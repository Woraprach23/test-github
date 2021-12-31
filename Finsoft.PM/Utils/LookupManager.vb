
Imports DevExpress.XtraEditors
Imports Finsoft.PM.Data 

Public Class LookupManager

#Region "LookUpEdit"
    Public Shared Sub LoadLookUpEdit(ByRef p_lookupEdit As DevExpress.XtraEditors.LookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueFieldName As String, ByVal p_DisplayFieldName As String, ByVal p_isUseDefault As Boolean, ByVal p_defaultValue As Object, ByVal p_defalutText As String)
        If (p_dataSource IsNot Nothing) Then
            If (p_isUseDefault) Then
                For Each col As DataColumn In p_dataSource.Columns
                    col.AllowDBNull = True
                Next
                Dim newRow As DataRow = p_dataSource.NewRow
                newRow(p_ValueFieldName) = p_defaultValue
                newRow(p_DisplayFieldName) = p_defalutText
                p_dataSource.Rows.InsertAt(newRow, 0)
            End If
        End If
        p_lookupEdit.Properties.Columns.Clear()
        p_lookupEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(p_DisplayFieldName))
        p_lookupEdit.Properties.NullText = String.Empty
        p_lookupEdit.Properties.DataSource = p_dataSource
        p_lookupEdit.Properties.ValueMember = p_ValueFieldName
        p_lookupEdit.Properties.DisplayMember = p_DisplayFieldName
        p_lookupEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        p_lookupEdit.Properties.ShowHeader = False
        p_lookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        If p_isUseDefault Then
            p_lookupEdit.EditValue = p_defaultValue
        End If

    End Sub
#End Region

#Region "RepositoryItemLookUpEdit"

    Public Shared Sub LoadLookUpEdit(ByRef p_lookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueFieldName As String, ByVal p_DisplayFieldName As String, ByVal p_isUseDefault As Boolean, ByVal p_defaultValue As Object, ByVal p_defalutText As String)
        LoadLookUpEdit(p_lookupEdit, p_dataSource, p_ValueFieldName, p_DisplayFieldName, p_isUseDefault, p_defaultValue, p_defalutText, Nothing)
    End Sub

    Public Shared Sub LoadLookUpEdit(ByRef p_lookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueFieldName As String, ByVal p_DisplayFieldName As String, ByVal p_isUseDefault As Boolean, ByVal p_defaultValue As Object, ByVal p_defalutText As String, ByVal p_columns() As String)
        If (p_dataSource IsNot Nothing) Then
            If (p_isUseDefault) Then
                For Each col As DataColumn In p_dataSource.Columns
                    col.AllowDBNull = True
                Next
                Dim newRow As DataRow = p_dataSource.NewRow
                newRow(p_ValueFieldName) = p_defaultValue
                newRow(p_DisplayFieldName) = p_defalutText
                p_dataSource.Rows.InsertAt(newRow, 0)
            End If
        End If
        p_lookupEdit.Columns.Clear()

        If p_columns Is Nothing Then
            p_lookupEdit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(p_DisplayFieldName))
        Else
            For Each strColumn As String In p_columns
                p_lookupEdit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(strColumn))
            Next
        End If

        p_lookupEdit.DataSource = p_dataSource
        p_lookupEdit.ValueMember = p_ValueFieldName
        p_lookupEdit.DisplayMember = p_DisplayFieldName
        p_lookupEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        p_lookupEdit.NullText = String.Empty
        p_lookupEdit.ShowHeader = False
    End Sub
#End Region

#Region "SearchLookUpEdit"

    Public Shared Sub LoadLookUpEdit(ByRef p_searchLookupEdit As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueField As String, ByVal p_DisplayField As String, ByVal p_ColumsName() As String)
        LoadLookUpEdit(p_searchLookupEdit, p_dataSource, p_ValueField, p_DisplayField, False, 0, Nothing, p_ColumsName)
        If p_dataSource IsNot Nothing Then
            If p_dataSource.Rows.Count = 1 Then
                p_searchLookupEdit.EditValue = p_dataSource.Rows(0)(p_ValueField)
            End If
        End If
    End Sub

    Public Shared Sub LoadLookUpEdit(ByRef p_searchLookupEdit As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueFieldName As String, ByVal p_DisplayFieldName As String, ByVal p_isUseDefault As Boolean, ByVal p_defaultValue As Object, ByVal p_defalutText As String, ByVal p_ColumsName() As String)
        If (p_dataSource IsNot Nothing) Then
            If (p_isUseDefault) Then
                For Each col As DataColumn In p_dataSource.Columns
                    col.AllowDBNull = True
                Next
                Dim newRow As DataRow = p_dataSource.NewRow
                newRow(p_ValueFieldName) = p_defaultValue
                newRow(p_DisplayFieldName) = p_defalutText
                p_dataSource.Rows.InsertAt(newRow, 0)
            End If
        End If

        p_searchLookupEdit.Properties.View.Columns.Clear()
        p_searchLookupEdit.Properties.View.Columns.AddField(p_DisplayFieldName).Visible = True

        If (p_ColumsName IsNot Nothing) Then
            Dim index As Integer = 0
            For Each field As String In p_ColumsName
                If p_searchLookupEdit.Properties.View.Columns(field) IsNot Nothing Then
                    ' p_searchLookupEdit.Properties.View.Columns(field).VisibleIndex = index
                Else
                    p_searchLookupEdit.Properties.View.Columns.AddField(field).Visible = True
                    If field.IndexOf("Code") >= 0 Then
                        p_searchLookupEdit.Properties.View.Columns.AddField(field).Width = 150
                    End If
                    If field.IndexOf("Name") >= 0 Then
                        p_searchLookupEdit.Properties.View.Columns.AddField(field).Width = 350
                    End If
                    ' p_searchLookupEdit.Properties.View.Columns(field).VisibleIndex = index
                End If

                index += 1
            Next

        Else
            p_searchLookupEdit.Properties.View.Columns.Clear()
            p_searchLookupEdit.Properties.View.Columns.AddField(p_DisplayFieldName).Visible = True
        End If
        p_searchLookupEdit.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        p_searchLookupEdit.Properties.NullText = String.Empty
        p_searchLookupEdit.Properties.DataSource = p_dataSource
        p_searchLookupEdit.Properties.ValueMember = p_ValueFieldName
        p_searchLookupEdit.Properties.DisplayMember = p_DisplayFieldName
        p_searchLookupEdit.Properties.View.OptionsFind.AlwaysVisible = True
        p_searchLookupEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        p_searchLookupEdit.Properties.BestFitWidth = (p_searchLookupEdit.Properties.View.Columns.Count * 200)
        If p_isUseDefault Then
            p_searchLookupEdit.EditValue = p_defaultValue
        Else
            If p_dataSource IsNot Nothing Then
                If p_dataSource.Rows.Count = 1 Then
                    p_searchLookupEdit.EditValue = p_dataSource.Rows(0)(p_ValueFieldName)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Search DevExpress.XtraEditors.GridlookupEdit"

    Public Shared Sub LoadLookUpGridEdit(ByRef p_searchLookupEdit As DevExpress.XtraEditors.GridLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_ValueField As String, ByVal p_DisplayField As String, ByVal p_ColumsName() As String)

        p_searchLookupEdit.Properties.View.OptionsSelection.EnableAppearanceFocusedRow = True
        p_searchLookupEdit.Properties.View.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = True
        p_searchLookupEdit.Properties.View.OptionsSelection.ShowCheckBoxSelectorInGroupRow = True
        p_searchLookupEdit.Properties.View.OptionsSelection.EnableAppearanceFocusedRow = True
        p_searchLookupEdit.Properties.NullText = String.Empty

        p_searchLookupEdit.Properties.ValueMember = p_ValueField
        p_searchLookupEdit.Properties.DisplayMember = p_DisplayField

        If (p_ColumsName IsNot Nothing) Then
            p_searchLookupEdit.Properties.View.Columns.Clear()
            For Each name In p_ColumsName
                Dim col As New DevExpress.XtraGrid.Columns.GridColumn
                col.FieldName = name
                p_searchLookupEdit.Properties.View.Columns.Add(col)
            Next
        End If

        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(p_searchLookupEdit.Properties.View, DevExpress.XtraGrid.Views.Grid.GridView)
        gridView.OptionsSelection.EnableAppearanceFocusedRow = True
        gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        gridView.OptionsSelection.MultiSelect = True
        gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        gridView.OptionsSelection.MultiSelect = True
        gridView.OptionsSelection.UseIndicatorForSelection = False
        gridView.OptionsFind.AllowFindPanel = True
        gridView.OptionsFind.ShowFindButton = True
        gridView.OptionsFind.AlwaysVisible = True
        gridView.OptionsView.ColumnAutoWidth = False
        p_searchLookupEdit.Properties.DataSource = p_dataSource
    End Sub

#End Region

#Region "Config"
    Public Shared Sub LoadLookUpEditConfig(ByRef p_searchLookupEdit As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_dataSource As DataTable)
        LoadLookUpEdit(p_searchLookupEdit, p_dataSource, "ConfigValue", "ConfigName", False, 0, Nothing, Nothing)
    End Sub
    Public Shared Sub LoadLookUpEditConfig(ByRef p_searchLookupEdit As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_dataSource As DataTable, ByVal p_hasDefault As Boolean)
        LoadLookUpEdit(p_searchLookupEdit, p_dataSource, "ConfigValue", "ConfigName", p_hasDefault, 0, Nothing, Nothing)
    End Sub

    Public Shared Sub LoadLookUpEditConfig(ByRef p_lookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal p_dataSource As DataTable)
        LoadLookUpEdit(p_lookupEdit, p_dataSource, "ConfigValue", "ConfigDisplayText", False, 0, String.Empty)
    End Sub

    Public Shared Sub LoadLookUpEditConfig(ByRef p_lookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal p_group As DataEnums.ConfigGroup)
        Dim dt = Data.ConfigService.GetConfigData(p_group)
        LoadLookUpEdit(p_lookupEdit, dt, "ConfigValue", "ConfigDisplayText", False, 0, String.Empty)
    End Sub

    Public Shared Sub LoadLookUpEditConfig(ByRef p_lookupEdit As DevExpress.XtraEditors.LookUpEdit, ByVal p_ds As DataTable, ByVal p_hasDefault As Boolean)
        LoadLookUpEdit(p_lookupEdit, p_ds, "ConfigValue", "ConfigName", p_hasDefault, 0, String.Empty)
    End Sub
#End Region

#Region "Get FieldValue"
    'Public Shared Function GetValueByKey(ByRef p_slue As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_field As String, ByVal p_nullValue As Object) As Object
    '    If p_slue.Properties.DataSource Is Nothing Then
    '        Return p_nullValue
    '    End If
    '    If Not ControlManager.CheckHasValue(p_slue) Then
    '        Return p_nullValue
    '    End If
    '    Dim value As Object = GetValueByKey(p_slue, p_field)
    '    If value Is Nothing Or IsDBNull(value) Then
    '        Return p_nullValue
    '    End If
    '    Return value
    'End Function
    'Public Shared Function GetValueByKey(ByRef p_slue As DevExpress.XtraEditors.SearchLookUpEdit, ByVal p_field As String) As Object
    '    If IsDBNull(p_slue.EditValue) OrElse p_slue.EditValue Is Nothing OrElse _
    '      (TypeOf (p_slue.EditValue) Is String AndAlso p_slue.EditValue = String.Empty) OrElse _
    '      ((TypeOf (p_slue.EditValue) Is Integer) Or (TypeOf (p_slue.EditValue) Is Decimal)) AndAlso p_slue.EditValue = 0 Then
    '        Return Nothing
    '    End If
    '    Dim dt As DataTable = p_slue.Properties.DataSource
    '    If dt Is Nothing Then
    '        Return Nothing
    '    End If

    '    Dim rows() As DataRow = dt.Select(String.Format("{0} = {1}", p_slue.Properties.ValueMember, Finsoft.NCR.Common.DataTypeConvertor.GetSQLString(p_slue.EditValue)))
    '    If rows.Length = 0 Then
    '        Return Nothing

    '    End If

    '    Return rows(0)(p_field)
    'End Function
#End Region

End Class
