Public Class ClientProduct
    Inherits MasterFile
    Public Property ClientProductID As Integer
    Public Property ClientID As Integer
    Public Property ProductID As Integer
    Public Property ClientCode As String
    Public Property ProductCode As String

    Protected Overrides Sub SetMasterProperties()
        TableName = "ClientProduct"
        KeyField = "ClientProductID"

    End Sub
End Class
