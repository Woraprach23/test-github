Public Class ReportLayoutFormView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "ReportLayoutID"
        CurrentGridControl = gcReportLayout
        CurrentGridView = gvReportLayout
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim Contract = New Data.ReportLayout
        Contract.LoadDataSource()
        Return Contract.DataSource
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.ReportLayout
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        Dim form As New ReportLayoutForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

    Protected Overrides Function LoadGridLookupControlWorking(p_value As Object) As Object
        Return Data.ConfigService.Config(Data.DataEnums.ConfigGroup.ReportType)
    End Function

    Protected Overrides Sub LoadGridLookupControlComplete(p_value As Object)
        colReportTypeID.ColumnEdit = New CustomRepositoryLookupConfig(p_value)
    End Sub
End Class
