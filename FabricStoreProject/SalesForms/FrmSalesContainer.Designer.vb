<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesContainer
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
        Me.LblCustomerOrders = New System.Windows.Forms.Label()
        Me.PnlCustomerOrders = New System.Windows.Forms.Panel()
        Me.LblDebts = New System.Windows.Forms.Label()
        Me.PnlDebts = New System.Windows.Forms.Panel()
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
        Me.PnlMain.TabIndex = 64
        '
        'PnlButtons
        '
        Me.PnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlButtons.Controls.Add(Me.LblCustomerOrders)
        Me.PnlButtons.Controls.Add(Me.PnlCustomerOrders)
        Me.PnlButtons.Controls.Add(Me.LblDebts)
        Me.PnlButtons.Controls.Add(Me.PnlDebts)
        Me.PnlButtons.Controls.Add(Me.LblInvoiceReport)
        Me.PnlButtons.Controls.Add(Me.PnlInvoReport)
        Me.PnlButtons.Controls.Add(Me.LblInvoice)
        Me.PnlButtons.Controls.Add(Me.PnlInvoice)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 4)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(996, 45)
        Me.PnlButtons.TabIndex = 66
        Me.PnlButtons.Tag = "Primary"
        '
        'LblCustomerOrders
        '
        Me.LblCustomerOrders.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCustomerOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCustomerOrders.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerOrders.ForeColor = System.Drawing.Color.White
        Me.LblCustomerOrders.Location = New System.Drawing.Point(141, 8)
        Me.LblCustomerOrders.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCustomerOrders.Name = "LblCustomerOrders"
        Me.LblCustomerOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCustomerOrders.Size = New System.Drawing.Size(161, 28)
        Me.LblCustomerOrders.TabIndex = 17
        Me.LblCustomerOrders.Text = "طلبات الزبائن"
        Me.LblCustomerOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlCustomerOrders
        '
        Me.PnlCustomerOrders.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlCustomerOrders.Location = New System.Drawing.Point(143, 35)
        Me.PnlCustomerOrders.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlCustomerOrders.Name = "PnlCustomerOrders"
        Me.PnlCustomerOrders.Size = New System.Drawing.Size(161, 4)
        Me.PnlCustomerOrders.TabIndex = 16
        '
        'LblDebts
        '
        Me.LblDebts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDebts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDebts.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebts.ForeColor = System.Drawing.Color.White
        Me.LblDebts.Location = New System.Drawing.Point(335, 8)
        Me.LblDebts.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDebts.Name = "LblDebts"
        Me.LblDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDebts.Size = New System.Drawing.Size(161, 28)
        Me.LblDebts.TabIndex = 13
        Me.LblDebts.Text = "حساب الزبائن"
        Me.LblDebts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlDebts
        '
        Me.PnlDebts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlDebts.Location = New System.Drawing.Point(335, 35)
        Me.PnlDebts.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlDebts.Name = "PnlDebts"
        Me.PnlDebts.Size = New System.Drawing.Size(161, 4)
        Me.PnlDebts.TabIndex = 12
        '
        'LblInvoiceReport
        '
        Me.LblInvoiceReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInvoiceReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblInvoiceReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoiceReport.ForeColor = System.Drawing.Color.White
        Me.LblInvoiceReport.Location = New System.Drawing.Point(520, 8)
        Me.LblInvoiceReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInvoiceReport.Name = "LblInvoiceReport"
        Me.LblInvoiceReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInvoiceReport.Size = New System.Drawing.Size(161, 28)
        Me.LblInvoiceReport.TabIndex = 11
        Me.LblInvoiceReport.Text = "تقارير المبيعات"
        Me.LblInvoiceReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInvoReport
        '
        Me.PnlInvoReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlInvoReport.Location = New System.Drawing.Point(519, 35)
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
        Me.LblInvoice.Location = New System.Drawing.Point(705, 8)
        Me.LblInvoice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInvoice.Name = "LblInvoice"
        Me.LblInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInvoice.Size = New System.Drawing.Size(161, 28)
        Me.LblInvoice.TabIndex = 9
        Me.LblInvoice.Text = "تسجيل المبيعات"
        Me.LblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInvoice
        '
        Me.PnlInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlInvoice.Location = New System.Drawing.Point(703, 35)
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
        Me.Panel1.TabIndex = 65
        '
        'FrmSalesContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 569)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSalesContainer"
        Me.Text = "المبيعات"
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents LblDebts As Label
    Friend WithEvents PnlDebts As Panel
    Friend WithEvents LblInvoiceReport As Label
    Friend WithEvents PnlInvoReport As Panel
    Friend WithEvents LblInvoice As Label
    Friend WithEvents PnlInvoice As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCustomerOrders As Label
    Friend WithEvents PnlCustomerOrders As Panel
End Class
