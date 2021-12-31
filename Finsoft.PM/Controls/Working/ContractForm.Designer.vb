<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContractForm))
        Me.lbContractDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContractNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContractName = New DevExpress.XtraEditors.TextEdit()
        Me.lueContractType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.deEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.deStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.slueMainContract = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.deContractDate = New DevExpress.XtraEditors.DateEdit()
        Me.speAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.AttachFileGridView1 = New Finsoft.PM.UI.AttachFileGridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnViewQuatation = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuotationName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuotationNo = New DevExpress.XtraEditors.TextEdit()
        Me.deQuotationDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtContractNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContractName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueContractType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueMainContract.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deContractDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deContractDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtQuotationName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deQuotationDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(666, 4)
        '
        'lbContractDate
        '
        Me.lbContractDate.Location = New System.Drawing.Point(32, 85)
        Me.lbContractDate.Name = "lbContractDate"
        Me.lbContractDate.Size = New System.Drawing.Size(68, 13)
        Me.lbContractDate.TabIndex = 198
        Me.lbContractDate.Text = "Contract Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(320, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 197
        Me.LabelControl2.Text = "Product"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(32, 33)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 196
        Me.LabelControl9.Text = "Client"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.txtContractNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtContractName)
        Me.GroupControl1.Controls.Add(Me.lueContractType)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.deEndDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deStartDate)
        Me.GroupControl1.Controls.Add(Me.slueMainContract)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.lbContractDate)
        Me.GroupControl1.Controls.Add(Me.deContractDate)
        Me.GroupControl1.Controls.Add(Me.speAmount)
        Me.GroupControl1.Controls.Add(Me.txtClientCode)
        Me.GroupControl1.Controls.Add(Me.txtProductCode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(820, 135)
        Me.GroupControl1.TabIndex = 201
        Me.GroupControl1.Text = "Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(587, 33)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl10.TabIndex = 215
        Me.LabelControl10.Text = "Contract No"
        '
        'txtContractNo
        '
        Me.txtContractNo.Location = New System.Drawing.Point(678, 30)
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Properties.MaxLength = 250
        Me.txtContractNo.Properties.ReadOnly = True
        Me.txtContractNo.Size = New System.Drawing.Size(127, 20)
        Me.txtContractNo.TabIndex = 214
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(31, 59)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl8.TabIndex = 213
        Me.LabelControl8.Text = "Contract Name"
        '
        'txtContractName
        '
        Me.txtContractName.Location = New System.Drawing.Point(113, 56)
        Me.txtContractName.Name = "txtContractName"
        Me.txtContractName.Properties.MaxLength = 250
        Me.txtContractName.Size = New System.Drawing.Size(692, 20)
        Me.txtContractName.TabIndex = 212
        '
        'lueContractType
        '
        Me.lueContractType.EditValue = 0
        Me.lueContractType.Location = New System.Drawing.Point(402, 82)
        Me.lueContractType.Name = "lueContractType"
        Me.lueContractType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueContractType.Size = New System.Drawing.Size(126, 20)
        Me.lueContractType.TabIndex = 211
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(319, 84)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 210
        Me.LabelControl6.Text = "Type"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(320, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 208
        Me.LabelControl5.Text = "End Date"
        '
        'deEndDate
        '
        Me.deEndDate.EditValue = Nothing
        Me.deEndDate.Location = New System.Drawing.Point(402, 108)
        Me.deEndDate.Name = "deEndDate"
        Me.deEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEndDate.Properties.DisplayFormat.FormatString = ""
        Me.deEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deEndDate.Properties.EditFormat.FormatString = ""
        Me.deEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deEndDate.Properties.Mask.EditMask = ""
        Me.deEndDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deEndDate.Properties.MaxLength = 250
        Me.deEndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deEndDate.Size = New System.Drawing.Size(127, 20)
        Me.deEndDate.TabIndex = 209
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(596, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 206
        Me.LabelControl3.Text = "Amount"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(32, 111)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 204
        Me.LabelControl4.Text = "Start Date"
        '
        'deStartDate
        '
        Me.deStartDate.EditValue = Nothing
        Me.deStartDate.Location = New System.Drawing.Point(114, 108)
        Me.deStartDate.Name = "deStartDate"
        Me.deStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deStartDate.Properties.DisplayFormat.FormatString = ""
        Me.deStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deStartDate.Properties.EditFormat.FormatString = ""
        Me.deStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deStartDate.Properties.Mask.EditMask = ""
        Me.deStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deStartDate.Properties.MaxLength = 250
        Me.deStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deStartDate.Size = New System.Drawing.Size(127, 20)
        Me.deStartDate.TabIndex = 207
        '
        'slueMainContract
        '
        Me.slueMainContract.Location = New System.Drawing.Point(678, 81)
        Me.slueMainContract.Name = "slueMainContract"
        Me.slueMainContract.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueMainContract.Properties.MaxLength = 250
        Me.slueMainContract.Properties.NullText = ""
        Me.slueMainContract.Properties.View = Me.GridView2
        Me.slueMainContract.Size = New System.Drawing.Size(127, 20)
        Me.slueMainContract.TabIndex = 201
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(596, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 202
        Me.LabelControl1.Text = "Main Contract"
        '
        'deContractDate
        '
        Me.deContractDate.EditValue = Nothing
        Me.deContractDate.Location = New System.Drawing.Point(114, 82)
        Me.deContractDate.Name = "deContractDate"
        Me.deContractDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deContractDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deContractDate.Properties.DisplayFormat.FormatString = ""
        Me.deContractDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deContractDate.Properties.EditFormat.FormatString = ""
        Me.deContractDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deContractDate.Properties.Mask.EditMask = ""
        Me.deContractDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deContractDate.Properties.MaxLength = 250
        Me.deContractDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deContractDate.Size = New System.Drawing.Size(127, 20)
        Me.deContractDate.TabIndex = 203
        '
        'speAmount
        '
        Me.speAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speAmount.Location = New System.Drawing.Point(678, 108)
        Me.speAmount.Name = "speAmount"
        Me.speAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.speAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.speAmount.Properties.MaxLength = 250
        Me.speAmount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.speAmount.Size = New System.Drawing.Size(127, 20)
        Me.speAmount.TabIndex = 205
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(114, 30)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.MaxLength = 250
        Me.txtClientCode.Properties.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(127, 20)
        Me.txtClientCode.TabIndex = 192
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(402, 30)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Properties.MaxLength = 250
        Me.txtProductCode.Properties.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(126, 20)
        Me.txtProductCode.TabIndex = 200
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
        Me.AttachFileGridView1.GridviewType = Finsoft.PM.Common.AppEnums.GridviewType.None
        Me.AttachFileGridView1.HasUpdatingColumn = True
        Me.AttachFileGridView1.IsAllowDelete = False
        Me.AttachFileGridView1.IsApprove = False
        Me.AttachFileGridView1.IsFixDocumentType = False
        Me.AttachFileGridView1.IsModify = False
        Me.AttachFileGridView1.IsProcess = False
        Me.AttachFileGridView1.IsView = False
        Me.AttachFileGridView1.KeyFieldName = Nothing
        Me.AttachFileGridView1.Location = New System.Drawing.Point(0, 215)
        Me.AttachFileGridView1.Name = "AttachFileGridView1"
        Me.AttachFileGridView1.ParentID = 0
        Me.AttachFileGridView1.ParentType = Finsoft.PM.Common.AppEnums.DocType.None
        Me.AttachFileGridView1.RowFilter = Nothing
        Me.AttachFileGridView1.ShowAddPanel = True
        Me.AttachFileGridView1.ShowCaption = False
        Me.AttachFileGridView1.Size = New System.Drawing.Size(820, 206)
        Me.AttachFileGridView1.TabIndex = 202
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImage = CType(resources.GetObject("GroupControl2.CaptionImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.btnViewQuatation)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtQuotationName)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.LabelControl14)
        Me.GroupControl2.Controls.Add(Me.txtQuotationNo)
        Me.GroupControl2.Controls.Add(Me.deQuotationDate)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 135)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(820, 80)
        Me.GroupControl2.TabIndex = 203
        Me.GroupControl2.Text = "Quotation"
        '
        'btnViewQuatation
        '
        Me.btnViewQuatation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewQuatation.Image = CType(resources.GetObject("btnViewQuatation.Image"), System.Drawing.Image)
        Me.btnViewQuatation.Location = New System.Drawing.Point(678, 25)
        Me.btnViewQuatation.Name = "btnViewQuatation"
        Me.btnViewQuatation.Size = New System.Drawing.Size(127, 28)
        Me.btnViewQuatation.TabIndex = 234
        Me.btnViewQuatation.Text = "Quatation"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(32, 58)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl7.TabIndex = 202
        Me.LabelControl7.Text = "Quotation Name"
        '
        'txtQuotationName
        '
        Me.txtQuotationName.Location = New System.Drawing.Point(114, 55)
        Me.txtQuotationName.Name = "txtQuotationName"
        Me.txtQuotationName.Properties.MaxLength = 250
        Me.txtQuotationName.Properties.ReadOnly = True
        Me.txtQuotationName.Size = New System.Drawing.Size(691, 20)
        Me.txtQuotationName.TabIndex = 201
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(32, 33)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl13.TabIndex = 196
        Me.LabelControl13.Text = "Quotation No"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(320, 33)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl14.TabIndex = 197
        Me.LabelControl14.Text = "Quotation Date"
        '
        'txtQuotationNo
        '
        Me.txtQuotationNo.Location = New System.Drawing.Point(114, 30)
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Properties.MaxLength = 250
        Me.txtQuotationNo.Properties.ReadOnly = True
        Me.txtQuotationNo.Size = New System.Drawing.Size(127, 20)
        Me.txtQuotationNo.TabIndex = 192
        '
        'deQuotationDate
        '
        Me.deQuotationDate.EditValue = Nothing
        Me.deQuotationDate.Location = New System.Drawing.Point(402, 30)
        Me.deQuotationDate.Name = "deQuotationDate"
        Me.deQuotationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deQuotationDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deQuotationDate.Properties.DisplayFormat.FormatString = ""
        Me.deQuotationDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deQuotationDate.Properties.EditFormat.FormatString = ""
        Me.deQuotationDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deQuotationDate.Properties.Mask.EditMask = ""
        Me.deQuotationDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deQuotationDate.Properties.MaxLength = 250
        Me.deQuotationDate.Properties.ReadOnly = True
        Me.deQuotationDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deQuotationDate.Size = New System.Drawing.Size(126, 20)
        Me.deQuotationDate.TabIndex = 200
        '
        'ContractForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(820, 467)
        Me.Controls.Add(Me.AttachFileGridView1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "ContractForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contract"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.AttachFileGridView1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtContractNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContractName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueContractType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueMainContract.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deContractDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deContractDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtQuotationName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deQuotationDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbContractDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents slueMainContract As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deContractDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents speAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AttachFileGridView1 As Finsoft.PM.UI.AttachFileGridView
    Friend WithEvents lueContractType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuotationName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuotationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deQuotationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContractName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContractNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnViewQuatation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductCode As DevExpress.XtraEditors.TextEdit

End Class
