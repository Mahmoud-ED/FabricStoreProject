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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtPurchasPrice = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GrpServices.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 49)
        Me.Label4.TabIndex = 1234
        Me.Label4.Text = "رقم الصنف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(403, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(140, 49)
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
        Me.CmbCounry.Location = New System.Drawing.Point(38, 7)
        Me.CmbCounry.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbCounry.MaxLength = 50
        Me.CmbCounry.Name = "CmbCounry"
        Me.CmbCounry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCounry.Size = New System.Drawing.Size(362, 35)
        Me.CmbCounry.TabIndex = 1237
        Me.CmbCounry.Tag = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsDelClassification})
        Me.ContextMenuStrip1.Name = "CmsCategory"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 26)
        '
        'CmsDelClassification
        '
        Me.CmsDelClassification.Name = "CmsDelClassification"
        Me.CmsDelClassification.Size = New System.Drawing.Size(99, 22)
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
        Me.BtnAddCountry.Location = New System.Drawing.Point(1, 7)
        Me.BtnAddCountry.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddCountry.Name = "BtnAddCountry"
        Me.BtnAddCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddCountry.Size = New System.Drawing.Size(35, 35)
        Me.BtnAddCountry.TabIndex = 1240
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
        Me.TxtDescription.Location = New System.Drawing.Point(0, 7)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtDescription.MaxLength = 200
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDescription.Size = New System.Drawing.Size(400, 35)
        Me.TxtDescription.TabIndex = 6
        Me.TxtDescription.Tag = ""
        '
        'TxtNum
        '
        Me.TxtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNum.BackColor = System.Drawing.Color.White
        Me.TxtNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(0, 7)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNum.MaxLength = 50
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(400, 35)
        Me.TxtNum.TabIndex = 1233
        Me.TxtNum.Tag = "0"
        Me.TxtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 49)
        Me.Label8.TabIndex = 901
        Me.Label8.Text = "وصف الصنف"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(25, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(242, 43)
        Me.Button2.TabIndex = 1300
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnDelete, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnRefresh, 4, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(25, 430)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(879, 40)
        Me.TableLayoutPanel3.TabIndex = 1298
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
        Me.BtnSave.Location = New System.Drawing.Point(593, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(286, 38)
        Me.BtnSave.TabIndex = 20
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
        Me.BtnDelete.Location = New System.Drawing.Point(297, 1)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(286, 38)
        Me.BtnDelete.TabIndex = 21
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
        Me.BtnRefresh.Size = New System.Drawing.Size(287, 38)
        Me.BtnRefresh.TabIndex = 22
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'LstItem
        '
        Me.LstItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstItem.BackColor = System.Drawing.Color.White
        Me.LstItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstItem.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstItem.FormattingEnabled = True
        Me.LstItem.IntegralHeight = False
        Me.LstItem.ItemHeight = 27
        Me.LstItem.Location = New System.Drawing.Point(25, 79)
        Me.LstItem.Name = "LstItem"
        Me.LstItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LstItem.Size = New System.Drawing.Size(242, 320)
        Me.LstItem.TabIndex = 1296
        '
        'GrpServices
        '
        Me.GrpServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpServices.Controls.Add(Me.TableLayoutPanel1)
        Me.GrpServices.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpServices.Location = New System.Drawing.Point(300, 18)
        Me.GrpServices.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpServices.Name = "GrpServices"
        Me.GrpServices.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpServices.Size = New System.Drawing.Size(550, 380)
        Me.GrpServices.TabIndex = 1297
        Me.GrpServices.TabStop = False
        Me.GrpServices.Text = "بيانات الصنف"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNum, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtColor, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPurchasPrice, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPrice, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(546, 348)
        Me.TableLayoutPanel1.TabIndex = 1241
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(402, 294)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(142, 54)
        Me.Label2.TabIndex = 1246
        Me.Label2.Text = "سعر البيع"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(402, 245)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(142, 49)
        Me.Label3.TabIndex = 1244
        Me.Label3.Text = "سعر الشراء"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 49)
        Me.Label1.TabIndex = 1242
        Me.Label1.Text = "اللون"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 49)
        Me.Label6.TabIndex = 1236
        Me.Label6.Text = "بلد الصنع"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(0, 56)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtName.MaxLength = 200
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtName.Size = New System.Drawing.Size(400, 35)
        Me.TxtName.TabIndex = 4
        Me.TxtName.Tag = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtDescription)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 196)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 49)
        Me.Panel1.TabIndex = 1239
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnAddCountry)
        Me.Panel3.Controls.Add(Me.CmbCounry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 49)
        Me.Panel3.TabIndex = 1241
        '
        'TxtColor
        '
        Me.TxtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtColor.BackColor = System.Drawing.Color.White
        Me.TxtColor.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(0, 154)
        Me.TxtColor.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtColor.MaxLength = 200
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtColor.Size = New System.Drawing.Size(400, 35)
        Me.TxtColor.TabIndex = 1243
        Me.TxtColor.Tag = "0"
        '
        'TxtPurchasPrice
        '
        Me.TxtPurchasPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchasPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchasPrice.Location = New System.Drawing.Point(0, 252)
        Me.TxtPurchasPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPurchasPrice.MaxLength = 8
        Me.TxtPurchasPrice.Name = "TxtPurchasPrice"
        Me.TxtPurchasPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPurchasPrice.Size = New System.Drawing.Size(400, 35)
        Me.TxtPurchasPrice.TabIndex = 1245
        Me.TxtPurchasPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrice
        '
        Me.TxtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(0, 303)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPrice.MaxLength = 8
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrice.Size = New System.Drawing.Size(400, 35)
        Me.TxtPrice.TabIndex = 1247
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column1, Me.Column7, Me.Column9, Me.Column10})
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
        Me.DGV.Location = New System.Drawing.Point(25, 480)
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
        Me.DGV.Size = New System.Drawing.Size(878, 63)
        Me.DGV.TabIndex = 1301
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
        'FrmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 578)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.LstItem)
        Me.Controls.Add(Me.GrpServices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة أصناف"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GrpServices.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPurchasPrice As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
