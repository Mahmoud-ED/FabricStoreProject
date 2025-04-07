<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerContainr
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
        Me.PnlAttachments = New System.Windows.Forms.Panel()
        Me.LblReport = New System.Windows.Forms.Label()
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.LblInfo = New System.Windows.Forms.Label()
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
        Me.PnlButtons.Controls.Add(Me.PnlAttachments)
        Me.PnlButtons.Controls.Add(Me.LblReport)
        Me.PnlButtons.Controls.Add(Me.PnlInfo)
        Me.PnlButtons.Controls.Add(Me.LblInfo)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 4)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(996, 45)
        Me.PnlButtons.TabIndex = 63
        Me.PnlButtons.Tag = "Primary"
        '
        'PnlAttachments
        '
        Me.PnlAttachments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlAttachments.BackColor = System.Drawing.Color.Transparent
        Me.PnlAttachments.Location = New System.Drawing.Point(272, 39)
        Me.PnlAttachments.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlAttachments.Name = "PnlAttachments"
        Me.PnlAttachments.Size = New System.Drawing.Size(243, 4)
        Me.PnlAttachments.TabIndex = 18
        '
        'LblReport
        '
        Me.LblReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblReport.Location = New System.Drawing.Point(272, -2)
        Me.LblReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblReport.Name = "LblReport"
        Me.LblReport.Size = New System.Drawing.Size(243, 47)
        Me.LblReport.TabIndex = 17
        Me.LblReport.Tag = "Primary"
        Me.LblReport.Text = "تقـاريـر الزبائن"
        Me.LblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInfo
        '
        Me.PnlInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlInfo.BackColor = System.Drawing.Color.Transparent
        Me.PnlInfo.Location = New System.Drawing.Point(533, 39)
        Me.PnlInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(243, 4)
        Me.PnlInfo.TabIndex = 14
        '
        'LblInfo
        '
        Me.LblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblInfo.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblInfo.Location = New System.Drawing.Point(533, -2)
        Me.LblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(243, 47)
        Me.LblInfo.TabIndex = 11
        Me.LblInfo.Tag = "Primary"
        Me.LblInfo.Text = "بـيانـات الزبائن"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'FrmCustomerContainr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 569)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCustomerContainr"
        Me.Text = "الزبائن"
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents PnlAttachments As Panel
    Friend WithEvents LblReport As Label
    Friend WithEvents PnlInfo As Panel
    Friend WithEvents LblInfo As Label
    Friend WithEvents Panel1 As Panel
End Class
