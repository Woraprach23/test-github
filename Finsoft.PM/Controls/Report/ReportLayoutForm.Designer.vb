<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportLayoutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportLayoutForm))
        Me.cboReportType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.chkActive = New DevExpress.XtraEditors.CheckEdit()
        Me.btnEditLayout = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReportCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReportName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.memoRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.btnViewXML = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUploadXML = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cboReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(490, 4)
        '
        'cboReportType
        '
        Me.cboReportType.Location = New System.Drawing.Point(125, 73)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReportType.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.cboReportType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cboReportType.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.cboReportType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cboReportType.Properties.NullText = ""
        Me.cboReportType.Properties.PopupSizeable = False
        Me.cboReportType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboReportType.Size = New System.Drawing.Size(142, 20)
        Me.cboReportType.TabIndex = 308
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(41, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 307
        Me.LabelControl2.Text = "Report Type"
        '
        'chkActive
        '
        Me.chkActive.Location = New System.Drawing.Point(273, 22)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Properties.Caption = "Active"
        Me.chkActive.Size = New System.Drawing.Size(75, 19)
        Me.chkActive.TabIndex = 306
        '
        'btnEditLayout
        '
        Me.btnEditLayout.Image = CType(resources.GetObject("btnEditLayout.Image"), System.Drawing.Image)
        Me.btnEditLayout.Location = New System.Drawing.Point(490, 71)
        Me.btnEditLayout.Name = "btnEditLayout"
        Me.btnEditLayout.Size = New System.Drawing.Size(104, 23)
        Me.btnEditLayout.TabIndex = 305
        Me.btnEditLayout.Text = "Edit Layout"
        '
        'txtReportCode
        '
        Me.txtReportCode.Location = New System.Drawing.Point(125, 21)
        Me.txtReportCode.Name = "txtReportCode"
        Me.txtReportCode.Size = New System.Drawing.Size(142, 20)
        Me.txtReportCode.TabIndex = 302
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(41, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 303
        Me.Label23.Text = "Report Code"
        '
        'txtReportName
        '
        Me.txtReportName.Location = New System.Drawing.Point(125, 47)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(469, 20)
        Me.txtReportName.TabIndex = 309
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(41, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 310
        Me.LabelControl3.Text = "Report Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 102)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 312
        Me.LabelControl1.Text = "Remark"
        '
        'memoRemark
        '
        Me.memoRemark.Location = New System.Drawing.Point(125, 99)
        Me.memoRemark.Name = "memoRemark"
        Me.memoRemark.Size = New System.Drawing.Size(469, 82)
        Me.memoRemark.TabIndex = 311
        '
        'btnViewXML
        '
        Me.btnViewXML.Image = CType(resources.GetObject("btnViewXML.Image"), System.Drawing.Image)
        Me.btnViewXML.Location = New System.Drawing.Point(366, 71)
        Me.btnViewXML.Name = "btnViewXML"
        Me.btnViewXML.Size = New System.Drawing.Size(88, 23)
        Me.btnViewXML.TabIndex = 313
        Me.btnViewXML.Text = "View XML"
        Me.btnViewXML.Visible = False
        '
        'btnUploadXML
        '
        Me.btnUploadXML.Image = CType(resources.GetObject("btnUploadXML.Image"), System.Drawing.Image)
        Me.btnUploadXML.Location = New System.Drawing.Point(273, 71)
        Me.btnUploadXML.Name = "btnUploadXML"
        Me.btnUploadXML.Size = New System.Drawing.Size(88, 23)
        Me.btnUploadXML.TabIndex = 314
        Me.btnUploadXML.Text = "Upload XML"
        '
        'ReportLayoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(644, 250)
        Me.Controls.Add(Me.btnUploadXML)
        Me.Controls.Add(Me.btnViewXML)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtReportName)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cboReportType)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.btnEditLayout)
        Me.Controls.Add(Me.txtReportCode)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.memoRemark)
        Me.Name = "ReportLayoutForm"
        Me.ShowButtonsPanel = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Layout"
        Me.Controls.SetChildIndex(Me.memoRemark, 0)
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.txtReportCode, 0)
        Me.Controls.SetChildIndex(Me.btnEditLayout, 0)
        Me.Controls.SetChildIndex(Me.chkActive, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.cboReportType, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtReportName, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.btnViewXML, 0)
        Me.Controls.SetChildIndex(Me.btnUploadXML, 0)
        CType(Me.cboReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboReportType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnEditLayout As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReportCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReportName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnViewXML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUploadXML As DevExpress.XtraEditors.SimpleButton

End Class
