<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRoleFromView
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
        Me.gcUserRole = New DevExpress.XtraGrid.GridControl()
        Me.gvUserRole = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserRoleCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserRoleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActve = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControlSearch.Size = New System.Drawing.Size(1115, 38)
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcUserRole)
        Me.PanelControl2.Size = New System.Drawing.Size(1115, 268)
        Me.PanelControl2.Controls.SetChildIndex(Me.gcUserRole, 0)
        '
        'gcUserRole
        '
        Me.gcUserRole.Cursor = System.Windows.Forms.Cursors.Default
        Me.gcUserRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUserRole.Location = New System.Drawing.Point(2, 2)
        Me.gcUserRole.MainView = Me.gvUserRole
        Me.gcUserRole.Name = "gcUserRole"
        Me.gcUserRole.Size = New System.Drawing.Size(1111, 264)
        Me.gcUserRole.TabIndex = 29
        Me.gcUserRole.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUserRole})
        '
        'gvUserRole
        '
        Me.gvUserRole.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserRoleCode, Me.colUserRoleName, Me.colDescription, Me.colIsActve, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gvUserRole.GridControl = Me.gcUserRole
        Me.gvUserRole.Name = "gvUserRole"
        Me.gvUserRole.OptionsView.ShowGroupPanel = False
        '
        'colUserRoleCode
        '
        Me.colUserRoleCode.AppearanceCell.Options.UseTextOptions = True
        Me.colUserRoleCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colUserRoleCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colUserRoleCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUserRoleCode.Caption = "User Role Code"
        Me.colUserRoleCode.FieldName = "UserRoleCode"
        Me.colUserRoleCode.Name = "colUserRoleCode"
        Me.colUserRoleCode.Visible = True
        Me.colUserRoleCode.VisibleIndex = 1
        Me.colUserRoleCode.Width = 141
        '
        'colUserRoleName
        '
        Me.colUserRoleName.AppearanceCell.Options.UseTextOptions = True
        Me.colUserRoleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colUserRoleName.AppearanceHeader.Options.UseTextOptions = True
        Me.colUserRoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUserRoleName.Caption = "User Role Name"
        Me.colUserRoleName.FieldName = "UserRoleName"
        Me.colUserRoleName.Name = "colUserRoleName"
        Me.colUserRoleName.Visible = True
        Me.colUserRoleName.VisibleIndex = 2
        Me.colUserRoleName.Width = 126
        '
        'colDescription
        '
        Me.colDescription.AppearanceCell.Options.UseTextOptions = True
        Me.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 132
        '
        'colIsActve
        '
        Me.colIsActve.AppearanceCell.Options.UseTextOptions = True
        Me.colIsActve.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsActve.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsActve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsActve.Caption = "IsActve"
        Me.colIsActve.FieldName = "IsActve"
        Me.colIsActve.Name = "colIsActve"
        Me.colIsActve.Visible = True
        Me.colIsActve.VisibleIndex = 3
        Me.colIsActve.Width = 199
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Created By"
        Me.GridColumn1.FieldName = "CreatedBy"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Created Date"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM:ss"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "CreatedDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Last Updated By"
        Me.GridColumn3.FieldName = "LastUpdatedBy"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Last Updated"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM:ss"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "LastUpdated"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
        '
        'UserRoleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1115, 346)
        Me.Name = "UserRoleView"
        CType(Me.PanelControlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcUserRole As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUserRole As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserRoleCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserRoleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

End Class
