<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemSizes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemSizes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TLPOrderDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSizeRefresh = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtHip = New System.Windows.Forms.TextBox()
        Me.TxtArmpit = New System.Windows.Forms.TextBox()
        Me.TxtWaist = New System.Windows.Forms.TextBox()
        Me.TxtSleeve = New System.Windows.Forms.TextBox()
        Me.TxtChest = New System.Windows.Forms.TextBox()
        Me.TxtShoulder = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlEditOrder = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblOrderData = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TLPOrderDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TLPOrder.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEditOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TLPOrderDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(751, 362)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Tag = "Background"
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
        Me.TLPOrderDetails.Size = New System.Drawing.Size(745, 356)
        Me.TLPOrderDetails.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(739, 288)
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
        Me.PnlData.Size = New System.Drawing.Size(739, 288)
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
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(739, 288)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSizeRefresh, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 241)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(733, 42)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'BtnSizeRefresh
        '
        Me.BtnSizeRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSizeRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSizeRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSizeRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSizeRefresh.FlatAppearance.BorderSize = 0
        Me.BtnSizeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSizeRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSizeRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnSizeRefresh.Image = CType(resources.GetObject("BtnSizeRefresh.Image"), System.Drawing.Image)
        Me.BtnSizeRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSizeRefresh.Location = New System.Drawing.Point(11, 1)
        Me.BtnSizeRefresh.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSizeRefresh.Name = "BtnSizeRefresh"
        Me.BtnSizeRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSizeRefresh.Size = New System.Drawing.Size(351, 40)
        Me.BtnSizeRefresh.TabIndex = 846
        Me.BtnSizeRefresh.Tag = "Dark"
        Me.BtnSizeRefresh.Text = "تحديث"
        Me.BtnSizeRefresh.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(372, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(351, 40)
        Me.BtnSave.TabIndex = 844
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(733, 232)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'TLPOrder
        '
        Me.TLPOrder.ColumnCount = 4
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TLPOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPOrder.Controls.Add(Me.TxtHip, 3, 3)
        Me.TLPOrder.Controls.Add(Me.TxtArmpit, 1, 3)
        Me.TLPOrder.Controls.Add(Me.TxtWaist, 3, 2)
        Me.TLPOrder.Controls.Add(Me.TxtSleeve, 1, 2)
        Me.TLPOrder.Controls.Add(Me.TxtChest, 3, 1)
        Me.TLPOrder.Controls.Add(Me.TxtShoulder, 1, 1)
        Me.TLPOrder.Controls.Add(Me.TxtHeight, 3, 0)
        Me.TLPOrder.Controls.Add(Me.TxtSize, 1, 0)
        Me.TLPOrder.Controls.Add(Me.Label4, 0, 0)
        Me.TLPOrder.Controls.Add(Me.Label24, 2, 0)
        Me.TLPOrder.Controls.Add(Me.Label27, 0, 1)
        Me.TLPOrder.Controls.Add(Me.Label29, 0, 2)
        Me.TLPOrder.Controls.Add(Me.Label31, 0, 3)
        Me.TLPOrder.Controls.Add(Me.Label26, 2, 3)
        Me.TLPOrder.Controls.Add(Me.Label28, 2, 2)
        Me.TLPOrder.Controls.Add(Me.Label30, 2, 1)
        Me.TLPOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPOrder.Location = New System.Drawing.Point(194, 2)
        Me.TLPOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPOrder.Name = "TLPOrder"
        Me.TLPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPOrder.RowCount = 4
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPOrder.Size = New System.Drawing.Size(537, 228)
        Me.TLPOrder.TabIndex = 1
        '
        'TxtHip
        '
        Me.TxtHip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHip.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHip.Location = New System.Drawing.Point(0, 182)
        Me.TxtHip.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtHip.MaxLength = 8
        Me.TxtHip.Name = "TxtHip"
        Me.TxtHip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtHip.Size = New System.Drawing.Size(149, 35)
        Me.TxtHip.TabIndex = 8
        Me.TxtHip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtArmpit
        '
        Me.TxtArmpit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtArmpit.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArmpit.Location = New System.Drawing.Point(269, 182)
        Me.TxtArmpit.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtArmpit.MaxLength = 8
        Me.TxtArmpit.Name = "TxtArmpit"
        Me.TxtArmpit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtArmpit.Size = New System.Drawing.Size(148, 35)
        Me.TxtArmpit.TabIndex = 7
        Me.TxtArmpit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtWaist
        '
        Me.TxtWaist.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWaist.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWaist.Location = New System.Drawing.Point(0, 125)
        Me.TxtWaist.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtWaist.MaxLength = 8
        Me.TxtWaist.Name = "TxtWaist"
        Me.TxtWaist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtWaist.Size = New System.Drawing.Size(149, 35)
        Me.TxtWaist.TabIndex = 6
        Me.TxtWaist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSleeve
        '
        Me.TxtSleeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSleeve.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSleeve.Location = New System.Drawing.Point(269, 125)
        Me.TxtSleeve.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSleeve.MaxLength = 8
        Me.TxtSleeve.Name = "TxtSleeve"
        Me.TxtSleeve.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSleeve.Size = New System.Drawing.Size(148, 35)
        Me.TxtSleeve.TabIndex = 5
        Me.TxtSleeve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChest
        '
        Me.TxtChest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChest.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChest.Location = New System.Drawing.Point(0, 68)
        Me.TxtChest.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtChest.MaxLength = 8
        Me.TxtChest.Name = "TxtChest"
        Me.TxtChest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtChest.Size = New System.Drawing.Size(149, 35)
        Me.TxtChest.TabIndex = 4
        Me.TxtChest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtShoulder
        '
        Me.TxtShoulder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtShoulder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShoulder.Location = New System.Drawing.Point(269, 68)
        Me.TxtShoulder.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtShoulder.MaxLength = 8
        Me.TxtShoulder.Name = "TxtShoulder"
        Me.TxtShoulder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtShoulder.Size = New System.Drawing.Size(148, 35)
        Me.TxtShoulder.TabIndex = 3
        Me.TxtShoulder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtHeight
        '
        Me.TxtHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHeight.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHeight.Location = New System.Drawing.Point(0, 11)
        Me.TxtHeight.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtHeight.MaxLength = 8
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtHeight.Size = New System.Drawing.Size(149, 35)
        Me.TxtHeight.TabIndex = 2
        Me.TxtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSize
        '
        Me.TxtSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSize.Location = New System.Drawing.Point(269, 11)
        Me.TxtSize.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSize.MaxLength = 8
        Me.TxtSize.Name = "TxtSize"
        Me.TxtSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSize.Size = New System.Drawing.Size(148, 35)
        Me.TxtSize.TabIndex = 1
        Me.TxtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(419, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(116, 57)
        Me.Label4.TabIndex = 1295
        Me.Label4.Text = "المقاس"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label24.Location = New System.Drawing.Point(151, 0)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(116, 57)
        Me.Label24.TabIndex = 1288
        Me.Label24.Text = "الطول"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label27.Location = New System.Drawing.Point(419, 57)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(116, 57)
        Me.Label27.TabIndex = 1290
        Me.Label27.Text = "عرض الكتف"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label29.Location = New System.Drawing.Point(419, 114)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label29.Size = New System.Drawing.Size(116, 57)
        Me.Label29.TabIndex = 1292
        Me.Label29.Text = "طول الكم"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label31.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label31.Location = New System.Drawing.Point(419, 171)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label31.Size = New System.Drawing.Size(116, 57)
        Me.Label31.TabIndex = 1294
        Me.Label31.Text = "دوران الإبط"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label26.Location = New System.Drawing.Point(151, 171)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(116, 57)
        Me.Label26.TabIndex = 1289
        Me.Label26.Text = "الحوض"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label28.Location = New System.Drawing.Point(151, 114)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(116, 57)
        Me.Label28.TabIndex = 1291
        Me.Label28.Text = "الخصر"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label30.Location = New System.Drawing.Point(151, 57)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label30.Size = New System.Drawing.Size(116, 57)
        Me.Label30.TabIndex = 1293
        Me.Label30.Text = "محيط الصدر"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1288
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 327)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(741, 27)
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
        Me.PnlEditOrder.Size = New System.Drawing.Size(741, 27)
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
        Me.LblOrderData.Location = New System.Drawing.Point(74, -1)
        Me.LblOrderData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblOrderData.Name = "LblOrderData"
        Me.LblOrderData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblOrderData.Size = New System.Drawing.Size(592, 28)
        Me.LblOrderData.TabIndex = 9
        Me.LblOrderData.Text = "مقاسات القطعة"
        Me.LblOrderData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmItemSizes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 368)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmItemSizes"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "مقاسات القطعة"
        Me.Panel1.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TLPOrderDetails As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlData As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TLPOrder As TableLayoutPanel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PnlEditOrder As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblOrderData As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSize As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtShoulder As TextBox
    Friend WithEvents TxtChest As TextBox
    Friend WithEvents TxtSleeve As TextBox
    Friend WithEvents TxtWaist As TextBox
    Friend WithEvents TxtArmpit As TextBox
    Friend WithEvents TxtHip As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnSizeRefresh As Button
    Friend WithEvents BtnSave As Button
End Class
