Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports DevExpress.Utils.Menu
Imports Finsoft.PM.Common
Imports System.Collections
Imports Finsoft.PM.Data

Public Class GridviewBase

    Public Property AutoLoad As Boolean = False
    Public Property ByPassRowFilter As Boolean
    Public Property HasUpdatingColumn As Boolean = True
    Public Property IsView As Boolean
    Public Property IsModify As Boolean
    Public Property IsApprove As Boolean
    Public Property IsProcess As Boolean
    Public Property IsAllowDelete As Boolean

    Protected _validateErrorText As String
    Protected _isLoad As Boolean
    Protected _controlsAreValid As Boolean = True
    Protected _isRegisteredGrid As Boolean

#Region "Events"
    Protected Friend Event DeleteCompleted(ByVal p_ID As Integer)
    Protected Friend Event UpdateCompleted(ByVal p_ID As Integer)
    Protected Friend Event GridViewFocusedRowChanged(ByVal p_ID As Integer)
    Protected Friend Event LoadDataSourceCompleted(ByVal p_count As Integer)
#End Region

#Region "Properties"
    Private _masterFile As MasterFile
    Public Property CurrentMasterFile As MasterFile
        Get
            Return _masterFile
        End Get
        Set(value As MasterFile)
            _masterFile = value
        End Set
    End Property

    Public Property ShowAddPanel As Boolean
        Get 
            Return MainToolBar.Visible
        End Get
        Set(value As Boolean) 
            MainToolBar.Visible = value
        End Set
    End Property

    Private _Config As Finsoft.PM.Common.ConfigHasTableService
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property Config As Finsoft.PM.Common.ConfigHasTableService
        Get
            If (_Config Is Nothing) Then
                _Config = New Finsoft.PM.Common.ConfigHasTableService
            End If
            Return _Config
        End Get
        Set(value As Finsoft.PM.Common.ConfigHasTableService)
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
                SetGridProperties(_gridview) 
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

    Private _editType As AppEnums.GridviewType = AppEnums.GridviewType.EditForm
    Public Property GridviewType As AppEnums.GridviewType
        Get
            Return _editType
        End Get
        Set(value As AppEnums.GridviewType)
            If (_editType = value) Then
                Return
            End If

            _editType = value
        End Set
    End Property


    Private _editMove As AppEnums.EditMode = AppEnums.EditMode.View
    Public Property EditMode As AppEnums.EditMode
        Get
            Return _editMove
        End Get
        Set(value As AppEnums.EditMode)
            If (_editMove <> value) Then
                _editMove = value
                SetToolBarPermission() 
            End If
        End Set
    End Property


    Public Property ShowCaption As Boolean
        Get
            If (CurrentGridView IsNot Nothing) Then
                Return CurrentGridView.OptionsView.ShowViewCaption
            End If
            Return False
        End Get
        Set(value As Boolean)
            If (CurrentGridView IsNot Nothing) Then
                CurrentGridView.OptionsView.ShowViewCaption = value
            End If
        End Set
    End Property

    Public WriteOnly Property SetGridViewCaption As String
        Set(value As String)
            If (CurrentGridView IsNot Nothing) Then
                CurrentGridView.ViewCaption = value
            End If
        End Set
    End Property
#End Region

#Region "Load"
    Private Sub GridViewBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.DesignMode) Then
            Return
        End If

        If (Not _isRegisteredGrid) Then
            RegisterGridControl()
            _isRegisteredGrid = True
        End If

        If (HasUpdatingColumn) Then
            DoWorkLoadGridLookupUpdatingColumns()
        End If

        DoWorkLoadGridLookup()

        RestoreLayout()

        SetToolBarPermission()
    End Sub

    Protected Overridable Sub InitializeDXMenuItems()
        If (_isLoadMenu) Then
            Return
        End If
        _menuItems = New List(Of DXMenuItem)
        Dim itemExport As New DXMenuItem("Export", AddressOf ItemExportGridView_Click)
        _menuItems.Add(itemExport)
        If (IsModify) Then
            Dim itemEdit As New DXMenuItem("Edit", AddressOf ItemEdit_Click)
            _menuItems.Add(itemEdit)
        End If

        If (IsAllowDelete) Then
            Dim itemDelete As New DXMenuItem("Delete", AddressOf ItemDelete_Click)
            _menuItems.Add(itemDelete)
        End If

        _isLoadMenu = True

    End Sub

    Public Overridable Sub RegisterGridControl()

    End Sub

    Protected Sub SetGridProperties(ByRef p_gridView As GridView)
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
    Protected Overridable Sub SetGridViewPropertiesByMenuCode()

    End Sub

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
            _dataSet = p_ds
            Dim ds = TryCast(p_ds, DataSet)
            dt = TryCast(ds.Tables(0), DataTable)
        ElseIf (TypeOf (p_ds) Is DataTable) Then
            dt = TryCast(p_ds, DataTable)
        End If

        If (dt IsNot Nothing) Then
            dt.DefaultView.RowFilter = RowFilter
            Dim count = dt.DefaultView.ToTable.Rows.Count
            RaiseEventLoadDataComplete(count)

            DataSource = dt
        Else
            DataSource = p_ds
            RaiseEventLoadDataComplete(CurrentGridView.RowCount)
        End If
         
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
                Dim id As Integer = DataHelper.CVBool(gridView.GetRowCellValue(selectedRowHandle, p_fieldName))
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

    'Public Sub SetControlProperty(p_isEditable As Boolean)
    '    MainToolBar.Visible = p_isEditable

    '    SetToolBarPermission()
    'End Sub

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
     
#Region "Load GridView Lookup Control - Update Columns"

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
        DeleteButtonClick()
    End Sub

    Protected Overridable Sub ItemEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles MenuItem2.Click
        Try
            If (CurrentGridView Is Nothing) Then
                Return
            End If

            Dim selectID = GetFocusRowID()
            If (selectID < 0) Then
                Return
            End If

            ShowForm(AppEnums.EditMode.Edit, selectID)
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

#Region "Raise Event"
    Protected Sub RaiseEventUpdateCompleted(ByVal p_txID As Integer)
        RaiseEvent UpdateCompleted(p_txID)
    End Sub

#End Region

#Region "Gridview Events"

    Private Sub gv_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim id = GetFocusRowID()
        RaiseEvent GridViewFocusedRowChanged(id)
    End Sub

    Private Sub gv_DoubleClick(sender As Object, e As EventArgs)
        GridDoubleClick()
    End Sub

    Private Sub gv_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        Dim grid = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If (e.RowHandle < 0 Or grid.IsGroupRow(e.RowHandle) OrElse e.CellValue Is DBNull.Value OrElse e.CellValue Is Nothing) Then
            Return
        End If

        If (e.Column.FieldName = "RowNo") Then
            e.DisplayText = String.Format("0:n0", e.RowHandle + 1)
        ElseIf (e.Column.FieldName = "CreatedDate" Or e.Column.FieldName = "LastUpdated") Then
            If (e.CellValue Is Nothing Or e.CellValue Is DBNull.Value) Then
                e.DisplayText = String.Empty
            Else
                Dim value As DateTime = CDate(e.CellValue)
                If (value <= DateTime.MinValue) Then
                    e.DisplayText = String.Empty
                End If
            End If
        End If

    End Sub

#End Region

#Region "Button click Events"
    Private Sub btnAdd_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
        Try
            AddButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiAdd.Caption, 0)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
        Try
            DeleteButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub
     
    Private Sub bbiCopy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCopyNew.ItemClick
        Try
            DeleteButtonClick()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, bbiDelete.Caption, 0)
        End Try
    End Sub
 
#End Region

#Region "Protected methods"

    Protected Overridable Sub GridDoubleClick()
        Dim id = GetFocusRowID()
        If (id = 0) Then
            Return
        End If

        If (EditMode = AppEnums.EditMode.View) Then
            ShowForm(AppEnums.EditMode.View, id)
        Else
            ShowForm(AppEnums.EditMode.Edit, id)
        End If

    End Sub

    Protected Overridable Sub AddButtonClick()
   
        If GridviewType = AppEnums.GridviewType.GridEdit Then
            SetGridEditable(True)
            SetCancelButtonEditable(True)
            Me.CurrentGridView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True
            Me.CurrentGridView.AddNewRow()
            Me.CurrentGridView.ShowPopupEditForm()
            EditMode = AppEnums.EditMode.Add
        Else
            ShowForm(AppEnums.EditMode.Add, 0)
        End If
    End Sub

    Protected Overridable Sub DeleteButtonClick()
        Dim id = GetFocusRowID()
        If (id <> 0) Then
            If (Not MessageManager.Comfirmation(AppEnums.MessageCode.M003)) Then
                Return
            End If

            If (CurrentGridView.OptionsSelection.MultiSelect) Then
                DeleteMultiRow()
            Else
                DeleteOneRow(id, True)
            End If

        Else
            MessageManager.ShowError(AppEnums.MessageCode.M009, "Delete")
        End If
    End Sub


    Private Sub DeleteOneRow(ByVal id As Integer, ByVal showMessage As Boolean)
        If (id <> 0) Then
            If (Not DoValidateDelete(id)) Then
                Return
            End If

            If (id > 0) Then
                If (Not DeleteRow(id)) Then
                    Return
                End If
            End If

        End If

        DeleteSelectedRow(id)

        If (id > 0 And showMessage) Then
            MessageManager.Complete("Delete successfully.", "Delete")
        End If
    End Sub

    Private Sub DeleteMultiRow()
        If (CheckGridViewUnselect()) Then
            Return
        End If

        Dim keys = GetSelectedKeys()
        For Each key In keys
            DeleteOneRow(key, False)
        Next

    End Sub

    Protected Overridable Sub Copy()
        If GridviewType = AppEnums.GridviewType.GridEdit Then
            SetGridEditable(True)
            SetCancelButtonEditable(True)
            Me.CurrentGridView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True
            Me.CurrentGridView.AddNewRow()
            Me.CurrentGridView.ShowPopupEditForm()
            EditMode = AppEnums.EditMode.Clone
        Else
            ShowForm(AppEnums.EditMode.Clone, 0)
        End If
    End Sub
     
    Public Overridable Sub ShowForm(ByVal p_EditMode As AppEnums.EditMode, ByVal p_id As Integer)

    End Sub

    Protected Overridable Sub ExportButtonClick()
        If (Me.CurrentGridView IsNot Nothing) Then
            Me.ExportGridView()
        End If
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

    Protected Overridable Function GetDataSourceRowFilter(ByVal p_ds As Object) As Object
        Dim dt = TryCast(p_ds, DataTable)
        If (dt Is Nothing) Then
            Return p_ds
        End If

        dt.DefaultView.RowFilter = RowFilter
        Return dt.DefaultView.ToTable
    End Function

#End Region

#Region "Layout"
    Public Overridable Sub SaveGrid()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub

    Public Overridable Sub RestoreLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.RestoreLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub
#End Region

#Region "GridviewType"
    Protected Overridable Sub SetToolBarPermission()

        'If (GridviewType = AppEnums.GridviewType.EditForm) Then
        '    bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    bbiCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'End If

        'If (GridviewType = AppEnums.GridviewType.GridEdit) Then
        '    bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '    bbiCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If
        'If (EditMode = AppEnums.EditMode.Add) Then
        '    biRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'Else
        '    biRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If

        MainToolBar.Visible = EditMode <> AppEnums.EditMode.View

        If (EditMode <> AppEnums.EditMode.View) Then
            Select Case GridviewType
                Case AppEnums.GridviewType.EditForm
                    'bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    'bbiCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    bbiCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case AppEnums.GridviewType.GridEdit
                    bbiCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End Select
        End If

        If GridviewType = AppEnums.GridviewType.GridEdit And EditMode <> AppEnums.EditMode.View Then
            SetGridEditable(True)
        Else
            SetGridEditable(False)
        End If

        bbiCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Protected Sub SetGridEditable(ByVal p_isEdit As Boolean)
        If CurrentGridView Is Nothing Then
            Return
        End If


        CurrentGridView.OptionsBehavior.Editable = p_isEdit
        SetCancelButtonEditable(p_isEdit)
    End Sub

    Protected Sub SetCancelButtonEditable(ByVal p_isShow As Boolean)
        'bbiCancel.Enabled = p_isShow
        'bbiSave.Enabled = p_isShow
    End Sub
#End Region
 
#Region "Grid Edit"
    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If Me.DesignMode Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Save()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, "Save", 0)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Protected Overridable Sub Save()
        
        Dim dt As DataTable = TryCast(DataSource, DataTable)
        If dt Is Nothing Or CurrentMasterFile Is Nothing Then
            Return
        End If

        If CurrentGridView.ValidateEditor Then
            CurrentGridView.UpdateCurrentRow()
        End If

        If CurrentMasterFile.IsDataTableChanged Then
            If MessageManager.Comfirmation("Confirm to save changed") Then
                CurrentMasterFile.LastUpdatedBy = ApplicationMeta.LoginUserID
                CurrentMasterFile.DBUpdateDataTable()
                CurrentGridView.OptionsBehavior.Editable = False
            End If
        End If
    End Sub

    Protected Overridable Sub Cancel()
        Dim dt As DataTable = TryCast(DataSource, DataTable)
        If dt Is Nothing Then
            Return
        End If

        dt.RejectChanges()
        CurrentGridView.RefreshData()
        SetGridEditable(False)

    End Sub
#End Region
    
End Class
