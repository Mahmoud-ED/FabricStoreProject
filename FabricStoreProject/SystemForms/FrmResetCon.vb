Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ManagementProject

Public Class FrmResetCon

    Private Sub FrmResetCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeSystemColors(Me)

        REM Get the settings values
        TxtServerName.Text = Settings.GetSettings(ClassSettings.Setting.Server)
        TxtDBName.Text = Settings.GetSettings(ClassSettings.Setting.Database)
        TxtLogin.Text = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
        TxtLoginPass.Text = Settings.GetSettings(ClassSettings.Setting.SQLPassword)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & TxtServerName.Text.Trim &
        ";Initial Catalog=master;Integrated Security=False;User ID=" & TxtLogin.Text.Trim &
        ";Password=" & TxtLoginPass.Text.Trim & ";")
        Dim DA2 As SqlDataAdapter
        Dim DtTestCon As New DataTable

        Try
            SQLQuery = "SELECT * FROM sys.databases WHERE name = '" & TxtDBName.Text.Trim & "'"
            DA2 = New SqlDataAdapter(SQLQuery, ConTest)
            DA2.Fill(DtTestCon)
            If DtTestCon.Rows.Count = 0 Then
                ConTest.Close()
                MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
            Else
                Settings.SaveSettings(TxtServerName.Text.Trim, ClassSettings.Setting.Server)
                Settings.SaveSettings(TxtDBName.Text.Trim, ClassSettings.Setting.Database)
                Settings.SaveSettings(TxtLogin.Text.Trim, ClassSettings.Setting.SQLLogin)
                Settings.SaveSettings(TxtLoginPass.Text.Trim, ClassSettings.Setting.SQLPassword)
                End
            End If
        Catch ex2 As Exception
            ConTest.Close()
            MsgBox("بيانات الإتصال غير صحيحة", MsgBoxStyle.Critical, "خطأ إتصال")
        End Try

    End Sub

    Private Sub PicShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles PicShowPassword.MouseEnter
        TxtLoginPass.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles PicShowPassword.MouseLeave
        TxtLoginPass.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub FrmResetCon_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
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
