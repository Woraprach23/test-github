Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Friend Class JobGridView

    Public Property QuotationID As Integer
    Public Property IsAddForm As Boolean
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentClientProduct As Data.ClientProduct

    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "JobID"
        CurrentGridControl = gcJob
        CurrentGridView = gvJob
        AutoLoad = False
        CurrentGridView.OptionsDetail.EnableMasterViewMode = False

        If (IsAddForm) Then
            _gridview.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            _gridview.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
        End If

    End Sub

    Protected Overrides Sub AddButtonClick()
        Dim form As New JobAddForm(QuotationID, CurrentClientProduct, GetKeyIDs)
        If (form.ShowDialog() = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub
     
    Protected Overrides Sub SetToolBarPermission()
        MyBase.SetToolBarPermission()

        If (IsAddForm) Then
            ShowAddPanel = False
        End If
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim job As New Data.Job
        If (IsAddForm) Then 
            job.LoadDataSourceByClientProductID(CurrentClientProduct.ClientID, CurrentClientProduct.ProductID)
            Return job.DataSource
        End If
         
        If (QuotationID <> 0) Then
            job.LoadDataSource(QuotationID)
        Else
            job.LoadDataSource()
        End If

        Return job.DataSource
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        If (QuotationID <> 0 And p_EditMode = AppEnums.EditMode.Edit) Then
            p_EditMode = AppEnums.EditMode.View
        End If
        Dim form As New CRForm(p_EditMode, p_id)
        form.ShowDialog()
    End Sub

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim fsd As New Data.Job
        If (QuotationID <> 0) Then 
            fsd = New Data.Job(p_id)
            fsd.QuotationID = 0
            fsd.LastUpdatedBy = ApplicationMeta.LoginUserID
            fsd.DBInsertUpdate()
        Else
            fsd.DBDelete(p_id)
        End If
        Return True
    End Function


    Public Function IsNotDuplicatingQuotation() As Boolean
        If IsHasValue("QuotationID") Then
            Return MessageManager.Comfirmation(Common.AppEnums.MessageCode.M0021)
        End If
        Return True
    End Function

    Private Function IsHasValue(ByVal p_fieldName As String) As Boolean
        Dim arrValue = GetSelectedValues(p_fieldName)
        Dim max = arrValue.Max()
        Return max > 0
    End Function


    Private Function GetKeyIDs() As List(Of Integer)
        Dim keyID As New List(Of Integer)
        For i As Integer = 0 To CurrentGridView.RowCount - 1
            Dim value = CurrentGridView.GetRowCellValue(i, "JobID")
            If (value IsNot Nothing) Then
                keyID.Add(CInt(value))
            End If
        Next
        Return keyID
    End Function

End Class
