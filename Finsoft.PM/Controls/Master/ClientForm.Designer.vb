<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTaxID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tpAddress = New DevExpress.XtraTab.XtraTabPage()
        Me.AddressGridView1 = New Finsoft.PM.UI.AddressGridView()
        Me.tpProduct = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tpAddress.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(592, 4)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Client Code"
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(114, 9)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Size = New System.Drawing.Size(143, 20)
        Me.txtClientCode.TabIndex = 5
        '
        'txtTaxID
        '
        Me.txtTaxID.Location = New System.Drawing.Point(392, 9)
        Me.txtTaxID.Name = "txtTaxID"
        Me.txtTaxID.Size = New System.Drawing.Size(143, 20)
        Me.txtTaxID.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(303, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Tax ID"
        '
        'txtClientName
        '
        Me.txtClientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientName.Location = New System.Drawing.Point(114, 35)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(602, 20)
        Me.txtClientName.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(25, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Client Name"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 63)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tpAddress
        Me.XtraTabControl1.Size = New System.Drawing.Size(746, 218)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpAddress, Me.tpProduct})
        '
        'tpAddress
        '
        Me.tpAddress.Controls.Add(Me.AddressGridView1)
        Me.tpAddress.Name = "tpAddress"
        Me.tpAddress.Size = New System.Drawing.Size(740, 190)
        Me.tpAddress.Text = "Address"
        '
        'AddressGridView1
        '
        Me.AddressGridView1.AutoLoad = False
        Me.AddressGridView1.ByPassRowFilter = False
        Me.AddressGridView1.CurrentGridControl = Nothing
        Me.AddressGridView1.CurrentGridView = Nothing
        Me.AddressGridView1.CurrentMasterFile = Nothing
        Me.AddressGridView1.DataSource = Nothing
        Me.AddressGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressGridView1.EditMode = Finsoft.PM.Common.AppEnums.EditMode.View
        Me.AddressGridView1.GridviewType = Finsoft.PM.Common.AppEnums.GridviewType.EditForm
        Me.AddressGridView1.HasUpdatingColumn = True
        Me.AddressGridView1.IsAllowDelete = False
        Me.AddressGridView1.IsApprove = False
        Me.AddressGridView1.IsModify = False
        Me.AddressGridView1.IsProcess = False
        Me.AddressGridView1.IsView = False
        Me.AddressGridView1.KeyFieldName = Nothing
        Me.AddressGridView1.Location = New System.Drawing.Point(0, 0)
        Me.AddressGridView1.Name = "AddressGridView1" 
        Me.AddressGridView1.RowFilter = Nothing
        Me.AddressGridView1.ShowAddPanel = True
        Me.AddressGridView1.Size = New System.Drawing.Size(740, 190)
        Me.AddressGridView1.TabIndex = 0
        '
        'tpProduct
        '
        Me.tpProduct.Name = "tpProduct"
        Me.tpProduct.PageVisible = False
        Me.tpProduct.Size = New System.Drawing.Size(740, 190)
        Me.tpProduct.Text = "Product"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTaxID)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtClientName)
        Me.PanelControl1.Controls.Add(Me.txtClientCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(746, 63)
        Me.PanelControl1.TabIndex = 11
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(746, 327)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ClientForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Client"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tpAddress.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTaxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpAddress As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpProduct As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents AddressGridView1 As Finsoft.PM.UI.AddressGridView

End Class
