Public  Class ClassSettings

    Public Enum Setting
        Server
        Database
        SQLLogin
        SQLPassword
        AdminUser
        AdminPassword
        SharePath
        SafePath
        Scanner
        PanelColor
        ActiveColor
        BackupClosing
        AutoBackupName
        AutoBackupPath
        BackupName
        BackupPath
        BackupMaxDays
        BackupMaxCount
        SenderName
        SenderPhone
        EmailSender
        EmailPass
        MaxDiscountPercent
        StartReciptID
        StartCashID
        CompanyLogo
        CompanyArabicName
        CompanyEnglishName
        CompanyPhone1
        CompanyPhone2
        CompanyPhone3
        CompanyEmail
        CompanyCityID
        CompanyCityName
        CompanyCity
        CompanyAddress
        SelectedUser
        ServiceLang
        SystemColors
        DataBaseID
        ColorDark
        ColorPrimary
        ColorLight
        Startup
        DateFormat
        TimeFormat
        CenterLogoPath
    End Enum

    Public Shadows Function GetSettings(S As Setting) As Object

        Select Case S
            Case Setting.Server
                Return My.Settings.Server
            Case Setting.Database
                Return My.Settings.Database
            Case Setting.SQLLogin
                Return My.Settings.SQLLogin
            Case Setting.SQLPassword
                Return My.Settings.SQLPassword
            Case Setting.AdminUser
                Return My.Settings.AdminUser
            Case Setting.AdminPassword
                Return My.Settings.AdminPassword

            Case Setting.PanelColor
                Return My.Settings.PanelColor
            Case Setting.ActiveColor
                Return My.Settings.ActiveColor
            Case Setting.BackupClosing
                Return My.Settings.BackupClosing
            Case Setting.AutoBackupName
                Return My.Settings.AutoBackupName
            Case Setting.AutoBackupPath
                Return My.Settings.AutoBackupPath
            Case Setting.BackupPath
                Return My.Settings.BackupPath

            Case Setting.BackupMaxDays
                Return My.Settings.BackupMaxDays

            Case Setting.MaxDiscountPercent
                Return 50
            Case Setting.StartReciptID
                Return My.Settings.StartReciptID
            Case Setting.StartCashID
                Return My.Settings.StartCashID
            Case Setting.CompanyLogo
                Return My.Settings.CompanyLogo
            Case Setting.CompanyArabicName
                Return My.Settings.CompanyArabicName
            Case Setting.CompanyEnglishName
                Return My.Settings.CompanyEnglishName
            Case Setting.CompanyPhone1
                Return My.Settings.CompanyPhone1
            Case Setting.CompanyPhone2
                Return My.Settings.CompanyPhone2

            Case Setting.CompanyEmail
                Return My.Settings.CompanyEmail
            Case Setting.CompanyAddress
                Return My.Settings.CompanyAddress

            Case Setting.SelectedUser
                Return My.Settings.SelectedUser

            Case Setting.SystemColors
                Return My.Settings.SystemColors

            Case Setting.ColorDark
                Return My.Settings.ColorDark
            Case Setting.ColorPrimary
                Return My.Settings.ColorPrimary
            Case Setting.ColorLight
                Return My.Settings.ColorLight
            Case Setting.Startup
                Return My.Settings.Startup
            Case Setting.DateFormat
                Return My.Settings.DateFormat
            Case Setting.TimeFormat
                Return My.Settings.TimeFormat


        End Select

    End Function


    Public Shadows Sub SaveSettings(Value As Object, S As Setting)

        Select Case S
            Case Setting.Server
                My.Settings.Server = Value
            Case Setting.Database
                My.Settings.Database = Value
            Case Setting.SQLLogin
                My.Settings.SQLLogin = Value
            Case Setting.SQLPassword
                My.Settings.SQLPassword = Value
            Case Setting.AdminUser
                My.Settings.AdminUser = Value
            Case Setting.AdminPassword
                My.Settings.AdminPassword = Value

            Case Setting.SelectedUser
                My.Settings.SelectedUser = Value
            Case Setting.PanelColor
                My.Settings.PanelColor = Value
            Case Setting.ActiveColor
                My.Settings.ActiveColor = Value
            Case Setting.BackupClosing
                My.Settings.BackupClosing = Value
            Case Setting.AutoBackupName
                My.Settings.AutoBackupName = Value
            Case Setting.AutoBackupPath
                My.Settings.AutoBackupPath = Value
            Case Setting.BackupPath
                My.Settings.BackupPath = Value

            Case Setting.BackupMaxDays
                My.Settings.BackupMaxDays = Value


            Case Setting.StartReciptID
                My.Settings.StartReciptID = Value
            Case Setting.StartCashID
                My.Settings.StartCashID = Value
            Case Setting.CompanyLogo
                My.Settings.CompanyLogo = Value
            Case Setting.CompanyArabicName
                My.Settings.CompanyArabicName = Value
            Case Setting.CompanyEnglishName
                My.Settings.CompanyEnglishName = Value
            Case Setting.CompanyPhone1
                My.Settings.CompanyPhone1 = Value
            Case Setting.CompanyPhone2
                My.Settings.CompanyPhone2 = Value

            Case Setting.CompanyEmail
                My.Settings.CompanyEmail = Value
            Case Setting.CompanyAddress
                My.Settings.CompanyAddress = Value

            Case Setting.SystemColors
                My.Settings.SystemColors = Value

            Case Setting.ColorDark
                My.Settings.ColorDark = Value
            Case Setting.ColorPrimary
                My.Settings.ColorPrimary = Value
            Case Setting.ColorLight
                My.Settings.ColorLight = Value
            Case Setting.Startup
                My.Settings.Startup = Value
            Case Setting.DateFormat
                My.Settings.DateFormat = Value
            Case Setting.TimeFormat
                My.Settings.TimeFormat = Value

        End Select

        My.Settings.Save()

    End Sub

End Class
