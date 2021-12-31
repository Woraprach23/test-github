Imports Finsoft.PM.Common
Imports System.ComponentModel

Public Class DoctypeForm
    Private _bindingSource As BindingSource
    Private _inst As Data.Doctype

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentValue As Data.Doctype
        Get
            If (_inst Is Nothing) Then
                If (KeyID > 0) Then
                    _inst = New Data.Doctype(KeyID)
                Else
                    _inst = New Data.Doctype
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _inst
            End If
            Return _inst
        End Get
        Set(value As Data.Doctype)
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
        controlValidate.SetRequiredFiledCaption(LabelControl1) 
        SetValidateRequiredField(txtDoctype) 

        txtDoctype.Properties.MaxLength = 50 
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentValue

        txtDoctype.DataBindings.Add("EditValue", _bindingSource, "Doctype", True, DataSourceUpdateMode.OnPropertyChanged)
       
    End Sub

End Class
