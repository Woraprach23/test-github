Public Class CR
    Inherits MasterFile

    Public Property CRID As Integer
    Public Property CRNo As String
    Public Property ClientID As Integer
    Public Property ProductID As Integer
    Public Property ModuleName As String
    Public Property OpenDate As Date?
    Public Property Summary As String
    Public Property Detail As String
    Public Property EstFSDMandays As Decimal
    Public Property EstDevMandays As Decimal
    Public Property EstTestMandays As Decimal
    Public Property EstSupportMandays As Decimal
    Public Property EstTotalMandays As Decimal
    Public Property FSDMandays As Decimal
    Public Property DevMandays As Decimal
    Public Property TestMandays As Decimal
    Public Property SupportMandays As Decimal
    Public Property TotalMandays As Decimal

    Public Property FSDDate As Date?
    Public Property DeliveryDate As Date?
    Public Property SignOffDate As Date?
    Public Property DeliveryVersion As String
    Public Property PMO_No As String
    Public Property ItemNo As String
    Public Property JobID As Integer
    Public Property FSDID As Integer

#Region "Members"
    Private _file As File
    Public Property CurrentFiles As File
        Get
            If (_file Is Nothing) Then
                _file = New File
                _file.DocTypeID = DataEnums.DocType.FSD
                _file.ReferenceID = CRID
                _file.ReferenceTypeID = DataEnums.DocType.CR
                _file.LoadDataSourceByReferenceID(_file.ReferenceTypeID, _file.ReferenceID)
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
        TableName = "CR"
        KeyField = "CRID"
    End Sub
#End Region


    Public Sub Clone(ByVal p_id As Integer)
        Dim cr = New CR(p_id)
        ClientID = cr.ClientID
        ProductID = cr.ProductID
        ModuleName = cr.ModuleName 
    End Sub

    Public Function GetListBySelectedIDs(ByVal p_dt As DataTable, ByVal p_arrID As List(Of Integer)) As List(Of CR)
        Dim list = p_dt.ToList(Of CR)()
        Return list.Where(Function(a) p_arrID.Contains(a.CRID)).ToList
    End Function


    Public Sub LoadDataSourceByClientProductID(ByVal p_clientID As Integer, ByVal p_productID As Integer)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add("ClientID", p_clientID)
        dic.Add("ProductID", p_productID)
        LoadDataSource(dic)
    End Sub

End Class
