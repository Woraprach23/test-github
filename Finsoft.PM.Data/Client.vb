Public Class Client
    Inherits MasterFile

    Public Property ClientID As Integer
    Public Property ClientCode As String
    Public Property TaxID As String
    Public Property ClientName As String

    Public Property CurrentAddress As Address
    Private _caAddressList As List(Of Address)
    Public Property CurrentAddressList As List(Of Address)
        Get
            If (_caAddressList Is Nothing) Then
                If (ClientID > 0) Then
                    Dim obj As New Address
                    obj.LoadDataSource(ClientID)
                    _caAddressList = obj.DataSource.ToList(Of Address)()
                Else
                    _caAddressList = New List(Of Address)
                End If
            End If
            Return _caAddressList
        End Get
        Set(value As List(Of Address))
            _caAddressList = value
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
        TableName = "Client"
        KeyField = "ClientID"
    End Sub
#End Region


#Region "Address"

    Public Sub SelectAddress(ByVal p_AddressID As Integer)
        CurrentAddress = CurrentAddressList.Where(Function(a) a.AddressID = p_AddressID).FirstOrDefault
        If (CurrentAddress Is Nothing) Then
            CurrentAddress = New Address
            CurrentAddress.ClientID = ClientID
        End If
    End Sub

    Public Sub UpdateAddress(ByVal p_Address As Address, ByVal p_userID As Integer)
        CurrentAddress = CurrentAddressList.Where(Function(a) a.AddressID = p_Address.AddressID).FirstOrDefault
        If (CurrentAddress Is Nothing) Then
            CurrentAddress = New Address
            CurrentAddress.CopyValue(p_Address)
            CurrentAddress.CreatedBy = p_userID
            If (CurrentAddress.AddressID <= 0) Then
                CurrentAddress.AddressID = (CurrentAddressList.Count + 1) * -1
            End If
            CurrentAddressList.Add(CurrentAddress)
        Else
            CurrentAddress.CopyValue(p_Address)
            CurrentAddress.LastUpdatedBy = p_userID
        End If

        If (ClientID > 0) Then
            CurrentAddress.ClientID = ClientID
            CurrentAddress.DBInsertUpdate()
            CurrentAddress.AddressID = CurrentAddress.PrimaryKeyID
        End If
    End Sub

    Public Sub DeleteAddress(ByVal p_AddressID As Integer)
        Dim delete = CurrentAddressList.Where(Function(a) a.AddressID = p_AddressID).FirstOrDefault
        If (delete Is Nothing) Then
            Return
        End If

        If (delete.AddressID > 0) Then
            delete.DBDelete(delete.AddressID)
        End If

        CurrentAddressList.Remove(delete)
    End Sub
#End Region


    Public Overrides Sub DBInsertUpdate()

        Dim isNew = ClientID <= 0
        MyBase.DBInsertUpdate()

        If (isNew) Then
            For Each item In CurrentAddressList
                item.ClientID = ClientID
                item.CreatedBy = CreatedBy
                item.DBInsertUpdate()
            Next
        End If
         
    End Sub


End Class
