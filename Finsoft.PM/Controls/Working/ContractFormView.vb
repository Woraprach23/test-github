Imports System.Collections

Public Class ContractFormView
    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "ContractID"
        CurrentGridControl = gcContract
        CurrentGridView = gvContract
    End Sub

    Protected Overrides Function GetDataSourceFromDB() As Object
        Dim Contract = New Data.Contract
        Contract.LoadDataSource()
        Return Contract.DataSource
    End Function

    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.Contract
        obj.DBDelete(p_id)
        Return True
    End Function

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        Dim form As New ContractForm(p_EditMode, p_id)
        Dim text = String.Format("{0} - {1}", form.Text, p_EditMode)
        form.Text = text
        If (form.ShowDialog = DialogResult.OK) Then
            LoadDataSource()
        End If
    End Sub

    Protected Overrides Function LoadGridLookupControlWorking(p_value As Object) As Object
        Dim hashTable As New Hashtable

        hashTable("contracttype") = Data.ConfigService.Config(Data.DataEnums.ConfigGroup.ContactType)
         
        'Dim client As New Data.Client
        'client.LoadDataSource()
        'hashTable("client") = client.DataSource

        'Dim product As New Data.Product
        'product.LoadDataSource()
        'hashTable("product") = product.DataSource

        'Dim contract As New Data.Contract
        'contract.LoadDataSource()
        'hashTable("contract") = contract.DataSource

        Return hashTable
    End Function

    Protected Overrides Sub LoadGridLookupControlComplete(p_value As Object)
        Dim hashTable As Hashtable = TryCast(p_value, Hashtable)
        'colClientID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("client"), "ClientID", "ClientCode")
        'colProductID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("product"), "ProductID", "ProductCode")
        'colMainContractID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("contract"), "ContractID", "ContractNo")
        colContractTypeID.ColumnEdit = New CustomRepositoryLookupConfig(hashTable("contracttype"))
    End Sub
End Class
