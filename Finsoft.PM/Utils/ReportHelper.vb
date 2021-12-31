Imports DevExpress.XtraReports.UI

Public Class ReportHelper
    Public Function GetReport(ByVal p_cls As Data.ReportLayout) As XtraReport
        Dim report As New XtraReport
        Dim ios As System.IO.MemoryStream = Nothing
        If (p_cls.Layout IsNot Nothing) Then
            ios = New System.IO.MemoryStream(p_cls.Layout)
            report.LoadLayout(ios)
        End If


        report.DisplayName = p_cls.ReportName
        Return report
    End Function
End Class
