<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRGridView
    Inherits PM.UI.GridviewBase

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
        Me.gcCR = New DevExpress.XtraGrid.GridControl()
        Me.gvCR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grboxMaster.SuspendLayout()
        CType(Me.gcCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxMaster
        '
        Me.grboxMaster.Controls.Add(Me.gcCR)
        Me.grboxMaster.Controls.SetChildIndex(Me.gcCR, 0)
        '
        'gcCR
        '
        Me.gcCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCR.Location = New System.Drawing.Point(2, 2)
        Me.gcCR.MainView = Me.gvCR
        Me.gcCR.Name = "gcCR"
        Me.gcCR.Size = New System.Drawing.Size(850, 233)
        Me.gcCR.TabIndex = 30
        Me.gcCR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCR})
        '
        'gvCR
        '
        Me.gvCR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCRNo, Me.colClientID, Me.colProductID, Me.colModuleName, Me.colOpenDate, Me.colSummary, Me.colDetail, Me.colEstFSDMandays, Me.colEstDevMandays, Me.colEstTestMandays, Me.colEstSupportMandays, Me.GridColumn3, Me.colFSDMandays, Me.colDevMandays, Me.colTestMandays, Me.colSupportMandays, Me.colTotalMandays, Me.colJobID, Me.GridColumn4, Me.GridColumn2, Me.GridColumn1, Me.colDeliveryVersion, Me.colCreatedBy, Me.colCreatedDate, Me.colLastUpdatedBy, Me.colLastUpdated})
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
        'colClientID
        '
        Me.colClientID.AppearanceCell.Options.UseTextOptions = True
        Me.colClientID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colClientID.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientID.Caption = "Client"
        Me.colClientID.FieldName = "ClientID"
        Me.colClientID.Name = "colClientID"
        Me.colClientID.Visible = True
        Me.colClientID.VisibleIndex = 3
        Me.colClientID.Width = 102
        '
        'colProductID
        '
        Me.colProductID.AppearanceCell.Options.UseTextOptions = True
        Me.colProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colProductID.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductID.Caption = "Product"
        Me.colProductID.FieldName = "ProductID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Visible = True
        Me.colProductID.VisibleIndex = 4
        Me.colProductID.Width = 84
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
        Me.colDetail.VisibleIndex = 8
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
        Me.colEstFSDMandays.VisibleIndex = 9
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
        Me.colEstDevMandays.VisibleIndex = 10
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
        Me.colEstTestMandays.VisibleIndex = 11
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
        Me.colEstSupportMandays.VisibleIndex = 12
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
        Me.GridColumn3.VisibleIndex = 13
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
        Me.colFSDMandays.VisibleIndex = 14
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
        Me.colDevMandays.VisibleIndex = 15
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
        Me.colTestMandays.VisibleIndex = 16
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
        Me.colSupportMandays.VisibleIndex = 17
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
        Me.colTotalMandays.VisibleIndex = 18
        Me.colTotalMandays.Width = 120
        '
        'colJobID
        '
        Me.colJobID.AppearanceCell.Options.UseTextOptions = True
        Me.colJobID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colJobID.AppearanceHeader.Options.UseTextOptions = True
        Me.colJobID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJobID.Caption = "Job No."
        Me.colJobID.FieldName = "JobID"
        Me.colJobID.Name = "colJobID"
        Me.colJobID.Visible = True
        Me.colJobID.VisibleIndex = 19
        Me.colJobID.Width = 120
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
        Me.GridColumn4.VisibleIndex = 20
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
        Me.GridColumn2.VisibleIndex = 21
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
        Me.GridColumn1.VisibleIndex = 22
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
        Me.colDeliveryVersion.VisibleIndex = 23
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
        Me.colCreatedBy.VisibleIndex = 24
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
        Me.colCreatedDate.VisibleIndex = 25
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
        Me.colLastUpdatedBy.VisibleIndex = 26
        Me.colLastUpdatedBy.Width = 120
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
        Me.colLastUpdated.VisibleIndex = 27
        Me.colLastUpdated.Width = 120
        '
        'CRGridView
        '
        Me.Name = "CRGridView"
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grboxMaster.ResumeLayout(False)
        CType(Me.gcCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModuleName As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdated As DevExpress.XtraGrid.Columns.GridColumn

End Class
