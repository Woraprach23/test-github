<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuotationForm))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xPageJob = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.JobGridView1 = New Finsoft.PM.UI.JobGridView()
        Me.xPageStatementofwork = New DevExpress.XtraTab.XtraTabPage()
        Me.AttachFileGridView1 = New Finsoft.PM.UI.AttachFileGridView()
        Me.xPageInvoice = New DevExpress.XtraTab.XtraTabPage()
        Me.xPageContract = New DevExpress.XtraTab.XtraTabPage()
        Me.xPageDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.memoDetail = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.deQuotationDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuotationName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuotationNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProductCode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xPageJob.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.xPageStatementofwork.SuspendLayout()
        Me.xPageDetail.SuspendLayout()
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deQuotationDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuotationName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(695, 4)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 79)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xPageJob
        Me.XtraTabControl1.Size = New System.Drawing.Size(849, 345)
        Me.XtraTabControl1.TabIndex = 232
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xPageJob, Me.xPageStatementofwork, Me.xPageInvoice, Me.xPageContract, Me.xPageDetail})
        '
        'xPageJob
        '
        Me.xPageJob.Controls.Add(Me.GroupControl4)
        Me.xPageJob.Image = CType(resources.GetObject("xPageJob.Image"), System.Drawing.Image)
        Me.xPageJob.Name = "xPageJob"
        Me.xPageJob.Size = New System.Drawing.Size(843, 314)
        Me.xPageJob.Text = "Job"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.JobGridView1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(843, 314)
        Me.GroupControl4.TabIndex = 228
        Me.GroupControl4.Text = "Detail"
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
        Me.JobGridView1.Location = New System.Drawing.Point(2, 2)
        Me.JobGridView1.Name = "JobGridView1"
        Me.JobGridView1.QuotationID = 0
        Me.JobGridView1.RowFilter = Nothing
        Me.JobGridView1.ShowAddPanel = True
        Me.JobGridView1.ShowCaption = False
        Me.JobGridView1.Size = New System.Drawing.Size(839, 310)
        Me.JobGridView1.TabIndex = 0
        '
        'xPageStatementofwork
        '
        Me.xPageStatementofwork.Controls.Add(Me.AttachFileGridView1)
        Me.xPageStatementofwork.Image = CType(resources.GetObject("xPageStatementofwork.Image"), System.Drawing.Image)
        Me.xPageStatementofwork.Name = "xPageStatementofwork"
        Me.xPageStatementofwork.Size = New System.Drawing.Size(843, 314)
        Me.xPageStatementofwork.Text = "Statement of work"
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
        Me.AttachFileGridView1.Size = New System.Drawing.Size(843, 314)
        Me.AttachFileGridView1.TabIndex = 0
        '
        'xPageInvoice
        '
        Me.xPageInvoice.Image = CType(resources.GetObject("xPageInvoice.Image"), System.Drawing.Image)
        Me.xPageInvoice.Name = "xPageInvoice"
        Me.xPageInvoice.Size = New System.Drawing.Size(843, 314)
        Me.xPageInvoice.Text = "Invoice"
        '
        'xPageContract
        '
        Me.xPageContract.Image = CType(resources.GetObject("xPageContract.Image"), System.Drawing.Image)
        Me.xPageContract.Name = "xPageContract"
        Me.xPageContract.Size = New System.Drawing.Size(843, 314)
        Me.xPageContract.Text = "Contract"
        '
        'xPageDetail
        '
        Me.xPageDetail.Controls.Add(Me.memoDetail)
        Me.xPageDetail.Image = CType(resources.GetObject("xPageDetail.Image"), System.Drawing.Image)
        Me.xPageDetail.Name = "xPageDetail"
        Me.xPageDetail.Size = New System.Drawing.Size(843, 314)
        Me.xPageDetail.Text = "Remark"
        '
        'memoDetail
        '
        Me.memoDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memoDetail.Location = New System.Drawing.Point(0, 0)
        Me.memoDetail.Name = "memoDetail"
        Me.memoDetail.Properties.MaxLength = 250
        Me.memoDetail.Size = New System.Drawing.Size(843, 314)
        Me.memoDetail.TabIndex = 212
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtProductCode)
        Me.GroupControl1.Controls.Add(Me.deQuotationDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.txtQuotationName)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtQuotationNo)
        Me.GroupControl1.Controls.Add(Me.txtClientCode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(849, 79)
        Me.GroupControl1.TabIndex = 233
        Me.GroupControl1.Text = "Information"
        '
        'deQuotationDate
        '
        Me.deQuotationDate.EditValue = Nothing
        Me.deQuotationDate.Location = New System.Drawing.Point(525, 27)
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
        Me.deQuotationDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deQuotationDate.Size = New System.Drawing.Size(126, 20)
        Me.deQuotationDate.TabIndex = 214
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(445, 31)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl19.TabIndex = 213
        Me.LabelControl19.Text = "Quotation Date"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(657, 31)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl17.TabIndex = 209
        Me.LabelControl17.Text = "Quotation No."
        '
        'txtQuotationName
        '
        Me.txtQuotationName.Location = New System.Drawing.Point(99, 53)
        Me.txtQuotationName.Name = "txtQuotationName"
        Me.txtQuotationName.Properties.MaxLength = 250
        Me.txtQuotationName.Size = New System.Drawing.Size(738, 20)
        Me.txtQuotationName.TabIndex = 206
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 31)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 202
        Me.LabelControl9.Text = "Client"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 205
        Me.LabelControl1.Text = "Quotation Name"
        '
        'txtQuotationNo
        '
        Me.txtQuotationNo.Location = New System.Drawing.Point(731, 28)
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtQuotationNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtQuotationNo.Properties.MaxLength = 250
        Me.txtQuotationNo.Properties.ReadOnly = True
        Me.txtQuotationNo.Size = New System.Drawing.Size(106, 20)
        Me.txtQuotationNo.TabIndex = 210
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(99, 27)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.MaxLength = 250
        Me.txtClientCode.Properties.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(120, 20)
        Me.txtClientCode.TabIndex = 204
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(239, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 215
        Me.LabelControl2.Text = "Product Code"
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(310, 28)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Properties.MaxLength = 250
        Me.txtProductCode.Properties.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(120, 20)
        Me.txtProductCode.TabIndex = 216
        '
        'QuotationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(849, 470)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "QuotationForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Quotation"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xPageJob.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.xPageStatementofwork.ResumeLayout(False)
        Me.xPageDetail.ResumeLayout(False)
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deQuotationDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuotationName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuotationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xPageJob As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents xPageDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents memoDetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xPageStatementofwork As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AttachFileGridView1 As Finsoft.PM.UI.AttachFileGridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deQuotationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuotationName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuotationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xPageInvoice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xPageContract As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents JobGridView1 As Finsoft.PM.UI.JobGridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductCode As DevExpress.XtraEditors.TextEdit

End Class
