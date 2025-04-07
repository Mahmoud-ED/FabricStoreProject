Imports System.Data.SqlClient

Public Class FrmChangePassword

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChangeSystemColors(Me)
        TxtUserName.Text = UserName
        TxtOldPassword.Select()

    End Sub

    Private Sub FrmChangePassword_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Public Sub ChangeColor()

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

    Private Sub TxtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtNewPassword.GotFocus
        If TxtOldPassword.Text <> UserPassword And TxtOldPassword.Text <> "" Then
            TxtOldPassword.Text = ""
            TxtOldPassword.Focus()
            LblMessage.Text = "كلمة المرور التي أدخلتها غير صحيحة"
            LblMessage.Visible = True
            Exit Sub
        End If
        If TxtOldPassword.Text = "" Then
            TxtOldPassword.Text = ""
            TxtOldPassword.Focus()
            LblMessage.Text = "يرجى كتابة كلمة المرور السابقة"
            LblMessage.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        If TxtOldPassword.Text = "" Then
            LblMessage.Text = "الرجاء إدخال كلمة المرور الحالية"
            LblMessage.Visible = True
            TxtOldPassword.Focus()
            Exit Sub
        ElseIf TxtOldPassword.Text <> UserPassword Then
            LblMessage.Text = "كلمة المرور الحالية غير صحيحة"
            LblMessage.Visible = True
            TxtOldPassword.Focus()
            TxtOldPassword.SelectAll()
            Exit Sub
        ElseIf TxtNewPassword.Text = "" Then
            LblMessage.Text = "الرجاء إدخال كلمة المرور الجديدة"
            LblMessage.Visible = True
            TxtNewPassword.Focus()
            Exit Sub
        ElseIf TxtNewPassword.Text <> TxtConfirmPassword.Text Then
            LblMessage.Text = "كلمة المرور غير متطابقة"
            LblMessage.Visible = True
            TxtConfirmPassword.Focus()
            TxtConfirmPassword.SelectAll()
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        Dim Para() As SqlParameter = {
            New SqlParameter("@NewPassword", TxtNewPassword.Text),
            New SqlParameter("@ID", UserID)
        }

        SQLQuery = "UPDATE UserTable SET Password=@NewPassword WHERE ID=@ID"
        Select Case SQLCon.CMDExecute(SQLQuery, 0, Para)
            Case > 0
                MsgBox("تم تغيير كلمة المرور بنجاح", vbInformation, "تأكيد")
                UserPassword = TxtNewPassword.Text
                BtnCancel_Click(sender, e)
        End Select

    End Sub

    Private Sub PicShowOldPassword_MouseMove(sender As Object, e As EventArgs) Handles PicShowOldPass.MouseMove
        TxtOldPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowOldPassword_MouseLeave(sender As Object, e As EventArgs) Handles PicShowOldPass.MouseLeave
        If ChkShowPassword.Checked Then Exit Sub
        TxtOldPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub PicShowNewPassword_MouseMove(sender As Object, e As EventArgs) Handles PicShowNewPass.MouseMove
        TxtNewPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowNewPassword_MouseLeave(sender As Object, e As EventArgs) Handles PicShowNewPass.MouseLeave
        If ChkShowPassword.Checked Then Exit Sub
        TxtNewPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPassword.CheckedChanged
        If ChkShowPassword.Checked = True Then
            TxtOldPassword.UseSystemPasswordChar = False
            TxtNewPassword.UseSystemPasswordChar = False
            TxtConfirmPassword.UseSystemPasswordChar = False
        Else
            TxtOldPassword.UseSystemPasswordChar = True
            TxtNewPassword.UseSystemPasswordChar = True
            TxtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        MainActive = True
        Me.Dispose()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

    Private Sub PicShowConfirmPass_MouseMove(sender As Object, e As MouseEventArgs) Handles PicShowConfirmPass.MouseMove
        TxtConfirmPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowConfirmPass_MouseLeave(sender As Object, e As EventArgs) Handles PicShowConfirmPass.MouseLeave
        If ChkShowPassword.Checked Then Exit Sub
        TxtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles TxtOldPassword.TextChanged, TxtNewPassword.TextChanged, TxtConfirmPassword.TextChanged
        LblMessage.Visible = False
    End Sub

    Private Sub PicShowOldPassword_MouseMove(sender As Object, e As MouseEventArgs) Handles PicShowOldPass.MouseMove

    End Sub

    Private Sub PicShowNewPassword_MouseMove(sender As Object, e As MouseEventArgs) Handles PicShowNewPass.MouseMove

    End Sub

    Private Sub TxtOldPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOldPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtNewPassword.Focus()
        End If
    End Sub

    Private Sub TxtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TxtNewPassword.Text = "" Then
                TxtNewPassword.Focus()
                LblMessage.Text = "يرجى كتابة كلمة المرور الجديدة"
                LblMessage.Visible = True
            Else
                'BtnOk_Click(sender, e)
                TxtConfirmPassword.Focus()
            End If
        End If
    End Sub

    Private Sub TxtConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtConfirmPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TxtConfirmPassword.Text = "" Then
                TxtConfirmPassword.Focus()
                LblMessage.Text = "يرجى تأكيد كلمة المرور الجديدة"
                LblMessage.Visible = True

            ElseIf TxtConfirmPassword.Text.Trim <> TxtNewPassword.Text.Trim Then
                TxtConfirmPassword.Focus()
                TxtConfirmPassword.SelectAll()
                LblMessage.Text = "الكلمة غير متطابقة ، يرجى تأكيد كلمة المرور الجديدة"
                LblMessage.Visible = True

            Else
                BtnOk_Click(sender, e)
            End If

        End If
    End Sub

End Class