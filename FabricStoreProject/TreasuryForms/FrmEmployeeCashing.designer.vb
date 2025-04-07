<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeCashing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployeeCashing))
        Me.DGVCashing = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbEmployee = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblValueCard = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTreasuryValue = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblCashingFinance = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TLPCheck = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CmbBank = New System.Windows.Forms.ComboBox()
        Me.TxtCheckNum = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblValue = New System.Windows.Forms.Label()
        Me.TxtValue = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNoteFor = New System.Windows.Forms.TextBox()
        Me.TxtLettersValue = New System.Windows.Forms.Label()
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPButtons.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TLPCheck.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCashing
        '
        Me.DGVCashing.AllowUserToAddRows = False
        Me.DGVCashing.AllowUserToDeleteRows = False
        Me.DGVCashing.AllowUserToResizeRows = False
        Me.DGVCashing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCashing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCashing.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCashing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCashing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCashing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCashing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column6, Me.Column8, Me.Column3, Me.Column2, Me.Column4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCashing.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCashing.EnableHeadersVisualStyles = False
        Me.DGVCashing.GridColor = System.Drawing.Color.Gray
        Me.DGVCashing.Location = New System.Drawing.Point(20, 461)
        Me.DGVCashing.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCashing.MultiSelect = False
        Me.DGVCashing.Name = "DGVCashing"
        Me.DGVCashing.ReadOnly = True
        Me.DGVCashing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCashing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCashing.RowHeadersVisible = False
        Me.DGVCashing.RowHeadersWidth = 51
        Me.DGVCashing.RowTemplate.Height = 30
        Me.DGVCashing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCashing.Size = New System.Drawing.Size(897, 69)
        Me.DGVCashing.TabIndex = 59
        Me.DGVCashing.Tag = ""
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "رقم الايصال"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "قيمة الايصال"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "الموظف"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "البند المالي"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "طريقة الدفع"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "التاريخ"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'TLPButtons
        '
        Me.TLPButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPButtons.ColumnCount = 7
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPButtons.Controls.Add(Me.BtnPrint, 6, 0)
        Me.TLPButtons.Controls.Add(Me.BtnRefresh, 4, 0)
        Me.TLPButtons.Controls.Add(Me.BtnDelete, 2, 0)
        Me.TLPButtons.Controls.Add(Me.BtnSave, 0, 0)
        Me.TLPButtons.Location = New System.Drawing.Point(20, 401)
        Me.TLPButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPButtons.Name = "TLPButtons"
        Me.TLPButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPButtons.RowCount = 1
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPButtons.Size = New System.Drawing.Size(897, 40)
        Me.TLPButtons.TabIndex = 60
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(0, 1)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(219, 38)
        Me.BtnPrint.TabIndex = 41
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.Location = New System.Drawing.Point(229, 1)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(216, 38)
        Me.BtnRefresh.TabIndex = 39
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(455, 1)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(216, 38)
        Me.BtnDelete.TabIndex = 40
        Me.BtnDelete.Tag = "Dark"
        Me.BtnDelete.Text = "إلغاء الايصال"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(681, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(216, 38)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 10)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(897, 377)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الإيصال"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.CmbEmployee, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label16, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.TLPCheck, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel9, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label13, 0, 7)
        Me.TableLayoutPanel10.Controls.Add(Me.TxtNoteFor, 1, 7)
        Me.TableLayoutPanel10.Controls.Add(Me.TxtLettersValue, 1, 5)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(10, 30)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 9
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.456178!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93483!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(877, 337)
        Me.TableLayoutPanel10.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(694, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 45)
        Me.Label4.TabIndex = 1276
        Me.Label4.Text = "القيمة بالحروف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(694, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 45)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "الموظــف"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbEmployee
        '
        Me.CmbEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmployee.FormattingEnabled = True
        Me.CmbEmployee.Location = New System.Drawing.Point(0, 102)
        Me.CmbEmployee.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbEmployee.Name = "CmbEmployee"
        Me.CmbEmployee.Size = New System.Drawing.Size(692, 35)
        Me.CmbEmployee.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(692, 45)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(238, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 45)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "القيمة في الخزينة طرق الدفع"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LblValueCard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 45)
        Me.Panel3.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(2, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Tag = "Auto"
        Me.Label3.Text = "د.ل"
        '
        'LblValueCard
        '
        Me.LblValueCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblValueCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblValueCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValueCard.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblValueCard.ForeColor = System.Drawing.Color.Black
        Me.LblValueCard.Location = New System.Drawing.Point(0, 5)
        Me.LblValueCard.Margin = New System.Windows.Forms.Padding(0)
        Me.LblValueCard.Name = "LblValueCard"
        Me.LblValueCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblValueCard.Size = New System.Drawing.Size(236, 35)
        Me.LblValueCard.TabIndex = 1278
        Me.LblValueCard.Tag = "Auto"
        Me.LblValueCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.LblTreasuryValue)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(456, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(236, 45)
        Me.Panel6.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(2, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 28)
        Me.Label7.TabIndex = 1
        Me.Label7.Tag = "Auto"
        Me.Label7.Text = "د.ل"
        '
        'LblTreasuryValue
        '
        Me.LblTreasuryValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTreasuryValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTreasuryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTreasuryValue.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTreasuryValue.ForeColor = System.Drawing.Color.Black
        Me.LblTreasuryValue.Location = New System.Drawing.Point(0, 5)
        Me.LblTreasuryValue.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTreasuryValue.Name = "LblTreasuryValue"
        Me.LblTreasuryValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTreasuryValue.Size = New System.Drawing.Size(236, 35)
        Me.LblTreasuryValue.TabIndex = 1278
        Me.LblTreasuryValue.Tag = "Auto"
        Me.LblTreasuryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Controls.Add(Me.LblCashingFinance, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LblDate, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(692, 45)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'LblCashingFinance
        '
        Me.LblCashingFinance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCashingFinance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblCashingFinance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCashingFinance.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblCashingFinance.ForeColor = System.Drawing.Color.Black
        Me.LblCashingFinance.Location = New System.Drawing.Point(0, 5)
        Me.LblCashingFinance.Margin = New System.Windows.Forms.Padding(0)
        Me.LblCashingFinance.Name = "LblCashingFinance"
        Me.LblCashingFinance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCashingFinance.Size = New System.Drawing.Size(165, 35)
        Me.LblCashingFinance.TabIndex = 1277
        Me.LblCashingFinance.Tag = "Auto"
        Me.LblCashingFinance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.LblNum)
        Me.Panel2.Location = New System.Drawing.Point(529, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(163, 36)
        Me.Panel2.TabIndex = 464
        Me.Panel2.Tag = "Light"
        '
        'LblNum
        '
        Me.LblNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblNum.ForeColor = System.Drawing.Color.Black
        Me.LblNum.Location = New System.Drawing.Point(2, 2)
        Me.LblNum.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblNum.Size = New System.Drawing.Size(159, 32)
        Me.LblNum.TabIndex = 1276
        Me.LblNum.Tag = "Auto"
        Me.LblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblDate.ForeColor = System.Drawing.Color.Black
        Me.LblDate.Location = New System.Drawing.Point(265, 5)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDate.Size = New System.Drawing.Size(164, 35)
        Me.LblDate.TabIndex = 1277
        Me.LblDate.Tag = "Auto"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(431, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "التاريخ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(167, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 45)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "البند المالي"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(694, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "القيمة في الخزينة النقدي"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(694, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 45)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "رقم الإيصال"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(694, 135)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 45)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "قيمة الايصال"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label16.Location = New System.Drawing.Point(694, 180)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(181, 45)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "رقم الصك"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLPCheck
        '
        Me.TLPCheck.ColumnCount = 3
        Me.TLPCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.83404!))
        Me.TLPCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25316!))
        Me.TLPCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.9128!))
        Me.TLPCheck.Controls.Add(Me.Label17, 1, 0)
        Me.TLPCheck.Controls.Add(Me.CmbBank, 2, 0)
        Me.TLPCheck.Controls.Add(Me.TxtCheckNum, 0, 0)
        Me.TLPCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPCheck.Enabled = False
        Me.TLPCheck.Location = New System.Drawing.Point(0, 180)
        Me.TLPCheck.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCheck.Name = "TLPCheck"
        Me.TLPCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPCheck.RowCount = 1
        Me.TLPCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPCheck.Size = New System.Drawing.Size(692, 45)
        Me.TLPCheck.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label17.Location = New System.Drawing.Point(293, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(136, 45)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "المصرف"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbBank
        '
        Me.CmbBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBank.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.CmbBank.FormattingEnabled = True
        Me.CmbBank.Location = New System.Drawing.Point(0, 4)
        Me.CmbBank.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbBank.Name = "CmbBank"
        Me.CmbBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbBank.Size = New System.Drawing.Size(291, 36)
        Me.CmbBank.TabIndex = 1
        '
        'TxtCheckNum
        '
        Me.TxtCheckNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCheckNum.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCheckNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCheckNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.TxtCheckNum.Location = New System.Drawing.Point(431, 5)
        Me.TxtCheckNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtCheckNum.MaxLength = 20
        Me.TxtCheckNum.Name = "TxtCheckNum"
        Me.TxtCheckNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCheckNum.Size = New System.Drawing.Size(261, 35)
        Me.TxtCheckNum.TabIndex = 0
        Me.TxtCheckNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 3
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.69339!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25316!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.9128!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.CmbPaymentType, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(0, 135)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(692, 45)
        Me.TableLayoutPanel9.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(293, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "طريقة الدفع"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPaymentType
        '
        Me.CmbPaymentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPaymentType.FormattingEnabled = True
        Me.CmbPaymentType.Location = New System.Drawing.Point(0, 12)
        Me.CmbPaymentType.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbPaymentType.Name = "CmbPaymentType"
        Me.CmbPaymentType.Size = New System.Drawing.Size(291, 35)
        Me.CmbPaymentType.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblValue)
        Me.Panel1.Controls.Add(Me.TxtValue)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(431, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 45)
        Me.Panel1.TabIndex = 4
        '
        'LblValue
        '
        Me.LblValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblValue.BackColor = System.Drawing.SystemColors.Window
        Me.LblValue.ForeColor = System.Drawing.Color.DimGray
        Me.LblValue.Location = New System.Drawing.Point(4, 8)
        Me.LblValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblValue.Name = "LblValue"
        Me.LblValue.Size = New System.Drawing.Size(35, 28)
        Me.LblValue.TabIndex = 1
        Me.LblValue.Text = "د.ل"
        '
        'TxtValue
        '
        Me.TxtValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtValue.BackColor = System.Drawing.SystemColors.Window
        Me.TxtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtValue.Location = New System.Drawing.Point(0, 5)
        Me.TxtValue.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtValue.Name = "TxtValue"
        Me.TxtValue.Size = New System.Drawing.Size(261, 35)
        Me.TxtValue.TabIndex = 3
        Me.TxtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(694, 277)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 45)
        Me.Label13.TabIndex = 1277
        Me.Label13.Text = "البيان"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNoteFor
        '
        Me.TxtNoteFor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNoteFor.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNoteFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoteFor.Location = New System.Drawing.Point(0, 277)
        Me.TxtNoteFor.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNoteFor.Multiline = True
        Me.TxtNoteFor.Name = "TxtNoteFor"
        Me.TxtNoteFor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNoteFor.Size = New System.Drawing.Size(692, 45)
        Me.TxtNoteFor.TabIndex = 4
        Me.TxtNoteFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLettersValue
        '
        Me.TxtLettersValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLettersValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtLettersValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLettersValue.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtLettersValue.ForeColor = System.Drawing.Color.Black
        Me.TxtLettersValue.Location = New System.Drawing.Point(0, 230)
        Me.TxtLettersValue.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtLettersValue.Name = "TxtLettersValue"
        Me.TxtLettersValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtLettersValue.Size = New System.Drawing.Size(692, 35)
        Me.TxtLettersValue.TabIndex = 1275
        Me.TxtLettersValue.Tag = "AutoC"
        Me.TxtLettersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEmployeeCashing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVCashing)
        Me.Controls.Add(Me.TLPButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeCashing"
        Me.Text = "ايصال صرف موظف"
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPButtons.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TLPCheck.ResumeLayout(False)
        Me.TLPCheck.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVCashing As DataGridView
    Friend WithEvents TLPButtons As TableLayoutPanel
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLettersValue As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents LblTreasuryValue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblValue As Label
    Friend WithEvents TxtValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNoteFor As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LblDate As Label
    Friend WithEvents LblNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbEmployee As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TLPCheck As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents CmbBank As ComboBox
    Friend WithEvents TxtCheckNum As TextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents LblCashingFinance As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbPaymentType As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblValueCard As Label
    Friend WithEvents Label13 As Label
End Class
