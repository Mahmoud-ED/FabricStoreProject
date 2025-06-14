<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasesInvoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchasesInvoices))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TLPData = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtTotalMaterial = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtPurchasPrice = New System.Windows.Forms.TextBox()
        Me.CmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtMaterialNum = New System.Windows.Forms.TextBox()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.GrpReport = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TlpInvoData = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtInvoNum = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.DGVInvoContent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edith = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TLPData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrpReport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TlpInvoData.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLPData
        '
        Me.TLPData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPData.ColumnCount = 5
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TLPData.Controls.Add(Me.TxtTotalMaterial, 1, 2)
        Me.TLPData.Controls.Add(Me.Label8, 4, 0)
        Me.TLPData.Controls.Add(Me.Label3, 2, 0)
        Me.TLPData.Controls.Add(Me.Label5, 2, 1)
        Me.TLPData.Controls.Add(Me.Label6, 2, 2)
        Me.TLPData.Controls.Add(Me.TxtQuantity, 1, 1)
        Me.TLPData.Controls.Add(Me.TxtPurchasPrice, 1, 0)
        Me.TLPData.Controls.Add(Me.CmbMaterial, 3, 1)
        Me.TLPData.Controls.Add(Me.Label1, 4, 1)
        Me.TLPData.Controls.Add(Me.Panel1, 3, 0)
        Me.TLPData.Controls.Add(Me.TxtCountry, 3, 2)
        Me.TLPData.Controls.Add(Me.Label4, 4, 2)
        Me.TLPData.Location = New System.Drawing.Point(2, 28)
        Me.TLPData.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPData.Name = "TLPData"
        Me.TLPData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TLPData.RowCount = 3
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPData.Size = New System.Drawing.Size(956, 178)
        Me.TLPData.TabIndex = 1
        '
        'TxtTotalMaterial
        '
        Me.TxtTotalMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalMaterial.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtTotalMaterial.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalMaterial.Location = New System.Drawing.Point(20, 130)
        Me.TxtTotalMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTotalMaterial.Name = "TxtTotalMaterial"
        Me.TxtTotalMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotalMaterial.Size = New System.Drawing.Size(366, 35)
        Me.TxtTotalMaterial.TabIndex = 1283
        Me.TxtTotalMaterial.Tag = "AutoC"
        Me.TxtTotalMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(849, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(105, 59)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "رقم الصنف"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(388, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(91, 59)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "سعر الشراء"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(388, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(91, 59)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "الكمية"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(388, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(91, 60)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "الإجمالي"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(20, 71)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtQuantity.MaxLength = 10
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtQuantity.Size = New System.Drawing.Size(366, 35)
        Me.TxtQuantity.TabIndex = 45
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPurchasPrice
        '
        Me.TxtPurchasPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchasPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchasPrice.Location = New System.Drawing.Point(20, 12)
        Me.TxtPurchasPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPurchasPrice.MaxLength = 8
        Me.TxtPurchasPrice.Name = "TxtPurchasPrice"
        Me.TxtPurchasPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPurchasPrice.Size = New System.Drawing.Size(366, 35)
        Me.TxtPurchasPrice.TabIndex = 44
        Me.TxtPurchasPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbMaterial
        '
        Me.CmbMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMaterial.DropDownHeight = 160
        Me.CmbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbMaterial.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMaterial.FormattingEnabled = True
        Me.CmbMaterial.IntegralHeight = False
        Me.CmbMaterial.Location = New System.Drawing.Point(481, 70)
        Me.CmbMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbMaterial.Name = "CmbMaterial"
        Me.CmbMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbMaterial.Size = New System.Drawing.Size(366, 35)
        Me.CmbMaterial.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(849, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(105, 59)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "الصنف"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.TxtMaterialNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(481, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 59)
        Me.Panel1.TabIndex = 50
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(-2, 12)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(42, 35)
        Me.BtnSearch.TabIndex = 38
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtMaterialNum
        '
        Me.TxtMaterialNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMaterialNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterialNum.Location = New System.Drawing.Point(41, 12)
        Me.TxtMaterialNum.Margin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TxtMaterialNum.MaxLength = 40
        Me.TxtMaterialNum.Name = "TxtMaterialNum"
        Me.TxtMaterialNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtMaterialNum.Size = New System.Drawing.Size(325, 35)
        Me.TxtMaterialNum.TabIndex = 37
        '
        'TxtCountry
        '
        Me.TxtCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCountry.BackColor = System.Drawing.Color.White
        Me.TxtCountry.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCountry.Location = New System.Drawing.Point(481, 130)
        Me.TxtCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtCountry.MaxLength = 200
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCountry.Size = New System.Drawing.Size(366, 35)
        Me.TxtCountry.TabIndex = 1284
        Me.TxtCountry.Tag = "0"
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(849, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(105, 60)
        Me.Label4.TabIndex = 1285
        Me.Label4.Text = "بلد الصنع"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnClean, 2, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(205, 241)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(590, 40)
        Me.TableLayoutPanel1.TabIndex = 1231
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.Location = New System.Drawing.Point(300, 1)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAdd.Size = New System.Drawing.Size(290, 38)
        Me.BtnAdd.TabIndex = 1237
        Me.BtnAdd.Tag = "Dark"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.UseVisualStyleBackColor = False
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
        Me.BtnClean.Location = New System.Drawing.Point(0, 1)
        Me.BtnClean.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClean.Size = New System.Drawing.Size(290, 38)
        Me.BtnClean.TabIndex = 845
        Me.BtnClean.Tag = "Dark"
        Me.BtnClean.Text = "تحديث"
        Me.BtnClean.UseVisualStyleBackColor = False
        '
        'GrpReport
        '
        Me.GrpReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpReport.BackColor = System.Drawing.SystemColors.Control
        Me.GrpReport.Controls.Add(Me.TLPData)
        Me.GrpReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReport.Location = New System.Drawing.Point(20, 8)
        Me.GrpReport.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpReport.Name = "GrpReport"
        Me.GrpReport.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpReport.Size = New System.Drawing.Size(960, 220)
        Me.GrpReport.TabIndex = 1232
        Me.GrpReport.TabStop = False
        Me.GrpReport.Text = "بيانات الصنف"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.TlpInvoData)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 429)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(957, 125)
        Me.GroupBox1.TabIndex = 1234
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الفاتورة"
        '
        'TlpInvoData
        '
        Me.TlpInvoData.ColumnCount = 5
        Me.TlpInvoData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpInvoData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpInvoData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TlpInvoData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpInvoData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TlpInvoData.Controls.Add(Me.TxtInvoNum, 3, 0)
        Me.TlpInvoData.Controls.Add(Me.Label15, 4, 1)
        Me.TlpInvoData.Controls.Add(Me.CmbSupplier, 3, 1)
        Me.TlpInvoData.Controls.Add(Me.Label10, 4, 0)
        Me.TlpInvoData.Controls.Add(Me.Label16, 2, 1)
        Me.TlpInvoData.Controls.Add(Me.TxtTotal, 1, 1)
        Me.TlpInvoData.Controls.Add(Me.TxtUserName, 1, 0)
        Me.TlpInvoData.Controls.Add(Me.Label11, 2, 0)
        Me.TlpInvoData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpInvoData.Location = New System.Drawing.Point(2, 30)
        Me.TlpInvoData.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpInvoData.Name = "TlpInvoData"
        Me.TlpInvoData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TlpInvoData.RowCount = 3
        Me.TlpInvoData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpInvoData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpInvoData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TlpInvoData.Size = New System.Drawing.Size(953, 93)
        Me.TlpInvoData.TabIndex = 1
        '
        'TxtInvoNum
        '
        Me.TxtInvoNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtInvoNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtInvoNum.ForeColor = System.Drawing.Color.Black
        Me.TxtInvoNum.Location = New System.Drawing.Point(480, 3)
        Me.TxtInvoNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtInvoNum.Name = "TxtInvoNum"
        Me.TxtInvoNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtInvoNum.Size = New System.Drawing.Size(365, 35)
        Me.TxtInvoNum.TabIndex = 1281
        Me.TxtInvoNum.Tag = "Auto"
        Me.TxtInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label15.Location = New System.Drawing.Point(847, 42)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(104, 42)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "المورد"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbSupplier
        '
        Me.CmbSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSupplier.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(480, 45)
        Me.CmbSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbSupplier.Size = New System.Drawing.Size(365, 35)
        Me.CmbSupplier.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(847, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(104, 42)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "رقم الفاتورة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label16.Location = New System.Drawing.Point(387, 42)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(91, 42)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "الإجمالي"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(20, 45)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotal.Size = New System.Drawing.Size(365, 35)
        Me.TxtTotal.TabIndex = 44
        Me.TxtTotal.Tag = "1"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtUserName.ForeColor = System.Drawing.Color.Black
        Me.TxtUserName.Location = New System.Drawing.Point(20, 3)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUserName.Size = New System.Drawing.Size(365, 35)
        Me.TxtUserName.TabIndex = 1282
        Me.TxtUserName.Tag = "Auto"
        Me.TxtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(387, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(91, 42)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "المستخدم"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPrint, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnNew, 2, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(20, 572)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(957, 40)
        Me.TableLayoutPanel3.TabIndex = 1235
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
        Me.BtnSave.Location = New System.Drawing.Point(645, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(312, 38)
        Me.BtnSave.TabIndex = 842
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.BtnPrint.Location = New System.Drawing.Point(0, 1)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(313, 38)
        Me.BtnPrint.TabIndex = 844
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة "
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(323, 1)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.Size = New System.Drawing.Size(312, 38)
        Me.BtnNew.TabIndex = 845
        Me.BtnNew.Tag = "Dark"
        Me.BtnNew.Text = "تحديث"
        Me.BtnNew.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVInvoContent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVInvoContent.ColumnHeadersHeight = 32
        Me.DGVInvoContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVInvoContent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column5, Me.Column2, Me.PruchPrice, Me.Quantity, Me.Total, Me.MaterialID, Me.SalePrice, Me.Column1, Me.Edith, Me.Del})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVInvoContent.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVInvoContent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVInvoContent.Location = New System.Drawing.Point(20, 293)
        Me.DGVInvoContent.MultiSelect = False
        Me.DGVInvoContent.Name = "DGVInvoContent"
        Me.DGVInvoContent.ReadOnly = True
        Me.DGVInvoContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVInvoContent.RowHeadersVisible = False
        Me.DGVInvoContent.RowHeadersWidth = 51
        Me.DGVInvoContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVInvoContent.RowTemplate.Height = 30
        Me.DGVInvoContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInvoContent.Size = New System.Drawing.Size(960, 129)
        Me.DGVInvoContent.TabIndex = 1236
        Me.DGVInvoContent.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "الرقم"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
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
        Me.PruchPrice.HeaderText = "سعر الشراء"
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
        'Total
        '
        Me.Total.HeaderText = "الإجمالي"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'MaterialID
        '
        Me.MaterialID.HeaderText = "ItemID"
        Me.MaterialID.MinimumWidth = 6
        Me.MaterialID.Name = "MaterialID"
        Me.MaterialID.ReadOnly = True
        Me.MaterialID.Visible = False
        '
        'SalePrice
        '
        Me.SalePrice.HeaderText = "SalePrice"
        Me.SalePrice.MinimumWidth = 6
        Me.SalePrice.Name = "SalePrice"
        Me.SalePrice.ReadOnly = True
        Me.SalePrice.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Country"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Edith
        '
        Me.Edith.HeaderText = ""
        Me.Edith.MinimumWidth = 6
        Me.Edith.Name = "Edith"
        Me.Edith.ReadOnly = True
        Me.Edith.Text = "تعديل"
        Me.Edith.UseColumnTextForButtonValue = True
        '
        'Del
        '
        Me.Del.HeaderText = ""
        Me.Del.MinimumWidth = 6
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Text = "حذف"
        Me.Del.UseColumnTextForButtonValue = True
        '
        'FrmPurchasesInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 632)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpReport)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DGVInvoContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchasesInvoices"
        Me.Text = "تسجيل المشتريات"
        Me.TLPData.ResumeLayout(False)
        Me.TLPData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GrpReport.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TlpInvoData.ResumeLayout(False)
        Me.TlpInvoData.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLPData As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMaterialNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents TxtPurchasPrice As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnClean As Button
    Friend WithEvents GrpReport As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TlpInvoData As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents CmbSupplier As ComboBox
    Friend WithEvents CmbMaterial As ComboBox
    Friend WithEvents DGVInvoContent As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtInvoNum As Label
    Friend WithEvents TxtUserName As Label
    Friend WithEvents TxtTotalMaterial As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PruchPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents MaterialID As DataGridViewTextBoxColumn
    Friend WithEvents SalePrice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Edith As DataGridViewButtonColumn
    Friend WithEvents Del As DataGridViewButtonColumn
End Class
