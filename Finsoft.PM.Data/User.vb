Public Class User
    Inherits MasterFile

    Public Property UserID As Integer
    Public Property Username As String
    Public Property PasswordHash As String
    Public Property PasswordSalt As String
    Public Property FullName As String
    Public Property Position As String
    Public Property RoleID As Integer?
    Public Property Remark As String
    Public Property IsLock As Boolean
    Public Property MustChangePassword As Boolean
    Public Property LastPasswordChanged As DateTime?
    Public Property LastSuccessfulLogin As DateTime?


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
        TableName = "User"
        KeyField = "UserID" 
    End Sub
#End Region

End Class
