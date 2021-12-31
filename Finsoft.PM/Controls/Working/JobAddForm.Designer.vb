<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobAddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobAddForm))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPructionCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeliveryVersion = New DevExpress.XtraEditors.TextEdit()
        Me.deSignOffDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtItemNo = New DevExpress.XtraEditors.TextEdit()
        Me.JobGridView1 = New Finsoft.PM.UI.JobGridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupControl1.Size = New System.Drawing.Size(654, 31)
        Me.GroupControl1.TabIndex = 227
        Me.GroupControl1.Text = "Information"
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
        'JobGridView1
        '
        Me.JobGridView1.AutoLoad = False
        Me.JobGridView1.ByPassRowFilter = False
        Me.JobGridView1.CurrentGridControl = Nothing
        Me.JobGridView1.CurrentGridView = Nothing
        Me.JobGridView1.CurrentMasterFile = Nothing
        Me.JobGridView1.DataSource = Nothing
        Me.JobGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobGridView1.EditMode = Finsoft.PM.Common.AppEnums.EditMode.View
        Me.JobGridView1.GridviewType = Finsoft.PM.Common.AppEnums.GridviewType.EditForm
        Me.JobGridView1.HasUpdatingColumn = True
        Me.JobGridView1.IsAllowDelete = False
        Me.JobGridView1.IsApprove = False
        Me.JobGridView1.IsModify = False
        Me.JobGridView1.IsProcess = False
        Me.JobGridView1.IsView = False
        Me.JobGridView1.KeyFieldName = Nothing
        Me.JobGridView1.Location = New System.Drawing.Point(0, 31)
        Me.JobGridView1.Name = "JobGridView1"
        Me.JobGridView1.QuotationID = 0
        Me.JobGridView1.RowFilter = Nothing
        Me.JobGridView1.ShowAddPanel = True
        Me.JobGridView1.ShowCaption = False
        Me.JobGridView1.Size = New System.Drawing.Size(654, 250)
        Me.JobGridView1.TabIndex = 228
        '
        'JobAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(654, 327)
        Me.Controls.Add(Me.JobGridView1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "JobAddForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Job"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.JobGridView1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPructionCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deSignOffDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtItemNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JobGridView1 As Finsoft.PM.UI.JobGridView

End Class
