Imports System.Collections

Public Class CRFormView

 
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "CRID"
        CurrentGridControl = gcCR
        CurrentGridView = gvCR


        SetCustomButton1("Create FSD", Nothing)
        SetCustomButton2("Create Job", Nothing)

        'SetCustomButton1("Create FSD", ImageCollection1.Images(0))
        'SetCustomButton2("Create Job", ImageCollection1.Images(1))
    End Sub

    
     
    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim Contract = New Data.CR
        Contract.LoadDataSource()
        Return Contract.DataSource
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.CR
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)

        Dim form As New CRForm(p_EditMode, p_id)
        If (p_EditMode = Common.AppEnums.EditMode.Clone) Then
            Dim cr = New Data.CR
            cr.Clone(p_id)
            form.CurrentCR = cr
        End If
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

        If (IsMultiProductOrClient()) Then
            MessageManager.ShowError(Common.AppEnums.MessageCode.M0019, "Warning")
            Return
        End If
         
        If (p_No = 1) Then
            If (IsNotDuplicatingFSD()) Then
                If (ShowCreateFSDForm()) Then
                    LoadDataSource()
                End If
            End If
        Else
            If (IsNotDuplicatingJob()) Then
                If (ShowCreateJobForm()) Then
                    LoadDataSource()
                End If
            End If
        End If
    End Sub
    
    Private Function ShowCreateJobForm() As Boolean
        Dim frm = New JobForm(Common.AppEnums.EditMode.Add, 0)
        frm.CurrentJob.ClientID = GetSelectedValues("ClientID")(0)
        frm.CurrentJob.ProductID = GetSelectedValues("ProductID")(0)
        frm.CurrentJob.ClientCode = GetSelectedStringValues("ClientCode")(0)
        frm.CurrentJob.ProductCode = GetSelectedStringValues("ProductCode")(0)
        frm.CurrentJob.CurrentCRList = GetCRList()
        If (frm.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Return True
        End If
        Return False
    End Function

    Private Function ShowCreateFSDForm() As Boolean
        Dim frm = New FSDForm(Common.AppEnums.EditMode.Add, 0)
        frm.CurrentFSD.ClientID = GetSelectedValues("ClientID")(0)
        frm.CurrentFSD.ProductID = GetSelectedValues("ProductID")(0)
        frm.CurrentFSD.ClientCode = GetSelectedStringValues("ClientCode")(0)
        frm.CurrentFSD.ProductCode = GetSelectedStringValues("ProductCode")(0)
        frm.CurrentFSD.CurrentCRList = GetCRList()
        If (frm.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Return True
        End If
        Return False
    End Function

    Private Function IsMultiProductOrClient() As Boolean
        Dim strClient = GetSelectedValues(colClientCode.FieldName)
        Dim clientCount = strClient.Distinct().ToList().Count
        If (clientCount > 1) Then
            Return False
        End If

        Dim strProduct = GetSelectedValues(colProductCode.FieldName)
        Dim ProductCount = strProduct.Distinct().ToList().Count
        Return ProductCount > 1

    End Function
     
    Private Function GetCRList() As List(Of Data.CR)
        Dim arrKeys = GetSelectedKeys()
        Dim cr = New Data.CR
        Dim result = cr.GetListBySelectedIDs(TryCast(DataSource, DataTable), arrKeys)
        Return result
    End Function
   

    Private Function IsNotDuplicatingFSD() As Boolean
        If IsHasValue("FSDID") Then
            Return MessageManager.Comfirmation(Common.AppEnums.MessageCode.M0017)
        End If
        Return True
    End Function

    Private Function IsNotDuplicatingJob() As Boolean
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

    'Private Function GetSelectDataSource() As DataTable

    '    If (DataSource Is Nothing) Then
    '        Return Nothing
    '    End If

    '    Dim arrKeys = GetSelectedKeys()
    '    Dim strKeys = String.Join(",", arrKeys)
    '    Dim rowFilter As String = String.Format("CRID IN ({0})", strKeys)
    '    Dim dt = TryCast(DataSource, DataTable)
    '    dt.DefaultView.RowFilter = rowFilter
    '    Dim temp = dt.DefaultView.ToTable
    '    Dim result = temp.co
    '    Return result
    'End Function
     
End Class
