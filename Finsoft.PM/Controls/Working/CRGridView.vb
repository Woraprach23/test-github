Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Friend Class CRGridView

    Public Property ParentType As AppEnums.DocType = AppEnums.DocType.BRD
    Public Property ParentID As Integer 
    Public Property IsAddForm As Boolean 
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentClientProduct As Data.ClientProduct

    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "CRID"
        CurrentGridControl = gcCR
        CurrentGridView = gvCR
        AutoLoad = False

    End Sub

    Protected Overrides Sub SetToolBarPermission()
        MyBase.SetToolBarPermission()

        If (IsAddForm) Then
            ShowAddPanel = False
        End If
    End Sub
     
    Protected Overrides Function GetDataSourceFromDB() As Object
        If (IsAddForm) Then
            Dim cr As New Data.CR
            cr.LoadDataSourceByClientProductID(CurrentClientProduct.ClientID, CurrentClientProduct.ProductID)
            Return cr.DataSource
        End If

        If (ParentType = AppEnums.DocType.Job) Then
            Dim job As New Data.Job(ParentID)
            Return job.CurrentCRList
        ElseIf ParentType = AppEnums.DocType.FSD Then
            Dim fsd As New Data.FSD(ParentID)
            Return fsd.CurrentCRList
        Else
            Dim cr As New Data.CR
            cr.LoadDataSource()
            Return cr.DataSource
        End If
         
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        If (ParentID > 0 And p_EditMode = AppEnums.EditMode.Edit) Then
            p_EditMode = AppEnums.EditMode.View
        End If
        Dim form As New CRForm(p_EditMode, p_id)
        form.ShowDialog() 
    End Sub

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim cr As New Data.CR
        If (ParentType = AppEnums.DocType.Job Or ParentType = AppEnums.DocType.FSD) Then
            cr = New Data.CR(p_id)
            If (ParentType = AppEnums.DocType.Job) Then
                cr.JobID = 0
            Else
                cr.FSDID = 0
            End If
            cr.LastUpdatedBy = ApplicationMeta.LoginUserID
            cr.DBInsertUpdate()
        Else
            cr.DBDelete(p_id)
        End If
        Return True
    End Function

    Protected Overrides Function LoadGridLookupControlWorking(p_value As Object) As Object
        Dim hashTable As New Hashtable
         
        Dim client As New Data.Client
        client.LoadDataSource()
        hashTable("client") = client.DataSource

        Dim product As New Data.Product
        product.LoadDataSource()
        hashTable("product") = product.DataSource
         
        Return hashTable
    End Function

    Protected Overrides Sub LoadGridLookupControlComplete(p_value As Object)
        Dim hashTable As Hashtable = TryCast(p_value, Hashtable)
        colClientID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("client"), "ClientID", "ClientCode")
        colProductID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("product"), "ProductID", "ProductCode")
    End Sub

    Protected Overrides Sub AddButtonClick()
        Dim form As New CRAddForm(ParentType, ParentID, CurrentClientProduct, GetCRIDs)
        If (form.ShowDialog() = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

    Private Function GetCRIDs() As List(Of Integer)
        Dim keyID As New List(Of Integer)
        For i As Integer = 0 To CurrentGridView.RowCount - 1
            Dim value = CurrentGridView.GetRowCellValue(i, "CRID")
            If (value IsNot Nothing) Then
                keyID.Add(CInt(value))
            End If
        Next
        Return keyID
    End Function

    Public Function IsNotDuplicatingFSD() As Boolean
        If IsHasValue("FSDID") Then
            Return MessageManager.Comfirmation(Common.AppEnums.MessageCode.M0017)
        End If
        Return True
    End Function

    Public Function IsNotDuplicatingJob() As Boolean
        If IsHasValue("JobID") Then
            Return MessageManager.Comfirmation(Common.AppEnums.MessageCode.M0017)
        End If
        Return True
    End Function

    Private Function IsHasValue(ByVal p_fieldName As String) As Boolean
        Dim arrValue = GetSelectedValues(p_fieldName)
        Dim max = arrValue.Max()
        Return max > 0
    End Function

End Class
