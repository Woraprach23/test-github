<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewMaster
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewMaster))
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadGridLookup = New System.ComponentModel.BackgroundWorker()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressPanel2 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.bgworkerUpdatingColumnLookup = New System.ComponentModel.BackgroundWorker()
        Me.MainToolBar = New DevExpress.XtraBars.Bar()
        Me.PanelControlSearch = New DevExpress.XtraEditors.PanelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.xtraBarMain = New DevExpress.XtraBars.Bar()
        Me.bbiNew = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiCopyNew = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiExportGrid = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiCustom1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiCustom2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgWorker
        '
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'bgwLoadGridLookup
        '
        Me.bgwLoadGridLookup.WorkerSupportsCancellation = True
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ProgressPanel2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(834, 245)
        Me.PanelControl2.TabIndex = 12
        '
        'ProgressPanel2
        '
        Me.ProgressPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressPanel2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel2.Appearance.Options.UseBackColor = True
        Me.ProgressPanel2.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProgressPanel2.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel2.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProgressPanel2.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel2.Location = New System.Drawing.Point(345, 89)
        Me.ProgressPanel2.Name = "ProgressPanel2"
        Me.ProgressPanel2.Size = New System.Drawing.Size(144, 66)
        Me.ProgressPanel2.TabIndex = 28
        Me.ProgressPanel2.Text = "ProgressPanel2"
        Me.ProgressPanel2.Visible = False
        '
        'bgworkerUpdatingColumnLookup
        '
        Me.bgworkerUpdatingColumnLookup.WorkerSupportsCancellation = True
        '
        'MainToolBar
        '
        Me.MainToolBar.BarName = "Main menu"
        Me.MainToolBar.DockCol = 0
        Me.MainToolBar.DockRow = 0
        Me.MainToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainToolBar.FloatLocation = New System.Drawing.Point(228, 120)
        Me.MainToolBar.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.MainToolBar.OptionsBar.UseWholeRow = True
        Me.MainToolBar.Text = "Main menu"
        '
        'PanelControlSearch
        '
        Me.PanelControlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlSearch.Location = New System.Drawing.Point(0, 40)
        Me.PanelControlSearch.Name = "PanelControlSearch"
        Me.PanelControlSearch.Size = New System.Drawing.Size(834, 38)
        Me.PanelControlSearch.TabIndex = 11
        Me.PanelControlSearch.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.xtraBarMain, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNew, Me.bbiCopyNew, Me.bbiDelete, Me.bbiRefresh, Me.bbiExportGrid, Me.bbiCustom1, Me.bbiCustom2})
        Me.BarManager1.MainMenu = Me.xtraBarMain
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'xtraBarMain
        '
        Me.xtraBarMain.BarName = "Main menu"
        Me.xtraBarMain.DockCol = 0
        Me.xtraBarMain.DockRow = 0
        Me.xtraBarMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.xtraBarMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.bbiNew, "Add"), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCopyNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCustom1), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCustom2)})
        Me.xtraBarMain.OptionsBar.MultiLine = True
        Me.xtraBarMain.OptionsBar.UseWholeRow = True
        Me.xtraBarMain.Text = "Main menu"
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "Add"
        Me.bbiNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiNew.Glyph = CType(resources.GetObject("bbiNew.Glyph"), System.Drawing.Image)
        Me.bbiNew.Id = 0
        Me.bbiNew.LargeGlyph = CType(resources.GetObject("bbiNew.LargeGlyph"), System.Drawing.Image)
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiCopyNew
        '
        Me.bbiCopyNew.Caption = "Copy"
        Me.bbiCopyNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiCopyNew.Glyph = CType(resources.GetObject("bbiCopyNew.Glyph"), System.Drawing.Image)
        Me.bbiCopyNew.Id = 1
        Me.bbiCopyNew.LargeGlyph = CType(resources.GetObject("bbiCopyNew.LargeGlyph"), System.Drawing.Image)
        Me.bbiCopyNew.Name = "bbiCopyNew"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiDelete.Glyph = CType(resources.GetObject("bbiDelete.Glyph"), System.Drawing.Image)
        Me.bbiDelete.Id = 2
        Me.bbiDelete.LargeGlyph = CType(resources.GetObject("bbiDelete.LargeGlyph"), System.Drawing.Image)
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiRefresh.Glyph = CType(resources.GetObject("bbiRefresh.Glyph"), System.Drawing.Image)
        Me.bbiRefresh.Id = 3
        Me.bbiRefresh.LargeGlyph = CType(resources.GetObject("bbiRefresh.LargeGlyph"), System.Drawing.Image)
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiExportGrid
        '
        Me.bbiExportGrid.Caption = "Export Grid"
        Me.bbiExportGrid.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiExportGrid.Glyph = CType(resources.GetObject("bbiExportGrid.Glyph"), System.Drawing.Image)
        Me.bbiExportGrid.Id = 4
        Me.bbiExportGrid.LargeGlyph = CType(resources.GetObject("bbiExportGrid.LargeGlyph"), System.Drawing.Image)
        Me.bbiExportGrid.Name = "bbiExportGrid"
        '
        'bbiCustom1
        '
        Me.bbiCustom1.Caption = "Custom 1"
        Me.bbiCustom1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiCustom1.Glyph = CType(resources.GetObject("bbiCustom1.Glyph"), System.Drawing.Image)
        Me.bbiCustom1.Id = 8
        Me.bbiCustom1.LargeGlyph = CType(resources.GetObject("bbiCustom1.LargeGlyph"), System.Drawing.Image)
        Me.bbiCustom1.Name = "bbiCustom1"
        Me.bbiCustom1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiCustom2
        '
        Me.bbiCustom2.Caption = "Custom 2"
        Me.bbiCustom2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiCustom2.Glyph = CType(resources.GetObject("bbiCustom2.Glyph"), System.Drawing.Image)
        Me.bbiCustom2.Id = 9
        Me.bbiCustom2.LargeGlyph = CType(resources.GetObject("bbiCustom2.LargeGlyph"), System.Drawing.Image)
        Me.bbiCustom2.Name = "bbiCustom2"
        Me.bbiCustom2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(834, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 323)
        Me.barDockControlBottom.Size = New System.Drawing.Size(834, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 283)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(834, 40)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 283)
        '
        'FormViewMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControlSearch)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FormViewMaster"
        Me.Text = "FormViewMaster"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadGridLookup As System.ComponentModel.BackgroundWorker
    Protected Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ProgressPanel2 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents bgworkerUpdatingColumnLookup As System.ComponentModel.BackgroundWorker
    Protected Friend WithEvents MainToolBar As DevExpress.XtraBars.Bar
    Protected Friend WithEvents PanelControlSearch As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents xtraBarMain As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiCopyNew As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiExportGrid As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiCustom1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiCustom2 As DevExpress.XtraBars.BarLargeButtonItem
End Class
