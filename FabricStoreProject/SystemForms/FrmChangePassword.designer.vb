<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkShowPassword = New System.Windows.Forms.CheckBox()
        Me.PicShowOldPass = New System.Windows.Forms.PictureBox()
        Me.PicShowNewPass = New System.Windows.Forms.PictureBox()
        Me.PicShowConfirmPass = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtUserName = New System.Windows.Forms.Label()
        Me.PnlMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicShowOldPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicShowNewPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicShowConfirmPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(3, 3)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(574, 28)
        Me.PnlMenu.TabIndex = 3
        Me.PnlMenu.Tag = "Dark"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(0, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(38, 28)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Lbl.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Lbl.ForeColor = System.Drawing.Color.White
        Me.Lbl.Location = New System.Drawing.Point(3, 33)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl.Size = New System.Drawing.Size(574, 37)
        Me.Lbl.TabIndex = 5
        Me.Lbl.Tag = "Primary"
        Me.Lbl.Text = " تغيير كلمة المرور"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.ChkShowPassword)
        Me.GroupBox1.Controls.Add(Me.PicShowOldPass)
        Me.GroupBox1.Controls.Add(Me.PicShowNewPass)
        Me.GroupBox1.Controls.Add(Me.PicShowConfirmPass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNewPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtOldPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 72)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(559, 245)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ChkShowPassword
        '
        Me.ChkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkShowPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!)
        Me.ChkShowPassword.ForeColor = System.Drawing.Color.Gray
        Me.ChkShowPassword.Location = New System.Drawing.Point(22, 210)
        Me.ChkShowPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkShowPassword.Name = "ChkShowPassword"
        Me.ChkShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShowPassword.Size = New System.Drawing.Size(148, 32)
        Me.ChkShowPassword.TabIndex = 8
        Me.ChkShowPassword.Text = "عرض كلمات المرور"
        Me.ChkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkShowPassword.UseVisualStyleBackColor = True
        '
        'PicShowOldPass
        '
        Me.PicShowOldPass.BackColor = System.Drawing.Color.White
        Me.PicShowOldPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowOldPass.Image = CType(resources.GetObject("PicShowOldPass.Image"), System.Drawing.Image)
        Me.PicShowOldPass.Location = New System.Drawing.Point(30, 81)
        Me.PicShowOldPass.Name = "PicShowOldPass"
        Me.PicShowOldPass.Size = New System.Drawing.Size(19, 19)
        Me.PicShowOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowOldPass.TabIndex = 46
        Me.PicShowOldPass.TabStop = False
        Me.PicShowOldPass.Tag = ""
        '
        'PicShowNewPass
        '
        Me.PicShowNewPass.BackColor = System.Drawing.Color.White
        Me.PicShowNewPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowNewPass.Image = CType(resources.GetObject("PicShowNewPass.Image"), System.Drawing.Image)
        Me.PicShowNewPass.Location = New System.Drawing.Point(30, 130)
        Me.PicShowNewPass.Name = "PicShowNewPass"
        Me.PicShowNewPass.Size = New System.Drawing.Size(19, 19)
        Me.PicShowNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowNewPass.TabIndex = 45
        Me.PicShowNewPass.TabStop = False
        Me.PicShowNewPass.Tag = ""
        '
        'PicShowConfirmPass
        '
        Me.PicShowConfirmPass.BackColor = System.Drawing.Color.White
        Me.PicShowConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowConfirmPass.Image = CType(resources.GetObject("PicShowConfirmPass.Image"), System.Drawing.Image)
        Me.PicShowConfirmPass.Location = New System.Drawing.Point(30, 176)
        Me.PicShowConfirmPass.Name = "PicShowConfirmPass"
        Me.PicShowConfirmPass.Size = New System.Drawing.Size(19, 19)
        Me.PicShowConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowConfirmPass.TabIndex = 44
        Me.PicShowConfirmPass.TabStop = False
        Me.PicShowConfirmPass.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(403, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(151, 28)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "اسم المســتخـدم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(23, 171)
        Me.TxtConfirmPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtConfirmPassword.MaxLength = 20
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(376, 35)
        Me.TxtConfirmPassword.TabIndex = 35
        Me.TxtConfirmPassword.Tag = "2"
        Me.TxtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(403, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(151, 28)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "تأكيد كلمة المرور"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNewPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNewPassword.Location = New System.Drawing.Point(23, 124)
        Me.TxtNewPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNewPassword.MaxLength = 20
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNewPassword.Size = New System.Drawing.Size(376, 35)
        Me.TxtNewPassword.TabIndex = 33
        Me.TxtNewPassword.Tag = "2"
        Me.TxtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNewPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(403, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(151, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "كلمة المرور الجديدة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtOldPassword
        '
        Me.TxtOldPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOldPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtOldPassword.Location = New System.Drawing.Point(23, 78)
        Me.TxtOldPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOldPassword.MaxLength = 20
        Me.TxtOldPassword.Name = "TxtOldPassword"
        Me.TxtOldPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtOldPassword.Size = New System.Drawing.Size(376, 35)
        Me.TxtOldPassword.TabIndex = 31
        Me.TxtOldPassword.Tag = "2"
        Me.TxtOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOldPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(403, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(151, 28)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "كلمة المرور الحالية"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnOK)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 312)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(559, 72)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(69, 25)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(203, 36)
        Me.BtnCancel.TabIndex = 31
        Me.BtnCancel.Tag = "Dark"
        Me.BtnCancel.Text = "إغلاق"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.FlatAppearance.BorderSize = 0
        Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOK.Location = New System.Drawing.Point(296, 25)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(203, 36)
        Me.BtnOK.TabIndex = 30
        Me.BtnOK.Tag = "Dark"
        Me.BtnOK.Text = "موافق"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'LblMessage
        '
        Me.LblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblMessage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.White
        Me.LblMessage.Location = New System.Drawing.Point(0, -4)
        Me.LblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(586, 32)
        Me.LblMessage.TabIndex = 458
        Me.LblMessage.Text = "كلمة المرور غير صحيحة"
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMessage.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblMessage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 394)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 28)
        Me.Panel1.TabIndex = 47
        Me.Panel1.Tag = "Dark"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Lbl)
        Me.Panel2.Controls.Add(Me.PnlMenu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(580, 425)
        Me.Panel2.TabIndex = 48
        Me.Panel2.Tag = "Background"
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtUserName.ForeColor = System.Drawing.Color.Black
        Me.TxtUserName.Location = New System.Drawing.Point(23, 31)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUserName.Size = New System.Drawing.Size(376, 35)
        Me.TxtUserName.TabIndex = 1273
        Me.TxtUserName.Tag = "AutoC"
        Me.TxtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 431)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmChangePassword"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = " تغيير كلمة المرور"
        Me.PnlMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicShowOldPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicShowNewPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicShowConfirmPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Lbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtOldPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkShowPassword As CheckBox
    Friend WithEvents LblMessage As Label
    Friend WithEvents PicShowOldPass As PictureBox
    Friend WithEvents PicShowNewPass As PictureBox
    Friend WithEvents PicShowConfirmPass As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtUserName As Label
End Class
