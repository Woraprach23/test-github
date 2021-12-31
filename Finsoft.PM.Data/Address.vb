Public Class Address
    Inherits MasterFile

    Public Property AddressID As Integer
    Public Property ClientID As Integer
    Public Property Address1 As String
    Public Property Address2 As String
    Public Property Address3 As String

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
        TableName = "Address"
        KeyField = "AddressID"
        ParentField = "ClientID"
    End Sub
#End Region

End Class
