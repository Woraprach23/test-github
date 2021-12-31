Public Class ClientFromView

    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "ClientID"
        CurrentGridControl = gcClient
        CurrentGridView = gvClient
    End Sub


    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim client = New Data.Client
        client.LoadDataSource()
        Return client.DataSource
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.Client
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        Dim form As New ClientForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub
End Class
