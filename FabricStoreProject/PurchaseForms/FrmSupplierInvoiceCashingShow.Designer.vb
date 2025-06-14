<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierInvoiceCashingShow
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SSLMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSLMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 649)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip1.TabIndex = 416
        Me.StatusStrip1.Tag = "Dark"
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SSLMessage
        '
        Me.SSLMessage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.SSLMessage.ForeColor = System.Drawing.Color.White
        Me.SSLMessage.Name = "SSLMessage"
        Me.SSLMessage.Size = New System.Drawing.Size(92, 28)
        Me.SSLMessage.Text = "تأكيد الحفظ"
        Me.SSLMessage.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        Me.Timer1.Tag = "0"
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
        Me.BtnClose.TabIndex = 61
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblTitle
        '
        Me.LblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(373, 0)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTitle.Size = New System.Drawing.Size(245, 29)
        Me.LblTitle.TabIndex = 60
        Me.LblTitle.Text = "إيصال صرف"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMain
        '
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 31)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlMain.Size = New System.Drawing.Size(990, 612)
        Me.PnlMain.TabIndex = 415
        Me.PnlMain.Tag = "Background"
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Controls.Add(Me.LblTitle)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(3, 3)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(990, 28)
        Me.PnlMenu.TabIndex = 410
        Me.PnlMenu.Tag = "Dark"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PnlMain)
        Me.Panel1.Controls.Add(Me.PnlMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(996, 646)
        Me.Panel1.TabIndex = 417
        Me.Panel1.Tag = "Background"
        '
        'FrmSupplierInvoiceCashingShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1002, 674)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSupplierInvoiceCashingShow"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "ايصال دفع"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SSLMessage As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Panel1 As Panel
End Class
