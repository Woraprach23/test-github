Public Class QuotationFormView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "QuotationID"
        CurrentGridControl = gcQuotation
        CurrentGridView = gvQuotation
        IsMutiSelect = False
        gvJob.ViewCaption = "Job"

        AddHandler gvJob.CustomDrawCell, AddressOf gvJob_CustomDrawCell

        SetGridProperties(gvJob)

        SetCustomButton1("Create Contract", Nothing)

        AllowAdd = False
        AllowCopy = False
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim obj = New Data.Quotation
        Return obj.GetDataSet
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.Quotation
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)

        Dim form As New QuotationForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

    Public Overrides Sub ShowFormDetail(p_gv As DevExpress.XtraGrid.Views.Grid.GridView, p_EditMode As Common.AppEnums.EditMode)

        If (p_gv.Name = gvJob.Name) Then
            Dim id = p_gv.GetRowCellValue(p_gv.FocusedRowHandle, "JobID")
            If (id Is Nothing OrElse id Is DBNull.Value) Then
                Dim form = New FSDForm(Common.AppEnums.EditMode.View, CInt(id))
                form.ShowDialog()
            End If
        End If
    End Sub


    Private Sub gvJob_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)

        Dim grid = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If (e.RowHandle < 0 Or grid.IsGroupRow(e.RowHandle) OrElse e.CellValue Is DBNull.Value OrElse e.CellValue Is Nothing) Then
            Return
        End If

        If (e.Column.FieldName = "RowNo") Then
            e.DisplayText = String.Format("{0:n0}", e.RowHandle + 1)
        End If
  
    End Sub


    Protected Overrides Sub CustomButtonClick(p_No As Integer)
        Dim id = GetFocusRowID()
        If (id = 0) Then
            Return
        End If

        If (p_No = 1) Then
            Dim contractID = GetContractID()
            If (contractID > 0) Then
                If (Not MessageManager.Comfirmation(Common.AppEnums.MessageCode.M0023)) Then
                    Return
                End If

                ShowContractForm(Common.AppEnums.EditMode.View, contractID, id)
            Else
                ShowContractForm(Common.AppEnums.EditMode.Add, 0, id)
            End If


        End If
    End Sub

    Private Sub ShowContractForm(ByVal p_editMode As Common.AppEnums.EditMode, ByVal p_id As Integer, ByVal p_parentID As Integer)
        Dim form As New ContractForm(p_editMode, p_id, p_parentID)
        form.ShowDialog()
    End Sub

    Private Function GetContractID() As Integer
        Dim id = GetFocusRowCellValue("ContractID")
        If (id IsNot Nothing And id IsNot DBNull.Value) Then
            Return CInt(id)
        End If
        Return 0
    End Function
End Class
