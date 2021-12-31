Imports System.Collections

Public Class JobFormView

    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "JobID"
        CurrentGridControl = gcJob
        CurrentGridView = gvJob
        IsMutiSelect = True

        SetCustomButton1("Create Quotation", Nothing)

        gcJob.LevelTree.Nodes(0).RelationName = "Job_CR" 
        gvCR.ViewCaption = "CR"
        SetGridProperties(gvCR)

        AllowAdd = False
        AllowCopy = False
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim obj = New Data.Job
        Return obj.GetDataSet() 
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
 
        Dim obj As New Data.Job
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)

        Dim form As New JobForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

    Protected Overrides Sub CustomButtonClick(p_No As Integer)
        If (CheckGridViewUnselect()) Then
            Return
        End If

        If (IsMultiClient()) Then
            MessageManager.ShowError(Common.AppEnums.MessageCode.M0020, "Warning")
            Return
        End If

        If (IsNotDuplicatingQuotation()) Then
            If (ShowCreateQuotationForm()) Then
                LoadDataSource()
            End If
        End If
    End Sub

    Private Function IsMultiClient() As Boolean
        Dim strClient = GetSelectedStringValues("ClientCode")
        Dim clientCount = strClient.Distinct().ToList().Count
        Return clientCount > 1

    End Function

    Private Function IsNotDuplicatingQuotation() As Boolean
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

    Private Function ShowCreateQuotationForm() As Boolean
        Dim frm = New QuotationForm(Common.AppEnums.EditMode.Add, 0)
        frm.CurrentQuotation.ClientID = GetSelectedValues("ClientID")(0)
        frm.CurrentQuotation.ClientCode = GetSelectedStringValues("ClientCode")(0)
        frm.CurrentQuotation.ProductID = GetSelectedValues("ProductID")(0)
        frm.CurrentQuotation.ProductCode = GetSelectedStringValues("ProductCode")(0)
        frm.CurrentQuotation.CurrentJobList = GetJobList()
        If (frm.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Return True
        End If
        Return False
    End Function

    Private Function GetJobList() As List(Of Data.Job)
        Dim arrKeys = GetSelectedKeys()
        Dim cr = New Data.Job
        Dim result = cr.GetListBySelectedIDs(TryCast(DataSource, DataTable), arrKeys)
        Return result
    End Function

    'Public Overrides Sub ShowFormDetail(p_gv As DevExpress.XtraGrid.Views.Grid.GridView, p_EditMode As Common.AppEnums.EditMode)
    '    Dim keyField As String = "CRID"
    '    Dim keyID = p_gv.GetRowCellValue(p_gv.FocusedRowHandle, keyField)
    '    If (CInt(keyID) <= 0) Then
    '        Return
    '    End If

    '    ViewCRForm(CInt(keyID))
    'End Sub

    'Private Sub ViewCRForm(ByVal p_id As Integer)
    '    Dim form As New CRForm(Common.AppEnums.EditMode.View, p_id)
    '    Dim text = String.Format("{0} - {1}", form.Text, Common.AppEnums.EditMode.View)
    '    form.ShowDialog()
    'End Sub
     
End Class
