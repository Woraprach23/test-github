Imports System.ComponentModel
Imports Finsoft.PM.Common

Public Class UserForm
    Private _bindingSource As BindingSource
    Private _inst As Data.User

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentValue As Data.User
        Get
            If (_inst Is Nothing) Then
                If (KeyID > 0) Then
                    _inst = New Data.User(KeyID)
                Else
                    _inst = New Data.User
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _inst
            End If
            Return _inst
        End Get
        Set(value As Data.User)
            _inst = value
        End Set
    End Property

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        SetValidateRequiredField(txtUserName)
        SetValidateRequiredField(txtFullName)
        SetValidateRequiredField(lupRole)

        If (EditMode = AppEnums.EditMode.Add) Then
            controlValidate.SetRequiredFiledCaption(LabelControl3)
            SetValidateRequiredField(txtPassword)
        End If

        txtUserName.Properties.MaxLength = 50
        txtFullName.Properties.MaxLength = 250
        txtPassword.Properties.MaxLength = 250
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentValue
         
        txtUserName.DataBindings.Add("EditValue", _bindingSource, "UserName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtFullName.DataBindings.Add("EditValue", _bindingSource, "FullName", True, DataSourceUpdateMode.OnPropertyChanged)
        lupRole.DataBindings.Add("EditValue", _bindingSource, "RoleID", True, DataSourceUpdateMode.OnPropertyChanged)

    End Sub


    Protected Overrides Function ProcessSave() As Boolean

        If (EditMode = AppEnums.EditMode.Add) Then

        End If
        Return MyBase.ProcessSave()


    End Function
End Class
