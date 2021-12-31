Public Class ProductGridView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "ProductID"
        CurrentGridControl = CurrentGridControl
        CurrentGridView = CurrentGridView

    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim client = New Data.Product
        client.LoadDataSource()
        Return client.DataSource
    End Function

End Class
