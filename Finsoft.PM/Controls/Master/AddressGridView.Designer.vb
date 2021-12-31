<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressGridView
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
        Me.GridControlClient = New DevExpress.XtraGrid.GridControl()
        Me.GridViewClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAddressID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grboxMaster.SuspendLayout()
        CType(Me.GridControlClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxMaster
        '
        Me.grboxMaster.Controls.Add(Me.GridControlClient)
        Me.grboxMaster.Controls.SetChildIndex(Me.GridControlClient, 0)
        '
        'GridControlClient
        '
        Me.GridControlClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlClient.Location = New System.Drawing.Point(2, 2)
        Me.GridControlClient.MainView = Me.GridViewClient
        Me.GridControlClient.Name = "GridControlClient"
        Me.GridControlClient.Size = New System.Drawing.Size(850, 233)
        Me.GridControlClient.TabIndex = 6
        Me.GridControlClient.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewClient})
        '
        'GridViewClient
        '
        Me.GridViewClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAddressID, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colCreatedBy, Me.GridColumn6, Me.colLastUpdatedBy, Me.GridColumn5})
        Me.GridViewClient.GridControl = Me.GridControlClient
        Me.GridViewClient.Name = "GridViewClient"
        Me.GridViewClient.OptionsView.ColumnAutoWidth = False
        Me.GridViewClient.OptionsView.ShowGroupPanel = False
        '
        'colAddressID
        '
        Me.colAddressID.AppearanceCell.Options.UseTextOptions = True
        Me.colAddressID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddressID.AppearanceHeader.Options.UseTextOptions = True
        Me.colAddressID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAddressID.Caption = "Address ID"
        Me.colAddressID.FieldName = "AddressID"
        Me.colAddressID.Name = "colAddressID"
        Me.colAddressID.Visible = True
        Me.colAddressID.VisibleIndex = 0
        Me.colAddressID.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Address1"
        Me.GridColumn2.FieldName = "Address1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Address3"
        Me.GridColumn3.FieldName = "Address3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 200
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Address2"
        Me.GridColumn4.FieldName = "Address2"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 200
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
        Me.colCreatedBy.VisibleIndex = 4
        Me.colCreatedBy.Width = 120
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Created Date"
        Me.GridColumn6.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "CreatedDate"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 120
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
        Me.colLastUpdatedBy.VisibleIndex = 6
        Me.colLastUpdatedBy.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Last Updated"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "LastUpdated"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 120
        '
        'AddressGridView
        '
        Me.Name = "AddressGridView"
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grboxMaster.ResumeLayout(False)
        CType(Me.GridControlClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControlClient As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewClient As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAddressID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

End Class
