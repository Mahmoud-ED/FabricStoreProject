Module MdlVariable

    Public Settings As New ClassSettings

    Public UserID, EmployeReportID, CustomerReportID, SuppleirReportID, MangExpensesID, TailorReportID, DeliveryReportID, SalaryYear, SalaryMonth As Integer

    Public UserName, UserPassword, UserJob, UpdateP, UserControlP, SettingP As String
    Public EmployeeID, DoctorID, PettyID, EmployeeInfoID, MainSafeID, InsuranceCompanyID As Integer
    Public MaxDisc As Double
    Public Title As String = "نظام لإدارة متجر أقمشة وملابس جاهزة"

    Public SQLQuery, SQLQuery2 As String
    Public Save As Integer = -1
    Public Pos As Point
    Public SW, SelectAllText As Boolean

    'Public EmployeID As Integer

    Public IsSelectSourceOpen As Boolean
    Public NewLocation As String
    Public MainActive As Boolean
    Public LogOut As Boolean
    Public DTUserPermission As DataTable
    Public Permission As Boolean
    '---------------------------Management-----------------------------------
    Public IsDataMissing As Boolean
    Public AssetsID As Integer
    '--------------------------Reception----------------------------------------

    Public PID, PIDInsur, PIDNotInsur As Integer ' PatientID
    Public InsuranceCompanyContractID, InsuranceEntityContractID As Integer
    Public NewSession, SessionID As Integer
    Public ExpensesDoctorID, ClinkExpensesID As Integer
    Public TreatmentID As Integer
    Public CashingMonth, CashingYear As Integer
    Public CenterLogoPath As String

    '--------------------------End---Reception------------------------------

    '------------------------------------------------------------
    Enum InputType
        TextBox
        Label
    End Enum

    Public InputObject As Object 'The control i want to write in it usually it's a TextBox
    '-------------------------------------------------------------
    Public RedColor As Color = Color.FromArgb(255, 235, 235) 'R
    Public GreenColor As Color = Color.FromArgb(216, 245, 255) 'G
    Public YellowColor As Color = Color.FromArgb(255, 255, 196) 'Y
    Public Gray As Color = Color.FromArgb(247, 247, 247) 'Y

End Module
