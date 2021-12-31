<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSDForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSDForm))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xPageCR = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.CrGridView1 = New Finsoft.PM.UI.CRGridView()
        Me.xPageDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.memoDetail = New DevExpress.XtraEditors.MemoEdit()
        Me.xPageDocuments = New DevExpress.XtraTab.XtraTabPage()
        Me.AttachFileGridView1 = New Finsoft.PM.UI.AttachFileGridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.slueClient = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.slueProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deSignOffDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.deFSDDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFSDName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFSDNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtClientCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPructionCode = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.slueClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFSDDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFSDDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFSDName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFSDNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(768, 4)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 97)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xPageCR
        Me.XtraTabControl1.Size = New System.Drawing.Size(922, 224)
        Me.XtraTabControl1.TabIndex = 230
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xPageCR, Me.xPageDetail, Me.xPageDocuments})
        '
        'xPageCR
        '
        Me.xPageCR.Controls.Add(Me.GroupControl4)
        Me.xPageCR.Image = CType(resources.GetObject("xPageCR.Image"), System.Drawing.Image)
        Me.xPageCR.Name = "xPageCR"
        Me.xPageCR.Size = New System.Drawing.Size(916, 193)
        Me.xPageCR.Text = "CR"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.CrGridView1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(916, 193)
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
        Me.CrGridView1.Size = New System.Drawing.Size(912, 189)
        Me.CrGridView1.TabIndex = 0
        '
        'xPageDetail
        '
        Me.xPageDetail.Controls.Add(Me.memoDetail)
        Me.xPageDetail.Image = CType(resources.GetObject("xPageDetail.Image"), System.Drawing.Image)
        Me.xPageDetail.Name = "xPageDetail"
        Me.xPageDetail.Size = New System.Drawing.Size(916, 193)
        Me.xPageDetail.Text = "Details"
        '
        'memoDetail
        '
        Me.memoDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memoDetail.Location = New System.Drawing.Point(0, 0)
        Me.memoDetail.Name = "memoDetail"
        Me.memoDetail.Properties.MaxLength = 250
        Me.memoDetail.Size = New System.Drawing.Size(916, 193)
        Me.memoDetail.TabIndex = 212
        '
        'xPageDocuments
        '
        Me.xPageDocuments.Controls.Add(Me.AttachFileGridView1)
        Me.xPageDocuments.Image = CType(resources.GetObject("xPageDocuments.Image"), System.Drawing.Image)
        Me.xPageDocuments.Name = "xPageDocuments"
        Me.xPageDocuments.Size = New System.Drawing.Size(916, 193)
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
        Me.AttachFileGridView1.Size = New System.Drawing.Size(916, 193)
        Me.AttachFileGridView1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.slueClient)
        Me.GroupControl1.Controls.Add(Me.slueProduct)
        Me.GroupControl1.Controls.Add(Me.deSignOffDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl21)
        Me.GroupControl1.Controls.Add(Me.deFSDDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.txtFSDName)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtFSDNo)
        Me.GroupControl1.Controls.Add(Me.txtClientCode)
        Me.GroupControl1.Controls.Add(Me.txtPructionCode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(922, 97)
        Me.GroupControl1.TabIndex = 231
        Me.GroupControl1.Text = "Information"
        '
        'slueClient
        '
        Me.slueClient.Location = New System.Drawing.Point(693, 27)
        Me.slueClient.Name = "slueClient"
        Me.slueClient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueClient.Properties.MaxLength = 250
        Me.slueClient.Properties.NullText = ""
        Me.slueClient.Properties.View = Me.SearchLookUpEdit1View
        Me.slueClient.Size = New System.Drawing.Size(127, 20)
        Me.slueClient.TabIndex = 219
        Me.slueClient.Visible = False
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'slueProduct
        '
        Me.slueProduct.Location = New System.Drawing.Point(694, 50)
        Me.slueProduct.Name = "slueProduct"
        Me.slueProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueProduct.Properties.MaxLength = 250
        Me.slueProduct.Properties.NullText = ""
        Me.slueProduct.Properties.View = Me.GridView1
        Me.slueProduct.Size = New System.Drawing.Size(126, 20)
        Me.slueProduct.TabIndex = 220
        Me.slueProduct.Visible = False
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'deSignOffDate
        '
        Me.deSignOffDate.EditValue = Nothing
        Me.deSignOffDate.Location = New System.Drawing.Point(318, 47)
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
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(235, 50)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl21.TabIndex = 217
        Me.LabelControl21.Text = "Sign Off Date"
        '
        'deFSDDate
        '
        Me.deFSDDate.EditValue = Nothing
        Me.deFSDDate.Location = New System.Drawing.Point(93, 46)
        Me.deFSDDate.Name = "deFSDDate"
        Me.deFSDDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFSDDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFSDDate.Properties.DisplayFormat.FormatString = ""
        Me.deFSDDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFSDDate.Properties.EditFormat.FormatString = ""
        Me.deFSDDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFSDDate.Properties.Mask.EditMask = ""
        Me.deFSDDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.deFSDDate.Properties.MaxLength = 250
        Me.deFSDDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deFSDDate.Size = New System.Drawing.Size(126, 20)
        Me.deFSDDate.TabIndex = 214
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(15, 50)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl19.TabIndex = 213
        Me.LabelControl19.Text = "FSD Date"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(461, 27)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl17.TabIndex = 209
        Me.LabelControl17.Text = "FSD No."
        '
        'txtFSDName
        '
        Me.txtFSDName.Location = New System.Drawing.Point(93, 72)
        Me.txtFSDName.Name = "txtFSDName"
        Me.txtFSDName.Properties.MaxLength = 250
        Me.txtFSDName.Size = New System.Drawing.Size(824, 20)
        Me.txtFSDName.TabIndex = 206
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(235, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 203
        Me.LabelControl2.Text = "Product"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 29)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 202
        Me.LabelControl9.Text = "Client"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 205
        Me.LabelControl1.Text = "FSD Name"
        '
        'txtFSDNo
        '
        Me.txtFSDNo.Location = New System.Drawing.Point(515, 24)
        Me.txtFSDNo.Name = "txtFSDNo"
        Me.txtFSDNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFSDNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFSDNo.Properties.MaxLength = 250
        Me.txtFSDNo.Properties.ReadOnly = True
        Me.txtFSDNo.Size = New System.Drawing.Size(126, 20)
        Me.txtFSDNo.TabIndex = 210
        '
        'txtClientCode
        '
        Me.txtClientCode.Location = New System.Drawing.Point(317, 24)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.Properties.MaxLength = 250
        Me.txtClientCode.Properties.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(127, 20)
        Me.txtClientCode.TabIndex = 201
        '
        'txtPructionCode
        '
        Me.txtPructionCode.Location = New System.Drawing.Point(93, 24)
        Me.txtPructionCode.Name = "txtPructionCode"
        Me.txtPructionCode.Properties.MaxLength = 250
        Me.txtPructionCode.Properties.ReadOnly = True
        Me.txtPructionCode.Size = New System.Drawing.Size(126, 20)
        Me.txtPructionCode.TabIndex = 204
        '
        'FSDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(922, 367)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FSDForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FSD"
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
        CType(Me.slueClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSignOffDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFSDDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFSDDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFSDName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFSDNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPructionCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xPageCR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents memoDetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xPageDocuments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AttachFileGridView1 As Finsoft.PM.UI.AttachFileGridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deSignOffDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFSDDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFSDName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFSDNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClientCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPructionCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xPageDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CrGridView1 As Finsoft.PM.UI.CRGridView
    Friend WithEvents slueClient As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents slueProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
