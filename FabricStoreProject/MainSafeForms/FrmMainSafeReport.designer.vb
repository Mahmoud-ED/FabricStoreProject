<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainSafeReport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainSafeReport))
        Me.DGVMainSafe = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColShow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CmbUser = New System.Windows.Forms.ComboBox()
        Me.ChkDay = New System.Windows.Forms.CheckBox()
        Me.ChkUserReport = New System.Windows.Forms.CheckBox()
        Me.CmbDay = New System.Windows.Forms.ComboBox()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSumValue = New System.Windows.Forms.Label()
        CType(Me.DGVMainSafe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVMainSafe
        '
        Me.DGVMainSafe.AllowUserToAddRows = False
        Me.DGVMainSafe.AllowUserToDeleteRows = False
        Me.DGVMainSafe.AllowUserToResizeRows = False
        Me.DGVMainSafe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVMainSafe.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVMainSafe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMainSafe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMainSafe.ColumnHeadersHeight = 32
        Me.DGVMainSafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVMainSafe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.UserID, Me.ColPrint, Me.ColShow})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMainSafe.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVMainSafe.EnableHeadersVisualStyles = False
        Me.DGVMainSafe.GridColor = System.Drawing.Color.Gray
        Me.DGVMainSafe.Location = New System.Drawing.Point(31, 191)
        Me.DGVMainSafe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVMainSafe.MultiSelect = False
        Me.DGVMainSafe.Name = "DGVMainSafe"
        Me.DGVMainSafe.ReadOnly = True
        Me.DGVMainSafe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVMainSafe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVMainSafe.RowHeadersVisible = False
        Me.DGVMainSafe.RowHeadersWidth = 51
        Me.DGVMainSafe.RowTemplate.Height = 30
        Me.DGVMainSafe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMainSafe.Size = New System.Drawing.Size(1413, 517)
        Me.DGVMainSafe.TabIndex = 9
        Me.DGVMainSafe.Tag = "Dark-SelectionVisible"
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.FillWeight = 40.0!
        Me.Column2.HeaderText = "ت"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'Column3
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "التاريخ"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "الموظف"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "القيمة نقدي"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "طرق الدفع"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "المصروفات"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "المستلم في الخزينة"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 300
        '
        'UserID
        '
        Me.UserID.HeaderText = "UserID"
        Me.UserID.MinimumWidth = 6
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Visible = False
        Me.UserID.Width = 125
        '
        'ColPrint
        '
        Me.ColPrint.HeaderText = ""
        Me.ColPrint.MinimumWidth = 6
        Me.ColPrint.Name = "ColPrint"
        Me.ColPrint.ReadOnly = True
        Me.ColPrint.Text = "طباعة"
        Me.ColPrint.UseColumnTextForButtonValue = True
        Me.ColPrint.Width = 125
        '
        'ColShow
        '
        Me.ColShow.HeaderText = ""
        Me.ColShow.MinimumWidth = 6
        Me.ColShow.Name = "ColShow"
        Me.ColShow.ReadOnly = True
        Me.ColShow.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColShow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColShow.Text = "عرض"
        Me.ColShow.UseColumnTextForButtonValue = True
        Me.ColShow.Width = 102
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(31, 9)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox8.Size = New System.Drawing.Size(1413, 105)
        Me.GroupBox8.TabIndex = 1208
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "بحث حسب"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1581!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1581!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1581!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.52569!))
        Me.TableLayoutPanel2.Controls.Add(Me.CmbUser, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkDay, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkUserReport, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CmbDay, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CmbYear, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CmbMonth, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(20, 34)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1178, 53)
        Me.TableLayoutPanel2.TabIndex = 1228
        '
        'CmbUser
        '
        Me.CmbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUser.DropDownHeight = 200
        Me.CmbUser.Enabled = False
        Me.CmbUser.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUser.FormattingEnabled = True
        Me.CmbUser.IntegralHeight = False
        Me.CmbUser.Location = New System.Drawing.Point(3, 5)
        Me.CmbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbUser.Name = "CmbUser"
        Me.CmbUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbUser.Size = New System.Drawing.Size(283, 42)
        Me.CmbUser.TabIndex = 1239
        '
        'ChkDay
        '
        Me.ChkDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDay.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDay.Location = New System.Drawing.Point(1072, 2)
        Me.ChkDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkDay.Name = "ChkDay"
        Me.ChkDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkDay.Size = New System.Drawing.Size(103, 49)
        Me.ChkDay.TabIndex = 1246
        Me.ChkDay.Text = "اليوم"
        Me.ChkDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkDay.UseVisualStyleBackColor = True
        '
        'ChkUserReport
        '
        Me.ChkUserReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkUserReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkUserReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUserReport.Location = New System.Drawing.Point(292, 2)
        Me.ChkUserReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkUserReport.Name = "ChkUserReport"
        Me.ChkUserReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUserReport.Size = New System.Drawing.Size(151, 49)
        Me.ChkUserReport.TabIndex = 1243
        Me.ChkUserReport.Text = "المستخدم"
        Me.ChkUserReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkUserReport.UseVisualStyleBackColor = True
        '
        'CmbDay
        '
        Me.CmbDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbDay.DropDownHeight = 300
        Me.CmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDay.Enabled = False
        Me.CmbDay.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDay.FormattingEnabled = True
        Me.CmbDay.IntegralHeight = False
        Me.CmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CmbDay.Location = New System.Drawing.Point(926, 5)
        Me.CmbDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbDay.Name = "CmbDay"
        Me.CmbDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbDay.Size = New System.Drawing.Size(140, 42)
        Me.CmbDay.TabIndex = 1245
        '
        'CmbYear
        '
        Me.CmbYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Location = New System.Drawing.Point(462, 5)
        Me.CmbYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbYear.Size = New System.Drawing.Size(140, 42)
        Me.CmbYear.TabIndex = 1241
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(608, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 53)
        Me.Label2.TabIndex = 1243
        Me.Label2.Text = "السنة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(834, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 53)
        Me.Label1.TabIndex = 1242
        Me.Label1.Text = "الشهر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbMonth
        '
        Me.CmbMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonth.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMonth.FormattingEnabled = True
        Me.CmbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbMonth.Location = New System.Drawing.Point(688, 5)
        Me.CmbMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbMonth.Name = "CmbMonth"
        Me.CmbMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbMonth.Size = New System.Drawing.Size(140, 42)
        Me.CmbMonth.TabIndex = 1240
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(461, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(193, 49)
        Me.Label9.TabIndex = 1225
        Me.Label9.Text = "المستلم في الخزينة"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.BtnSearch, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnRefresh, 2, 0)
        Me.TableLayoutPanel5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(31, 138)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1413, 49)
        Me.TableLayoutPanel5.TabIndex = 1216
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(713, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(700, 45)
        Me.BtnSearch.TabIndex = 46
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
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
        Me.BtnRefresh.Location = New System.Drawing.Point(0, 2)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefresh.Size = New System.Drawing.Size(700, 45)
        Me.BtnRefresh.TabIndex = 1210
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 714)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(657, 49)
        Me.TableLayoutPanel1.TabIndex = 1227
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtSumValue)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 49)
        Me.Panel1.TabIndex = 1226
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(7, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(48, 37)
        Me.Label13.TabIndex = 1224
        Me.Label13.Tag = "AutoC"
        Me.Label13.Text = "د.ل"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSumValue
        '
        Me.TxtSumValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSumValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSumValue.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSumValue.ForeColor = System.Drawing.Color.Black
        Me.TxtSumValue.Location = New System.Drawing.Point(3, 2)
        Me.TxtSumValue.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSumValue.Name = "TxtSumValue"
        Me.TxtSumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSumValue.Size = New System.Drawing.Size(452, 43)
        Me.TxtSumValue.TabIndex = 1280
        Me.TxtSumValue.Tag = "AutoC"
        Me.TxtSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMainSafeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 788)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.DGVMainSafe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMainSafeReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تقارير المناوبات المغلقة"
        CType(Me.DGVMainSafe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVMainSafe As DataGridView
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CmbUser As ComboBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ChkUserReport As CheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents CmbDay As ComboBox
    Friend WithEvents ChkDay As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents CmbMonth As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtSumValue As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents ColPrint As DataGridViewButtonColumn
    Friend WithEvents ColShow As DataGridViewButtonColumn
End Class
