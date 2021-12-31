Imports Finsoft.PM.Common

Public Class FormBase

#Region "Events"
    Protected Friend Event DeleteCompleted(ByVal p_ID As Integer)
    Protected Friend Event UpdateCompleted(ByVal p_ID As Integer)
#End Region

#Region "Protected Member"
    Public Property HasParentForm As Boolean = True

    Protected _validateErrorText As String = String.Empty
    'MINTRA,2014-04-07
    Protected _isBindingControl As Boolean
    Protected _isLoad As Boolean
    Protected _controlsAreValid As Boolean = True
    Protected _isChanged As Boolean
    Protected _isEditable As Boolean
    Protected _masterFile As Data.MasterFile
    Protected _logtype As AppEnums.LogType
    Public Property LogType As AppEnums.LogType
        Get
            Return _logtype
        End Get
        Set(value As AppEnums.LogType)
            _logtype = value
        End Set
    End Property

    Private _keyID As Integer
    Public Property KeyID As Integer
        Get
            Return _keyID
        End Get
        Set(value As Integer)
            _keyID = value
        End Set
    End Property

    Protected _editmode As AppEnums.EditMode = AppEnums.EditMode.View
    Public Property EditMode As AppEnums.EditMode
        Get
            Return _editmode
        End Get
        Set(value As AppEnums.EditMode)
            _editmode = value
        End Set
    End Property

    Public Property ShowButtonsPanel As Boolean
        Get
            Return PanelButtons.Visible
        End Get
        Set(value As Boolean)
            PanelButtons.Visible = value
        End Set
    End Property

#End Region

#Region "Form Events"

    Private Sub FormEditBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.StartPosition = FormStartPosition.CenterParent
            _isEditable = EditMode <> AppEnums.EditMode.View

            StartWaiting()
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")
            System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("en-GB", False)

            'Dim m As UserLayoutManager = New UserLayoutManager
            'm.RestoreLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
            LoadGridLayout()

            FormLoad()

            AdditionalIntialize()

            SetControlValidation()

            LoadControls()

        Catch ex As Exception
            'StopWaiting()
            MessageManager.ProcessError(Me, ex, False, String.Empty, Me.Text, AppEnums.LogType.Access)
        End Try
    End Sub

    Private Sub FormEditBase_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If (DesignMode) Then
            Return
        End If
        Try
            'LoadGridLayout()

            SetControlVisible()

            If (_isLoad) Then
                BindingControls()
                _isBindingControl = True
            End If

            btnSave.Visible = EditMode <> AppEnums.EditMode.View
            SetControlEditable()

        Catch ex As Exception
            StopWaiting()
            MessageManager.ProcessError(Me, ex, False, String.Empty, Me.Text, AppEnums.LogType.Access)
        Finally
            StopWaiting()
        End Try
    End Sub

    Protected Overridable Sub LoadGridLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.RestoreLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub

    Private Sub FormEditBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Not DesignMode Then
            Me.CausesValidation = False
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


    Protected Overridable Sub SaveGridLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
    End Sub

#End Region

#Region "Button Click Events"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If (Not ValidateControl()) Then
                Return
            End If

            SaveClick()
        Catch ex As Exception
            StopWaiting()
            MessageManager.ProcessError(sender, ex, False, String.Empty, Me.Text, LogType)
        Finally
            StopWaiting()
        End Try
    End Sub

    Protected Overridable Sub SaveClick()
        StartWaiting()
        If (ProcessSave()) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Try
            If (ProcessCancel()) Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, String.Empty, Me.Text, LogType)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub

    Protected Sub SetCustomBotton(ByVal p_text As String)
        btnCustom.Visible = True
        btnCustom.Text = p_text
    End Sub

    Protected Sub SetCustomBotton2(ByVal p_text As String)
        btnCustom2.Visible = True
        btnCustom2.Text = p_text
    End Sub


#End Region

#Region "Custom Button "
    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        CustomButtonClick()
    End Sub


    Private Sub btnCustom2_Click(sender As Object, e As EventArgs) Handles btnCustom2.Click
        CustomButton2Click()
    End Sub

    Protected Overridable Sub CustomButtonClick()

    End Sub

    Protected Overridable Sub CustomButton2Click()

    End Sub
#End Region

#Region "Protected Overridable Methods"

    'Init value such as Menu Code
    Protected Overridable Sub FormLoad()

    End Sub

    Protected Overridable Sub AdditionalIntialize()

    End Sub

    Protected Overridable Sub SetControlVisible()
        'Select Case _formMode
        '    Case 
        'End Select
    End Sub

    ''' <summary>
    ''' Bind Form Controls to Datasource or class
    ''' </summary>
    Protected Overridable Sub BindingControls()
        ' Bind "SelectedValue" for ComboBox binded to dataset
        ' Bind "Text" for ComboBox binded to Array or Constants (Enum)
        ' Bind "EditValue" for DevXpress TextEdit Control
        ' May have to bind OnPropertyChange not OnValidating for some controls
    End Sub

    Protected Overridable Sub SetControlValidation()
        ' additional load or initialize here
        Dim validator As New ControlValidator
        validator.SetControlProperty(Me, Nothing)
    End Sub

    Protected Overridable Function ProcessSave() As Boolean
         
        Dim logType As AppEnums.LogType = AppEnums.LogType.Edit
        Dim logID As Integer = 0
        If (EditMode = AppEnums.EditMode.Add) Then
            logType = AppEnums.LogType.Add
            '_masterFile.CreatedLogID = LogManager.InsertLog(logType)
            _masterFile.CreatedBy = ApplicationMeta.LoginUserID
        Else
            '_masterFile.LastUpdatedLogID = LogManager.InsertLog(logType)
            _masterFile.LastUpdatedBy = ApplicationMeta.LoginUserID
        End If
 
        _masterFile.DBInsertUpdate()
            MessageManager.Complete(logType, btnSave.Text)

            Return True
    End Function

    Protected Overridable Function CustomValidateData() As Boolean
        Return True
    End Function

    Protected Overridable Function ProcessComplete() As Boolean
        Return True
    End Function

    Protected Overridable Function ProcessCancel() As Boolean
        Return True
    End Function

    Protected Overridable Sub SetControlEditable()
        Dim validator As New ControlValidator
        validator.SetControlProperty(Me, EditMode <> AppEnums.EditMode.View)
    End Sub

#End Region

#Region "BG Worker : Load Control"

    Protected Overridable Sub LoadControls()
        If (Me.DesignMode = False) Then
            If (bgWorker Is Nothing) Then Exit Sub

            If (bgWorker.IsBusy) Then
                bgWorker.CancelAsync()
            End If

            While (bgWorker.IsBusy)
                System.Windows.Forms.Application.DoEvents()
            End While
            bgWorker.RunWorkerAsync()
        End If
    End Sub

    Protected Overridable Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            If (bgWorker IsNot Nothing AndAlso Not bgWorker.CancellationPending AndAlso Not e.Cancel) Then
                e.Result = LoadControlDowork(e.Argument)
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, String.Empty, Me.Text, 0)
            e.Result = Nothing
        End Try
    End Sub

    Protected Overridable Sub bgWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        LoadControlCompleted(e.Result)
        _isLoad = True

        If (Not _isBindingControl) Then
            BindingControls()
            _isBindingControl = True
        End If
    End Sub

    Protected Overridable Function LoadControlDowork(ByVal p_arg As Object) As Object
        Return Nothing
    End Function

    Protected Overridable Sub LoadControlCompleted(ByVal p_Result As Object)

    End Sub

#End Region

#Region "Controls Validation"

    Protected Sub ClearValidateRequiredField(sender As DevExpress.XtraEditors.BaseEdit)
        RemoveHandler sender.Validated, AddressOf ValidatingRequiredFieldHandler
    End Sub
    Protected Sub SetValidateRequiredField(sender As DevExpress.XtraEditors.BaseEdit)
        AddHandler sender.Validated, AddressOf ValidatingRequiredFieldHandler
    End Sub

    Protected Sub SetValidateDateWithCurrentDate(sender As DevExpress.XtraEditors.BaseEdit)
        AddHandler sender.Validated, AddressOf ValidatingDateWithCurrentDate
    End Sub

    Protected Sub SetValidateWithCurrentDate_RequiredField(sender As DevExpress.XtraEditors.BaseEdit)
        AddHandler sender.Validated, AddressOf ValidatingDateWithCurrentDateRequired
    End Sub

    Protected Sub ValidatingRequiredFieldHandler(sender As System.Object, e As System.EventArgs)
        ValidatingRequiredField(sender, "Required field.")
    End Sub


    Protected Sub ValidatingRequiredFieldHandler(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        Me.ValidatingRequiredField(sender, "Required field.")
    End Sub

    Protected Sub ValidatingDateWithCurrentDate(sender As System.Object, e As System.EventArgs)
        ValidatingDate(sender, False)
    End Sub

    Protected Sub ValidatingDateWithCurrentDateRequired(sender As System.Object, e As System.EventArgs)
        ValidatingDate(sender, True)
    End Sub

    Protected Sub ValidatingDate(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        Me.ValidatingRequiredField(sender, "Required field.")
    End Sub


    Protected Function ValidatingRequiredField(ByRef p_baseEdit As DevExpress.XtraEditors.BaseEdit, ByVal p_fieldName As String) As Boolean
        'MINTRA,2014-04-07
        If (Not _isLoad) Then
            Return True
        End If
        If (Not p_baseEdit.Enabled OrElse Not p_baseEdit.Visible OrElse p_baseEdit.Properties.ReadOnly) Then
            ClearErrProviderError(p_baseEdit)
            Return True
        End If

        If IsDBNull(p_baseEdit.EditValue) OrElse p_baseEdit.EditValue Is Nothing OrElse _
           (TypeOf (p_baseEdit.EditValue) Is String AndAlso p_baseEdit.EditValue Is String.Empty) OrElse _
           ((TypeOf (p_baseEdit.EditValue) Is Integer) Or (TypeOf (p_baseEdit.EditValue) Is Decimal)) AndAlso p_baseEdit.EditValue = 0 Then
            SetErrProviderError(p_baseEdit, "Please input " & p_fieldName)
            Return False
        Else
            ClearErrProviderError(p_baseEdit)
            Return True
        End If
    End Function

    Protected Function ValidatingDate(ByRef p_baseEdit As DevExpress.XtraEditors.BaseEdit, ByVal p_isRequired As Boolean) As Boolean
        'MINTRA,2014-04-07
        If (Not _isLoad) Then
            Return True
        End If
        If (Not p_baseEdit.Enabled OrElse Not p_baseEdit.Visible OrElse p_baseEdit.Properties.ReadOnly) Then
            ClearErrProviderError(p_baseEdit)
            Return True
        End If

        Dim fieldName As String = p_baseEdit.Tag
        If IsDBNull(p_baseEdit.EditValue) OrElse p_baseEdit.EditValue Is Nothing OrElse _
           (TypeOf (p_baseEdit.EditValue) Is String AndAlso p_baseEdit.EditValue Is String.Empty) OrElse _
           ((TypeOf (p_baseEdit.EditValue) Is Integer) Or (TypeOf (p_baseEdit.EditValue) Is Decimal)) AndAlso p_baseEdit.EditValue = 0 Then
            If (p_isRequired) Then
                SetErrProviderError(p_baseEdit, "Please input required")
                Return False
            Else
                Return True
            End If
        Else
            Dim currentDate = ApplicationMeta.ServerDate
            Dim dateTo = DataHelper.CVDate(p_baseEdit.EditValue)
            If (DateDiff(DateInterval.Day, currentDate, dateTo) < 0) Then
                _validateErrorText = String.Format("{0} cannot be greater than current date.", fieldName)
                SetErrProviderError(p_baseEdit, _validateErrorText)
                Return False
            End If
            Return True
        End If
    End Function

    Public Function CheckDateFromGreaterThanTo(ByRef p_dateFrom As DevExpress.XtraEditors.DateEdit, ByRef p_dateTo As DevExpress.XtraEditors.DateEdit, ByVal p_showError As Boolean) As Boolean

        ClearErrProviderError(p_dateTo)
        If (p_dateFrom.EditValue Is Nothing Or p_dateTo.EditValue Is Nothing Or Not p_dateTo.Enabled) Then
            Return True
        End If

        Dim dateFrom = DataHelper.CVDate(p_dateFrom.EditValue)
        Dim dateTo = DataHelper.CVDate(p_dateTo.EditValue)
        If (DateDiff(DateInterval.Day, dateFrom, dateTo) < 0) Then
            _validateErrorText = String.Format("{0} cannot be greater than {1}.", p_dateFrom.Tag, p_dateTo.Tag)
            SetErrProviderError(p_dateFrom, _validateErrorText)

            If (p_showError) Then
                MessageManager.ShowError(_validateErrorText, "Validate")
            End If
            Return False
        End If
        Return True
    End Function

    Protected Sub SetErrProviderError(ByVal sender As System.Object, ByRef p_strError As String)
        DxErrorProvider1.SetError(sender, p_strError, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        _controlsAreValid = False
    End Sub

    Protected Sub ClearErrProviderError(ByVal sender As System.Object)
        DxErrorProvider1.SetError(sender, String.Empty, DevExpress.XtraEditors.DXErrorProvider.ErrorType.None)
    End Sub

    Public Overridable Function ValidateControl() As Boolean
        Return ValidateControl(True)
    End Function

    Public Overridable Function ValidateControl(ByVal p_displayErrorMsg As Boolean) As Boolean
        _controlsAreValid = True
        _validateErrorText = String.Empty
        If Not (Me.ValidateChildren()) Then
            Return False
        End If

        If _controlsAreValid = False Then
            If (p_displayErrorMsg) Then
                DisplayMsgControlsNotValid()
            End If
            Return False
        End If

        If (Not ValidateDateFromTo()) Then
            Return False
        End If

        If (_masterFile IsNot Nothing) Then
            Dim validate = _masterFile.ValidateData()
            If (validate > 0) Then
                MessageManager.ShowError(validate, "Validation")
                Return False
            End If
        End If

        If (Not CustomValidateData()) Then
            Return False
        End If

        Return True
    End Function

    Protected Sub DisplayMsgControlsNotValid()
        If (String.IsNullOrEmpty(_validateErrorText)) Then
            MessageManager.ShowError("Please fill in required fields.", "Error")
        Else
            MessageManager.ShowError(_validateErrorText, "Error")
        End If
    End Sub

    Protected Sub SetRequiredFiledCaption(ByRef p_control As DevExpress.XtraEditors.LabelControl)
        p_control.AllowHtmlString = True
        p_control.Text = p_control.Text.Replace("*", String.Empty)
        p_control.Text = String.Format("{0}<color=red>*</color>", p_control.Text)
        ' Extra init before load and bind
    End Sub

    Protected Sub ClearRequiredFiledCaption(ByRef p_control As DevExpress.XtraEditors.LabelControl)
        p_control.Text = p_control.Text.Replace("*", String.Empty)
    End Sub


    Public Function ValidateDateFromTo() As Boolean
        _validateErrorText = String.Empty
        Dim result = DoValidateDateFromTo()
        If (Not result) Then
            MessageManager.ShowError(_validateErrorText, "Validate")
        End If
        Return result
    End Function

    Protected Overridable Function DoValidateDateFromTo() As Boolean
        Return True
    End Function

    Protected Function ValidatingDateFromTo(ByRef p_deDateFrom As DevExpress.XtraEditors.DateEdit, ByRef p_deDateTo As DevExpress.XtraEditors.DateEdit, ByVal p_fieldName As String) As Boolean
        Return ValidatingDateFromTo(p_deDateFrom, p_deDateTo, p_fieldName + " From ", p_fieldName + " To")
    End Function


    Protected Function ValidatingDateFromTo(ByRef p_deDateFrom As DevExpress.XtraEditors.DateEdit, ByRef p_deDateTo As DevExpress.XtraEditors.DateEdit, ByVal p_fieldNameFrom As String, ByVal p_fieldNameTo As String) As Boolean

        If ((Not p_deDateTo.Enabled) Or (p_deDateTo.ReadOnly = True) Or (Not p_deDateTo.Visible)) Then
            Return True
        End If

        ClearErrProviderError(p_deDateFrom)
        ClearErrProviderError(p_deDateTo)

        If (p_deDateTo.EditValue IsNot Nothing And p_deDateTo.EditValue IsNot DBNull.Value And (p_deDateFrom.EditValue Is Nothing Or p_deDateFrom.EditValue Is DBNull.Value)) Then
            _validateErrorText = String.Format("Please input {0}", p_fieldNameFrom)
            SetErrProviderError(p_deDateFrom, _validateErrorText)
            Return False
        End If

        If (p_deDateTo.EditValue IsNot Nothing And p_deDateFrom.EditValue IsNot Nothing And p_deDateTo.EditValue IsNot DBNull.Value And p_deDateFrom.EditValue IsNot DBNull.Value) Then
            Dim dateFrom = CDate(p_deDateFrom.EditValue)
            Dim dateTo = CDate(p_deDateTo.EditValue)
            If (DateDiff(DateInterval.Day, dateFrom, dateTo) < 0) Then
                _validateErrorText = String.Format("{0} cannot be greater than {0}.", p_fieldNameFrom, p_fieldNameTo)
                SetErrProviderError(p_deDateTo, _validateErrorText)
                p_deDateTo.Focus()
                Return False
            Else
                ClearErrProviderError(p_deDateTo)
            End If
        End If


        Return True

    End Function

#End Region


#Region "Waiting Form Show/Hide"
    Protected _showWaitingForm As Boolean
    Protected Sub StartWaiting()
        If (_showWaitingForm) Then
            Return
        End If

        _showWaitingForm = True

        'SplashScreenManager.ShowForm(Me, GetType(UI.WaitForm1), True, True, False)
    End Sub

    Protected Sub StopWaiting()
        'If (_showWaitingForm) Then
        '    SplashScreenManager.CloseForm(False)
        'End If
        _showWaitingForm = False
    End Sub
#End Region

End Class