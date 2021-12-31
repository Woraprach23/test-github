<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRFormView
    Inherits PM.UI.FormViewMaster

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRFormView))
        Me.gcCR = New DevExpress.XtraGrid.GridControl()
        Me.gvCR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModuleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpenDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstFSDMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstDevMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstTestMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstSupportMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFSDMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDevMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTestMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupportMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFSDID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.colPMO_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcCR)
        Me.PanelControl2.Size = New System.Drawing.Size(834, 243)
        Me.PanelControl2.Controls.SetChildIndex(Me.gcCR, 0)
        '
        'gcCR
        '
        Me.gcCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCR.Location = New System.Drawing.Point(2, 2)
        Me.gcCR.MainView = Me.gvCR
        Me.gcCR.Name = "gcCR"
        Me.gcCR.Size = New System.Drawing.Size(830, 239)
        Me.gcCR.TabIndex = 29
        Me.gcCR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCR})
        '
        'gvCR
        '
        Me.gvCR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCRNo, Me.colClientCode, Me.colProductCode, Me.colModuleName, Me.colOpenDate, Me.colSummary, Me.colDetail, Me.colPMO_No, Me.GridColumn9, Me.colEstFSDMandays, Me.colEstDevMandays, Me.colEstTestMandays, Me.colEstSupportMandays, Me.GridColumn3, Me.colFSDMandays, Me.colDevMandays, Me.colTestMandays, Me.colSupportMandays, Me.colTotalMandays, Me.colJobID, Me.GridColumn6, Me.colFSDID, Me.GridColumn5, Me.GridColumn4, Me.GridColumn2, Me.GridColumn1, Me.colDeliveryVersion, Me.colCreatedBy, Me.colCreatedDate, Me.colLastUpdatedBy, Me.GridColumn8, Me.GridColumn7, Me.colLastUpdated})
        Me.gvCR.GridControl = Me.gcCR
        Me.gvCR.Name = "gvCR"
        Me.gvCR.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvCR.OptionsSelection.MultiSelect = True
        Me.gvCR.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvCR.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvCR.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvCR.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCR.OptionsSelection.UseIndicatorForSelection = False
        Me.gvCR.OptionsView.ColumnAutoWidth = False
        Me.gvCR.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.AppearanceCell.Options.UseTextOptions = True
        Me.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.AppearanceHeader.Options.UseTextOptions = True
        Me.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.Caption = "CR ID"
        Me.colID.FieldName = "CRID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 1
        Me.colID.Width = 61
        '
        'colCRNo
        '
        Me.colCRNo.AppearanceCell.Options.UseTextOptions = True
        Me.colCRNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCRNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCRNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCRNo.Caption = "CR No"
        Me.colCRNo.FieldName = "CRNo"
        Me.colCRNo.Name = "colCRNo"
        Me.colCRNo.Visible = True
        Me.colCRNo.VisibleIndex = 2
        Me.colCRNo.Width = 120
        '
        'colClientCode
        '
        Me.colClientCode.AppearanceCell.Options.UseTextOptions = True
        Me.colClientCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colClientCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientCode.Caption = "Client"
        Me.colClientCode.FieldName = "ClientCode"
        Me.colClientCode.Name = "colClientCode"
        Me.colClientCode.Visible = True
        Me.colClientCode.VisibleIndex = 3
        Me.colClientCode.Width = 102
        '
        'colProductCode
        '
        Me.colProductCode.AppearanceCell.Options.UseTextOptions = True
        Me.colProductCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colProductCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductCode.Caption = "Product"
        Me.colProductCode.FieldName = "ProductCode"
        Me.colProductCode.Name = "colProductCode"
        Me.colProductCode.Visible = True
        Me.colProductCode.VisibleIndex = 4
        Me.colProductCode.Width = 84
        '
        'colModuleName
        '
        Me.colModuleName.AppearanceCell.Options.UseTextOptions = True
        Me.colModuleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colModuleName.AppearanceHeader.Options.UseTextOptions = True
        Me.colModuleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModuleName.Caption = "Module Name"
        Me.colModuleName.FieldName = "ModuleName"
        Me.colModuleName.Name = "colModuleName"
        Me.colModuleName.Visible = True
        Me.colModuleName.VisibleIndex = 6
        Me.colModuleName.Width = 155
        '
        'colOpenDate
        '
        Me.colOpenDate.AppearanceCell.Options.UseTextOptions = True
        Me.colOpenDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOpenDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colOpenDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOpenDate.Caption = "Open Date"
        Me.colOpenDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colOpenDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOpenDate.FieldName = "OpenDate"
        Me.colOpenDate.Name = "colOpenDate"
        Me.colOpenDate.Visible = True
        Me.colOpenDate.VisibleIndex = 5
        Me.colOpenDate.Width = 120
        '
        'colSummary
        '
        Me.colSummary.AppearanceCell.Options.UseTextOptions = True
        Me.colSummary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSummary.Caption = "Summary"
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        Me.colSummary.Visible = True
        Me.colSummary.VisibleIndex = 7
        Me.colSummary.Width = 120
        '
        'colDetail
        '
        Me.colDetail.AppearanceCell.Options.UseTextOptions = True
        Me.colDetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDetail.AppearanceHeader.Options.UseTextOptions = True
        Me.colDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDetail.Caption = "Detail"
        Me.colDetail.FieldName = "Detail"
        Me.colDetail.Name = "colDetail"
        Me.colDetail.Visible = True
        Me.colDetail.VisibleIndex = 10
        Me.colDetail.Width = 229
        '
        'colEstFSDMandays
        '
        Me.colEstFSDMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colEstFSDMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstFSDMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstFSDMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstFSDMandays.Caption = "Est. FSD Mandays"
        Me.colEstFSDMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colEstFSDMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstFSDMandays.FieldName = "EstFSDMandays"
        Me.colEstFSDMandays.Name = "colEstFSDMandays"
        Me.colEstFSDMandays.Visible = True
        Me.colEstFSDMandays.VisibleIndex = 11
        Me.colEstFSDMandays.Width = 120
        '
        'colEstDevMandays
        '
        Me.colEstDevMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colEstDevMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstDevMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstDevMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstDevMandays.Caption = "Est. Dev Mandays"
        Me.colEstDevMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colEstDevMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstDevMandays.FieldName = "EstDevMandays"
        Me.colEstDevMandays.Name = "colEstDevMandays"
        Me.colEstDevMandays.Visible = True
        Me.colEstDevMandays.VisibleIndex = 12
        Me.colEstDevMandays.Width = 120
        '
        'colEstTestMandays
        '
        Me.colEstTestMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colEstTestMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstTestMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstTestMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstTestMandays.Caption = "Est. Test Mandays"
        Me.colEstTestMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colEstTestMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstTestMandays.FieldName = "EstTestMandays"
        Me.colEstTestMandays.Name = "colEstTestMandays"
        Me.colEstTestMandays.Visible = True
        Me.colEstTestMandays.VisibleIndex = 13
        Me.colEstTestMandays.Width = 120
        '
        'colEstSupportMandays
        '
        Me.colEstSupportMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colEstSupportMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEstSupportMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstSupportMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstSupportMandays.Caption = "Est. Support Mandays"
        Me.colEstSupportMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colEstSupportMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstSupportMandays.FieldName = "EstSupportMandays"
        Me.colEstSupportMandays.Name = "colEstSupportMandays"
        Me.colEstSupportMandays.Visible = True
        Me.colEstSupportMandays.VisibleIndex = 14
        Me.colEstSupportMandays.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Est. Total Mandays"
        Me.GridColumn3.DisplayFormat.FormatString = "{#,###.##}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "EstTotalMandays"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 15
        Me.GridColumn3.Width = 120
        '
        'colFSDMandays
        '
        Me.colFSDMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colFSDMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colFSDMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colFSDMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFSDMandays.Caption = "FSD Mandays"
        Me.colFSDMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colFSDMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFSDMandays.FieldName = "FSDMandays"
        Me.colFSDMandays.Name = "colFSDMandays"
        Me.colFSDMandays.Visible = True
        Me.colFSDMandays.VisibleIndex = 16
        Me.colFSDMandays.Width = 120
        '
        'colDevMandays
        '
        Me.colDevMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colDevMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDevMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colDevMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDevMandays.Caption = "Dev Mandays"
        Me.colDevMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colDevMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDevMandays.FieldName = "DevMandays"
        Me.colDevMandays.Name = "colDevMandays"
        Me.colDevMandays.Visible = True
        Me.colDevMandays.VisibleIndex = 17
        Me.colDevMandays.Width = 120
        '
        'colTestMandays
        '
        Me.colTestMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colTestMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTestMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colTestMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTestMandays.Caption = "Test Mandays"
        Me.colTestMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colTestMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTestMandays.FieldName = "TestMandays"
        Me.colTestMandays.Name = "colTestMandays"
        Me.colTestMandays.Visible = True
        Me.colTestMandays.VisibleIndex = 18
        Me.colTestMandays.Width = 120
        '
        'colSupportMandays
        '
        Me.colSupportMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colSupportMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSupportMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupportMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupportMandays.Caption = "Support Mandays"
        Me.colSupportMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colSupportMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSupportMandays.FieldName = "SupportMandays"
        Me.colSupportMandays.Name = "colSupportMandays"
        Me.colSupportMandays.Visible = True
        Me.colSupportMandays.VisibleIndex = 19
        Me.colSupportMandays.Width = 120
        '
        'colTotalMandays
        '
        Me.colTotalMandays.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalMandays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalMandays.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalMandays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalMandays.Caption = "Total Mandays"
        Me.colTotalMandays.DisplayFormat.FormatString = "{#,###.##}"
        Me.colTotalMandays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalMandays.FieldName = "TotalMandays"
        Me.colTotalMandays.Name = "colTotalMandays"
        Me.colTotalMandays.Visible = True
        Me.colTotalMandays.VisibleIndex = 20
        Me.colTotalMandays.Width = 120
        '
        'colJobID
        '
        Me.colJobID.AppearanceCell.Options.UseTextOptions = True
        Me.colJobID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colJobID.AppearanceHeader.Options.UseTextOptions = True
        Me.colJobID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJobID.Caption = "Job No."
        Me.colJobID.FieldName = "JobNo"
        Me.colJobID.Name = "colJobID"
        Me.colJobID.Visible = True
        Me.colJobID.VisibleIndex = 25
        Me.colJobID.Width = 120
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Job Name"
        Me.GridColumn6.FieldName = "JobName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 21
        '
        'colFSDID
        '
        Me.colFSDID.Caption = "FSD No"
        Me.colFSDID.FieldName = "FSDNo"
        Me.colFSDID.Name = "colFSDID"
        Me.colFSDID.Visible = True
        Me.colFSDID.VisibleIndex = 22
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "FSD Name"
        Me.GridColumn5.FieldName = "FSDName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 23
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "FSD Date"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "FSDDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 24
        Me.GridColumn4.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Delivery Date"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "DeliveryDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 26
        Me.GridColumn2.Width = 120
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Sign Off Date"
        Me.GridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "SignOffDate"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 27
        Me.GridColumn1.Width = 120
        '
        'colDeliveryVersion
        '
        Me.colDeliveryVersion.AppearanceCell.Options.UseTextOptions = True
        Me.colDeliveryVersion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryVersion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDeliveryVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDeliveryVersion.Caption = "Delivery Version"
        Me.colDeliveryVersion.FieldName = "DeliveryVersion"
        Me.colDeliveryVersion.Name = "colDeliveryVersion"
        Me.colDeliveryVersion.Visible = True
        Me.colDeliveryVersion.VisibleIndex = 28
        Me.colDeliveryVersion.Width = 120
        '
        'colCreatedBy
        '
        Me.colCreatedBy.AppearanceCell.Options.UseTextOptions = True
        Me.colCreatedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedBy.Caption = "Created By"
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.Visible = True
        Me.colCreatedBy.VisibleIndex = 29
        Me.colCreatedBy.Width = 120
        '
        'colCreatedDate
        '
        Me.colCreatedDate.AppearanceCell.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.Caption = "Created Date"
        Me.colCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM:ss"
        Me.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 30
        Me.colCreatedDate.Width = 120
        '
        'colLastUpdatedBy
        '
        Me.colLastUpdatedBy.AppearanceCell.Options.UseTextOptions = True
        Me.colLastUpdatedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdatedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastUpdatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdatedBy.Caption = "Last Updated By"
        Me.colLastUpdatedBy.FieldName = "LastUpdatedBy"
        Me.colLastUpdatedBy.Name = "colLastUpdatedBy"
        Me.colLastUpdatedBy.Visible = True
        Me.colLastUpdatedBy.VisibleIndex = 31
        Me.colLastUpdatedBy.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ClientID"
        Me.GridColumn8.FieldName = "ClientID"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ProductID"
        Me.GridColumn7.FieldName = "ProductID"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'colLastUpdated
        '
        Me.colLastUpdated.AppearanceCell.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.Caption = "Last Updated"
        Me.colLastUpdated.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM:ss"
        Me.colLastUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastUpdated.FieldName = "LastUpdated"
        Me.colLastUpdated.Name = "colLastUpdated"
        Me.colLastUpdated.Visible = True
        Me.colLastUpdated.VisibleIndex = 32
        Me.colLastUpdated.Width = 120
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.InsertGalleryImage("converttoparagraphs_32x32.png", "images/reports/converttoparagraphs_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/converttoparagraphs_32x32.png"), 0)
        Me.ImageCollection1.Images.SetKeyName(0, "converttoparagraphs_32x32.png")
        Me.ImageCollection1.InsertGalleryImage("chartyaxissettings_32x32.png", "images/chart/chartyaxissettings_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/chartyaxissettings_32x32.png"), 1)
        Me.ImageCollection1.Images.SetKeyName(1, "chartyaxissettings_32x32.png")
        '
        'colPMO_No
        '
        Me.colPMO_No.AppearanceCell.Options.UseTextOptions = True
        Me.colPMO_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPMO_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colPMO_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPMO_No.Caption = "PMO No."
        Me.colPMO_No.FieldName = "PMO_No"
        Me.colPMO_No.Name = "colPMO_No"
        Me.colPMO_No.Visible = True
        Me.colPMO_No.VisibleIndex = 8
        Me.colPMO_No.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Item No."
        Me.GridColumn9.FieldName = "ItemNo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 100
        '
        'CRFormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Name = "CRFormView"
        Me.ShowPanelSearch = True
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModuleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpenDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstFSDMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstDevMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstTestMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstSupportMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFSDMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDevMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupportMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents colFSDID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPMO_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn

End Class
