<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategory))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlCategory = New System.Windows.Forms.Panel()
        Me.TLPBtns = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DGVCategory = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCategory = New System.Windows.Forms.TextBox()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlCategory.SuspendLayout()
        Me.TLPBtns.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGVCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlCategory
        '
        Me.PnlCategory.BackColor = System.Drawing.SystemColors.Control
        Me.PnlCategory.Controls.Add(Me.TLPBtns)
        Me.PnlCategory.Controls.Add(Me.Panel5)
        Me.PnlCategory.Controls.Add(Me.Label1)
        Me.PnlCategory.Controls.Add(Me.TxtCategory)
        Me.PnlCategory.Controls.Add(Me.PnlTitel)
        Me.PnlCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCategory.Location = New System.Drawing.Point(3, 3)
        Me.PnlCategory.Name = "PnlCategory"
        Me.PnlCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlCategory.Size = New System.Drawing.Size(445, 435)
        Me.PnlCategory.TabIndex = 0
        Me.PnlCategory.Tag = "Background"
        '
        'TLPBtns
        '
        Me.TLPBtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPBtns.ColumnCount = 7
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBtns.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBtns.Controls.Add(Me.BtnRefresh, 6, 0)
        Me.TLPBtns.Controls.Add(Me.BtnDelete, 4, 0)
        Me.TLPBtns.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TLPBtns.Controls.Add(Me.BtnSave, 2, 0)
        Me.TLPBtns.Location = New System.Drawing.Point(11, 87)
        Me.TLPBtns.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBtns.Name = "TLPBtns"
        Me.TLPBtns.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPBtns.RowCount = 1
        Me.TLPBtns.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPBtns.Size = New System.Drawing.Size(422, 41)
        Me.TLPBtns.TabIndex = 3
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
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 37)
        Me.BtnRefresh.TabIndex = 4
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
        Me.BtnDelete.Location = New System.Drawing.Point(110, 2)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(94, 37)
        Me.BtnDelete.TabIndex = 3
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
        Me.BtnAdd.Location = New System.Drawing.Point(326, 2)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAdd.Size = New System.Drawing.Size(94, 37)
        Me.BtnAdd.TabIndex = 1
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
        Me.BtnSave.Location = New System.Drawing.Point(218, 2)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(94, 37)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "تعديل"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnSave, "تعديل")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.DGVCategory)
        Me.Panel5.Location = New System.Drawing.Point(11, 142)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(422, 281)
        Me.Panel5.TabIndex = 0
        '
        'DGVCategory
        '
        Me.DGVCategory.AllowUserToAddRows = False
        Me.DGVCategory.AllowUserToDeleteRows = False
        Me.DGVCategory.AllowUserToResizeRows = False
        Me.DGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCategory.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCategory.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCategory.EnableHeadersVisualStyles = False
        Me.DGVCategory.Location = New System.Drawing.Point(0, 0)
        Me.DGVCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCategory.MultiSelect = False
        Me.DGVCategory.Name = "DGVCategory"
        Me.DGVCategory.ReadOnly = True
        Me.DGVCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCategory.RowHeadersVisible = False
        Me.DGVCategory.RowHeadersWidth = 51
        Me.DGVCategory.RowTemplate.DividerHeight = 2
        Me.DGVCategory.RowTemplate.Height = 32
        Me.DGVCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCategory.Size = New System.Drawing.Size(422, 281)
        Me.DGVCategory.TabIndex = 7
        Me.DGVCategory.Tag = "Dark-SelectionVisible"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(327, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اسم التصنيف"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCategory
        '
        Me.TxtCategory.BackColor = System.Drawing.Color.White
        Me.TxtCategory.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.TxtCategory.Location = New System.Drawing.Point(11, 42)
        Me.TxtCategory.MaxLength = 200
        Me.TxtCategory.Name = "TxtCategory"
        Me.TxtCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCategory.Size = New System.Drawing.Size(312, 35)
        Me.TxtCategory.TabIndex = 0
        '
        'PnlTitel
        '
        Me.PnlTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlTitel.Controls.Add(Me.BtnClose)
        Me.PnlTitel.Controls.Add(Me.LblTitel)
        Me.PnlTitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitel.ForeColor = System.Drawing.Color.Transparent
        Me.PnlTitel.Location = New System.Drawing.Point(3, 3)
        Me.PnlTitel.Name = "PnlTitel"
        Me.PnlTitel.Size = New System.Drawing.Size(439, 28)
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
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(120, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(198, 28)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "تصنيفات الأصناف"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 441)
        Me.Controls.Add(Me.PnlCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategory"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Dark"
        Me.Text = "تصنيفات الأصول"
        Me.PnlCategory.ResumeLayout(False)
        Me.PnlCategory.PerformLayout()
        Me.TLPBtns.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DGVCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlCategory As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCategory As TextBox
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents LblTitel As Label
    Friend WithEvents TLPBtns As TableLayoutPanel
    Friend WithEvents DGVCategory As DataGridView
    Friend WithEvents BtnClose As Button
End Class
