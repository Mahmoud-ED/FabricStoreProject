<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PicUserSettings = New System.Windows.Forms.PictureBox()
        Me.TLPSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PicChangePass = New System.Windows.Forms.PictureBox()
        Me.PicChangeColor = New System.Windows.Forms.PictureBox()
        Me.PicLogoCo = New System.Windows.Forms.PictureBox()
        Me.TLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlButton = New System.Windows.Forms.Panel()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnUserManagement = New System.Windows.Forms.Button()
        Me.PnlBasicData = New System.Windows.Forms.Panel()
        Me.BtnCities = New System.Windows.Forms.Button()
        Me.BtnExpensesType = New System.Windows.Forms.Button()
        Me.BtnServices = New System.Windows.Forms.Button()
        Me.BtnCountry = New System.Windows.Forms.Button()
        Me.BtnBank = New System.Windows.Forms.Button()
        Me.BtnPaymentType = New System.Windows.Forms.Button()
        Me.BtnBasicData = New System.Windows.Forms.Button()
        Me.BtnDeliveryCo = New System.Windows.Forms.Button()
        Me.BtnTailors = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnSupplers = New System.Windows.Forms.Button()
        Me.BtnEmployees = New System.Windows.Forms.Button()
        Me.PnlReports = New System.Windows.Forms.Panel()
        Me.BtnSalarySuppliers = New System.Windows.Forms.Button()
        Me.BtnTreasury = New System.Windows.Forms.Button()
        Me.BtnSalaryTailors = New System.Windows.Forms.Button()
        Me.BtnSafe = New System.Windows.Forms.Button()
        Me.BtnTreasuryReceipts = New System.Windows.Forms.Button()
        Me.BtnReceiptReport = New System.Windows.Forms.Button()
        Me.BtnDailyServices = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnExpenses = New System.Windows.Forms.Button()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.BtnPurchase = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSLDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSLUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSLMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PicMenu = New System.Windows.Forms.PictureBox()
        Me.PnlSplit1 = New System.Windows.Forms.Panel()
        Me.TimerShowSettings = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlMain.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PicUserSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPSettings.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChangeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogoCo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPButtons.SuspendLayout()
        Me.PnlButton.SuspendLayout()
        Me.PnlBasicData.SuspendLayout()
        Me.PnlReports.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        CType(Me.PicMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlMain.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlMain.Controls.Add(Me.PicLogoCo)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(8, 40)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(760, 707)
        Me.PnlMain.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PicUserSettings, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TLPSettings, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 641)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(269, 58)
        Me.TableLayoutPanel2.TabIndex = 1252
        '
        'PicUserSettings
        '
        Me.PicUserSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUserSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicUserSettings.Image = CType(resources.GetObject("PicUserSettings.Image"), System.Drawing.Image)
        Me.PicUserSettings.Location = New System.Drawing.Point(1, 1)
        Me.PicUserSettings.Margin = New System.Windows.Forms.Padding(1)
        Me.PicUserSettings.Name = "PicUserSettings"
        Me.PicUserSettings.Size = New System.Drawing.Size(71, 56)
        Me.PicUserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicUserSettings.TabIndex = 1247
        Me.PicUserSettings.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicUserSettings, "الإعدادات")
        '
        'TLPSettings
        '
        Me.TLPSettings.ColumnCount = 5
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TLPSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSettings.Controls.Add(Me.PicClose, 0, 0)
        Me.TLPSettings.Controls.Add(Me.PicChangePass, 2, 0)
        Me.TLPSettings.Controls.Add(Me.PicChangeColor, 4, 0)
        Me.TLPSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPSettings.Location = New System.Drawing.Point(76, 3)
        Me.TLPSettings.Name = "TLPSettings"
        Me.TLPSettings.RowCount = 1
        Me.TLPSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPSettings.Size = New System.Drawing.Size(190, 52)
        Me.TLPSettings.TabIndex = 1248
        Me.TLPSettings.Visible = False
        '
        'PicClose
        '
        Me.PicClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicClose.Image = CType(resources.GetObject("PicClose.Image"), System.Drawing.Image)
        Me.PicClose.Location = New System.Drawing.Point(1, 1)
        Me.PicClose.Margin = New System.Windows.Forms.Padding(1)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(54, 50)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicClose.TabIndex = 7
        Me.PicClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicClose, "تسجيل خروج")
        '
        'PicChangePass
        '
        Me.PicChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicChangePass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicChangePass.Image = CType(resources.GetObject("PicChangePass.Image"), System.Drawing.Image)
        Me.PicChangePass.Location = New System.Drawing.Point(66, 1)
        Me.PicChangePass.Margin = New System.Windows.Forms.Padding(1)
        Me.PicChangePass.Name = "PicChangePass"
        Me.PicChangePass.Size = New System.Drawing.Size(55, 50)
        Me.PicChangePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicChangePass.TabIndex = 2
        Me.PicChangePass.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicChangePass, "تغيير كلمة المرور")
        '
        'PicChangeColor
        '
        Me.PicChangeColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicChangeColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicChangeColor.Image = CType(resources.GetObject("PicChangeColor.Image"), System.Drawing.Image)
        Me.PicChangeColor.Location = New System.Drawing.Point(133, 1)
        Me.PicChangeColor.Margin = New System.Windows.Forms.Padding(1)
        Me.PicChangeColor.Name = "PicChangeColor"
        Me.PicChangeColor.Size = New System.Drawing.Size(56, 50)
        Me.PicChangeColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicChangeColor.TabIndex = 4
        Me.PicChangeColor.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicChangeColor, "تغيير ألوان النظام")
        '
        'PicLogoCo
        '
        Me.PicLogoCo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicLogoCo.Image = Global.FabricStoreProject.My.Resources.Resources.NoImage
        Me.PicLogoCo.Location = New System.Drawing.Point(177, 117)
        Me.PicLogoCo.Margin = New System.Windows.Forms.Padding(2)
        Me.PicLogoCo.Name = "PicLogoCo"
        Me.PicLogoCo.Size = New System.Drawing.Size(406, 473)
        Me.PicLogoCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogoCo.TabIndex = 4
        Me.PicLogoCo.TabStop = False
        '
        'TLPButtons
        '
        Me.TLPButtons.BackColor = System.Drawing.SystemColors.Control
        Me.TLPButtons.ColumnCount = 1
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPButtons.Controls.Add(Me.PnlButton, 0, 0)
        Me.TLPButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.TLPButtons.Location = New System.Drawing.Point(768, 40)
        Me.TLPButtons.Name = "TLPButtons"
        Me.TLPButtons.RowCount = 1
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.8803!))
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 707.0!))
        Me.TLPButtons.Size = New System.Drawing.Size(264, 707)
        Me.TLPButtons.TabIndex = 1243
        Me.TLPButtons.Tag = "Light"
        '
        'PnlButton
        '
        Me.PnlButton.AutoScroll = True
        Me.PnlButton.Controls.Add(Me.BtnSettings)
        Me.PnlButton.Controls.Add(Me.BtnUserManagement)
        Me.PnlButton.Controls.Add(Me.PnlBasicData)
        Me.PnlButton.Controls.Add(Me.BtnBasicData)
        Me.PnlButton.Controls.Add(Me.BtnDeliveryCo)
        Me.PnlButton.Controls.Add(Me.BtnTailors)
        Me.PnlButton.Controls.Add(Me.BtnCustomers)
        Me.PnlButton.Controls.Add(Me.BtnSupplers)
        Me.PnlButton.Controls.Add(Me.BtnEmployees)
        Me.PnlButton.Controls.Add(Me.PnlReports)
        Me.PnlButton.Controls.Add(Me.BtnReports)
        Me.PnlButton.Controls.Add(Me.BtnExpenses)
        Me.PnlButton.Controls.Add(Me.BtnAddItem)
        Me.PnlButton.Controls.Add(Me.BtnPurchase)
        Me.PnlButton.Controls.Add(Me.BtnSales)
        Me.PnlButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlButton.Location = New System.Drawing.Point(3, 3)
        Me.PnlButton.Name = "PnlButton"
        Me.PnlButton.Size = New System.Drawing.Size(258, 701)
        Me.PnlButton.TabIndex = 1244
        '
        'BtnSettings
        '
        Me.BtnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSettings.ForeColor = System.Drawing.Color.White
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSettings.Location = New System.Drawing.Point(0, 1234)
        Me.BtnSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(241, 50)
        Me.BtnSettings.TabIndex = 1274
        Me.BtnSettings.Tag = "Dark"
        Me.BtnSettings.Text = "الإعدادات"
        Me.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'BtnUserManagement
        '
        Me.BtnUserManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUserManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUserManagement.FlatAppearance.BorderSize = 0
        Me.BtnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserManagement.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnUserManagement.ForeColor = System.Drawing.Color.White
        Me.BtnUserManagement.Image = CType(resources.GetObject("BtnUserManagement.Image"), System.Drawing.Image)
        Me.BtnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUserManagement.Location = New System.Drawing.Point(0, 1184)
        Me.BtnUserManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUserManagement.Name = "BtnUserManagement"
        Me.BtnUserManagement.Size = New System.Drawing.Size(241, 50)
        Me.BtnUserManagement.TabIndex = 1273
        Me.BtnUserManagement.Tag = "Dark"
        Me.BtnUserManagement.Text = "إدارة المستخدمين"
        Me.BtnUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUserManagement.UseVisualStyleBackColor = False
        '
        'PnlBasicData
        '
        Me.PnlBasicData.BackColor = System.Drawing.Color.White
        Me.PnlBasicData.Controls.Add(Me.BtnCities)
        Me.PnlBasicData.Controls.Add(Me.BtnExpensesType)
        Me.PnlBasicData.Controls.Add(Me.BtnServices)
        Me.PnlBasicData.Controls.Add(Me.BtnCountry)
        Me.PnlBasicData.Controls.Add(Me.BtnBank)
        Me.PnlBasicData.Controls.Add(Me.BtnPaymentType)
        Me.PnlBasicData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBasicData.Location = New System.Drawing.Point(0, 899)
        Me.PnlBasicData.Name = "PnlBasicData"
        Me.PnlBasicData.Size = New System.Drawing.Size(241, 285)
        Me.PnlBasicData.TabIndex = 1270
        Me.PnlBasicData.Tag = ""
        Me.PnlBasicData.Visible = False
        '
        'BtnCities
        '
        Me.BtnCities.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCities.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCities.FlatAppearance.BorderSize = 0
        Me.BtnCities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnCities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCities.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCities.ForeColor = System.Drawing.Color.White
        Me.BtnCities.Image = CType(resources.GetObject("BtnCities.Image"), System.Drawing.Image)
        Me.BtnCities.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCities.Location = New System.Drawing.Point(3, 237)
        Me.BtnCities.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCities.Name = "BtnCities"
        Me.BtnCities.Size = New System.Drawing.Size(223, 45)
        Me.BtnCities.TabIndex = 1257
        Me.BtnCities.Tag = "Dark"
        Me.BtnCities.Text = "المدن"
        Me.BtnCities.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCities.UseVisualStyleBackColor = False
        '
        'BtnExpensesType
        '
        Me.BtnExpensesType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnExpensesType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExpensesType.FlatAppearance.BorderSize = 0
        Me.BtnExpensesType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnExpensesType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnExpensesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExpensesType.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnExpensesType.ForeColor = System.Drawing.Color.White
        Me.BtnExpensesType.Image = CType(resources.GetObject("BtnExpensesType.Image"), System.Drawing.Image)
        Me.BtnExpensesType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExpensesType.Location = New System.Drawing.Point(3, 190)
        Me.BtnExpensesType.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExpensesType.Name = "BtnExpensesType"
        Me.BtnExpensesType.Size = New System.Drawing.Size(223, 45)
        Me.BtnExpensesType.TabIndex = 1256
        Me.BtnExpensesType.Tag = "Dark"
        Me.BtnExpensesType.Text = "أنواع المصروفات"
        Me.BtnExpensesType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExpensesType.UseVisualStyleBackColor = False
        '
        'BtnServices
        '
        Me.BtnServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServices.FlatAppearance.BorderSize = 0
        Me.BtnServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServices.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnServices.ForeColor = System.Drawing.Color.White
        Me.BtnServices.Image = CType(resources.GetObject("BtnServices.Image"), System.Drawing.Image)
        Me.BtnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnServices.Location = New System.Drawing.Point(3, 143)
        Me.BtnServices.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnServices.Name = "BtnServices"
        Me.BtnServices.Size = New System.Drawing.Size(223, 45)
        Me.BtnServices.TabIndex = 1255
        Me.BtnServices.Tag = "Dark"
        Me.BtnServices.Text = "خدمات الخياط"
        Me.BtnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnServices.UseVisualStyleBackColor = False
        '
        'BtnCountry
        '
        Me.BtnCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCountry.FlatAppearance.BorderSize = 0
        Me.BtnCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCountry.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCountry.ForeColor = System.Drawing.Color.White
        Me.BtnCountry.Image = CType(resources.GetObject("BtnCountry.Image"), System.Drawing.Image)
        Me.BtnCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCountry.Location = New System.Drawing.Point(3, 96)
        Me.BtnCountry.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCountry.Name = "BtnCountry"
        Me.BtnCountry.Size = New System.Drawing.Size(223, 45)
        Me.BtnCountry.TabIndex = 1254
        Me.BtnCountry.Tag = "Dark"
        Me.BtnCountry.Text = "البلدان"
        Me.BtnCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCountry.UseVisualStyleBackColor = False
        '
        'BtnBank
        '
        Me.BtnBank.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBank.FlatAppearance.BorderSize = 0
        Me.BtnBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBank.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnBank.ForeColor = System.Drawing.Color.White
        Me.BtnBank.Image = CType(resources.GetObject("BtnBank.Image"), System.Drawing.Image)
        Me.BtnBank.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBank.Location = New System.Drawing.Point(3, 2)
        Me.BtnBank.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBank.Name = "BtnBank"
        Me.BtnBank.Size = New System.Drawing.Size(223, 45)
        Me.BtnBank.TabIndex = 1252
        Me.BtnBank.Tag = "Dark"
        Me.BtnBank.Text = "المصارف"
        Me.BtnBank.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBank.UseVisualStyleBackColor = False
        '
        'BtnPaymentType
        '
        Me.BtnPaymentType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPaymentType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPaymentType.FlatAppearance.BorderSize = 0
        Me.BtnPaymentType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnPaymentType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaymentType.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnPaymentType.ForeColor = System.Drawing.Color.White
        Me.BtnPaymentType.Image = CType(resources.GetObject("BtnPaymentType.Image"), System.Drawing.Image)
        Me.BtnPaymentType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPaymentType.Location = New System.Drawing.Point(3, 49)
        Me.BtnPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPaymentType.Name = "BtnPaymentType"
        Me.BtnPaymentType.Size = New System.Drawing.Size(223, 45)
        Me.BtnPaymentType.TabIndex = 1253
        Me.BtnPaymentType.Tag = "Dark"
        Me.BtnPaymentType.Text = "أنواع الدفع"
        Me.BtnPaymentType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPaymentType.UseVisualStyleBackColor = False
        '
        'BtnBasicData
        '
        Me.BtnBasicData.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBasicData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBasicData.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBasicData.FlatAppearance.BorderSize = 0
        Me.BtnBasicData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnBasicData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnBasicData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBasicData.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnBasicData.ForeColor = System.Drawing.Color.White
        Me.BtnBasicData.Image = CType(resources.GetObject("BtnBasicData.Image"), System.Drawing.Image)
        Me.BtnBasicData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBasicData.Location = New System.Drawing.Point(0, 849)
        Me.BtnBasicData.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBasicData.Name = "BtnBasicData"
        Me.BtnBasicData.Size = New System.Drawing.Size(241, 50)
        Me.BtnBasicData.TabIndex = 1272
        Me.BtnBasicData.Tag = "Dark1"
        Me.BtnBasicData.Text = "◁           البيانات الأساسية"
        Me.BtnBasicData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBasicData.UseVisualStyleBackColor = False
        '
        'BtnDeliveryCo
        '
        Me.BtnDeliveryCo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDeliveryCo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeliveryCo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDeliveryCo.FlatAppearance.BorderSize = 0
        Me.BtnDeliveryCo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnDeliveryCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnDeliveryCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeliveryCo.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnDeliveryCo.ForeColor = System.Drawing.Color.White
        Me.BtnDeliveryCo.Image = CType(resources.GetObject("BtnDeliveryCo.Image"), System.Drawing.Image)
        Me.BtnDeliveryCo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeliveryCo.Location = New System.Drawing.Point(0, 804)
        Me.BtnDeliveryCo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDeliveryCo.Name = "BtnDeliveryCo"
        Me.BtnDeliveryCo.Size = New System.Drawing.Size(241, 45)
        Me.BtnDeliveryCo.TabIndex = 1258
        Me.BtnDeliveryCo.Tag = "Dark"
        Me.BtnDeliveryCo.Text = "شركات التوصيل"
        Me.BtnDeliveryCo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeliveryCo.UseVisualStyleBackColor = False
        '
        'BtnTailors
        '
        Me.BtnTailors.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTailors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTailors.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTailors.FlatAppearance.BorderSize = 0
        Me.BtnTailors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnTailors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnTailors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTailors.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnTailors.ForeColor = System.Drawing.Color.White
        Me.BtnTailors.Image = CType(resources.GetObject("BtnTailors.Image"), System.Drawing.Image)
        Me.BtnTailors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTailors.Location = New System.Drawing.Point(0, 749)
        Me.BtnTailors.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTailors.Name = "BtnTailors"
        Me.BtnTailors.Size = New System.Drawing.Size(241, 55)
        Me.BtnTailors.TabIndex = 1287
        Me.BtnTailors.Tag = "Dark"
        Me.BtnTailors.Text = "بيانات الخياطين"
        Me.BtnTailors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTailors.UseVisualStyleBackColor = False
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCustomers.FlatAppearance.BorderSize = 0
        Me.BtnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCustomers.ForeColor = System.Drawing.Color.White
        Me.BtnCustomers.Image = CType(resources.GetObject("BtnCustomers.Image"), System.Drawing.Image)
        Me.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCustomers.Location = New System.Drawing.Point(0, 694)
        Me.BtnCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(241, 55)
        Me.BtnCustomers.TabIndex = 1286
        Me.BtnCustomers.Tag = "Dark"
        Me.BtnCustomers.Text = "بيانات الزبائن"
        Me.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCustomers.UseVisualStyleBackColor = False
        '
        'BtnSupplers
        '
        Me.BtnSupplers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSupplers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSupplers.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSupplers.FlatAppearance.BorderSize = 0
        Me.BtnSupplers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSupplers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSupplers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplers.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSupplers.ForeColor = System.Drawing.Color.White
        Me.BtnSupplers.Image = CType(resources.GetObject("BtnSupplers.Image"), System.Drawing.Image)
        Me.BtnSupplers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSupplers.Location = New System.Drawing.Point(0, 639)
        Me.BtnSupplers.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplers.Name = "BtnSupplers"
        Me.BtnSupplers.Size = New System.Drawing.Size(241, 55)
        Me.BtnSupplers.TabIndex = 1251
        Me.BtnSupplers.Tag = "Dark"
        Me.BtnSupplers.Text = "بيانات الموردين"
        Me.BtnSupplers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSupplers.UseVisualStyleBackColor = False
        '
        'BtnEmployees
        '
        Me.BtnEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmployees.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmployees.FlatAppearance.BorderSize = 0
        Me.BtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmployees.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnEmployees.ForeColor = System.Drawing.Color.White
        Me.BtnEmployees.Image = CType(resources.GetObject("BtnEmployees.Image"), System.Drawing.Image)
        Me.BtnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEmployees.Location = New System.Drawing.Point(0, 589)
        Me.BtnEmployees.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEmployees.Name = "BtnEmployees"
        Me.BtnEmployees.Size = New System.Drawing.Size(241, 50)
        Me.BtnEmployees.TabIndex = 1267
        Me.BtnEmployees.Tag = "Dark"
        Me.BtnEmployees.Text = "بيانات الموظفين"
        Me.BtnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnEmployees.UseVisualStyleBackColor = False
        '
        'PnlReports
        '
        Me.PnlReports.BackColor = System.Drawing.Color.White
        Me.PnlReports.Controls.Add(Me.BtnSalarySuppliers)
        Me.PnlReports.Controls.Add(Me.BtnTreasury)
        Me.PnlReports.Controls.Add(Me.BtnSalaryTailors)
        Me.PnlReports.Controls.Add(Me.BtnSafe)
        Me.PnlReports.Controls.Add(Me.BtnTreasuryReceipts)
        Me.PnlReports.Controls.Add(Me.BtnReceiptReport)
        Me.PnlReports.Controls.Add(Me.BtnDailyServices)
        Me.PnlReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlReports.Location = New System.Drawing.Point(0, 255)
        Me.PnlReports.Name = "PnlReports"
        Me.PnlReports.Size = New System.Drawing.Size(241, 334)
        Me.PnlReports.TabIndex = 1285
        Me.PnlReports.Tag = ""
        Me.PnlReports.Visible = False
        '
        'BtnSalarySuppliers
        '
        Me.BtnSalarySuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalarySuppliers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalarySuppliers.FlatAppearance.BorderSize = 0
        Me.BtnSalarySuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSalarySuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSalarySuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalarySuppliers.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSalarySuppliers.ForeColor = System.Drawing.Color.White
        Me.BtnSalarySuppliers.Image = CType(resources.GetObject("BtnSalarySuppliers.Image"), System.Drawing.Image)
        Me.BtnSalarySuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalarySuppliers.Location = New System.Drawing.Point(3, 190)
        Me.BtnSalarySuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalarySuppliers.Name = "BtnSalarySuppliers"
        Me.BtnSalarySuppliers.Size = New System.Drawing.Size(224, 45)
        Me.BtnSalarySuppliers.TabIndex = 1276
        Me.BtnSalarySuppliers.Tag = "Dark"
        Me.BtnSalarySuppliers.Text = "الموردين"
        Me.BtnSalarySuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSalarySuppliers.UseVisualStyleBackColor = False
        '
        'BtnTreasury
        '
        Me.BtnTreasury.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTreasury.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTreasury.FlatAppearance.BorderSize = 0
        Me.BtnTreasury.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnTreasury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnTreasury.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTreasury.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnTreasury.ForeColor = System.Drawing.Color.White
        Me.BtnTreasury.Image = CType(resources.GetObject("BtnTreasury.Image"), System.Drawing.Image)
        Me.BtnTreasury.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTreasury.Location = New System.Drawing.Point(3, 49)
        Me.BtnTreasury.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTreasury.Name = "BtnTreasury"
        Me.BtnTreasury.Size = New System.Drawing.Size(224, 45)
        Me.BtnTreasury.TabIndex = 1268
        Me.BtnTreasury.Tag = "Dark"
        Me.BtnTreasury.Text = "الخزينة الرئيسية"
        Me.BtnTreasury.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTreasury.UseVisualStyleBackColor = False
        '
        'BtnSalaryTailors
        '
        Me.BtnSalaryTailors.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalaryTailors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalaryTailors.FlatAppearance.BorderSize = 0
        Me.BtnSalaryTailors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSalaryTailors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSalaryTailors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalaryTailors.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSalaryTailors.ForeColor = System.Drawing.Color.White
        Me.BtnSalaryTailors.Image = CType(resources.GetObject("BtnSalaryTailors.Image"), System.Drawing.Image)
        Me.BtnSalaryTailors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalaryTailors.Location = New System.Drawing.Point(3, 143)
        Me.BtnSalaryTailors.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalaryTailors.Name = "BtnSalaryTailors"
        Me.BtnSalaryTailors.Size = New System.Drawing.Size(224, 45)
        Me.BtnSalaryTailors.TabIndex = 1266
        Me.BtnSalaryTailors.Tag = "Dark"
        Me.BtnSalaryTailors.Text = "الخياطين"
        Me.BtnSalaryTailors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSalaryTailors.UseVisualStyleBackColor = False
        '
        'BtnSafe
        '
        Me.BtnSafe.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSafe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSafe.FlatAppearance.BorderSize = 0
        Me.BtnSafe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSafe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSafe.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSafe.ForeColor = System.Drawing.Color.White
        Me.BtnSafe.Image = CType(resources.GetObject("BtnSafe.Image"), System.Drawing.Image)
        Me.BtnSafe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSafe.Location = New System.Drawing.Point(3, 2)
        Me.BtnSafe.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSafe.Name = "BtnSafe"
        Me.BtnSafe.Size = New System.Drawing.Size(224, 45)
        Me.BtnSafe.TabIndex = 1275
        Me.BtnSafe.Tag = "Dark"
        Me.BtnSafe.Text = "المناوبات"
        Me.BtnSafe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSafe.UseVisualStyleBackColor = False
        '
        'BtnTreasuryReceipts
        '
        Me.BtnTreasuryReceipts.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTreasuryReceipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTreasuryReceipts.FlatAppearance.BorderSize = 0
        Me.BtnTreasuryReceipts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnTreasuryReceipts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnTreasuryReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTreasuryReceipts.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTreasuryReceipts.ForeColor = System.Drawing.Color.White
        Me.BtnTreasuryReceipts.Image = CType(resources.GetObject("BtnTreasuryReceipts.Image"), System.Drawing.Image)
        Me.BtnTreasuryReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTreasuryReceipts.Location = New System.Drawing.Point(3, 96)
        Me.BtnTreasuryReceipts.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTreasuryReceipts.Name = "BtnTreasuryReceipts"
        Me.BtnTreasuryReceipts.Size = New System.Drawing.Size(224, 45)
        Me.BtnTreasuryReceipts.TabIndex = 1267
        Me.BtnTreasuryReceipts.Tag = "Dark"
        Me.BtnTreasuryReceipts.Text = "إيصالات الخزينة"
        Me.BtnTreasuryReceipts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTreasuryReceipts.UseVisualStyleBackColor = False
        '
        'BtnReceiptReport
        '
        Me.BtnReceiptReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnReceiptReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceiptReport.FlatAppearance.BorderSize = 0
        Me.BtnReceiptReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnReceiptReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnReceiptReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceiptReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnReceiptReport.ForeColor = System.Drawing.Color.White
        Me.BtnReceiptReport.Image = CType(resources.GetObject("BtnReceiptReport.Image"), System.Drawing.Image)
        Me.BtnReceiptReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReceiptReport.Location = New System.Drawing.Point(3, 284)
        Me.BtnReceiptReport.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReceiptReport.Name = "BtnReceiptReport"
        Me.BtnReceiptReport.Size = New System.Drawing.Size(224, 45)
        Me.BtnReceiptReport.TabIndex = 1265
        Me.BtnReceiptReport.Tag = "Dark"
        Me.BtnReceiptReport.Text = "تقارير الإيصالات"
        Me.BtnReceiptReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReceiptReport.UseVisualStyleBackColor = False
        '
        'BtnDailyServices
        '
        Me.BtnDailyServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDailyServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDailyServices.FlatAppearance.BorderSize = 0
        Me.BtnDailyServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnDailyServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnDailyServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDailyServices.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnDailyServices.ForeColor = System.Drawing.Color.White
        Me.BtnDailyServices.Image = CType(resources.GetObject("BtnDailyServices.Image"), System.Drawing.Image)
        Me.BtnDailyServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDailyServices.Location = New System.Drawing.Point(3, 237)
        Me.BtnDailyServices.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDailyServices.Name = "BtnDailyServices"
        Me.BtnDailyServices.Size = New System.Drawing.Size(224, 45)
        Me.BtnDailyServices.TabIndex = 1264
        Me.BtnDailyServices.Tag = "Dark"
        Me.BtnDailyServices.Text = "الإيرادات اليومية"
        Me.BtnDailyServices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDailyServices.UseVisualStyleBackColor = False
        '
        'BtnReports
        '
        Me.BtnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.FlatAppearance.BorderSize = 0
        Me.BtnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReports.Location = New System.Drawing.Point(0, 205)
        Me.BtnReports.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(241, 50)
        Me.BtnReports.TabIndex = 1265
        Me.BtnReports.Tag = "Dark1"
        Me.BtnReports.Text = "◁              المالية          "
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReports.UseVisualStyleBackColor = False
        '
        'BtnExpenses
        '
        Me.BtnExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExpenses.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnExpenses.FlatAppearance.BorderSize = 0
        Me.BtnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExpenses.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExpenses.ForeColor = System.Drawing.Color.White
        Me.BtnExpenses.Image = CType(resources.GetObject("BtnExpenses.Image"), System.Drawing.Image)
        Me.BtnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExpenses.Location = New System.Drawing.Point(0, 155)
        Me.BtnExpenses.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExpenses.Name = "BtnExpenses"
        Me.BtnExpenses.Size = New System.Drawing.Size(241, 50)
        Me.BtnExpenses.TabIndex = 1258
        Me.BtnExpenses.Tag = "Dark"
        Me.BtnExpenses.Text = "المصروفات"
        Me.BtnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExpenses.UseVisualStyleBackColor = False
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnAddItem.Image = CType(resources.GetObject("BtnAddItem.Image"), System.Drawing.Image)
        Me.BtnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddItem.Location = New System.Drawing.Point(0, 105)
        Me.BtnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(241, 50)
        Me.BtnAddItem.TabIndex = 1261
        Me.BtnAddItem.Tag = "Dark"
        Me.BtnAddItem.Text = "الأصناف"
        Me.BtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'BtnPurchase
        '
        Me.BtnPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPurchase.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPurchase.FlatAppearance.BorderSize = 0
        Me.BtnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPurchase.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnPurchase.ForeColor = System.Drawing.Color.White
        Me.BtnPurchase.Image = CType(resources.GetObject("BtnPurchase.Image"), System.Drawing.Image)
        Me.BtnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPurchase.Location = New System.Drawing.Point(0, 50)
        Me.BtnPurchase.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPurchase.Name = "BtnPurchase"
        Me.BtnPurchase.Size = New System.Drawing.Size(241, 55)
        Me.BtnPurchase.TabIndex = 1250
        Me.BtnPurchase.Tag = "Dark"
        Me.BtnPurchase.Text = "مشتريات"
        Me.BtnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPurchase.UseVisualStyleBackColor = False
        '
        'BtnSales
        '
        Me.BtnSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSales.FlatAppearance.BorderSize = 0
        Me.BtnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BtnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSales.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSales.ForeColor = System.Drawing.Color.White
        Me.BtnSales.Image = CType(resources.GetObject("BtnSales.Image"), System.Drawing.Image)
        Me.BtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSales.Location = New System.Drawing.Point(0, 0)
        Me.BtnSales.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Size = New System.Drawing.Size(241, 50)
        Me.BtnSales.TabIndex = 1284
        Me.BtnSales.Tag = "Dark"
        Me.BtnSales.Text = "المبيعات"
        Me.BtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSales.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLDateTime, Me.TSLUserName, Me.SSLMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(8, 747)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 33)
        Me.StatusStrip1.TabIndex = 407
        Me.StatusStrip1.Tag = "Primary"
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSLDateTime
        '
        Me.TSLDateTime.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLDateTime.ForeColor = System.Drawing.Color.White
        Me.TSLDateTime.Image = CType(resources.GetObject("TSLDateTime.Image"), System.Drawing.Image)
        Me.TSLDateTime.Margin = New System.Windows.Forms.Padding(10, 3, 50, 2)
        Me.TSLDateTime.Name = "TSLDateTime"
        Me.TSLDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TSLDateTime.Size = New System.Drawing.Size(130, 28)
        Me.TSLDateTime.Text = "الساعة والتاريخ"
        '
        'TSLUserName
        '
        Me.TSLUserName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLUserName.ForeColor = System.Drawing.Color.White
        Me.TSLUserName.Image = CType(resources.GetObject("TSLUserName.Image"), System.Drawing.Image)
        Me.TSLUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSLUserName.Name = "TSLUserName"
        Me.TSLUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TSLUserName.Size = New System.Drawing.Size(156, 28)
        Me.TSLUserName.Text = "مستخدم المنظومة"
        '
        'SSLMessage
        '
        Me.SSLMessage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSLMessage.ForeColor = System.Drawing.Color.White
        Me.SSLMessage.Margin = New System.Windows.Forms.Padding(100, 3, 0, 2)
        Me.SSLMessage.Name = "SSLMessage"
        Me.SSLMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SSLMessage.Size = New System.Drawing.Size(92, 28)
        Me.SSLMessage.Text = "تأكيد الحفظ"
        Me.SSLMessage.Visible = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.LblTitel)
        Me.PnlMenu.Controls.Add(Me.BtnMin)
        Me.PnlMenu.Controls.Add(Me.BtnMax)
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Controls.Add(Me.PicMenu)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(8, 8)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(1024, 28)
        Me.PnlMenu.TabIndex = 409
        Me.PnlMenu.Tag = "Primary"
        '
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(431, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(163, 28)
        Me.LblTitel.TabIndex = 422
        Me.LblTitel.Text = "منظومة المتجر"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMin
        '
        Me.BtnMin.BackColor = System.Drawing.Color.Transparent
        Me.BtnMin.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), System.Drawing.Image)
        Me.BtnMin.Location = New System.Drawing.Point(76, 0)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(38, 28)
        Me.BtnMin.TabIndex = 5
        Me.BtnMin.Tag = "Primary"
        Me.BtnMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'BtnMax
        '
        Me.BtnMax.BackColor = System.Drawing.Color.Transparent
        Me.BtnMax.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnMax.FlatAppearance.BorderSize = 0
        Me.BtnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMax.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMax.Image = Global.FabricStoreProject.My.Resources.Resources.maximize_16
        Me.BtnMax.Location = New System.Drawing.Point(38, 0)
        Me.BtnMax.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(38, 28)
        Me.BtnMax.TabIndex = 4
        Me.BtnMax.Tag = "Primary"
        Me.BtnMax.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMax.UseVisualStyleBackColor = False
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
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PicMenu
        '
        Me.PicMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMenu.Image = CType(resources.GetObject("PicMenu.Image"), System.Drawing.Image)
        Me.PicMenu.Location = New System.Drawing.Point(763, 3)
        Me.PicMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PicMenu.Name = "PicMenu"
        Me.PicMenu.Size = New System.Drawing.Size(36, 22)
        Me.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMenu.TabIndex = 0
        Me.PicMenu.TabStop = False
        '
        'PnlSplit1
        '
        Me.PnlSplit1.BackColor = System.Drawing.Color.White
        Me.PnlSplit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSplit1.Location = New System.Drawing.Point(8, 36)
        Me.PnlSplit1.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlSplit1.Name = "PnlSplit1"
        Me.PnlSplit1.Size = New System.Drawing.Size(1024, 4)
        Me.PnlSplit1.TabIndex = 410
        '
        'TimerShowSettings
        '
        Me.TimerShowSettings.Interval = 25
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1040, 788)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.TLPButtons)
        Me.Controls.Add(Me.PnlSplit1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1023, 583)
        Me.Name = "Frmmain"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مركز إبتسامة هوليوود لطب وجراحة الفم والأسنان - منظومة الإدارة"
        Me.TransparencyKey = System.Drawing.SystemColors.Info
        Me.PnlMain.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PicUserSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPSettings.ResumeLayout(False)
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChangeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogoCo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPButtons.ResumeLayout(False)
        Me.PnlButton.ResumeLayout(False)
        Me.PnlBasicData.ResumeLayout(False)
        Me.PnlReports.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        CType(Me.PicMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlMain As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSLDateTime As ToolStripStatusLabel
    Friend WithEvents TSLUserName As ToolStripStatusLabel
    Friend WithEvents SSLMessage As ToolStripStatusLabel

    Private Sub PicClose_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents PnlMenu As Panel
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents PicMenu As PictureBox
    Friend WithEvents PicLogoCo As PictureBox
    Friend WithEvents PnlSplit1 As Panel
    Friend WithEvents TimerShowSettings As Timer
    Friend WithEvents TLPButtons As TableLayoutPanel
    Friend WithEvents PnlButton As Panel
    Friend WithEvents BtnSafe As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents BtnUserManagement As Button
    Friend WithEvents BtnBasicData As Button
    Friend WithEvents BtnSupplers As Button
    Friend WithEvents BtnPurchase As Button
    Friend WithEvents BtnEmployees As Button
    Friend WithEvents BtnSalaryTailors As Button
    Friend WithEvents BtnReceiptReport As Button
    Friend WithEvents BtnDailyServices As Button
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents BtnExpenses As Button
    Friend WithEvents PnlBasicData As Panel
    Friend WithEvents BtnBank As Button
    Friend WithEvents BtnPaymentType As Button
    Friend WithEvents BtnSales As Button
    Friend WithEvents PnlReports As Panel
    Friend WithEvents BtnReports As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnTreasury As Button
    Friend WithEvents BtnTreasuryReceipts As Button
    Friend WithEvents BtnCountry As Button
    Friend WithEvents LblTitel As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PicUserSettings As PictureBox
    Friend WithEvents TLPSettings As TableLayoutPanel
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents PicChangePass As PictureBox
    Friend WithEvents PicChangeColor As PictureBox
    Friend WithEvents BtnExpensesType As Button
    Friend WithEvents BtnServices As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnTailors As Button
    Friend WithEvents BtnSalarySuppliers As Button
    Friend WithEvents BtnCities As Button
    Friend WithEvents BtnDeliveryCo As Button
End Class
