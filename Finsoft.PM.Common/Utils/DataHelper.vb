Public Class DataHelper

    Public Shared Function CVBool(ByVal p_obj As Object) As Boolean
        If (p_obj Is DBNull.Value OrElse p_obj Is Nothing) Then
            Return False
        End If

        Return CBool(p_obj)
    End Function

    Public Shared Function CVInt(ByVal p_obj As Object) As Integer
        If (p_obj Is DBNull.Value OrElse p_obj Is Nothing) Then
            Return 0
        End If

        Try
            Return CInt(p_obj)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function CVDec(ByVal p_obj As Object) As Decimal
        If (p_obj Is DBNull.Value OrElse p_obj Is Nothing) Then
            Return 0
        End If
 
        Return CDec(p_obj)
    End Function

    Public Shared Function CVDate(ByVal p_obj As Object) As Date
        If (p_obj Is DBNull.Value OrElse p_obj Is Nothing) Then
            Return DateTime.MinValue
        End If

        Return CDate(p_obj)
    End Function

    Public Shared Function CVText(ByVal p_obj As Object) As String
        If (p_obj Is DBNull.Value OrElse p_obj Is Nothing) Then
            Return String.Empty
        End If

        Return CStr(p_obj)
    End Function

     

End Class
