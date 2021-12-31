<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
    Inherits PM.UI.FormBase

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
        Me.lupIsInactive = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lupRole = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbUserRole = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        CType(Me.lupIsInactive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lupRole.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(434, 4)
        '
        'lupIsInactive
        '
        Me.lupIsInactive.Location = New System.Drawing.Point(131, 90)
        Me.lupIsInactive.Name = "lupIsInactive"
        Me.lupIsInactive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lupIsInactive.Size = New System.Drawing.Size(100, 20)
        Me.lupIsInactive.TabIndex = 187
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(49, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 191
        Me.LabelControl5.Text = "Status"
        '
        'lupRole
        '
        Me.lupRole.Location = New System.Drawing.Point(131, 64)
        Me.lupRole.Name = "lupRole"
        Me.lupRole.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lupRole.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.lupRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lupRole.Size = New System.Drawing.Size(234, 20)
        Me.lupRole.TabIndex = 186
        '
        'lbUserRole
        '
        Me.lbUserRole.Location = New System.Drawing.Point(49, 67)
        Me.lbUserRole.Name = "lbUserRole"
        Me.lbUserRole.Size = New System.Drawing.Size(46, 13)
        Me.lbUserRole.TabIndex = 190
        Me.lbUserRole.Text = "User Role"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(49, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 189
        Me.LabelControl2.Text = "FullName"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFullName.Location = New System.Drawing.Point(131, 38)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Properties.MaxLength = 250
        Me.txtFullName.Size = New System.Drawing.Size(445, 20)
        Me.txtFullName.TabIndex = 185
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(49, 15)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl9.TabIndex = 188
        Me.LabelControl9.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Location = New System.Drawing.Point(131, 12)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.MaxLength = 250
        Me.txtUserName.Size = New System.Drawing.Size(207, 20)
        Me.txtUserName.TabIndex = 184
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelControl3.Location = New System.Drawing.Point(49, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 194
        Me.LabelControl3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(131, 117)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(207, 20)
        Me.txtPassword.TabIndex = 193
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(588, 204)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lupIsInactive)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lupRole)
        Me.Controls.Add(Me.lbUserRole)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "UserForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User"
        Me.Controls.SetChildIndex(Me.txtUserName, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.txtFullName, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.lbUserRole, 0)
        Me.Controls.SetChildIndex(Me.lupRole, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.lupIsInactive, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        CType(Me.lupIsInactive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lupRole.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lupIsInactive As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lupRole As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbUserRole As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit

End Class
