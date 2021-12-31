Public Class DataEnums
    Public Enum ConfigGroup As Integer
        [None] = 0
        ContactType = 6
        EditMode = 4
        FileConfig = 7
        'FileReferenceType = 8
        LogType = 2
        MessageCode = 3
        UiPermissionTypes = 1
        UiType = 5
        ReportType = 10
    End Enum

    Public Enum FileConfig As Integer
        AttachFileMaxSize = 1
        AttachFileFilter = 2
    End Enum

    Public Enum MessageCode As Integer
        M001 = 1 'Would you like to export?
        M002 = 2 'Would you like to save?
        M003 = 3 'Would you like to delete ?
        M004 = 4 'Would you like to cancel?
        M005 = 5 'Would you like to confirm
        M006 = 6 '(Conflic) The current status has already been changed.
        M007 = 7 'Please fill in required fields
        M008 = 8 'An error has occurred
        M009 = 9 'Please select at least 1 row.
        M0010 = 10 '{0} is not valid
        M0011 = 11 'No data was changed.
        M0012 = 12 '{0} successfully.
        M0013 = 13 'Failed to {0}. {1}
        M0014 = 14 'Please correct Error before continue
        M0015 = 15 'Data is duplicated.
        M0016 = 16 'The file size exceeds the limit allowed ({0}mb) and cannot be saved.
    End Enum

    'Public Enum FileReferenceType As Integer
    '    FSD = 1 'FSD
    '    CR = 2 'CR
    '    Invoice = 3 'Invoice
    '    Contract = 4 'Contract
    'End Enum

    Public Enum DocType As Integer
        FSD = 1
        Contract = 2
        Quatation = 3
        Invoice = 4
        Receipt = 5
        BRD = 6
        Others = 7
        ProductSpec = 10
        Companyprofile = 12
        Statementofwork = 13
        PO = 14
        CR = 15
        Job = 16
    End Enum
End Class
