<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrderData))
        Me.TLPOrderDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.BtnReceive = New System.Windows.Forms.Button()
        Me.BtnSell = New System.Windows.Forms.Button()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbTailorOrder = New System.Windows.Forms.ComboBox()
        Me.CmbServiceOrder = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtHip = New System.Windows.Forms.TextBox()
        Me.TxtWaist = New System.Windows.Forms.TextBox()
        Me.TxtChest = New System.Windows.Forms.TextBox()
        Me.TxtArmpit = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtSleeve = New System.Windows.Forms.TextBox()
        Me.TxtShoulder = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTailorPrice = New System.Windows.Forms.TextBox()
        Me.TxtSize = New System.Windows.Forms.TextBox()
        Me.CmbSizeName = New System.Windows.Forms.ComboBox()
        Me.TxtSizeName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlEditOrder = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblOrderData = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkCustomerPrice = New System.Windows.Forms.CheckBox()
        Me.TLPOrderDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TLPOrder.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEditOrder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLPOrderDetails
        '
        Me.TLPOrderDetails.ColumnCount = 1
        Me.TLPOrderDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPOrderDetails.Controls.Add(Me.Panel2, 0, 1)
        Me.TLPOrderDetails.Controls.Add(Me.Panel6, 0, 2)
        Me.TLPOrderDetails.Controls.Add(Me.PnlEditOrder, 0, 0)
        Me.TLPOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPOrderDetails.Location = New System.Drawing.Point(3, 3)
        Me.TLPOrderDetails.Name = "TLPOrderDetails"
        Me.TLPOrderDetails.RowCount = 3
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.Size = New System.Drawing.Size(868, 476)
        Me.TLPOrderDetails.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 408)
        Me.Panel2.TabIndex = 1
        '
        'PnlData
        '
        Me.PnlData.AutoScroll = True
        Me.PnlData.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlData.Location = New System.Drawing.Point(0, 0)
        Me.PnlData.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(862, 408)
        Me.PnlData.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel11, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(862, 408)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSend, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnReceive, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSell, 7, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 357)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(856, 48)
        Me.TableLayoutPanel2.TabIndex = 2
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
        Me.BtnSave.Location = New System.Drawing.Point(648, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(195, 42)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.BtnSend.Location = New System.Drawing.Point(437, 3)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(195, 42)
        Me.BtnSend.TabIndex = 2
        Me.BtnSend.Tag = "Dark"
        Me.BtnSend.Text = "تسليم للخياط"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'BtnReceive
        '
        Me.BtnReceive.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReceive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnReceive.FlatAppearance.BorderSize = 0
        Me.BtnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceive.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceive.ForeColor = System.Drawing.Color.White
        Me.BtnReceive.Image = CType(resources.GetObject("BtnReceive.Image"), System.Drawing.Image)
        Me.BtnReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReceive.Location = New System.Drawing.Point(226, 3)
        Me.BtnReceive.Name = "BtnReceive"
        Me.BtnReceive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnReceive.Size = New System.Drawing.Size(195, 42)
        Me.BtnReceive.TabIndex = 3
        Me.BtnReceive.Tag = "Dark"
        Me.BtnReceive.Text = "استلام من الخياط"
        Me.BtnReceive.UseVisualStyleBackColor = False
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
        Me.BtnSell.Location = New System.Drawing.Point(15, 3)
        Me.BtnSell.Name = "BtnSell"
        Me.BtnSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSell.Size = New System.Drawing.Size(195, 42)
        Me.BtnSell.TabIndex = 4
        Me.BtnSell.Tag = "Dark"
        Me.BtnSell.Text = "تسليم للزبون"
        Me.BtnSell.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.80952!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19048!))
        Me.TableLayoutPanel11.Controls.Add(Me.TLPOrder, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(856, 348)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'TLPOrder
        '
        Me.TLPOrder.ColumnCount = 4
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TLPOrder.Controls.Add(Me.Label7, 0, 5)
        Me.TLPOrder.Controls.Add(Me.LblCustomerName, 2, 3)
        Me.TLPOrder.Controls.Add(Me.Label6, 1, 3)
        Me.TLPOrder.Controls.Add(Me.CmbTailorOrder, 1, 0)
        Me.TLPOrder.Controls.Add(Me.CmbServiceOrder, 1, 1)
        Me.TLPOrder.Controls.Add(Me.Label3, 0, 1)
        Me.TLPOrder.Controls.Add(Me.Label5, 0, 0)
        Me.TLPOrder.Controls.Add(Me.Label26, 2, 8)
        Me.TLPOrder.Controls.Add(Me.Label28, 2, 7)
        Me.TLPOrder.Controls.Add(Me.Label30, 2, 6)
        Me.TLPOrder.Controls.Add(Me.Label31, 2, 5)
        Me.TLPOrder.Controls.Add(Me.Label24, 0, 6)
        Me.TLPOrder.Controls.Add(Me.Label27, 0, 7)
        Me.TLPOrder.Controls.Add(Me.Label29, 0, 8)
        Me.TLPOrder.Controls.Add(Me.Label1, 2, 1)
        Me.TLPOrder.Controls.Add(Me.Label4, 2, 0)
        Me.TLPOrder.Controls.Add(Me.TxtTailorPrice, 3, 1)
        Me.TLPOrder.Controls.Add(Me.TxtSize, 3, 0)
        Me.TLPOrder.Controls.Add(Me.TxtSleeve, 1, 8)
        Me.TLPOrder.Controls.Add(Me.TxtShoulder, 1, 7)
        Me.TLPOrder.Controls.Add(Me.TxtHeight, 1, 6)
        Me.TLPOrder.Controls.Add(Me.TxtSizeName, 1, 5)
        Me.TLPOrder.Controls.Add(Me.CmbSizeName, 1, 4)
        Me.TLPOrder.Controls.Add(Me.TxtHip, 3, 8)
        Me.TLPOrder.Controls.Add(Me.TxtWaist, 3, 7)
        Me.TLPOrder.Controls.Add(Me.TxtChest, 3, 6)
        Me.TLPOrder.Controls.Add(Me.TxtArmpit, 3, 5)
        Me.TLPOrder.Controls.Add(Me.ChkCustomerPrice, 3, 2)
        Me.TLPOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPOrder.Location = New System.Drawing.Point(227, 2)
        Me.TLPOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPOrder.Name = "TLPOrder"
        Me.TLPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPOrder.RowCount = 9
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TLPOrder.Size = New System.Drawing.Size(627, 344)
        Me.TLPOrder.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(521, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(104, 38)
        Me.Label7.TabIndex = 1304
        Me.Label7.Text = "الاسم"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCustomerName
        '
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblCustomerName.Location = New System.Drawing.Point(119, 114)
        Me.LblCustomerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCustomerName.Size = New System.Drawing.Size(127, 38)
        Me.LblCustomerName.TabIndex = 1301
        Me.LblCustomerName.Tag = ""
        Me.LblCustomerName.Text = "اسم الزبون "
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(250, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(267, 38)
        Me.Label6.TabIndex = 1300
        Me.Label6.Text = "مقاسات الزبون / "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbTailorOrder
        '
        Me.CmbTailorOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbTailorOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbTailorOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTailorOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbTailorOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTailorOrder.FormattingEnabled = True
        Me.CmbTailorOrder.Location = New System.Drawing.Point(248, 1)
        Me.CmbTailorOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbTailorOrder.Name = "CmbTailorOrder"
        Me.CmbTailorOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbTailorOrder.Size = New System.Drawing.Size(271, 35)
        Me.CmbTailorOrder.TabIndex = 1
        '
        'CmbServiceOrder
        '
        Me.CmbServiceOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbServiceOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbServiceOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbServiceOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbServiceOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbServiceOrder.FormattingEnabled = True
        Me.CmbServiceOrder.Location = New System.Drawing.Point(248, 39)
        Me.CmbServiceOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbServiceOrder.Name = "CmbServiceOrder"
        Me.CmbServiceOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbServiceOrder.Size = New System.Drawing.Size(271, 35)
        Me.CmbServiceOrder.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(521, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(104, 38)
        Me.Label3.TabIndex = 1286
        Me.Label3.Text = "الخدمة"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(521, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(104, 38)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "الخياط"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtHip
        '
        Me.TxtHip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHip.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHip.Location = New System.Drawing.Point(0, 306)
        Me.TxtHip.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtHip.MaxLength = 8
        Me.TxtHip.Name = "TxtHip"
        Me.TxtHip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtHip.Size = New System.Drawing.Size(117, 35)
        Me.TxtHip.TabIndex = 13
        Me.TxtHip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtWaist
        '
        Me.TxtWaist.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWaist.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWaist.Location = New System.Drawing.Point(0, 267)
        Me.TxtWaist.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtWaist.MaxLength = 8
        Me.TxtWaist.Name = "TxtWaist"
        Me.TxtWaist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtWaist.Size = New System.Drawing.Size(117, 35)
        Me.TxtWaist.TabIndex = 12
        Me.TxtWaist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChest
        '
        Me.TxtChest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChest.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChest.Location = New System.Drawing.Point(0, 229)
        Me.TxtChest.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtChest.MaxLength = 8
        Me.TxtChest.Name = "TxtChest"
        Me.TxtChest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtChest.Size = New System.Drawing.Size(117, 35)
        Me.TxtChest.TabIndex = 11
        Me.TxtChest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtArmpit
        '
        Me.TxtArmpit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtArmpit.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArmpit.Location = New System.Drawing.Point(0, 191)
        Me.TxtArmpit.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtArmpit.MaxLength = 8
        Me.TxtArmpit.Name = "TxtArmpit"
        Me.TxtArmpit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtArmpit.Size = New System.Drawing.Size(117, 35)
        Me.TxtArmpit.TabIndex = 10
        Me.TxtArmpit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label26.Location = New System.Drawing.Point(119, 304)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(127, 40)
        Me.Label26.TabIndex = 1289
        Me.Label26.Text = "الحوض"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label28.Location = New System.Drawing.Point(119, 266)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(127, 38)
        Me.Label28.TabIndex = 1291
        Me.Label28.Text = "الخصر"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label30.Location = New System.Drawing.Point(119, 228)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label30.Size = New System.Drawing.Size(127, 38)
        Me.Label30.TabIndex = 1293
        Me.Label30.Text = "محيط الصدر"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label31.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label31.Location = New System.Drawing.Point(119, 190)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label31.Size = New System.Drawing.Size(127, 38)
        Me.Label31.TabIndex = 1294
        Me.Label31.Text = "دوران الإبط"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSleeve
        '
        Me.TxtSleeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSleeve.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSleeve.Location = New System.Drawing.Point(248, 306)
        Me.TxtSleeve.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSleeve.MaxLength = 8
        Me.TxtSleeve.Name = "TxtSleeve"
        Me.TxtSleeve.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSleeve.Size = New System.Drawing.Size(271, 35)
        Me.TxtSleeve.TabIndex = 9
        Me.TxtSleeve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtShoulder
        '
        Me.TxtShoulder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtShoulder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShoulder.Location = New System.Drawing.Point(248, 267)
        Me.TxtShoulder.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtShoulder.MaxLength = 8
        Me.TxtShoulder.Name = "TxtShoulder"
        Me.TxtShoulder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtShoulder.Size = New System.Drawing.Size(271, 35)
        Me.TxtShoulder.TabIndex = 8
        Me.TxtShoulder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtHeight
        '
        Me.TxtHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHeight.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHeight.Location = New System.Drawing.Point(248, 229)
        Me.TxtHeight.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtHeight.MaxLength = 8
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtHeight.Size = New System.Drawing.Size(271, 35)
        Me.TxtHeight.TabIndex = 7
        Me.TxtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label24.Location = New System.Drawing.Point(521, 228)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(104, 38)
        Me.Label24.TabIndex = 1288
        Me.Label24.Text = "الطول"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label27.Location = New System.Drawing.Point(521, 266)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(104, 38)
        Me.Label27.TabIndex = 1290
        Me.Label27.Text = "عرض الكتف"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label29.Location = New System.Drawing.Point(521, 304)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label29.Size = New System.Drawing.Size(104, 40)
        Me.Label29.TabIndex = 1292
        Me.Label29.Text = "طول الكم"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(119, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(127, 38)
        Me.Label1.TabIndex = 1287
        Me.Label1.Text = "س الخياطة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(119, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(127, 38)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "المقاس"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTailorPrice
        '
        Me.TxtTailorPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTailorPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTailorPrice.Location = New System.Drawing.Point(0, 39)
        Me.TxtTailorPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTailorPrice.MaxLength = 8
        Me.TxtTailorPrice.Name = "TxtTailorPrice"
        Me.TxtTailorPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTailorPrice.Size = New System.Drawing.Size(117, 35)
        Me.TxtTailorPrice.TabIndex = 4
        Me.TxtTailorPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSize
        '
        Me.TxtSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSize.Location = New System.Drawing.Point(0, 1)
        Me.TxtSize.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSize.MaxLength = 8
        Me.TxtSize.Name = "TxtSize"
        Me.TxtSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSize.Size = New System.Drawing.Size(117, 35)
        Me.TxtSize.TabIndex = 3
        Me.TxtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbSizeName
        '
        Me.CmbSizeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSizeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSizeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSizeName.DropDownHeight = 160
        Me.CmbSizeName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSizeName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSizeName.FormattingEnabled = True
        Me.CmbSizeName.IntegralHeight = False
        Me.CmbSizeName.Location = New System.Drawing.Point(248, 153)
        Me.CmbSizeName.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbSizeName.Name = "CmbSizeName"
        Me.CmbSizeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbSizeName.Size = New System.Drawing.Size(271, 35)
        Me.CmbSizeName.TabIndex = 5
        '
        'TxtSizeName
        '
        Me.TxtSizeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSizeName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSizeName.Location = New System.Drawing.Point(248, 191)
        Me.TxtSizeName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSizeName.MaxLength = 8
        Me.TxtSizeName.Name = "TxtSizeName"
        Me.TxtSizeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSizeName.Size = New System.Drawing.Size(271, 35)
        Me.TxtSizeName.TabIndex = 6
        Me.TxtSizeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 342)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1288
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 447)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(864, 27)
        Me.Panel6.TabIndex = 1246
        Me.Panel6.TabStop = True
        Me.Panel6.Tag = "Dark"
        '
        'PnlEditOrder
        '
        Me.PnlEditOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlEditOrder.Controls.Add(Me.BtnClose)
        Me.PnlEditOrder.Controls.Add(Me.LblOrderData)
        Me.PnlEditOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlEditOrder.Location = New System.Drawing.Point(2, 2)
        Me.PnlEditOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlEditOrder.Name = "PnlEditOrder"
        Me.PnlEditOrder.Size = New System.Drawing.Size(864, 27)
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
        'LblOrderData
        '
        Me.LblOrderData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOrderData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblOrderData.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderData.ForeColor = System.Drawing.Color.White
        Me.LblOrderData.Location = New System.Drawing.Point(352, -1)
        Me.LblOrderData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblOrderData.Name = "LblOrderData"
        Me.LblOrderData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblOrderData.Size = New System.Drawing.Size(161, 28)
        Me.LblOrderData.TabIndex = 9
        Me.LblOrderData.Text = "بيانات الطلب"
        Me.LblOrderData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TLPOrderDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(874, 482)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Tag = "Background"
        '
        'ChkCustomerPrice
        '
        Me.ChkCustomerPrice.AutoSize = True
        Me.ChkCustomerPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkCustomerPrice.Location = New System.Drawing.Point(14, 79)
        Me.ChkCustomerPrice.Name = "ChkCustomerPrice"
        Me.ChkCustomerPrice.Size = New System.Drawing.Size(100, 32)
        Me.ChkCustomerPrice.TabIndex = 1306
        Me.ChkCustomerPrice.Text = "على الزبون"
        Me.ChkCustomerPrice.UseVisualStyleBackColor = True
        '
        'FrmOrderData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 488)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOrderData"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "طلبات الزبائن"
        Me.TLPOrderDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnlData.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TLPOrder.ResumeLayout(False)
        Me.TLPOrder.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEditOrder.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLPOrderDetails As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlData As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnSend As Button
    Friend WithEvents BtnReceive As Button
    Friend WithEvents BtnSell As Button
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TLPOrder As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbTailorOrder As ComboBox
    Friend WithEvents CmbServiceOrder As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHip As TextBox
    Friend WithEvents TxtWaist As TextBox
    Friend WithEvents TxtChest As TextBox
    Friend WithEvents TxtArmpit As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtSleeve As TextBox
    Friend WithEvents TxtShoulder As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTailorPrice As TextBox
    Friend WithEvents TxtSize As TextBox
    Friend WithEvents CmbSizeName As ComboBox
    Friend WithEvents TxtSizeName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PnlEditOrder As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblOrderData As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkCustomerPrice As CheckBox
End Class
