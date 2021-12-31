Public Class DesignerClosingCommandHandler
    Implements DevExpress.XtraReports.UserDesigner.ICommandHandler
      
    Public Function CanHandleCommand1(command As DevExpress.XtraReports.UserDesigner.ReportCommand, ByRef useNextHandler As Boolean) As Boolean Implements DevExpress.XtraReports.UserDesigner.ICommandHandler.CanHandleCommand
        If command = DevExpress.XtraReports.UserDesigner.ReportCommand.Closing Then
            useNextHandler = Not (command = DevExpress.XtraReports.UserDesigner.ReportCommand.Closing)
            Return Not useNextHandler
        End If
        Return False
    End Function

    Public Sub HandleCommand1(command As DevExpress.XtraReports.UserDesigner.ReportCommand, args() As Object) Implements DevExpress.XtraReports.UserDesigner.ICommandHandler.HandleCommand
        If command = DevExpress.XtraReports.UserDesigner.ReportCommand.Closing Then
            Dim eventArgs As DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs = args.OfType(Of DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs)().FirstOrDefault()
            If eventArgs IsNot Nothing Then eventArgs.Cancel = True
        End If

    End Sub

End Class
