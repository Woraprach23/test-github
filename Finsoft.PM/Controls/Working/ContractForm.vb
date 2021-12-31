Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Public Class ContractForm
    Private _bindingSource As BindingSource
    Private _contract As Data.Contract
    Private _parentID As Integer = 0
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentContract As Data.Contract
        Get
            If (_contract Is Nothing) Then
                If (KeyID > 0) Then
                    _contract = New Data.Contract(KeyID)
                Else
                    _contract = New Data.Contract
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _contract
            End If
            Return _contract
        End Get
        Set(value As Data.Contract)
            _contract = value
        End Set
    End Property

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer, ByVal p_QuotationID As Integer)
        EditMode = p_editmode
        KeyID = p_id
        CurrentContract.QuotationID = p_QuotationID
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub AdditionalIntialize()
        AttachFileGridView1.ShowCaption = True
        AttachFileGridView1.SetGridViewCaption = "Files"
        AttachFileGridView1.CurrentFile = CurrentContract.CurrentFiles
        AttachFileGridView1.ParentType = AppEnums.DocType.Contract
        AttachFileGridView1.DocType = AppEnums.DocType.Contract
        AttachFileGridView1.ParentID = CurrentContract.ContractID
        AttachFileGridView1.IsFixDocumentType = True
        AttachFileGridView1.EditMode = Me.EditMode
        AttachFileGridView1.RegisterGridControl()
        AttachFileGridView1.LoadDataSource()

        lueContractType.EditValue = 0
    End Sub

    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl9)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        controlValidate.SetRequiredFiledCaption(LabelControl8)

        SetValidateRequiredField(txtContractName)
        'SetValidateRequiredField(slueClient)
        'SetValidateRequiredField(slueProduct)
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentContract

        If (EditMode = AppEnums.EditMode.Add) Then
            CurrentContract.Amount = CurrentContract.CurrentQuotation.GetAmount 
        End If

        'slueClient.DataBindings.Add("EditValue", _bindingSource, "ClientID", True, DataSourceUpdateMode.OnPropertyChanged)
        'slueProduct.DataBindings.Add("EditValue", _bindingSource, "ProductID", True, DataSourceUpdateMode.OnPropertyChanged)
        'txtClientCode.DataBindings.Add("EditValue", _bindingSource, "ClientCode", True, DataSourceUpdateMode.OnPropertyChanged)
        'txtProductCode.DataBindings.Add("EditValue", _bindingSource, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged)

        slueMainContract.DataBindings.Add("EditValue", _bindingSource, "MainContractID", True, DataSourceUpdateMode.OnPropertyChanged)
        deContractDate.DataBindings.Add("EditValue", _bindingSource, "ContractDate", True, DataSourceUpdateMode.OnPropertyChanged)
        speAmount.DataBindings.Add("EditValue", _bindingSource, "Amount", True, DataSourceUpdateMode.OnPropertyChanged)
        lueContractType.DataBindings.Add("EditValue", _bindingSource, "ContractTypeID", True, DataSourceUpdateMode.OnPropertyChanged)
        deStartDate.DataBindings.Add("EditValue", _bindingSource, "StartDate", True, DataSourceUpdateMode.OnPropertyChanged)
        deEndDate.DataBindings.Add("EditValue", _bindingSource, "EndDate", True, DataSourceUpdateMode.OnPropertyChanged)
        txtContractName.DataBindings.Add("EditValue", _bindingSource, "ContractName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtContractNo.DataBindings.Add("EditValue", _bindingSource, "ContractNo", True, DataSourceUpdateMode.OnPropertyChanged)

        txtQuotationNo.Text = CurrentContract.CurrentQuotation.QuotationNo
        txtQuotationName.Text = CurrentContract.CurrentQuotation.QuotationName
        deQuotationDate.EditValue = CurrentContract.CurrentQuotation.QuotationDate

        txtClientCode.Text = CurrentContract.CurrentQuotation.ClientCode
        txtProductCode.Text = CurrentContract.CurrentQuotation.ProductCode
         
    End Sub


    Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
        Dim hashTable As New Hashtable

        hashTable("contracttype") = Data.ConfigService.Config(Data.DataEnums.ConfigGroup.ContactType)
        
        Dim contract As New Data.Contract
        contract.LoadDataSource()

        If (EditMode = AppEnums.EditMode.Edit) Then
            contract.DataSource.DefaultView.RowFilter = String.Format("ContractID <> {0}", CurrentContract.ContractID)
        End If

        hashTable("contract") = contract.DataSource

        'Dim client As New Data.Client
        'client.LoadDataSource()
        'hashTable("client") = client.DataSource

        'Dim product As New Data.Product
        'product.LoadDataSource()
        'hashTable("product") = product.DataSource

        Return hashTable
    End Function


    Protected Overrides Sub LoadControlCompleted(p_Result As Object)
        Dim hashTable As Hashtable = TryCast(p_Result, Hashtable)
        LookupManager.LoadLookUpEditConfig(lueContractType, TryCast(hashTable("contracttype"), DataTable), False)
        'LookupManager.LoadLookUpEdit(slueClient, TryCast(hashTable("client"), DataTable), "ClientID", "ClientCode", Nothing)
        'LookupManager.LoadLookUpEdit(slueProduct, TryCast(hashTable("product"), DataTable), "ProductID", "ProductCode", Nothing)
        LookupManager.LoadLookUpEdit(slueMainContract, TryCast(hashTable("contract"), DataTable), "ContractID", "ContractNo", Nothing)
    End Sub
     
    Private Sub lueContractType_EditValueChanged(sender As Object, e As EventArgs) Handles lueContractType.EditValueChanged
        If (Not _isLoad) Then
            Return
        End If

        If (lueContractType.EditValue IsNot Nothing And lueContractType.EditValue IsNot DBNull.Value) Then
            Dim id = Convert.ToInt32(lueContractType.EditValue)
            If (id = AppEnums.ContractType.Sub) Then
                slueMainContract.Properties.ReadOnly = False
            Else
                slueMainContract.EditValue = 0
                slueMainContract.Properties.ReadOnly = True
            End If
        End If

    End Sub

    Private Sub btnViewQuatation_Click(sender As Object, e As EventArgs) Handles btnViewQuatation.Click
        Dim form As New QuotationForm(AppEnums.EditMode.View, CurrentContract.QuotationID)
        Dim text = String.Format("{0} - {1}", form.Text, AppEnums.EditMode.View)
        form.Text = text
        form.ShowDialog()
    End Sub


    Protected Overrides Function ProcessSave() As Boolean
        If (EditMode <> AppEnums.EditMode.Add) Then
            Return MyBase.ProcessSave()
        End If

        CurrentContract.DBInsertUpdate()
        CurrentContract.CurrentQuotation.ContractID = CurrentContract.ContractID
        CurrentContract.CurrentQuotation.LastUpdatedBy = CurrentContract.CreatedBy
        CurrentContract.CurrentQuotation.DBInsertUpdate()
        Return True
    End Function
End Class
