<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbCounry = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsDelClassification = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAddCountry = New System.Windows.Forms.Button()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.LstItem = New System.Windows.Forms.ListBox()
        Me.GrpServices = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbCat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtPurchasPrice = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtAddCategoreis = New System.Windows.Forms.TextBox()
        Me.TxtUpdateCategories = New System.Windows.Forms.TextBox()
        Me.LstCategories = New System.Windows.Forms.ListBox()
        Me.PicUpdateCategories = New System.Windows.Forms.Button()
        Me.PicDeleteCategories = New System.Windows.Forms.Button()
        Me.PicAddClassification = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GrpServices.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 49)
        Me.Label4.TabIndex = 1234
        Me.Label4.Text = "رقم الصنف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(322, 49)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(159, 49)
        Me.Label20.TabIndex = 888
        Me.Label20.Text = "الاسـم"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCounry
        '
        Me.CmbCounry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCounry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCounry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCounry.BackColor = System.Drawing.Color.White
        Me.CmbCounry.DropDownHeight = 160
        Me.CmbCounry.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCounry.FormattingEnabled = True
        Me.CmbCounry.IntegralHeight = False
        Me.CmbCounry.Location = New System.Drawing.Point(51, 2)
        Me.CmbCounry.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbCounry.MaxLength = 50
        Me.CmbCounry.Name = "CmbCounry"
        Me.CmbCounry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCounry.Size = New System.Drawing.Size(266, 42)
        Me.CmbCounry.TabIndex = 1
        Me.CmbCounry.Tag = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsDelClassification})
        Me.ContextMenuStrip1.Name = "CmsCategory"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 28)
        '
        'CmsDelClassification
        '
        Me.CmsDelClassification.Name = "CmsDelClassification"
        Me.CmsDelClassification.Size = New System.Drawing.Size(110, 24)
        Me.CmsDelClassification.Text = "حذف"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "1479606346_config-users.png")
        Me.ImageList1.Images.SetKeyName(1, "3d bar chart.bmp")
        Me.ImageList1.Images.SetKeyName(2, "13.png")
        Me.ImageList1.Images.SetKeyName(3, "198-512.png")
        Me.ImageList1.Images.SetKeyName(4, "checklist-icon-277x300.png")
        Me.ImageList1.Images.SetKeyName(5, "solution.png")
        Me.ImageList1.Images.SetKeyName(6, "6.jpg")
        Me.ImageList1.Images.SetKeyName(7, "9.jpg")
        Me.ImageList1.Images.SetKeyName(8, "27.jpg")
        Me.ImageList1.Images.SetKeyName(9, "32.jpg")
        Me.ImageList1.Images.SetKeyName(10, "33.jpg")
        Me.ImageList1.Images.SetKeyName(11, "35.jpg")
        Me.ImageList1.Images.SetKeyName(12, "images.jpg")
        Me.ImageList1.Images.SetKeyName(13, "images.png")
        Me.ImageList1.Images.SetKeyName(14, "5.jpg")
        Me.ImageList1.Images.SetKeyName(15, "5.png")
        Me.ImageList1.Images.SetKeyName(16, "8.jpg")
        Me.ImageList1.Images.SetKeyName(17, "18.jpg")
        Me.ImageList1.Images.SetKeyName(18, "19.jpg")
        Me.ImageList1.Images.SetKeyName(19, "22.png")
        Me.ImageList1.Images.SetKeyName(20, "3.png")
        Me.ImageList1.Images.SetKeyName(21, "6.png")
        Me.ImageList1.Images.SetKeyName(22, "7.jpg")
        Me.ImageList1.Images.SetKeyName(23, "2.png")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Black
        Me.ImageList3.Images.SetKeyName(0, "111.png")
        '
        'BtnAddCountry
        '
        Me.BtnAddCountry.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAddCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnAddCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCountry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAddCountry.FlatAppearance.BorderSize = 0
        Me.BtnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCountry.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCountry.ForeColor = System.Drawing.Color.White
        Me.BtnAddCountry.Image = CType(resources.GetObject("BtnAddCountry.Image"), System.Drawing.Image)
        Me.BtnAddCountry.Location = New System.Drawing.Point(1, 2)
        Me.BtnAddCountry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddCountry.Name = "BtnAddCountry"
        Me.BtnAddCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddCountry.Size = New System.Drawing.Size(47, 43)
        Me.BtnAddCountry.TabIndex = 2
        Me.BtnAddCountry.Tag = "Dark"
        Me.BtnAddCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.BtnAddCountry, "إضافة مؤهل")
        Me.BtnAddCountry.UseVisualStyleBackColor = False
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescription.BackColor = System.Drawing.Color.White
        Me.TxtDescription.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(0, 199)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtDescription.MaxLength = 200
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDescription.Size = New System.Drawing.Size(318, 42)
        Me.TxtDescription.TabIndex = 5
        Me.TxtDescription.Tag = ""
        '
        'TxtNum
        '
        Me.TxtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNum.BackColor = System.Drawing.Color.White
        Me.TxtNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(0, 3)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNum.MaxLength = 50
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(318, 42)
        Me.TxtNum.TabIndex = 1
        Me.TxtNum.Tag = "0"
        Me.TxtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 196)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 49)
        Me.Label8.TabIndex = 901
        Me.Label8.Text = "وصف الصنف"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(3, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(323, 54)
        Me.Button2.TabIndex = 1300
        Me.Button2.TabStop = False
        Me.Button2.Tag = ""
        Me.Button2.Text = "الأصناف"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnDelete, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnRefresh, 4, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(33, 529)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1172, 49)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(790, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(382, 47)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(395, 1)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(382, 47)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Tag = "Dark"
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.Location = New System.Drawing.Point(0, 1)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefresh.Size = New System.Drawing.Size(382, 47)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'LstItem
        '
        Me.LstItem.BackColor = System.Drawing.Color.White
        Me.LstItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstItem.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstItem.FormattingEnabled = True
        Me.LstItem.IntegralHeight = False
        Me.LstItem.ItemHeight = 34
        Me.LstItem.Location = New System.Drawing.Point(4, 62)
        Me.LstItem.Margin = New System.Windows.Forms.Padding(4)
        Me.LstItem.Name = "LstItem"
        Me.LstItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstItem.Size = New System.Drawing.Size(321, 418)
        Me.LstItem.TabIndex = 1
        '
        'GrpServices
        '
        Me.GrpServices.Controls.Add(Me.TableLayoutPanel1)
        Me.GrpServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpServices.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpServices.Location = New System.Drawing.Point(677, 2)
        Me.GrpServices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpServices.Name = "GrpServices"
        Me.GrpServices.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpServices.Size = New System.Drawing.Size(491, 488)
        Me.GrpServices.TabIndex = 1
        Me.GrpServices.TabStop = False
        Me.GrpServices.Text = "بيانات الصنف"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtQuantity, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.CmbCat, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDescription, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNum, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtColor, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPurchasPrice, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPrice, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 37)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(485, 449)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(3, 399)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TxtQuantity.MaxLength = 10
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtQuantity.Size = New System.Drawing.Size(312, 42)
        Me.TxtQuantity.TabIndex = 9
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 392)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 57)
        Me.Label7.TabIndex = 1246
        Me.Label7.Text = "الكمية"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCat
        '
        Me.CmbCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCat.BackColor = System.Drawing.Color.White
        Me.CmbCat.DropDownHeight = 160
        Me.CmbCat.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCat.FormattingEnabled = True
        Me.CmbCat.IntegralHeight = False
        Me.CmbCat.Location = New System.Drawing.Point(0, 346)
        Me.CmbCat.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbCat.MaxLength = 50
        Me.CmbCat.Name = "CmbCat"
        Me.CmbCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCat.Size = New System.Drawing.Size(318, 42)
        Me.CmbCat.TabIndex = 8
        Me.CmbCat.Tag = ""
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 343)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 49)
        Me.Label5.TabIndex = 1245
        Me.Label5.Text = "التصنيف"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(321, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(161, 49)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "سعر البيع"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(321, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(161, 49)
        Me.Label3.TabIndex = 1244
        Me.Label3.Text = "سعر الشراء"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 147)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 49)
        Me.Label1.TabIndex = 1242
        Me.Label1.Text = "اللون"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 49)
        Me.Label6.TabIndex = 1236
        Me.Label6.Text = "بلد الصنع"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(0, 52)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtName.MaxLength = 200
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtName.Size = New System.Drawing.Size(318, 42)
        Me.TxtName.TabIndex = 2
        Me.TxtName.Tag = "0"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnAddCountry)
        Me.Panel3.Controls.Add(Me.CmbCounry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 49)
        Me.Panel3.TabIndex = 3
        '
        'TxtColor
        '
        Me.TxtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtColor.BackColor = System.Drawing.Color.White
        Me.TxtColor.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(0, 150)
        Me.TxtColor.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtColor.MaxLength = 200
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtColor.Size = New System.Drawing.Size(318, 42)
        Me.TxtColor.TabIndex = 4
        Me.TxtColor.Tag = "0"
        '
        'TxtPurchasPrice
        '
        Me.TxtPurchasPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchasPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchasPrice.Location = New System.Drawing.Point(0, 248)
        Me.TxtPurchasPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPurchasPrice.MaxLength = 8
        Me.TxtPurchasPrice.Name = "TxtPurchasPrice"
        Me.TxtPurchasPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPurchasPrice.Size = New System.Drawing.Size(318, 42)
        Me.TxtPurchasPrice.TabIndex = 6
        Me.TxtPurchasPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrice
        '
        Me.TxtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(0, 297)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPrice.MaxLength = 8
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrice.Size = New System.Drawing.Size(318, 42)
        Me.TxtPrice.TabIndex = 7
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Printer.png")
        Me.ImageList2.Images.SetKeyName(1, "le-updates-icon.png")
        Me.ImageList2.Images.SetKeyName(2, "Refresh.ico")
        Me.ImageList2.Images.SetKeyName(3, "Print.ico")
        Me.ImageList2.Images.SetKeyName(4, "Search.ico")
        Me.ImageList2.Images.SetKeyName(5, "Save.ico")
        Me.ImageList2.Images.SetKeyName(6, "Del.ico")
        Me.ImageList2.Images.SetKeyName(7, "View Doc.ico")
        Me.ImageList2.Images.SetKeyName(8, "Add Card.ico")
        Me.ImageList2.Images.SetKeyName(9, "Add Folder.ico")
        Me.ImageList2.Images.SetKeyName(10, "Back 2.ico")
        Me.ImageList2.Images.SetKeyName(11, "Download.ico")
        Me.ImageList2.Images.SetKeyName(12, "Forward 2.ico")
        Me.ImageList2.Images.SetKeyName(13, "Properties.ico")
        Me.ImageList2.Images.SetKeyName(14, "Rename - Edit.ico")
        Me.ImageList2.Images.SetKeyName(15, "Spell.ico")
        Me.ImageList2.Images.SetKeyName(16, "6.jpg")
        Me.ImageList2.Images.SetKeyName(17, "7.jpg")
        Me.ImageList2.Images.SetKeyName(18, "12.jpg")
        Me.ImageList2.Images.SetKeyName(19, "13.jpg")
        Me.ImageList2.Images.SetKeyName(20, "14.jpg")
        Me.ImageList2.Images.SetKeyName(21, "19.jpg")
        Me.ImageList2.Images.SetKeyName(22, "1.jpg")
        Me.ImageList2.Images.SetKeyName(23, "9.jpg")
        Me.ImageList2.Images.SetKeyName(24, "Edit.ico")
        Me.ImageList2.Images.SetKeyName(25, "Delete.ico")
        Me.ImageList2.Images.SetKeyName(26, "Actions-trash-empty-icon.png")
        Me.ImageList2.Images.SetKeyName(27, "Actions-view-refresh-icon.png")
        Me.ImageList2.Images.SetKeyName(28, "recycle_bin_full3.png")
        Me.ImageList2.Images.SetKeyName(29, "trashcan_full.png")
        Me.ImageList2.Images.SetKeyName(30, "refresh-icon.png")
        Me.ImageList2.Images.SetKeyName(31, "save_as.gif")
        Me.ImageList2.Images.SetKeyName(32, "save.png")
        Me.ImageList2.Images.SetKeyName(33, "3.png")
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 32
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column1, Me.Column7, Me.Column2, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(33, 591)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 30
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1171, 78)
        Me.DGV.TabIndex = 1301
        Me.DGV.TabStop = False
        Me.DGV.Tag = ""
        '
        'Column11
        '
        Me.Column11.HeaderText = "ID"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "الرقم"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "الإسم"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "التصنيف"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "اللون"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "بلد الصنع"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(323, 58)
        Me.Button1.TabIndex = 1308
        Me.Button1.TabStop = False
        Me.Button1.Tag = ""
        Me.Button1.Text = "التصنيفات"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtAddCategoreis
        '
        Me.TxtAddCategoreis.BackColor = System.Drawing.Color.White
        Me.TxtAddCategoreis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAddCategoreis.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddCategoreis.Location = New System.Drawing.Point(57, 4)
        Me.TxtAddCategoreis.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddCategoreis.MaxLength = 200
        Me.TxtAddCategoreis.Name = "TxtAddCategoreis"
        Me.TxtAddCategoreis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddCategoreis.Size = New System.Drawing.Size(260, 42)
        Me.TxtAddCategoreis.TabIndex = 1
        '
        'TxtUpdateCategories
        '
        Me.TxtUpdateCategories.BackColor = System.Drawing.Color.White
        Me.TxtUpdateCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUpdateCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtUpdateCategories.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUpdateCategories.Location = New System.Drawing.Point(57, 4)
        Me.TxtUpdateCategories.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUpdateCategories.MaxLength = 200
        Me.TxtUpdateCategories.Name = "TxtUpdateCategories"
        Me.TxtUpdateCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUpdateCategories.Size = New System.Drawing.Size(207, 42)
        Me.TxtUpdateCategories.TabIndex = 1
        Me.TxtUpdateCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LstCategories
        '
        Me.LstCategories.BackColor = System.Drawing.Color.White
        Me.LstCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstCategories.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstCategories.FormattingEnabled = True
        Me.LstCategories.IntegralHeight = False
        Me.LstCategories.ItemHeight = 34
        Me.LstCategories.Location = New System.Drawing.Point(4, 124)
        Me.LstCategories.Margin = New System.Windows.Forms.Padding(4)
        Me.LstCategories.Name = "LstCategories"
        Me.LstCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstCategories.Size = New System.Drawing.Size(321, 302)
        Me.LstCategories.TabIndex = 2
        '
        'PicUpdateCategories
        '
        Me.PicUpdateCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PicUpdateCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUpdateCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicUpdateCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PicUpdateCategories.FlatAppearance.BorderSize = 0
        Me.PicUpdateCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PicUpdateCategories.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicUpdateCategories.ForeColor = System.Drawing.Color.White
        Me.PicUpdateCategories.Image = CType(resources.GetObject("PicUpdateCategories.Image"), System.Drawing.Image)
        Me.PicUpdateCategories.Location = New System.Drawing.Point(3, 2)
        Me.PicUpdateCategories.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicUpdateCategories.Name = "PicUpdateCategories"
        Me.PicUpdateCategories.Size = New System.Drawing.Size(47, 42)
        Me.PicUpdateCategories.TabIndex = 2
        Me.PicUpdateCategories.Tag = "Dark"
        Me.PicUpdateCategories.UseVisualStyleBackColor = False
        '
        'PicDeleteCategories
        '
        Me.PicDeleteCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PicDeleteCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDeleteCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicDeleteCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PicDeleteCategories.FlatAppearance.BorderSize = 0
        Me.PicDeleteCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PicDeleteCategories.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicDeleteCategories.ForeColor = System.Drawing.Color.White
        Me.PicDeleteCategories.Image = CType(resources.GetObject("PicDeleteCategories.Image"), System.Drawing.Image)
        Me.PicDeleteCategories.Location = New System.Drawing.Point(271, 2)
        Me.PicDeleteCategories.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicDeleteCategories.Name = "PicDeleteCategories"
        Me.PicDeleteCategories.Size = New System.Drawing.Size(47, 42)
        Me.PicDeleteCategories.TabIndex = 3
        Me.PicDeleteCategories.Tag = "Dark"
        Me.PicDeleteCategories.UseVisualStyleBackColor = False
        '
        'PicAddClassification
        '
        Me.PicAddClassification.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PicAddClassification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAddClassification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicAddClassification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PicAddClassification.FlatAppearance.BorderSize = 0
        Me.PicAddClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PicAddClassification.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicAddClassification.ForeColor = System.Drawing.Color.White
        Me.PicAddClassification.Image = CType(resources.GetObject("PicAddClassification.Image"), System.Drawing.Image)
        Me.PicAddClassification.Location = New System.Drawing.Point(3, 2)
        Me.PicAddClassification.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicAddClassification.Name = "PicAddClassification"
        Me.PicAddClassification.Size = New System.Drawing.Size(47, 46)
        Me.PicAddClassification.TabIndex = 2
        Me.PicAddClassification.Tag = "Dark"
        Me.PicAddClassification.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LstCategories, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(341, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(329, 484)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TxtUpdateCategories, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PicUpdateCategories, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PicDeleteCategories, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 434)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(321, 46)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TxtAddCategoreis, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PicAddClassification, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 66)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(321, 50)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LstItem, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(329, 484)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GrpServices, 2, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(33, 31)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1171, 492)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'FrmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 711)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة أصناف"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GrpServices.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnAddCountry As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbCounry As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CmsDelClassification As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents LstItem As ListBox
    Friend WithEvents GrpServices As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPurchasPrice As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbCat As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtAddCategoreis As TextBox
    Friend WithEvents TxtUpdateCategories As TextBox
    Friend WithEvents LstCategories As ListBox
    Friend WithEvents PicUpdateCategories As Button
    Friend WithEvents PicDeleteCategories As Button
    Friend WithEvents PicAddClassification As Button
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtQuantity As TextBox
End Class
