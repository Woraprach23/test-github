Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections
'Imports System.Xml
Imports System.IO

Public Class ReportLayoutForm

#Region "Members"

    Private _bindingSource As BindingSource
    Private _template As Data.ReportLayout

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentClient As Data.ReportLayout
        Get
            If (_template Is Nothing) Then
                If (KeyID > 0) Then
                    _template = New Data.ReportLayout(KeyID)
                Else
                    _template = New Data.ReportLayout
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _template
            End If
            Return _template
        End Get
        Set(value As Data.ReportLayout)
            _template = value
        End Set
    End Property

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region "Protected Overrides"
    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        controlValidate.SetRequiredFiledCaption(LabelControl3)
        controlValidate.SetRequiredFiledCaption(Label23)
        SetValidateRequiredField(txtReportCode)
        SetValidateRequiredField(txtReportName)
        SetValidateRequiredField(cboReportType)
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentClient

        txtReportCode.DataBindings.Add("EditValue", _bindingSource, "ReportCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtReportName.DataBindings.Add("EditValue", _bindingSource, "ReportName", True, DataSourceUpdateMode.OnPropertyChanged)
        cboReportType.DataBindings.Add("EditValue", _bindingSource, "ReportTypeID", True, DataSourceUpdateMode.OnPropertyChanged)
        memoRemark.DataBindings.Add("EditValue", _bindingSource, "Remark", True, DataSourceUpdateMode.OnPropertyChanged)
        chkActive.DataBindings.Add("EditValue", _bindingSource, "IsActive", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
        Return Data.ConfigService.Config(Data.DataEnums.ConfigGroup.ReportType)
    End Function

    Protected Overrides Sub LoadControlCompleted(p_Result As Object)
        LookupManager.LoadLookUpEditConfig(cboReportType, TryCast(p_Result, DataTable), False)
    End Sub

#End Region

#Region "Button Click Events"
    Private Sub btnEditLayout_Click(sender As Object, e As EventArgs) Handles btnEditLayout.Click
        If (ValidateControl()) Then
            Dim frm As New ReportDesignForm(Me.EditMode, CurrentClient)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnUploadXML_Click(sender As Object, e As EventArgs) Handles btnUploadXML.Click
        Try
            Dim upload As New OpenFileDialog()
            upload.Multiselect = False
            'upload.Filter = "XML File (*.xml)|.xml"
            If (upload.ShowDialog = Windows.Forms.DialogResult.OK) Then
                Dim xmlfilereader As StreamReader = New StreamReader(upload.FileName) 
                CurrentClient.XMLString = xmlfilereader.ReadToEnd
            End If
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, True, ex.Message, btnUploadXML.Text, 0)
        End Try
    End Sub

    Private Sub btnViewXML_Click(sender As Object, e As EventArgs) Handles btnViewXML.Click
        Try

        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, True, ex.Message, btnUploadXML.Text, 0)
        End Try
    End Sub

#End Region

    'dt1.TableName = "MyDataTable"
    'dt1.WriteXmlSchema(Application.StartupPath + "\test_sh.xml", True)
    'dt1.WriteXml(Application.StartupPath + "\test_dt.xml", True)

    'dt2 = New DataTable
    'dt2.ReadXmlSchema(Application.StartupPath + "\test_sh.xml")
    'dt2.ReadXml(Application.StartupPath + "\test_dt.xml")
End Class
