<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIPermissionView
    Inherits PM.UI.ControlBase

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
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.UIPermissionID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.UiParentID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.UiCaption = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PermissionTypeID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.UIPermissionID, Me.UiParentID, Me.UiCaption, Me.TreeListColumn4, Me.PermissionTypeID})
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.Size = New System.Drawing.Size(580, 383)
        Me.TreeList1.TabIndex = 0
        '
        'UIPermissionID
        '
        Me.UIPermissionID.Caption = "TreeListColumn1"
        Me.UIPermissionID.FieldName = "UIPermissionID"
        Me.UIPermissionID.Name = "UIPermissionID"
        '
        'UiParentID
        '
        Me.UiParentID.Caption = "TreeListColumn2"
        Me.UiParentID.FieldName = "UiParentID"
        Me.UiParentID.Name = "UiParentID"
        '
        'UiCaption
        '
        Me.UiCaption.Caption = "Name"
        Me.UiCaption.FieldName = "UiCaption"
        Me.UiCaption.Name = "UiCaption"
        Me.UiCaption.Visible = True
        Me.UiCaption.VisibleIndex = 0
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "Description"
        Me.TreeListColumn4.FieldName = "Description"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.Visible = True
        Me.TreeListColumn4.VisibleIndex = 1
        '
        'PermissionTypeID
        '
        Me.PermissionTypeID.Caption = "Permission Type"
        Me.PermissionTypeID.FieldName = "PermissionTypeID"
        Me.PermissionTypeID.Name = "PermissionTypeID"
        Me.PermissionTypeID.Visible = True
        Me.PermissionTypeID.VisibleIndex = 2
        '
        'UIPermissionView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.TreeList1)
        Me.Name = "UIPermissionView"
        Me.Size = New System.Drawing.Size(580, 383)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents UIPermissionID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents UiParentID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents UiCaption As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents PermissionTypeID As DevExpress.XtraTreeList.Columns.TreeListColumn

End Class
