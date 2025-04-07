<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasesContainer
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
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.LblCashing = New System.Windows.Forms.Label()
        Me.PnlCashing = New System.Windows.Forms.Panel()
        Me.LblInvoiceReport = New System.Windows.Forms.Label()
        Me.PnlInvoReport = New System.Windows.Forms.Panel()
        Me.LblInvoice = New System.Windows.Forms.Label()
        Me.PnlInvoice = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.AutoScroll = True
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 49)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(996, 520)
        Me.PnlMain.TabIndex = 61
        '
        'PnlButtons
        '
        Me.PnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlButtons.Controls.Add(Me.LblCashing)
        Me.PnlButtons.Controls.Add(Me.PnlCashing)
        Me.PnlButtons.Controls.Add(Me.LblInvoiceReport)
        Me.PnlButtons.Controls.Add(Me.PnlInvoReport)
        Me.PnlButtons.Controls.Add(Me.LblInvoice)
        Me.PnlButtons.Controls.Add(Me.PnlInvoice)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 4)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(996, 45)
        Me.PnlButtons.TabIndex = 63
        Me.PnlButtons.Tag = "Primary"
        '
        'LblCashing
        '
        Me.LblCashing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCashing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCashing.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCashing.ForeColor = System.Drawing.Color.White
        Me.LblCashing.Location = New System.Drawing.Point(143, 4)
        Me.LblCashing.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCashing.Name = "LblCashing"
        Me.LblCashing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCashing.Size = New System.Drawing.Size(161, 28)
        Me.LblCashing.TabIndex = 13
        Me.LblCashing.Text = "ايصالات الصرف"
        Me.LblCashing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCashing.Visible = False
        '
        'PnlCashing
        '
        Me.PnlCashing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlCashing.Location = New System.Drawing.Point(143, 33)
        Me.PnlCashing.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlCashing.Name = "PnlCashing"
        Me.PnlCashing.Size = New System.Drawing.Size(161, 4)
        Me.PnlCashing.TabIndex = 12
        Me.PnlCashing.Visible = False
        '
        'LblInvoiceReport
        '
        Me.LblInvoiceReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInvoiceReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblInvoiceReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoiceReport.ForeColor = System.Drawing.Color.White
        Me.LblInvoiceReport.Location = New System.Drawing.Point(316, 4)
        Me.LblInvoiceReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInvoiceReport.Name = "LblInvoiceReport"
        Me.LblInvoiceReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInvoiceReport.Size = New System.Drawing.Size(161, 28)
        Me.LblInvoiceReport.TabIndex = 11
        Me.LblInvoiceReport.Text = "تقارير المشتريات"
        Me.LblInvoiceReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInvoReport
        '
        Me.PnlInvoReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlInvoReport.Location = New System.Drawing.Point(316, 33)
        Me.PnlInvoReport.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlInvoReport.Name = "PnlInvoReport"
        Me.PnlInvoReport.Size = New System.Drawing.Size(161, 4)
        Me.PnlInvoReport.TabIndex = 10
        '
        'LblInvoice
        '
        Me.LblInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblInvoice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoice.ForeColor = System.Drawing.Color.White
        Me.LblInvoice.Location = New System.Drawing.Point(520, 4)
        Me.LblInvoice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInvoice.Name = "LblInvoice"
        Me.LblInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInvoice.Size = New System.Drawing.Size(161, 28)
        Me.LblInvoice.TabIndex = 9
        Me.LblInvoice.Text = "تسجيل المشتريات"
        Me.LblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInvoice
        '
        Me.PnlInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlInvoice.Location = New System.Drawing.Point(520, 33)
        Me.PnlInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlInvoice.Name = "PnlInvoice"
        Me.PnlInvoice.Size = New System.Drawing.Size(161, 4)
        Me.PnlInvoice.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 4)
        Me.Panel1.TabIndex = 62
        '
        'FrmPurchasesContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 569)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchasesContainer"
        Me.Text = "المشتريات"
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblInvoiceReport As Label
    Friend WithEvents PnlInvoReport As Panel
    Friend WithEvents LblInvoice As Label
    Friend WithEvents PnlInvoice As Panel
    Friend WithEvents LblCashing As Label
    Friend WithEvents PnlCashing As Panel
End Class
