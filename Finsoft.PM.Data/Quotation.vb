Public Class Quotation
    Inherits MasterFile

    Public Property QuotationID As Integer
    Public Property QuotationNo As String
    Public Property QuotationName As String
    Public Property QuotationDate As Date?
    Public Property ClientID As Integer
    Public Property ProductID As Integer
    Public Property ContractID As Integer
    Public Property InvoiceID As Integer

    Public Property ClientCode As String
    Public Property ProductCode As String

    'Job List 
    Private _jobList As List(Of Job)
    Public Property CurrentJobList As List(Of Job)
        Get
            If (_jobList Is Nothing) Then
                If (QuotationID > 0) Then
                    Dim job = New Job
                    job.LoadDataSource(KeyField, QuotationID)
                    _jobList = job.DataSource.ToList(Of Job)()
                End If

            End If
            Return _jobList
        End Get
        Set(value As List(Of Job))
            _jobList = value
        End Set
    End Property
     

    Private _file As File
    Public Property CurrentFiles As File
        Get
            If (_file Is Nothing) Then
                _file = New File
                _file.DocTypeID = DataEnums.DocType.Statementofwork
                _file.ReferenceID = QuotationID
                _file.ReferenceTypeID = DataEnums.DocType.Quatation
                _file.LoadDataSourceByReferenceID(_file.ReferenceTypeID, _file.ReferenceID)
            End If
            Return _file
        End Get
        Set(value As File)
            _file = value
        End Set
    End Property


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
        TableName = "Quotation"
        KeyField = "QuotationID"
    End Sub
#End Region

    Public Overrides Sub DBInsertUpdate()

        Dim isnew = PrimaryKeyID <= 0
        MyBase.DBInsertUpdate()

        If (isnew) Then
            Dim jobList = CurrentJobList
            For Each CR In jobList
                CR.LastUpdatedBy = CreatedBy
                CR.QuotationID = QuotationID
                CR.DBInsertUpdate()
            Next

            CurrentFiles.DBInsertUpdateTable(DataEnums.DocType.Quatation, QuotationID, CreatedBy)
        End If
    End Sub
    Public Function GetDataSet() As DataSet
         
        LoadDataSource()
        Dim mater As DataTable = DataSource
        Dim job As New Job
        job.LoadDataSource(-99)
        Dim detailTxType As DataTable = job.DataSource
         
        Dim ds As New DataSet
        ds.Tables.Add(mater)
        ds.Tables.Add(detailTxType) 

        'Set up a master-detail relationship between the DataTables 
        Dim keyColumn As DataColumn = mater.Columns(KeyField) 
        Dim foreignKeyColumn As DataColumn = detailTxType.Columns(KeyField)
         
        ds.Relations.Add("Quotation_Job", keyColumn, foreignKeyColumn)


        Return ds
    End Function 


    Public Function GetAmount() As Decimal?
        Dim amount = CurrentJobList.Select(Function(a) a.Amount).Sum()
        Return amount
    End Function
End Class
