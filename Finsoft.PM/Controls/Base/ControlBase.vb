Imports Finsoft.PM.Common

Public Class ControlBase
    Public Property IsView As Boolean
    Public Property IsModify As Boolean
    Public Property IsApprove As Boolean
    Public Property IsProcess As Boolean
    Public Property IsAllowDelete As Boolean
    Protected _validateErrorText As String
    Public Property MenuCode As AppEnums.MenuCode = AppEnums.MenuCode.None
    Protected _isLoad As Boolean
    Protected _controlsAreValid As Boolean = True

    Private _editMove As AppEnums.EditMode = AppEnums.EditMode.View
    Public Property EditMode As AppEnums.EditMode
        Get
            Return _editMove
        End Get
        Set(value As AppEnums.EditMode)
            If (_editMove <> value) Then
                _editMove = value
                SetControlProperty(EditMode <> AppEnums.EditMode.View)
            End If
        End Set
    End Property

    Public ReadOnly Property IsEditable As Boolean
        Get
            Return EditMode <> AppEnums.EditMode.View
        End Get 
    End Property


    Private Sub ControlBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not DesignMode) Then
            Return
        End If

        RestoreLayout()
        SetButtonPermission(Me, Me)

    End Sub

    Public Overridable Sub SetControlProperty()
        SetControlProperty(Me, IsModify)
    End Sub

    Public Overridable Sub SetControlProperty(ByVal p_isEditable As Boolean)
        SetControlProperty(Me, p_isEditable)
    End Sub

    Public Overridable Sub SetControlProperty(ByRef ctrl As Control, ByVal p_isEditable As Boolean)
        Dim validator As New ControlValidator
        validator.SetControlProperty(Me, p_isEditable)
    End Sub

    Protected Overridable Sub SetButtonPermission(ByVal crtParent As Control, ByVal crt As Control)
        For Each Control In crt.Controls
            If Control.GetType() = GetType(DevExpress.XtraEditors.SimpleButton) Then
                Dim btn As DevExpress.XtraEditors.SimpleButton = Control
                If btn.AccessibleDescription Is Nothing Then
                    'for not set AccessibleDescription

                ElseIf btn.AccessibleDescription.Trim <> String.Empty Then

                    btn.Enabled = False
                    If IsView And btn.AccessibleDescription.Contains("View") Then
                        btn.Enabled = True
                    ElseIf IsModify And btn.AccessibleDescription.Contains("Modify") Then
                        btn.Enabled = True
                    ElseIf IsApprove And btn.AccessibleDescription.Contains("Approve") Then
                        btn.Enabled = True
                    ElseIf IsProcess And btn.AccessibleDescription.Contains("Process") Then
                        btn.Enabled = True
                    End If
                End If
            ElseIf Control.GetType() = GetType(DevExpress.XtraBars.Bar) Then
                Dim btn As DevExpress.XtraEditors.SimpleButton = Control
                If btn.AccessibleDescription Is Nothing Then
                    'for not set AccessibleDescription

                ElseIf btn.AccessibleDescription.Trim <> String.Empty Then
                    btn.Enabled = False
                    If IsView And btn.AccessibleDescription.Contains("View") Then
                        btn.Enabled = True
                    ElseIf IsModify And btn.AccessibleDescription.Contains("Modify") Then
                        btn.Enabled = True
                    ElseIf IsApprove And btn.AccessibleDescription.Contains("Approve") Then
                        btn.Enabled = True
                    ElseIf IsProcess And btn.AccessibleDescription.Contains("Process") Then
                        btn.Enabled = True
                    End If
                End If
            End If
            SetButtonPermission(crtParent, Control)
        Next
    End Sub

#Region "Layout"
    Public Overridable Sub SaveGrid()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
        'If (ApplicationMeta.PreviousMenuCode <> AppEnums.MenuCode.None) Then
        '    m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.PreviousMenuCode.ToString)
        'Else
        '    m.SaveLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)
        'End If
    End Sub

    Public Overridable Sub RestoreLayout()
        Dim m As UserLayoutManager = New UserLayoutManager
        m.RestoreLayout(Me, Me, ApplicationMeta.LoginUserID, ApplicationMeta.CurrentMenuCode.ToString)

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
                _validateErrorText = String.Format("{0} cannot be greater than {1}.", p_fieldNameFrom, p_fieldNameTo)
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

End Class
