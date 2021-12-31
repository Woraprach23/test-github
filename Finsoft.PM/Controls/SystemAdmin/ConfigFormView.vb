Public Class ConfigFormView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "ConfigID"
        CurrentGridControl = gcConfig
        CurrentGridView = gvConfig
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim Config = New Data.Config
        Config.LoadDataSource()
        Return Config.DataSource
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.Config
        obj.DBDelete(p_id)
        Return True
    End Function

    'Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
    '    Dim form As New ConfigForm(p_EditMode, p_id)
    '    Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
    '    form.Text = text
    '    If (form.ShowDialog = DialogResult.OK) Then
    '        LoadDataSource()
    '    End If
    'End Sub
End Class
