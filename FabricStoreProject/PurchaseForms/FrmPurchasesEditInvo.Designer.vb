<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasesEditInvo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchasesEditInvo))
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TLPData = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtName = New System.Windows.Forms.Label()
        Me.الاسم = New System.Windows.Forms.Label()
        Me.السعر = New System.Windows.Forms.Label()
        Me.الكمية = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtPurchasPrice = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVInvoContent = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSumValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtInvoNum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSupplier = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PnlTitel.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TLPData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(238, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(339, 28)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "محتويات الفاتورة"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PnlTitel.Size = New System.Drawing.Size(814, 28)
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TLPData)
        Me.GroupBox8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox8.Size = New System.Drawing.Size(779, 86)
        Me.GroupBox8.TabIndex = 1236
        Me.GroupBox8.TabStop = False
        '
        'TLPData
        '
        Me.TLPData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPData.ColumnCount = 7
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TLPData.Controls.Add(Me.TxtName, 1, 0)
        Me.TLPData.Controls.Add(Me.الاسم, 0, 0)
        Me.TLPData.Controls.Add(Me.السعر, 2, 0)
        Me.TLPData.Controls.Add(Me.الكمية, 5, 0)
        Me.TLPData.Controls.Add(Me.TxtQuantity, 6, 0)
        Me.TLPData.Controls.Add(Me.TxtPurchasPrice, 3, 0)
        Me.TLPData.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPData.Location = New System.Drawing.Point(19, 32)
        Me.TLPData.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPData.Name = "TLPData"
        Me.TLPData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPData.RowCount = 1
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPData.Size = New System.Drawing.Size(747, 37)
        Me.TLPData.TabIndex = 1208
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtName.ForeColor = System.Drawing.Color.Black
        Me.TxtName.Location = New System.Drawing.Point(522, 1)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtName.Size = New System.Drawing.Size(136, 35)
        Me.TxtName.TabIndex = 1282
        Me.TxtName.Tag = "AutoC"
        Me.TxtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'الاسم
        '
        Me.الاسم.Dock = System.Windows.Forms.DockStyle.Fill
        Me.الاسم.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.الاسم.ForeColor = System.Drawing.SystemColors.WindowText
        Me.الاسم.Location = New System.Drawing.Point(660, 0)
        Me.الاسم.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.الاسم.Name = "الاسم"
        Me.الاسم.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.الاسم.Size = New System.Drawing.Size(85, 37)
        Me.الاسم.TabIndex = 1244
        Me.الاسم.Text = "الاسم"
        Me.الاسم.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'السعر
        '
        Me.السعر.Dock = System.Windows.Forms.DockStyle.Fill
        Me.السعر.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.السعر.ForeColor = System.Drawing.SystemColors.WindowText
        Me.السعر.Location = New System.Drawing.Point(422, 0)
        Me.السعر.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.السعر.Name = "السعر"
        Me.السعر.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.السعر.Size = New System.Drawing.Size(98, 37)
        Me.السعر.TabIndex = 37
        Me.السعر.Text = "السعر"
        Me.السعر.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'الكمية
        '
        Me.الكمية.AutoSize = True
        Me.الكمية.Dock = System.Windows.Forms.DockStyle.Top
        Me.الكمية.Location = New System.Drawing.Point(208, 0)
        Me.الكمية.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.الكمية.Name = "الكمية"
        Me.الكمية.Size = New System.Drawing.Size(68, 31)
        Me.الكمية.TabIndex = 1245
        Me.الكمية.Text = "الكمية"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(0, 1)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtQuantity.MaxLength = 10
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtQuantity.Size = New System.Drawing.Size(206, 35)
        Me.TxtQuantity.TabIndex = 2
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPurchasPrice
        '
        Me.TxtPurchasPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchasPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchasPrice.Location = New System.Drawing.Point(284, 1)
        Me.TxtPurchasPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPurchasPrice.MaxLength = 8
        Me.TxtPurchasPrice.Name = "TxtPurchasPrice"
        Me.TxtPurchasPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPurchasPrice.Size = New System.Drawing.Size(136, 35)
        Me.TxtPurchasPrice.TabIndex = 1
        Me.TxtPurchasPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGVInvoContent)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.PnlTitel)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(820, 610)
        Me.Panel1.TabIndex = 1242
        Me.Panel1.Tag = "Background"
        '
        'DGVInvoContent
        '
        Me.DGVInvoContent.AllowUserToAddRows = False
        Me.DGVInvoContent.AllowUserToResizeRows = False
        Me.DGVInvoContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVInvoContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.DGVInvoContent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn4, Me.Column1, Me.Column2, Me.PruchPrice, Me.Quantity, Me.TotalAll})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVInvoContent.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVInvoContent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVInvoContent.Location = New System.Drawing.Point(24, 179)
        Me.DGVInvoContent.MultiSelect = False
        Me.DGVInvoContent.Name = "DGVInvoContent"
        Me.DGVInvoContent.ReadOnly = True
        Me.DGVInvoContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVInvoContent.RowHeadersVisible = False
        Me.DGVInvoContent.RowHeadersWidth = 51
        Me.DGVInvoContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVInvoContent.RowTemplate.Height = 30
        Me.DGVInvoContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInvoContent.Size = New System.Drawing.Size(779, 341)
        Me.DGVInvoContent.TabIndex = 1235
        Me.DGVInvoContent.Tag = "Dark-SelectionVisible"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "الرقم"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الصنف"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'PruchPrice
        '
        Me.PruchPrice.HeaderText = "السعر"
        Me.PruchPrice.MinimumWidth = 6
        Me.PruchPrice.Name = "PruchPrice"
        Me.PruchPrice.ReadOnly = True
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
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPrint, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnClean, 2, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(104, 128)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(613, 40)
        Me.TableLayoutPanel1.TabIndex = 1283
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
        Me.BtnSave.Location = New System.Drawing.Point(416, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(197, 38)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClean
        '
        Me.BtnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClean.FlatAppearance.BorderSize = 0
        Me.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClean.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClean.ForeColor = System.Drawing.Color.White
        Me.BtnClean.Image = CType(resources.GetObject("BtnClean.Image"), System.Drawing.Image)
        Me.BtnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClean.Location = New System.Drawing.Point(209, 1)
        Me.BtnClean.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClean.Size = New System.Drawing.Size(197, 38)
        Me.BtnClean.TabIndex = 2
        Me.BtnClean.Tag = "Dark"
        Me.BtnClean.Text = "تحديث"
        Me.BtnClean.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 518)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(779, 82)
        Me.GroupBox1.TabIndex = 1284
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtInvoNum, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSupplier, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(752, 37)
        Me.TableLayoutPanel2.TabIndex = 1208
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TxtSumValue)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 37)
        Me.Panel2.TabIndex = 1285
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(3, 3)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(37, 30)
        Me.Label13.TabIndex = 1238
        Me.Label13.Tag = "AutoC"
        Me.Label13.Text = "د.ل"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TxtSumValue.Size = New System.Drawing.Size(219, 37)
        Me.TxtSumValue.TabIndex = 1282
        Me.TxtSumValue.Tag = "AutoC"
        Me.TxtSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(646, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "رقم الفاتورة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvoNum
        '
        Me.TxtInvoNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtInvoNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtInvoNum.ForeColor = System.Drawing.Color.Black
        Me.TxtInvoNum.Location = New System.Drawing.Point(498, 1)
        Me.TxtInvoNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtInvoNum.Name = "TxtInvoNum"
        Me.TxtInvoNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtInvoNum.Size = New System.Drawing.Size(146, 35)
        Me.TxtInvoNum.TabIndex = 1280
        Me.TxtInvoNum.Tag = "AutoC"
        Me.TxtInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(439, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 31)
        Me.Label3.TabIndex = 1245
        Me.Label3.Text = "المورد"
        '
        'TxtSupplier
        '
        Me.TxtSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupplier.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSupplier.ForeColor = System.Drawing.Color.Black
        Me.TxtSupplier.Location = New System.Drawing.Point(291, 1)
        Me.TxtSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSupplier.Size = New System.Drawing.Size(146, 35)
        Me.TxtSupplier.TabIndex = 1281
        Me.TxtSupplier.Tag = "AutoC"
        Me.TxtSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(221, 2)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(68, 35)
        Me.Label9.TabIndex = 1239
        Me.Label9.Text = "الإجمالي"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnPrint.Location = New System.Drawing.Point(2, 2)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(195, 36)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'FrmPurchasesEditInvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 616)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchasesEditInvo"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "تعديل فاتورة شراء"
        Me.PnlTitel.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.TLPData.ResumeLayout(False)
        Me.TLPData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitel As Label
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TLPData As TableLayoutPanel
    Friend WithEvents الاسم As Label
    Friend WithEvents السعر As Label
    Friend WithEvents الكمية As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtSumValue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVInvoContent As DataGridView
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents TxtPurchasPrice As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnClean As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtSupplier As Label
    Friend WithEvents TxtInvoNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtName As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PruchPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalAll As DataGridViewTextBoxColumn
    Friend WithEvents BtnPrint As Button
End Class
