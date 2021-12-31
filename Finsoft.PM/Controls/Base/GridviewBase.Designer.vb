<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridviewBase
    'Inherits PM.UI.ControlBase
    Inherits DevExpress.XtraEditors.XtraUserControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridviewBase))
        Me.ProgressPanel2 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.grboxMaster = New DevExpress.XtraEditors.GroupControl()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadGridLookup = New System.ComponentModel.BackgroundWorker()
        Me.bgworkerUpdatingColumnLookup = New System.ComponentModel.BackgroundWorker()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.MainToolBar = New DevExpress.XtraBars.Bar()
        Me.bbiAdd = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiCopyNew = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grboxMaster.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ProgressPanel2.Location = New System.Drawing.Point(269, 72)
        Me.ProgressPanel2.Name = "ProgressPanel2"
        Me.ProgressPanel2.Size = New System.Drawing.Size(246, 66)
        Me.ProgressPanel2.TabIndex = 5
        Me.ProgressPanel2.Text = "ProgressPanel1"
        Me.ProgressPanel2.Visible = False
        '
        'grboxMaster
        '
        Me.grboxMaster.Controls.Add(Me.ProgressPanel2)
        Me.grboxMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grboxMaster.Location = New System.Drawing.Point(0, 40)
        Me.grboxMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.grboxMaster.Name = "grboxMaster"
        Me.grboxMaster.ShowCaption = False
        Me.grboxMaster.Size = New System.Drawing.Size(854, 237)
        Me.grboxMaster.TabIndex = 4
        Me.grboxMaster.Text = "Master View"
        '
        'bgWorker
        '
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'bgwLoadGridLookup
        '
        Me.bgwLoadGridLookup.WorkerSupportsCancellation = True
        '
        'bgworkerUpdatingColumnLookup
        '
        Me.bgworkerUpdatingColumnLookup.WorkerSupportsCancellation = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MainToolBar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAdd, Me.bbiCopyNew, Me.bbiDelete})
        Me.BarManager1.MainMenu = Me.MainToolBar
        Me.BarManager1.MaxItemId = 3
        '
        'MainToolBar
        '
        Me.MainToolBar.BarName = "Main menu"
        Me.MainToolBar.DockCol = 0
        Me.MainToolBar.DockRow = 0
        Me.MainToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.bbiAdd, "Add"), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCopyNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
        Me.MainToolBar.OptionsBar.MultiLine = True
        Me.MainToolBar.OptionsBar.UseWholeRow = True
        Me.MainToolBar.Text = "Main menu"
        '
        'bbiAdd
        '
        Me.bbiAdd.Caption = "Add"
        Me.bbiAdd.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.bbiAdd.Glyph = CType(resources.GetObject("bbiAdd.Glyph"), System.Drawing.Image)
        Me.bbiAdd.Id = 0
        Me.bbiAdd.LargeGlyph = CType(resources.GetObject("bbiAdd.LargeGlyph"), System.Drawing.Image)
        Me.bbiAdd.Name = "bbiAdd"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(854, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 277)
        Me.barDockControlBottom.Size = New System.Drawing.Size(854, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 237)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(854, 40)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 237)
        '
        'GridviewBase
        '
        Me.Controls.Add(Me.grboxMaster)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "GridviewBase"
        Me.Size = New System.Drawing.Size(854, 277)
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grboxMaster.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents grboxMaster As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ProgressPanel2 As DevExpress.XtraWaitForm.ProgressPanel

    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadGridLookup As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgworkerUpdatingColumnLookup As System.ComponentModel.BackgroundWorker
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents MainToolBar As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiCopyNew As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
