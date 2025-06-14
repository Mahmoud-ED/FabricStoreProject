<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMangmentExpensesReport
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMangmentExpensesReport))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DGVExpensesReport = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLPPages = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefreshPage = New System.Windows.Forms.Button()
        Me.TxtPagesCount = New System.Windows.Forms.TextBox()
        Me.TxtCurrentPage = New System.Windows.Forms.TextBox()
        Me.NUDPageSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnLastPage = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BtnNextPage = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtnPreviousPage = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnFirstPage = New System.Windows.Forms.Button()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrintReport = New System.Windows.Forms.Button()
        Me.BtnRefreshReport = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrintAll = New System.Windows.Forms.Button()
        Me.GrpReport = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DTPToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPFromDate = New System.Windows.Forms.DateTimePicker()
        Me.ChkMonth = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.CmbMonthReport = New System.Windows.Forms.ComboBox()
        Me.CmbYearReport = New System.Windows.Forms.ComboBox()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.ChkUserReport = New System.Windows.Forms.CheckBox()
        Me.ChkReciptName = New System.Windows.Forms.CheckBox()
        Me.CmbUserReport = New System.Windows.Forms.ComboBox()
        Me.TxtReciptNameReport = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TxtSumReportAmont = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVExpensesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.GrpReport.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.DGVExpensesReport)
        Me.Panel2.Controls.Add(Me.TLPPages)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel9)
        Me.Panel2.Controls.Add(Me.GrpReport)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.TxtSumReportAmont)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1339, 684)
        Me.Panel2.TabIndex = 1139
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(25, 613)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(49, 34)
        Me.Label1.TabIndex = 31
        Me.Label1.Tag = "AutoC"
        Me.Label1.Text = "د.ل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(472, 612)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 41)
        Me.Label20.TabIndex = 1215
        Me.Label20.Text = "إجمالي المبلغ في جميع الصفحات"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGVExpensesReport
        '
        Me.DGVExpensesReport.AllowUserToAddRows = False
        Me.DGVExpensesReport.AllowUserToDeleteRows = False
        Me.DGVExpensesReport.AllowUserToResizeRows = False
        Me.DGVExpensesReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVExpensesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVExpensesReport.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVExpensesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVExpensesReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVExpensesReport.ColumnHeadersHeight = 32
        Me.DGVExpensesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVExpensesReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn26, Me.Column16, Me.Column1, Me.Column2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVExpensesReport.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVExpensesReport.EnableHeadersVisualStyles = False
        Me.DGVExpensesReport.GridColor = System.Drawing.Color.Gray
        Me.DGVExpensesReport.Location = New System.Drawing.Point(21, 274)
        Me.DGVExpensesReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVExpensesReport.MultiSelect = False
        Me.DGVExpensesReport.Name = "DGVExpensesReport"
        Me.DGVExpensesReport.ReadOnly = True
        Me.DGVExpensesReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVExpensesReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVExpensesReport.RowHeadersVisible = False
        Me.DGVExpensesReport.RowHeadersWidth = 51
        Me.DGVExpensesReport.RowTemplate.Height = 30
        Me.DGVExpensesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVExpensesReport.Size = New System.Drawing.Size(1299, 258)
        Me.DGVExpensesReport.TabIndex = 1225
        Me.DGVExpensesReport.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "المستخدم"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "تاريخ الصرف"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "المستلم"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "نوع المصروف"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn26.HeaderText = "القيمة"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "السنة-شهر"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "حالة"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "UserID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
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
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TLPPages.Controls.Add(Me.BtnRefreshPage, 9, 0)
        Me.TLPPages.Controls.Add(Me.TxtPagesCount, 6, 0)
        Me.TLPPages.Controls.Add(Me.TxtCurrentPage, 2, 0)
        Me.TLPPages.Controls.Add(Me.NUDPageSize, 8, 0)
        Me.TLPPages.Controls.Add(Me.Panel5, 7, 0)
        Me.TLPPages.Controls.Add(Me.Panel6, 5, 0)
        Me.TLPPages.Controls.Add(Me.Panel7, 4, 0)
        Me.TLPPages.Controls.Add(Me.Panel12, 3, 0)
        Me.TLPPages.Controls.Add(Me.Panel13, 1, 0)
        Me.TLPPages.Controls.Add(Me.Panel16, 0, 0)
        Me.TLPPages.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPPages.Location = New System.Drawing.Point(21, 540)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(1299, 49)
        Me.TLPPages.TabIndex = 1214
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
        Me.BtnRefreshPage.Size = New System.Drawing.Size(133, 41)
        Me.BtnRefreshPage.TabIndex = 1209
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(485, 4)
        Me.TxtPagesCount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(174, 42)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCurrentPage
        '
        Me.TxtCurrentPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCurrentPage.BackColor = System.Drawing.Color.White
        Me.TxtCurrentPage.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtCurrentPage.Location = New System.Drawing.Point(973, 4)
        Me.TxtCurrentPage.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCurrentPage.Name = "TxtCurrentPage"
        Me.TxtCurrentPage.ReadOnly = True
        Me.TxtCurrentPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCurrentPage.Size = New System.Drawing.Size(174, 42)
        Me.TxtCurrentPage.TabIndex = 1205
        Me.TxtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(145, 4)
        Me.NUDPageSize.Margin = New System.Windows.Forms.Padding(4)
        Me.NUDPageSize.Name = "NUDPageSize"
        Me.NUDPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NUDPageSize.Size = New System.Drawing.Size(174, 42)
        Me.NUDPageSize.TabIndex = 19
        Me.NUDPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(326, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(152, 45)
        Me.Panel5.TabIndex = 1205
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(666, 2)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(152, 45)
        Me.Panel6.TabIndex = 1205
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
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnLastPage)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(824, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(85, 45)
        Me.Panel7.TabIndex = 1205
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
        Me.BtnLastPage.Size = New System.Drawing.Size(85, 45)
        Me.BtnLastPage.TabIndex = 18
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BtnNextPage)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(915, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(51, 45)
        Me.Panel12.TabIndex = 1205
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
        Me.BtnNextPage.Size = New System.Drawing.Size(51, 45)
        Me.BtnNextPage.TabIndex = 17
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnPreviousPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(1154, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(51, 45)
        Me.Panel13.TabIndex = 1205
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
        Me.BtnPreviousPage.Size = New System.Drawing.Size(51, 45)
        Me.BtnPreviousPage.TabIndex = 16
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(1211, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(85, 45)
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
        Me.BtnFirstPage.Size = New System.Drawing.Size(85, 45)
        Me.BtnFirstPage.TabIndex = 15
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 7
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.BtnPrintReport, 4, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.BtnRefreshReport, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.BtnSearch, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.BtnPrintAll, 6, 0)
        Me.TableLayoutPanel9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(21, 208)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1299, 49)
        Me.TableLayoutPanel9.TabIndex = 1215
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrintReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnPrintReport.FlatAppearance.BorderSize = 0
        Me.BtnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintReport.ForeColor = System.Drawing.Color.White
        Me.BtnPrintReport.Image = CType(resources.GetObject("BtnPrintReport.Image"), System.Drawing.Image)
        Me.BtnPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintReport.Location = New System.Drawing.Point(331, 2)
        Me.BtnPrintReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(309, 45)
        Me.BtnPrintReport.TabIndex = 26
        Me.BtnPrintReport.Tag = "Dark"
        Me.BtnPrintReport.Text = "طباعة صفحة واحدة"
        Me.BtnPrintReport.UseVisualStyleBackColor = False
        '
        'BtnRefreshReport
        '
        Me.BtnRefreshReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefreshReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefreshReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnRefreshReport.FlatAppearance.BorderSize = 0
        Me.BtnRefreshReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshReport.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshReport.Image = CType(resources.GetObject("BtnRefreshReport.Image"), System.Drawing.Image)
        Me.BtnRefreshReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefreshReport.Location = New System.Drawing.Point(659, 2)
        Me.BtnRefreshReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRefreshReport.Name = "BtnRefreshReport"
        Me.BtnRefreshReport.Size = New System.Drawing.Size(309, 45)
        Me.BtnRefreshReport.TabIndex = 1168
        Me.BtnRefreshReport.Tag = "Dark"
        Me.BtnRefreshReport.Text = "تحديث"
        Me.BtnRefreshReport.UseVisualStyleBackColor = False
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
        Me.BtnSearch.Location = New System.Drawing.Point(987, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 3, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(312, 45)
        Me.BtnSearch.TabIndex = 26
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
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
        Me.BtnPrintAll.Size = New System.Drawing.Size(315, 45)
        Me.BtnPrintAll.TabIndex = 1172
        Me.BtnPrintAll.Tag = "Dark"
        Me.BtnPrintAll.Text = "طباعة الكل"
        Me.BtnPrintAll.UseVisualStyleBackColor = False
        '
        'GrpReport
        '
        Me.GrpReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpReport.Controls.Add(Me.TableLayoutPanel4)
        Me.GrpReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReport.Location = New System.Drawing.Point(21, 2)
        Me.GrpReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpReport.Name = "GrpReport"
        Me.GrpReport.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpReport.Size = New System.Drawing.Size(1299, 190)
        Me.GrpReport.TabIndex = 1214
        Me.GrpReport.TabStop = False
        Me.GrpReport.Text = "بحث حسب"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkMonth, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkDate, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkUserReport, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkReciptName, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.CmbUserReport, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtReciptNameReport, 3, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(20, 34)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1247, 143)
        Me.TableLayoutPanel4.TabIndex = 1226
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DTPToDate, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.DTPFromDate, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 71)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(424, 72)
        Me.TableLayoutPanel6.TabIndex = 1211
        '
        'DTPToDate
        '
        Me.DTPToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPToDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTPToDate.CustomFormat = ""
        Me.DTPToDate.Enabled = False
        Me.DTPToDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPToDate.Location = New System.Drawing.Point(0, 15)
        Me.DTPToDate.Margin = New System.Windows.Forms.Padding(0)
        Me.DTPToDate.Name = "DTPToDate"
        Me.DTPToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPToDate.RightToLeftLayout = True
        Me.DTPToDate.Size = New System.Drawing.Size(184, 42)
        Me.DTPToDate.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 72)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "إلى"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFromDate
        '
        Me.DTPFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTPFromDate.CustomFormat = ""
        Me.DTPFromDate.Enabled = False
        Me.DTPFromDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFromDate.Location = New System.Drawing.Point(239, 15)
        Me.DTPFromDate.Margin = New System.Windows.Forms.Padding(0)
        Me.DTPFromDate.Name = "DTPFromDate"
        Me.DTPFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPFromDate.RightToLeftLayout = True
        Me.DTPFromDate.Size = New System.Drawing.Size(185, 42)
        Me.DTPFromDate.TabIndex = 11
        '
        'ChkMonth
        '
        Me.ChkMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkMonth.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMonth.Location = New System.Drawing.Point(427, 2)
        Me.ChkMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkMonth.Name = "ChkMonth"
        Me.ChkMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkMonth.Size = New System.Drawing.Size(202, 67)
        Me.ChkMonth.TabIndex = 1
        Me.ChkMonth.Text = "الشهر - السنة"
        Me.ChkMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkMonth.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.CmbMonthReport, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CmbYearReport, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(424, 71)
        Me.TableLayoutPanel5.TabIndex = 37
        '
        'CmbMonthReport
        '
        Me.CmbMonthReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMonthReport.BackColor = System.Drawing.Color.White
        Me.CmbMonthReport.DropDownHeight = 160
        Me.CmbMonthReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonthReport.Enabled = False
        Me.CmbMonthReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMonthReport.FormattingEnabled = True
        Me.CmbMonthReport.IntegralHeight = False
        Me.CmbMonthReport.Location = New System.Drawing.Point(239, 14)
        Me.CmbMonthReport.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbMonthReport.MaxLength = 4
        Me.CmbMonthReport.Name = "CmbMonthReport"
        Me.CmbMonthReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbMonthReport.Size = New System.Drawing.Size(185, 42)
        Me.CmbMonthReport.TabIndex = 1160
        '
        'CmbYearReport
        '
        Me.CmbYearReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbYearReport.BackColor = System.Drawing.Color.White
        Me.CmbYearReport.DropDownHeight = 160
        Me.CmbYearReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYearReport.Enabled = False
        Me.CmbYearReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYearReport.FormattingEnabled = True
        Me.CmbYearReport.IntegralHeight = False
        Me.CmbYearReport.Location = New System.Drawing.Point(0, 14)
        Me.CmbYearReport.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbYearReport.MaxLength = 4
        Me.CmbYearReport.Name = "CmbYearReport"
        Me.CmbYearReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbYearReport.Size = New System.Drawing.Size(184, 42)
        Me.CmbYearReport.TabIndex = 1159
        '
        'ChkDate
        '
        Me.ChkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDate.Location = New System.Drawing.Point(427, 73)
        Me.ChkDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkDate.Size = New System.Drawing.Size(202, 68)
        Me.ChkDate.TabIndex = 1209
        Me.ChkDate.Text = "تاريخ الصرف :  من"
        Me.ChkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'ChkUserReport
        '
        Me.ChkUserReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkUserReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkUserReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUserReport.Location = New System.Drawing.Point(1082, 2)
        Me.ChkUserReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkUserReport.Name = "ChkUserReport"
        Me.ChkUserReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUserReport.Size = New System.Drawing.Size(162, 67)
        Me.ChkUserReport.TabIndex = 3
        Me.ChkUserReport.Text = "المستخدم"
        Me.ChkUserReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkUserReport.UseVisualStyleBackColor = True
        '
        'ChkReciptName
        '
        Me.ChkReciptName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkReciptName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkReciptName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkReciptName.Location = New System.Drawing.Point(1082, 73)
        Me.ChkReciptName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkReciptName.Name = "ChkReciptName"
        Me.ChkReciptName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkReciptName.Size = New System.Drawing.Size(162, 68)
        Me.ChkReciptName.TabIndex = 5
        Me.ChkReciptName.Text = "المستلم"
        Me.ChkReciptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkReciptName.UseVisualStyleBackColor = True
        '
        'CmbUserReport
        '
        Me.CmbUserReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUserReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUserReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserReport.DropDownHeight = 160
        Me.CmbUserReport.Enabled = False
        Me.CmbUserReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUserReport.FormattingEnabled = True
        Me.CmbUserReport.IntegralHeight = False
        Me.CmbUserReport.Location = New System.Drawing.Point(658, 14)
        Me.CmbUserReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbUserReport.Name = "CmbUserReport"
        Me.CmbUserReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbUserReport.Size = New System.Drawing.Size(418, 42)
        Me.CmbUserReport.TabIndex = 1212
        '
        'TxtReciptNameReport
        '
        Me.TxtReciptNameReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtReciptNameReport.Enabled = False
        Me.TxtReciptNameReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReciptNameReport.Location = New System.Drawing.Point(658, 86)
        Me.TxtReciptNameReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtReciptNameReport.MaxLength = 200
        Me.TxtReciptNameReport.Name = "TxtReciptNameReport"
        Me.TxtReciptNameReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtReciptNameReport.Size = New System.Drawing.Size(418, 42)
        Me.TxtReciptNameReport.TabIndex = 31
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 672)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1339, 12)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1140
        '
        'TxtSumReportAmont
        '
        Me.TxtSumReportAmont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSumReportAmont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSumReportAmont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSumReportAmont.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtSumReportAmont.Location = New System.Drawing.Point(21, 609)
        Me.TxtSumReportAmont.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSumReportAmont.Name = "TxtSumReportAmont"
        Me.TxtSumReportAmont.Size = New System.Drawing.Size(449, 43)
        Me.TxtSumReportAmont.TabIndex = 1237
        Me.TxtSumReportAmont.Tag = "AutoC"
        Me.TxtSumReportAmont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMangmentExpensesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 684)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMangmentExpensesReport"
        Me.Text = "تقارير المصروفات"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVExpensesReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.GrpReport.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents BtnRefreshReport As Button
    Friend WithEvents BtnPrintReport As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents GrpReport As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DGVExpensesReport As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ChkUserReport As CheckBox
    Friend WithEvents ChkMonth As CheckBox
    Friend WithEvents TxtReciptNameReport As TextBox
    Friend WithEvents ChkReciptName As CheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents CmbMonthReport As ComboBox
    Friend WithEvents CmbYearReport As ComboBox
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DTPToDate As DateTimePicker
    Friend WithEvents DTPFromDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbUserReport As ComboBox
    Friend WithEvents TLPPages As TableLayoutPanel
    Friend WithEvents TxtPagesCount As TextBox
    Friend WithEvents TxtCurrentPage As TextBox
    Friend WithEvents NUDPageSize As NumericUpDown
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BtnLastPage As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnNextPage As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnPreviousPage As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnFirstPage As Button
    Friend WithEvents BtnPrintAll As Button
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TxtSumReportAmont As Label
End Class
