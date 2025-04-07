<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFinanceType
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinanceType))
        Me.PnlFinanceType = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DGVFinanceType = New System.Windows.Forms.DataGridView()
        Me.TLPBtns = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFinanceType = New System.Windows.Forms.TextBox()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlFinanceType.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGVFinanceType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPBtns.SuspendLayout()
        Me.PnlTitel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlFinanceType
        '
        Me.PnlFinanceType.BackColor = System.Drawing.SystemColors.Control
        Me.PnlFinanceType.Controls.Add(Me.Panel5)
        Me.PnlFinanceType.Controls.Add(Me.TLPBtns)
        Me.PnlFinanceType.Controls.Add(Me.Label3)
        Me.PnlFinanceType.Controls.Add(Me.TxtDescription)
        Me.PnlFinanceType.Controls.Add(Me.Label1)
        Me.PnlFinanceType.Controls.Add(Me.TxtFinanceType)
        Me.PnlFinanceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlFinanceType.Location = New System.Drawing.Point(0, 28)
        Me.PnlFinanceType.Name = "PnlFinanceType"
        Me.PnlFinanceType.Size = New System.Drawing.Size(451, 450)
        Me.PnlFinanceType.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.DGVFinanceType)
        Me.Panel5.Location = New System.Drawing.Point(16, 145)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(419, 290)
        Me.Panel5.TabIndex = 0
        '
        'DGVFinanceType
        '
        Me.DGVFinanceType.AllowUserToAddRows = False
        Me.DGVFinanceType.AllowUserToDeleteRows = False
        Me.DGVFinanceType.AllowUserToResizeRows = False
        Me.DGVFinanceType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVFinanceType.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVFinanceType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVFinanceType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVFinanceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVFinanceType.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVFinanceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVFinanceType.EnableHeadersVisualStyles = False
        Me.DGVFinanceType.Location = New System.Drawing.Point(0, 0)
        Me.DGVFinanceType.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVFinanceType.MultiSelect = False
        Me.DGVFinanceType.Name = "DGVFinanceType"
        Me.DGVFinanceType.ReadOnly = True
        Me.DGVFinanceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVFinanceType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVFinanceType.RowHeadersVisible = False
        Me.DGVFinanceType.RowHeadersWidth = 51
        Me.DGVFinanceType.RowTemplate.DividerHeight = 2
        Me.DGVFinanceType.RowTemplate.Height = 32
        Me.DGVFinanceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFinanceType.Size = New System.Drawing.Size(419, 290)
        Me.DGVFinanceType.TabIndex = 6
        Me.DGVFinanceType.Tag = "Dark-SelectionVisible"
        '
        'TLPBtns
        '
        Me.TLPBtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPBtns.ColumnCount = 4
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.Controls.Add(Me.BtnRefresh, 3, 0)
        Me.TLPBtns.Controls.Add(Me.BtnDelete, 2, 0)
        Me.TLPBtns.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TLPBtns.Controls.Add(Me.BtnSave, 1, 0)
        Me.TLPBtns.Location = New System.Drawing.Point(16, 96)
        Me.TLPBtns.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBtns.Name = "TLPBtns"
        Me.TLPBtns.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPBtns.RowCount = 1
        Me.TLPBtns.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPBtns.Size = New System.Drawing.Size(419, 41)
        Me.TLPBtns.TabIndex = 20
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.Location = New System.Drawing.Point(2, 2)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefresh.Size = New System.Drawing.Size(103, 37)
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnRefresh, "تحديث")
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(109, 2)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(100, 37)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Tag = "Dark"
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "حذف")
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.Location = New System.Drawing.Point(317, 2)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAdd.Size = New System.Drawing.Size(100, 37)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Tag = "Dark"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnAdd, "إضافة")
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(213, 2)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "تعديل"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnSave, "تعديل")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(358, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "الوصف"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.White
        Me.TxtDescription.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(16, 50)
        Me.TxtDescription.MaxLength = 200
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDescription.Size = New System.Drawing.Size(341, 35)
        Me.TxtDescription.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(358, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اسم البند"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtFinanceType
        '
        Me.TxtFinanceType.BackColor = System.Drawing.Color.White
        Me.TxtFinanceType.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.TxtFinanceType.Location = New System.Drawing.Point(16, 10)
        Me.TxtFinanceType.MaxLength = 200
        Me.TxtFinanceType.Name = "TxtFinanceType"
        Me.TxtFinanceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFinanceType.Size = New System.Drawing.Size(341, 35)
        Me.TxtFinanceType.TabIndex = 0
        '
        'PnlTitel
        '
        Me.PnlTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlTitel.Controls.Add(Me.BtnClose)
        Me.PnlTitel.Controls.Add(Me.LblTitel)
        Me.PnlTitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitel.ForeColor = System.Drawing.Color.Transparent
        Me.PnlTitel.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitel.Name = "PnlTitel"
        Me.PnlTitel.Size = New System.Drawing.Size(451, 28)
        Me.PnlTitel.TabIndex = 7
        Me.PnlTitel.TabStop = True
        Me.PnlTitel.Tag = "Dark"
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
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(159, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(133, 28)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "بيانات البند"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmFinanceType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 478)
        Me.Controls.Add(Me.PnlFinanceType)
        Me.Controls.Add(Me.PnlTitel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFinanceType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بيانات البند"
        Me.PnlFinanceType.ResumeLayout(False)
        Me.PnlFinanceType.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DGVFinanceType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPBtns.ResumeLayout(False)
        Me.PnlTitel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlFinanceType As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFinanceType As TextBox
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents LblTitel As Label
    Friend WithEvents TLPBtns As TableLayoutPanel
    Friend WithEvents DGVFinanceType As DataGridView
    Friend WithEvents BtnClose As Button
End Class
