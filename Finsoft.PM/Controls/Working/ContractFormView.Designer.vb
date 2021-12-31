<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractFormView
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
        Me.gcContract = New DevExpress.XtraGrid.GridControl()
        Me.gvContract = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colContractID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContractNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMainContractID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContractDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContractTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcContract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcContract)
        Me.PanelControl2.Size = New System.Drawing.Size(834, 243)
        Me.PanelControl2.Controls.SetChildIndex(Me.gcContract, 0)
        '
        'gcContract
        '
        Me.gcContract.Cursor = System.Windows.Forms.Cursors.Default
        Me.gcContract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcContract.Location = New System.Drawing.Point(2, 2)
        Me.gcContract.MainView = Me.gvContract
        Me.gcContract.Name = "gcContract"
        Me.gcContract.Size = New System.Drawing.Size(830, 239)
        Me.gcContract.TabIndex = 29
        Me.gcContract.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContract})
        '
        'gvContract
        '
        Me.gvContract.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colContractID, Me.colContractNo, Me.colClientID, Me.colProductID, Me.colMainContractID, Me.colContractDate, Me.colAmount, Me.colStartDate, Me.colEnddate, Me.colContractTypeID, Me.GridColumn3, Me.GridColumn2, Me.colCreatedBy, Me.colCreatedDate, Me.colLastUpdatedBy, Me.colLastUpdated})
        Me.gvContract.GridControl = Me.gcContract
        Me.gvContract.Name = "gvContract"
        Me.gvContract.OptionsView.ColumnAutoWidth = False
        Me.gvContract.OptionsView.ShowGroupPanel = False
        '
        'colContractID
        '
        Me.colContractID.AppearanceCell.Options.UseTextOptions = True
        Me.colContractID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractID.AppearanceHeader.Options.UseTextOptions = True
        Me.colContractID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractID.Caption = "Contract ID"
        Me.colContractID.FieldName = "ContractID"
        Me.colContractID.Name = "colContractID"
        Me.colContractID.Visible = True
        Me.colContractID.VisibleIndex = 0
        Me.colContractID.Width = 97
        '
        'colContractNo
        '
        Me.colContractNo.AppearanceCell.Options.UseTextOptions = True
        Me.colContractNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colContractNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractNo.Caption = "Contract No."
        Me.colContractNo.FieldName = "ContractNo"
        Me.colContractNo.Name = "colContractNo"
        Me.colContractNo.Visible = True
        Me.colContractNo.VisibleIndex = 1
        Me.colContractNo.Width = 119
        '
        'colClientID
        '
        Me.colClientID.AppearanceCell.Options.UseTextOptions = True
        Me.colClientID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientID.AppearanceHeader.Options.UseTextOptions = True
        Me.colClientID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClientID.Caption = "Client"
        Me.colClientID.FieldName = "ClientCode"
        Me.colClientID.Name = "colClientID"
        Me.colClientID.Visible = True
        Me.colClientID.VisibleIndex = 2
        Me.colClientID.Width = 120
        '
        'colProductID
        '
        Me.colProductID.AppearanceCell.Options.UseTextOptions = True
        Me.colProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductID.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductID.Caption = "Product"
        Me.colProductID.FieldName = "ProductCode"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Visible = True
        Me.colProductID.VisibleIndex = 3
        Me.colProductID.Width = 120
        '
        'colMainContractID
        '
        Me.colMainContractID.AppearanceCell.Options.UseTextOptions = True
        Me.colMainContractID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMainContractID.AppearanceHeader.Options.UseTextOptions = True
        Me.colMainContractID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMainContractID.Caption = "Main Contract "
        Me.colMainContractID.FieldName = "MainContractName"
        Me.colMainContractID.Name = "colMainContractID"
        Me.colMainContractID.Visible = True
        Me.colMainContractID.VisibleIndex = 4
        Me.colMainContractID.Width = 120
        '
        'colContractDate
        '
        Me.colContractDate.AppearanceCell.Options.UseTextOptions = True
        Me.colContractDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colContractDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractDate.Caption = "Contract Date"
        Me.colContractDate.FieldName = "ContractDate"
        Me.colContractDate.Name = "colContractDate"
        Me.colContractDate.Visible = True
        Me.colContractDate.VisibleIndex = 5
        Me.colContractDate.Width = 120
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
        Me.colAmount.VisibleIndex = 6
        Me.colAmount.Width = 120
        '
        'colStartDate
        '
        Me.colStartDate.AppearanceCell.Options.UseTextOptions = True
        Me.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStartDate.Caption = "StartDate"
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 7
        Me.colStartDate.Width = 120
        '
        'colEnddate
        '
        Me.colEnddate.AppearanceCell.Options.UseTextOptions = True
        Me.colEnddate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnddate.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnddate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnddate.Caption = "Enddate"
        Me.colEnddate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colEnddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEnddate.FieldName = "Enddate"
        Me.colEnddate.Name = "colEnddate"
        Me.colEnddate.Visible = True
        Me.colEnddate.VisibleIndex = 8
        Me.colEnddate.Width = 120
        '
        'colContractTypeID
        '
        Me.colContractTypeID.AppearanceCell.Options.UseTextOptions = True
        Me.colContractTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractTypeID.AppearanceHeader.Options.UseTextOptions = True
        Me.colContractTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContractTypeID.Caption = "Type"
        Me.colContractTypeID.FieldName = "ContractTypeID"
        Me.colContractTypeID.Name = "colContractTypeID"
        Me.colContractTypeID.Visible = True
        Me.colContractTypeID.VisibleIndex = 9
        Me.colContractTypeID.Width = 49
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
        Me.colCreatedBy.VisibleIndex = 12
        Me.colCreatedBy.Width = 120
        '
        'colCreatedDate
        '
        Me.colCreatedDate.AppearanceCell.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCreatedDate.Caption = "Created Date"
        Me.colCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM"
        Me.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 13
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
        Me.colLastUpdatedBy.VisibleIndex = 14
        Me.colLastUpdatedBy.Width = 120
        '
        'colLastUpdated
        '
        Me.colLastUpdated.AppearanceCell.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastUpdated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastUpdated.Caption = "Last Updated"
        Me.colLastUpdated.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM"
        Me.colLastUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastUpdated.FieldName = "LastUpdated"
        Me.colLastUpdated.Name = "colLastUpdated"
        Me.colLastUpdated.Visible = True
        Me.colLastUpdated.VisibleIndex = 15
        Me.colLastUpdated.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Quotation Name"
        Me.GridColumn2.FieldName = "QuotationName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 11
        Me.GridColumn2.Width = 167
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Quotation No"
        Me.GridColumn3.FieldName = "QuotationNo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 10
        Me.GridColumn3.Width = 117
        '
        'ContractFormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Name = "ContractFormView"
        Me.ShowPanelSearch = True
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcContract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcContract As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvContract As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClientID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMainContractID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContractDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContractID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContractTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContractNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
