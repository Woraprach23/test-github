Public Class ApplicationMeta

    Public Shared LoginUserID As Integer = 1
    Public Shared UserRoleID As Integer = 1
    Public Shared LoginUserName As String
    Public Shared IPAddress As String
    Public Shared ComputerName As String
    Private Shared _CurrentDate As Date = DateTime.MinValue
    Public Shared ReadOnly Property MaxDate As DateTime
        Get
            Return DateTime.MaxValue
        End Get
    End Property

    Public Shared ReadOnly Property MinDate As DateTime
        Get
            Return DateTime.MinValue
        End Get
    End Property

    Public Shared Function ServerDate() As DateTime
        Return Data.DBProc.ServerDate()
    End Function

    Private Shared _menuCode As AppEnums.MenuCode = AppEnums.MenuCode.None
    Public Shared Property CurrentMenuCode As AppEnums.MenuCode
        Get
            Return _menuCode
        End Get
        Set(value As AppEnums.MenuCode)
            _previousmenuCode = _menuCode
            _menuCode = value
        End Set
    End Property

    Private Shared _previousmenuCode As AppEnums.MenuCode = AppEnums.MenuCode.None
    Public Shared Property PreviousMenuCode As AppEnums.MenuCode
        Get
            Return _previousmenuCode
        End Get
        Set(value As AppEnums.MenuCode)
            _previousmenuCode = value
        End Set
    End Property

    Public Shared Property PermissionType As AppEnums.UiPermissionTypes

End Class
