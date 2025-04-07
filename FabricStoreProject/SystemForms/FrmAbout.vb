Public Class FrmAbout

    Private SW As Boolean
    Private Pos As Point
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        Me.Left = (frmmain.Width - Me.Width) / 2
        Me.Top = (frmmain.Height - Me.Height) / 2
    End Sub
    Private Sub FrmAbout_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PicCombany.MouseDown, PictureBox1.MouseDown, PictureBox2.MouseDown, lblDetails.MouseDown, lblTitle.MouseDown, LblAdd.MouseDown, LblPhoneNum.MouseDown, Panel1.MouseDown, Panel2.MouseDown, Panel8.MouseDown, PnlMenu.MouseDown, PicFaceBook.MouseDown, PicGmail.MouseDown, LblFacebook.MouseDown, LblGmail.MouseDown
        If e.Button = MouseButtons.Left Then
            SW = True
            Pos = e.Location
        End If
    End Sub

    Private Sub FrmAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, PicCombany.MouseMove, PictureBox1.MouseMove, PictureBox2.MouseMove, lblDetails.MouseMove, lblTitle.MouseMove, LblAdd.MouseMove, LblPhoneNum.MouseMove, Panel1.MouseMove, Panel2.MouseMove, Panel8.MouseMove, PnlMenu.MouseMove, PicFaceBook.MouseMove, PicGmail.MouseMove, LblFacebook.MouseMove, LblGmail.MouseMove
        If SW = True Then
            Me.Location = Me.Location + (e.Location - Pos)
        End If
    End Sub

    Private Sub FrmAbout_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, PicCombany.MouseUp, PictureBox1.MouseUp, PictureBox2.MouseUp, lblDetails.MouseUp, lblTitle.MouseUp, LblAdd.MouseUp, LblPhoneNum.MouseUp, Panel1.MouseUp, Panel2.MouseUp, Panel8.MouseUp, PnlMenu.MouseUp, PicFaceBook.MouseUp, PicGmail.MouseUp, LblFacebook.MouseUp, LblGmail.MouseUp
        If e.Button = MouseButtons.Left Then
            SW = False
        End If
    End Sub


End Class