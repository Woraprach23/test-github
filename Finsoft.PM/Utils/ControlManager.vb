Public Class ControlManager

    'Public Function GetUserControl(ByVal p_menuClassName As String, ByVal p_caption As String, ByVal p_image As Image, ByVal p_permissionType As String) As ControlGridViewBase
    '    Try
    '        'Dim _currentMenu = New Data.CorporateAction.URSA_CA_Config_Menu
    '        '_currentMenu.LoadDataByUIClassName(p_menuClassName)
    '        'If (_currentMenu.URSA_CA_Config_MenuID <= 0) Then
    '        '    Dim errorMessage As String = String.Format("{0} is not found on Custodian Menu Config.", p_menuClassName)
    '        '    Throw New Exception(errorMessage)
    '        'End If

    '        'Dim p_menuCode As AppEnums.MenuCode = _currentMenu.URSA_CA_Config_MenuID
    '        Dim uc = GetUserControl(p_menuCode, p_caption, p_image, p_permissionType)
    '        'If (uc IsNot Nothing) Then
    '        '    uc.CaptionImage = p_image
    '        '    uc.CurrentMenu = _currentMenu

    '        '    uc.AccessibleDescription = p_permissionType
    '        '    uc.IsView = p_permissionType.Contains("View")
    '        '    uc.IsModify = p_permissionType.Contains("Modify")
    '        '    uc.IsApprove = p_permissionType.Contains("Approve")
    '        '    uc.IsProcess = p_permissionType.Contains("Process")
    '        '    ApplicationMeta.CurrentMenuCode = _currentMenu.URSA_CA_Config_MenuID

    '        Return uc
    '        Else
    '        Throw New NotImplementedException()
    '        End If
    '    Catch ex As Exception
    '        LogManager.InsertLog(AppEnums.LogType.Access, ex.Message)
    '        Throw ex
    '    End Try

    'End Function



End Class
