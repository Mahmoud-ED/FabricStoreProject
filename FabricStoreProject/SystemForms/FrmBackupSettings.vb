Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TwainLib
Imports System.ComponentModel


Public Class FrmBackupSettings


    Private DSDataBases As New DataSet
    Private NewCon As Boolean = True
    Private IsDone As Boolean = True ' For changing colors
    Dim DTTimeFormat, DTDateFormat As New DataTable
    Private Cmd As SqlCommand
    Private swload As Boolean


    Private Sub FrmBackupSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        If UserID = 1 Then
            TxtAdminName.ReadOnly = False
            TxtAdminPass.ReadOnly = False
            TxtAdminPass.UseSystemPasswordChar = False
            TxtSqlPassword.UseSystemPasswordChar = False

        Else
            TxtAdminName.ReadOnly = True
            TxtAdminPass.ReadOnly = True
            TxtAdminPass.UseSystemPasswordChar = True
            TxtSqlPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FrmBackupSettings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetFillDataBases()
            ' إعدادات الإتصال
            Dim ServerName As String = Settings.GetSettings(ClassSettings.Setting.Server)
            'Dim DataBase As String = Settings.GetSettings(ClassSettings.Setting.Database)
            Dim SQLUserName As String = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
            Dim SQLPassword As String = Settings.GetSettings(ClassSettings.Setting.SQLPassword)
            TxtServerName.Text = ServerName
            TxtSQLUser.Text = SQLUserName
            TxtSqlPassword.Text = SQLPassword
            ' نسخة عند الاغلاق
            Dim CloseBackup As String = Settings.GetSettings(ClassSettings.Setting.BackupClosing)
            'If CloseBackup = True Then
            '    RadYes.Checked = True
            '    RadNo.Checked = False
            'ElseIf CloseBackup = False Then
            '    RadNo.Checked = True
            '    RadYes.Checked = False
            'End If
            swload = True
            'BtnTestCon.PerformClick()

        Else
            If Not IsNothing(DSDataBases) Then
                DSDataBases.Clear()
            End If

        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetFillDataBases()

        ' Get
        SQLQuery = "SELECT database_id, name FROM sys.databases WHERE database_id > 4 ORDER BY name"
        'SQLQuery &= " SELECT * From GeneralInfoTable"

        Dim SQLCon = New SQLConClass()
        DSDataBases = SQLCon.SelectData(SQLQuery)

        ' Fill
        If Not DSHasTables(DSDataBases) Then Exit Sub
        CmbDataBase.DataSource = DSDataBases.Tables(0)
        CmbDataBase.ValueMember = "database_id"
        CmbDataBase.DisplayMember = "name"

        ' Set DataBase
        Dim DBID As Integer = Settings.GetSettings(ClassSettings.Setting.DataBaseID)
        Dim DBName As String = Settings.GetSettings(ClassSettings.Setting.Database)
        If DBID = 0 Then
            CmbDataBase.Text = DBName
        Else
            CmbDataBase.SelectedValue = DBID
        End If

        'If DSDataBases.Tables(1).Rows.Count > 0 Then
        '    With DSDataBases.Tables(1).Rows(0)

        '        If Not IsDBNull(.Item("AdminUserName")) Then
        '            TxtAdminName.Text = .Item("AdminUserName")

        '        End If
        '        If Not IsDBNull(.Item("AdminUserPassword")) Then
        '            TxtAdminPass.Text = .Item("AdminUserPassword")
        '        End If
        '        LblPath.Text = .Item("BackUpPath").ToString
        '        TxtServerBackupName.Text = .Item("BackUpName").ToString
        '    End With
        'End If

    End Sub

    Private Sub Message(Txt As String, Style As Boolean)

        Dim FalseColor As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim TrueColor As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)

        LblConTestMessage.Text = Txt
        If Style = True Then
            LblConTestMessage.BackColor = Color.FromArgb(72, 210, 117)
            LblConTestMessage.ForeColor = Color.Black
        Else
            LblConTestMessage.BackColor = Color.FromArgb(255, 128, 128)
            LblConTestMessage.ForeColor = Color.White
        End If

    End Sub

    Private Sub BtnBackUpPath_Click(sender As Object, e As EventArgs)
        Dim DeskTopPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        If FBDBackUpPath.ShowDialog = DialogResult.OK Then
            If FBDBackUpPath.SelectedPath = "C:\" Or FBDBackUpPath.SelectedPath = DeskTopPath Then
                MsgBox("لا يمكن وضع النسخة الإحتياطية على القرص الصلب" & vbCrLf & "C:\" & vbCrLf & "مباشرة أو على سطح المكتب", vbExclamation, "تنبيه")
            Else
                TxtBackupPath.Text = FBDBackUpPath.SelectedPath
            End If
        End If
    End Sub

    Private Sub BtnAutoBackupPath_Click(sender As Object, e As EventArgs)
        If Not FBDAutoBackUpPath.ShowDialog = DialogResult.OK Then Exit Sub
        TxtAutoBackupPath.Text = FBDAutoBackUpPath.SelectedPath

    End Sub

    Private Sub BtnTestCon_Click(sender As Object, e As EventArgs) Handles BtnTestCon.Click
        If IsNothing(CmbDataBase.SelectedValue) Then
            MsgTool("يرجى اختيار قاعدة البيانات", 0)
            Exit Sub
        End If

        Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & TxtServerName.Text & ";Initial Catalog=master;Integrated Security=False;User ID=" & TxtSQLUser.Text & ";Password=" & TxtSqlPassword.Text & ";")
        Dim DA As SqlDataAdapter
        Dim DtTestCon As New DataTable

        Try
            SQLQuery = "SELECT * FROM sys.databases WHERE name = '" & CmbDataBase.Text.Trim & "'"
            DA = New SqlDataAdapter(SQLQuery, ConTest)
            DA.Fill(DtTestCon)

            If DtTestCon.Rows.Count = 0 Then
                Message("اسم قاعدة البيانات غير موجود", 0)
                MsgTool("اسم قاعدة البيانات غير موجود", 0)
                NewCon = False  ' Private NewCon As Boolean
            Else

                Message("الاتصال بالسيرفر فعال", 1)
                If swload = False Then
                    MsgTool("الاتصال بالسيرفر فعال", 1)
                End If
                swload = False
                NewCon = True
            End If

        Catch ex As Exception
            Message("بيانات الإتصال خاطئة", 0)
            NewCon = False
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel2)
        IsInputEmpty(GroupBox4)
        IsInputEmpty(TableLayoutPanel6)
        ' IsDataMissing = False
        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من كافة البيانات", 0)
            Exit Sub
        End If


        BtnTestCon.PerformClick()
        ' Get current connection data
        Dim ServerName As String = Settings.GetSettings(ClassSettings.Setting.Server)
        Dim DataBase As String = Settings.GetSettings(ClassSettings.Setting.Database)
        Dim SQLUserName As String = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
        Dim SQLPassword As String = Settings.GetSettings(ClassSettings.Setting.SQLPassword)

        ' Get FrmSettings data
        Dim ClosBack As Boolean
        'If RadYes.Checked Then ClosBack = True Else ClosBack = False

        If NewCon = True Then

            ' Save settings
            Settings.SaveSettings(ClosBack, ClassSettings.Setting.BackupClosing)
            Settings.SaveSettings(ServerName, ClassSettings.Setting.Server)
            Settings.SaveSettings(CmbDataBase.Text.Trim, ClassSettings.Setting.Database)
            Settings.SaveSettings(CmbDataBase.SelectedValue, ClassSettings.Setting.DataBaseID)
            Settings.SaveSettings(TxtSQLUser.Text.Trim, ClassSettings.Setting.SQLLogin)
            Settings.SaveSettings(TxtSqlPassword.Text, ClassSettings.Setting.SQLPassword)
            Settings.SaveSettings(TxtAdminName.Text, ClassSettings.Setting.AdminUser)
            Settings.SaveSettings(TxtAdminPass.Text, ClassSettings.Setting.AdminPassword)

            SaveInDB()
        Else
            ' Settings not saved
            MsgTool("لا يمكن حفظ الإعدادات خطأ في الإتصال", 0)
        End If
        BtnTestCon_Click(sender, e)
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel13)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Settings = New ClassSettings
        Dim Param() As SqlParameter
        Param = {
            New SqlParameter("@DriveName", TxtDrive.Text.Trim),
            New SqlParameter("@BackupPath", TxtBackupPath.Text),
            New SqlParameter("@BackUpName", TxtBackupName.Text)}
        Dim Sqlcon As New SQLConClass()
        SQLQuery = "       --------------------------------------------------------------- Get directories ready
      DECLARE @DirPath nvarchar(4000)
      DECLARE @DirResult int SET @DirResult = 0
declare @TargetLocation nvarchar(50)
  set @TargetLocation =@DriveName+':'
    -------------------------------------------- 1- Main folder for the system
      --EXEC IsDirExists @BackupPath,@DriveName, @DirResult
      EXEC IsDirExists @BackupPath, @TargetLocation, @DirResult
    IF @DirResult = 0
    Begin
    SET @DirPath = @TargetLocation + '\'+@BackupPath+'\'
    EXEC xp_create_subdir  @DirPath
    End
    SET @DirResult = 0 -- Reset @DirResult
    SET @TargetLocation = @TargetLocation + '\'+@BackupPath+'\'+@BackUpName +'-" & Now.Day.ToString + "-" + Now.Month.ToString + "-" + Now.Year.ToString & ".bak' "
        SQLQuery += "backup database " +
            Settings.GetSettings(ClassSettings.Setting.Database) + " TO DISK = @TargetLocation WITH INIT"

        Dim DS As DataSet
        DS = Sqlcon.SelectData(SQLQuery, 0, Param)
        '======
        'TxtBackupPath.Text = vbNullString
        'TxtDrive.Text = ""
        'TxtBackupName.Text = vbNullString
        MsgTool("تم اخد نسخة احتياطية بنجاح", 1)
    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        OFDRestor.Filter = "Bakup files (*.Bak)|*.Bak|All Files|*.*"
        OFDRestor.Title = "استعادة نسخة احتياطية"

        If OFDRestor.ShowDialog = DialogResult.OK Then
            Dim con1 As SqlConnection = New SqlConnection("Data Source=" & TxtServerName.Text.Trim &
        ";Initial Catalog=master;Integrated Security=False;User ID=" &
        TxtSQLUser.Text.Trim & ";Password=" & TxtSqlPassword.Text.Trim & ";")
            Try
                con1.Open()

                Dim Str2 As String = "ALTER Database [" & Settings.GetSettings(ClassSettings.Setting.Database) + "] Set SINGLE_USER WITH ROLLBACK IMMEDIATE"
                Dim CMD2 As New SqlCommand(Str2, con1)
                CMD2.ExecuteNonQuery()

                SQLQuery = "Use MASTER Restore Database [" + Settings.GetSettings(ClassSettings.Setting.Database) + "] From Disk= '" &
                    OFDRestor.FileName & "' WITH REPLACE"
                Cmd = New SqlCommand(SQLQuery, con1)
                Cmd.ExecuteNonQuery()

                Dim Str3 As String = "ALTER Database [" & Settings.GetSettings(ClassSettings.Setting.Database) + "] Set MULTI_USER"
                Dim CMD3 As New SqlCommand(Str3, con1)
                CMD3.ExecuteNonQuery()

                MsgBox("تم استعادة النسخة الإحتياطية من قواعد البيانات بنجاح", MsgBoxStyle.Information + vbMsgBoxRight, "استعادة نسخة أحتياطية")
                con1.Close()

            Catch ex As Exception
                con1.Close()

                If MessageBox.Show("تم ايقاف العملية " & vbCrLf & ex.Message, "استعادة نسخة أحتياطية",
                                   MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.Retry Then
                    BtnRestore_Click(sender, e)
                End If
            End Try
        End If

    End Sub

    Private Sub BtnCansel_Click(sender As Object, e As EventArgs) Handles BtnCansel.Click
        Clear(TableLayoutPanel3)
        GetFillDataBases()
        ChangeControlColor(Me)
        ' إعدادات الإتصال
        Dim ServerName As String = Settings.GetSettings(ClassSettings.Setting.Server)
        'Dim DataBase As String = Settings.GetSettings(ClassSettings.Setting.Database)
        Dim SQLUserName As String = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
        Dim SQLPassword As String = Settings.GetSettings(ClassSettings.Setting.SQLPassword)
        TxtServerName.Text = ServerName
        TxtSQLUser.Text = SQLUserName
        TxtSqlPassword.Text = SQLPassword


        ' نسخة عند الاغلاق
        Dim CloseBackup As String = Settings.GetSettings(ClassSettings.Setting.BackupClosing)
        'If CloseBackup = True Then
        '    RadYes.Checked = True
        '    RadNo.Checked = False
        'ElseIf CloseBackup = False Then
        '    RadNo.Checked = True
        '    RadYes.Checked = False
        'End If
    End Sub

    Private Sub SaveInDB()
        Dim Sqlcon As New SQLConClass()
        Dim Param() As SqlParameter = {
            New SqlParameter("AdminUserName", TxtAdminName.Text.Trim),
            New SqlParameter("AdminUserPassword", TxtAdminPass.Text.Trim),
            New SqlParameter("BackUpPath", TxtServerPath.Text.Trim),
            New SqlParameter("BackUpName", TxtServerBackupName.Text.Trim),
            New SqlParameter("BackUpMaxDays", 0),
            New SqlParameter("BackUpMaxCount", 0),
            New SqlParameter("ServerDrive", TxtServerDrive.Text.Trim)
        }
        DSDataBases = Sqlcon.CMDExecuteData("SaveGeneralMainInfo", Param)
        If Not DSHasTables(DSDataBases) Then Exit Sub
        CmbDataBase.DataSource = DSDataBases.Tables(0)
        CmbDataBase.ValueMember = "database_id"
        CmbDataBase.DisplayMember = "name"

        ' Set DataBase
        Dim DBID As Integer = Settings.GetSettings(ClassSettings.Setting.DataBaseID)
        Dim DBName As String = Settings.GetSettings(ClassSettings.Setting.Database)
        If DBID = 0 Then
            CmbDataBase.Text = DBName
        Else
            CmbDataBase.SelectedValue = DBID
        End If
        With DSDataBases.Tables(1).Rows(0)

            TxtAdminName.Text = .Item("AdminUserName")
            TxtAdminPass.Text = .Item("AdminUserPassword")
        End With

    End Sub

    Private Sub TxtAutoBackUpName_GotFocus(sender As Object, e As EventArgs) Handles TxtBackupName.GotFocus, TxtSQLUser.GotFocus, TxtDrive.GotFocus, TxtBackupPath.GotFocus
        ChangeLanguage("ENG")
    End Sub

    Private Sub TxtMaxBackUpCount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAutoBackupPath_TextChanged(sender As Object, e As EventArgs) Handles TxtAdminName.TextChanged, TxtAdminPass.TextChanged, TxtBackupName.TextChanged, TxtBackupPath.TextChanged
        '   If sender.BackColor <> SystemColors.WindowColor Then sender.BackColor = Color.White
        sender.BackColor = Color.White
    End Sub

    Private Sub TxtSqlPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtSqlPassword.TextChanged
    End Sub

    Private Sub TxtSQLUser_TextChanged(sender As Object, e As EventArgs) Handles TxtSQLUser.TextChanged
    End Sub

    Private Sub TxtServerName_TextChanged(sender As Object, e As EventArgs) Handles TxtServerName.TextChanged
    End Sub

    Private Sub TxtServerPath_TextChanged(sender As Object, e As EventArgs) Handles TxtServerPath.TextChanged
        sender.BackColor = Color.White ' SystemColors.WindowColor
    End Sub

    Private Sub CmbDataBase_TextChanged(sender As Object, e As EventArgs) Handles CmbDataBase.TextChanged
    End Sub

    Private Sub TxtDrive_TextChanged(sender As Object, e As EventArgs) Handles TxtDrive.TextChanged
        sender.BackColor = Color.White
    End Sub

    Private Sub TxtServerDrive_TextChanged(sender As Object, e As EventArgs) Handles TxtServerDrive.TextChanged
        sender.BackColor = Color.White
    End Sub

    Private Sub TxtServerPath_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDrive.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub
End Class