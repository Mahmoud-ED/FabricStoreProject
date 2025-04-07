<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuppleir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuppleir))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblStorName = New System.Windows.Forms.Label()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.CmbSuppleir = New System.Windows.Forms.ComboBox()
        Me.DGVSuppleir = New System.Windows.Forms.DataGridView()
        Me.IDSuppelr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Addres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TLPData = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblStoreName2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSupplerName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhone1 = New System.Windows.Forms.TextBox()
        Me.TxtPhone2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVSuppleir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPData.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(961, 80)
        Me.GroupBox1.TabIndex = 1293
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بحث"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LblStorName, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnShow, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CmbSuppleir, 1, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(13, 27)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(945, 40)
        Me.TableLayoutPanel3.TabIndex = 1215
        '
        'LblStorName
        '
        Me.LblStorName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStorName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStorName.Location = New System.Drawing.Point(829, 0)
        Me.LblStorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblStorName.Name = "LblStorName"
        Me.LblStorName.Size = New System.Drawing.Size(114, 40)
        Me.LblStorName.TabIndex = 17
        Me.LblStorName.Text = "اسم المورد"
        Me.LblStorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnShow.FlatAppearance.BorderSize = 0
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.Image = CType(resources.GetObject("BtnShow.Image"), System.Drawing.Image)
        Me.BtnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShow.Location = New System.Drawing.Point(2, 2)
        Me.BtnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnShow.Size = New System.Drawing.Size(227, 36)
        Me.BtnShow.TabIndex = 444
        Me.BtnShow.Tag = "Dark"
        Me.BtnShow.Text = "عرض"
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'CmbSuppleir
        '
        Me.CmbSuppleir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSuppleir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSuppleir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSuppleir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSuppleir.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSuppleir.FormattingEnabled = True
        Me.CmbSuppleir.Location = New System.Drawing.Point(241, 2)
        Me.CmbSuppleir.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbSuppleir.Name = "CmbSuppleir"
        Me.CmbSuppleir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbSuppleir.Size = New System.Drawing.Size(584, 35)
        Me.CmbSuppleir.TabIndex = 17
        Me.CmbSuppleir.Tag = "1"
        '
        'DGVSuppleir
        '
        Me.DGVSuppleir.AllowUserToAddRows = False
        Me.DGVSuppleir.AllowUserToDeleteRows = False
        Me.DGVSuppleir.AllowUserToResizeRows = False
        Me.DGVSuppleir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSuppleir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSuppleir.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVSuppleir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSuppleir.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSuppleir.ColumnHeadersHeight = 32
        Me.DGVSuppleir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVSuppleir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSuppelr, Me.SName, Me.Addres, Me.Phone})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSuppleir.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSuppleir.EnableHeadersVisualStyles = False
        Me.DGVSuppleir.GridColor = System.Drawing.Color.Gray
        Me.DGVSuppleir.Location = New System.Drawing.Point(22, 564)
        Me.DGVSuppleir.Margin = New System.Windows.Forms.Padding(8, 2, 8, 2)
        Me.DGVSuppleir.MultiSelect = False
        Me.DGVSuppleir.Name = "DGVSuppleir"
        Me.DGVSuppleir.ReadOnly = True
        Me.DGVSuppleir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVSuppleir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVSuppleir.RowHeadersVisible = False
        Me.DGVSuppleir.RowHeadersWidth = 51
        Me.DGVSuppleir.RowTemplate.Height = 30
        Me.DGVSuppleir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSuppleir.Size = New System.Drawing.Size(961, 69)
        Me.DGVSuppleir.TabIndex = 1296
        Me.DGVSuppleir.Tag = ""
        '
        'IDSuppelr
        '
        Me.IDSuppelr.DataPropertyName = "IDSuppelr"
        Me.IDSuppelr.HeaderText = "IDSuppelr"
        Me.IDSuppelr.MinimumWidth = 6
        Me.IDSuppelr.Name = "IDSuppelr"
        Me.IDSuppelr.ReadOnly = True
        Me.IDSuppelr.Visible = False
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "اسم المورد"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.ReadOnly = True
        '
        'Addres
        '
        Me.Addres.DataPropertyName = "Addres"
        Me.Addres.HeaderText = "العنوان"
        Me.Addres.MinimumWidth = 6
        Me.Addres.Name = "Addres"
        Me.Addres.ReadOnly = True
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "رقم الهاتف"
        Me.Phone.MinimumWidth = 6
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnNew, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDelete, 2, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(22, 517)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(961, 40)
        Me.TableLayoutPanel1.TabIndex = 1295
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.BtnSave.TabIndex = 1217
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(0, 2)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.Size = New System.Drawing.Size(315, 36)
        Me.BtnNew.TabIndex = 1220
        Me.BtnNew.Tag = "Dark"
        Me.BtnNew.Text = "تحديث"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(325, 2)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(313, 36)
        Me.BtnDelete.TabIndex = 1218
        Me.BtnDelete.Tag = "Dark"
        Me.BtnDelete.Text = "حــذف"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'TLPData
        '
        Me.TLPData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPData.ColumnCount = 2
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPData.Controls.Add(Me.Label3, 0, 3)
        Me.TLPData.Controls.Add(Me.LblStoreName2, 0, 0)
        Me.TLPData.Controls.Add(Me.Label5, 0, 2)
        Me.TLPData.Controls.Add(Me.Label7, 0, 1)
        Me.TLPData.Controls.Add(Me.TxtSupplerName, 1, 0)
        Me.TLPData.Controls.Add(Me.TxtAddress, 1, 1)
        Me.TLPData.Controls.Add(Me.TxtPhone1, 1, 2)
        Me.TLPData.Controls.Add(Me.TxtPhone2, 1, 3)
        Me.TLPData.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPData.Location = New System.Drawing.Point(22, 98)
        Me.TLPData.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPData.Name = "TLPData"
        Me.TLPData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPData.RowCount = 5
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPData.Size = New System.Drawing.Size(961, 406)
        Me.TLPData.TabIndex = 1297
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(775, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 81)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "رقم الهاتف (2)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStoreName2
        '
        Me.LblStoreName2.BackColor = System.Drawing.Color.Transparent
        Me.LblStoreName2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStoreName2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStoreName2.ForeColor = System.Drawing.Color.Black
        Me.LblStoreName2.Location = New System.Drawing.Point(775, 0)
        Me.LblStoreName2.Name = "LblStoreName2"
        Me.LblStoreName2.Size = New System.Drawing.Size(183, 81)
        Me.LblStoreName2.TabIndex = 15
        Me.LblStoreName2.Text = "اسم المورد"
        Me.LblStoreName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(775, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 81)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "رقم الهاتف (1)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(775, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 81)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "العنوان"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSupplerName
        '
        Me.TxtSupplerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSupplerName.BackColor = System.Drawing.Color.White
        Me.TxtSupplerName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplerName.Location = New System.Drawing.Point(0, 23)
        Me.TxtSupplerName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSupplerName.MaxLength = 200
        Me.TxtSupplerName.Name = "TxtSupplerName"
        Me.TxtSupplerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSupplerName.Size = New System.Drawing.Size(772, 35)
        Me.TxtSupplerName.TabIndex = 0
        Me.TxtSupplerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TxtAddress.TabIndex = 1
        Me.TxtAddress.Tag = ""
        '
        'TxtPhone1
        '
        Me.TxtPhone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone1.BackColor = System.Drawing.Color.White
        Me.TxtPhone1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone1.Location = New System.Drawing.Point(0, 185)
        Me.TxtPhone1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPhone1.MaxLength = 10
        Me.TxtPhone1.Name = "TxtPhone1"
        Me.TxtPhone1.ShortcutsEnabled = False
        Me.TxtPhone1.Size = New System.Drawing.Size(772, 35)
        Me.TxtPhone1.TabIndex = 2
        Me.TxtPhone1.Tag = "10"
        '
        'TxtPhone2
        '
        Me.TxtPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone2.BackColor = System.Drawing.Color.White
        Me.TxtPhone2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone2.Location = New System.Drawing.Point(0, 266)
        Me.TxtPhone2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPhone2.MaxLength = 10
        Me.TxtPhone2.Name = "TxtPhone2"
        Me.TxtPhone2.ShortcutsEnabled = False
        Me.TxtPhone2.Size = New System.Drawing.Size(772, 35)
        Me.TxtPhone2.TabIndex = 3
        Me.TxtPhone2.Tag = "10"
        '
        'FrmSuppleir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 650)
        Me.Controls.Add(Me.TLPData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVSuppleir)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmSuppleir"
        Me.Text = "بيانات الموردين"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DGVSuppleir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TLPData.ResumeLayout(False)
        Me.TLPData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LblStorName As Label
    Friend WithEvents BtnShow As Button
    Friend WithEvents CmbSuppleir As ComboBox
    Friend WithEvents DGVSuppleir As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TLPData As TableLayoutPanel
    Friend WithEvents TxtSupplerName As TextBox
    Friend WithEvents LblStoreName2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPhone1 As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPhone2 As TextBox
    Friend WithEvents IDSuppelr As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Addres As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
End Class
