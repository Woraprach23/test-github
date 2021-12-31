Partial Public Class W
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(W))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiClient = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDoctype = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCR = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiQuotation = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiJOB = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFSD = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContract = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUser = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUserRole = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConfig = New DevExpress.XtraBars.BarButtonItem()
        Me.rbPageMain = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rbPageGroupMaster = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbPageGroupWorking = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbPageGroupSystemAdmin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.rbPageGroupReport = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbiReportLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReportA = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiClient, Me.bbiProduct, Me.bbiDoctype, Me.bbiCR, Me.bbiQuotation, Me.bbiJOB, Me.bbiFSD, Me.bbiContract, Me.bbiUser, Me.bbiUserRole, Me.bbiConfig, Me.bbiReportLayout, Me.bbiReportA})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 15
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbPageMain})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1370, 163)
        '
        'bbiClient
        '
        Me.bbiClient.Caption = "Client  "
        Me.bbiClient.Glyph = CType(resources.GetObject("bbiClient.Glyph"), System.Drawing.Image)
        Me.bbiClient.Id = 1
        Me.bbiClient.LargeGlyph = CType(resources.GetObject("bbiClient.LargeGlyph"), System.Drawing.Image)
        Me.bbiClient.Name = "bbiClient"
        '
        'bbiProduct
        '
        Me.bbiProduct.Caption = "Product"
        Me.bbiProduct.Glyph = CType(resources.GetObject("bbiProduct.Glyph"), System.Drawing.Image)
        Me.bbiProduct.Id = 2
        Me.bbiProduct.LargeGlyph = CType(resources.GetObject("bbiProduct.LargeGlyph"), System.Drawing.Image)
        Me.bbiProduct.Name = "bbiProduct"
        '
        'bbiDoctype
        '
        Me.bbiDoctype.Caption = "Doctype"
        Me.bbiDoctype.Glyph = CType(resources.GetObject("bbiDoctype.Glyph"), System.Drawing.Image)
        Me.bbiDoctype.Id = 3
        Me.bbiDoctype.LargeGlyph = CType(resources.GetObject("bbiDoctype.LargeGlyph"), System.Drawing.Image)
        Me.bbiDoctype.Name = "bbiDoctype"
        '
        'bbiCR
        '
        Me.bbiCR.Caption = "CR"
        Me.bbiCR.Glyph = CType(resources.GetObject("bbiCR.Glyph"), System.Drawing.Image)
        Me.bbiCR.Id = 4
        Me.bbiCR.LargeGlyph = CType(resources.GetObject("bbiCR.LargeGlyph"), System.Drawing.Image)
        Me.bbiCR.Name = "bbiCR"
        '
        'bbiQuotation
        '
        Me.bbiQuotation.Caption = "Quotation"
        Me.bbiQuotation.Glyph = CType(resources.GetObject("bbiQuotation.Glyph"), System.Drawing.Image)
        Me.bbiQuotation.Id = 5
        Me.bbiQuotation.LargeGlyph = CType(resources.GetObject("bbiQuotation.LargeGlyph"), System.Drawing.Image)
        Me.bbiQuotation.Name = "bbiQuotation"
        '
        'bbiJOB
        '
        Me.bbiJOB.Caption = "Job"
        Me.bbiJOB.Glyph = CType(resources.GetObject("bbiJOB.Glyph"), System.Drawing.Image)
        Me.bbiJOB.Id = 7
        Me.bbiJOB.LargeGlyph = CType(resources.GetObject("bbiJOB.LargeGlyph"), System.Drawing.Image)
        Me.bbiJOB.Name = "bbiJOB"
        '
        'bbiFSD
        '
        Me.bbiFSD.Caption = "FSD"
        Me.bbiFSD.Glyph = CType(resources.GetObject("bbiFSD.Glyph"), System.Drawing.Image)
        Me.bbiFSD.Id = 8
        Me.bbiFSD.LargeGlyph = CType(resources.GetObject("bbiFSD.LargeGlyph"), System.Drawing.Image)
        Me.bbiFSD.Name = "bbiFSD"
        '
        'bbiContract
        '
        Me.bbiContract.Caption = "Contract"
        Me.bbiContract.Glyph = CType(resources.GetObject("bbiContract.Glyph"), System.Drawing.Image)
        Me.bbiContract.Id = 9
        Me.bbiContract.LargeGlyph = CType(resources.GetObject("bbiContract.LargeGlyph"), System.Drawing.Image)
        Me.bbiContract.Name = "bbiContract"
        '
        'bbiUser
        '
        Me.bbiUser.Caption = "User"
        Me.bbiUser.Glyph = CType(resources.GetObject("bbiUser.Glyph"), System.Drawing.Image)
        Me.bbiUser.Id = 10
        Me.bbiUser.LargeGlyph = CType(resources.GetObject("bbiUser.LargeGlyph"), System.Drawing.Image)
        Me.bbiUser.Name = "bbiUser"
        '
        'bbiUserRole
        '
        Me.bbiUserRole.Caption = "User Role"
        Me.bbiUserRole.Glyph = CType(resources.GetObject("bbiUserRole.Glyph"), System.Drawing.Image)
        Me.bbiUserRole.Id = 11
        Me.bbiUserRole.LargeGlyph = CType(resources.GetObject("bbiUserRole.LargeGlyph"), System.Drawing.Image)
        Me.bbiUserRole.Name = "bbiUserRole"
        '
        'bbiConfig
        '
        Me.bbiConfig.Caption = "Config"
        Me.bbiConfig.Glyph = CType(resources.GetObject("bbiConfig.Glyph"), System.Drawing.Image)
        Me.bbiConfig.Id = 12
        Me.bbiConfig.LargeGlyph = CType(resources.GetObject("bbiConfig.LargeGlyph"), System.Drawing.Image)
        Me.bbiConfig.Name = "bbiConfig"
        '
        'rbPageMain
        '
        Me.rbPageMain.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rbPageGroupMaster, Me.rbPageGroupWorking, Me.rbPageGroupReport, Me.rbPageGroupSystemAdmin})
        Me.rbPageMain.Image = CType(resources.GetObject("rbPageMain.Image"), System.Drawing.Image)
        Me.rbPageMain.Name = "rbPageMain"
        '
        'rbPageGroupMaster
        '
        Me.rbPageGroupMaster.AllowTextClipping = False
        Me.rbPageGroupMaster.ItemLinks.Add(Me.bbiClient)
        Me.rbPageGroupMaster.ItemLinks.Add(Me.bbiProduct)
        Me.rbPageGroupMaster.ItemLinks.Add(Me.bbiDoctype)
        Me.rbPageGroupMaster.Name = "rbPageGroupMaster"
        Me.rbPageGroupMaster.Text = "Master"
        '
        'rbPageGroupWorking
        '
        Me.rbPageGroupWorking.ItemLinks.Add(Me.bbiCR)
        Me.rbPageGroupWorking.ItemLinks.Add(Me.bbiFSD)
        Me.rbPageGroupWorking.ItemLinks.Add(Me.bbiJOB)
        Me.rbPageGroupWorking.ItemLinks.Add(Me.bbiQuotation)
        Me.rbPageGroupWorking.ItemLinks.Add(Me.bbiContract)
        Me.rbPageGroupWorking.Name = "rbPageGroupWorking"
        Me.rbPageGroupWorking.Text = "Working"
        '
        'rbPageGroupSystemAdmin
        '
        Me.rbPageGroupSystemAdmin.ItemLinks.Add(Me.bbiUser)
        Me.rbPageGroupSystemAdmin.ItemLinks.Add(Me.bbiUserRole)
        Me.rbPageGroupSystemAdmin.ItemLinks.Add(Me.bbiConfig)
        Me.rbPageGroupSystemAdmin.Name = "rbPageGroupSystemAdmin"
        Me.rbPageGroupSystemAdmin.Text = "System Admin"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[False]
        '
        'rbPageGroupReport
        '
        Me.rbPageGroupReport.AllowTextClipping = False
        Me.rbPageGroupReport.ItemLinks.Add(Me.bbiReportLayout)
        Me.rbPageGroupReport.ItemLinks.Add(Me.bbiReportA)
        Me.rbPageGroupReport.Name = "rbPageGroupReport"
        Me.rbPageGroupReport.Text = "Report"
        '
        'bbiReportLayout
        '
        Me.bbiReportLayout.Caption = "Report Layout"
        Me.bbiReportLayout.Glyph = CType(resources.GetObject("bbiReportLayout.Glyph"), System.Drawing.Image)
        Me.bbiReportLayout.Id = 13
        Me.bbiReportLayout.LargeGlyph = CType(resources.GetObject("bbiReportLayout.LargeGlyph"), System.Drawing.Image)
        Me.bbiReportLayout.Name = "bbiReportLayout"
        '
        'bbiReportA
        '
        Me.bbiReportA.Caption = "Report A"
        Me.bbiReportA.Id = 14
        Me.bbiReportA.Name = "bbiReportA"
        '
        'W
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClientSize = New System.Drawing.Size(1370, 668)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "W"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Project Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private rbPageMain As DevExpress.XtraBars.Ribbon.RibbonPage
    Private rbPageGroupMaster As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbPageGroupWorking As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents bbiClient As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDoctype As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiQuotation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiJOB As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFSD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiContract As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbPageGroupSystemAdmin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiUserRole As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConfig As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbPageGroupReport As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiReportLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReportA As DevExpress.XtraBars.BarButtonItem
End Class
