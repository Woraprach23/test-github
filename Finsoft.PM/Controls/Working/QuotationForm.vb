Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Public Class QuotationForm
    Private _bindingSource As BindingSource
    Private _value As Data.Quotation

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentQuotation As Data.Quotation
        Get
            If (_value Is Nothing) Then
                If (KeyID > 0) Then
                    _value = New Data.Quotation(KeyID)
                Else
                    _value = New Data.Quotation
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _value
            End If
            Return _value
        End Get
        Set(value As Data.Quotation)
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
        AttachFileGridView1.ParentID = CurrentQuotation.QuotationID
        AttachFileGridView1.ParentType = AppEnums.DocType.Quotation 
        AttachFileGridView1.CurrentFile = CurrentQuotation.CurrentFiles
        AttachFileGridView1.EditMode = Me.EditMode
        AttachFileGridView1.IsFixDocumentType = True
         AttachFileGridView1.RegisterGridControl()
        AttachFileGridView1.LoadDataSource()
         
        JobGridView1.QuotationID = CurrentQuotation.QuotationID 
        JobGridView1.EditMode = Me.EditMode
        JobGridView1.RegisterGridControl()
        If (EditMode <> AppEnums.EditMode.Add) Then
            JobGridView1.CurrentClientProduct = New Data.ClientProduct
            JobGridView1.CurrentClientProduct.ClientID = CurrentQuotation.ClientID
            JobGridView1.CurrentClientProduct.ClientCode = CurrentQuotation.ClientCode
            JobGridView1.CurrentClientProduct.ProductID = CurrentQuotation.ProductID
            JobGridView1.CurrentClientProduct.ProductCode = CurrentQuotation.ProductCode

            JobGridView1.LoadDataSource()
        Else
            JobGridView1.DataSource = CurrentQuotation.CurrentJobList
        End If

    End Sub

    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl1)
        controlValidate.SetRequiredFiledCaption(LabelControl9)
        controlValidate.SetRequiredFiledCaption(LabelControl19)
        SetValidateRequiredField(txtQuotationName)
        SetValidateRequiredField(deQuotationDate)
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentQuotation

        'slueClient.DataBindings.Add("EditValue", _bindingSource, "ClientID", True, DataSourceUpdateMode.OnPropertyChanged)
        'slueProduct.DataBindings.Add("EditValue", _bindingSource, "ProductID", True, DataSourceUpdateMode.OnPropertyChanged)

        txtClientCode.DataBindings.Add("EditValue", _bindingSource, "ClientCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtProductCode.DataBindings.Add("EditValue", _bindingSource, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtQuotationName.DataBindings.Add("EditValue", _bindingSource, "QuotationName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtQuotationNo.DataBindings.Add("EditValue", _bindingSource, "QuotationNo", True, DataSourceUpdateMode.OnPropertyChanged)
        deQuotationDate.DataBindings.Add("EditValue", _bindingSource, "QuotationDate", True, DataSourceUpdateMode.OnPropertyChanged)
        'deSignOffDate.DataBindings.Add("EditValue", _bindingSource, "QuotationSignOffDate", True, DataSourceUpdateMode.OnPropertyChanged)
        'memoDetail.DataBindings.Add("EditValue", _bindingSource, "QuotationDetail", True, DataSourceUpdateMode.OnPropertyChanged)
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


    'Public Overrides Function ValidateControl() As Boolean
    '    If (Not MyBase.ValidateControl()) Then
    '        Return False
    '    End If

    '    Return True
    'End Function

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If (e.Page Is xPageStatementofwork) Then
            SetFileRowFilter(AppEnums.DocType.Statementofwork)
        ElseIf e.Page Is xPageInvoice Then
            SetFileRowFilter(AppEnums.DocType.Invoice)
        Else
            Return
        End If

        AttachFileGridView1.Parent = e.Page
    End Sub

    Private Sub SetFileRowFilter(ByVal p_docType As AppEnums.DocType)
        AttachFileGridView1.DocType = p_docType
        If (CurrentQuotation.CurrentFiles.DataSource IsNot Nothing) Then
            Dim rowFilter = String.Format("DocTypeID = {0}", CInt(p_docType))
            CurrentQuotation.CurrentFiles.DataSource.DefaultView.RowFilter = rowFilter
            Me.AttachFileGridView1.DataSource = CurrentQuotation.CurrentFiles.DataSource
        End If
    End Sub
     
End Class

