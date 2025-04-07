<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ChkShowPass = New System.Windows.Forms.CheckBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PnlMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-1, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(657, 34)
        Me.Label7.TabIndex = 438
        Me.Label7.Tag = "Primary"
        Me.Label7.Text = "منظومة المتجر"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(655, 28)
        Me.PnlMenu.TabIndex = 439
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(595, -17)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(11, 460)
        Me.Panel8.TabIndex = 442
        Me.Panel8.Tag = "Dark"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(612, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 458)
        Me.Panel2.TabIndex = 441
        Me.Panel2.Tag = "Primary"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(628, -53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 511)
        Me.Panel3.TabIndex = 440
        Me.Panel3.Tag = "Dark"
        '
        'LblPassword
        '
        Me.LblPassword.BackColor = System.Drawing.Color.White
        Me.LblPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblPassword.ForeColor = System.Drawing.Color.Gray
        Me.LblPassword.Location = New System.Drawing.Point(387, 240)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(130, 29)
        Me.LblPassword.TabIndex = 452
        Me.LblPassword.Text = "كلمـــة المــــــرور"
        Me.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblUserName
        '
        Me.LblUserName.BackColor = System.Drawing.Color.White
        Me.LblUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblUserName.ForeColor = System.Drawing.Color.Gray
        Me.LblUserName.Location = New System.Drawing.Point(387, 168)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(130, 32)
        Me.LblUserName.TabIndex = 451
        Me.LblUserName.Text = "اسم المستخدم"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbUserName
        '
        Me.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserName.BackColor = System.Drawing.Color.White
        Me.CmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUserName.FormattingEnabled = True
        Me.CmbUserName.Location = New System.Drawing.Point(257, 165)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbUserName.Size = New System.Drawing.Size(263, 36)
        Me.CmbUserName.TabIndex = 447
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(255, 272)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(265, 4)
        Me.Panel7.TabIndex = 449
        Me.Panel7.Tag = "Primary"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(257, 200)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(263, 4)
        Me.Panel6.TabIndex = 448
        Me.Panel6.Tag = "Primary"
        '
        'LblMessage
        '
        Me.LblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblMessage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.White
        Me.LblMessage.Location = New System.Drawing.Point(0, 0)
        Me.LblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(655, 28)
        Me.LblMessage.TabIndex = 458
        Me.LblMessage.Text = "كلمة المرور أو اسم المستخدم غير صحيح"
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMessage.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LblMessage)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 442)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(655, 28)
        Me.Panel4.TabIndex = 459
        Me.Panel4.Tag = "Dark"
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(255, 240)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPassword.Size = New System.Drawing.Size(265, 31)
        Me.TxtPassword.TabIndex = 460
        Me.TxtPassword.Tag = "0"
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'ChkShowPass
        '
        Me.ChkShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkShowPass.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowPass.ForeColor = System.Drawing.Color.Gray
        Me.ChkShowPass.Location = New System.Drawing.Point(400, 295)
        Me.ChkShowPass.Name = "ChkShowPass"
        Me.ChkShowPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShowPass.Size = New System.Drawing.Size(115, 26)
        Me.ChkShowPass.TabIndex = 461
        Me.ChkShowPass.Text = "عرض كلمة المرور"
        Me.ChkShowPass.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.FlatAppearance.BorderSize = 0
        Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOK.Location = New System.Drawing.Point(398, 349)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(160, 36)
        Me.BtnOK.TabIndex = 32
        Me.BtnOK.Tag = "Dark"
        Me.BtnOK.Text = "دخول"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(216, 349)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(160, 36)
        Me.BtnCancel.TabIndex = 33
        Me.BtnCancel.Tag = "Dark"
        Me.BtnCancel.Text = "خروج"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.White
        Me.PicLogo.Image = Global.FabricStoreProject.My.Resources.Resources.NoImage
        Me.PicLogo.Location = New System.Drawing.Point(58, 165)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(155, 183)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.TabIndex = 429
        Me.PicLogo.TabStop = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(655, 470)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.ChkShowPass)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.CmbUserName)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PicLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الدخول للنظام"
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.PnlMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents CmbUserName As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents LblMessage As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents ChkShowPass As CheckBox
    Friend WithEvents BtnClose As Button
End Class
