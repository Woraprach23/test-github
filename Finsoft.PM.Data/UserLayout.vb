Public Class UserLayout
    Inherits MasterFile

    Public Property UserLayoutID As Integer
    Public Property UserID As Integer
    Public Property ControlName As String
    Public Property LayoutString As String

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
        TableName = "UserLayout"
        KeyField = "UserLayoutID"
    End Sub
#End Region

    Public Sub New(ByVal p_userID As Integer, ByVal p_controlName As String)
        MyBase.New()
        LoadDataByUser(p_userID, p_controlName)
        UserID = p_userID
        ControlName = p_controlName
    End Sub

    Private Sub LoadDataByUser(ByVal p_userID As Integer, ByVal p_controlName As String)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add("UserID", p_userID)
        dic.Add("ControlName", p_controlName)
        MyBase.LoadData(dic)
    End Sub

End Class
