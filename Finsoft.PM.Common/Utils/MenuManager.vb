
Imports Finsoft.PM.Data
Imports Finsoft.PM.Common.AppEnums

Public Class RoleUiPermission
    Private Shared _uiPermission As UIPermission
    Public Shared Property CurerntUIPermissions As UIPermission
        Get
            If _uiPermission Is Nothing Then
                _uiPermission = New UIPermission()
                _uiPermission.LoadDataSource("UserRoleID", ApplicationMeta.UserRoleID)
            End If
            Return _uiPermission
        End Get
        Set(value As UIPermission)
            _uiPermission = value
        End Set
    End Property

    Public Shared Function GetPermission(ByVal p_userInterfaceID As Integer) As UiPermissionTypes
        Dim result As Integer = CurerntUIPermissions.GetPermission(p_userInterfaceID)
        Return CType([Enum].Parse(GetType(UiPermissionTypes), result), UiPermissionTypes)
    End Function

    Public Shared Function GetPermission(ByVal p_UiClassName As String) As UiPermissionTypes
        Dim result As Integer = CurerntUIPermissions.GetPermission(p_UiClassName)
        Return CType([Enum].Parse(GetType(UiPermissionTypes), result), UiPermissionTypes)
    End Function

    Public Shared Function GetUserinterfaceID(ByVal p_UiClassName As String) As Integer
        Dim result As Integer = CurerntUIPermissions.GetIDByClassName(p_UiClassName)
        Return result
    End Function

    Public Shared Function GetMenuCode(ByVal p_UiClassName As String) As MenuCode
        Dim id As Integer = CurerntUIPermissions.GetIDByClassName(p_UiClassName)
        Dim value As MenuCode = CType(MenuCode.ToObject(GetType(MenuCode), id), MenuCode)
        Return value
    End Function

    Public Shared Function GetUserUIPermissionByClassName(ByVal p_UiClassName As String) As UIPermission
        Dim selectRow As DataRow = CurerntUIPermissions.SelectRowByClassName(p_UiClassName)
        Dim ui As New UIPermission
        If selectRow IsNot Nothing Then
            ui.Mapping(selectRow)
        End If
        Return ui
    End Function

End Class
