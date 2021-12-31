Imports Finsoft.PM.Common

Public Class FormLogIn

    Private _systemDate As Date
    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' lbVersion.Text = "Rigel v." & Application.ProductVersion.ToString '& " @KSAM 2013"
        _systemDate = ApplicationMeta.ServerDate
        GroupControl1.Text = String.Format("{0} (V.{1})", "NCR Management", Application.ProductVersion)
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Try
            If DoLogIn() Then
                Me.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, True, Me.Text, btnLogin.Text, 0)
        End Try
    End Sub
 
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Function DoLogIn() As Boolean
        Dim strUserName As String = txtUserName.Text
        Dim strPassword As String = txtPassword.Text
        Dim strError As String
        Dim clsUser As New Data.User

        If String.IsNullOrEmpty(strUserName) Then
            DisplayErrorMessage("Please input username")
            Return False
        End If

        If String.IsNullOrEmpty(strPassword) Then
            DisplayErrorMessage("Please input password")
            Return False
        End If

        clsUser.LoadData("LoginName", strUserName)
        If clsUser.UserID <= 0 Then
            DisplayErrorMessage("Incorrect User Name.")
            txtUserName.Focus()
            'AppAuditLog.InsertUserAuditLog(AuditActivityTypes.Login_Failed, 0, "Use LoginName: " & strUserName & ", Invalid User Name", AuditCriticality.High)
            Return False
        End If

        ApplicationMeta.LoginUserID = clsUser.UserID
        ApplicationMeta.IPAddress = ModuleInitialize.GetIPAddress
        ApplicationMeta.ComputerName = ModuleInitialize.GetComputerName

        'If clsUser.isSuspended Or clsUser.isInactive Then
        '    strError = "Use LoginName: " & strUserName & ", User is inactive or suspended"
        '    DisplayErrorMessage(strError)
        '    Return False
        'End If


        ''TODO: Check start date also
        'If clsUser.StartDate > _systemDate Then         ' ApplicationMeta.CurrentDate()
        '    strError = "Use LoginName: " & strUserName & ", User start date greater than today"
        '    DisplayErrorMessage(strError)

        '    'TODO: Logging to admin that login before start date not allowed so user doesn't confused why
        '    'AppAuditLog.InsertUserAuditLog(AuditActivityTypes.Login_Failed, clsUser.LoginUserID, strError, AuditCriticality.High)
        '    Return False
        'End If

        'If clsUser.isLogin Then
        '    strError = "Use LoginName: " & strUserName & " is loggin another pc."
        '    DisplayErrorMessage(strError)
        '    'AppAuditLog.InsertUserAuditLog(AuditActivityTypes.Login_Failed, clsUser.LoginUserID, strError, AuditCriticality.High)
        '    Return False
        'End If

        'If clsUser.Username = "Admin" And strPassword = "mt62666!" Then
        '    f_LoginUser = clsUser
        '    clsUser.UpdatedBy = clsUser.LoginUserID
        '    'clsUser.Update()
        'Else
        '    ' Compare password here
        '    Dim currentHash As String = Common.PasswordHelper.GenerateHashPassword(strPassword, clsUser.PasswordSalt)
        '    If clsUser.PasswordHash <> currentHash Then
        '        strError = "Incorrect Password"
        '        DisplayErrorMessage(strError)
        '        txtPassword.Focus()

        '        clsUser.LastLoginFailed = ApplicationMeta.ServerDate
        '        clsUser.NoOfLoginFailed += 1
        '        clsUser.ThresholdCounter += 1

        '        If clsUser.NoOfLoginFailed > ApplicationMeta.Setting.MaxNoLoginFailed() Then
        '            clsUser.isSuspended = True
        '            'clsUser.SuspendedCode = UserSuspendedCodes.ExceedMaxLoginFailed.ToString()
        '            clsUser.SuspendedTime = ApplicationMeta.ServerDate
        '            strError = String.Format("You have reached a limit of login failed ({0} times)", ApplicationMeta.Setting.MaxNoLoginFailed())
        '            DisplayErrorMessage(strError)
        '        End If
        '        ' set to allow update

        '        clsUser.LastUpdatedBy = clsUser.UserID
        '        clsUser.DBInsertUpdate()

        '        'If clsUser.isSuspended Then Me.Close()

        '        Return False
        '    End If

        'End If


        ''Login Success
        'clsUser.isLogin = True
        'clsUser.LastSuccessfulLogin = ApplicationMeta.ServerDate()
        'clsUser.NoOfLoginFailed = 0
        'clsUser.ThresholdCounter = 0
        'clsUser.UpdatedBy = clsUser.LoginUserID
        'clsUser.Update()
        ''AppAuditLog.InsertUserAuditLog(AuditActivityTypes.Login, clsUser.LoginUserID, "LoginName: " & strUserName & " is logged in.", AuditCriticality.High)

        'f_UserIsAuthenticated = True
        'f_LoginUser = clsUser
        Return True
    End Function



    Private Sub DisplayErrorMessage(ByVal p_message As String)
        MessageBox.Show(p_message, "Login failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    End Sub

End Class