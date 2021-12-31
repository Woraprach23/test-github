<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttachFileGridView
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
        Me.gcFiles = New DevExpress.XtraGrid.GridControl()
        Me.gvFiles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferenceTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grboxMaster.SuspendLayout()
        CType(Me.gcFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxMaster
        '
        Me.grboxMaster.Controls.Add(Me.gcFiles)
        Me.grboxMaster.Controls.SetChildIndex(Me.gcFiles, 0)
        '
        'gcFiles
        '
        Me.gcFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcFiles.Location = New System.Drawing.Point(2, 2)
        Me.gcFiles.MainView = Me.gvFiles
        Me.gcFiles.Name = "gcFiles"
        Me.gcFiles.Size = New System.Drawing.Size(850, 233)
        Me.gcFiles.TabIndex = 32
        Me.gcFiles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFiles})
        '
        'gvFiles
        '
        Me.gvFiles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.colReferenceTypeID, Me.colDocTypeID, Me.GridColumn3, Me.GridColumn5, Me.colExtension, Me.colCreatedBy, Me.GridColumn34, Me.colLastUpdatedBy, Me.GridColumn32})
        Me.gvFiles.GridControl = Me.gcFiles
        Me.gvFiles.Name = "gvFiles"
        Me.gvFiles.OptionsView.ColumnAutoWidth = False
        Me.gvFiles.OptionsView.ShowGroupPanel = False
        Me.gvFiles.ViewCaption = "Attach Files"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "File ID"
        Me.GridColumn4.FieldName = "FileID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colReferenceTypeID
        '
        Me.colReferenceTypeID.AppearanceCell.Options.UseTextOptions = True
        Me.colReferenceTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReferenceTypeID.AppearanceHeader.Options.UseTextOptions = True
        Me.colReferenceTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReferenceTypeID.Caption = "Type"
        Me.colReferenceTypeID.FieldName = "ReferenceTypeID"
        Me.colReferenceTypeID.Name = "colReferenceTypeID"
        Me.colReferenceTypeID.Visible = True
        Me.colReferenceTypeID.VisibleIndex = 2
        '
        'colDocTypeID
        '
        Me.colDocTypeID.AppearanceCell.Options.UseTextOptions = True
        Me.colDocTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDocTypeID.AppearanceHeader.Options.UseTextOptions = True
        Me.colDocTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDocTypeID.Caption = "Doc Type"
        Me.colDocTypeID.FieldName = "DocTypeID"
        Me.colDocTypeID.Name = "colDocTypeID"
        Me.colDocTypeID.Visible = True
        Me.colDocTypeID.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "File Name"
        Me.GridColumn3.FieldName = "FileName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 314
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "File Size"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n0} KB"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "FileSize"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'colExtension
        '
        Me.colExtension.Caption = "Extension"
        Me.colExtension.FieldName = "Extension"
        Me.colExtension.Name = "colExtension"
        Me.colExtension.Visible = True
        Me.colExtension.VisibleIndex = 5
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
        Me.colCreatedBy.Width = 100
        '
        'GridColumn34
        '
        Me.GridColumn34.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.Caption = "Created Date"
        Me.GridColumn34.DisplayFormat.FormatString = "dd/MM/yyyy HH:MM:ss"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn34.FieldName = "CreatedDate"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 6
        Me.GridColumn34.Width = 100
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
        Me.colLastUpdatedBy.VisibleIndex = 8
        Me.colLastUpdatedBy.Width = 100
        '
        'GridColumn32
        '
        Me.GridColumn32.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.Caption = "Last Updated"
        Me.GridColumn32.DisplayFormat.FormatString = "dd/MM/yyyy HH:MM:ss"
        Me.GridColumn32.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn32.FieldName = "LastUpdated"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 7
        Me.GridColumn32.Width = 100
        '
        'AttachFileGridView
        '
        Me.Name = "AttachFileGridView"
        CType(Me.grboxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grboxMaster.ResumeLayout(False)
        CType(Me.gcFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcFiles As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFiles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenceTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtension As DevExpress.XtraGrid.Columns.GridColumn

End Class
