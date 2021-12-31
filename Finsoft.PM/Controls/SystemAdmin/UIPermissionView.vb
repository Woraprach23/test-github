Imports Finsoft.PM.Common.AppEnums

Public Class UIPermissionView
    Private _userRole As Data.UserRole
    Public Property CurrentRole As Data.UserRole
        Get
            If _userRole Is Nothing Then
                _userRole = New Data.UserRole
            End If
            Return _userRole
        End Get
        Set(value As Data.UserRole)
            _userRole = value
        End Set
    End Property


    Private Sub UIPermissionView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeList1.KeyFieldName = "UserInterfaceID"
        TreeList1.ParentFieldName = "UiParentID"
        TreeList1.ExpandAll()
        TreeList1.OptionsBehavior.Editable = EditMode <> Common.AppEnums.EditMode.View
    End Sub


#Region "UI Permission : Private methods"

    Private Sub SetNodeChecked(ByVal p_node As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim uiName As String = p_node.GetValue("UiCaption").ToString
        Dim row As DataRow = GetPermissionRow(uiName)

        If row IsNot Nothing Then
            p_node.Checked = CBool(row("IsPermission"))
            If CBool(row("IsPermission")) Then
                p_node.CheckState = CheckState.Checked
            Else
                p_node.CheckState = CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub TreeListMappingCheckedStateToDataSource()
        For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In TreeList1.Nodes
            Dim isSelect As Boolean = node.CheckState <> CheckState.Unchecked
            If node.CheckState = CheckState.Indeterminate Then
                Dim row As DataRow = GetPermissionRow(node.GetValue("UiCaption"))
                row("PermissionTypeID") = CInt(UiPermissionTypes.View)
            End If
        Next
    End Sub

    Private Sub TreeListMappingDataSourceToCheckedState()
        For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In TreeList1.Nodes
            TreeListMappingDataSourceToCheckedState(node)
        Next
    End Sub

    Private Sub TreeListMappingDataSourceToCheckedState(ByRef p_node As DevExpress.XtraTreeList.Nodes.TreeListNode)

        Dim UiCaption As String = p_node.GetValue("UiCaption").ToString
        Dim row As DataRow = GetPermissionRow(UiCaption)

        If row IsNot Nothing Then
            p_node.Checked = CBool(row("IsPermission"))
            If CBool(row("IsPermission")) Then
                p_node.CheckState = CheckState.Checked
            Else
                p_node.CheckState = CheckState.Unchecked
            End If
        End If

        If p_node.HasChildren Then
            For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In p_node.Nodes
                TreeListMappingDataSourceToCheckedState(node)
            Next
        End If


    End Sub

#End Region

#Region "UI Permission :DataTable"
    Private Function GetPermissionRow(ByVal p_UiCaption As String) As DataRow
        Dim rows() As DataRow = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("UiCaption = '{0}'", p_UiCaption))
        If rows.Length > 0 Then
            Return rows(0)
        End If
        Return Nothing
    End Function
#End Region

#Region "UI Permission : TreeList Events"

    Private Sub TreeList1_AfterCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles TreeList1.AfterCheckNode
        Dim id As Integer = e.Node.GetValue("UserInterfaceID")
        Dim isSelect As Boolean = e.Node.Checked

        Dim permissionType As Integer = CInt(e.Node.GetValue("PermissionTypeID"))

        If isSelect Then
            permissionType = CInt(UiPermissionTypes.View)
        Else
            permissionType = CInt(UiPermissionTypes.None)
        End If

        Dim row() As DataRow = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("{0} = {1}", "UserInterfaceID", id))

        If row.Length = 0 Then
            Return
        End If

        row(0)("IsPermission") = isSelect
        row(0)("PermissionTypeID") = permissionType
        CurrentRole.CurrentUIPermissions.Mapping(row(0))

        'Check If has child
        Dim childRows() As DataRow = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("UiParentID = {0}", id))
        For Each child As DataRow In childRows
            child("IsPermission") = isSelect
            child("PermissionTypeID") = permissionType
        Next

        'Check If has parent
        Dim ParentID As Integer = CurrentRole.CurrentUserInterface.UiParentID
        If ParentID > 0 Then
            Dim groupCount As Integer = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("UiParentID = {0}", ParentID)).Length
            Dim groupCountChecked As Integer = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("UiParentID = {0} AND IsPermission = {1}", ParentID, isSelect)).Length

            If groupCount = groupCountChecked Then
                row = CurrentRole.CurrentUIPermissions.DataSource.Select(String.Format("{0} = {1}", "UserInterfaceID", ParentID))
                If row.Length > 0 Then
                    row(0)("IsPermission") = isSelect
                    row(0)("PermissionTypeID") = permissionType
                End If

            End If
        End If

    End Sub

    Private Sub TreeList1_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeList1.BeforeCheckNode
        e.CanCheck = IsEditable
    End Sub

    Private Sub TreeList1_CellValueChanged(sender As System.Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeList1.CellValueChanged
        If e.Value Is Nothing OrElse IsDBNull(e.Value) OrElse e.Column.FieldName <> "PermissionTypeID" Then
            Return
        End If

        If CInt(e.Value) = CInt(UiPermissionTypes.None) Then
            e.Node.Checked = False
        Else
            e.Node.Checked = True
            CurrentRole.CurrentUIPermissions.IsPropertiesChanged = True
        End If
    End Sub

    Private Sub TreeList1_NodesReloaded(sender As System.Object, e As System.EventArgs) Handles TreeList1.NodesReloaded
        If TreeList1.DataSource Is Nothing Then
            Return
        End If
        TreeListMappingDataSourceToCheckedState()
    End Sub

    Private Sub TreeList1_CustomNodeCellEdit(sender As System.Object, e As DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs) Handles TreeList1.CustomNodeCellEdit
        If e.Node.Level = 0 Then
            If e.Column.FieldName = "PermissionTypeID" Then
                e.RepositoryItem = Nothing
            End If
        End If

    End Sub

    Private Sub TreeList1_CustomDrawNodeCell(sender As System.Object, e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles TreeList1.CustomDrawNodeCell
        If e.Node.Level = 0 And e.Column.FieldName = "UiCaption" Then
            e.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
            e.Appearance.Font = New Drawing.Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
        If e.Node.Level = 0 And e.Column.FieldName = "PermissionTypeID" Then
            e.CellText = String.Empty
        End If
    End Sub

#End Region

End Class
