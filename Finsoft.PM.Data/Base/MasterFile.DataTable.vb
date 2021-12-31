Imports System.Data.SqlClient

Partial Public Class MasterFile
    Public Event NewRowInserted(ByVal p_oldKeyID As Integer, ByVal p_NewkeyID As Integer)

#Region "DB Load DataSource"
    Public Function GetDataSource() As DataTable
        If DataSource Is Nothing Then
            LoadDataSource()
        End If
        Return DataSource
    End Function

    Public Overridable Sub LoadDataSource()
        LoadDataSource(Nothing)
    End Sub
     
    Public Sub LoadDataSource(ByVal p_ParentValue As Object)
        Dim dic As New Dictionary(Of String, Object)
        If Not String.IsNullOrEmpty(ParentField) Then
            dic.Add(ParentField, p_ParentValue)
        End If
        LoadDataSource(dic)
    End Sub
     
    Public Sub LoadDataSource(ByVal p_FieldName As String, ByRef p_Value As Object)
        Dim dic As New Dictionary(Of String, Object)
        If Not String.IsNullOrEmpty(p_FieldName) Then
            dic.Add(p_FieldName, p_Value)
        End If
        LoadDataSource(dic)
    End Sub

    Public Sub LoadDataSource(ByVal p_FieldName As String, ByRef p_Value As Object, ByVal p_FieldName2 As String, ByRef p_Value2 As Object)
        Dim dic As New Dictionary(Of String, Object)
        If Not String.IsNullOrEmpty(p_FieldName) Then
            dic.Add(p_FieldName, p_Value)
        End If
        If Not String.IsNullOrEmpty(p_FieldName2) Then
            dic.Add(p_FieldName2, p_Value2)
        End If
        LoadDataSource(dic)
    End Sub

    Public Sub LoadDataSource(ByVal p_params As Dictionary(Of String, Object))
        LoadDataSource(String.Format("dbo.{0}_List", _tableName), p_params)
    End Sub

    Protected Sub LoadDataSource(ByVal p_ProcName As String, ByVal p_params As System.Collections.Generic.Dictionary(Of String, Object))
        Dim dt As New DataTable()

        Dim i As Integer = 0

        If p_params IsNot Nothing Then
            Dim params(p_params.Count - 1) As SqlParameter
            For Each key As String In p_params.Keys
                params(i) = New SqlParameter("@" + key, p_params(key))
                i += 1
            Next
            If (p_ProcName.IndexOf("dbo.") < 0) Then
                p_ProcName = String.Concat("dbo.", p_ProcName)
            End If
            dt = DBProc.GetDataTableByProc_Params(p_ProcName, params)
        Else
            dt = DBProc.GetDataTableByProc(p_ProcName)
        End If

        Try
            SetPrimaryKey(dt, _keyField)
        Catch ex As Exception

        End Try


        If dt IsNot Nothing Then
            dt.AcceptChanges()
        End If

        DataSource = dt
    End Sub

    Protected Sub LoadDataSource(ByVal p_ProcName As String, ByVal p_params As System.Collections.Generic.Dictionary(Of String, Object), ByVal p_conn As SqlClient.SqlConnection, ByVal p_trann As SqlClient.SqlTransaction)
        Dim dt As New DataTable()
        If (p_ProcName.IndexOf("dbo.") < 0) Then
            p_ProcName = String.Concat("dbo.", p_ProcName)
        End If

        If p_params Is Nothing Then
            dt = DBProc.GetDataTableByProc_Params(p_conn, p_trann, p_ProcName, Nothing, 600)
        Else

            Dim params(p_params.Count - 1) As SqlParameter
            Dim i As Integer = 0


            For Each key As String In p_params.Keys
                params(i) = New SqlParameter("@" + key, p_params(key))
                i += 1
            Next
            dt = DBProc.GetDataTableByProc_Params(p_conn, p_trann, p_ProcName, params, 600)
        End If

        SetPrimaryKey(dt, _keyField)

        dt.AcceptChanges()

        DataSource = dt
    End Sub

#End Region

#Region "DB Insert/Update/Delete"
    Public Overridable Sub DBUpdateDataTable(ByVal p_LastUpdatedBy As Integer)
        LastUpdatedBy = p_LastUpdatedBy
        DBUpdateDataTable()
    End Sub
    Public Overridable Sub DBUpdateDataTable()
        If (IsDataTableChanged()) Then

            Dim conn As SqlConnection = Nothing
            Dim tran As SqlTransaction = Nothing

            Try
                conn = New SqlConnection(DBProc.DBConnectionString)
                conn.Open()
                tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted)

                DBUpdateDataTable(Me, conn, tran, LastUpdatedBy)

                tran.Commit()

                DataSource.AcceptChanges()
            Catch ex As Exception
                DataSource.RejectChanges()
                tran.Rollback()
                Throw ex
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End If

    End Sub

    Public Overridable Sub DBUpdateDataTable(ByRef p_conn As SqlConnection, ByVal p_tran As SqlTransaction)
        DBUpdateDataTable(Me, p_conn, p_tran, LastUpdatedBy)
    End Sub
 

    Public Overridable Sub DBUpdateDataTable(ByVal p_instance As MasterFile, ByRef p_conn As SqlConnection, ByVal p_tran As SqlTransaction, ByVal p_LastUpdatedBy As Integer)
        If (IsDataTableChanged()) Then

            Dim editRows() As DataRow = DataSource.Select(String.Empty, String.Empty, DataViewRowState.ModifiedCurrent Or DataViewRowState.Added)
            For Each row As DataRow In editRows

                Dim p_type As Type = p_instance.GetType()
                Dim obj As MasterFile = Activator.CreateInstance(p_type)
                If row(KeyField) > 0 Then
                    obj.LoadDataFromMaster(p_conn, p_tran, row(KeyField))
                End If
                row.ToProperties(obj)

                obj.LastUpdatedBy = p_LastUpdatedBy
                obj.DBInsertUpdate(p_conn, p_tran)

                If row.RowState = DataRowState.Added Then
                    Dim oldID As Object = row(KeyField)
                    UpdateReferenceID(oldID, obj.PrimaryKeyID)
                End If

                DataSource.Columns(obj.KeyField).ReadOnly = False
                row(KeyField) = obj.PrimaryKeyID
            Next

            Dim deleteRows() As DataRow = DataSource.Select(String.Format("{0} > 0", p_instance.KeyField), String.Empty, DataViewRowState.Deleted)
            For Each row As DataRow In deleteRows
                p_instance.PrimaryKeyID = row(KeyField, DataRowVersion.Original)
                p_instance.DBDelete(p_conn, p_tran, p_instance.KeyField, p_instance.PrimaryKeyID)
            Next

        End If
    End Sub

    Private Sub EventHandler_RowUpdated(ByVal p_sender As SqlDataAdapter, ByVal e As SqlRowUpdatedEventArgs)
        If e.Row.RowState <> DataRowState.Added Then
            Return
        End If

        If e.Command.Parameters.Contains("@" + KeyField) AndAlso e.Command.Parameters("@" + KeyField).Value IsNot Nothing And Not IsDBNull(e.Command.Parameters("@" + KeyField).Value) Then
            e.Row(KeyField) = e.Command.Parameters("@" + KeyField).Value
        End If

    End Sub

    Private Sub SetInsertUpdateTableParameters(ByVal p_source As DataTable, ByRef cmd As SqlClient.SqlCommand)
        Dim dt As DataTable = Data.DBProc.GetDataTableByProc_Params("dbo.GetProcParameters_List", {New SqlClient.SqlParameter("@PROC_NAME", cmd.CommandText.Replace("dbo.", String.Empty))})
        Dim param As SqlClient.SqlParameter
        Dim paramName As String
        Dim fieldName As String
        Dim paramMode As String

        For Each row As System.Data.DataRow In dt.Rows
            paramName = CStr(row("PARAMETER_NAME"))
            fieldName = paramName.Replace("@", String.Empty)
            paramMode = CStr(row("PARAMETER_MODE"))
            If Not p_source.Columns.Contains(fieldName) Then
                'If paramMode = "INOUT" Or paramMode = "OUT" Then
                '    p_source.Columns.Add(fieldName, GetType(Integer))
                'Else
                Continue For
                'End If
            End If

            param = New SqlClient.SqlParameter()
            param.ParameterName = paramName
            param.SourceColumn = fieldName

            Dim paramtTYPE As String = CStr(row("DATA_TYPE"))

            Select Case paramtTYPE
                Case "int"
                    param.SqlDbType = SqlDbType.Int
                Case "decimal"
                    param.SqlDbType = SqlDbType.Decimal
                Case "date"
                    param.SqlDbType = SqlDbType.Date
                Case "datetime"
                    param.SqlDbType = SqlDbType.DateTime
            End Select
            If (paramtTYPE = "varchar") Then
                Dim maxlenght As Integer = CInt(row("CHARACTER_MAXIMUM_LENGTH"))
                param.SqlDbType = SqlDbType.VarChar
                param.Size = maxlenght
            End If
            If (paramMode = "INOUT") Then
                param.Direction = ParameterDirection.InputOutput
            End If

            If (paramMode = "OUT") Then
                param.Direction = ParameterDirection.Output
            End If

            cmd.Parameters.Add(param)
        Next
    End Sub

    'Public Overridable Sub DBUpdateDataTable(ByVal p_instance As MasterFile, ByRef p_conn As SqlConnection, ByVal p_tran As SqlTransaction, ByVal p_LastUpdatedBy As Integer)
    '    If (IsDataTableChanged()) Then

    '        Dim editRows() As DataRow = DataSource.Select(String.Empty, String.Empty, DataViewRowState.ModifiedCurrent Or DataViewRowState.Added)
    '        For Each row As DataRow In editRows

    '            Dim p_type As Type = p_instance.GetType()
    '            Dim obj As MasterFile = Activator.CreateInstance(p_type)
    '            If row(_keyField) > 0 Then
    '                obj.LoadData(p_conn, p_tran, row(_keyField))
    '            End If
    '            row.ToProperties(obj)

    '            'obj.LastLastUpdatedBy = p_LastUpdatedBy
    '            'obj.ChangedList = obj.GetChangedList(row)
    '            obj.DBInsertUpdate(p_conn, p_tran)

    '            If row.RowState = DataRowState.Added OrElse row(_keyField) <> obj.PrimaryKeyID Then
    '                Dim oldID As Object = row(_keyField)
    '                UpdateReferenceID(oldID, obj.PrimaryKeyID)
    '            End If

    '            DataSource.Columns(obj.KeyField).ReadOnly = False
    '            row(_keyField) = obj.PrimaryKeyID
    '        Next

    '        Dim deleteRows() As DataRow = DataSource.Select(String.Format("{0} > 0", p_instance.KeyField), String.Empty, DataViewRowState.Deleted)
    '        For Each row As DataRow In deleteRows
    '            p_instance.PrimaryKeyID = row(_keyField, DataRowVersion.Original)
    '            p_instance.DBDelete(p_conn, p_tran, p_instance.KeyField, p_instance.PrimaryKeyID)
    '        Next
    '    End If
    'End Sub

#End Region

#Region "Data Table"

    Protected Sub SetPrimaryKey(ByRef dt As DataTable, ByVal _KeyFieldName As String)
        If dt Is Nothing Then
            Return
        End If

        If Not dt.Columns.Contains(_KeyFieldName) Then
            Return
        End If
        If (Not String.IsNullOrEmpty(_KeyFieldName)) Then
            Dim pkColumns(1) As DataColumn
            pkColumns(0) = dt.Columns(_KeyFieldName)
            pkColumns(0).AutoIncrement = True
            pkColumns(0).AutoIncrementSeed = -1
            pkColumns(0).AutoIncrementStep = -1
            pkColumns(0).AllowDBNull = False
            pkColumns(0).ReadOnly = False

            dt.PrimaryKey = pkColumns
        End If

        For Each col As DataColumn In dt.Columns
            col.ReadOnly = False
        Next

        If Not String.IsNullOrEmpty(_tableName) Then
            dt.TableName = _tableName
        End If

    End Sub

    Public Function GetRowByKeyID(ByVal keyID As Integer) As DataRow
        Return DataSource.Rows.Find(keyID)
    End Function

    Public Overridable Sub InsertUpdateRow()
        InsertUpdateRow(Me)
    End Sub

    Public Sub InsertUpdateRow(ByVal p_baseEn As MasterFile)
        Dim id As Integer = GetValue(p_baseEn, _keyField)
        If DataSource Is Nothing Then
            LoadDataSource()
        End If

        Dim selectedRow As DataRow = DataSource.Rows.Find(id)

        Dim isNewRow As Boolean = False
        If (selectedRow Is Nothing) Then
            Dim col As DataColumn = DataSource.PrimaryKey(0)
            If col IsNot Nothing Then
                col.AutoIncrement = True
                col.AutoIncrementSeed = -1
                col.AutoIncrementStep = -1
            End If
            isNewRow = True
            selectedRow = DataSource.NewRow
            If selectedRow(_keyField) > 0 Then
                selectedRow(_keyField) = DataSource.Rows.Count * -1
            End If

        End If

        selectedRow.LoadValueFromInstant(p_baseEn)

        If isNewRow Then
            DataSource.Rows.Add(selectedRow)

            If p_baseEn.PrimaryKeyID > 0 Then
                selectedRow(p_baseEn.KeyField) = p_baseEn.PrimaryKeyID
            Else
                Dim newID As Integer = DataSource.Rows(DataSource.Rows.Count - 1)(p_baseEn.KeyField)
                If newID > 0 Then
                    p_baseEn.PrimaryKeyID = DataSource.Rows.Count * -1
                    selectedRow(p_baseEn.KeyField) = p_baseEn.PrimaryKeyID
                Else
                    p_baseEn.PrimaryKeyID = newID
                End If
            End If

        End If
    End Sub

    Public Overridable Sub SelectRow(ByVal keyID As Integer)
        If DataSource Is Nothing Then
            SetDefault()
            Return
        End If

        Dim row As DataRow = DataSource.Rows.Find(keyID)

        If (row IsNot Nothing) Then
            row.ToProperties(Me)
        Else
            SetDefault()
        End If
    End Sub

    Public Overridable Sub UpdateRow()
        If (DataSource Is Nothing) Then
            Return
        End If

        Dim id As Integer = GetValue(Me, _keyField)
        Dim selectedRow As DataRow = DataSource.Rows.Find(id)
        If (selectedRow Is Nothing) Then
            selectedRow = DataSource.NewRow

            DataSource.Rows.Add(selectedRow)
        End If
        selectedRow.LoadValueFromInstant(Me)
    End Sub

    Public Overridable Sub UpdateRow(ByVal p_value As Object)
        If (DataSource Is Nothing) Then
            Return
        End If

        Dim id As Integer = GetValue(Me, _keyField)
        Dim selectedRow As DataRow = DataSource.Rows.Find(id)
        If (selectedRow Is Nothing) Then
            selectedRow = DataSource.NewRow

            DataSource.Rows.Add(selectedRow)
        End If
        selectedRow.LoadValueFromInstant(p_value)
    End Sub


    Public Sub DeleteRow()
        DeleteRow(PrimaryKeyID)
    End Sub

    Public Sub DeleteRow(ByVal p_keyID As Integer)
        Dim row As DataRow = DataSource.Rows.Find(p_keyID)
        If row Is Nothing Then
            Return
        End If

        If DataSource.Columns.Contains("TxType") Then
            Dim txtype As Object = row("TxType")
            Dim txTypestr As String = String.Empty
            If (txtype IsNot DBNull.Value) Then
                txTypestr = row("TxType").ToString
            End If
            If txtype = "Add" Then
                If (row IsNot Nothing) Then
                    row("TxType") = "Delete"
                    row.Delete()
                End If
            Else
                If (row IsNot Nothing) Then
                    row("TxType") = "Delete"
                End If
            End If
        Else
            If row.RowState <> DataRowState.Unchanged Or row.RowState <> DataRowState.Deleted Then
                row.AcceptChanges()
            End If
            row.Delete()
            'row.AcceptChanges()
        End If
    End Sub

    Public Sub DeleteRowByFieldValue(ByVal p_field As String, ByVal p_value As Integer)
        For Each row As DataRow In DataSource.Select(String.Format("{0}={1}", p_field, p_value))
            If row.RowState <> DataRowState.Unchanged Or row.RowState <> DataRowState.Deleted Then
                row.AcceptChanges()
            End If
            row.Delete()
            row.AcceptChanges()
        Next
    End Sub

    Public Sub UpdateParentFieldID(ByVal p_ParentID As Integer)
        UpdateFiledValue(_parentField, p_ParentID)
    End Sub

    Public Sub UpdateFiledValue(ByVal p_Field As String, ByVal p_value As Object)
        If DataSource IsNot Nothing Then
            For Each row As DataRow In DataSource.Rows
                If row.RowState = DataRowState.Deleted Then
                    Continue For
                End If
                If IsDBNull(row(p_Field)) OrElse row(p_Field) Is Nothing Then
                    row(p_Field) = p_value
                Else
                    If row(p_Field) <> p_value Then
                        row(p_Field) = p_value
                    End If
                End If

            Next
        End If
    End Sub

    Public Sub UpdateFiledValue(ByVal p_Field As String, ByVal p_value As Object, ByVal p_Keyfield As String, ByVal p_KeyID As Object)
        Dim rows() As DataRow = DataSource.Select(String.Format("{0} = {1}", p_Keyfield, p_KeyID))
        For Each row As DataRow In rows
            If IsDBNull(row(p_Field)) And IsDBNull(p_value) Then
                Continue For
            End If

            If IsDBNull(row(p_Field)) And Not IsDBNull(p_value) Then
                row(p_Field) = p_value
            End If

            If Not IsDBNull(row(p_Field)) And IsDBNull(p_value) Then
                row(p_Field) = p_value
            End If

            If row(p_Field) <> p_value Then
                row(p_Field) = p_value
            End If
        Next
    End Sub

    Public Sub UpdateFiledValue(ByVal p_Field As String, ByVal p_value As Object, ByVal p_KeyID As Integer)
        Dim row As DataRow = GetRowByKeyID(p_KeyID)
        If row IsNot Nothing Then
            If row(p_Field) <> p_value Then
                row(p_Field) = p_value
            End If
        End If
    End Sub

    Public Sub UpdateFiledValueByOldValue(ByVal p_Field As String, ByVal p_oldValue As Object, ByVal p_newValue As Object)
        Dim rows() As DataRow = DataSource.Select(String.Format("{0} = {1}", p_Field, p_oldValue))
        For Each row As DataRow In rows
            If row(p_Field) <> p_newValue Then
                row(p_Field) = p_newValue
            End If
        Next

    End Sub

    Public Function GetFiledValueByKey(ByVal p_KeyID As Integer, ByVal p_Field As String) As Object
        Dim row As DataRow = GetRowByKeyID(p_KeyID)
        If row IsNot Nothing Then
            Return row(p_Field)
        End If
        Return Nothing
    End Function

    Public Function IsDataTableChanged() As Boolean
        If (DataSource IsNot Nothing) Then
            Dim ischange As Boolean = DataSource.Select(String.Empty, String.Empty, DataViewRowState.ModifiedCurrent Or DataViewRowState.Added Or DataViewRowState.Deleted).Length > 0
            Return ischange
        End If
        Return False
    End Function

    'Public Sub CreateColumnIsSelect()
    '    CreateColumnIsSelect(DataSource)
    'End Sub

    'Public Sub CreateColumnIsSelect(ByRef p_dataSource As DataTable)
    '    If p_dataSource Is Nothing Then
    '        Return
    '    End If

    '    If Not p_dataSource.Columns.Contains("IsSelect") Then
    '        p_dataSource.Columns.Add("IsSelect", GetType(Boolean))
    '    End If
    '    p_dataSource.Columns("IsSelect").ReadOnly = False
    '    p_dataSource.Columns("IsSelect").DefaultValue = False
    'End Sub

    Public Function GetCloneByFilter(ByVal p_keyField As String, ByVal p_keyID As Integer) As DataTable
        If DataSource Is Nothing Then
            Return Nothing
        End If

        Dim dvByFilter As New DataView
        dvByFilter = New DataView(DataSource, String.Format("{0} = {1}", p_keyField, p_keyID), String.Empty, DataViewRowState.Added Or DataViewRowState.Unchanged Or DataViewRowState.ModifiedCurrent)
        Dim copyTable As New DataTable
        copyTable = dvByFilter.ToTable()


        Dim clone As New DataTable
        clone = copyTable.Copy()
        clone.AcceptChanges()

        Return clone
    End Function


    Public Sub UpdateDataTable(ByVal p_base As MasterFile, ByVal p_dataTable As DataTable)

        Dim updatedRows() As DataRow = p_dataTable.Select(String.Empty, String.Empty, DataViewRowState.Added Or DataViewRowState.ModifiedCurrent)
        For Each row As DataRow In updatedRows
            p_base.Mapping(row)
            InsertUpdateRow(p_base)
        Next

        Dim deleteRows() As DataRow = p_dataTable.Select(String.Empty, String.Empty, DataViewRowState.Deleted)
        For Each row As DataRow In deleteRows
            Dim key As Integer = row(_keyField)
            If key > 0 Then
                DeleteRow(row(_keyField))
            Else
                row.Delete()
                row.AcceptChanges()
            End If
        Next
    End Sub

    Public Sub CopyRow(ByVal p_source As DataTable, ByVal p_userID As Integer, ByVal p_newNCRID As Integer, ByVal p_DateField As String, ByVal p_Date As Date)
        If DataSource Is Nothing Then
            Return
        End If

        For Each sourceRow As DataRow In p_source.Rows
            Dim newRow As DataRow = DataSource.NewRow
            For Each col As DataColumn In p_source.Columns
                If col.ColumnName = "LastLastUpdatedBy" Or col.ColumnName = "LastUpdated" Or col.ColumnName = KeyField Then
                    Continue For
                ElseIf col.ColumnName = "NCRMainID" Then
                    newRow(col.ColumnName) = p_newNCRID
                ElseIf col.ColumnName = p_DateField Then
                    newRow(col.ColumnName) = p_Date
                ElseIf col.ColumnName = "CreatedBy" Then
                    newRow(col.ColumnName) = p_userID
                Else
                    If DataSource.Columns.Contains(col.ColumnName) Then
                        newRow(col.ColumnName) = sourceRow(col.ColumnName)
                    End If
                End If
            Next

            DataSource.Rows.Add(newRow)
        Next

    End Sub

    Public Function CheckDuplicatedValueDB(ByVal p_dic As Dictionary(Of String, Object)) As Boolean
        Dim strFilter As String = String.Empty
        For Each key As String In p_dic.Keys
            strFilter += String.Format("AND {0} = {1}", key, DataConverter.GetSQLString(p_dic(key)))
        Next

        strFilter = strFilter.Substring(0, 4)

        Return CheckDuplicatedValueDB(strFilter)
    End Function

    Public Function CheckDuplicatedValueDB(ByVal p_field As String, ByVal p_Value As Object, p_keyField As String, ByVal p_key As Integer) As Boolean
        Dim strFilter As String = String.Format("{0} = {1} AND {2} <> {3}", p_field, DataConverter.GetSQLString(p_Value), p_keyField, p_key)
        Return CheckDuplicatedValueDB(strFilter)
    End Function

    Public Function CheckDuplicatedValueDB(ByVal p_field As String, ByVal p_Value As Object, ByVal p_field2 As String, ByVal p_Value2 As Object, ByVal p_keyField As String, ByVal p_key As Integer) As Boolean
        Dim strFilter As String = String.Format("{0} = {1} AND {2} = {3} AND {4} <> {5}", p_field, DataConverter.GetSQLString(p_Value), p_field2, DataConverter.GetSQLString(p_Value2), p_keyField, p_key)
        Return CheckDuplicatedValueDB(strFilter)
    End Function

    Private Function CheckDuplicatedValueDB(ByVal p_strFilter As String) As Boolean
        Dim strQuery As String = String.Format("SELECT TOP 1 {0} FROM dbo.{1} WITH (NOLOCK) WHERE {2}", KeyField, TableName, p_strFilter)
        Dim result As Object = DBProc.ExecuteScalar(strQuery)
        Return result IsNot Nothing
    End Function

#End Region

    Public Function GetValue(obj As Object, ByVal keyFieldName As String) As Object
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList()
        Dim pc As Reflection.PropertyInfo

        pc = pClass.Find(Function(a) a.Name = keyFieldName)
        If pc IsNot Nothing Then
            Return pc.GetValue(obj, pc.GetIndexParameters)
        End If
        Return Nothing
    End Function

    Public Sub SetFieldValue(ByVal keyFieldName As String, ByVal p_value As Object)
        Dim pClass As List(Of Reflection.PropertyInfo) = Me.GetProperties().ToList()
        Dim pc As Reflection.PropertyInfo = pClass.Find(Function(a) a.Name = keyFieldName)
        If pc IsNot Nothing Then
            pc.SetValue(Me, p_value, Nothing)
        End If
    End Sub

    Public Overridable Sub UpdateReferenceID(ByVal p_oldValue As Integer, ByVal p_newValue As Integer)
        RaiseEvent NewRowInserted(p_oldValue, p_newValue)
    End Sub

    Protected Sub RaiseEventNewRowInserted(ByVal p_oldValue As Integer, ByVal p_newValue As Integer)
        RaiseEvent NewRowInserted(p_oldValue, p_newValue)
    End Sub

    Public Function GetRowStatus(ByVal p_keyID As Integer) As DataRowState
        Dim row As DataRow = DataSource.Rows.Find(p_keyID)
        If row Is Nothing Then
            Return DataRowState.Unchanged
        End If
        Return row.RowState
    End Function

    Public Function GetIDByCode(ByVal p_code As String, ByVal p_codeValue As String) As Integer
        Dim selectrows As DataRow() = DataSource.Select(String.Format("{0} = '{1}'", p_code, p_codeValue))
        If selectrows.Length > 0 Then
            Return CInt(selectrows(0)(KeyField))
        End If
        Return 0
    End Function

End Class
