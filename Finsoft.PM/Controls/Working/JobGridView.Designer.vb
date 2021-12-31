<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobGridView
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvCR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJob = New DevExpress.XtraGrid.GridControl()
        Me.gvJob = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuatationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuatationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatementOfworkDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMandays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPMO_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContractRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grboxMaster.SuspendLayout()
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxMaster
        '
        Me.grboxMaster.Controls.Add(Me.gcJob)
        Me.grboxMaster.Size = New System.Drawing.Size(890, 319)
        Me.grboxMaster.Controls.SetChildIndex(Me.gcJob, 0)
        '
        'gvCR
        '
        Me.gvCR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn5, Me.GridColumn6, Me.GridColumn12, Me.GridColumn11})
        Me.gvCR.GridControl = Me.gcJob
        Me.gvCR.Name = "gvCR"
        Me.gvCR.OptionsView.ColumnAutoWidth = False
        Me.gvCR.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "CR ID"
        Me.GridColumn1.FieldName = "CRID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 89
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "CR No"
        Me.GridColumn2.FieldName = "CRNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 89
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Client Code"
        Me.GridColumn3.FieldName = "ClientCode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 89
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Product Code"
        Me.GridColumn4.FieldName = "ProductCode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 89
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Module Name"
        Me.GridColumn7.FieldName = "ModuleName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 89
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Open Date"
        Me.GridColumn8.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "OpenDate"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 89
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Summary"
        Me.GridColumn9.FieldName = "Summary"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 343
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Detail"
        Me.GridColumn10.FieldName = "Detail"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 174
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "PO Ref. No."
        Me.GridColumn5.FieldName = "PORefNo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 89
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Item No."
        Me.GridColumn6.FieldName = "ItemNo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        Me.GridColumn6.Width = 80
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Estimated Total Mandays"
        Me.GridColumn12.FieldName = "EstTotalMandays"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 150
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Total Man days"
        Me.GridColumn11.FieldName = "TotalMandays"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 150
        '
        'gcJob
        '
        Me.gcJob.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvCR
        GridLevelNode1.RelationName = "Job_CR"
        Me.gcJob.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcJob.Location = New System.Drawing.Point(2, 2)
        Me.gcJob.MainView = Me.gvJob
        Me.gcJob.Name = "gcJob"
        Me.gcJob.Size = New System.Drawing.Size(886, 315)
        Me.gcJob.TabIndex = 31
        Me.gcJob.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJob, Me.gvCR})
        '
        'gvJob
        '
        Me.gvJob.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobID, Me.colProductCode, Me.colClientID, Me.colCRNo, Me.colJobName, Me.colQuatationDate, Me.colQuatationNo, Me.colStatementOfworkDate, Me.colAmount, Me.colTotalMandays, Me.colPO_NO, Me.colPMO_NO, Me.colInvoiceNo, Me.colContractRefNo, Me.colCreatedBy, Me.colCreatedDate, Me.colLastUpdatedBy, Me.colLastUpdated})
        Me.gvJob.GridControl = Me.gcJob
        Me.gvJob.Name = "gvJob"
        Me.gvJob.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvJob.OptionsSelection.MultiSelect = True
        Me.gvJob.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvJob.OptionsView.ColumnAutoWidth = False
        Me.gvJob.OptionsView.ShowGroupPanel = False
        '
        'colJobID
        '
        Me.colJobID.AppearanceCell.Options.UseTextOptions = True
        Me.colJobID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJobID.AppearanceHeader.Options.UseTextOptions = True
        Me.colJobID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJobID.Caption = "Job ID"
        Me.colJobID.FieldName = "JobID"
        Me.colJobID.Name = "colJobID"
        Me.colJobID.Visible = True
        Me.colJobID.VisibleIndex = 1
        Me.colJobID.Width = 103
        '
        'colProductCode
        '
        Me.colProductCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductCode.Caption = "Product Code"
        Me.colProductCode.FieldName = "ProductCode"
        Me.colProductCode.Name = "colProductCode"
        Me.colProductCode.Visible = True
        Me.colProductCode.VisibleIndex = 3
        Me.colProductCode.Width = 97
        '
        'colClientID
        '
        Me.colClientID.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientID.Caption = "Client Code"
        Me.colClientID.FieldName = "ClientCode"
        Me.colClientID.Name = "colClientID"
        Me.colClientID.Visible = True
        Me.colClientID.VisibleIndex = 2
        Me.colClientID.Width = 105
        '
        'colCRNo
        '
        Me.colCRNo.AppearanceCell.Options.UseTextOptions = True
        Me.colCRNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCRNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCRNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCRNo.Caption = "Job No."
        Me.colCRNo.FieldName = "JobNo"
        Me.colCRNo.Name = "colCRNo"
        Me.colCRNo.Visible = True
        Me.colCRNo.VisibleIndex = 4
        Me.colCRNo.Width = 81
        '
        'colJobName
        '
        Me.colJobName.AppearanceHeader.Options.UseTextOptions = True
        Me.colJobName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJobName.Caption = "Job Name"
        Me.colJobName.FieldName = "JobName"
        Me.colJobName.Name = "colJobName"
        Me.colJobName.Visible = True
        Me.colJobName.VisibleIndex = 5
        Me.colJobName.Width = 160
        '
        'colQuatationDate
        '
        Me.colQuatationDate.AppearanceCell.Options.UseTextOptions = True
        Me.colQuatationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuatationDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuatationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuatationDate.Caption = "Quatation Date"
        Me.colQuatationDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colQuatationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colQuatationDate.FieldName = "QuotationDate"
        Me.colQuatationDate.Name = "colQuatationDate"
        Me.colQuatationDate.Visible = True
        Me.colQuatationDate.VisibleIndex = 6
        Me.colQuatationDate.Width = 120
        '
        'colQuatationNo
        '
        Me.colQuatationNo.AppearanceCell.Options.UseTextOptions = True
        Me.colQuatationNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuatationNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuatationNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuatationNo.Caption = "Quatation No."
        Me.colQuatationNo.FieldName = "QuotationNo"
        Me.colQuatationNo.Name = "colQuatationNo"
        Me.colQuatationNo.Visible = True
        Me.colQuatationNo.VisibleIndex = 7
        Me.colQuatationNo.Width = 120
        '
        'colStatementOfworkDate
        '
        Me.colStatementOfworkDate.AppearanceCell.Options.UseTextOptions = True
        Me.colStatementOfworkDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatementOfworkDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colStatementOfworkDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatementOfworkDate.Caption = "Statement of work Date"
        Me.colStatementOfworkDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colStatementOfworkDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStatementOfworkDate.FieldName = "StatementOfworkDate"
        Me.colStatementOfworkDate.Name = "colStatementOfworkDate"
        Me.colStatementOfworkDate.Visible = True
        Me.colStatementOfworkDate.VisibleIndex = 8
        Me.colStatementOfworkDate.Width = 138
        '
        'colAmount
        '
        Me.colAmount.AppearanceCell.Options.UseTextOptions = True
        Me.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmount.Caption = "Amount"
        Me.colAmount.DisplayFormat.FormatString = "{0:n2}"
        Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 9
        Me.colAmount.Width = 120
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
        Me.colTotalMandays.VisibleIndex = 10
        Me.colTotalMandays.Width = 120
        '
        'colPO_NO
        '
        Me.colPO_NO.AppearanceCell.Options.UseTextOptions = True
        Me.colPO_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPO_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO_NO.Caption = "PO_NO"
        Me.colPO_NO.FieldName = "PO_NO"
        Me.colPO_NO.Name = "colPO_NO"
        Me.colPO_NO.Visible = True
        Me.colPO_NO.VisibleIndex = 11
        Me.colPO_NO.Width = 120
        '
        'colPMO_NO
        '
        Me.colPMO_NO.AppearanceCell.Options.UseTextOptions = True
        Me.colPMO_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPMO_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPMO_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPMO_NO.Caption = "PMO_NO"
        Me.colPMO_NO.FieldName = "PMO_NO"
        Me.colPMO_NO.Name = "colPMO_NO"
        Me.colPMO_NO.Visible = True
        Me.colPMO_NO.VisibleIndex = 12
        Me.colPMO_NO.Width = 120
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.AppearanceCell.Options.UseTextOptions = True
        Me.colInvoiceNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvoiceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvoiceNo.Caption = "InvoiceNo"
        Me.colInvoiceNo.FieldName = "InvoiceNo"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.Visible = True
        Me.colInvoiceNo.VisibleIndex = 13
        Me.colInvoiceNo.Width = 120
        '
        'colContractRefNo
        '
        Me.colContractRefNo.AppearanceCell.Options.UseTextOptions = True
        Me.colContractRefNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractRefNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colContractRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractRefNo.Caption = "Contract Ref. No"
        Me.colContractRefNo.FieldName = "ContractRefNo"
        Me.colContractRefNo.Name = "colContractRefNo"
        Me.colContractRefNo.Visible = True
        Me.colContractRefNo.VisibleIndex = 14
        Me.colContractRefNo.Width = 120
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
        Me.colCreatedBy.VisibleIndex = 15
        Me.colCreatedBy.Width = 120
        '
        'colCreatedDate
        '
        Me.colCreatedDate.AppearanceCell.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.Caption = "Created Date"
        Me.colCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 16
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
        Me.colLastUpdatedBy.VisibleIndex = 17
        Me.colLastUpdatedBy.Width = 120
        '
        'colLastUpdated
        '
        Me.colLastUpdated.AppearanceCell.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.Caption = "Last Updated"
        Me.colLastUpdated.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colLastUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastUpdated.FieldName = "LastUpdated"
        Me.colLastUpdated.Name = "colLastUpdated"
        Me.colLastUpdated.Visible = True
        Me.colLastUpdated.VisibleIndex = 18
        Me.colLastUpdated.Width = 120
        '
        'JobGridView
        '
        Me.Name = "JobGridView"
        Me.Size = New System.Drawing.Size(890, 359)
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grboxMaster.ResumeLayout(False)
        CType(Me.gvCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcJob As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvJob As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuatationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuatationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatementOfworkDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMandays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPMO_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContractRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdated As DevExpress.XtraGrid.Columns.GridColumn

End Class
