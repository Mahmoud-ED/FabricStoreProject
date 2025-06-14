<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchInvo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearchInvo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtCurrentPage = New System.Windows.Forms.TextBox()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVReport = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TxtSearchName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TLPPages)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DGVReport)
        Me.Panel2.Controls.Add(Me.PnlMenu)
        Me.Panel2.Controls.Add(Me.GrpSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Size = New System.Drawing.Size(1345, 697)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Tag = "Background"
        '
        'TLPPages
        '
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
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TLPPages.Controls.Add(Me.BtnRefreshPage, 9, 0)
        Me.TLPPages.Controls.Add(Me.TxtPagesCount, 6, 0)
        Me.TLPPages.Controls.Add(Me.TxtCurrentPage, 2, 0)
        Me.TLPPages.Controls.Add(Me.NUDPageSize, 8, 0)
        Me.TLPPages.Controls.Add(Me.Panel3, 7, 0)
        Me.TLPPages.Controls.Add(Me.Panel4, 5, 0)
        Me.TLPPages.Controls.Add(Me.Panel12, 4, 0)
        Me.TLPPages.Controls.Add(Me.Panel13, 3, 0)
        Me.TLPPages.Controls.Add(Me.Panel14, 1, 0)
        Me.TLPPages.Controls.Add(Me.Panel16, 0, 0)
        Me.TLPPages.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPPages.Location = New System.Drawing.Point(20, 599)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(1304, 49)
        Me.TLPPages.TabIndex = 1216
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
        Me.BtnRefreshPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRefreshPage.Name = "BtnRefreshPage"
        Me.BtnRefreshPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshPage.Size = New System.Drawing.Size(99, 41)
        Me.BtnRefreshPage.TabIndex = 1207
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(460, 4)
        Me.TxtPagesCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(183, 42)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCurrentPage
        '
        Me.TxtCurrentPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCurrentPage.BackColor = System.Drawing.Color.White
        Me.TxtCurrentPage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtCurrentPage.Location = New System.Drawing.Point(963, 4)
        Me.TxtCurrentPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCurrentPage.Name = "TxtCurrentPage"
        Me.TxtCurrentPage.ReadOnly = True
        Me.TxtCurrentPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCurrentPage.Size = New System.Drawing.Size(183, 42)
        Me.TxtCurrentPage.TabIndex = 1205
        Me.TxtCurrentPage.TabStop = False
        Me.TxtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(111, 4)
        Me.NUDPageSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NUDPageSize.Name = "NUDPageSize"
        Me.NUDPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NUDPageSize.Size = New System.Drawing.Size(183, 42)
        Me.NUDPageSize.TabIndex = 20
        Me.NUDPageSize.TabStop = False
        Me.NUDPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(301, 2)
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
        Me.Panel4.Location = New System.Drawing.Point(650, 2)
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
        Me.Panel12.Location = New System.Drawing.Point(808, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(89, 45)
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
        Me.BtnLastPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLastPage.Size = New System.Drawing.Size(89, 45)
        Me.BtnLastPage.TabIndex = 19
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnNextPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(903, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(53, 45)
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
        Me.BtnNextPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNextPage.Size = New System.Drawing.Size(53, 45)
        Me.BtnNextPage.TabIndex = 18
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.BtnPreviousPage)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(1153, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(53, 45)
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
        Me.BtnPreviousPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPreviousPage.Size = New System.Drawing.Size(53, 45)
        Me.BtnPreviousPage.TabIndex = 17
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(1212, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(89, 45)
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
        Me.BtnFirstPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirstPage.Size = New System.Drawing.Size(89, 45)
        Me.BtnFirstPage.TabIndex = 16
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(4, 659)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 34)
        Me.Panel1.TabIndex = 31
        Me.Panel1.Tag = "Dark"
        '
        'DGVReport
        '
        Me.DGVReport.AllowUserToAddRows = False
        Me.DGVReport.AllowUserToDeleteRows = False
        Me.DGVReport.AllowUserToResizeRows = False
        Me.DGVReport.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DGVReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVReport.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVReport.ColumnHeadersHeight = 32
        Me.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column3, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVReport.EnableHeadersVisualStyles = False
        Me.DGVReport.Location = New System.Drawing.Point(20, 155)
        Me.DGVReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVReport.MultiSelect = False
        Me.DGVReport.Name = "DGVReport"
        Me.DGVReport.ReadOnly = True
        Me.DGVReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVReport.RowHeadersVisible = False
        Me.DGVReport.RowHeadersWidth = 51
        Me.DGVReport.RowTemplate.Height = 30
        Me.DGVReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVReport.Size = New System.Drawing.Size(1304, 436)
        Me.DGVReport.TabIndex = 30
        Me.DGVReport.Tag = "Dark-SelectionVisible"
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.FillWeight = 40.0!
        Me.Column2.HeaderText = "ت"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "رقم الفاتورة"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "تاريخ الفاتورة"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 167.9145!
        Me.Column3.HeaderText = "اسم الزبون"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "هاتف"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Controls.Add(Me.LblTitel)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(4, 4)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(1337, 34)
        Me.PnlMenu.TabIndex = 2
        Me.PnlMenu.Tag = "Dark"
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
        Me.BtnClose.TabIndex = 468
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(557, 0)
        Me.LblTitel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(223, 34)
        Me.LblTitel.TabIndex = 467
        Me.LblTitel.Text = "بحث عن فاتورة"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GrpSearch.Controls.Add(Me.TxtSearchName)
        Me.GrpSearch.Controls.Add(Me.Label9)
        Me.GrpSearch.Controls.Add(Me.BtnSearch)
        Me.GrpSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpSearch.Location = New System.Drawing.Point(20, 36)
        Me.GrpSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpSearch.Size = New System.Drawing.Size(1304, 101)
        Me.GrpSearch.TabIndex = 29
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "بحث"
        '
        'TxtSearchName
        '
        Me.TxtSearchName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSearchName.Location = New System.Drawing.Point(219, 37)
        Me.TxtSearchName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSearchName.MaxLength = 200
        Me.TxtSearchName.Name = "TxtSearchName"
        Me.TxtSearchName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSearchName.Size = New System.Drawing.Size(717, 42)
        Me.TxtSearchName.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(943, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(352, 34)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "اسم الزبون أو الهاتف/ رقم الفاتورة"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(19, 36)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(195, 44)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'FrmSearchInvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 705)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSearchInvo"
        Me.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dark"
        Me.Text = "بحث عن فاتورة"
        Me.Panel2.ResumeLayout(False)
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TLPPages As TableLayoutPanel
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents TxtPagesCount As TextBox
    Friend WithEvents TxtCurrentPage As TextBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVReport As DataGridView
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTitel As Label
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents TxtSearchName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
