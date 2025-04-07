<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseInvoiceContents
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSumValue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtStore = New System.Windows.Forms.Label()
        Me.TxtInvoNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DGVInvoContent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(27, 551)
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
        Me.TxtSumValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSumValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSumValue.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSumValue.ForeColor = System.Drawing.Color.Black
        Me.TxtSumValue.Location = New System.Drawing.Point(24, 550)
        Me.TxtSumValue.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSumValue.Name = "TxtSumValue"
        Me.TxtSumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSumValue.Size = New System.Drawing.Size(348, 35)
        Me.TxtSumValue.TabIndex = 1282
        Me.TxtSumValue.Tag = "AutoC"
        Me.TxtSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(376, 550)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(69, 35)
        Me.Label9.TabIndex = 1239
        Me.Label9.Text = "الإجمالي"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TxtStore.Size = New System.Drawing.Size(206, 35)
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
        Me.TxtInvoNum.Location = New System.Drawing.Point(284, 1)
        Me.TxtInvoNum.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtInvoNum.Name = "TxtInvoNum"
        Me.TxtInvoNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtInvoNum.Size = New System.Drawing.Size(136, 35)
        Me.TxtInvoNum.TabIndex = 1280
        Me.TxtInvoNum.Tag = "AutoC"
        Me.TxtInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(660, 0)
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
        Me.TxtUserName.Location = New System.Drawing.Point(522, 1)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtUserName.Size = New System.Drawing.Size(136, 35)
        Me.TxtUserName.TabIndex = 1279
        Me.TxtUserName.Tag = "AutoC"
        Me.TxtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(422, 0)
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
        Me.Label3.Location = New System.Drawing.Point(208, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 31)
        Me.Label3.TabIndex = 1245
        Me.Label3.Text = "المورد"
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
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(747, 37)
        Me.TableLayoutPanel11.TabIndex = 1208
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtSumValue)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.DGVInvoContent)
        Me.Panel1.Controls.Add(Me.PnlTitel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(820, 602)
        Me.Panel1.TabIndex = 1241
        Me.Panel1.Tag = "Background"
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
        Me.GroupBox8.Size = New System.Drawing.Size(779, 86)
        Me.GroupBox8.TabIndex = 1236
        Me.GroupBox8.TabStop = False
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
        Me.DGVInvoContent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column2, Me.PruchPrice, Me.Quantity, Me.TotalAll, Me.Column1, Me.Column3})
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
        Me.DGVInvoContent.Size = New System.Drawing.Size(779, 388)
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
        'Column1
        '
        Me.Column1.HeaderText = "اللون"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "الصنع"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
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
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(332, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(167, 28)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "تفاصيل الفاتورة  "
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPurchaseInvoiceContents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 608)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchaseInvoiceContents"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "تفاصيل الفاتورة"
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DGVInvoContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtSumValue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtStore As Label
    Friend WithEvents TxtInvoNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DGVInvoContent As DataGridView
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTitel As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PruchPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalAll As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
