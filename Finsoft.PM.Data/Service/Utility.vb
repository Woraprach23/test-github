Public Class Utility

    Public Shared Property MaxDate As Date = System.Data.SqlTypes.SqlDateTime.MaxValue
    Public Shared Property MinDate As Date = System.Data.SqlTypes.SqlDateTime.MinValue

    Public Shared Function MaxDateText() As String
        Return String.Empty
    End Function

    Public Shared Function ServerDate() As DateTime
        Dim datetime As DateTime = DBProc.ServerDate
        Return datetime
    End Function

    Public Shared Function ServerDateText() As String
        Dim datetime As DateTime = ServerDate()
        Return GetDateText(datetime)
    End Function

    Public Shared Function GetDateText(ByVal p_date As Date) As String
        If (p_date = MaxDate) Then
            Return String.Empty
        End If
        Return p_date.ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
    End Function

    Public Shared Function GetServerDateTextEN(ByVal p_FormatString As String) As String
        Dim datetime As DateTime = ServerDate()
        Return datetime.ToString(p_FormatString, New System.Globalization.CultureInfo("en-US"))
    End Function

    Public Shared Function GetServerDateTextTH(ByVal p_FormatString As String) As String
        Dim datetime As DateTime = ServerDate()
        If datetime.Year < 2400 Then
            datetime = datetime.AddYears(543)
        End If
        Dim str As String = datetime.Year.ToString '.ToString(p_FormatString, New System.Globalization.CultureInfo("th-TH"))
        Return str
    End Function


    'Public Shared Function GetNextTradeDate(ByVal p_FundID As Integer, ByVal p_chanel As String, ByVal p_transaction As String) As Date
    '    Return GetNextTradeDate(p_FundID, p_chanel, p_transaction, DateTime.MinValue)
    'End Function

    'Public Shared Function GetNextTradeDate(ByVal p_FundID As Integer, ByVal p_chanel As String, ByVal p_transaction As String, ByVal p_Date As Date) As Date
    '    Dim value As Object = DBProc.ExecuteScalarByProc_Params("dbo.TradeDate_GetNextTradeDate", {New SqlClient.SqlParameter("@FundID", p_FundID), _
    '                                                                                               New SqlClient.SqlParameter("@Chanel", p_chanel), _
    '                                                                                               New SqlClient.SqlParameter("@Date", IIf(p_Date <= DateTime.MinValue, DBNull.Value, p_Date)), _
    '                                                                                               New SqlClient.SqlParameter("@TransactionType", p_transaction)})
    '    If value IsNot Nothing And Not IsDBNull(value) Then
    '        Return CDate(value)
    '    End If

    '    Return DateTime.MinValue
    'End Function

    'Public Shared Function GetCurrentTradeDate(ByVal p_FundID As Integer) As Date
    '    Return GetCurrentTradeDate(p_FundID, 0, "PVD", "Contribution")
    'End Function

    'Public Shared Function GetCurrentTradeDate(ByVal p_FundID As Integer, ByVal p_companyID As Integer) As Date
    '    Return GetCurrentTradeDate(p_FundID, p_companyID, "PVD", "Contribution")
    'End Function

    'Public Shared Function GetCurrentTradeDate(ByVal p_FundID As Integer, ByVal p_companyID As Integer, ByVal p_chanel As String, ByVal p_transaction As String) As Date
    '    Dim value As Object = DBProc.ExecuteScalarByProc_Params("dbo.[Balance_GetCurrentTradeDate]", {New SqlClient.SqlParameter("@FundID", p_FundID), _
    '                                                                                                  New SqlClient.SqlParameter("@CompanyID", IIf(p_companyID > 0, p_companyID, DBNull.Value)), _
    '                                                                                               New SqlClient.SqlParameter("@Channel", p_chanel), _
    '                                                                                               New SqlClient.SqlParameter("@TransactionType", p_transaction)})
    '    If value IsNot Nothing And Not IsDBNull(value) Then
    '        Return CDate(value)
    '    End If

    '    Return DateTime.MinValue
    'End Function

    'Public Shared Function GetAuditGroupByTableName(ByVal p_tableName As String) As String
    '    Select Case p_tableName
    '        Case Fund.c_TableName, Board.c_TableName,
    '            Company.c_TableName, CompanyRule.c_TableName, CompanyFundRule.c_TableName, CompanyEmployedType.c_TableName, Company_Interface.c_TableName, CompanyInvestmentPlan.c_TableName, CompanyInvestmentPlanPolicy.c_TableName, CompanyReallocateRebalance.c_TableName, CompanyRule.c_TableName, CompanyRuleSalaryPaymentCalendar.c_TableName, CompanyContactPerson.c_TableName,
    '            CompanyFund.c_TableName, CompanyFundRule.c_TableName, CompanyFundRuleVesting.c_TableName, CompanyFundRuleVestingTable.c_TableName,
    '            Member.c_TableName, MemberFund.c_TableName, Beneficiary.c_TableName, MemberInvestmentPlan.c_TableName
    '            Return "Profile"
    '        Case Payment.c_TableName, Balance.c_TableName, NAV.c_TableName, ImportBatch.c_TableName, ImportContribution.c_TableName, ImportContributionError.c_TableName, TransferEmployer.c_TableName, TransferEmployer.c_TableName, TransferIN.c_TableName
    '            Return "Transaction"
    '        Case LoginUser.c_TableName, UserGroup.c_TableName, UserInterface.c_TableName, UIPermission.c_TableName, InternetUser.c_TableName, InternetUserCompany.c_TableName
    '            Return "Users"
    '    End Select


    '    Return String.Empty
    'End Function
End Class

