Public Class UserRole
    Inherits MasterFile

    Public Property UserRoleID As Integer
    Public Property UserRoleCode As String
    Public Property UserRoleName As String
    Public Property Description As String
    Public Property IsActve As Boolean

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
        TableName = "UserRole"
        KeyField = "UserRoleID"
    End Sub
#End Region


#Region "Reference Table"
    Private _UIPermission As UIPermission
    Public Property CurrentUIPermissions As UIPermission
        Get
            If _UIPermission Is Nothing Then
                _UIPermission = New UIPermission()
                _UIPermission.LoadDataSource("UserRoleID", UserRoleID)
            End If
            Return _UIPermission

        End Get
        Set(value As UIPermission)
            _UIPermission = value
        End Set
    End Property

    Private _UserInterface As UserInterface
    Public Property CurrentUserInterface As UserInterface
        Get
            If _UserInterface Is Nothing Then
                _UserInterface = New UserInterface()
                _UserInterface.LoadDataSource()
            End If
            Return _UserInterface

        End Get
        Set(value As UserInterface)
            _UserInterface = value
        End Set
    End Property

#End Region


End Class
