<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMangmentExpensesContainer
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.LblExpensesReport = New System.Windows.Forms.Label()
        Me.PnlExpensesReport = New System.Windows.Forms.Panel()
        Me.LblExpenses = New System.Windows.Forms.Label()
        Me.PnlExpenses = New System.Windows.Forms.Panel()
        Me.PnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 45)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1010, 563)
        Me.PnlMain.TabIndex = 7
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.LblExpensesReport)
        Me.PnlTop.Controls.Add(Me.PnlExpensesReport)
        Me.PnlTop.Controls.Add(Me.LblExpenses)
        Me.PnlTop.Controls.Add(Me.PnlExpenses)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1010, 45)
        Me.PnlTop.TabIndex = 6
        Me.PnlTop.Tag = "Primary"
        '
        'LblExpensesReport
        '
        Me.LblExpensesReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblExpensesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblExpensesReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpensesReport.ForeColor = System.Drawing.Color.White
        Me.LblExpensesReport.Location = New System.Drawing.Point(323, 3)
        Me.LblExpensesReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExpensesReport.Name = "LblExpensesReport"
        Me.LblExpensesReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblExpensesReport.Size = New System.Drawing.Size(167, 34)
        Me.LblExpensesReport.TabIndex = 3
        Me.LblExpensesReport.Text = "تقارير المصروفات"
        Me.LblExpensesReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlExpensesReport
        '
        Me.PnlExpensesReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlExpensesReport.Location = New System.Drawing.Point(324, 37)
        Me.PnlExpensesReport.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlExpensesReport.Name = "PnlExpensesReport"
        Me.PnlExpensesReport.Size = New System.Drawing.Size(167, 4)
        Me.PnlExpensesReport.TabIndex = 2
        '
        'LblExpenses
        '
        Me.LblExpenses.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblExpenses.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpenses.ForeColor = System.Drawing.Color.White
        Me.LblExpenses.Location = New System.Drawing.Point(520, 3)
        Me.LblExpenses.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExpenses.Name = "LblExpenses"
        Me.LblExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblExpenses.Size = New System.Drawing.Size(167, 34)
        Me.LblExpenses.TabIndex = 1
        Me.LblExpenses.Text = "المصروفات"
        Me.LblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlExpenses
        '
        Me.PnlExpenses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlExpenses.Location = New System.Drawing.Point(519, 37)
        Me.PnlExpenses.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlExpenses.Name = "PnlExpenses"
        Me.PnlExpenses.Size = New System.Drawing.Size(167, 4)
        Me.PnlExpenses.TabIndex = 0
        '
        'FrmMangmentExpensesContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 608)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMangmentExpensesContainer"
        Me.Text = "مصروفات العيادة"
        Me.PnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents LblExpensesReport As Label
    Friend WithEvents PnlExpensesReport As Panel
    Friend WithEvents LblExpenses As Label
    Friend WithEvents PnlExpenses As Panel
End Class
