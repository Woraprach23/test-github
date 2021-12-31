Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports System.Collections
Imports DevExpress.Utils.Menu
Imports Finsoft.PM.Common

Public Class FormViewMaster

#Region "Protect Properties"
    Protected Property HasRowNoColumn As Boolean = False
    Protected Property GridViewMasterName As String
    Protected Property AllowCopy As Boolean = False
    Protected Property AllowAdd As Boolean = True 
#End Region

#Region "Public Properties"
    Public Property HasUpdatingColumn As Boolean = True
    Public Property AutoLoad As Boolean = True
    Public Property PermissionType As AppEnums.UiPermissionTypes = AppEnums.UiPermissionTypes.Edit
#End Region
     
#Region "Events"
    Protected Friend Event DeleteCompleted(ByVal p_ID As Integer)
    Protected Friend Event UpdateCompleted(ByVal p_ID As Integer)
    Protected Friend Event GridViewFocusedRowChanged(ByVal p_ID As Integer)
    Protected Friend Event LoadDataSourceCompleted(ByVal p_count As Integer)
#End Region

#Region "Properties"

    Public Property ShowAddPanel As Boolean
        Get
            Return xtraBarMain.Visible
        End Get
        Set(value As Boolean)
            xtraBarMain.Visible = value
        End Set
    End Property

    Public Property ShowPanelSearch As Boolean
        Get
            Return PanelControlSearch.Visible
        End Get
        Set(value As Boolean)
            PanelControlSearch.Visible = value
        End Set
    End Property

    Private _Config As ConfigHasTableService
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property Config As ConfigHasTableService
        Get
            If (_Config Is Nothing) Then
                _Config = New ConfigHasTableService
            End If
            Return _Config
        End Get
        Set(value As ConfigHasTableService)
            _Config = value
        End Set
    End Property

    Protected _gridControl As GridControl
    Public Property CurrentGridControl As GridControl
        Get
            Return _gridControl
        End Get
        Set(value As GridControl)
            _gridControl = value
        End Set
    End Property

    Protected _gridview As GridView
    Public Property CurrentGridView As GridView
        Get
            Return _gridview
        End Get
        Set(value As GridView)
            _gridview = value
            If (_gridview IsNot Nothing) Then
                GridViewMasterName = _gridview.Name
                SetGridProperties(_gridview)
                '_gridview.Appearance.FocusedRow.BackColor = Color.CornflowerBlue
                '_gridview.Appearance.FocusedRow.ForeColor = Color.White
                '_gridview.Appearance.SelectedRow.BackColor = Color.Orange
                '_gridview.Appearance.SelectedRow.ForeColor = Color.White
                '_gridview.OptionsSelection.EnableAppearanceFocusedRow = True
                '_gridview.OptionsSelection.EnableAppearanceFocusedCell = False
                '_gridview.OptionsBehavior.Editable = False
                '_gridview.OptionsBehavior.AutoExpandAllGroups = True
                '_gridview.OptionsView.ShowGroupedColumns = True
                '_gridview.OptionsView.EnableAppearanceEvenRow = True
                'AddHandler _gridview.PopupMenuShowing, AddressOf MainGridView_PopupMenuShowing
                'AddHandler _gridview.FocusedRowChanged, AddressOf gv_FocusedRowChanged
                'AddHandler _gridview.DoubleClick, AddressOf gv_DoubleClick

                'SetGridViewTotalSummary(_gridview)
            End If
        End Set
    End Property

    Public Property IsMutiSelect As Boolean
        Get
            If (_gridview IsNot Nothing) Then
                Return _gridview.OptionsSelection.MultiSelect
            End If
            Return False
        End Get
        Set(value As Boolean)
            If (_gridview IsNot Nothing) Then
                _gridview.OptionsSelection.MultiSelect = value
                If (value) Then
                    _gridview.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
                    _gridview.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
                End If
            End If
        End Set
    End Property

    Private _dataSource As Object
    Public Property DataSource As Object
        Get
            Return _dataSource
        End Get
        Set(value As Object)
            _dataSource = value
            If (_gridControl IsNot Nothing) Then
                _gridControl.DataSource = _dataSource
                _gridControl.RefreshDataSource()
            End If
        End Set
    End Property

    Private _rowFilter As String
    Public Property RowFilter As String
        Get
            Return _rowFilter
        End Get
        Set(value As String)
            If (value <> _rowFilter) Then
                _rowFilter = value
            End If
        End Set
    End Property

    Public Property KeyFieldName As String
    Protected _menuItems As List(Of DXMenuItem)
    Protected _isLoadMenu As Boolean
    Protected _dataSet As DataSet

    'Private _editType As AppEnums.GridviewType = AppEnums.GridviewType.EditForm
    'Public Property GridviewType As AppEnums.GridviewType
    '    Get
    '        Return _editType
    '    End Get
    '    Set(value As AppEnums.GridviewType)
    '        If (_editType = value) Then
    '            Return
    '        End If

    '        _editType = value
    '    End Set
    'End Property
#End Region

#Region "Load"
    Private Sub GridViewBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.DesignMode) Then
            Return
        End If
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")
        System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("en-GB", False)

        If (Not _isRegisteredGrid) Then
            RegisterGridControl()
            _isRegisteredGrid = True
        End If

        RestoreLayout()

        DoWorkLoadGridLookup()

        If (HasUpdatingColumn) Then
            DoWorkLoadGridLookupUpdatingColumns()
        End If

        If (AutoLoad) Then
            LoadDataSource()
        End If

        SetButtomVisible()
    End Sub

    Protected Overridable Sub InitializeDXMenuItems()
        If (_isLoadMenu) Then
            Return
        End If
        _menuItems = New List(Of DXMenuItem)
        Dim itemExport As New DXMenuItem("Export", AddressOf ItemExportGridView_Click)
        'itemExport.Image = ""
        _menuItems.Add(itemExport)

        'If (PermissionType = AppEnums.UiPermissionTypes.Edit) Then
        '    Dim itemCopy As New DXMenuItem("Copy", AddressOf ItemDelete_Click)
        '    _menuItems.Add(itemCopy)

        'Dim itemEdit As New DXMenuItem("Edit", AddressOf ItemEdit_Click)
        '_menuItems.Add(itemEdit)

        'Dim itemDelete As New DXMenuItem("Delete", AddressOf ItemDelete_Click)
        '_menuItems.Add(itemDelete)
        'End If

        'If (PermissionType = AppEnums.UiPermissionTypes.Edit) Then
        '    Dim itemDelete As New DXMenuItem("Delete", AddressOf ItemDelete_Click)
        '    _menuItems.Add(itemDelete)
        'End If

        _isLoadMenu = True

    End Sub

    Public Overridable Sub RegisterGridControl()

    End Sub
     
    Protected Sub SetGridProperties(ByRef p_gridView As GridView)
        SetGridProperties(p_gridView, True)
    End Sub

    Protected Sub SetGridProperties(ByRef p_gridView As GridView, ByVal p_addGridEvent As Boolean)
        p_gridView.Appearance.FocusedRow.BackColor = Color.CornflowerBlue  'CornflowerBlue.
        p_gridView.Appearance.FocusedRow.ForeColor = Color.White
        p_gridView.Appearance.SelectedRow.BackColor = Color.Orange   'CornflowerBlue.
        p_gridView.Appearance.SelectedRow.ForeColor = Color.White
        p_gridView.OptionsSelection.EnableAppearanceFocusedRow = True
        p_gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        p_gridView.OptionsBehavior.Editable = False
        p_gridView.OptionsBehavior.AutoExpandAllGroups = True
        p_gridView.OptionsView.ShowGroupedColumns = True
        p_gridView.OptionsView.EnableAppearanceEvenRow = True
        AddHandler p_gridView.PopupMenuShowing, AddressOf MainGridView_PopupMenuShowing
        AddHandler p_gridView.FocusedRowChanged, AddressOf gv_FocusedRowChanged
        AddHandler p_gridView.DoubleClick, AddressOf gv_DoubleClick
        AddHandler p_gridView.CustomDrawCell, AddressOf gv_CustomDrawCell
        SetGridViewTotalSummary(p_gridView)
    End Sub

    Protected Overridable Sub SetButtomVisible()
        PanelControlSearch.Visible = False
        If (AutoLoad) Then
            bbiRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            bbiRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If (AllowCopy) Then
            bbiCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            bbiCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If (AllowAdd) Then
            bbiNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            bbiNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        'If (GridviewType = AppEnums.GridviewType.EditForm) Then
        '    bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    bbiCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'End If

        'If (GridviewType = AppEnums.GridviewType.GridEdit) Then
        '    bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '    bbiCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If
    End Sub

    Protected Sub SetCustomButton1(ByVal p_caption As String, ByRef p_image As Image)
        bbiCustom1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        bbiCustom1.Caption = p_caption
        If (p_image IsNot Nothing) Then
            bbiCustom2.LargeGlyph = p_image
        End If
        AddHandler bbiCustom1.ItemClick, AddressOf bbiCustomButton_Click
    End Sub

    Protected Sub SetCustomButton2(ByVal p_caption As String, ByRef p_image As Image)
        bbiCustom2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        bbiCustom2.Caption = p_caption
        If (p_image IsNot Nothing) Then
            bbiCustom2.LargeGlyph = p_image
        End If
        AddHandler bbiCustom2.ItemClick, AddressOf bbiCustomButton_Click
    End Sub

    Protected Overridable Sub AddCustomButton(ByVal p_id As Integer, ByVal p_name As String, ByVal p_caption As String, ByRef p_image As Image)
        Dim bbiCustom = New DevExpress.XtraBars.BarLargeButtonItem(BarManager1, p_caption)
        bbiCustom.Name = p_name
        bbiCustom.LargeGlyph = p_image
        bbiCustom.Glyph = p_image
        bbiCustom.Caption = p_caption
        bbiCustom.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        bbiCustom.Id = p_id
        AddHandler bbiCustom.ItemClick, AddressOf bbiCustomButton_Click
        xtraBarMain.ItemLinks.Add(bbiCustom)
    End Sub
     
#End Region
     
#Region "Progress Bar"
    Protected Sub HideProgressBar()
        Try
            Me.Invoke(New MethodInvoker(AddressOf InvokeHideProgressBar))
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub ShowProgressBar()
        Try
            ProgressPanel2.Visible = True
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub InvokeHideProgressBar()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf InvokeHideProgressBar))
            Else
                If ProgressPanel2.Visible Then
                    ProgressPanel2.Visible = False
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "BG Worker"

    Public Sub LoadDataSource()
        LoadDataSource(Nothing)
    End Sub

    Public Sub LoadDataSource(ByVal p_param As Object)
        If (Me.DesignMode = False) Then
            If (bgWorker Is Nothing) Then Exit Sub

            If (bgWorker.IsBusy) Then
                bgWorker.CancelAsync()
            End If

            While (bgWorker.IsBusy)
                System.Windows.Forms.Application.DoEvents()
            End While
            ShowProgressBar()
            bgWorker.RunWorkerAsync(p_param)
        End If
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            If (bgWorker IsNot Nothing AndAlso Not bgWorker.CancellationPending AndAlso Not e.Cancel) Then
                If (e.Argument IsNot Nothing) Then
                    e.Result = GetDataSourceFromDB(e.Argument)
                Else
                    e.Result = GetDataSourceFromDB()
                End If
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, "Load Data Source", 0)
            e.Result = Nothing
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If (e.Error Is Nothing And e.Cancelled = False And e.Result IsNot Nothing And bgWorker.WorkerSupportsCancellation = True) Then
            SetGridViewSource(e.Result)

        ElseIf (e.Error IsNot Nothing) Then
            MessageManager.ProcessError(sender, e.Error, False, String.Empty, "Load GridView", AppEnums.LogType.Access)
        End If

        HideProgressBar()
    End Sub

#End Region

#Region "Gridview Methods"
      
    Protected Overridable Function GetDataSourceFromDB() As Object
        Return Nothing
    End Function

    Protected Overridable Function GetDataSourceFromDB(ByVal p_param As Object) As Object
        Return Nothing
    End Function


    Public Overridable Sub RefreshGridViewSource()
        SetGridViewSource(_dataSource)
    End Sub

    Public Overridable Sub SetGridViewSource(ByVal p_ds As Object)
        If (p_ds Is Nothing) Then
            Return
        End If

        Dim dt As DataTable = Nothing

        If (TypeOf (p_ds) Is DataSet) Then
            _dataSet = TryCast(p_ds, DataSet)
            Dim ds = TryCast(p_ds, DataSet)
            dt = TryCast(ds.Tables(0), DataTable)
        Else
            dt = TryCast(p_ds, DataTable)
        End If

        If (dt IsNot Nothing) Then
            dt.DefaultView.RowFilter = RowFilter
            Dim count = dt.DefaultView.ToTable.Rows.Count
            RaiseEventLoadDataComplete(count)
        End If

        DataSource = dt

        If (CurrentGridView IsNot Nothing) Then
            CurrentGridView.ExpandAllGroups()
        End If
    End Sub

    Protected Sub RaiseEventLoadDataComplete(ByVal p_count As Integer)
        RaiseEvent LoadDataSourceCompleted(p_count)
    End Sub

    Public Sub ExportGridView()
        If (_gridControl Is Nothing And _gridview Is Nothing) Then
            Return
        End If

        Dim defaultView = _gridControl.DefaultView
        Dim manager As New GridViewManager
        manager.ExportFile(defaultView, defaultView.Name, ApplicationMeta.LoginUserName)
    End Sub

    Public Function GetSelectedKeys() As List(Of Integer)
        Return GetSelectedValues(KeyFieldName)
    End Function

    Public Function GetSelectedValues(ByVal p_fieldName As String) As List(Of Integer)
        Dim gridView = GetCurrentView()
        Dim Rows As New List(Of Integer)
        Dim selectedRowHandles As Int32() = gridView.GetSelectedRows()
        Dim index As Integer
        For index = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(index)
            If (selectedRowHandle >= 0 And Not gridView.IsGroupRow(selectedRowHandle)) Then
                Dim id As Integer = DataHelper.CVInt(gridView.GetRowCellValue(selectedRowHandle, p_fieldName))
                Rows.Add(id)
            End If
        Next
        Return Rows
    End Function


    Public Function GetSelectedBooleanValues(ByVal p_fieldName As String) As List(Of Boolean)
        Dim gridView = GetCurrentView()
        Dim Rows As New List(Of Boolean)
        Dim selectedRowHandles As Int32() = gridView.GetSelectedRows()
        Dim index As Integer
        For index = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(index)
            If (selectedRowHandle >= 0 And Not gridView.IsGroupRow(selectedRowHandle)) Then
                Dim id As Boolean = DataHelper.CVBool(gridView.GetRowCellValue(selectedRowHandle, p_fieldName))
                Rows.Add(id)
            End If
        Next
        Return Rows
    End Function

    Public Function GetSelectedStringValues(ByVal p_fieldName As String) As List(Of String)
        Dim gridView = GetCurrentView()
        Dim Rows As New List(Of String)
        Dim selectedRowHandles As Int32() = gridView.GetSelectedRows()
        Dim index As Integer
        For index = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(index)
            If (selectedRowHandle >= 0 And Not gridView.IsGroupRow(selectedRowHandle)) Then
                Dim id As String = DataHelper.CVText(gridView.GetRowCellValue(selectedRowHandle, p_fieldName))
                Rows.Add(id)
            End If
        Next
        Return Rows
    End Function

    Public Function GetSelectedList(ByVal p_fieldName As String) As ArrayList
        Dim gridView = GetCurrentView()
        Dim Rows As New ArrayList
        Dim selectedRowHandles As Int32() = gridView.GetSelectedRows()
        Dim index As Integer
        For index = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(index)
            If (selectedRowHandle >= 0 And Not gridView.IsGroupRow(selectedRowHandle)) Then
                Dim value = gridView.GetRowCellValue(selectedRowHandle, p_fieldName)
                Rows.Add(value)
            End If
        Next
        Return Rows
    End Function

    Public Function GetFocusRowID() As Integer
        If (String.IsNullOrEmpty(KeyFieldName)) Then
            Return 0
        End If
        Return GetFocusRowID(KeyFieldName)
    End Function

    Public Function GetFocusRowID(ByVal p_fieldName As String) As Integer
        If (_gridview.FocusedRowHandle < 0) Then
            Return 0
        End If

        If (_gridview.IsGroupRow(_gridview.FocusedRowHandle)) Then
            Return 0
        End If

        Dim id = CInt(_gridview.GetFocusedRowCellValue(p_fieldName))
        Return id
    End Function

    Public Function GetFocusRowCellValue(ByVal p_fieldName As String) As Object
        If (_gridview.FocusedRowHandle < 0) Then
            Return 0
        End If


        If (_gridview.IsGroupRow(_gridview.FocusedRowHandle)) Then
            Return 0
        End If

        Dim id = _gridview.GetFocusedRowCellValue(p_fieldName)
        Return id
    End Function


    Private Function GetCurrentView() As DevExpress.XtraGrid.Views.Grid.GridView
        If (_gridControl Is Nothing) Then
            Return Nothing
        End If

        Dim defaultView = _gridControl.DefaultView
        If (TypeOf (defaultView) Is DevExpress.XtraGrid.Views.Grid.GridView) Then
            Return TryCast(_gridControl.DefaultView, DevExpress.XtraGrid.Views.Grid.GridView)
        End If
        Return Nothing
    End Function

#End Region

#Region "Public Methods"

    Public Function CheckGridViewUnselect() As Boolean
        If (CurrentGridControl IsNot Nothing And CurrentGridView IsNot Nothing) Then
            If (CurrentGridControl.DataSource Is Nothing OrElse CurrentGridView.RowCount <= 0) Then
                MessageBox.Show("No data to process.", "Select Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If


        If (CurrentGridView.OptionsSelection.MultiSelect) Then
            If (CurrentGridView.SelectedRowsCount <= 0) Then
                MessageBox.Show("Please select row to process.", "Select Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        Else
            If (CurrentGridView.FocusedRowHandle < 0) Then
                MessageBox.Show("Please select row to process.", "Select Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If
        Return False
    End Function
#End Region

#Region "Load GridView Lookup Control"

    Private Sub DoWorkLoadGridLookup()
        If (Me.DesignMode = False) Then
            If (bgwLoadGridLookup Is Nothing) Then Exit Sub

            If (bgwLoadGridLookup.IsBusy) Then
                bgwLoadGridLookup.CancelAsync()
            End If

            While (bgwLoadGridLookup.IsBusy)
                System.Windows.Forms.Application.DoEvents()
            End While
            bgwLoadGridLookup.RunWorkerAsync()

        End If
    End Sub

    Private Sub bgwLoadGridLookup_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadGridLookup.DoWork
        Try
            If (bgWorker IsNot Nothing AndAlso Not bgWorker.CancellationPending AndAlso Not e.Cancel) Then
                If (e.Argument IsNot Nothing) Then
                    e.Result = LoadGridLookupControlWorking(e.Argument)
                Else
                    e.Result = LoadGridLookupControlWorking(Nothing)
                End If
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, "Load Controls", "Load Control", 0)
            e.Result = Nothing
        End Try
    End Sub

    Private Sub bgwLoadGridLookup_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadGridLookup.RunWorkerCompleted
        If (e.Error Is Nothing And e.Cancelled = False And e.Result IsNot Nothing And bgWorker.WorkerSupportsCancellation = True) Then

            LoadGridLookupControlComplete(e.Result)

            InitializeDXMenuItems()

        ElseIf (e.Error IsNot Nothing) Then
            MessageManager.ProcessError(sender, e.Error, False, String.Empty, "Load GridView", AppEnums.LogType.Access)
        End If
    End Sub

    Protected Overridable Function LoadGridLookupControlWorking(ByVal p_value As Object) As Object
        Return Nothing
    End Function

    Protected Overridable Sub LoadGridLookupControlComplete(ByVal p_value As Object)

    End Sub
#End Region

#Region "Gridview DXMenu"
    Protected Overridable Sub MainGridView_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs)
        If (_menuItems Is Nothing) Then
            Return
        End If

        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle

            For Each item As DXMenuItem In _menuItems
                e.Menu.Items.Add(item)
            Next item
        End If
    End Sub

    Protected Sub ItemDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles MenuItem2.Click
        If (GridViewMasterName <> CurrentGridControl.FocusedView.Name) Then
            Return
        End If

        DeleteButtonClick()
    End Sub

    Protected Overridable Sub ItemEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles MenuItem2.Click
        Try
            If (CurrentGridView Is Nothing) Then
                Return
            End If

            If (GridViewMasterName = CurrentGridControl.FocusedView.Name) Then
                Dim selectID = GetFocusRowID()
                If (selectID < 0) Then
                    Return
                End If
                ShowForm(AppEnums.EditMode.Edit, selectID)
            Else
                Dim gv = TryCast(CurrentGridControl.FocusedView, GridView)
                If (gv.FocusedRowHandle < 0 Or gv.IsGroupRow(gv.FocusedRowHandle)) Then
                    Return
                End If
                ShowFormDetail(gv, AppEnums.EditMode.Edit)
            End If
            
        Catch ex As Exception

        End Try
    End Sub

    Protected Overridable Sub DeleteSelectedRow(ByVal p_id As Integer)
        CurrentGridView.DeleteRow(CurrentGridView.FocusedRowHandle) 
        CurrentGridView.RefreshData()
        RaiseEvent DeleteCompleted(p_id)
    End Sub

    Protected Sub ItemExportGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ExportGridView()
    End Sub

#End Region

#Region "Gridview Events"
    Private Sub gv_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim id = GetFocusRowID()
        RaiseEvent GridViewFocusedRowChanged(id)
    End Sub

    Protected Overridable Sub gv_DoubleClick(sender As Object, e As EventArgs)
        GridDoubleClick()
    End Sub

    Protected Overridable Sub gv_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        Dim grid = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If (e.RowHandle < 0 Or grid.IsGroupRow(e.RowHandle) OrElse e.CellValue Is DBNull.Value OrElse e.CellValue Is Nothing) Then
            Return
        End If

        If (e.Column.FieldName = AppConst.c_CreatedDate OrElse e.Column.FieldName = AppConst.c_LastUpdated) Then
            If (e.CellValue Is Nothing OrElse e.Column Is DBNull.Value) Then
                e.DisplayText = String.Empty
            End If
        End If

        If (e.Column.FieldName = "RowNo") Then
            e.DisplayText = String.Format("{0:n0}", e.RowHandle + 1)
        End If

    End Sub

#End Region

#Region "Button Click"
    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        LoadDataSource()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles bbiNew.ItemClick
        Try
            AddButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiNew.Caption, 0)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles bbiDelete.ItemClick
        Try
            DeleteButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub

    Private Sub bbiCopyNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCopyNew.ItemClick
        Try
            CopyButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub

    Private Sub bbiCustomButton_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            CustomButtonClick(IIf(e.Item.Name = "bbiCustom1", 1, 2))
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub

    Private Sub bbiExportGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportGrid.ItemClick
        Try
            If (_gridControl Is Nothing And _gridview Is Nothing) Then
                Return
            End If

            Dim defaultView = _gridControl.DefaultView
            Dim manager As New GridViewManager
            manager.ExportFile(defaultView, defaultView.Name, ApplicationMeta.LoginUserName)
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub
#End Region

#Region " Protected Overridable"

    Protected Sub RaiseEventUpdateCompleted(ByVal p_txID As Integer)
        RaiseEvent UpdateCompleted(p_txID)
    End Sub

    Protected Overridable Sub GridDoubleClick()
        If (GridViewMasterName = CurrentGridControl.FocusedView.Name) Then
            Dim id = GetFocusRowID()
            If (id = 0) Then
                Return
            End If

            If (PermissionType = AppEnums.UiPermissionTypes.View) Then
                ShowForm(AppEnums.EditMode.View, id)
            Else
                ShowForm(AppEnums.EditMode.Edit, id)
            End If
        Else
            ShowFormDetail(TryCast(CurrentGridControl.FocusedView, GridView), AppEnums.EditMode.View)
        End If
         
    End Sub

    Protected Overridable Sub AddButtonClick()
        ShowForm(AppEnums.EditMode.Add, 0)
    End Sub

    Protected Overridable Sub CopyButtonClick()
        Dim id = GetFocusRowID()
        If (id <= 0) Then
            MessageManager.Warning(AppEnums.MessageCode.M009)
            Return
        End If
        ShowForm(AppEnums.EditMode.Clone, id)
    End Sub

    Protected Overridable Sub DeleteButtonClick()
        If (GridViewMasterName <> CurrentGridControl.FocusedView.Name) Then
            Return
        End If

        If (IsMutiSelect) Then
            If (CurrentGridView.GetSelectedRows.Count = 0) Then
                MessageManager.ShowError("Please select row to delete.", bbiDelete.Caption)
                Return
            End If

            If (MessageManager.Comfirmation(AppEnums.MessageCode.M003)) Then
                If (DeleteMultiRows()) Then
                    MessageManager.Complete("Delete successfully.", "Delete")
                End If
            End If

        Else
            Dim id = GetFocusRowID()
            If (id = 0) Then
                MessageManager.ShowError("Please select row to delete.", bbiDelete.Caption)
                Return
            End If

            If (MessageManager.Comfirmation(AppEnums.MessageCode.M003)) Then
                If (DeleteOneRow(id)) Then
                    If (id > 0) Then
                        MessageManager.Complete("Delete successfully.", "Delete")
                    End If
                End If
            End If

        End If

    End Sub

    Private Function DeleteOneRow(ByVal p_id As Integer) As Boolean
        If (p_id <> 0) Then
            If (Not DoValidateDelete(p_id)) Then
                Return False
            End If
            If (Not DeleteRow(p_id)) Then
                Return False
            End If
        End If

        DeleteSelectedRow(p_id)
        Return True
    End Function

    Private Function DeleteMultiRows() As Boolean
        Dim ids = GetSelectedKeys()
        For Each keyID In ids
            If (Not DeleteOneRow(keyID)) Then
                Return False
            End If
        Next

        Return True
    End Function

    Protected Overridable Sub CustomButtonClick(ByVal p_No As Integer)

    End Sub

    Public Overridable Sub ShowForm(ByVal p_EditMode As AppEnums.EditMode, ByVal p_id As Integer)

    End Sub

    Public Overridable Sub ShowFormDetail(ByVal p_gv As GridView, ByVal p_EditMode As AppEnums.EditMode)

    End Sub

    Protected Overridable Function DoValidateDelete(ByVal p_id As Integer) As Boolean
        Dim result = ValidateDelete(p_id)
        If (result > 0) Then
            MessageManager.ShowError(result, "Delete")
        End If
        Return result = 0
    End Function

    Protected Overridable Function ValidateDelete(ByVal p_id As Integer) As Integer
        Return 0
    End Function

    Protected Overridable Function DeleteRow(ByVal p_id As Integer) As Boolean
        Return False
    End Function

    Protected Overridable Sub ExportButtonClick()
        If (Me.CurrentGridView IsNot Nothing) Then
            Me.ExportGridView()
        End If
    End Sub

    Protected _isRegisteredGrid As Boolean
    Protected Overridable Function CheckUnRegisteredGrid() As Boolean
        If (_isRegisteredGrid) Then
            Return False
        End If

        _isRegisteredGrid = True
        Return True
    End Function

    Protected Overridable Function GetDataSourceRowFilter(ByVal p_ds As Object) As Object
        Dim dt = TryCast(p_ds, DataTable)
        If (dt Is Nothing) Then
            Return p_ds
        End If

        dt.DefaultView.RowFilter = RowFilter
        Return dt.DefaultView.ToTable
    End Function

    Protected Overridable Sub SetGridViewTotalSummary(ByRef p_gridView As GridView)
        If (p_gridView.Columns(KeyFieldName) IsNot Nothing) Then
            If (p_gridView.Columns(KeyFieldName).Visible) Then
                p_gridView.OptionsView.ShowFooter = True
                p_gridView.Columns(KeyFieldName).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                p_gridView.Columns(KeyFieldName).SummaryItem.DisplayFormat = "Total : {0:n0}"
                Return
            End If
        End If
    End Sub

#End Region

#Region "Load GridView Lookup Control"

    Private Sub DoWorkLoadGridLookupUpdatingColumns()
        If (Me.DesignMode = False) Then
            If (bgworkerUpdatingColumnLookup Is Nothing) Then Exit Sub

            If (bgworkerUpdatingColumnLookup.IsBusy) Then
                bgworkerUpdatingColumnLookup.CancelAsync()
            End If

            While (bgworkerUpdatingColumnLookup.IsBusy)
                System.Windows.Forms.Application.DoEvents()
            End While
            bgworkerUpdatingColumnLookup.RunWorkerAsync()
        End If
    End Sub


    Private Sub bgworkerUpdatingColumnLookup_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworkerUpdatingColumnLookup.DoWork
        Try
            If (bgWorker IsNot Nothing AndAlso Not bgWorker.CancellationPending AndAlso Not e.Cancel) Then
                Dim user As New Data.User
                user.LoadDataSource()
                e.Result = user.DataSource
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, "Load Controls", "Load Control", 0)
            e.Result = Nothing
        End Try
    End Sub

    Private Sub bgworkerUpdatingColumnLookup_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerUpdatingColumnLookup.RunWorkerCompleted
        If (e.Error Is Nothing And e.Cancelled = False And e.Result IsNot Nothing And bgWorker.WorkerSupportsCancellation = True) Then
            SetGridViewUpdatingColumn(e.Result)
        ElseIf (e.Error IsNot Nothing) Then
            MessageManager.ProcessError(sender, e.Error, False, String.Empty, "Load GridView", AppEnums.LogType.Access)
        End If
    End Sub

    Private Sub SetGridViewUpdatingColumn(ByVal p_user As Object)
        If (p_user Is Nothing) Then
            Return
        End If

        If (CurrentGridView Is Nothing) Then
            Return
        End If

        Dim service As New Data.User
        service.LoadDataSource()
        Dim dt = service.DataSource

        If (CurrentGridView.Columns(Common.AppConst.c_LastUpdatedBy) IsNot Nothing) Then
            CurrentGridView.Columns(Common.AppConst.c_LastUpdatedBy).ColumnEdit = New CustomRepositoryLookupUser(dt)
        End If

        If (CurrentGridView.Columns(Common.AppConst.c_CreatedBy) IsNot Nothing) Then
            CurrentGridView.Columns(Common.AppConst.c_CreatedBy).ColumnEdit = New CustomRepositoryLookupUser(dt)
        End If

    End Sub
#End Region


#Region "Layout"
    Public Overridable Sub SaveGridLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub

    Public Overridable Sub RestoreLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.RestoreLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub
#End Region

    Private Sub FormViewMaster_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
         
        If Not DesignMode Then
            SaveGridLayout()
            e.Cancel = False
            Me.Dispose()
            Return
        End If



        'can do this to allow form to close without validating
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.CausesValidation = False
        'or this
        e.Cancel = False
        Me.Dispose()
    End Sub
End Class