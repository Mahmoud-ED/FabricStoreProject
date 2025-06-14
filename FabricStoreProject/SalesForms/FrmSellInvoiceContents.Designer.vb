<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSellInvoiceContents
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSellInvoiceContents))
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.TxtSumValue = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtStore = New System.Windows.Forms.Label()
        Me.TxtInvoNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVInvoContent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlTitel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(431, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(167, 28)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "تفاصيل الفاتورة  "
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSumValue
        '
        Me.TxtSumValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSumValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSumValue.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSumValue.ForeColor = System.Drawing.Color.Black
        Me.TxtSumValue.Location = New System.Drawing.Point(0, 0)
        Me.TxtSumValue.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSumValue.Name = "TxtSumValue"
        Me.TxtSumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSumValue.Size = New System.Drawing.Size(294, 34)
        Me.TxtSumValue.TabIndex = 1282
        Me.TxtSumValue.Tag = "AutoC"
        Me.TxtSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TableLayoutPanel11)
        Me.GroupBox8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(24, 38)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox8.Size = New System.Drawing.Size(993, 86)
        Me.GroupBox8.TabIndex = 1236
        Me.GroupBox8.TabStop = False
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 7
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel11.Controls.Add(Me.TxtStore, 6, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TxtInvoNum, 3, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TxtUserName, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label3, 5, 0)
        Me.TableLayoutPanel11.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(19, 32)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(961, 37)
        Me.TableLayoutPanel11.TabIndex = 1208
        '
        'TxtStore
        '
        Me.TxtStore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStore.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtStore.ForeColor = System.Drawing.Color.Black
        Me.TxtStore.Location = New System.Drawing.Point(0, 1)
        Me.TxtStore.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtStore.Name = "TxtStore"
        Me.TxtStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtStore.Size = New System.Drawing.Size(298, 35)
        Me.TxtStore.TabIndex = 1281
        Me.TxtStore.Tag = "AutoC"
        Me.TxtStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvoNum
        '
        Me.TxtInvoNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtInvoNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtInvoNum.ForeColor = System.Drawing.Color.Black
        Me.TxtInvoNum.Location = New System.Drawing.Point(376, 1)
        Me.TxtInvoNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtInvoNum.Name = "TxtInvoNum"
        Me.TxtInvoNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtInvoNum.Size = New System.Drawing.Size(197, 35)
        Me.TxtInvoNum.TabIndex = 1280
        Me.TxtInvoNum.Tag = "AutoC"
        Me.TxtInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(874, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(85, 37)
        Me.Label1.TabIndex = 1244
        Me.Label1.Text = "المستخدم"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtUserName.ForeColor = System.Drawing.Color.Black
        Me.TxtUserName.Location = New System.Drawing.Point(675, 1)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUserName.Size = New System.Drawing.Size(197, 35)
        Me.TxtUserName.TabIndex = 1279
        Me.TxtUserName.Tag = "AutoC"
        Me.TxtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(575, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(98, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "رقم الفاتورة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(300, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 31)
        Me.Label3.TabIndex = 1245
        Me.Label3.Text = "الزبون"
        '
        'DGVInvoContent
        '
        Me.DGVInvoContent.AllowUserToAddRows = False
        Me.DGVInvoContent.AllowUserToResizeRows = False
        Me.DGVInvoContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVInvoContent.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVInvoContent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVInvoContent.ColumnHeadersHeight = 32
        Me.DGVInvoContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVInvoContent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column9, Me.Column2, Me.PruchPrice, Me.Quantity, Me.TotalAll, Me.Column4, Me.Column1, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVInvoContent.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVInvoContent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVInvoContent.Location = New System.Drawing.Point(24, 143)
        Me.DGVInvoContent.MultiSelect = False
        Me.DGVInvoContent.Name = "DGVInvoContent"
        Me.DGVInvoContent.ReadOnly = True
        Me.DGVInvoContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVInvoContent.RowHeadersVisible = False
        Me.DGVInvoContent.RowHeadersWidth = 51
        Me.DGVInvoContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVInvoContent.RowTemplate.Height = 30
        Me.DGVInvoContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInvoContent.Size = New System.Drawing.Size(993, 389)
        Me.DGVInvoContent.TabIndex = 1235
        Me.DGVInvoContent.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "رقم الصنف"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "الصنف"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'PruchPrice
        '
        Me.PruchPrice.HeaderText = "السعر"
        Me.PruchPrice.MinimumWidth = 6
        Me.PruchPrice.Name = "PruchPrice"
        Me.PruchPrice.ReadOnly = True
        Me.PruchPrice.Width = 150
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "الكمية"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'TotalAll
        '
        Me.TotalAll.HeaderText = "الإجمالي"
        Me.TotalAll.MinimumWidth = 6
        Me.TotalAll.Name = "TotalAll"
        Me.TotalAll.ReadOnly = True
        Me.TotalAll.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "النوع"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم الطلب"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "الخدمة"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "الخياط"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "المقاس"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "تاريخ الاستلام"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "المكان"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.DGVInvoContent)
        Me.Panel1.Controls.Add(Me.PnlTitel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1034, 602)
        Me.Panel1.TabIndex = 1242
        Me.Panel1.Tag = "Background"
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
        Me.PnlTitel.Size = New System.Drawing.Size(1028, 28)
        Me.PnlTitel.TabIndex = 30
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPrint, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 4, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 549)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(993, 40)
        Me.TableLayoutPanel1.TabIndex = 1285
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
        Me.BtnPrint.Location = New System.Drawing.Point(698, 2)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(293, 36)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(312, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(293, 35)
        Me.Label4.TabIndex = 1239
        Me.Label4.Text = "الإجمالي"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtSumValue)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 34)
        Me.Panel2.TabIndex = 1240
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(2, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(37, 30)
        Me.Label5.TabIndex = 1238
        Me.Label5.Tag = "AutoC"
        Me.Label5.Text = "د.ل"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSellInvoiceContents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 608)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSellInvoiceContents"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "تفاصيل الفاتورة"
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PnlTitel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitel As Label
    Friend WithEvents TxtSumValue As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TxtStore As Label
    Friend WithEvents TxtInvoNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVInvoContent As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PruchPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalAll As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
End Class
