Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TwainLib
Imports System.Windows.Forms


Public Class FrmCenterInfoSettings
    Private DS As DataSet

    Private Sub FrmCenterInfoSettings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetFillData()

        Else
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

        End If
        TxtArCenterName.Focus()
        TxtArCenterName.DeselectAll()

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetFillData()
        Dim Sqlcon As New SQLConClass()
        SQLQuery = "  Select PhoneNum1,PhoneNum2,Email,Name,Address,Logo, LogoReport,Facebook, City FROM CenterInfoTable "
        DS = Sqlcon.SelectData(SQLQuery, 0, Nothing)
        If Not DSHasTables(DS) Then Exit Sub
        FillData()
    End Sub


    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        IsDataMissing = False
        IsInputEmpty(GrpLab)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If IsNothing(PicCompany.Image) Or IsNothing(PicCompanyReport.Image) Then
            MsgTool("يرجى اختيار شعار المتجر وشعار التقارير", 0)
            Exit Sub
        End If

        Dim sqlcon As New SQLConClass()
        Dim Param() As SqlParameter = {
            New SqlParameter("@Name", TxtArCenterName.Text.Trim),
            New SqlParameter("@City", TxtCity.Text),
            New SqlParameter("@Address", TxtAddress.Text.Trim),
            New SqlParameter("@Phone1", TxtPhoneNum1.Text.Trim),
            New SqlParameter("@Phone2", TxtPhoneNum2.Text.Trim),
            New SqlParameter("@Logo", ImageToByte(PicCompany)),
            New SqlParameter("@LogoReport", ImageToByte(PicCompanyReport)),
            New SqlParameter("@FaceBook", TxtFacebookPage.Text.Trim),
            New SqlParameter("@Email", TxtEmail.Text.Trim)}
        Param(5).SqlDbType = SqlDbType.VarBinary
        Param(6).SqlDbType = SqlDbType.VarBinary
        DS = sqlcon.CMDExecuteData("SaveCompanyData", Param)
        If DSHasTables(DS) Then
            FillData()

            Dim projectPath As String = Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath)
            Dim FullName As String = Directory.GetParent(Directory.GetParent(projectPath).FullName).FullName
            FullName = FullName & "\CenterLogo" '.Png"

            If Not Directory.Exists(FullName) Then
                Directory.CreateDirectory(FullName)
            End If
            '

            If Not PicCompany Is Nothing Then
                Dim NewImage As Bitmap = PicCompany.Image


                Dim LogoPath As String = FullName
                FullName = FullName & "\CenterLogo" & My.Computer.Info.AvailablePhysicalMemory & ".Png"
                NewImage.Save(FullName, System.Drawing.Imaging.ImageFormat.Png)
                Settings.SaveSettings(FullName, ClassSettings.Setting.CenterLogoPath)
            End If

        End If

    End Sub

    Private Sub FillData()
        If DS.Tables(0).Rows.Count > 0 Then

            With DS.Tables(0).Rows(0)
                TxtArCenterName.Text = .Item("Name")
                TxtCity.Text = .Item("City")
                TxtAddress.Text = .Item("Address")
                TxtPhoneNum1.Text = .Item("PhoneNum1")
                TxtPhoneNum2.Text = .Item("PhoneNum2")
                TxtEmail.Text = .Item("Email")
                TxtFacebookPage.Text = .Item("Facebook")

                If Not IsDBNull(.Item("Logo")) Then
                    PicCompany.Image = ByteToImage(.Item("Logo"))
                    PicCompany.BackgroundImage = Nothing

                    Frmmain.PicLogoCo.Image = ByteToImage(.Item("Logo"))
                    Frmmain.PicLogoCo.BackgroundImage = Nothing



                Else
                    PicCompany.Image = Nothing
                    PicCompany.BackgroundImage = Nothing

                    Frmmain.PicLogoCo.Image = Nothing
                    Frmmain.PicLogoCo.BackgroundImage = Nothing
                End If

                If Not IsDBNull(.Item("LogoReport")) Then
                    PicCompanyReport.Image = ByteToImage(.Item("LogoReport"))
                    PicCompanyReport.BackgroundImage = Nothing
                Else
                    PicCompanyReport.Image = Nothing

                    PicCompanyReport.BackgroundImage = Nothing
                End If
            End With
        End If

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TxtFacebookPage.Focus()
    End Sub

    Private Sub TxtFacebookPage_TextChanged(sender As Object, e As EventArgs) Handles TxtFacebookPage.TextChanged
        sender.BackColor = Color.White
        If TxtFacebookPage.Text = "" Then Label9.Visible = True Else Label9.Visible = False

    End Sub

    Private Sub BtnShowPic_Click(sender As Object, e As EventArgs) Handles BtnShowPic.Click
        If IsNothing(PicCompany.Image) Then Exit Sub
        Dim FileName As String = ""
        Dim Extension As String = ".png"
        OpenFile(FileName, Extension, ImageToByte(PicCompany))
    End Sub

    Private Sub BtnAddLogo_Click(sender As Object, e As EventArgs) Handles BtnAddLogo.Click
        If Settings.GetSettings(ClassSettings.Setting.ServiceLang) = "EN" Then
            OpfLogo.Title = "Select Center Logo"

        Else
            OpfLogo.Title = "اختيار شعار المتجر"
        End If

        OpfLogo.Filter = "(Image Files)|*.png|Png | *.png|Jpg, | *.jpg"
        If OpfLogo.ShowDialog() = DialogResult.OK Then
            PicCompany.Image = Image.FromFile(OpfLogo.FileName)
        End If
    End Sub

    Private Sub BtnDelPic_Click(sender As Object, e As EventArgs) Handles BtnDelPic.Click
        PicCompany.Image = Nothing
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear(GrpLab)
        GetFillData()
    End Sub

    Private Sub TxtPhoneNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhoneNum1.KeyPress
        If IsPhone(sender.Text, e) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhoneNum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhoneNum2.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtArCenterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArCenterName.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEnCenterName_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus
        ChangeLanguage("ENG")
    End Sub

    Public Function IsPhone(Txt As String, Number As KeyPressEventArgs) As Boolean

        If Asc(Number.KeyChar) = Keys.Space Then Return False
        If Number.KeyChar = vbBack Then Return True
        If Not Txt.Length < 10 Then Return False

        Select Case Txt.Length

            Case 0
                If Number.KeyChar <> "0" Then Return False

            Case 1
                If Number.KeyChar <> "9" Then Return False

        End Select
        Return True

    End Function

    Private Sub TxtArCenterName_TextChanged(sender As Object, e As EventArgs) Handles TxtArCenterName.TextChanged, TxtAddress.TextChanged, TxtFacebookPage.TextChanged, TxtPhoneNum1.TextChanged, TxtPhoneNum2.TextChanged
        sender.BackColor = Color.White

    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        sender.BackColor = Color.White
        If TxtEmail.Text = "" Then LblEmail.Visible = True Else LblEmail.Visible = False

    End Sub


    Private Sub BtnAddLogoReport_Click(sender As Object, e As EventArgs) Handles BtnAddLogoReport.Click
        If Settings.GetSettings(ClassSettings.Setting.ServiceLang) = "EN" Then
            OpfLogo.Title = "Select Report Logo"

        Else
            OpfLogo.Title = "اختيار شعار التقارير"
        End If

        OpfLogo.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        If OpfLogo.ShowDialog() = DialogResult.OK Then
            PicCompanyReport.Image = Image.FromFile(OpfLogo.FileName)
        End If
    End Sub

    Private Sub BtnShowPicReport_Click(sender As Object, e As EventArgs) Handles BtnShowPicReport.Click
        If IsNothing(PicCompanyReport.Image) Then Exit Sub
        Dim FileName As String = ""
        Dim Extension As String = ".jpg"
        OpenFile(FileName, Extension, ImageToByte(PicCompanyReport))
    End Sub

    Private Sub BtnDelPicReport_Click(sender As Object, e As EventArgs) Handles BtnDelPicReport.Click
        PicCompanyReport.Image = Nothing
    End Sub

    Private Sub CmbCity_SelectedIndexChanged(sender As Object, e As EventArgs)
        sender.BackColor = System.Drawing.SystemColors.Window
    End Sub

    Private Sub CmbCity_TextChanged(sender As Object, e As EventArgs)
        sender.BackColor = System.Drawing.SystemColors.Window
    End Sub

End Class