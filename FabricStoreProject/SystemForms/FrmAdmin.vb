Imports System.ComponentModel
Public Class FrmAdmin

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeSystemColors(Me)
        TxtAdmin.Select()
    End Sub

    Private Sub TxtAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdmin.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TxtAdmin.Text.Trim = "" Then
                TxtAdmin.Focus()
            Else
                TxtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TxtPassword.Text = "" Then
                TxtPassword.Focus()
            Else
                BtnOk_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dim Settings = New ClassSettings
        Dim AdminUser, AdminPass As String
        AdminPass = Settings.GetSettings(ClassSettings.Setting.AdminPassword)
        AdminUser = Settings.GetSettings(ClassSettings.Setting.AdminUser)

        If TxtAdmin.Text = AdminUser And TxtPassword.Text = AdminPass Then
            Me.Hide()
            FrmResetCon.ShowDialog()
        Else
            MsgBox("بيانات الدخول خاطئة ", MsgBoxStyle.Critical, "خطأ دخول")
            TxtAdmin.Text = ""
            TxtPassword.Text = ""
            TxtAdmin.Focus()
        End If
    End Sub

    Private Sub PicShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles PicShowPassword.MouseEnter
        TxtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles PicShowPassword.MouseLeave
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub FrmAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub TxtAdmin_GotFocus(sender As Object, e As EventArgs) Handles TxtAdmin.GotFocus
        ChangeLanguage("EN")
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub
End Class