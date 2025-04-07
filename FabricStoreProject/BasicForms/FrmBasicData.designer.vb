<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBasicData
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlServices = New System.Windows.Forms.Panel()
        Me.PnlCountry = New System.Windows.Forms.Panel()
        Me.PnlPaymentType = New System.Windows.Forms.Panel()
        Me.PnlExpensesType = New System.Windows.Forms.Panel()
        Me.PnlBank = New System.Windows.Forms.Panel()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.LblCountry = New System.Windows.Forms.Label()
        Me.LblServices = New System.Windows.Forms.Label()
        Me.LblExpensesType = New System.Windows.Forms.Label()
        Me.LblBank = New System.Windows.Forms.Label()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.PnlServices)
        Me.PnlTop.Controls.Add(Me.PnlCountry)
        Me.PnlTop.Controls.Add(Me.PnlPaymentType)
        Me.PnlTop.Controls.Add(Me.PnlExpensesType)
        Me.PnlTop.Controls.Add(Me.PnlBank)
        Me.PnlTop.Controls.Add(Me.LblPaymentType)
        Me.PnlTop.Controls.Add(Me.LblCountry)
        Me.PnlTop.Controls.Add(Me.LblServices)
        Me.PnlTop.Controls.Add(Me.LblExpensesType)
        Me.PnlTop.Controls.Add(Me.LblBank)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1040, 45)
        Me.PnlTop.TabIndex = 985
        Me.PnlTop.Tag = "Primary"
        '
        'PnlServices
        '
        Me.PnlServices.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlServices.Location = New System.Drawing.Point(285, 39)
        Me.PnlServices.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlServices.Name = "PnlServices"
        Me.PnlServices.Size = New System.Drawing.Size(131, 4)
        Me.PnlServices.TabIndex = 10
        '
        'PnlCountry
        '
        Me.PnlCountry.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlCountry.Location = New System.Drawing.Point(455, 37)
        Me.PnlCountry.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlCountry.Name = "PnlCountry"
        Me.PnlCountry.Size = New System.Drawing.Size(131, 4)
        Me.PnlCountry.TabIndex = 10
        '
        'PnlPaymentType
        '
        Me.PnlPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlPaymentType.Location = New System.Drawing.Point(625, 37)
        Me.PnlPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlPaymentType.Name = "PnlPaymentType"
        Me.PnlPaymentType.Size = New System.Drawing.Size(131, 4)
        Me.PnlPaymentType.TabIndex = 10
        '
        'PnlExpensesType
        '
        Me.PnlExpensesType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlExpensesType.Location = New System.Drawing.Point(115, 37)
        Me.PnlExpensesType.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlExpensesType.Name = "PnlExpensesType"
        Me.PnlExpensesType.Size = New System.Drawing.Size(131, 4)
        Me.PnlExpensesType.TabIndex = 10
        '
        'PnlBank
        '
        Me.PnlBank.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlBank.Location = New System.Drawing.Point(795, 38)
        Me.PnlBank.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlBank.Name = "PnlBank"
        Me.PnlBank.Size = New System.Drawing.Size(131, 4)
        Me.PnlBank.TabIndex = 9
        '
        'LblPaymentType
        '
        Me.LblPaymentType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPaymentType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblPaymentType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblPaymentType.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblPaymentType.Location = New System.Drawing.Point(625, 5)
        Me.LblPaymentType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(131, 30)
        Me.LblPaymentType.TabIndex = 1
        Me.LblPaymentType.Tag = "Primary"
        Me.LblPaymentType.Text = "أنواع الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCountry
        '
        Me.LblCountry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCountry.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCountry.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCountry.Location = New System.Drawing.Point(455, 5)
        Me.LblCountry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCountry.Name = "LblCountry"
        Me.LblCountry.Size = New System.Drawing.Size(131, 30)
        Me.LblCountry.TabIndex = 3
        Me.LblCountry.Tag = "Primary"
        Me.LblCountry.Text = "البلدان"
        Me.LblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblServices
        '
        Me.LblServices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblServices.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServices.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblServices.Location = New System.Drawing.Point(285, 5)
        Me.LblServices.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblServices.Name = "LblServices"
        Me.LblServices.Size = New System.Drawing.Size(131, 30)
        Me.LblServices.TabIndex = 4
        Me.LblServices.Tag = "Primary"
        Me.LblServices.Text = "خدمات الخياط"
        Me.LblServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExpensesType
        '
        Me.LblExpensesType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblExpensesType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblExpensesType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblExpensesType.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpensesType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblExpensesType.Location = New System.Drawing.Point(115, 5)
        Me.LblExpensesType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExpensesType.Name = "LblExpensesType"
        Me.LblExpensesType.Size = New System.Drawing.Size(131, 30)
        Me.LblExpensesType.TabIndex = 5
        Me.LblExpensesType.Tag = "Primary"
        Me.LblExpensesType.Text = "أنواع المصروفات"
        Me.LblExpensesType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBank
        '
        Me.LblBank.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBank.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblBank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBank.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBank.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblBank.Location = New System.Drawing.Point(795, 5)
        Me.LblBank.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(131, 30)
        Me.LblBank.TabIndex = 0
        Me.LblBank.Tag = "Primary"
        Me.LblBank.Text = "المصارف"
        Me.LblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlMain.BackColor = System.Drawing.SystemColors.Control
        Me.PnlMain.Location = New System.Drawing.Point(295, 24)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.PnlMain.Size = New System.Drawing.Size(451, 487)
        Me.PnlMain.TabIndex = 986
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.PnlMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 505)
        Me.Panel1.TabIndex = 0
        '
        'FrmBasicData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1040, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBasicData"
        Me.Text = "البيانات الأساسية"
        Me.PnlTop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlTop As Panel
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents LblBank As Label
    Friend WithEvents LblCountry As Label
    Friend WithEvents LblServices As Label
    Friend WithEvents LblExpensesType As Label
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlServices As Panel
    Friend WithEvents PnlCountry As Panel
    Friend WithEvents PnlPaymentType As Panel
    Friend WithEvents PnlExpensesType As Panel
    Friend WithEvents PnlBank As Panel
    Friend WithEvents Panel1 As Panel
End Class
