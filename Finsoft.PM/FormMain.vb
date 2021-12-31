Imports System.ComponentModel
Imports System.Text


Partial Public Class W
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ModuleInitialize.InitialAppSettings()

        If Not ModuleInitialize.TestConnectionString() Then
            Return
        End If
    End Sub

#Region "Private methods"
    Private Sub ShowMDIChildForm(ByVal p_form As FormViewMaster, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Common.ApplicationMeta.CurrentMenuCode = Common.RoleUiPermission.GetMenuCode(e.Item.Name)
        'Common.ApplicationMeta.PermissionType = Common.RoleUiPermission.GetPermission(e.Item.Name)
        p_form.MdiParent = Me
        p_form.Text = e.Item.Caption
        p_form.Show()
        XtraTabbedMdiManager1.Pages(XtraTabbedMdiManager1.Pages.Count - 1).Image = e.Item.Glyph
    End Sub


    'Private Sub ShowMDIChildForm(ByVal p_form As DevExpress.XtraEditors.XtraForm, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    Dim userinterfaceID = Common.RoleUiPermission.GetUserinterfaceID(e.Item.Name)
    '    Dim UiPermission = Common.RoleUiPermission.GetPermission(e.Item.Name)
    '    Common.ApplicationMeta.CurrentMenuCode = userinterfaceID
    '    Common.ApplicationMeta.PermissionType = UiPermission
    '    p_form.MdiParent = Me
    '    p_form.Text = e.Item.Caption
    '    p_form.Show()
    '    XtraTabbedMdiManager1.Pages(XtraTabbedMdiManager1.Pages.Count - 1).Image = e.Item.Glyph

    '    'ShowMDIChildForm(p_form, e.Item.Caption, e.Item.Glyph)
    'End Sub

    'Private Sub ShowMDIChildForm(ByVal p_form As Form, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    ShowMDIChildForm(p_form, e.Item.Caption, e.Item.Glyph)
    'End Sub

    'Private Sub ShowMDIChildForm(ByVal p_form As Form, ByVal p_caption As String, ByVal p_image As Image)
    '    p_form.MdiParent = Me
    '    p_form.Text = p_caption
    '    p_form.Show()
    '    XtraTabbedMdiManager1.Pages(XtraTabbedMdiManager1.Pages.Count - 1).Image = p_image
    'End Sub

    Private Function NotExitstForm(ByRef p_form As FormViewMaster) As Boolean
        Dim found As Boolean = False
        Try
            For Each frm As Form In Me.MdiChildren()
                If frm.Name = p_form.Name Then
                    frm.Focus()
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
        Return Not found
    End Function

    Public Function NotExitstForm(ByRef p_formName As String) As Boolean
        Dim found As Boolean = False
        Try
            For Each frm As Form In Me.MdiChildren()
                If frm.Name = p_formName Then
                    frm.Focus()
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
        Return Not found
    End Function

    Public Function ShowForm(ByRef p_form As Form, ByRef p_Text As String) As Boolean
        Dim found As Boolean = False
        For Each frm As Form In Me.MdiChildren()
            If frm.Name = p_form.Name AndAlso frm.Text = p_Text Then
                frm.Focus()
                found = True
                Exit For
            End If
        Next
        Return found
    End Function
#End Region


    Private Sub bbiClient_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClient.ItemClick
        If NotExitstForm(ClientFromView) Then
            ShowMDIChildForm(New ClientFromView, e)
        End If
    End Sub

    Private Sub bbiProduct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProduct.ItemClick
        If NotExitstForm(ProductFormView) Then
            ShowMDIChildForm(New ProductFormView, e)
        End If
    End Sub

    Private Sub bbiDoctype_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDoctype.ItemClick
        If NotExitstForm(DoctypeFormView) Then
            ShowMDIChildForm(New DoctypeFormView, e)
        End If
    End Sub

    Private Sub bbiCR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCR.ItemClick
        If NotExitstForm(CRFormView) Then
            ShowMDIChildForm(New CRFormView, e)
        End If
    End Sub

    Private Sub bbiJOB_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJOB.ItemClick
        If NotExitstForm(JobFormView) Then
            ShowMDIChildForm(New JobFormView, e)
        End If
    End Sub

    Private Sub bbiQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuotation.ItemClick
        If NotExitstForm(QuotationFormView) Then
            ShowMDIChildForm(New QuotationFormView, e)
        End If
    End Sub

    'Private Sub bbiInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFSD.ItemClick
    '    If NotExitstForm(InvoiceFormView) Then
    '        ShowMDIChildForm(New InvoiceFormView, e)
    '    End If
    'End Sub

    Private Sub bbiContract_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContract.ItemClick
        If NotExitstForm(ContractFormView) Then
            ShowMDIChildForm(New ContractFormView, e)
        End If
    End Sub

    Private Sub bbiUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUser.ItemClick
        If NotExitstForm(UserFromView) Then
            ShowMDIChildForm(New UserFromView, e)
        End If
    End Sub

    Private Sub bbiUserRole_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUserRole.ItemClick
        If NotExitstForm(UserRoleFromView) Then
            ShowMDIChildForm(New UserRoleFromView, e)
        End If
    End Sub

    Private Sub bbiConfig_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConfig.ItemClick
        If NotExitstForm(ConfigFormView) Then
            ShowMDIChildForm(New ConfigFormView, e)
        End If
    End Sub

    Private Sub bbiFSD_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFSD.ItemClick
        If NotExitstForm(FSDFormView) Then
            ShowMDIChildForm(New FSDFormView, e)
        End If
    End Sub

    Private Sub bbiReportLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReportLayout.ItemClick
        If NotExitstForm(ReportLayoutFormView) Then
            ShowMDIChildForm(New ReportLayoutFormView, e)
        End If
    End Sub
End Class
