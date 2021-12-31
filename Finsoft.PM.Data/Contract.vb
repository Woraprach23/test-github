Public Class Contract
    Inherits MasterFile

#Region "Properties"
    Public Property ContractID AS Integer
    Public Property ContractNo As String
    Public Property ContractName As String
    Public Property QuotationID As Integer
    Public Property MainContractID As Integer
    Public Property ContractDate As Date?
    Public Property Amount As Decimal?
    Public Property StartDate As Date?
    Public Property Enddate As Date?
    Public Property ContractTypeID As String
#End Region

#Region "Members"
    Private _quotation As Quotation
    Public Property CurrentQuotation As Quotation
        Get
            If (_quotation Is Nothing) Then
                If (QuotationID > 0) Then
                    _quotation = New Quotation(QuotationID)
                Else
                    _quotation = New Quotation
                End If
            End If
            Return _quotation
        End Get
        Set(value As Quotation)
            _quotation = value
        End Set
    End Property

    Private _file As File
    Public Property CurrentFiles As File
        Get
            If (_file Is Nothing) Then
                _file = New File
                _file.DocTypeID = DataEnums.DocType.Contract
                _file.ReferenceID = ContractID
                _file.ReferenceTypeID = DataEnums.DocType.Contract
                '_file.LoadDataSourceByReferenceID(_file.ReferenceTypeID, _file.ReferenceID)
            End If
            Return _file
        End Get
        Set(value As File)
            _file = value
        End Set
    End Property
#End Region

#Region "Contructor"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal p_ID As Integer)
        MyBase.New(p_ID)
    End Sub
#End Region

#Region "Protected Overrides"
    Protected Overrides Sub SetMasterProperties()
        TableName = "Contract"
        KeyField = "ContractID"
    End Sub

    Public Overrides Sub DBInsertUpdate()
        Dim isnew = ContractID <= 0
        MyBase.DBInsertUpdate()

        If (isnew) Then
            Dim list = CurrentFiles.DataSource.ToList(Of Data.File)()
            For Each file In list
                file.ReferenceID = PrimaryKeyID
                file.CreatedBy = CreatedBy
                file.DBInsertUpdate()
            Next
        End If
    End Sub
#End Region

End Class
