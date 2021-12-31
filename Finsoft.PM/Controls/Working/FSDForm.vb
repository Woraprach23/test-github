Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Public Class FSDForm
    Private _bindingSource As BindingSource
    Private _value As Data.FSD

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentFSD As Data.FSD
        Get
            If (_value Is Nothing) Then
                If (KeyID > 0) Then
                    _value = New Data.FSD(KeyID)
                Else
                    _value = New Data.FSD
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _value
            End If
            Return _value
        End Get
        Set(value As Data.FSD)
            _value = value
        End Set
    End Property
     

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub AdditionalIntialize()
        AttachFileGridView1.ParentID = CurrentFSD.FSDID
        AttachFileGridView1.ParentType = AppEnums.DocType.FSD
        AttachFileGridView1.DocType = AppEnums.DocType.FSD
        AttachFileGridView1.CurrentFile = CurrentFSD.CurrentFiles
        AttachFileGridView1.EditMode = Me.EditMode
        AttachFileGridView1.RegisterGridControl()
        AttachFileGridView1.LoadDataSource()

        CrGridView1.ParentID = CurrentFSD.FSDID 
        CrGridView1.ParentType = AppEnums.DocType.FSD
        CrGridView1.EditMode = Me.EditMode
        CrGridView1.RegisterGridControl()
        If (EditMode <> AppEnums.EditMode.Add) Then
            CrGridView1.CurrentClientProduct = New Data.ClientProduct
            CrGridView1.CurrentClientProduct.ClientID = CurrentFSD.ClientID
            CrGridView1.CurrentClientProduct.ClientCode = CurrentFSD.ClientCode
            CrGridView1.CurrentClientProduct.ProductID = CurrentFSD.ProductID
            CrGridView1.CurrentClientProduct.ProductCode = CurrentFSD.ProductCode
            CrGridView1.LoadDataSource()
        Else
            CrGridView1.DataSource = CurrentFSD.CurrentCRList
        End If

    End Sub

    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl9)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        SetValidateRequiredField(txtFSDName) 
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentFSD

        'slueClient.DataBindings.Add("EditValue", _bindingSource, "ClientID", True, DataSourceUpdateMode.OnPropertyChanged)
        'slueProduct.DataBindings.Add("EditValue", _bindingSource, "ProductID", True, DataSourceUpdateMode.OnPropertyChanged)

        txtClientCode.DataBindings.Add("EditValue", _bindingSource, "ClientCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtPructionCode.DataBindings.Add("EditValue", _bindingSource, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtFSDName.DataBindings.Add("EditValue", _bindingSource, "FSDName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtFSDNo.DataBindings.Add("EditValue", _bindingSource, "FSDNo", True, DataSourceUpdateMode.OnPropertyChanged)
         
        deFSDDate.DataBindings.Add("EditValue", _bindingSource, "FSDDate", True, DataSourceUpdateMode.OnPropertyChanged)
        deSignOffDate.DataBindings.Add("EditValue", _bindingSource, "FSDSignOffDate", True, DataSourceUpdateMode.OnPropertyChanged)
        memoDetail.DataBindings.Add("EditValue", _bindingSource, "FSDDetail", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    ' Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
    '    Dim hashTable As New Hashtable

    '    Dim client As New Data.Client
    '    client.LoadDataSource()
    '    hashTable("client") = client.DataSource

    '    Dim product As New Data.Product
    '    product.LoadDataSource()
    '    hashTable("product") = product.DataSource

    '    Return hashTable
    'End Function


    'Protected Overrides Sub LoadControlCompleted(p_Result As Object)
    '    Dim hashTable As Hashtable = TryCast(p_Result, Hashtable)
    '     LookupManager.LoadLookUpEdit(slueClient, TryCast(hashTable("client"), DataTable), "ClientID", "ClientCode", Nothing)
    '    LookupManager.LoadLookUpEdit(slueProduct, TryCast(hashTable("product"), DataTable), "ProductID", "ProductCode", Nothing)
    'End Sub


    Public Overrides Function ValidateControl() As Boolean
        If (Not MyBase.ValidateControl()) Then
            Return False
        End If

        If (CrGridView1.CurrentGridView.RowCount = 0) Then
            MessageManager.ShowError("CR item is required.", btnSave.Text)
            xPageCR.Focus()
            Return False
        End If
        Return True
    End Function
End Class

