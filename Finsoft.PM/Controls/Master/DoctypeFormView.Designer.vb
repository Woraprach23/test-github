<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctypeFormView
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
        Me.gcDoctype = New DevExpress.XtraGrid.GridControl()
        Me.gvDoctype = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDoctypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoctype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcDoctype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDoctype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcDoctype)
        Me.PanelControl2.Controls.SetChildIndex(Me.gcDoctype, 0)
        '
        'gcDoctype
        '
        Me.gcDoctype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDoctype.Location = New System.Drawing.Point(2, 2)
        Me.gcDoctype.MainView = Me.gvDoctype
        Me.gcDoctype.Name = "gcDoctype"
        Me.gcDoctype.Size = New System.Drawing.Size(830, 264)
        Me.gcDoctype.TabIndex = 29
        Me.gcDoctype.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDoctype})
        '
        'gvDoctype
        '
        Me.gvDoctype.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDoctypeID, Me.colDoctype, Me.colCreatedBy, Me.colCreatedDate, Me.colLastUpdatedBy, Me.colLastUpdated})
        Me.gvDoctype.GridControl = Me.gcDoctype
        Me.gvDoctype.Name = "gvDoctype"
        Me.gvDoctype.OptionsView.ColumnAutoWidth = False
        Me.gvDoctype.OptionsView.ShowGroupPanel = False
        '
        'colDoctypeID
        '
        Me.colDoctypeID.AppearanceCell.Options.UseTextOptions = True
        Me.colDoctypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDoctypeID.AppearanceHeader.Options.UseTextOptions = True
        Me.colDoctypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDoctypeID.Caption = "ID"
        Me.colDoctypeID.FieldName = "DoctypeID"
        Me.colDoctypeID.Name = "colDoctypeID"
        Me.colDoctypeID.Visible = True
        Me.colDoctypeID.VisibleIndex = 0
        Me.colDoctypeID.Width = 61
        '
        'colDoctype
        '
        Me.colDoctype.AppearanceCell.Options.UseTextOptions = True
        Me.colDoctype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDoctype.AppearanceHeader.Options.UseTextOptions = True
        Me.colDoctype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDoctype.Caption = "Doctype"
        Me.colDoctype.FieldName = "Doctype"
        Me.colDoctype.Name = "colDoctype"
        Me.colDoctype.Visible = True
        Me.colDoctype.VisibleIndex = 1
        Me.colDoctype.Width = 150
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
        Me.colCreatedBy.VisibleIndex = 2
        Me.colCreatedBy.Width = 100
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
        Me.colCreatedDate.VisibleIndex = 3
        Me.colCreatedDate.Width = 100
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
        Me.colLastUpdatedBy.VisibleIndex = 4
        Me.colLastUpdatedBy.Width = 100
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
        Me.colLastUpdated.VisibleIndex = 5
        Me.colLastUpdated.Width = 100
        '
        'DoctypeFormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Name = "DoctypeFormView"
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcDoctype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDoctype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcDoctype As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDoctype As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDoctypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoctype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdated As DevExpress.XtraGrid.Columns.GridColumn

End Class
