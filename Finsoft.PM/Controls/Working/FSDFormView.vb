Imports System.Collections

Public Class FSDFormView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "FSDID"
        CurrentGridControl = gcFSD
        CurrentGridView = gvFSD

        gcFSD.LevelTree.Nodes(0).RelationName = "FSD_CR"
        gcFSD.LevelTree.Nodes(1).RelationName = "FSD_File"
        gvCR.ViewCaption = "CR"
        gvFile.ViewCaption = "File"
        SetGridProperties(gvCR)
        SetGridProperties(gvFile)

        AllowAdd = False
        AllowCopy = False
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim obj = New Data.FSD
        Return obj.GetDataSet
    End Function


    Public Overrides Sub ShowFormDetail(p_gv As DevExpress.XtraGrid.Views.Grid.GridView, p_EditMode As Common.AppEnums.EditMode)
        Dim keyField As String = IIf(p_gv.Name = "gvCR", "CRID", "FileID")
        Dim keyID = p_gv.GetRowCellValue(p_gv.FocusedRowHandle, keyField)
        If (CInt(keyID) <= 0) Then
            Return
        End If

        If (p_gv.Name = "gvCR") Then
            ViewCRForm(CInt(keyID))
        Else
            ViewFiles(CInt(keyID))
        End If
    End Sub


    Private Sub ViewCRForm(ByVal p_id As Integer)
        Dim form As New CRForm(Common.AppEnums.EditMode.View, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, Common.AppEnums.EditMode.View)
        form.ShowDialog()
    End Sub

    Private Sub ViewFiles(ByVal p_id As Integer)
        Dim fm As New FileManager
        fm.ViewFile(p_id)
    End Sub

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.FSD
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)

        Dim form As New FSDForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

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

    End Sub

    'Protected Overrides Function LoadGridLookupControlWorking(p_value As Object) As Object
    '    Dim hashTable As New Hashtable

    '    Dim client As New Data.Client
    '    client.LoadDataSource()
    '    hashTable("client") = client.DataSource

    '    Dim product As New Data.Product
    '    product.LoadDataSource()
    '    hashTable("product") = product.DataSource

    '    Return hashTable
    'End Function

    'Protected Overrides Sub LoadGridLookupControlComplete(p_value As Object)
    '    Dim hashTable As Hashtable = TryCast(p_value, Hashtable)
    '    colClientID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("client"), "ClientID", "ClientCode")
    '    colProductID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("product"), "ProductID", "ProductCode")

    'End Sub
End Class
