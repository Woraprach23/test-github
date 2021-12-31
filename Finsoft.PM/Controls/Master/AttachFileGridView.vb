Imports System.Collections
Imports Finsoft.PM.Common
Imports System.ComponentModel
Imports System.IO

Public Class AttachFileGridView
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentFile As Data.File
    Public Property ParentType As AppEnums.DocType = AppEnums.DocType.None
    Public Property DocType As AppEnums.DocType = AppEnums.DocType.None
    Public Property ParentID As Integer = 0
    Public Property IsFixDocumentType As Boolean = False

    Public Overrides Sub RegisterGridControl()
        Me.CurrentGridControl = gcFiles
        Me.CurrentGridView = gvFiles
        KeyFieldName = "FileID"
        _isRegisteredGrid = True
    End Sub

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.File
        obj.DBDelete(p_id)
        Return True
    End Function

    Protected Overrides Function GetDataSourceFromDB() As Object
        If (CurrentFile Is Nothing) Then
            CurrentFile = New Data.File
        End If

        CurrentFile.LoadDataSourceByReferenceID(ParentType, ParentID)
        Return CurrentFile.DataSource

    End Function

    Protected Overrides Function LoadGridLookupControlWorking(p_value As Object) As Object
        Dim hashTable As New Hashtable
        Dim docttype As New Data.Doctype
        docttype.LoadDataSource()
        hashTable("Doctype") = docttype.DataSource
        Return hashTable
    End Function

    Protected Overrides Sub LoadGridLookupControlComplete(p_value As Object)
        Dim hashTable As Hashtable = TryCast(p_value, Hashtable)
        colDocTypeID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("Doctype"), "DoctypeID", "Doctype")
        colReferenceTypeID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("Doctype"), "DoctypeID", "Doctype")
    End Sub


    Protected Overrides Sub GridDoubleClick()
        Dim id = GetFocusRowID()
        If (id = 0) Then
            Return
        End If

        Dim f As New FileManager
        Dim strFileName As String = GetFocusRowCellValue("FileName").ToString
        Dim strExtension As String = GetFocusRowCellValue("Extension").ToString
        Dim buffer = GetFileData(id)
        f.ViewFile(buffer, strFileName, strExtension)

    End Sub
     
    Private Function GetFileData(ByVal p_id As Integer) As Byte()
        Dim dt = TryCast(DataSource, DataTable)
        If (dt Is Nothing) Then
            Return Nothing
        End If

        Dim rows = dt.Select("FileID=" + p_id.ToString)
        If (rows.Length > 0) Then
            Dim FileData As Byte() = TryCast(rows(0)("FileData"), Byte())
            Return FileData
        End If

        Return Nothing
    End Function

    Public Overrides Sub ShowForm(p_EditMode As AppEnums.EditMode, p_id As Integer)
        If (EditMode <> AppEnums.EditMode.Add) Then
            EditMode = AppEnums.EditMode.View
        End If

        Dim form As New CAAttachFileForm(p_EditMode, p_id)
        form.ReferenceID = ParentID
        form.ReferenceType = Me.ParentType
        form.DocumentType = Me.DocType
        form.FixDocumentType = IsFixDocumentType
        If (form.ShowDialog = DialogResult.OK) Then
            For Each file In form.CurrentFileList
                If (ParentID > 0) Then
                    LoadDataSource()
                Else
                    CurrentFile.UpdateRow(file)
                    DataSource = CurrentFile.DataSource
                End If
            Next
        End If

    End Sub
End Class
