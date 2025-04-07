<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettingsContainer
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.PnlCenterInfoSettings = New System.Windows.Forms.Panel()
        Me.LblCenterInfoSettings = New System.Windows.Forms.Label()
        Me.PnlBackupSettings = New System.Windows.Forms.Panel()
        Me.LblBackupSettings = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.AutoScroll = True
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1002, 537)
        Me.PnlMain.TabIndex = 57
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 2
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "معلومة"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 5)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1002, 537)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage2"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 45)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1010, 546)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.PnlMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 5)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1002, 537)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'PnlButtons
        '
        Me.PnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlButtons.Controls.Add(Me.PnlCenterInfoSettings)
        Me.PnlButtons.Controls.Add(Me.LblCenterInfoSettings)
        Me.PnlButtons.Controls.Add(Me.PnlBackupSettings)
        Me.PnlButtons.Controls.Add(Me.LblBackupSettings)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 0)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(1010, 45)
        Me.PnlButtons.TabIndex = 97
        Me.PnlButtons.Tag = "Primary"
        '
        'PnlCenterInfoSettings
        '
        Me.PnlCenterInfoSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlCenterInfoSettings.BackColor = System.Drawing.Color.Transparent
        Me.PnlCenterInfoSettings.Location = New System.Drawing.Point(234, 39)
        Me.PnlCenterInfoSettings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PnlCenterInfoSettings.Name = "PnlCenterInfoSettings"
        Me.PnlCenterInfoSettings.Size = New System.Drawing.Size(243, 4)
        Me.PnlCenterInfoSettings.TabIndex = 19
        '
        'LblCenterInfoSettings
        '
        Me.LblCenterInfoSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCenterInfoSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCenterInfoSettings.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCenterInfoSettings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCenterInfoSettings.Location = New System.Drawing.Point(232, 0)
        Me.LblCenterInfoSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCenterInfoSettings.Name = "LblCenterInfoSettings"
        Me.LblCenterInfoSettings.Size = New System.Drawing.Size(243, 45)
        Me.LblCenterInfoSettings.TabIndex = 18
        Me.LblCenterInfoSettings.Text = "ضبط بيانات المتجر"
        Me.LblCenterInfoSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBackupSettings
        '
        Me.PnlBackupSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlBackupSettings.BackColor = System.Drawing.Color.White
        Me.PnlBackupSettings.Location = New System.Drawing.Point(533, 39)
        Me.PnlBackupSettings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PnlBackupSettings.Name = "PnlBackupSettings"
        Me.PnlBackupSettings.Size = New System.Drawing.Size(243, 4)
        Me.PnlBackupSettings.TabIndex = 13
        '
        'LblBackupSettings
        '
        Me.LblBackupSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBackupSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBackupSettings.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBackupSettings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblBackupSettings.Location = New System.Drawing.Point(536, 0)
        Me.LblBackupSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBackupSettings.Name = "LblBackupSettings"
        Me.LblBackupSettings.Size = New System.Drawing.Size(243, 45)
        Me.LblBackupSettings.TabIndex = 10
        Me.LblBackupSettings.Text = "ضبط إعدادات النسخ الإحتياطي"
        Me.LblBackupSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSettingsContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSettingsContainer"
        Me.Text = "إعدادات النظام"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents PnlBackupSettings As Panel
    Friend WithEvents LblBackupSettings As Label
    Friend WithEvents PnlCenterInfoSettings As Panel
    Friend WithEvents LblCenterInfoSettings As Label
End Class
