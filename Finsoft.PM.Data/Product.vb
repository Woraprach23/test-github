Public Class Product
    Inherits MasterFile

    Public Property ProductID As Integer
    Public Property ProductCode As String
    Public Property ProductName As String
    Public Property Description As String

#Region "Contructor"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal p_ID As Integer)
        MyBase.New(p_ID)
    End Sub
#End Region

#Region "Protected Overrides"
    Protected Overrides Sub SetMasterProperties()
        TableName = "Product"
        KeyField = "ProductID"
    End Sub
#End Region

End Class
