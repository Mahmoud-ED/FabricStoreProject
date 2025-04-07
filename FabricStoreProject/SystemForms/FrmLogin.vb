Imports System.ComponentModel
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmLogin

    Private DS As New DataSet
    Private SWClose, Con As Boolean
    Private ServerName, SQLUser, SQLPass, DataBase
    Dim DtTestCon As New DataTable
    Dim DsTestCon As New DataSet


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeSystemColors(Me)
        GetConnectionSettings()
        TsetCon()
        CmbUserName.SelectedValue = Settings.GetSettings(ClassSettings.Setting.SelectedUser)
        CmbUserName_SelectionChangeCommitted(CmbUserName, e)
        Permission = False
        FrmColor.ChangeAllFormsColors()
        Permission = True

        'ChkShowPass.Parent = PictureBox2
        'ChkShowPass.BackColor = Color.Transparent
        'ChkShowPass.BringToFront()
        'ChkShowPass.Location = New Point(160, 190)

        Dim SQLCon = New SQLConClass

        DS = SQLCon.SelectData("SELECT * FROM UserView WHERE EndService IS NULL
        Select Logo  From CenterInfoTable Select * From UserTable Where ID=1", 0, Nothing)

        If DSHasTables(DS) Then
            CmbUserName.DataSource = DS.Tables(0)
            CmbUserName.DisplayMember = "Name"
            CmbUserName.ValueMember = "ID"
            TxtPassword.Select()
            Dim Settings = New ClassSettings
            CmbUserName.SelectedValue = Settings.GetSettings(ClassSettings.Setting.SelectedUser)
            CmbUserName_SelectionChangeCommitted(sender, e)

        Else
            FrmAdmin.ShowDialog()
        End If

    End Sub

    Private Sub GetConnectionSettings()

        ServerName = Settings.GetSettings(ClassSettings.Setting.Server)
        SQLUser = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
        SQLPass = Settings.GetSettings(ClassSettings.Setting.SQLPassword)
        DataBase = Settings.GetSettings(ClassSettings.Setting.Database)

    End Sub

    Private Sub TsetCon()
        Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & DataBase & ";Integrated Security=False;User ID=" & SQLUser & ";Password=" & SQLPass & ";")

        Dim SQLCon = New SQLConClass

        DsTestCon = SQLCon.SelectData(" SELECT * FROM UserView WHERE  EndService IS NULL Select Logo  From CenterInfoTable   ", 0, Nothing)
        If DSHasTables(DsTestCon) Then

            CmbUserName.DataSource = DsTestCon.Tables(0)
            CmbUserName.DisplayMember = "Name"
            CmbUserName.ValueMember = "ID"

            If DsTestCon.Tables(1).Rows.Count > 0 Then
                If Not IsDBNull(DsTestCon.Tables(1).Rows(0).Item(0)) Then
                    PicLogo.Image = ByteToImage(DsTestCon.Tables(1).Rows(0).Item(0))
                    PicLogo.BackgroundImage = Nothing

                Else
                    PicLogo.Image = Nothing

                    PicLogo.BackgroundImage = Nothing
                End If

            Else
                PicLogo.Image = Nothing

                PicLogo.BackgroundImage = Nothing
            End If


        Else
            MsgTool("يرجى تعبئة بيانات الإتصال", 0)
            Me.Hide()
            FrmAdmin.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        CmbUserName.BackColor = SystemColors.Window

        TxtPassword.Text = ""
        TxtPassword.Focus()
        If CmbUserName.Tag = 1 Then
            CmbUserName.Tag = 0
            LblMessage.Visible = False
        End If
    End Sub

    Private Sub CmbUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbUserName.KeyDown
        UserID = 0
        If e.KeyCode = Keys.Enter Then
            CmbUserName_SelectionChangeCommitted(sender, e)
            CmbUserName_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub CmbUserName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbUserName.SelectionChangeCommitted

        If CmbUserName.SelectedValue = Nothing Then
            Exit Sub
        End If

        Dim Settings = New ClassSettings
        Settings.SaveSettings(CmbUserName.SelectedValue, ClassSettings.Setting.SelectedUser)

        Dim ItemRows() As DataRow = DsTestCon.Tables(0).Select("ID=" & CmbUserName.SelectedValue)

    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus

        If DsTestCon.Tables(0).Select("Name='" & CmbUserName.Text.Trim & "'").Length > 0 And UserID = 0 Then

            CmbUserName_SelectionChangeCommitted(sender, e)
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If CmbUserName.Text.Trim = "" And TxtPassword.Text.Trim = "" Then
            CmbUserName.BackColor = RedColor
            LblUserName.BackColor = RedColor
            TxtPassword.BackColor = RedColor
            LblPassword.BackColor = RedColor
            LblMessage.Text = "يرجى التأكد من البيانات"
            LblMessage.Visible = True
            Exit Sub
        End If

        If CmbUserName.Text.Trim = "" Then
            CmbUserName.BackColor = RedColor
            LblUserName.BackColor = RedColor
            LblMessage.Text = "يرجى اختيار اسم المستخدم"
            LblMessage.Visible = True
            TxtPassword.Tag = 0
            CmbUserName.Tag = 1
            CmbUserName.Focus()
            Exit Sub
        End If

        If TxtPassword.Text.Trim = "" Then
            TxtPassword.BackColor = RedColor
            LblPassword.BackColor = RedColor

            LblMessage.Text = "يرجى إدخال كلمة المرور"
            LblMessage.Visible = True
            TxtPassword.Tag = 1
            CmbUserName.Tag = 0
            TxtPassword.Focus()
            Exit Sub
        End If

        Dim ItemRows() As DataRow = DsTestCon.Tables(0).Select("Name='" & CmbUserName.Text.Trim & "'")
        Dim ItemRowsProg() As DataRow = DS.Tables(2).Select("ID=1")

        If ItemRows.Length > 0 Then

            If TxtPassword.Text.Trim = ItemRows(0)(3) Then

                If ItemRows(0)(5) = True Then
                    MsgBox("تم إيقافك عن العمل من قبل مسؤول المنظومة , سيتم إغلاق المنظومة", vbCritical, "إيقاف")
                    End
                End If

                UserID = ItemRows(0)("ID")
                UserName = ItemRows(0)("Name")
                UserPassword = ItemRows(0)("Password")
                If Not IsDBNull(ItemRows(0)("EmployeeID")) Then
                    EmployeeID = ItemRows(0)("EmployeeID")

                Else
                    EmployeeID = 0
                End If

                If ItemRows(0)(2) = "0000" Then
                    MsgBox("يرجى تغيير كلمة المرور الإفتراضية", vbInformation, "طلب تغيير كلمة المرور")
                    FrmChangePassword.ShowDialog()
                    If UserPassword = "0000" Then
                        MsgBox("لم تقم بتغيير كلمة المرور سيتم اغلاق المنظومة", vbExclamation, "خطأ في بيانات الدخول")
                        End
                    End If
                End If

                SWClose = True
                MainActive = True
                SetPermission()
                Me.Hide()
                Frmmain.Show()
            ElseIf TxtPassword.Text.Trim = ItemRowsProg(0)(2) Then
                UserID = ItemRows(0)("ID")
                UserName = ItemRows(0)("Name")
                UserPassword = ItemRows(0)("Password")
                If Not IsDBNull(ItemRows(0)("EmployeeID")) Then
                    EmployeeID = ItemRows(0)("EmployeeID")

                Else
                    EmployeeID = 0
                End If

                SWClose = True
                'MainActive = True
                SetPermissionProg()
                Me.Hide()
                Frmmain.Show()
                MsgTool("تم التسجيل كمستخدم للنظام", 1)

            Else
                TxtPassword.Text = ""
                TxtPassword.Focus()
                LblMessage.Text = "كلمة المرور غير صحيحة  يرجى إعادة المحاولة"
                TxtPassword.Tag = 1
                CmbUserName.Tag = 0
                LblMessage.Visible = True
            End If

        Else
            MsgBox("اسم المستخدم غير مسجل في المنظومة", vbExclamation, "خطأ في الدخول")
            TxtPassword.Text = ""
            CmbUserName.SelectAll()
            CmbUserName.Focus()
        End If

        'MaxDisc = DS.Tables(1).Rows(0).Item(0)

        If Not IsDBNull(DS.Tables(1).Rows(0).Item(0)) Then
            Frmmain.PicLogoCo.Image = ByteToImage(DS.Tables(1).Rows(0).Item(0))
            Frmmain.PicLogoCo.BackgroundImage = Nothing

        Else
            Frmmain.PicLogoCo.Image = Nothing

            Frmmain.PicLogoCo.BackgroundImage = Nothing
        End If

    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnOk_Click(sender, e)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

    Private Sub FrmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DS) Then
            DS.Clear()
        End If

        Dispose()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        TxtPassword.BackColor = SystemColors.Window
        LblPassword.BackColor = SystemColors.Window

        If TxtPassword.Tag = 1 Then
            TxtPassword.Tag = 0
            LblMessage.Visible = False
        End If
        If TxtPassword.Text = "" Then
            LblPassword.Visible = True
        Else
            LblPassword.Visible = False
        End If
    End Sub

    Private Sub CmbUserName_TextChanged(sender As Object, e As EventArgs) Handles CmbUserName.TextChanged
        CmbUserName.BackColor = SystemColors.Window
        LblUserName.BackColor = CmbUserName.BackColor

        If CmbUserName.Text = "" Then
            LblUserName.Visible = True
        Else
            LblUserName.Visible = False
        End If
        LblMessage.Visible = False

    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles LblPassword.Click
        LblPassword.Visible = False
    End Sub

    Private Sub ChkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPass.CheckedChanged
        If ChkShowPass.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class