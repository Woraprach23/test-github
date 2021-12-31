<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserFromView
    Inherits PM.UI.FormViewMaster

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gcUser = New DevExpress.XtraGrid.GridControl()
        Me.gvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoginName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhoneNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLoggedIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastSuccessfulLogin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLockOutTime = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcUser)
        Me.PanelControl2.Controls.SetChildIndex(Me.gcUser, 0)
        '
        'gcUser
        '
        Me.gcUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.gcUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUser.Location = New System.Drawing.Point(2, 2)
        Me.gcUser.MainView = Me.gvUser
        Me.gcUser.Name = "gcUser"
        Me.gcUser.Size = New System.Drawing.Size(830, 264)
        Me.gcUser.TabIndex = 6
        Me.gcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUser})
        '
        'gvUser
        '
        Me.gvUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserName, Me.colUserGroupName, Me.colLoginName, Me.colEmailAddress, Me.colPhoneNo, Me.colIsLoggedIn, Me.colLastSuccessfulLogin, Me.colLockOutTime})
        Me.gvUser.GridControl = Me.gcUser
        Me.gvUser.Name = "gvUser"
        Me.gvUser.OptionsView.ColumnAutoWidth = False
        Me.gvUser.OptionsView.ShowGroupPanel = False
        '
        'colUserName
        '
        Me.colUserName.Caption = "User Name"
        Me.colUserName.FieldName = "LoginUserName"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.Visible = True
        Me.colUserName.VisibleIndex = 1
        Me.colUserName.Width = 141
        '
        'colUserGroupName
        '
        Me.colUserGroupName.Caption = "Group"
        Me.colUserGroupName.FieldName = "UserGroupName"
        Me.colUserGroupName.Name = "colUserGroupName"
        Me.colUserGroupName.Visible = True
        Me.colUserGroupName.VisibleIndex = 2
        Me.colUserGroupName.Width = 126
        '
        'colLoginName
        '
        Me.colLoginName.Caption = "Login Name"
        Me.colLoginName.FieldName = "LoginName"
        Me.colLoginName.Name = "colLoginName"
        Me.colLoginName.Visible = True
        Me.colLoginName.VisibleIndex = 0
        Me.colLoginName.Width = 132
        '
        'colEmailAddress
        '
        Me.colEmailAddress.Caption = "Email Address"
        Me.colEmailAddress.FieldName = "EmailAddress"
        Me.colEmailAddress.Name = "colEmailAddress"
        Me.colEmailAddress.Visible = True
        Me.colEmailAddress.VisibleIndex = 3
        Me.colEmailAddress.Width = 199
        '
        'colPhoneNo
        '
        Me.colPhoneNo.Caption = "Phone No"
        Me.colPhoneNo.FieldName = "PhoneNo"
        Me.colPhoneNo.Name = "colPhoneNo"
        Me.colPhoneNo.Visible = True
        Me.colPhoneNo.VisibleIndex = 4
        Me.colPhoneNo.Width = 157
        '
        'colIsLoggedIn
        '
        Me.colIsLoggedIn.AppearanceCell.Options.UseTextOptions = True
        Me.colIsLoggedIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsLoggedIn.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsLoggedIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsLoggedIn.Caption = "Logged In"
        Me.colIsLoggedIn.FieldName = "IsLoggedIn"
        Me.colIsLoggedIn.Name = "colIsLoggedIn"
        Me.colIsLoggedIn.Visible = True
        Me.colIsLoggedIn.VisibleIndex = 5
        Me.colIsLoggedIn.Width = 67
        '
        'colLastSuccessfulLogin
        '
        Me.colLastSuccessfulLogin.AppearanceCell.Options.UseTextOptions = True
        Me.colLastSuccessfulLogin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastSuccessfulLogin.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastSuccessfulLogin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastSuccessfulLogin.Caption = "Login Time"
        Me.colLastSuccessfulLogin.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt"
        Me.colLastSuccessfulLogin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastSuccessfulLogin.FieldName = "LastSuccessfulLogin"
        Me.colLastSuccessfulLogin.Name = "colLastSuccessfulLogin"
        Me.colLastSuccessfulLogin.Visible = True
        Me.colLastSuccessfulLogin.VisibleIndex = 6
        Me.colLastSuccessfulLogin.Width = 140
        '
        'colLockOutTime
        '
        Me.colLockOutTime.AppearanceCell.Options.UseTextOptions = True
        Me.colLockOutTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLockOutTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colLockOutTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLockOutTime.Caption = "Logout Time"
        Me.colLockOutTime.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt"
        Me.colLockOutTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLockOutTime.FieldName = "LogoutTime"
        Me.colLockOutTime.Name = "colLockOutTime"
        Me.colLockOutTime.Visible = True
        Me.colLockOutTime.VisibleIndex = 7
        Me.colLockOutTime.Width = 155
        '
        'UserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Name = "UserView"
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoginName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhoneNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoggedIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastSuccessfulLogin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLockOutTime As DevExpress.XtraGrid.Columns.GridColumn

End Class
