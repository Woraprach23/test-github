Public Class AppEnums
   
    Public Enum MenuCode As Integer
        None = 0
        Page1 = 1
        Master = 2
        Working = 3
        Client = 4
        Product = 5
        Doctype = 6
        CR = 8
        Quotation = 9
        FSD = 10
        Statementofwork = 11
        Invoice = 12
        Contract = 13
    End Enum


    Public Enum ConfigGroup As Integer
        [None] = 0
        UiPermissionTypes = 1
        LogType = 2
        MessageCode = 3
        EditMode = 4
    End Enum

    Public Enum EditMode As Integer
        View = 0
        Add = 1
        Edit = 2
        Clone = 3
    End Enum

    Public Enum UiPermissionTypes As Integer
        None = 0
        View = 1
        Edit = 2
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
        M0011 = 11 'No data was found.
        M0012 = 12 '{0} successfully.
        M0013 = 13 'Failed to {0}. {1}
        M0014 = 14 'Please correct Error before continue
        M0015 = 15 'Data is duplicated.
        M0016 = 16 'The file size exceeds the limit allowed ({0}mb) and cannot be saved.

        M0017 = 17 'Some CR item has already been assigned to another FSD No., Would you like to comfirm changing them to a new FSD?
        M0018 = 18 'Some CR item has already been assigned to another Job No., Would you like to comfirm changing them to a new job?
        M0019 = 19 'Cannot select muti-client or product
        M0020 = 20 'Cannot select client code more than 1
        M0021 = 21 'Some Job No. has already been assigned to another Quotation No. Would you like to confirm changing them to a new quotation?
        M0022 = 22 ' CR item is required 
        M0023 = 23 'Contract of this quotation has already been created. Would you like to view the contract?
    End Enum
     
    Public Enum LogType As Integer
        Access = 1
        Add = 2
        Edit = 3
        Delete = 4
        Export = 5
    End Enum
     
    Public Enum GridviewType As Integer
        None = 0
        EditForm = 1
        GridEdit = 2
    End Enum

    Public Enum ResultType As Integer
        Success = 1
        Waring = 2
        [Error] = 3
    End Enum


    'Public Enum ReferenceType As Integer
    '    None = 0
    '    Product = 1
    '    CR = 2
    '    FSD = 3
    '    Job = 4
    '    Invoice = 5
    '    Contract = 6
    'End Enum

    Public Enum DocType As Integer
        None = 0
        FSD = 1
        Contract = 2
        Quotation = 3
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

    Public Enum ContractType As Integer
        Main = 1
        [Sub] = 2
    End Enum
End Class
