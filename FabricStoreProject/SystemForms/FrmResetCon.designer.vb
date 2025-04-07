<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmResetCon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResetCon))
        Me.TxtLoginPass = New System.Windows.Forms.TextBox()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtServerName = New System.Windows.Forms.TextBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PicShowPassword = New System.Windows.Forms.PictureBox()
        Me.TxtDBName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtLoginPass
        '
        Me.TxtLoginPass.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtLoginPass.Location = New System.Drawing.Point(20, 176)
        Me.TxtLoginPass.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLoginPass.MaxLength = 50
        Me.TxtLoginPass.Name = "TxtLoginPass"
        Me.TxtLoginPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtLoginPass.Size = New System.Drawing.Size(322, 35)
        Me.TxtLoginPass.TabIndex = 16
        Me.TxtLoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtLoginPass.UseSystemPasswordChar = True
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtLogin.Location = New System.Drawing.Point(20, 128)
        Me.TxtLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLogin.MaxLength = 100
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtLogin.Size = New System.Drawing.Size(322, 35)
        Me.TxtLogin.TabIndex = 14
        Me.TxtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtServerName
        '
        Me.TxtServerName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtServerName.Location = New System.Drawing.Point(20, 34)
        Me.TxtServerName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtServerName.MaxLength = 300
        Me.TxtServerName.Name = "TxtServerName"
        Me.TxtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtServerName.Size = New System.Drawing.Size(322, 35)
        Me.TxtServerName.TabIndex = 13
        Me.TxtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(3, 3)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(481, 28)
        Me.PnlMenu.TabIndex = 21
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicShowPassword)
        Me.GroupBox1.Controls.Add(Me.TxtDBName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtServerName)
        Me.GroupBox1.Controls.Add(Me.TxtLogin)
        Me.GroupBox1.Controls.Add(Me.TxtLoginPass)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(467, 231)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الدخول"
        '
        'PicShowPassword
        '
        Me.PicShowPassword.BackColor = System.Drawing.Color.White
        Me.PicShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowPassword.Image = CType(resources.GetObject("PicShowPassword.Image"), System.Drawing.Image)
        Me.PicShowPassword.Location = New System.Drawing.Point(26, 181)
        Me.PicShowPassword.Name = "PicShowPassword"
        Me.PicShowPassword.Size = New System.Drawing.Size(19, 19)
        Me.PicShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowPassword.TabIndex = 36
        Me.PicShowPassword.TabStop = False
        Me.PicShowPassword.Tag = ""
        '
        'TxtDBName
        '
        Me.TxtDBName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtDBName.Location = New System.Drawing.Point(20, 81)
        Me.TxtDBName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDBName.MaxLength = 300
        Me.TxtDBName.Name = "TxtDBName"
        Me.TxtDBName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDBName.Size = New System.Drawing.Size(322, 35)
        Me.TxtDBName.TabIndex = 34
        Me.TxtDBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(342, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(116, 28)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "كلمة المرور"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(342, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(116, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "اسم المستخدم"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(342, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(116, 28)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "قاعدة البيانات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(342, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "اسم السيرفر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Lbl.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Lbl.ForeColor = System.Drawing.Color.White
        Me.Lbl.Location = New System.Drawing.Point(3, 35)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl.Size = New System.Drawing.Size(481, 37)
        Me.Lbl.TabIndex = 23
        Me.Lbl.Tag = "Primary"
        Me.Lbl.Text = "ضبط إعدادات الإتصال للنظام"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnOK)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 303)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(467, 83)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(22, 29)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(203, 36)
        Me.BtnCancel.TabIndex = 31
        Me.BtnCancel.Tag = "Dark"
        Me.BtnCancel.Text = "خروج"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.FlatAppearance.BorderSize = 0
        Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOK.Location = New System.Drawing.Point(249, 29)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(203, 36)
        Me.BtnOK.TabIndex = 30
        Me.BtnOK.Tag = "Dark"
        Me.BtnOK.Text = "موافق"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 394)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 28)
        Me.Panel1.TabIndex = 464
        Me.Panel1.Tag = "Dark"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Lbl)
        Me.Panel2.Controls.Add(Me.PnlMenu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(487, 425)
        Me.Panel2.TabIndex = 465
        Me.Panel2.Tag = "Background"
        '
        'FrmResetCon
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(493, 431)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmResetCon"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "ضبط إعدادات الإتصال للنظام"
        Me.PnlMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtLoginPass As TextBox
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents TxtServerName As TextBox
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtDBName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PicShowPassword As PictureBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel2 As Panel
End Class
