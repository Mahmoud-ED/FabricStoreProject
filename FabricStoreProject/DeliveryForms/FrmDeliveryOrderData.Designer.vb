<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeliveryOrderData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeliveryOrderData))
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
        Me.BtnSell = New System.Windows.Forms.Button()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlEditOrder = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TLPOrderDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TLPDeliveryData.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
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
        Me.TLPOrderDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPOrderDetails.Name = "TLPOrderDetails"
        Me.TLPOrderDetails.RowCount = 3
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPOrderDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TLPOrderDetails.Size = New System.Drawing.Size(556, 347)
        Me.TLPOrderDetails.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(550, 279)
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
        Me.PnlData.Size = New System.Drawing.Size(550, 279)
        Me.PnlData.TabIndex = 1
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(550, 279)
        Me.TableLayoutPanel3.TabIndex = 1
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
        Me.TLPDeliveryData.Size = New System.Drawing.Size(550, 229)
        Me.TLPDeliveryData.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(444, 177)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(104, 47)
        Me.Label21.TabIndex = 1291
        Me.Label21.Text = "رقم الهاتف"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDeliveryPrice
        '
        Me.TxtDeliveryPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDeliveryPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryPrice.Location = New System.Drawing.Point(12, 138)
        Me.TxtDeliveryPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtDeliveryPrice.MaxLength = 8
        Me.TxtDeliveryPrice.Name = "TxtDeliveryPrice"
        Me.TxtDeliveryPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDeliveryPrice.Size = New System.Drawing.Size(428, 35)
        Me.TxtDeliveryPrice.TabIndex = 4
        Me.TxtDeliveryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label17.Location = New System.Drawing.Point(444, 134)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(104, 43)
        Me.Label17.TabIndex = 1287
        Me.Label17.Text = "السعر"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label18.Location = New System.Drawing.Point(444, 48)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(104, 43)
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
        Me.CmbDeliveryOrder.Location = New System.Drawing.Point(10, 8)
        Me.CmbDeliveryOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbDeliveryOrder.Name = "CmbDeliveryOrder"
        Me.CmbDeliveryOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbDeliveryOrder.Size = New System.Drawing.Size(432, 35)
        Me.CmbDeliveryOrder.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label19.Location = New System.Drawing.Point(444, 91)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(104, 43)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "العنوان"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label20.Location = New System.Drawing.Point(444, 5)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(104, 43)
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
        Me.CmbCityOrder.Location = New System.Drawing.Point(10, 51)
        Me.CmbCityOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbCityOrder.Name = "CmbCityOrder"
        Me.CmbCityOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCityOrder.Size = New System.Drawing.Size(432, 35)
        Me.CmbCityOrder.TabIndex = 2
        '
        'TxtAddress
        '
        Me.TxtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAddress.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(12, 95)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtAddress.MaxLength = 200
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddress.Size = New System.Drawing.Size(428, 35)
        Me.TxtAddress.TabIndex = 3
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPhone
        '
        Me.TxtPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone.BackColor = System.Drawing.Color.White
        Me.TxtPhone.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone.Location = New System.Drawing.Point(12, 183)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone.MaxLength = 10
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(428, 35)
        Me.TxtPhone.TabIndex = 5
        Me.TxtPhone.Tag = "10"
        Me.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 7
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.BtnSell, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BtnSend, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 232)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(544, 42)
        Me.TableLayoutPanel7.TabIndex = 2
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
        Me.BtnSell.Location = New System.Drawing.Point(13, 3)
        Me.BtnSell.Name = "BtnSell"
        Me.BtnSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSell.Size = New System.Drawing.Size(162, 36)
        Me.BtnSell.TabIndex = 2
        Me.BtnSell.Tag = "Dark"
        Me.BtnSell.Text = "تسليم للزبون"
        Me.BtnSell.UseVisualStyleBackColor = False
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
        Me.BtnSend.Location = New System.Drawing.Point(191, 3)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(162, 36)
        Me.BtnSend.TabIndex = 1
        Me.BtnSend.Tag = "Dark"
        Me.BtnSend.Text = "تسليم للتوصيل"
        Me.BtnSend.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(369, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(162, 36)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 318)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(552, 27)
        Me.Panel6.TabIndex = 1246
        Me.Panel6.TabStop = True
        Me.Panel6.Tag = "Dark"
        '
        'PnlEditOrder
        '
        Me.PnlEditOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlEditOrder.Controls.Add(Me.Label1)
        Me.PnlEditOrder.Controls.Add(Me.BtnClose)
        Me.PnlEditOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlEditOrder.Location = New System.Drawing.Point(2, 2)
        Me.PnlEditOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlEditOrder.Name = "PnlEditOrder"
        Me.PnlEditOrder.Size = New System.Drawing.Size(552, 27)
        Me.PnlEditOrder.TabIndex = 1245
        Me.PnlEditOrder.TabStop = True
        Me.PnlEditOrder.Tag = "Dark"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "بيانات الطلب"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TLPOrderDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(562, 353)
        Me.Panel1.TabIndex = 1247
        Me.Panel1.Tag = "Background"
        '
        'FrmDeliveryOrderData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 359)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDeliveryOrderData"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "بيانات طلب خدمة توصيل"
        Me.TLPOrderDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnlData.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TLPDeliveryData.ResumeLayout(False)
        Me.TLPDeliveryData.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.PnlEditOrder.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLPOrderDetails As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSend As Button
    Friend WithEvents BtnSell As Button
    Friend WithEvents PnlData As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TLPDeliveryData As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtDeliveryPrice As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CmbDeliveryOrder As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbCityOrder As ComboBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PnlEditOrder As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
