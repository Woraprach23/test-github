Imports System.ComponentModel
Imports System.IO
Imports Finsoft.PM.Common

Public Class CAAttachFileForm
    'Private _bindingSource As BindingSource
    'Private _file As Data.Files
    '<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    'Public Property CurrentFile As Data.Files
    '    Get
    '        If (_file Is Nothing) Then
    '            If (KeyID > 0) Then
    '                _file = New Data.Files(KeyID)
    '            Else
    '                _file = New Data.Files
    '            End If
    '        End If
    '        If (_masterFile Is Nothing) Then
    '            _masterFile = _file
    '        End If
    '        Return _file
    '    End Get
    '    Set(value As Data.Files)
    '        _file = value
    '    End Set
    'End Property
    Public Property ReferenceID As Integer
    Public Property ReferenceType As AppEnums.DocType = AppEnums.DocType.None
    Public Property DocumentType As AppEnums.DocType = AppEnums.DocType.None
    Public Property FixDocumentType As Boolean = False

    Private _fileList As List(Of Data.File)
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentFileList As List(Of Data.File)
        Get
            If (_fileList Is Nothing) Then
                _fileList = New List(Of Data.File)
            End If
            Return _fileList
        End Get
        Set(value As List(Of Data.File))
            _fileList = value
        End Set
    End Property

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Protected Overrides Sub AdditionalIntialize()
        'MyBase.AdditionalIntialize()
        If (EditMode = AppEnums.EditMode.Add) Then
            btnView.Enabled = False
            btnSave.Enabled = False
        End If

        Me.Text += " - " + EditMode.ToString

    End Sub
    Protected Overrides Sub SetControlValidation()

        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl1)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        SetValidateRequiredField(lueDocType)
    End Sub

    Protected Overrides Sub BindingControls()
        lueDocType.EditValue = CInt(DocumentType)
        lueDocType.Properties.ReadOnly = FixDocumentType
    End Sub
     
    Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
        Dim Doctype As New Data.Doctype
        Doctype.LoadDataSource()
        Return Doctype.DataSource
    End Function
     
    Protected Overrides Sub LoadControlCompleted(p_Result As Object)
        LookupManager.LoadLookUpEdit(lueDocType, TryCast(p_Result, DataTable), "DoctypeID", "Doctype", False, 0, String.Empty)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Browse()
        Catch ex As Exception
            MessageManager.ProcessError(sender, ex, False, ex.Message, "Browse File", 0)
        End Try
    End Sub
     
    Private Sub Browse()
        Dim filter = Data.ConfigService.GetConfig(Data.DataEnums.ConfigGroup.FileConfig, Data.DataEnums.FileConfig.AttachFileFilter)
        Dim dlg As New OpenFileDialog()
        dlg.Title = "Selected File Dialog"
        dlg.InitialDirectory = "D:\"
        dlg.Filter = filter.ConfigDisplayText
        dlg.FilterIndex = 2
        dlg.RestoreDirectory = True
        dlg.Multiselect = True
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return

        End If

        '*** Save File
        CurrentFileList = Nothing
        For Each FileName In dlg.FileNames
            Dim file = LoadFiles(FileName)
            CurrentFileList.Add(file)
        Next

        btnSave.Enabled = True
        Dim arrFileName = CurrentFileList.Select(Function(a) a.FileName).ToArray
        txtFileName.Text = String.Join(vbNewLine, arrFileName)
 
    End Sub

    Private Function LoadFiles(ByVal p_path As String) As Data.File
        Dim file = New Data.File
        file.FileName = Path.GetFileName(p_path)
        file.Extension = Path.GetExtension(p_path) 
        Dim fInfo As New FileInfo(p_path)
        file.FileSize = Math.Round(fInfo.Length / 1024)
        Dim numBytes As Long = fInfo.Length
        Dim fs As New FileStream(p_path, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(fs)
        Dim bytes As Byte() = br.ReadBytes(CInt(numBytes))
        file.FileData = bytes

        Return file
    End Function
     
    Protected Overrides Function ProcessSave() As Boolean
        Dim docType As Integer = CInt(lueDocType.EditValue)
        For Each File In CurrentFileList
            File.ReferenceID = ReferenceID
            File.ReferenceTypeID = ReferenceType
            File.DocTypeID = docType

            If (ReferenceID > 0) Then
                File.CreatedBy = ApplicationMeta.LoginUserID
                File.DBInsertUpdate()
            End If
        Next
        Return True
         
    End Function
     
End Class
