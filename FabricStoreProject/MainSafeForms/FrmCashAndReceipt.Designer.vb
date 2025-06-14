<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashAndReceipt
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCashAndReceipt))
        Me.DGVCashing = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtPageNum = New System.Windows.Forms.TextBox()
        Me.NUDPageSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BtnLastPage = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtnNextPage = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.BtnPreviousPage = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnFirstPage = New System.Windows.Forms.Button()
        Me.LblMain = New System.Windows.Forms.Label()
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCashing
        '
        Me.DGVCashing.AllowUserToAddRows = False
        Me.DGVCashing.AllowUserToDeleteRows = False
        Me.DGVCashing.AllowUserToResizeRows = False
        Me.DGVCashing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCashing.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCashing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCashing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCashing.ColumnHeadersHeight = 32
        Me.DGVCashing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVCashing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column10, Me.Column11, Me.Column12, Me.Column2, Me.Column3, Me.Column1, Me.Column4, Me.ColShow})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCashing.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCashing.EnableHeadersVisualStyles = False
        Me.DGVCashing.GridColor = System.Drawing.Color.Gray
        Me.DGVCashing.Location = New System.Drawing.Point(12, 33)
        Me.DGVCashing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCashing.MultiSelect = False
        Me.DGVCashing.Name = "DGVCashing"
        Me.DGVCashing.ReadOnly = True
        Me.DGVCashing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCashing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCashing.RowHeadersVisible = False
        Me.DGVCashing.RowHeadersWidth = 51
        Me.DGVCashing.RowTemplate.Height = 30
        Me.DGVCashing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCashing.Size = New System.Drawing.Size(1256, 641)
        Me.DGVCashing.TabIndex = 1238
        Me.DGVCashing.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle2.Format = "0000"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "رقم الإيصال"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "البيان"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'Column10
        '
        Me.Column10.HeaderText = "المسلم"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        Me.Column10.Width = 300
        '
        'Column11
        '
        Me.Column11.HeaderText = "القيمة"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 150
        '
        'Column12
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column12.HeaderText = "تاريخ الايصال"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "المستلم"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "طريقة الدفع"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column1
        '
        Me.Column1.HeaderText = "البند المالي"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "نوع الايصال"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'ColShow
        '
        Me.ColShow.HeaderText = ""
        Me.ColShow.MinimumWidth = 6
        Me.ColShow.Name = "ColShow"
        Me.ColShow.ReadOnly = True
        Me.ColShow.Text = "عرض"
        Me.ColShow.UseColumnTextForButtonValue = True
        Me.ColShow.Width = 96
        '
        'TLPPages
        '
        Me.TLPPages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPPages.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TLPPages.ColumnCount = 10
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.756757!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.756757!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162!))
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TLPPages.Controls.Add(Me.BtnRefreshPage, 9, 0)
        Me.TLPPages.Controls.Add(Me.TxtPagesCount, 6, 0)
        Me.TLPPages.Controls.Add(Me.TxtPageNum, 2, 0)
        Me.TLPPages.Controls.Add(Me.NUDPageSize, 8, 0)
        Me.TLPPages.Controls.Add(Me.Panel3, 7, 0)
        Me.TLPPages.Controls.Add(Me.Panel4, 5, 0)
        Me.TLPPages.Controls.Add(Me.Panel12, 4, 0)
        Me.TLPPages.Controls.Add(Me.Panel13, 3, 0)
        Me.TLPPages.Controls.Add(Me.Panel14, 1, 0)
        Me.TLPPages.Controls.Add(Me.Panel16, 0, 0)
        Me.TLPPages.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPPages.Location = New System.Drawing.Point(374, 678)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(866, 49)
        Me.TLPPages.TabIndex = 1239
        Me.TLPPages.Tag = "Dark"
        '
        'BtnRefreshPage
        '
        Me.BtnRefreshPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefreshPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefreshPage.FlatAppearance.BorderSize = 0
        Me.BtnRefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshPage.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshPage.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshPage.Image = CType(resources.GetObject("BtnRefreshPage.Image"), System.Drawing.Image)
        Me.BtnRefreshPage.Location = New System.Drawing.Point(4, 4)
        Me.BtnRefreshPage.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRefreshPage.Name = "BtnRefreshPage"
        Me.BtnRefreshPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshPage.Size = New System.Drawing.Size(126, 41)
        Me.BtnRefreshPage.TabIndex = 1207
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(386, 4)
        Me.TxtPagesCount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(82, 42)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPageNum
        '
        Me.TxtPageNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPageNum.BackColor = System.Drawing.Color.White
        Me.TxtPageNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPageNum.Location = New System.Drawing.Point(707, 4)
        Me.TxtPageNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPageNum.Name = "TxtPageNum"
        Me.TxtPageNum.ReadOnly = True
        Me.TxtPageNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPageNum.Size = New System.Drawing.Size(82, 42)
        Me.TxtPageNum.TabIndex = 1205
        Me.TxtPageNum.TabStop = False
        Me.TxtPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(138, 4)
        Me.NUDPageSize.Margin = New System.Windows.Forms.Padding(4)
        Me.NUDPageSize.Name = "NUDPageSize"
        Me.NUDPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NUDPageSize.Size = New System.Drawing.Size(82, 42)
        Me.NUDPageSize.TabIndex = 20
        Me.NUDPageSize.TabStop = False
        Me.NUDPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(227, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(152, 45)
        Me.Panel3.TabIndex = 1205
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 5)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 34)
        Me.Label10.TabIndex = 1201
        Me.Label10.Text = "حجم الصفحة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(475, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(152, 45)
        Me.Panel4.TabIndex = 1205
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 5)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 34)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "عدد الصفحات"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BtnLastPage)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(633, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(39, 45)
        Me.Panel12.TabIndex = 1205
        '
        'BtnLastPage
        '
        Me.BtnLastPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnLastPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLastPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLastPage.FlatAppearance.BorderSize = 0
        Me.BtnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLastPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLastPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLastPage.Image = CType(resources.GetObject("BtnLastPage.Image"), System.Drawing.Image)
        Me.BtnLastPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnLastPage.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLastPage.Size = New System.Drawing.Size(39, 45)
        Me.BtnLastPage.TabIndex = 19
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnNextPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(678, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(22, 45)
        Me.Panel13.TabIndex = 1205
        '
        'BtnNextPage
        '
        Me.BtnNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNextPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNextPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNextPage.FlatAppearance.BorderSize = 0
        Me.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNextPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNextPage.Image = CType(resources.GetObject("BtnNextPage.Image"), System.Drawing.Image)
        Me.BtnNextPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnNextPage.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNextPage.Size = New System.Drawing.Size(22, 45)
        Me.BtnNextPage.TabIndex = 18
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.BtnPreviousPage)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(796, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(22, 45)
        Me.Panel14.TabIndex = 1205
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreviousPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPreviousPage.FlatAppearance.BorderSize = 0
        Me.BtnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreviousPage.Image = CType(resources.GetObject("BtnPreviousPage.Image"), System.Drawing.Image)
        Me.BtnPreviousPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnPreviousPage.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPreviousPage.Size = New System.Drawing.Size(22, 45)
        Me.BtnPreviousPage.TabIndex = 17
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(824, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(39, 45)
        Me.Panel16.TabIndex = 1205
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFirstPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnFirstPage.FlatAppearance.BorderSize = 0
        Me.BtnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirstPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirstPage.Image = CType(resources.GetObject("BtnFirstPage.Image"), System.Drawing.Image)
        Me.BtnFirstPage.Location = New System.Drawing.Point(0, 0)
        Me.BtnFirstPage.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirstPage.Size = New System.Drawing.Size(39, 45)
        Me.BtnFirstPage.TabIndex = 16
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'LblMain
        '
        Me.LblMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblMain.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMain.Location = New System.Drawing.Point(12, 685)
        Me.LblMain.Name = "LblMain"
        Me.LblMain.Size = New System.Drawing.Size(329, 42)
        Me.LblMain.TabIndex = 1240
        '
        'FrmCashAndReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 749)
        Me.Controls.Add(Me.LblMain)
        Me.Controls.Add(Me.TLPPages)
        Me.Controls.Add(Me.DGVCashing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCashAndReceipt"
        Me.Text = "FrmCashAndReceipt"
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVCashing As DataGridView
    Friend WithEvents TLPPages As TableLayoutPanel
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents TxtPagesCount As TextBox
    Friend WithEvents TxtPageNum As TextBox
    Friend WithEvents NUDPageSize As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnLastPage As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnNextPage As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents BtnPreviousPage As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnFirstPage As Button
    Friend WithEvents LblMain As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ColShow As DataGridViewButtonColumn
End Class
