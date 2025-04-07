<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeliveryOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeliveryOrder))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdid = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ChkUser = New System.Windows.Forms.CheckBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChkNum = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.ChkDelivery = New System.Windows.Forms.CheckBox()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkCity = New System.Windows.Forms.CheckBox()
        Me.ChkOrder = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.CmbDelivery = New System.Windows.Forms.ComboBox()
        Me.CmbCity = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadReady = New System.Windows.Forms.RadioButton()
        Me.RadOrder = New System.Windows.Forms.RadioButton()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        Me.TLPBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrintAll = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NUDPageSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.BtnPreviousPage = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtnNextPage = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BtnLastPage = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtPageNum = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnFirstPage = New System.Windows.Forms.Button()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.TLPOrderDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPDeliveryData = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtDeliveryPrice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CmbDeliveryOrder = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbCityOrder = New System.Windows.Forms.ComboBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.PnlState = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.BtnSell = New System.Windows.Forms.Button()
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.LblOrderState = New System.Windows.Forms.Label()
        Me.PnlOrderState = New System.Windows.Forms.Panel()
        Me.LblOrderData = New System.Windows.Forms.Label()
        Me.PnlOrderData = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlEditOrder = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TLPBottom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.TLPPages.SuspendLayout()
        Me.TLPOrderDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TLPDeliveryData.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.PnlState.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PnlButtons.SuspendLayout()
        Me.PnlEditOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 32
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column12, Me.Column4, Me.Column2, Me.Column3, Me.Column6, Me.Column5, Me.Column7, Me.Column1, Me.Column14, Me.Column9, Me.Column10, Me.Column13, Me.Column16, Me.ColEdid, Me.ColDel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(19, 275)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 30
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1002, 217)
        Me.DGV.TabIndex = 1252
        Me.DGV.Tag = "Dark-SelectionVisible"
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
        'Column4
        '
        Me.Column4.HeaderText = "شركة التوصيل"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الزبون"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 360
        '
        'Column3
        '
        Me.Column3.HeaderText = "المدينة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "الهاتف"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "سعر الفاتورة"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "سعر التوصيل"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "الاجمالي"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "تاريخ التسجيل"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "تاريخ التسليم"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "CityID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "DeliveryID"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column16
        '
        Me.Column16.HeaderText = "Address"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Visible = False
        '
        'ColEdid
        '
        Me.ColEdid.HeaderText = ""
        Me.ColEdid.Name = "ColEdid"
        Me.ColEdid.ReadOnly = True
        Me.ColEdid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEdid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColEdid.Text = "تعديل"
        Me.ColEdid.UseColumnTextForButtonValue = True
        '
        'ColDel
        '
        Me.ColDel.HeaderText = ""
        Me.ColDel.Name = "ColDel"
        Me.ColDel.ReadOnly = True
        Me.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColDel.Text = "إلغاء"
        Me.ColDel.UseColumnTextForButtonValue = True
        '
        'ChkUser
        '
        Me.ChkUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkUser.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkUser.Location = New System.Drawing.Point(0, 0)
        Me.ChkUser.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkUser.Name = "ChkUser"
        Me.ChkUser.Size = New System.Drawing.Size(167, 48)
        Me.ChkUser.TabIndex = 1
        Me.ChkUser.Text = "المستخدم"
        Me.ChkUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkUser.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.ChkUser)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(320, 104)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(167, 48)
        Me.Panel21.TabIndex = 45
        '
        'ChkDate
        '
        Me.ChkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkDate.Location = New System.Drawing.Point(0, 0)
        Me.ChkDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(167, 47)
        Me.ChkDate.TabIndex = 2
        Me.ChkDate.Text = "تاريخ الفاتورة  :  من"
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ChkDate)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(320, 53)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(167, 47)
        Me.Panel7.TabIndex = 51
        '
        'ChkNum
        '
        Me.ChkNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkNum.Location = New System.Drawing.Point(0, 0)
        Me.ChkNum.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkNum.Name = "ChkNum"
        Me.ChkNum.Size = New System.Drawing.Size(167, 47)
        Me.ChkNum.TabIndex = 0
        Me.ChkNum.Text = "رقم الفاتورة"
        Me.ChkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkNum.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.ChkNum)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(320, 2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(167, 47)
        Me.Panel9.TabIndex = 0
        '
        'DTPFrom
        '
        Me.DTPFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFrom.CustomFormat = ""
        Me.DTPFrom.Enabled = False
        Me.DTPFrom.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(183, 6)
        Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPFrom.RightToLeftLayout = True
        Me.DTPFrom.Size = New System.Drawing.Size(133, 35)
        Me.DTPFrom.TabIndex = 42
        Me.DTPFrom.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'ChkDelivery
        '
        Me.ChkDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDelivery.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkDelivery.Location = New System.Drawing.Point(834, 2)
        Me.ChkDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkDelivery.Name = "ChkDelivery"
        Me.ChkDelivery.Size = New System.Drawing.Size(132, 47)
        Me.ChkDelivery.TabIndex = 1231
        Me.ChkDelivery.Text = "الشركة"
        Me.ChkDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkDelivery.UseVisualStyleBackColor = True
        '
        'DTPTo
        '
        Me.DTPTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPTo.CustomFormat = ""
        Me.DTPTo.Enabled = False
        Me.DTPTo.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(2, 6)
        Me.DTPTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPTo.RightToLeftLayout = True
        Me.DTPTo.Size = New System.Drawing.Size(134, 35)
        Me.DTPTo.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "إلى"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkCity
        '
        Me.ChkCity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkCity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkCity.Location = New System.Drawing.Point(834, 53)
        Me.ChkCity.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkCity.Name = "ChkCity"
        Me.ChkCity.Size = New System.Drawing.Size(132, 47)
        Me.ChkCity.TabIndex = 1236
        Me.ChkCity.Text = "المدينة"
        Me.ChkCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkCity.UseVisualStyleBackColor = True
        '
        'ChkOrder
        '
        Me.ChkOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkOrder.Location = New System.Drawing.Point(834, 104)
        Me.ChkOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkOrder.Name = "ChkOrder"
        Me.ChkOrder.Size = New System.Drawing.Size(132, 48)
        Me.ChkOrder.TabIndex = 2
        Me.ChkOrder.Text = "حالة الطلب"
        Me.ChkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkOrder.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel4.Controls.Add(Me.ChkCity, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkDelivery, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel9, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel21, 3, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtNum, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbDelivery, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbCity, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkOrder, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbUserName, 4, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(19, 31)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(968, 154)
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
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 53)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(318, 47)
        Me.TableLayoutPanel6.TabIndex = 1227
        '
        'TxtNum
        '
        Me.TxtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNum.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNum.Location = New System.Drawing.Point(2, 8)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNum.MaxLength = 6
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(314, 35)
        Me.TxtNum.TabIndex = 56
        Me.TxtNum.Tag = ""
        '
        'CmbDelivery
        '
        Me.CmbDelivery.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbDelivery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbDelivery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbDelivery.DropDownHeight = 160
        Me.CmbDelivery.Enabled = False
        Me.CmbDelivery.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbDelivery.FormattingEnabled = True
        Me.CmbDelivery.IntegralHeight = False
        Me.CmbDelivery.Location = New System.Drawing.Point(517, 7)
        Me.CmbDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbDelivery.Name = "CmbDelivery"
        Me.CmbDelivery.Size = New System.Drawing.Size(313, 35)
        Me.CmbDelivery.TabIndex = 1232
        '
        'CmbCity
        '
        Me.CmbCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCity.DropDownHeight = 160
        Me.CmbCity.Enabled = False
        Me.CmbCity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbCity.FormattingEnabled = True
        Me.CmbCity.IntegralHeight = False
        Me.CmbCity.Location = New System.Drawing.Point(517, 58)
        Me.CmbCity.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCity.Name = "CmbCity"
        Me.CmbCity.Size = New System.Drawing.Size(313, 35)
        Me.CmbCity.TabIndex = 1237
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.RadReady, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RadOrder, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(515, 102)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(317, 52)
        Me.TableLayoutPanel5.TabIndex = 1233
        '
        'RadReady
        '
        Me.RadReady.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadReady.AutoSize = True
        Me.RadReady.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadReady.Enabled = False
        Me.RadReady.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadReady.Location = New System.Drawing.Point(161, 10)
        Me.RadReady.Name = "RadReady"
        Me.RadReady.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadReady.Size = New System.Drawing.Size(153, 32)
        Me.RadReady.TabIndex = 1253
        Me.RadReady.Text = "تم التسليم"
        Me.RadReady.UseVisualStyleBackColor = True
        '
        'RadOrder
        '
        Me.RadOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadOrder.AutoSize = True
        Me.RadOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadOrder.Enabled = False
        Me.RadOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadOrder.Location = New System.Drawing.Point(3, 10)
        Me.RadOrder.Name = "RadOrder"
        Me.RadOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadOrder.Size = New System.Drawing.Size(152, 32)
        Me.RadOrder.TabIndex = 1252
        Me.RadOrder.Text = "جاهز  للتسليم"
        Me.RadOrder.UseVisualStyleBackColor = True
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
        Me.CmbUserName.Location = New System.Drawing.Point(2, 110)
        Me.CmbUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.Size = New System.Drawing.Size(314, 35)
        Me.CmbUserName.TabIndex = 41
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
        Me.TLPBottom.Controls.Add(Me.BtnSearch, 6, 0)
        Me.TLPBottom.Controls.Add(Me.BtnPrintAll, 0, 0)
        Me.TLPBottom.Controls.Add(Me.BtnNew, 4, 0)
        Me.TLPBottom.Location = New System.Drawing.Point(19, 225)
        Me.TLPBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBottom.Name = "TLPBottom"
        Me.TLPBottom.RowCount = 1
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPBottom.Size = New System.Drawing.Size(1001, 40)
        Me.TLPBottom.TabIndex = 1251
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
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(756, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(245, 36)
        Me.BtnSearch.TabIndex = 29
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Size = New System.Drawing.Size(1002, 199)
        Me.GroupBox2.TabIndex = 1250
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بحث حسب"
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
        Me.TLPPages.TabIndex = 1253
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
        'TLPOrderDetails
        '
        Me.TLPOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TLPOrderDetails.ColumnCount = 1
        Me.TLPOrderDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPOrderDetails.Controls.Add(Me.Panel2, 0, 1)
        Me.TLPOrderDetails.Controls.Add(Me.Panel6, 0, 2)
        Me.TLPOrderDetails.Controls.Add(Me.PnlEditOrder, 0, 0)
        Me.TLPOrderDetails.Location = New System.Drawing.Point(250, 113)
        Me.TLPOrderDetails.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.TLPOrderDetails.Name = "TLPOrderDetails"
        Me.TLPOrderDetails.RowCount = 3
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.Size = New System.Drawing.Size(541, 359)
        Me.TLPOrderDetails.TabIndex = 1254
        Me.TLPOrderDetails.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlData)
        Me.Panel2.Controls.Add(Me.PnlState)
        Me.Panel2.Controls.Add(Me.PnlButtons)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 291)
        Me.Panel2.TabIndex = 1248
        '
        'PnlData
        '
        Me.PnlData.AutoScroll = True
        Me.PnlData.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 45)
        Me.PnlData.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(535, 246)
        Me.PnlData.TabIndex = 64
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TLPDeliveryData, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(535, 246)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TLPDeliveryData
        '
        Me.TLPDeliveryData.ColumnCount = 2
        Me.TLPDeliveryData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TLPDeliveryData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPDeliveryData.Controls.Add(Me.Label21, 0, 4)
        Me.TLPDeliveryData.Controls.Add(Me.TxtDeliveryPrice, 1, 3)
        Me.TLPDeliveryData.Controls.Add(Me.Label17, 0, 3)
        Me.TLPDeliveryData.Controls.Add(Me.Label18, 0, 1)
        Me.TLPDeliveryData.Controls.Add(Me.CmbDeliveryOrder, 1, 0)
        Me.TLPDeliveryData.Controls.Add(Me.Label19, 0, 2)
        Me.TLPDeliveryData.Controls.Add(Me.Label20, 0, 0)
        Me.TLPDeliveryData.Controls.Add(Me.CmbCityOrder, 1, 1)
        Me.TLPDeliveryData.Controls.Add(Me.TxtAddress, 1, 2)
        Me.TLPDeliveryData.Controls.Add(Me.TxtPhone, 1, 4)
        Me.TLPDeliveryData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPDeliveryData.Location = New System.Drawing.Point(0, 0)
        Me.TLPDeliveryData.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPDeliveryData.Name = "TLPDeliveryData"
        Me.TLPDeliveryData.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.TLPDeliveryData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPDeliveryData.RowCount = 5
        Me.TLPDeliveryData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPDeliveryData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPDeliveryData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPDeliveryData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPDeliveryData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPDeliveryData.Size = New System.Drawing.Size(535, 196)
        Me.TLPDeliveryData.TabIndex = 847
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(429, 153)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(104, 38)
        Me.Label21.TabIndex = 1291
        Me.Label21.Text = "رقم الهاتف"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDeliveryPrice
        '
        Me.TxtDeliveryPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDeliveryPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryPrice.Location = New System.Drawing.Point(12, 117)
        Me.TxtDeliveryPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtDeliveryPrice.MaxLength = 8
        Me.TxtDeliveryPrice.Name = "TxtDeliveryPrice"
        Me.TxtDeliveryPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDeliveryPrice.Size = New System.Drawing.Size(413, 35)
        Me.TxtDeliveryPrice.TabIndex = 4
        Me.TxtDeliveryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label17.Location = New System.Drawing.Point(429, 116)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(104, 37)
        Me.Label17.TabIndex = 1287
        Me.Label17.Text = "السعر"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label18.Location = New System.Drawing.Point(429, 42)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(104, 37)
        Me.Label18.TabIndex = 1286
        Me.Label18.Text = "المدينة"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbDeliveryOrder
        '
        Me.CmbDeliveryOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbDeliveryOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbDeliveryOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbDeliveryOrder.DropDownHeight = 160
        Me.CmbDeliveryOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbDeliveryOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDeliveryOrder.FormattingEnabled = True
        Me.CmbDeliveryOrder.IntegralHeight = False
        Me.CmbDeliveryOrder.Location = New System.Drawing.Point(10, 5)
        Me.CmbDeliveryOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbDeliveryOrder.Name = "CmbDeliveryOrder"
        Me.CmbDeliveryOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbDeliveryOrder.Size = New System.Drawing.Size(417, 35)
        Me.CmbDeliveryOrder.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label19.Location = New System.Drawing.Point(429, 79)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(104, 37)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "العنوان"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label20.Location = New System.Drawing.Point(429, 5)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(104, 37)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "الشركة"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCityOrder
        '
        Me.CmbCityOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCityOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCityOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCityOrder.DropDownHeight = 160
        Me.CmbCityOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbCityOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCityOrder.FormattingEnabled = True
        Me.CmbCityOrder.IntegralHeight = False
        Me.CmbCityOrder.Location = New System.Drawing.Point(10, 42)
        Me.CmbCityOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbCityOrder.Name = "CmbCityOrder"
        Me.CmbCityOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCityOrder.Size = New System.Drawing.Size(417, 35)
        Me.CmbCityOrder.TabIndex = 2
        '
        'TxtAddress
        '
        Me.TxtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAddress.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(12, 80)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtAddress.MaxLength = 8
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddress.Size = New System.Drawing.Size(413, 35)
        Me.TxtAddress.TabIndex = 3
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPhone
        '
        Me.TxtPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone.BackColor = System.Drawing.Color.White
        Me.TxtPhone.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone.Location = New System.Drawing.Point(12, 155)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone.MaxLength = 10
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(413, 35)
        Me.TxtPhone.TabIndex = 5
        Me.TxtPhone.Tag = "10"
        Me.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 199)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(529, 42)
        Me.TableLayoutPanel7.TabIndex = 1248
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
        Me.BtnSave.Location = New System.Drawing.Point(33, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(463, 36)
        Me.BtnSave.TabIndex = 846
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'PnlState
        '
        Me.PnlState.AutoScroll = True
        Me.PnlState.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlState.Location = New System.Drawing.Point(0, 45)
        Me.PnlState.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlState.Name = "PnlState"
        Me.PnlState.Size = New System.Drawing.Size(535, 246)
        Me.PnlState.TabIndex = 67
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSend, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSell, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(535, 246)
        Me.TableLayoutPanel2.TabIndex = 1248
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSend.FlatAppearance.BorderSize = 0
        Me.BtnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.Image = CType(resources.GetObject("BtnSend.Image"), System.Drawing.Image)
        Me.BtnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSend.Location = New System.Drawing.Point(33, 43)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(469, 67)
        Me.BtnSend.TabIndex = 846
        Me.BtnSend.Tag = "Dark"
        Me.BtnSend.Text = "تسليم للتوصيل"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'BtnSell
        '
        Me.BtnSell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSell.FlatAppearance.BorderSize = 0
        Me.BtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSell.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSell.ForeColor = System.Drawing.Color.White
        Me.BtnSell.Image = CType(resources.GetObject("BtnSell.Image"), System.Drawing.Image)
        Me.BtnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSell.Location = New System.Drawing.Point(33, 136)
        Me.BtnSell.Name = "BtnSell"
        Me.BtnSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSell.Size = New System.Drawing.Size(469, 67)
        Me.BtnSell.TabIndex = 847
        Me.BtnSell.Tag = "Dark"
        Me.BtnSell.Text = "تسليم للزبون"
        Me.BtnSell.UseVisualStyleBackColor = False
        '
        'PnlButtons
        '
        Me.PnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlButtons.Controls.Add(Me.LblOrderState)
        Me.PnlButtons.Controls.Add(Me.PnlOrderState)
        Me.PnlButtons.Controls.Add(Me.LblOrderData)
        Me.PnlButtons.Controls.Add(Me.PnlOrderData)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 0)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(535, 45)
        Me.PnlButtons.TabIndex = 66
        Me.PnlButtons.Tag = "Primary"
        '
        'LblOrderState
        '
        Me.LblOrderState.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOrderState.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblOrderState.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderState.ForeColor = System.Drawing.Color.White
        Me.LblOrderState.Location = New System.Drawing.Point(85, 4)
        Me.LblOrderState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblOrderState.Name = "LblOrderState"
        Me.LblOrderState.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblOrderState.Size = New System.Drawing.Size(161, 28)
        Me.LblOrderState.TabIndex = 11
        Me.LblOrderState.Text = "حالة الطلب"
        Me.LblOrderState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlOrderState
        '
        Me.PnlOrderState.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlOrderState.BackColor = System.Drawing.Color.White
        Me.PnlOrderState.Location = New System.Drawing.Point(85, 33)
        Me.PnlOrderState.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlOrderState.Name = "PnlOrderState"
        Me.PnlOrderState.Size = New System.Drawing.Size(161, 4)
        Me.PnlOrderState.TabIndex = 10
        Me.PnlOrderState.Visible = False
        '
        'LblOrderData
        '
        Me.LblOrderData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOrderData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblOrderData.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderData.ForeColor = System.Drawing.Color.White
        Me.LblOrderData.Location = New System.Drawing.Point(289, 4)
        Me.LblOrderData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblOrderData.Name = "LblOrderData"
        Me.LblOrderData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblOrderData.Size = New System.Drawing.Size(161, 28)
        Me.LblOrderData.TabIndex = 9
        Me.LblOrderData.Text = "بيانات الطلب"
        Me.LblOrderData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlOrderData
        '
        Me.PnlOrderData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlOrderData.BackColor = System.Drawing.Color.White
        Me.PnlOrderData.Location = New System.Drawing.Point(289, 33)
        Me.PnlOrderData.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlOrderData.Name = "PnlOrderData"
        Me.PnlOrderData.Size = New System.Drawing.Size(161, 4)
        Me.PnlOrderData.TabIndex = 8
        Me.PnlOrderData.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 330)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(537, 27)
        Me.Panel6.TabIndex = 1246
        Me.Panel6.TabStop = True
        Me.Panel6.Tag = "Dark"
        '
        'PnlEditOrder
        '
        Me.PnlEditOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlEditOrder.Controls.Add(Me.BtnClose)
        Me.PnlEditOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlEditOrder.Location = New System.Drawing.Point(2, 2)
        Me.PnlEditOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlEditOrder.Name = "PnlEditOrder"
        Me.PnlEditOrder.Size = New System.Drawing.Size(537, 27)
        Me.PnlEditOrder.TabIndex = 1245
        Me.PnlEditOrder.TabStop = True
        Me.PnlEditOrder.Tag = "Dark"
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
        Me.BtnClose.Size = New System.Drawing.Size(33, 27)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmDeliveryOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 545)
        Me.Controls.Add(Me.TLPOrderDetails)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TLPBottom)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TLPPages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDeliveryOrder"
        Me.Text = "طلبات التوصيل"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TLPBottom.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        Me.TLPOrderDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnlData.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TLPDeliveryData.ResumeLayout(False)
        Me.TLPDeliveryData.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.PnlState.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PnlButtons.ResumeLayout(False)
        Me.PnlEditOrder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BtnFirstPage As Button
    Friend WithEvents ChkUser As CheckBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ChkNum As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents ChkDelivery As CheckBox
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkCity As CheckBox
    Friend WithEvents ChkOrder As CheckBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents CmbUserName As ComboBox
    Friend WithEvents CmbDelivery As ComboBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RadReady As RadioButton
    Friend WithEvents RadOrder As RadioButton
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents CmbCity As ComboBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrintAll As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TLPBottom As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NUDPageSize As NumericUpDown
    Friend WithEvents BtnPreviousPage As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents BtnNextPage As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnLastPage As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents TxtPagesCount As TextBox
    Friend WithEvents TxtPageNum As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TLPPages As TableLayoutPanel
    Friend WithEvents TLPOrderDetails As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlData As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents PnlState As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnSell As Button
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents LblOrderState As Label
    Friend WithEvents PnlOrderState As Panel
    Friend WithEvents LblOrderData As Label
    Friend WithEvents PnlOrderData As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PnlEditOrder As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents TLPDeliveryData As TableLayoutPanel
    Friend WithEvents TxtDeliveryPrice As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CmbDeliveryOrder As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbCityOrder As ComboBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents ColEdid As DataGridViewButtonColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
    Friend WithEvents BtnSend As Button
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label21 As Label
End Class
