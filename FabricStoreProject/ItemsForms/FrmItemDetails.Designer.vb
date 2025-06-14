<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemDetails
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
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicBarcode = New System.Windows.Forms.PictureBox()
        Me.GrpTypes = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadAll = New System.Windows.Forms.RadioButton()
        Me.RadReady = New System.Windows.Forms.RadioButton()
        Me.RadOrder = New System.Windows.Forms.RadioButton()
        Me.TxtSumQuantity = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GrpItems = New System.Windows.Forms.GroupBox()
        Me.DGVItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColSizes = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PnlTitel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTypes.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GrpItems.SuspendLayout()
        CType(Me.DGVItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(403, 0)
        Me.LblTitel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(913, 34)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "تفاصيل الصنف رقم"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTitel
        '
        Me.PnlTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlTitel.Controls.Add(Me.BtnClose)
        Me.PnlTitel.Controls.Add(Me.LblTitel)
        Me.PnlTitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitel.ForeColor = System.Drawing.Color.Transparent
        Me.PnlTitel.Location = New System.Drawing.Point(4, 4)
        Me.PnlTitel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlTitel.Name = "PnlTitel"
        Me.PnlTitel.Size = New System.Drawing.Size(1717, 34)
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
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(51, 34)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PicBarcode)
        Me.Panel1.Controls.Add(Me.GrpTypes)
        Me.Panel1.Controls.Add(Me.TxtSumQuantity)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GrpItems)
        Me.Panel1.Controls.Add(Me.PnlTitel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Size = New System.Drawing.Size(1725, 623)
        Me.Panel1.TabIndex = 1242
        Me.Panel1.Tag = "Background"
        '
        'PicBarcode
        '
        Me.PicBarcode.Location = New System.Drawing.Point(83, 114)
        Me.PicBarcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicBarcode.Name = "PicBarcode"
        Me.PicBarcode.Size = New System.Drawing.Size(69, 50)
        Me.PicBarcode.TabIndex = 1303
        Me.PicBarcode.TabStop = False
        Me.PicBarcode.Visible = False
        '
        'GrpTypes
        '
        Me.GrpTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpTypes.Controls.Add(Me.TableLayoutPanel5)
        Me.GrpTypes.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpTypes.Location = New System.Drawing.Point(383, 62)
        Me.GrpTypes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpTypes.Name = "GrpTypes"
        Me.GrpTypes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpTypes.Size = New System.Drawing.Size(960, 102)
        Me.GrpTypes.TabIndex = 1302
        Me.GrpTypes.TabStop = False
        Me.GrpTypes.Text = "عرض حسب"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.RadAll, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RadReady, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RadOrder, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(52, 39)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(856, 46)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'RadAll
        '
        Me.RadAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadAll.Checked = True
        Me.RadAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAll.Location = New System.Drawing.Point(686, 4)
        Me.RadAll.Margin = New System.Windows.Forms.Padding(53, 2, 3, 2)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadAll.Size = New System.Drawing.Size(103, 37)
        Me.RadAll.TabIndex = 1254
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "الكل"
        Me.RadAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'RadReady
        '
        Me.RadReady.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadReady.AutoSize = True
        Me.RadReady.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadReady.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadReady.Location = New System.Drawing.Point(395, 4)
        Me.RadReady.Margin = New System.Windows.Forms.Padding(53, 2, 3, 2)
        Me.RadReady.Name = "RadReady"
        Me.RadReady.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadReady.Size = New System.Drawing.Size(114, 38)
        Me.RadReady.TabIndex = 1253
        Me.RadReady.Text = "جاهز للبيع"
        Me.RadReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadReady.UseVisualStyleBackColor = True
        '
        'RadOrder
        '
        Me.RadOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadOrder.AutoSize = True
        Me.RadOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadOrder.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadOrder.Location = New System.Drawing.Point(100, 4)
        Me.RadOrder.Margin = New System.Windows.Forms.Padding(53, 2, 3, 2)
        Me.RadOrder.Name = "RadOrder"
        Me.RadOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadOrder.Size = New System.Drawing.Size(135, 38)
        Me.RadOrder.TabIndex = 1252
        Me.RadOrder.Text = "طلبات الزبائن"
        Me.RadOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadOrder.UseVisualStyleBackColor = True
        '
        'TxtSumQuantity
        '
        Me.TxtSumQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSumQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSumQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSumQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSumQuantity.ForeColor = System.Drawing.Color.Black
        Me.TxtSumQuantity.Location = New System.Drawing.Point(19, 557)
        Me.TxtSumQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSumQuantity.Name = "TxtSumQuantity"
        Me.TxtSumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSumQuantity.Size = New System.Drawing.Size(443, 43)
        Me.TxtSumQuantity.TabIndex = 1301
        Me.TxtSumQuantity.Tag = "AutoC"
        Me.TxtSumQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(356, 564)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(329, 43)
        Me.Label9.TabIndex = 1300
        Me.Label9.Text = "إجمالي الكمية (قماش و ملابس)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpItems
        '
        Me.GrpItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpItems.Controls.Add(Me.DGVItem)
        Me.GrpItems.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpItems.Location = New System.Drawing.Point(21, 170)
        Me.GrpItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpItems.Name = "GrpItems"
        Me.GrpItems.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpItems.Size = New System.Drawing.Size(1684, 376)
        Me.GrpItems.TabIndex = 1298
        Me.GrpItems.TabStop = False
        Me.GrpItems.Text = "بيانات الصنف"
        '
        'DGVItem
        '
        Me.DGVItem.AllowUserToAddRows = False
        Me.DGVItem.AllowUserToResizeRows = False
        Me.DGVItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVItem.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVItem.ColumnHeadersHeight = 32
        Me.DGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column2, Me.Column6, Me.PruchPrice, Me.TotalAll, Me.Quantity, Me.Column7, Me.Column4, Me.Column5, Me.Column8, Me.Column9, Me.Column1, Me.ColEdit, Me.ColPrint, Me.ColSizes})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVItem.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVItem.Location = New System.Drawing.Point(23, 41)
        Me.DGVItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVItem.MultiSelect = False
        Me.DGVItem.Name = "DGVItem"
        Me.DGVItem.ReadOnly = True
        Me.DGVItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVItem.RowHeadersVisible = False
        Me.DGVItem.RowHeadersWidth = 51
        Me.DGVItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVItem.RowTemplate.Height = 30
        Me.DGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVItem.Size = New System.Drawing.Size(1639, 310)
        Me.DGVItem.TabIndex = 1236
        Me.DGVItem.Tag = "Dark-SelectionVisible"
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
        Me.Column2.HeaderText = "رقم القطعة"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "الاسم"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'PruchPrice
        '
        Me.PruchPrice.HeaderText = "سعر الشراء"
        Me.PruchPrice.MinimumWidth = 6
        Me.PruchPrice.Name = "PruchPrice"
        Me.PruchPrice.ReadOnly = True
        '
        'TotalAll
        '
        Me.TotalAll.HeaderText = "سعر البيع"
        Me.TotalAll.MinimumWidth = 6
        Me.TotalAll.Name = "TotalAll"
        Me.TotalAll.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "الكمية"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "رقم الصنف"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "النوع"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "المقاس"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "الصنع"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "اللون"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ItemStoreID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'ColEdit
        '
        Me.ColEdit.HeaderText = ""
        Me.ColEdit.MinimumWidth = 6
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.ReadOnly = True
        Me.ColEdit.Text = "تعديل"
        '
        'ColPrint
        '
        Me.ColPrint.HeaderText = ""
        Me.ColPrint.MinimumWidth = 6
        Me.ColPrint.Name = "ColPrint"
        Me.ColPrint.ReadOnly = True
        Me.ColPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColPrint.Text = "طباعة الرقم"
        Me.ColPrint.UseColumnTextForButtonValue = True
        '
        'ColSizes
        '
        Me.ColSizes.HeaderText = ""
        Me.ColSizes.MinimumWidth = 6
        Me.ColSizes.Name = "ColSizes"
        Me.ColSizes.ReadOnly = True
        Me.ColSizes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSizes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColSizes.Text = "تفاصيل القطعة"
        Me.ColSizes.UseColumnTextForButtonValue = True
        '
        'FrmItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 631)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmItemDetails"
        Me.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "تفاصيل الصنف"
        Me.PnlTitel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTypes.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GrpItems.ResumeLayout(False)
        CType(Me.DGVItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitel As Label
    Friend WithEvents PnlTitel As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GrpItems As GroupBox
    Friend WithEvents DGVItem As DataGridView
    Friend WithEvents TxtSumQuantity As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GrpTypes As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RadAll As RadioButton
    Friend WithEvents RadReady As RadioButton
    Friend WithEvents RadOrder As RadioButton
    Friend WithEvents PicBarcode As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PruchPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalAll As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ColEdit As DataGridViewButtonColumn
    Friend WithEvents ColPrint As DataGridViewButtonColumn
    Friend WithEvents ColSizes As DataGridViewButtonColumn
End Class
