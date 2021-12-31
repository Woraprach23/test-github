<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRAddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRAddForm))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDeliveryVersion = New DevExpress.XtraEditors.TextEdit()
        Me.deSignOffDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtItemNo = New DevExpress.XtraEditors.TextEdit()
        Me.CrGridView1 = New Finsoft.PM.UI.CRGridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPructionCode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDeliveryVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(546, 4)
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtClientCode)
        Me.GroupControl1.Controls.Add(Me.txtPructionCode)
        Me.GroupControl1.Controls.Add(Me.txtDeliveryVersion)
        Me.GroupControl1.Controls.Add(Me.deSignOffDate)
        Me.GroupControl1.Controls.Add(Me.txtItemNo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(700, 31)
        Me.GroupControl1.TabIndex = 226
        Me.GroupControl1.Text = "Information"
        '
        'txtDeliveryVersion
        '
        Me.txtDeliveryVersion.Location = New System.Drawing.Point(743, 47)
        Me.txtDeliveryVersion.Name = "txtDeliveryVersion"
        Me.txtDeliveryVersion.Properties.MaxLength = 250
        Me.txtDeliveryVersion.Size = New System.Drawing.Size(126, 20)
        Me.txtDeliveryVersion.TabIndex = 220
        '
        'deSignOffDate
        '
        Me.deSignOffDate.EditValue = Nothing
        Me.deSignOffDate.Location = New System.Drawing.Point(743, 70)
        Me.deSignOffDate.Name = "deSignOffDate"
        Me.deSignOffDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSignOffDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSignOffDate.Properties.DisplayFormat.FormatString = ""
        Me.deSignOffDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deSignOffDate.Properties.EditFormat.FormatString = ""
        Me.deSignOffDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deSignOffDate.Properties.Mask.EditMask = ""
        Me.deSignOffDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deSignOffDate.Properties.MaxLength = 250
        Me.deSignOffDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deSignOffDate.Size = New System.Drawing.Size(126, 20)
        Me.deSignOffDate.TabIndex = 218
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(743, 24)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtItemNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtItemNo.Properties.MaxLength = 250
        Me.txtItemNo.Size = New System.Drawing.Size(126, 20)
        Me.txtItemNo.TabIndex = 212
        '
        'CrGridView1
        '
        Me.CrGridView1.AutoLoad = False
        Me.CrGridView1.ByPassRowFilter = False
        Me.CrGridView1.CurrentGridControl = Nothing
        Me.CrGridView1.CurrentGridView = Nothing
        Me.CrGridView1.CurrentMasterFile = Nothing
        Me.CrGridView1.DataSource = Nothing
        Me.CrGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrGridView1.EditMode = Finsoft.PM.Common.AppEnums.EditMode.View
        Me.CrGridView1.GridviewType = Finsoft.PM.Common.AppEnums.GridviewType.EditForm
        Me.CrGridView1.HasUpdatingColumn = True
        Me.CrGridView1.IsAllowDelete = False
        Me.CrGridView1.IsApprove = False
        Me.CrGridView1.IsModify = False
        Me.CrGridView1.IsProcess = False
        Me.CrGridView1.IsView = False
        Me.CrGridView1.KeyFieldName = Nothing
        Me.CrGridView1.Location = New System.Drawing.Point(0, 31)
        Me.CrGridView1.Name = "CrGridView1"
        Me.CrGridView1.ParentID = 0
        Me.CrGridView1.ParentType = Finsoft.PM.Common.AppEnums.DocType.BRD
        Me.CrGridView1.RowFilter = Nothing
        Me.CrGridView1.ShowAddPanel = False
        Me.CrGridView1.ShowCaption = False
        Me.CrGridView1.Size = New System.Drawing.Size(700, 324)
        Me.CrGridView1.TabIndex = 227
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(234, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 223
        Me.LabelControl2.Text = "Product"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(14, 10)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 222
        Me.LabelControl9.Text = "Client"
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(304, 5)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.MaxLength = 250
        Me.txtClientCode.Properties.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(127, 20)
        Me.txtClientCode.TabIndex = 221
        '
        'txtPructionCode
        '
        Me.txtPructionCode.Location = New System.Drawing.Point(61, 5)
        Me.txtPructionCode.Name = "txtPructionCode"
        Me.txtPructionCode.Properties.MaxLength = 250
        Me.txtPructionCode.Properties.ReadOnly = True
        Me.txtPructionCode.Size = New System.Drawing.Size(126, 20)
        Me.txtPructionCode.TabIndex = 224
        '
        'CRAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(700, 401)
        Me.Controls.Add(Me.CrGridView1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "CRAddForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add CR"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.CrGridView1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDeliveryVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDeliveryVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deSignOffDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtItemNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CrGridView1 As Finsoft.PM.UI.CRGridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPructionCode As DevExpress.XtraEditors.TextEdit

End Class
