<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobForm))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xPageCR = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.CrGridView1 = New Finsoft.PM.UI.CRGridView()
        Me.xPageDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.memoDetail = New DevExpress.XtraEditors.MemoEdit()
        Me.xPageDocuments = New DevExpress.XtraTab.XtraTabPage()
        Me.AttachFileGridView1 = New Finsoft.PM.UI.AttachFileGridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnViewQuatation = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPMO_NO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPO_NO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContractNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuatationNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.speTotalMandays = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.deStatementOfworkDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtJobName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFSDNo = New DevExpress.XtraEditors.TextEdit()
        Me.speAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtProductCode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xPageCR.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.xPageDetail.SuspendLayout()
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xPageDocuments.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtPMO_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContractNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuatationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speTotalMandays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStatementOfworkDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStatementOfworkDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFSDNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(833, 4)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 129)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xPageCR
        Me.XtraTabControl1.Size = New System.Drawing.Size(987, 286)
        Me.XtraTabControl1.TabIndex = 232
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xPageCR, Me.xPageDetail, Me.xPageDocuments})
        '
        'xPageCR
        '
        Me.xPageCR.Controls.Add(Me.GroupControl4)
        Me.xPageCR.Image = CType(resources.GetObject("xPageCR.Image"), System.Drawing.Image)
        Me.xPageCR.Name = "xPageCR"
        Me.xPageCR.Size = New System.Drawing.Size(981, 255)
        Me.xPageCR.Text = "CR"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.CrGridView1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(981, 255)
        Me.GroupControl4.TabIndex = 228
        Me.GroupControl4.Text = "Detail"
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
        Me.CrGridView1.Location = New System.Drawing.Point(2, 2)
        Me.CrGridView1.Name = "CrGridView1"
        Me.CrGridView1.ParentID = 0
        Me.CrGridView1.ParentType = Finsoft.PM.Common.AppEnums.DocType.BRD
        Me.CrGridView1.RowFilter = Nothing
        Me.CrGridView1.ShowAddPanel = True
        Me.CrGridView1.ShowCaption = False
        Me.CrGridView1.Size = New System.Drawing.Size(977, 251)
        Me.CrGridView1.TabIndex = 0
        '
        'xPageDetail
        '
        Me.xPageDetail.Controls.Add(Me.memoDetail)
        Me.xPageDetail.Image = CType(resources.GetObject("xPageDetail.Image"), System.Drawing.Image)
        Me.xPageDetail.Name = "xPageDetail"
        Me.xPageDetail.Size = New System.Drawing.Size(981, 186)
        Me.xPageDetail.Text = "Details"
        '
        'memoDetail
        '
        Me.memoDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memoDetail.Location = New System.Drawing.Point(0, 0)
        Me.memoDetail.Name = "memoDetail"
        Me.memoDetail.Properties.MaxLength = 250
        Me.memoDetail.Size = New System.Drawing.Size(981, 186)
        Me.memoDetail.TabIndex = 212
        '
        'xPageDocuments
        '
        Me.xPageDocuments.Controls.Add(Me.AttachFileGridView1)
        Me.xPageDocuments.Image = CType(resources.GetObject("xPageDocuments.Image"), System.Drawing.Image)
        Me.xPageDocuments.Name = "xPageDocuments"
        Me.xPageDocuments.Size = New System.Drawing.Size(981, 186)
        Me.xPageDocuments.Text = "Documents"
        '
        'AttachFileGridView1
        '
        Me.AttachFileGridView1.AutoLoad = False
        Me.AttachFileGridView1.ByPassRowFilter = False
        Me.AttachFileGridView1.CurrentGridControl = Nothing
        Me.AttachFileGridView1.CurrentGridView = Nothing
        Me.AttachFileGridView1.CurrentMasterFile = Nothing
        Me.AttachFileGridView1.DataSource = Nothing
        Me.AttachFileGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AttachFileGridView1.DocType = Finsoft.PM.Common.AppEnums.DocType.None
        Me.AttachFileGridView1.EditMode = Finsoft.PM.Common.AppEnums.EditMode.View
        Me.AttachFileGridView1.GridviewType = Finsoft.PM.Common.AppEnums.GridviewType.EditForm
        Me.AttachFileGridView1.HasUpdatingColumn = True
        Me.AttachFileGridView1.IsAllowDelete = False
        Me.AttachFileGridView1.IsApprove = False
        Me.AttachFileGridView1.IsFixDocumentType = False
        Me.AttachFileGridView1.IsModify = False
        Me.AttachFileGridView1.IsProcess = False
        Me.AttachFileGridView1.IsView = False
        Me.AttachFileGridView1.KeyFieldName = Nothing
        Me.AttachFileGridView1.Location = New System.Drawing.Point(0, 0)
        Me.AttachFileGridView1.Name = "AttachFileGridView1"
        Me.AttachFileGridView1.ParentID = 0
        Me.AttachFileGridView1.ParentType = Finsoft.PM.Common.AppEnums.DocType.None
        Me.AttachFileGridView1.RowFilter = Nothing
        Me.AttachFileGridView1.ShowAddPanel = True
        Me.AttachFileGridView1.ShowCaption = False
        Me.AttachFileGridView1.Size = New System.Drawing.Size(981, 186)
        Me.AttachFileGridView1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.btnViewQuatation)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtPMO_NO)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtPO_NO)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtContractNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtQuatationNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.speTotalMandays)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.deStatementOfworkDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.txtJobName)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtFSDNo)
        Me.GroupControl1.Controls.Add(Me.speAmount)
        Me.GroupControl1.Controls.Add(Me.txtClientCode)
        Me.GroupControl1.Controls.Add(Me.txtProductCode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(987, 129)
        Me.GroupControl1.TabIndex = 233
        Me.GroupControl1.Text = "PMO No."
        '
        'btnViewQuatation
        '
        Me.btnViewQuatation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewQuatation.Image = CType(resources.GetObject("btnViewQuatation.Image"), System.Drawing.Image)
        Me.btnViewQuatation.Location = New System.Drawing.Point(885, 22)
        Me.btnViewQuatation.Name = "btnViewQuatation"
        Me.btnViewQuatation.Size = New System.Drawing.Size(76, 28)
        Me.btnViewQuatation.TabIndex = 233
        Me.btnViewQuatation.Text = "Quatation"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(261, 108)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl8.TabIndex = 231
        Me.LabelControl8.Text = "PO No."
        '
        'txtPMO_NO
        '
        Me.txtPMO_NO.Location = New System.Drawing.Point(317, 105)
        Me.txtPMO_NO.Name = "txtPMO_NO"
        Me.txtPMO_NO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPMO_NO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPMO_NO.Properties.MaxLength = 250
        Me.txtPMO_NO.Size = New System.Drawing.Size(127, 20)
        Me.txtPMO_NO.TabIndex = 232
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(15, 108)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl7.TabIndex = 229
        Me.LabelControl7.Text = "PO No."
        '
        'txtPO_NO
        '
        Me.txtPO_NO.Location = New System.Drawing.Point(107, 105)
        Me.txtPO_NO.Name = "txtPO_NO"
        Me.txtPO_NO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPO_NO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPO_NO.Properties.MaxLength = 250
        Me.txtPO_NO.Size = New System.Drawing.Size(127, 20)
        Me.txtPO_NO.TabIndex = 230
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(693, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl6.TabIndex = 227
        Me.LabelControl6.Text = "Contract No."
        '
        'txtContractNo
        '
        Me.txtContractNo.Location = New System.Drawing.Point(767, 78)
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtContractNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtContractNo.Properties.MaxLength = 250
        Me.txtContractNo.Properties.ReadOnly = True
        Me.txtContractNo.Size = New System.Drawing.Size(112, 20)
        Me.txtContractNo.TabIndex = 228
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(693, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 225
        Me.LabelControl5.Text = "Invoice No"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(767, 52)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtInvoiceNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtInvoiceNo.Properties.MaxLength = 250
        Me.txtInvoiceNo.Properties.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(112, 20)
        Me.txtInvoiceNo.TabIndex = 226
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(693, 29)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl4.TabIndex = 223
        Me.LabelControl4.Text = "Quatation No."
        '
        'txtQuatationNo
        '
        Me.txtQuatationNo.Location = New System.Drawing.Point(767, 26)
        Me.txtQuatationNo.Name = "txtQuatationNo"
        Me.txtQuatationNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtQuatationNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtQuatationNo.Properties.MaxLength = 250
        Me.txtQuatationNo.Properties.ReadOnly = True
        Me.txtQuatationNo.Size = New System.Drawing.Size(112, 20)
        Me.txtQuatationNo.TabIndex = 224
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(462, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 221
        Me.LabelControl3.Text = "Total Mandays"
        '
        'speTotalMandays
        '
        Me.speTotalMandays.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speTotalMandays.Location = New System.Drawing.Point(551, 80)
        Me.speTotalMandays.Name = "speTotalMandays"
        Me.speTotalMandays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speTotalMandays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.speTotalMandays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.speTotalMandays.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.speTotalMandays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.speTotalMandays.Properties.MaxLength = 250
        Me.speTotalMandays.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.speTotalMandays.Size = New System.Drawing.Size(126, 20)
        Me.speTotalMandays.TabIndex = 222
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(261, 82)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl21.TabIndex = 217
        Me.LabelControl21.Text = "Amount"
        '
        'deStatementOfworkDate
        '
        Me.deStatementOfworkDate.EditValue = Nothing
        Me.deStatementOfworkDate.Location = New System.Drawing.Point(138, 79)
        Me.deStatementOfworkDate.Name = "deStatementOfworkDate"
        Me.deStatementOfworkDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStatementOfworkDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStatementOfworkDate.Properties.DisplayFormat.FormatString = ""
        Me.deStatementOfworkDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deStatementOfworkDate.Properties.EditFormat.FormatString = ""
        Me.deStatementOfworkDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deStatementOfworkDate.Properties.Mask.EditMask = ""
        Me.deStatementOfworkDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deStatementOfworkDate.Properties.MaxLength = 250
        Me.deStatementOfworkDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deStatementOfworkDate.Size = New System.Drawing.Size(96, 20)
        Me.deStatementOfworkDate.TabIndex = 214
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(15, 81)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl19.TabIndex = 213
        Me.LabelControl19.Text = "Statement Of work Date"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(461, 29)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl17.TabIndex = 209
        Me.LabelControl17.Text = "Job No."
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(107, 53)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Properties.MaxLength = 250
        Me.txtJobName.Size = New System.Drawing.Size(570, 20)
        Me.txtJobName.TabIndex = 206
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(261, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 203
        Me.LabelControl2.Text = "Product"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 30)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 202
        Me.LabelControl9.Text = "Client"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 205
        Me.LabelControl1.Text = "Job Name"
        '
        'txtFSDNo
        '
        Me.txtFSDNo.Location = New System.Drawing.Point(551, 27)
        Me.txtFSDNo.Name = "txtFSDNo"
        Me.txtFSDNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFSDNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFSDNo.Properties.MaxLength = 250
        Me.txtFSDNo.Properties.ReadOnly = True
        Me.txtFSDNo.Size = New System.Drawing.Size(126, 20)
        Me.txtFSDNo.TabIndex = 210
        '
        'speAmount
        '
        Me.speAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speAmount.Location = New System.Drawing.Point(317, 80)
        Me.speAmount.Name = "speAmount"
        Me.speAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.speAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.speAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.speAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.speAmount.Properties.MaxLength = 250
        Me.speAmount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.speAmount.Size = New System.Drawing.Size(126, 20)
        Me.speAmount.TabIndex = 218
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(107, 27)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.MaxLength = 250
        Me.txtClientCode.Properties.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(127, 20)
        Me.txtClientCode.TabIndex = 219
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(317, 27)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Properties.MaxLength = 250
        Me.txtProductCode.Properties.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(126, 20)
        Me.txtProductCode.TabIndex = 220
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(987, 461)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "JobForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xPageCR.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.xPageDetail.ResumeLayout(False)
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xPageDocuments.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtPMO_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContractNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuatationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speTotalMandays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStatementOfworkDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStatementOfworkDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFSDNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xPageCR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CrGridView1 As Finsoft.PM.UI.CRGridView
    Friend WithEvents xPageDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents memoDetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xPageDocuments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AttachFileGridView1 As Finsoft.PM.UI.AttachFileGridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deStatementOfworkDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtJobName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFSDNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents speTotalMandays As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents speAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuatationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPO_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContractNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPMO_NO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnViewQuatation As DevExpress.XtraEditors.SimpleButton

End Class
