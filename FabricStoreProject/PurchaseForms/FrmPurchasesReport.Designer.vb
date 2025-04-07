<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchasesReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnPrintAll = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ChkNum = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.ChkUser = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkSupplier = New System.Windows.Forms.CheckBox()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        Me.BtnSaerch = New System.Windows.Forms.Button()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtPageNum = New System.Windows.Forms.TextBox()
        Me.NUDPageSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BtnLastPage = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtnNextPage = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.BtnPreviousPage = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnFirstPage = New System.Windows.Forms.Button()
        Me.DGVPurchases = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TLPBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.DGVPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPBottom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(254, 2)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(238, 36)
        Me.BtnPrint.TabIndex = 33
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة صفحة واحدة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnPrintAll
        '
        Me.BtnPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrintAll.FlatAppearance.BorderSize = 0
        Me.BtnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnPrintAll.ForeColor = System.Drawing.Color.White
        Me.BtnPrintAll.Image = CType(resources.GetObject("BtnPrintAll.Image"), System.Drawing.Image)
        Me.BtnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintAll.Location = New System.Drawing.Point(0, 2)
        Me.BtnPrintAll.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnPrintAll.Name = "BtnPrintAll"
        Me.BtnPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintAll.Size = New System.Drawing.Size(242, 36)
        Me.BtnPrintAll.TabIndex = 32
        Me.BtnPrintAll.Tag = "Dark"
        Me.BtnPrintAll.Text = "طباعة الكل"
        Me.BtnPrintAll.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(504, 2)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.Size = New System.Drawing.Size(242, 36)
        Me.BtnNew.TabIndex = 31
        Me.BtnNew.Tag = "Dark"
        Me.BtnNew.Text = "تحديث"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtNum, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel9, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel21, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbSupplier, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbUserName, 4, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(19, 30)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(972, 110)
        Me.TableLayoutPanel4.TabIndex = 1230
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DTPFrom, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.DTPTo, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 2)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(320, 51)
        Me.TableLayoutPanel6.TabIndex = 1227
        '
        'DTPFrom
        '
        Me.DTPFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFrom.CustomFormat = ""
        Me.DTPFrom.Enabled = False
        Me.DTPFrom.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(184, 8)
        Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPFrom.RightToLeftLayout = True
        Me.DTPFrom.Size = New System.Drawing.Size(134, 35)
        Me.DTPFrom.TabIndex = 42
        Me.DTPFrom.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'DTPTo
        '
        Me.DTPTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPTo.CustomFormat = ""
        Me.DTPTo.Enabled = False
        Me.DTPTo.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(2, 8)
        Me.DTPTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPTo.RightToLeftLayout = True
        Me.DTPTo.Size = New System.Drawing.Size(135, 35)
        Me.DTPTo.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "إلى"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNum
        '
        Me.TxtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNum.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNum.Location = New System.Drawing.Point(519, 10)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNum.MaxLength = 6
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(315, 35)
        Me.TxtNum.TabIndex = 56
        Me.TxtNum.Tag = ""
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.ChkNum)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(838, 2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(132, 51)
        Me.Panel9.TabIndex = 0
        '
        'ChkNum
        '
        Me.ChkNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkNum.Location = New System.Drawing.Point(0, 0)
        Me.ChkNum.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkNum.Name = "ChkNum"
        Me.ChkNum.Size = New System.Drawing.Size(132, 51)
        Me.ChkNum.TabIndex = 0
        Me.ChkNum.Text = "رقم الفاتورة"
        Me.ChkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkNum.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ChkDate)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(322, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(167, 51)
        Me.Panel7.TabIndex = 51
        '
        'ChkDate
        '
        Me.ChkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkDate.Location = New System.Drawing.Point(0, 0)
        Me.ChkDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(167, 51)
        Me.ChkDate.TabIndex = 2
        Me.ChkDate.Text = "تاريخ الفاتورة  :  من"
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.ChkUser)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(322, 57)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(167, 51)
        Me.Panel21.TabIndex = 45
        '
        'ChkUser
        '
        Me.ChkUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkUser.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkUser.Location = New System.Drawing.Point(0, 0)
        Me.ChkUser.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkUser.Name = "ChkUser"
        Me.ChkUser.Size = New System.Drawing.Size(167, 51)
        Me.ChkUser.TabIndex = 1
        Me.ChkUser.Text = "المستخدم"
        Me.ChkUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkUser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkSupplier)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(838, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 51)
        Me.Panel1.TabIndex = 1229
        '
        'ChkSupplier
        '
        Me.ChkSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSupplier.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkSupplier.Location = New System.Drawing.Point(0, 0)
        Me.ChkSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkSupplier.Name = "ChkSupplier"
        Me.ChkSupplier.Size = New System.Drawing.Size(132, 51)
        Me.ChkSupplier.TabIndex = 1
        Me.ChkSupplier.Text = "المورد"
        Me.ChkSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSupplier.UseVisualStyleBackColor = True
        '
        'CmbSupplier
        '
        Me.CmbSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSupplier.DropDownHeight = 160
        Me.CmbSupplier.Enabled = False
        Me.CmbSupplier.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.IntegralHeight = False
        Me.CmbSupplier.Location = New System.Drawing.Point(519, 65)
        Me.CmbSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(315, 35)
        Me.CmbSupplier.TabIndex = 1230
        '
        'CmbUserName
        '
        Me.CmbUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserName.DropDownHeight = 160
        Me.CmbUserName.Enabled = False
        Me.CmbUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbUserName.FormattingEnabled = True
        Me.CmbUserName.IntegralHeight = False
        Me.CmbUserName.Location = New System.Drawing.Point(2, 65)
        Me.CmbUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.Size = New System.Drawing.Size(316, 35)
        Me.CmbUserName.TabIndex = 41
        '
        'BtnSaerch
        '
        Me.BtnSaerch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSaerch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaerch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSaerch.FlatAppearance.BorderSize = 0
        Me.BtnSaerch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSaerch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSaerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaerch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSaerch.ForeColor = System.Drawing.Color.White
        Me.BtnSaerch.Image = CType(resources.GetObject("BtnSaerch.Image"), System.Drawing.Image)
        Me.BtnSaerch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSaerch.Location = New System.Drawing.Point(756, 2)
        Me.BtnSaerch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSaerch.Name = "BtnSaerch"
        Me.BtnSaerch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSaerch.Size = New System.Drawing.Size(245, 36)
        Me.BtnSaerch.TabIndex = 29
        Me.BtnSaerch.Tag = "Dark"
        Me.BtnSaerch.Text = "بحث"
        Me.BtnSaerch.UseVisualStyleBackColor = False
        '
        'TLPPages
        '
        Me.TLPPages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPPages.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TLPPages.ColumnCount = 10
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.756757!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.756757!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TLPPages.Controls.Add(Me.BtnRefreshPage, 9, 0)
        Me.TLPPages.Controls.Add(Me.TxtPagesCount, 6, 0)
        Me.TLPPages.Controls.Add(Me.TxtPageNum, 2, 0)
        Me.TLPPages.Controls.Add(Me.NUDPageSize, 8, 0)
        Me.TLPPages.Controls.Add(Me.Panel3, 7, 0)
        Me.TLPPages.Controls.Add(Me.Panel4, 5, 0)
        Me.TLPPages.Controls.Add(Me.Panel12, 4, 0)
        Me.TLPPages.Controls.Add(Me.Panel13, 3, 0)
        Me.TLPPages.Controls.Add(Me.Panel14, 1, 0)
        Me.TLPPages.Controls.Add(Me.Panel16, 0, 0)
        Me.TLPPages.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPPages.Location = New System.Drawing.Point(19, 494)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(1002, 40)
        Me.TLPPages.TabIndex = 1239
        Me.TLPPages.Tag = "Dark"
        '
        'BtnRefreshPage
        '
        Me.BtnRefreshPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefreshPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefreshPage.FlatAppearance.BorderSize = 0
        Me.BtnRefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshPage.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshPage.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshPage.Image = CType(resources.GetObject("BtnRefreshPage.Image"), System.Drawing.Image)
        Me.BtnRefreshPage.Location = New System.Drawing.Point(3, 3)
        Me.BtnRefreshPage.Name = "BtnRefreshPage"
        Me.BtnRefreshPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshPage.Size = New System.Drawing.Size(94, 34)
        Me.BtnRefreshPage.TabIndex = 1207
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(365, 3)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(138, 35)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPageNum
        '
        Me.TxtPageNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPageNum.BackColor = System.Drawing.Color.White
        Me.TxtPageNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPageNum.Location = New System.Drawing.Point(744, 3)
        Me.TxtPageNum.Name = "TxtPageNum"
        Me.TxtPageNum.ReadOnly = True
        Me.TxtPageNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPageNum.Size = New System.Drawing.Size(138, 35)
        Me.TxtPageNum.TabIndex = 1205
        Me.TxtPageNum.TabStop = False
        Me.TxtPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(103, 3)
        Me.NUDPageSize.Name = "NUDPageSize"
        Me.NUDPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NUDPageSize.Size = New System.Drawing.Size(138, 35)
        Me.NUDPageSize.TabIndex = 20
        Me.NUDPageSize.TabStop = False
        Me.NUDPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(246, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(114, 36)
        Me.Panel3.TabIndex = 1205
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 28)
        Me.Label10.TabIndex = 1201
        Me.Label10.Text = "حجم الصفحة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(508, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(114, 36)
        Me.Panel4.TabIndex = 1205
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "عدد الصفحات"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BtnLastPage)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(626, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(68, 36)
        Me.Panel12.TabIndex = 1205
        '
        'BtnLastPage
        '
        Me.BtnLastPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnLastPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLastPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLastPage.FlatAppearance.BorderSize = 0
        Me.BtnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLastPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLastPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLastPage.Image = CType(resources.GetObject("BtnLastPage.Image"), System.Drawing.Image)
        Me.BtnLastPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLastPage.Size = New System.Drawing.Size(68, 36)
        Me.BtnLastPage.TabIndex = 19
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnNextPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(698, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(41, 36)
        Me.Panel13.TabIndex = 1205
        '
        'BtnNextPage
        '
        Me.BtnNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNextPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNextPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNextPage.FlatAppearance.BorderSize = 0
        Me.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNextPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNextPage.Image = CType(resources.GetObject("BtnNextPage.Image"), System.Drawing.Image)
        Me.BtnNextPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNextPage.Size = New System.Drawing.Size(41, 36)
        Me.BtnNextPage.TabIndex = 18
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.BtnPreviousPage)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(887, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(41, 36)
        Me.Panel14.TabIndex = 1205
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreviousPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPreviousPage.FlatAppearance.BorderSize = 0
        Me.BtnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreviousPage.Image = CType(resources.GetObject("BtnPreviousPage.Image"), System.Drawing.Image)
        Me.BtnPreviousPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPreviousPage.Size = New System.Drawing.Size(41, 36)
        Me.BtnPreviousPage.TabIndex = 17
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(932, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(68, 36)
        Me.Panel16.TabIndex = 1205
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFirstPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnFirstPage.FlatAppearance.BorderSize = 0
        Me.BtnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirstPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirstPage.Image = CType(resources.GetObject("BtnFirstPage.Image"), System.Drawing.Image)
        Me.BtnFirstPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirstPage.Size = New System.Drawing.Size(68, 36)
        Me.BtnFirstPage.TabIndex = 16
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'DGVPurchases
        '
        Me.DGVPurchases.AllowUserToAddRows = False
        Me.DGVPurchases.AllowUserToDeleteRows = False
        Me.DGVPurchases.AllowUserToResizeRows = False
        Me.DGVPurchases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPurchases.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPurchases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPurchases.ColumnHeadersHeight = 32
        Me.DGVPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVPurchases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column12, Me.Column11, Me.Column2, Me.ColShow, Me.ColDel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPurchases.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVPurchases.EnableHeadersVisualStyles = False
        Me.DGVPurchases.GridColor = System.Drawing.Color.Gray
        Me.DGVPurchases.Location = New System.Drawing.Point(19, 242)
        Me.DGVPurchases.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVPurchases.MultiSelect = False
        Me.DGVPurchases.Name = "DGVPurchases"
        Me.DGVPurchases.ReadOnly = True
        Me.DGVPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVPurchases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVPurchases.RowHeadersVisible = False
        Me.DGVPurchases.RowHeadersWidth = 51
        Me.DGVPurchases.RowTemplate.Height = 30
        Me.DGVPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPurchases.Size = New System.Drawing.Size(1002, 250)
        Me.DGVPurchases.TabIndex = 1238
        Me.DGVPurchases.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle2.Format = "000000"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "رقم الفاتورة"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Column12
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column12.HeaderText = "تاريخ الفاتورة"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 220
        '
        'Column11
        '
        Me.Column11.HeaderText = "القيمة"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "المورد"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 360
        '
        'ColShow
        '
        Me.ColShow.HeaderText = ""
        Me.ColShow.Name = "ColShow"
        Me.ColShow.ReadOnly = True
        Me.ColShow.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColShow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColShow.Text = "عرض"
        Me.ColShow.UseColumnTextForButtonValue = True
        '
        'ColDel
        '
        Me.ColDel.HeaderText = ""
        Me.ColDel.MinimumWidth = 6
        Me.ColDel.Name = "ColDel"
        Me.ColDel.ReadOnly = True
        Me.ColDel.Text = "حذف"
        Me.ColDel.UseColumnTextForButtonValue = True
        Me.ColDel.Width = 88
        '
        'TLPBottom
        '
        Me.TLPBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPBottom.ColumnCount = 7
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.Controls.Add(Me.BtnPrint, 2, 0)
        Me.TLPBottom.Controls.Add(Me.BtnSaerch, 6, 0)
        Me.TLPBottom.Controls.Add(Me.BtnPrintAll, 0, 0)
        Me.TLPBottom.Controls.Add(Me.BtnNew, 4, 0)
        Me.TLPBottom.Location = New System.Drawing.Point(19, 187)
        Me.TLPBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBottom.Name = "TLPBottom"
        Me.TLPBottom.RowCount = 1
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPBottom.Size = New System.Drawing.Size(1001, 40)
        Me.TLPBottom.TabIndex = 1237
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(1002, 159)
        Me.GroupBox2.TabIndex = 1236
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بحث حسب"
        '
        'FrmPurchasesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 545)
        Me.Controls.Add(Me.TLPPages)
        Me.Controls.Add(Me.DGVPurchases)
        Me.Controls.Add(Me.TLPBottom)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchasesReport"
        Me.Text = "تقارير المشتريات"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        CType(Me.DGVPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPBottom.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnPrintAll As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ChkNum As CheckBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents ChkUser As CheckBox
    Friend WithEvents CmbUserName As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkSupplier As CheckBox
    Friend WithEvents CmbSupplier As ComboBox
    Friend WithEvents BtnSaerch As Button
    Friend WithEvents TLPPages As TableLayoutPanel
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents TxtPagesCount As TextBox
    Friend WithEvents TxtPageNum As TextBox
    Friend WithEvents NUDPageSize As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnLastPage As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnNextPage As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents BtnPreviousPage As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnFirstPage As Button
    Friend WithEvents DGVPurchases As DataGridView
    Friend WithEvents TLPBottom As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ColShow As DataGridViewButtonColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
End Class
