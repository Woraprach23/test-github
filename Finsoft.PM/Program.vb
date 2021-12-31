 
Imports System.Globalization
Imports System.Threading

Module Program
    'Friend f_LoginUser As Data.User
    Friend f_UserIsAuthenticated As Boolean = False
    Friend f_frmMain As W

    Sub Main()

        ModuleInitialize.InitialAppSettings()
        f_UserIsAuthenticated = False

        If Not ModuleInitialize.TestConnectionString() Then
            Return
        End If


        f_frmMain = New W()

        Try
            Application.Run(f_frmMain)
        Catch exMain As Exception
            MessageBox.Show("Unexpected Error.  Please contact support@finsoft", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        'Return
        'Dim frmLogin As New FormLogin()
        'frmLogin.ShowDialog()
        'frmLogin.Close()

        'If (f_UserIsAuthenticated = False) Or (f_LoginUser Is Nothing) Then
        '    Application.Exit()
        '    Exit Sub
        'End If

        ''KJ, Prefer to check after authenticated, so last success login is ok!!!
        '' check if user must change password
        'If f_LoginUser.mustChangePassword And f_LoginUser.LoginUserName <> "Admin" Then
        '    MessageBox.Show("Must Change Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Dim frmChgPwd As New FormChangePassword()
        '    frmChgPwd.StartPosition = FormStartPosition.CenterScreen

        '    If frmChgPwd.ShowDialog() <> DialogResult.OK Then
        '        f_UserIsAuthenticated = False
        '        Application.Exit()
        '        Exit Sub
        '    End If
        '    frmChgPwd.Close()

        '    ' check password expire after lifetime
        'ElseIf DateDiff(DateInterval.Day, f_LoginUser.LastPasswordChanged, Finsoft.NCR.Common.ApplicationMeta.ServerDate) > Finsoft.NCR.Common.ApplicationMeta.Setting.PasswordLifeTime() Then
        '    MessageBox.Show("Password is expired, must change password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Dim frmChgPwd As New FormChangePassword()
        '    If frmChgPwd.ShowDialog() <> DialogResult.OK Then
        '        f_UserIsAuthenticated = False
        '        Application.Exit()
        '        Exit Sub
        '    End If
        '    frmChgPwd.Close()
        'End If

        'If (f_UserIsAuthenticated AndAlso (f_LoginUser IsNot Nothing)) Then

        '    ' Logging
        '    ' Finsoft.NCR.Common.AppAuditLog.InsertUserAuditLog(Finsoft.NCR.Common.AuditActivityTypes.Login, f_LoginUser.LoginUserID, String.Empty, Finsoft.NCR.Common.AuditCriticality.Medium)

        '    f_frmMain = New FormMain()

        '    Try
        '        Application.Run(f_frmMain)
        '    Catch exMain As Exception
        '        MessageBox.Show("Unexpected Error.  Please contact support@finsoft", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Finsoft.NCR.Common.ErrorLogger.WriteToErrorLog(exMain.Message(), exMain.ToString(), "Main", exMain.Source, String.Empty)
        '        Application.Exit()
        '    End Try
        'End If
    End Sub
End Module

 
