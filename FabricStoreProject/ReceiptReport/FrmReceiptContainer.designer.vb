<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceiptContainer
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.LblCashing = New System.Windows.Forms.Label()
        Me.PnlCashing = New System.Windows.Forms.Panel()
        Me.LblReceipt = New System.Windows.Forms.Label()
        Me.PnlReceipt = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.SystemColors.Control
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 45)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(997, 507)
        Me.PnlMain.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 507)
        Me.Panel1.TabIndex = 12
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.LblCashing)
        Me.PnlTop.Controls.Add(Me.PnlCashing)
        Me.PnlTop.Controls.Add(Me.LblReceipt)
        Me.PnlTop.Controls.Add(Me.PnlReceipt)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(997, 45)
        Me.PnlTop.TabIndex = 10
        Me.PnlTop.Tag = "Primary"
        '
        'LblCashing
        '
        Me.LblCashing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCashing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCashing.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCashing.ForeColor = System.Drawing.Color.White
        Me.LblCashing.Location = New System.Drawing.Point(296, 5)
        Me.LblCashing.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCashing.Name = "LblCashing"
        Me.LblCashing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCashing.Size = New System.Drawing.Size(188, 28)
        Me.LblCashing.TabIndex = 7
        Me.LblCashing.Text = "ايصالات الصرف"
        Me.LblCashing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlCashing
        '
        Me.PnlCashing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlCashing.Location = New System.Drawing.Point(296, 38)
        Me.PnlCashing.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlCashing.Name = "PnlCashing"
        Me.PnlCashing.Size = New System.Drawing.Size(188, 4)
        Me.PnlCashing.TabIndex = 6
        '
        'LblReceipt
        '
        Me.LblReceipt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblReceipt.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceipt.ForeColor = System.Drawing.Color.White
        Me.LblReceipt.Location = New System.Drawing.Point(512, 5)
        Me.LblReceipt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblReceipt.Name = "LblReceipt"
        Me.LblReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblReceipt.Size = New System.Drawing.Size(188, 28)
        Me.LblReceipt.TabIndex = 1
        Me.LblReceipt.Text = "ايصالات القبض"
        Me.LblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlReceipt
        '
        Me.PnlReceipt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlReceipt.Location = New System.Drawing.Point(512, 38)
        Me.PnlReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlReceipt.Name = "PnlReceipt"
        Me.PnlReceipt.Size = New System.Drawing.Size(188, 4)
        Me.PnlReceipt.TabIndex = 0
        '
        'FrmReceiptContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 552)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReceiptContainer"
        Me.Text = "تقارير الايصالات"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents LblCashing As Label
    Friend WithEvents PnlCashing As Panel
    Friend WithEvents LblReceipt As Label
    Friend WithEvents PnlReceipt As Panel
    Friend WithEvents Panel1 As Panel
End Class
