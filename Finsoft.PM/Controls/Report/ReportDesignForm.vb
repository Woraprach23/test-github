Imports Finsoft.PM.Common

Public Class ReportDesignForm
    Dim LayoutID As Integer
    Dim Report As New DevExpress.XtraReports.UI.XtraReport
    Dim clsLayout As New Data.ReportLayout
    Private _dataSource As Object
    Private _editMode As AppEnums.EditMode = AppEnums.EditMode.View
    Public Sub New(ByVal p_editMode As AppEnums.EditMode, ByVal p_reportLayout As Data.ReportLayout)

        _editMode = p_editMode
        clsLayout = p_reportLayout

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReportDesignForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdditionalIntialize()
    End Sub

    Protected Sub AdditionalIntialize()
        Dim helper As New ReportHelper
        Report = helper.GetReport(clsLayout)

        Report.DataSource = clsLayout.GetReportDataReport
        RibbonPageToolbox.Visible = False
        RibbonPageHTML.Visible = False


        ReportDesigner1.OpenReport(Report)

        If _editMode = Common.AppEnums.EditMode.View Then
            RibbonPagePreview1.Visible = False
            RibbonControl1.SelectedPage = RibbonPagePreview1
        End If

        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFile, DevExpress.XtraReports.UserDesigner.CommandVisibility.All)
        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFileAs, DevExpress.XtraReports.UserDesigner.CommandVisibility.None)
        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.SaveAll, DevExpress.XtraReports.UserDesigner.CommandVisibility.None)
        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.OpenFile, DevExpress.XtraReports.UserDesigner.CommandVisibility.All)
        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.NewReport, DevExpress.XtraReports.UserDesigner.CommandVisibility.None)
        ReportDesigner1.ActiveDesignPanel.SetCommandVisibility(DevExpress.XtraReports.UserDesigner.ReportCommand.AddNewDataSource, DevExpress.XtraReports.UserDesigner.CommandVisibility.None)
        ReportDesigner1.ActiveDesignPanel.AddCommandHandler(New DesignerClosingCommandHandler)

    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (ReportDesigner1.ActiveDesignPanel Is Nothing) Then
            Return
        End If

        If ReportDesigner1.ActiveDesignPanel.ReportState = DevExpress.XtraReports.UserDesigner.ReportState.Changed Then
            If MessageBox.Show("Do want to save current layout?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                SaveLayout()
            End If
        End If
        ReportDesigner1.ActiveDesignPanel.ReportState = DevExpress.XtraReports.UserDesigner.ReportState.Saved
    End Sub

    Private Sub SaveLayout()
        Dim ios As New System.IO.MemoryStream
        Report.SaveLayout(ios)
        Dim savebyte As Byte() = ios.ToArray
        clsLayout.Layout = savebyte

        ReportDesigner1.ActiveDesignPanel.ReportState = DevExpress.XtraReports.UserDesigner.ReportState.Saved
    End Sub


End Class