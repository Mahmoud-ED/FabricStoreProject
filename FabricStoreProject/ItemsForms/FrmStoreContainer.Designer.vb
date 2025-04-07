<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStoreContainer
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
        Me.LblStore = New System.Windows.Forms.Label()
        Me.PnlStore = New System.Windows.Forms.Panel()
        Me.LblItemReport = New System.Windows.Forms.Label()
        Me.PnlItemReport = New System.Windows.Forms.Panel()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.PnlItem = New System.Windows.Forms.Panel()
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
        Me.PnlButtons.Controls.Add(Me.LblStore)
        Me.PnlButtons.Controls.Add(Me.PnlStore)
        Me.PnlButtons.Controls.Add(Me.LblItemReport)
        Me.PnlButtons.Controls.Add(Me.PnlItemReport)
        Me.PnlButtons.Controls.Add(Me.LblItem)
        Me.PnlButtons.Controls.Add(Me.PnlItem)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 4)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(996, 45)
        Me.PnlButtons.TabIndex = 66
        Me.PnlButtons.Tag = "Primary"
        '
        'LblStore
        '
        Me.LblStore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblStore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblStore.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStore.ForeColor = System.Drawing.Color.White
        Me.LblStore.Location = New System.Drawing.Point(230, 4)
        Me.LblStore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblStore.Name = "LblStore"
        Me.LblStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblStore.Size = New System.Drawing.Size(161, 28)
        Me.LblStore.TabIndex = 13
        Me.LblStore.Text = "المخزن"
        Me.LblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblStore.Visible = False
        '
        'PnlStore
        '
        Me.PnlStore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlStore.Location = New System.Drawing.Point(230, 33)
        Me.PnlStore.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlStore.Name = "PnlStore"
        Me.PnlStore.Size = New System.Drawing.Size(161, 4)
        Me.PnlStore.TabIndex = 12
        Me.PnlStore.Visible = False
        '
        'LblItemReport
        '
        Me.LblItemReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblItemReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblItemReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemReport.ForeColor = System.Drawing.Color.White
        Me.LblItemReport.Location = New System.Drawing.Point(418, 4)
        Me.LblItemReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemReport.Name = "LblItemReport"
        Me.LblItemReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblItemReport.Size = New System.Drawing.Size(161, 28)
        Me.LblItemReport.TabIndex = 11
        Me.LblItemReport.Text = "تقارير أصناف"
        Me.LblItemReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlItemReport
        '
        Me.PnlItemReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlItemReport.Location = New System.Drawing.Point(418, 33)
        Me.PnlItemReport.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlItemReport.Name = "PnlItemReport"
        Me.PnlItemReport.Size = New System.Drawing.Size(161, 4)
        Me.PnlItemReport.TabIndex = 10
        '
        'LblItem
        '
        Me.LblItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblItem.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItem.ForeColor = System.Drawing.Color.White
        Me.LblItem.Location = New System.Drawing.Point(606, 4)
        Me.LblItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblItem.Size = New System.Drawing.Size(161, 28)
        Me.LblItem.TabIndex = 9
        Me.LblItem.Text = "تسجيل أصناف"
        Me.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlItem
        '
        Me.PnlItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlItem.Location = New System.Drawing.Point(606, 33)
        Me.PnlItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlItem.Name = "PnlItem"
        Me.PnlItem.Size = New System.Drawing.Size(161, 4)
        Me.PnlItem.TabIndex = 8
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
        'FrmStoreContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 569)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStoreContainer"
        Me.Text = "المخزن"
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents LblStore As Label
    Friend WithEvents PnlStore As Panel
    Friend WithEvents LblItemReport As Label
    Friend WithEvents PnlItemReport As Panel
    Friend WithEvents LblItem As Label
    Friend WithEvents PnlItem As Panel
    Friend WithEvents Panel1 As Panel
End Class
