<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBase
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBase))
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelButtons = New DevExpress.XtraEditors.PanelControl()
        Me.btnCustom2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustom = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'bgWorker
        '
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.btnCustom2)
        Me.PanelButtons.Controls.Add(Me.btnCustom)
        Me.PanelButtons.Controls.Add(Me.btnClose)
        Me.PanelButtons.Controls.Add(Me.btnSave)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtons.Location = New System.Drawing.Point(0, 281)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelButtons.Size = New System.Drawing.Size(654, 46)
        Me.PanelButtons.TabIndex = 3
        '
        'btnCustom2
        '
        Me.btnCustom2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustom2.Image = CType(resources.GetObject("btnCustom2.Image"), System.Drawing.Image)
        Me.btnCustom2.Location = New System.Drawing.Point(304, 4)
        Me.btnCustom2.Name = "btnCustom2"
        Me.btnCustom2.Size = New System.Drawing.Size(150, 38)
        Me.btnCustom2.TabIndex = 19
        Me.btnCustom2.Text = "SimpleButton2"
        Me.btnCustom2.Visible = False
        '
        'btnCustom
        '
        Me.btnCustom.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustom.Image = CType(resources.GetObject("btnCustom.Image"), System.Drawing.Image)
        Me.btnCustom.Location = New System.Drawing.Point(154, 4)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(150, 38)
        Me.btnCustom.TabIndex = 18
        Me.btnCustom.Text = "SimpleButton1"
        Me.btnCustom.Visible = False
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = ""
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(500, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 38)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = "Modify"
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 38)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        '
        'FormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 327)
        Me.Controls.Add(Me.PanelButtons)
        Me.Name = "FormBase"
        Me.Text = "FormBase"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelButtons As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCustom2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustom As DevExpress.XtraEditors.SimpleButton
    Protected WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
