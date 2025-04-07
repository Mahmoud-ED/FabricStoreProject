<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmployeesData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployeesData))
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEmployeeName = New System.Windows.Forms.TextBox()
        Me.TxtPhone1 = New System.Windows.Forms.TextBox()
        Me.TxtPhone2 = New System.Windows.Forms.TextBox()
        Me.DGVEmp = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDeleteBasic = New System.Windows.Forms.Button()
        Me.BtnRefreshBasic = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmbEmpName = New System.Windows.Forms.ComboBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TxtAddress, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel7, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel18, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel19, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtEmployeeName, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtPhone1, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtPhone2, 1, 3)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(22, 98)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(961, 406)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'TxtAddress
        '
        Me.TxtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(0, 104)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtAddress.MaxLength = 200
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddress.Size = New System.Drawing.Size(772, 35)
        Me.TxtAddress.TabIndex = 2
        Me.TxtAddress.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(774, 164)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 77)
        Me.Panel1.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(185, 77)
        Me.Label9.TabIndex = 1109
        Me.Label9.Text = "رقم الهاتف (1)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(774, 83)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(185, 77)
        Me.Panel7.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 77)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "العنوان"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Label12)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(774, 2)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(185, 77)
        Me.Panel18.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(185, 77)
        Me.Label12.TabIndex = 1108
        Me.Label12.Text = "اسم الموظف"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Label10)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(774, 245)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(185, 77)
        Me.Panel19.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(185, 77)
        Me.Label10.TabIndex = 1226
        Me.Label10.Text = "رقم الهاتف (2)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEmployeeName
        '
        Me.TxtEmployeeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmployeeName.BackColor = System.Drawing.Color.White
        Me.TxtEmployeeName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmployeeName.Location = New System.Drawing.Point(2, 23)
        Me.TxtEmployeeName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmployeeName.MaxLength = 200
        Me.TxtEmployeeName.Name = "TxtEmployeeName"
        Me.TxtEmployeeName.Size = New System.Drawing.Size(768, 35)
        Me.TxtEmployeeName.TabIndex = 1
        Me.TxtEmployeeName.Tag = "0"
        Me.TxtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPhone1
        '
        Me.TxtPhone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone1.BackColor = System.Drawing.Color.White
        Me.TxtPhone1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone1.Location = New System.Drawing.Point(2, 185)
        Me.TxtPhone1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone1.MaxLength = 10
        Me.TxtPhone1.Name = "TxtPhone1"
        Me.TxtPhone1.Size = New System.Drawing.Size(768, 35)
        Me.TxtPhone1.TabIndex = 3
        Me.TxtPhone1.Tag = "10"
        Me.TxtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPhone2
        '
        Me.TxtPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone2.BackColor = System.Drawing.Color.White
        Me.TxtPhone2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone2.Location = New System.Drawing.Point(2, 266)
        Me.TxtPhone2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone2.MaxLength = 10
        Me.TxtPhone2.Name = "TxtPhone2"
        Me.TxtPhone2.Size = New System.Drawing.Size(768, 35)
        Me.TxtPhone2.TabIndex = 4
        Me.TxtPhone2.Tag = "10"
        Me.TxtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVEmp
        '
        Me.DGVEmp.AllowUserToAddRows = False
        Me.DGVEmp.AllowUserToDeleteRows = False
        Me.DGVEmp.AllowUserToResizeRows = False
        Me.DGVEmp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEmp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEmp.ColumnHeadersHeight = 32
        Me.DGVEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEmp.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVEmp.EnableHeadersVisualStyles = False
        Me.DGVEmp.GridColor = System.Drawing.Color.Gray
        Me.DGVEmp.Location = New System.Drawing.Point(22, 564)
        Me.DGVEmp.Margin = New System.Windows.Forms.Padding(8, 2, 8, 2)
        Me.DGVEmp.MultiSelect = False
        Me.DGVEmp.Name = "DGVEmp"
        Me.DGVEmp.ReadOnly = True
        Me.DGVEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVEmp.RowHeadersVisible = False
        Me.DGVEmp.RowHeadersWidth = 51
        Me.DGVEmp.RowTemplate.Height = 30
        Me.DGVEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEmp.Size = New System.Drawing.Size(961, 69)
        Me.DGVEmp.TabIndex = 1282
        Me.DGVEmp.Tag = ""
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "اسم الموظف"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "العنوان"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "رقم الهاتف"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 5
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.BtnDeleteBasic, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.BtnRefreshBasic, 4, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(22, 517)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(961, 40)
        Me.TableLayoutPanel11.TabIndex = 1282
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(648, 2)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(313, 36)
        Me.BtnSave.TabIndex = 1136
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnDeleteBasic
        '
        Me.BtnDeleteBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnDeleteBasic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteBasic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDeleteBasic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDeleteBasic.FlatAppearance.BorderSize = 0
        Me.BtnDeleteBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteBasic.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteBasic.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteBasic.Image = CType(resources.GetObject("BtnDeleteBasic.Image"), System.Drawing.Image)
        Me.BtnDeleteBasic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteBasic.Location = New System.Drawing.Point(325, 2)
        Me.BtnDeleteBasic.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnDeleteBasic.Name = "BtnDeleteBasic"
        Me.BtnDeleteBasic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteBasic.Size = New System.Drawing.Size(313, 36)
        Me.BtnDeleteBasic.TabIndex = 1139
        Me.BtnDeleteBasic.Tag = "Dark"
        Me.BtnDeleteBasic.Text = "حــذف"
        Me.BtnDeleteBasic.UseVisualStyleBackColor = False
        '
        'BtnRefreshBasic
        '
        Me.BtnRefreshBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefreshBasic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshBasic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefreshBasic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRefreshBasic.FlatAppearance.BorderSize = 0
        Me.BtnRefreshBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshBasic.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshBasic.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshBasic.Image = CType(resources.GetObject("BtnRefreshBasic.Image"), System.Drawing.Image)
        Me.BtnRefreshBasic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefreshBasic.Location = New System.Drawing.Point(0, 2)
        Me.BtnRefreshBasic.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnRefreshBasic.Name = "BtnRefreshBasic"
        Me.BtnRefreshBasic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshBasic.Size = New System.Drawing.Size(315, 36)
        Me.BtnRefreshBasic.TabIndex = 1137
        Me.BtnRefreshBasic.Tag = "Dark"
        Me.BtnRefreshBasic.Text = "تحديث"
        Me.BtnRefreshBasic.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel12)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(961, 80)
        Me.GroupBox1.TabIndex = 1282
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بحث"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 4
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.CmbEmpName, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.BtnShow, 3, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(13, 27)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(945, 40)
        Me.TableLayoutPanel12.TabIndex = 1210
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(829, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 40)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "اسم الموظف"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbEmpName
        '
        Me.CmbEmpName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmpName.BackColor = System.Drawing.Color.White
        Me.CmbEmpName.DropDownHeight = 160
        Me.CmbEmpName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbEmpName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmpName.FormattingEnabled = True
        Me.CmbEmpName.IntegralHeight = False
        Me.CmbEmpName.Location = New System.Drawing.Point(241, 2)
        Me.CmbEmpName.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbEmpName.Name = "CmbEmpName"
        Me.CmbEmpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbEmpName.Size = New System.Drawing.Size(584, 35)
        Me.CmbEmpName.TabIndex = 1119
        Me.CmbEmpName.Tag = "1"
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnShow.FlatAppearance.BorderSize = 0
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.Image = CType(resources.GetObject("BtnShow.Image"), System.Drawing.Image)
        Me.BtnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShow.Location = New System.Drawing.Point(2, 2)
        Me.BtnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(227, 36)
        Me.BtnShow.TabIndex = 443
        Me.BtnShow.Tag = "Dark"
        Me.BtnShow.Text = "عرض"
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'FrmEmployeesData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1005, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.DGVEmp)
        Me.Controls.Add(Me.TableLayoutPanel11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmEmployeesData"
        Me.Text = "بيانات الموظفين"
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVEmp As DataGridView
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnRefreshBasic As Button
    Friend WithEvents BtnDeleteBasic As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents BtnShow As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents CmbEmpName As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TxtPhone2 As TextBox
    Friend WithEvents TxtPhone1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmployeeName As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
