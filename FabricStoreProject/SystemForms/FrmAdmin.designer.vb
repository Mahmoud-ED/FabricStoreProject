<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PicShowPassword = New System.Windows.Forms.PictureBox()
        Me.TxtAdmin = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicShowPassword)
        Me.GroupBox1.Controls.Add(Me.TxtAdmin)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(466, 167)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الدخول"
        '
        'PicShowPassword
        '
        Me.PicShowPassword.BackColor = System.Drawing.Color.White
        Me.PicShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowPassword.Image = CType(resources.GetObject("PicShowPassword.Image"), System.Drawing.Image)
        Me.PicShowPassword.Location = New System.Drawing.Point(43, 110)
        Me.PicShowPassword.Name = "PicShowPassword"
        Me.PicShowPassword.Size = New System.Drawing.Size(19, 19)
        Me.PicShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowPassword.TabIndex = 33
        Me.PicShowPassword.TabStop = False
        Me.PicShowPassword.Tag = ""
        '
        'TxtAdmin
        '
        Me.TxtAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAdmin.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtAdmin.Location = New System.Drawing.Point(36, 48)
        Me.TxtAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAdmin.MaxLength = 200
        Me.TxtAdmin.Name = "TxtAdmin"
        Me.TxtAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAdmin.Size = New System.Drawing.Size(299, 35)
        Me.TxtAdmin.TabIndex = 0
        Me.TxtAdmin.Tag = "2"
        Me.TxtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPassword.Location = New System.Drawing.Point(36, 105)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.MaxLength = 20
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPassword.Size = New System.Drawing.Size(299, 35)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.Tag = "2"
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(342, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(110, 28)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "كلمة المرور"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(342, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(110, 28)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "اسم المستخدم"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnOK)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 241)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(466, 84)
        Me.GroupBox2.TabIndex = 12
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
        Me.BtnCancel.Location = New System.Drawing.Point(22, 31)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(203, 36)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Tag = "Dark"
        Me.BtnCancel.Text = "إغلاق"
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
        Me.BtnOK.Location = New System.Drawing.Point(249, 31)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOK.Size = New System.Drawing.Size(203, 36)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Tag = "Dark"
        Me.BtnOK.Text = "موافق"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 335)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 28)
        Me.Panel1.TabIndex = 15
        Me.Panel1.TabStop = True
        Me.Panel1.Tag = "Dark"
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
        Me.PnlMenu.TabIndex = 14
        Me.PnlMenu.TabStop = True
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
        Me.Lbl.Location = New System.Drawing.Point(3, 36)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl.Size = New System.Drawing.Size(481, 37)
        Me.Lbl.TabIndex = 13
        Me.Lbl.Tag = "Primary"
        Me.Lbl.Text = "تسجيل الدخول كمدير للنظام"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PnlMenu)
        Me.Panel2.Controls.Add(Me.Lbl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(487, 366)
        Me.Panel2.TabIndex = 16
        Me.Panel2.Tag = "Background"
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(493, 372)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAdmin"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "تسجيل الدخول كمدير للنظام"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.PnlMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PicShowPassword As PictureBox
    Friend WithEvents TxtAdmin As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Lbl As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel2 As Panel
End Class
