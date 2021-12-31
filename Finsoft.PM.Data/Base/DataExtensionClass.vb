'Imports Volunteer.Common

<HideModuleName()> _
Module DataExtensionClass

    '<System.Runtime.CompilerServices.Extension()> _
    'Public Function DataTableToList(Of T As {Class, New})(table As DataTable) As List(Of T)
    '    Try
    '        Dim list As New List(Of T)()

    '        For Each row As Object In table.AsEnumerable()
    '            Dim obj As New T()

    '            For Each prop As Object In obj.[GetType]().GetProperties()
    '                Try
    '                    Dim propertyInfo As Reflection.PropertyInfo = obj.[GetType]().GetProperty(prop.Name)
    '                    propertyInfo.SetValue(obj, Convert.ChangeType(row(prop.Name), propertyInfo.PropertyType), Nothing)
    '                Catch
    '                    Continue For
    '                End Try
    '            Next

    '            list.Add(obj)
    '        Next

    '        Return list
    '    Catch
    '        Return Nothing
    '    End Try
    'End Function

    ''<System.Runtime.CompilerServices.Extension()> _
    ''Public Function ConvertTo(Of T As New)(datatable As DataTable) As List(Of T)
    ''    Dim Temp As New List(Of T)()
    ''    Try
    ''        Dim columnsNames As New List(Of String)()
    ''        For Each DataColumn As DataColumn In datatable.Columns
    ''            columnsNames.Add(DataColumn.ColumnName)
    ''        Next
    ''        Temp = datatable.AsEnumerable().ToList().ConvertAll(Of T)(Function(row) getObject(Of T)(row, columnsNames))
    ''        Return Temp
    ''    Catch
    ''        Return Temp
    ''    End Try
    ''End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function CreateNewInstant(Of T)(p_obj As Object) As T
        Dim tClass As Type = p_obj.GetType()
        Dim cn As T
        cn = DirectCast(Activator.CreateInstance(tClass), T)
        Return cn
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToList(Of T)(dt As DataTable) As List(Of T)
        Dim lst As List(Of T) = New System.Collections.Generic.List(Of T)()
        Dim tClass As Type = GetType(T)
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList
        Dim pc As Reflection.PropertyInfo

        Dim cn As T
        For Each row As DataRow In dt.Rows
            cn = DirectCast(Activator.CreateInstance(tClass), T)
            For Each col As DataColumn In dt.Columns
                pc = pClass.Find(Function(o) o.Name = col.ColumnName)
                If pc IsNot Nothing Then
                    If Not (IsDBNull(row(col.ColumnName)) OrElse row(col.ColumnName) Is Nothing) Then
                        pc.SetValue(cn, cvDBNull(row(col.ColumnName)), Nothing)
                    End If
                End If
            Next
            pc = pClass.Find(Function(o) o.Name = "IsPropertiesChanged")
            If pc IsNot Nothing Then
                pc.SetValue(cn, False, Nothing)
            End If

            lst.Add(cn)
        Next
        Return lst
    End Function
 
    <System.Runtime.CompilerServices.Extension()> _
    Public Sub DataRowToCollection(row As DataRow, obj As Object)
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList
        Dim pc As Reflection.PropertyInfo
        Dim columName As String = String.Empty
        For Each col As DataColumn In row.Table.Columns
            columName = col.ColumnName
            pc = pClass.Find(Function(o) o.Name = columName)
            If pc IsNot Nothing Then
                pc.SetValue(obj, cvDBNull(row(pc.Name)), Nothing)
            End If
        Next
    End Sub


    <System.Runtime.CompilerServices.Extension()> _
    Public Sub LoadValueFromInstant(row As DataRow, obj As MasterFile)
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList
        Dim pc As Reflection.PropertyInfo
        Dim columName As String = String.Empty
        For Each col As DataColumn In row.Table.Columns
            columName = col.ColumnName
            If obj.KeyField = columName Then
                Continue For
            End If
            pc = pClass.Find(Function(o) o.Name = columName)
            If pc IsNot Nothing Then
                row(columName) = pc.GetValue(obj, pc.GetIndexParameters)
                'pc.SetValue(obj, cvDBNull(row(pc.Name)), Nothing)
            End If
        Next
    End Sub

    '<System.Runtime.CompilerServices.Extension()> _
    'Public Function ToList(dt As DataTable, ByVal p_class As BaseEntity) As Object

    '    'Dim lst As List(Of MasterBase) = New System.Collections.Generic.List(Of MasterBase)()
    '    Dim array(dt.Rows.Count - 1) 'As MasterBase
    '    Dim pClass As List(Of Reflection.PropertyInfo) = p_Type.GetProperties().ToList
    '    Dim pc As Reflection.PropertyInfo
    '    Dim i As Integer = 0
    '    Dim cn
    '    For Each row As DataRow In dt.Rows
    '        cn = Activator.CreateInstance(p_Type)
    '        For Each col As DataColumn In dt.Columns
    '            pc = pClass.Find(Function(o) o.Name = col.ColumnName)
    '            If pc IsNot Nothing Then
    '                pc.SetValue(cn, cvDBNull(row(col.ColumnName)), Nothing)
    '            End If
    '        Next
    '        array(i) = cn
    '        i += 1
    '        'lst.Add(cn)
    '    Next
    '    Return array.ToList
    'End Function

    '<System.Runtime.CompilerServices.Extension()> _
    'Public Function ToArray(dt As DataTable, ByVal p_Type As Type) As Object

    '    'Dim lst = New System.Collections.Generic.List(Of p_Type)()

    '    Dim array(dt.Rows.Count - 1)
    '    Dim pClass As List(Of Reflection.PropertyInfo) = p_Type.GetProperties().ToList
    '    Dim pc As Reflection.PropertyInfo
    '    Dim i As Integer = 0
    '    Dim cn
    '    Dim colName As String = String.Empty
    '    For Each row As DataRow In dt.Rows
    '        cn = Activator.CreateInstance(p_Type)
    '        For Each col As DataColumn In dt.Columns
    '            colName = col.ColumnName
    '            pc = pClass.Find(Function(o) o.Name = colName)
    '            If pc IsNot Nothing Then
    '                pc.SetValue(cn, cvDBNull(row(col.ColumnName)), Nothing)
    '            End If
    '        Next
    '        array(i) = cn
    '        i += 1
    '        'lst.Add(cn)
    '    Next
    '    Return array
    'End Function


    <System.Runtime.CompilerServices.Extension()> _
    Public Sub ToCollection(row As DataRow, obj As Object)
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList
        Dim pc As Reflection.PropertyInfo
        Dim colName As String = String.Empty
        For Each col As DataColumn In row.Table.Columns
            colName = col.ColumnName
            pc = pClass.Find(Function(o) o.Name = colName)
            If pc IsNot Nothing Then
                If (Not (IsDBNull(row(pc.Name)) OrElse row(pc.Name) Is Nothing)) Then
                    pc.SetValue(obj, cvDBNull(row(pc.Name)), Nothing)
                End If
            End If
        Next
    End Sub

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub ToProperties(sdr As SqlClient.SqlDataReader, obj As Object)

        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList()
        Dim index As Integer = sdr.FieldCount
        Dim pc As Reflection.PropertyInfo
        Dim i As Integer

        For i = 0 To index - 1
            Try
                Dim name As String = sdr.GetName(i)
                pc = pClass.Find(Function(a) a.Name = sdr.GetName(i))
                If pc IsNot Nothing Then
                    If Not (IsDBNull(sdr.GetValue(i))) Then
                        pc.SetValue(obj, cvDBNull(sdr.GetValue(i)), Nothing)
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    '<System.Runtime.CompilerServices.Extension()> _
    'Public Function ToList(dt As DataTable, ByVal p_class As MasterFile) As List(Of MasterFile)
    '    Dim lst As List(Of MasterFile) = New System.Collections.Generic.List(Of MasterFile)()
    '    'Dim array(dt.Rows.Count - 1) 'As MasterBase
    '    Dim pClass As List(Of Reflection.PropertyInfo) = p_class.GetProperties().ToList
    '    Dim pc As Reflection.PropertyInfo
    '    Dim i As Integer = 0

    '    Dim cn As MasterFile
    '    For Each row As DataRow In dt.Rows
    '        cn = Activator.CreateInstance(p_class.GetType())
    '        For Each col As DataColumn In dt.Columns
    '            Dim colName As String = col.ColumnName
    '            pc = pClass.Find(Function(o) o.Name = colName)
    '            If pc IsNot Nothing Then
    '                pc.SetValue(cn, cvDBNull(row(colName)), Nothing)
    '            End If
    '        Next
    '        'array(i) = cn
    '        i += 1
    '        lst.Add(cn)
    '    Next
    '    Return lst
    'End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub ToProperties(row As DataRow, obj As Object)
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList
        Dim pc As Reflection.PropertyInfo
        Dim colName As String

        For Each col As DataColumn In row.Table.Columns
            colName = col.ColumnName
            pc = pClass.Find(Function(x) x.Name = colName)
            If (pc IsNot Nothing) Then
                pc.SetValue(obj, cvDBNull(row(pc.Name)), Nothing)
            End If
        Next
    End Sub

    <System.Runtime.CompilerServices.Extension()> _
    Public Function cvDBNull(p_Value As Object) As Object
        If (IsDBNull(p_Value)) Then
            Return Nothing
        End If
        Return p_Value
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function cvDBNull(p_Value As Object, ByVal p_defaultValue As Object) As Object
        If (IsDBNull(p_Value) Or p_Value Is Nothing) Then
            Return p_defaultValue
        End If
        Return p_Value
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub SetKeyValue(obj As Object, ByVal keyFieldName As String, ByVal keyValue As Object)
        Dim tClass As Type = obj.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList()
        Dim pc As Reflection.PropertyInfo

        pc = pClass.Find(Function(a) a.Name = keyFieldName)
        If pc IsNot Nothing Then
            pc.SetValue(obj, keyValue, Nothing)
        End If
    End Sub

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub SetParameters(cmd As SqlClient.SqlCommand, ByVal instance As Object)
        Dim tClass As Type = instance.GetType()
        Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList()
        Dim pc As Reflection.PropertyInfo
        Dim param As SqlClient.SqlParameter
        Dim paramName As String
        Dim fieldName As String
        Dim paramMode As String

        Dim dt As DataTable = DBProc.GetDataTableByProc_Params("dbo._GetProcParameters_List", {New SqlClient.SqlParameter("@PROC_NAME", cmd.CommandText.Replace("dbo.", String.Empty))})
        Try
            For Each row As System.Data.DataRow In dt.Rows
                paramName = row("PARAMETER_NAME")
                fieldName = paramName.Replace("@", String.Empty)
                paramMode = row("PARAMETER_MODE")
                pc = pClass.Find(Function(a) a.Name = fieldName)
                If pc IsNot Nothing Then
                    param = New SqlClient.SqlParameter()
                    param.ParameterName = paramName

                    Dim value As Object = pc.GetValue(instance, Nothing)

                    If pc.PropertyType.Name = "DateTime" Or pc.PropertyType.Name = "Date" And (value IsNot Nothing OrElse Not IsDBNull(value)) Then
                        Dim date1 As Date = CDate(value)
                        Dim minDate As Date = System.Data.SqlTypes.SqlDateTime.MinValue
                        Dim maxDate As Date = System.Data.SqlTypes.SqlDateTime.MaxValue
                        If date1.Date = DateTime.MinValue Or (date1.Date < minDate) Or date1.Date > maxDate Then
                            value = DBNull.Value
                            Continue For
                        End If
                    End If

                    param.Value = value

                    Dim paramtTYPE As String = row("DATA_TYPE")

                    If (paramtTYPE = "varchar") Then
                        Dim maxlenght As Integer = row("CHARACTER_MAXIMUM_LENGTH")
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
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    '<System.Runtime.CompilerServices.Extension()> _
    'Public Sub DictionaryToClass(data As System.Collections.Specialized.OrderedDictionary, obj As Object)
    '    Dim tClass As Type = obj.GetType()
    '    Dim pClass As List(Of Reflection.PropertyInfo) = tClass.GetProperties().ToList()
    '    Dim index As Integer = data.Count
    '    Dim pc As Reflection.PropertyInfo

    '    For Each key As String In data.Keys
    '        pc = pClass.Find(Function(a) a.Name = key)
    '        If pc IsNot Nothing Then
    '            pc.SetValue(obj, cvDBNull(data(key)), Nothing)
    '        End If
    '    Next
    'End Sub

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub CopyValues(objDestination As Object, objSource As Object, strReserveFieldName As String())
        Dim tClassDestination As Type = objDestination.GetType()
        Dim pClassDestination As List(Of Reflection.PropertyInfo) = tClassDestination.GetProperties().ToList()
        Dim pcDestination As Reflection.PropertyInfo

        Dim tClassSource As Type = objDestination.GetType()
        Dim pClassSource As List(Of Reflection.PropertyInfo) = tClassSource.GetProperties().ToList()
        Dim pcSource As Reflection.PropertyInfo


        Dim count As Integer = pClassDestination.Count
        Dim fieldName As String = String.Empty
        Dim value As Object = Nothing

        For index As Integer = 0 To count - 1

            pcDestination = pClassDestination(index)
            fieldName = pcDestination.Name

            If strReserveFieldName IsNot Nothing Then
                If strReserveFieldName.Contains(fieldName) Then
                    Continue For
                End If
            End If

            If TypeOf (objDestination) Is MasterFile Then
                If fieldName = TryCast(objDestination, MasterFile).ParentField OrElse _
                fieldName = TryCast(objDestination, MasterFile).KeyField Then
                    Continue For
                End If
            End If

            If fieldName = "PrimaryKeyID" OrElse _
                fieldName = "KeyField" OrElse _
                fieldName = "ParentField" OrElse _
                fieldName = "ParentID" OrElse _
                fieldName = "KeyID" OrElse _
                fieldName = "TableName" OrElse _
                fieldName = "CreatedBy" OrElse _
                fieldName = "CreatedDate" OrElse _
                fieldName = "LastUpdatedBy" OrElse _
                pcDestination.MemberType <> Reflection.MemberTypes.Property OrElse _
                fieldName.IndexOf("Current") >= 0 OrElse _
                fieldName = "DataSource" OrElse _
                fieldName = "IsPropertiesChanged" OrElse _
                fieldName = "LastUpdated" Then
                Continue For
            End If

            pcSource = pClassSource.Find(Function(a) a.Name = pcDestination.Name And a.PropertyType = pcDestination.PropertyType)
            If pcSource IsNot Nothing Then
                value = pcSource.GetValue(objSource, Nothing)
                pcDestination.SetValue(objDestination, value, Nothing)
            End If
        Next

    End Sub

End Module

