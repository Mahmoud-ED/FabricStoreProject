<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTailorReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTailorReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtCurrentPage = New System.Windows.Forms.TextBox()
        Me.NUDPageSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.DGVReport = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrpReport = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.ChkAddress = New System.Windows.Forms.CheckBox()
        Me.TxtPhoneReport = New System.Windows.Forms.TextBox()
        Me.ChkNameReport = New System.Windows.Forms.CheckBox()
        Me.ChkPhone = New System.Windows.Forms.CheckBox()
        Me.TxtNameReport = New System.Windows.Forms.TextBox()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.BtnLastPage = New System.Windows.Forms.Button()
        Me.BtnNextPage = New System.Windows.Forms.Button()
        Me.BtnPreviousPage = New System.Windows.Forms.Button()
        Me.BtnFirstPage = New System.Windows.Forms.Button()
        Me.BtnPrintAll = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.GrpReport.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.ChkAll)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel12)
        Me.Panel1.Controls.Add(Me.GrpReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 583)
        Me.Panel1.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 573)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(992, 10)
        Me.ProgressBar1.TabIndex = 1228
        '
        'ChkAll
        '
        Me.ChkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAll.Location = New System.Drawing.Point(865, 225)
        Me.ChkAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAll.Size = New System.Drawing.Size(95, 32)
        Me.ChkAll.TabIndex = 1226
        Me.ChkAll.Text = "عرض الكل"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.TLPPages)
        Me.GroupBox7.Controls.Add(Me.DGVReport)
        Me.GroupBox7.Location = New System.Drawing.Point(14, 232)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(963, 328)
        Me.GroupBox7.TabIndex = 1227
        Me.GroupBox7.TabStop = False
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
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
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
        Me.TLPPages.Location = New System.Drawing.Point(10, 276)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(942, 40)
        Me.TLPPages.TabIndex = 1222
        Me.TLPPages.Tag = "Dark"
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(363, 3)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(122, 35)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCurrentPage
        '
        Me.TxtCurrentPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCurrentPage.BackColor = System.Drawing.Color.White
        Me.TxtCurrentPage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtCurrentPage.Location = New System.Drawing.Point(713, 3)
        Me.TxtCurrentPage.Name = "TxtCurrentPage"
        Me.TxtCurrentPage.ReadOnly = True
        Me.TxtCurrentPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCurrentPage.Size = New System.Drawing.Size(122, 35)
        Me.TxtCurrentPage.TabIndex = 1205
        Me.TxtCurrentPage.TabStop = False
        Me.TxtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(117, 3)
        Me.NUDPageSize.Name = "NUDPageSize"
        Me.NUDPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NUDPageSize.Size = New System.Drawing.Size(122, 35)
        Me.NUDPageSize.TabIndex = 20
        Me.NUDPageSize.TabStop = False
        Me.NUDPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(244, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(114, 36)
        Me.Panel3.TabIndex = 1205
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 28)
        Me.Label10.TabIndex = 1201
        Me.Label10.Text = "حجم الصفحة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(490, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(114, 36)
        Me.Panel4.TabIndex = 1205
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "عدد الصفحات"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BtnLastPage)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(608, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(60, 36)
        Me.Panel12.TabIndex = 1205
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnNextPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(672, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(36, 36)
        Me.Panel13.TabIndex = 1205
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.BtnPreviousPage)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(840, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(36, 36)
        Me.Panel14.TabIndex = 1205
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(880, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(60, 36)
        Me.Panel16.TabIndex = 1205
        '
        'DGVReport
        '
        Me.DGVReport.AllowUserToAddRows = False
        Me.DGVReport.AllowUserToResizeRows = False
        Me.DGVReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVReport.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVReport.ColumnHeadersHeight = 32
        Me.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column10, Me.Column11, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVReport.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVReport.GridColor = System.Drawing.Color.Gray
        Me.DGVReport.Location = New System.Drawing.Point(10, 29)
        Me.DGVReport.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVReport.MultiSelect = False
        Me.DGVReport.Name = "DGVReport"
        Me.DGVReport.ReadOnly = True
        Me.DGVReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVReport.RowHeadersVisible = False
        Me.DGVReport.RowHeadersWidth = 51
        Me.DGVReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVReport.RowTemplate.Height = 30
        Me.DGVReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVReport.Size = New System.Drawing.Size(942, 244)
        Me.DGVReport.TabIndex = 1221
        Me.DGVReport.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "ت"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "اسم الخياط"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "رقم الهاتف"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "العنوان"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 5
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.BtnPrintAll, 4, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.BtnSearch, 0, 0)
        Me.TableLayoutPanel12.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(14, 183)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(963, 41)
        Me.TableLayoutPanel12.TabIndex = 1224
        '
        'GrpReport
        '
        Me.GrpReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpReport.BackColor = System.Drawing.SystemColors.Control
        Me.GrpReport.Controls.Add(Me.TableLayoutPanel1)
        Me.GrpReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReport.Location = New System.Drawing.Point(14, 5)
        Me.GrpReport.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpReport.Name = "GrpReport"
        Me.GrpReport.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpReport.Size = New System.Drawing.Size(963, 166)
        Me.GrpReport.TabIndex = 1223
        Me.GrpReport.TabStop = False
        Me.GrpReport.Text = "بحث حسب"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAddress, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkAddress, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPhoneReport, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkNameReport, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkPhone, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNameReport, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(942, 126)
        Me.TableLayoutPanel1.TabIndex = 1214
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAddress.Enabled = False
        Me.TxtAddress.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(2, 44)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAddress.MaxLength = 200
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddress.Size = New System.Drawing.Size(772, 35)
        Me.TxtAddress.TabIndex = 1238
        Me.TxtAddress.Tag = ""
        '
        'ChkAddress
        '
        Me.ChkAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkAddress.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAddress.Location = New System.Drawing.Point(778, 44)
        Me.ChkAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAddress.Name = "ChkAddress"
        Me.ChkAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAddress.Size = New System.Drawing.Size(162, 38)
        Me.ChkAddress.TabIndex = 1225
        Me.ChkAddress.Text = "العنوان"
        Me.ChkAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkAddress.UseVisualStyleBackColor = True
        '
        'TxtPhoneReport
        '
        Me.TxtPhoneReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPhoneReport.Enabled = False
        Me.TxtPhoneReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneReport.Location = New System.Drawing.Point(2, 86)
        Me.TxtPhoneReport.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhoneReport.MaxLength = 10
        Me.TxtPhoneReport.Name = "TxtPhoneReport"
        Me.TxtPhoneReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPhoneReport.Size = New System.Drawing.Size(772, 35)
        Me.TxtPhoneReport.TabIndex = 1224
        '
        'ChkNameReport
        '
        Me.ChkNameReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkNameReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkNameReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNameReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkNameReport.Location = New System.Drawing.Point(778, 2)
        Me.ChkNameReport.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkNameReport.Name = "ChkNameReport"
        Me.ChkNameReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkNameReport.Size = New System.Drawing.Size(162, 38)
        Me.ChkNameReport.TabIndex = 1041
        Me.ChkNameReport.Text = "اسـم الخياط"
        Me.ChkNameReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkNameReport.UseVisualStyleBackColor = True
        '
        'ChkPhone
        '
        Me.ChkPhone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkPhone.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkPhone.Location = New System.Drawing.Point(778, 86)
        Me.ChkPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkPhone.Name = "ChkPhone"
        Me.ChkPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPhone.Size = New System.Drawing.Size(162, 38)
        Me.ChkPhone.TabIndex = 1051
        Me.ChkPhone.Text = "رقـم الهـاتف"
        Me.ChkPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPhone.UseVisualStyleBackColor = True
        '
        'TxtNameReport
        '
        Me.TxtNameReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNameReport.Enabled = False
        Me.TxtNameReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameReport.Location = New System.Drawing.Point(2, 2)
        Me.TxtNameReport.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNameReport.MaxLength = 200
        Me.TxtNameReport.Name = "TxtNameReport"
        Me.TxtNameReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNameReport.Size = New System.Drawing.Size(772, 35)
        Me.TxtNameReport.TabIndex = 1055
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
        Me.BtnRefreshPage.Location = New System.Drawing.Point(3, 3)
        Me.BtnRefreshPage.Name = "BtnRefreshPage"
        Me.BtnRefreshPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshPage.Size = New System.Drawing.Size(108, 34)
        Me.BtnRefreshPage.TabIndex = 1207
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
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
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLastPage.Size = New System.Drawing.Size(60, 36)
        Me.BtnLastPage.TabIndex = 19
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
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
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNextPage.Size = New System.Drawing.Size(36, 36)
        Me.BtnNextPage.TabIndex = 18
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
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
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPreviousPage.Size = New System.Drawing.Size(36, 36)
        Me.BtnPreviousPage.TabIndex = 17
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
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
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirstPage.Size = New System.Drawing.Size(60, 36)
        Me.BtnFirstPage.TabIndex = 16
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'BtnPrintAll
        '
        Me.BtnPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrintAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrintAll.FlatAppearance.BorderSize = 0
        Me.BtnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintAll.ForeColor = System.Drawing.Color.White
        Me.BtnPrintAll.Image = CType(resources.GetObject("BtnPrintAll.Image"), System.Drawing.Image)
        Me.BtnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintAll.Location = New System.Drawing.Point(0, 2)
        Me.BtnPrintAll.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnPrintAll.Name = "BtnPrintAll"
        Me.BtnPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintAll.Size = New System.Drawing.Size(315, 37)
        Me.BtnPrintAll.TabIndex = 1171
        Me.BtnPrintAll.Tag = "Dark"
        Me.BtnPrintAll.Text = "طباعة"
        Me.BtnPrintAll.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.Location = New System.Drawing.Point(325, 2)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdate.Size = New System.Drawing.Size(314, 37)
        Me.BtnUpdate.TabIndex = 1123
        Me.BtnUpdate.Tag = "Dark"
        Me.BtnUpdate.Text = "تحديث"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(649, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(314, 37)
        Me.BtnSearch.TabIndex = 1141
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'FrmTailorReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 583)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTailorReport"
        Me.Text = "تقـاريـر الخياطين"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
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
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.GrpReport.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNextPage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
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
    Friend WithEvents Panel14 As Panel
    Friend WithEvents BtnPreviousPage As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnFirstPage As Button
    Friend WithEvents DGVReport As DataGridView
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents BtnPrintAll As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents GrpReport As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents ChkAddress As CheckBox
    Friend WithEvents TxtPhoneReport As TextBox
    Friend WithEvents ChkNameReport As CheckBox
    Friend WithEvents ChkPhone As CheckBox
    Friend WithEvents TxtNameReport As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
