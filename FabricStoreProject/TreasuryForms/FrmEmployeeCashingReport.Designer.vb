﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeCashingReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployeeCashingReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ChkNum = New System.Windows.Forms.CheckBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.ChkEmployee = New System.Windows.Forms.CheckBox()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.ChkBank = New System.Windows.Forms.CheckBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.ChkCheck = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.ChkPayment = New System.Windows.Forms.CheckBox()
        Me.CmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.CmbBank = New System.Windows.Forms.ComboBox()
        Me.TxtCheck = New System.Windows.Forms.TextBox()
        Me.CmbEmployee = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadCashing = New System.Windows.Forms.RadioButton()
        Me.RadReceipt = New System.Windows.Forms.RadioButton()
        Me.TLPBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrintAll = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.DGVCashing = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TLPPages.SuspendLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPSearch.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TLPBottom.SuspendLayout()
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TLPPages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
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
        Me.TLPPages.Location = New System.Drawing.Point(17, 479)
        Me.TLPPages.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPPages.Name = "TLPPages"
        Me.TLPPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPPages.RowCount = 1
        Me.TLPPages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPages.Size = New System.Drawing.Size(902, 40)
        Me.TLPPages.TabIndex = 1242
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
        Me.BtnRefreshPage.Location = New System.Drawing.Point(3, 3)
        Me.BtnRefreshPage.Name = "BtnRefreshPage"
        Me.BtnRefreshPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshPage.Size = New System.Drawing.Size(68, 34)
        Me.BtnRefreshPage.TabIndex = 1207
        Me.BtnRefreshPage.Tag = "Dark"
        Me.BtnRefreshPage.UseVisualStyleBackColor = False
        '
        'TxtPagesCount
        '
        Me.TxtPagesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPagesCount.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPagesCount.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPagesCount.Location = New System.Drawing.Point(323, 3)
        Me.TxtPagesCount.Name = "TxtPagesCount"
        Me.TxtPagesCount.ReadOnly = True
        Me.TxtPagesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagesCount.Size = New System.Drawing.Size(122, 35)
        Me.TxtPagesCount.TabIndex = 1205
        Me.TxtPagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPageNum
        '
        Me.TxtPageNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPageNum.BackColor = System.Drawing.Color.White
        Me.TxtPageNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPageNum.Location = New System.Drawing.Point(673, 3)
        Me.TxtPageNum.Name = "TxtPageNum"
        Me.TxtPageNum.ReadOnly = True
        Me.TxtPageNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPageNum.Size = New System.Drawing.Size(122, 35)
        Me.TxtPageNum.TabIndex = 1205
        Me.TxtPageNum.TabStop = False
        Me.TxtPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUDPageSize
        '
        Me.NUDPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUDPageSize.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.NUDPageSize.Location = New System.Drawing.Point(77, 3)
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
        Me.Panel3.Location = New System.Drawing.Point(204, 2)
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
        Me.Panel4.Location = New System.Drawing.Point(450, 2)
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
        Me.Panel12.Location = New System.Drawing.Point(568, 2)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(60, 36)
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
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLastPage.Size = New System.Drawing.Size(60, 36)
        Me.BtnLastPage.TabIndex = 19
        Me.BtnLastPage.Tag = "Dark"
        Me.BtnLastPage.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnNextPage)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(632, 2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(36, 36)
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
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNextPage.Size = New System.Drawing.Size(36, 36)
        Me.BtnNextPage.TabIndex = 18
        Me.BtnNextPage.Tag = "Dark"
        Me.BtnNextPage.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.BtnPreviousPage)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(800, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(36, 36)
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
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPreviousPage.Size = New System.Drawing.Size(36, 36)
        Me.BtnPreviousPage.TabIndex = 17
        Me.BtnPreviousPage.Tag = "Dark"
        Me.BtnPreviousPage.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnFirstPage)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(840, 2)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(60, 36)
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
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirstPage.Size = New System.Drawing.Size(60, 36)
        Me.BtnFirstPage.TabIndex = 16
        Me.BtnFirstPage.Tag = "Dark"
        Me.BtnFirstPage.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(902, 219)
        Me.GroupBox2.TabIndex = 1239
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بحث حسب"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TLPSearch, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.06417!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.93583!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 187)
        Me.TableLayoutPanel1.TabIndex = 1243
        '
        'TLPSearch
        '
        Me.TLPSearch.ColumnCount = 5
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPSearch.Controls.Add(Me.TxtNum, 1, 0)
        Me.TLPSearch.Controls.Add(Me.Panel9, 0, 0)
        Me.TLPSearch.Controls.Add(Me.Panel22, 0, 1)
        Me.TLPSearch.Controls.Add(Me.Panel24, 3, 1)
        Me.TLPSearch.Controls.Add(Me.Panel11, 3, 2)
        Me.TLPSearch.Controls.Add(Me.Panel7, 0, 2)
        Me.TLPSearch.Controls.Add(Me.TableLayoutPanel6, 1, 2)
        Me.TLPSearch.Controls.Add(Me.Panel23, 3, 0)
        Me.TLPSearch.Controls.Add(Me.CmbPaymentType, 4, 0)
        Me.TLPSearch.Controls.Add(Me.CmbBank, 4, 1)
        Me.TLPSearch.Controls.Add(Me.TxtCheck, 4, 2)
        Me.TLPSearch.Controls.Add(Me.CmbEmployee, 1, 1)
        Me.TLPSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPSearch.Location = New System.Drawing.Point(2, 47)
        Me.TLPSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPSearch.Name = "TLPSearch"
        Me.TLPSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPSearch.RowCount = 3
        Me.TLPSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearch.Size = New System.Drawing.Size(864, 138)
        Me.TLPSearch.TabIndex = 1230
        '
        'TxtNum
        '
        Me.TxtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNum.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNum.Location = New System.Drawing.Point(439, 5)
        Me.TxtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNum.MaxLength = 6
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNum.Size = New System.Drawing.Size(258, 35)
        Me.TxtNum.TabIndex = 56
        Me.TxtNum.Tag = ""
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.ChkNum)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(701, 2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(161, 42)
        Me.Panel9.TabIndex = 0
        '
        'ChkNum
        '
        Me.ChkNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkNum.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkNum.Location = New System.Drawing.Point(0, 1)
        Me.ChkNum.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkNum.Name = "ChkNum"
        Me.ChkNum.Size = New System.Drawing.Size(161, 41)
        Me.ChkNum.TabIndex = 0
        Me.ChkNum.Text = "رقم الإيصال"
        Me.ChkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkNum.UseVisualStyleBackColor = True
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.ChkEmployee)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(701, 48)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(161, 42)
        Me.Panel22.TabIndex = 45
        '
        'ChkEmployee
        '
        Me.ChkEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkEmployee.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkEmployee.Location = New System.Drawing.Point(0, 1)
        Me.ChkEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkEmployee.Name = "ChkEmployee"
        Me.ChkEmployee.Size = New System.Drawing.Size(161, 38)
        Me.ChkEmployee.TabIndex = 1
        Me.ChkEmployee.Text = "الموظــف"
        Me.ChkEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkEmployee.UseVisualStyleBackColor = True
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.ChkBank)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel24.Location = New System.Drawing.Point(264, 48)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(161, 42)
        Me.Panel24.TabIndex = 45
        '
        'ChkBank
        '
        Me.ChkBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkBank.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkBank.Location = New System.Drawing.Point(0, 1)
        Me.ChkBank.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkBank.Name = "ChkBank"
        Me.ChkBank.Size = New System.Drawing.Size(161, 41)
        Me.ChkBank.TabIndex = 1
        Me.ChkBank.Text = "المصرف"
        Me.ChkBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkBank.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.ChkCheck)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(264, 94)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(161, 42)
        Me.Panel11.TabIndex = 49
        '
        'ChkCheck
        '
        Me.ChkCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkCheck.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkCheck.Location = New System.Drawing.Point(0, -1)
        Me.ChkCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkCheck.Name = "ChkCheck"
        Me.ChkCheck.Size = New System.Drawing.Size(161, 44)
        Me.ChkCheck.TabIndex = 1
        Me.ChkCheck.Text = "الصك"
        Me.ChkCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkCheck.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ChkDate)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(701, 94)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(161, 42)
        Me.Panel7.TabIndex = 51
        '
        'ChkDate
        '
        Me.ChkDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkDate.Location = New System.Drawing.Point(0, 1)
        Me.ChkDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(161, 41)
        Me.ChkDate.TabIndex = 2
        Me.ChkDate.Text = "تاريخ الإيصال  :  من"
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DTPFrom, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.DTPTo, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(437, 94)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(262, 42)
        Me.TableLayoutPanel6.TabIndex = 1227
        '
        'DTPFrom
        '
        Me.DTPFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFrom.CustomFormat = ""
        Me.DTPFrom.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(155, 3)
        Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPFrom.RightToLeftLayout = True
        Me.DTPFrom.Size = New System.Drawing.Size(105, 35)
        Me.DTPFrom.TabIndex = 42
        Me.DTPFrom.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'DTPTo
        '
        Me.DTPTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPTo.CustomFormat = ""
        Me.DTPTo.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(2, 3)
        Me.DTPTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPTo.RightToLeftLayout = True
        Me.DTPTo.Size = New System.Drawing.Size(106, 35)
        Me.DTPTo.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "إلى"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.ChkPayment)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(264, 2)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(161, 42)
        Me.Panel23.TabIndex = 45
        '
        'ChkPayment
        '
        Me.ChkPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkPayment.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkPayment.Location = New System.Drawing.Point(0, 1)
        Me.ChkPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkPayment.Name = "ChkPayment"
        Me.ChkPayment.Size = New System.Drawing.Size(161, 41)
        Me.ChkPayment.TabIndex = 1
        Me.ChkPayment.Text = "طريقة الدفع"
        Me.ChkPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPayment.UseVisualStyleBackColor = True
        '
        'CmbPaymentType
        '
        Me.CmbPaymentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPaymentType.Enabled = False
        Me.CmbPaymentType.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbPaymentType.FormattingEnabled = True
        Me.CmbPaymentType.Location = New System.Drawing.Point(2, 5)
        Me.CmbPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbPaymentType.Name = "CmbPaymentType"
        Me.CmbPaymentType.Size = New System.Drawing.Size(258, 35)
        Me.CmbPaymentType.TabIndex = 49
        '
        'CmbBank
        '
        Me.CmbBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBank.Enabled = False
        Me.CmbBank.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbBank.FormattingEnabled = True
        Me.CmbBank.Location = New System.Drawing.Point(2, 51)
        Me.CmbBank.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbBank.Name = "CmbBank"
        Me.CmbBank.Size = New System.Drawing.Size(258, 35)
        Me.CmbBank.TabIndex = 50
        '
        'TxtCheck
        '
        Me.TxtCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCheck.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCheck.Enabled = False
        Me.TxtCheck.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtCheck.Location = New System.Drawing.Point(2, 97)
        Me.TxtCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCheck.MaxLength = 20
        Me.TxtCheck.Name = "TxtCheck"
        Me.TxtCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCheck.Size = New System.Drawing.Size(258, 35)
        Me.TxtCheck.TabIndex = 45
        Me.TxtCheck.Tag = ""
        '
        'CmbEmployee
        '
        Me.CmbEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmployee.Enabled = False
        Me.CmbEmployee.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbEmployee.FormattingEnabled = True
        Me.CmbEmployee.Location = New System.Drawing.Point(439, 51)
        Me.CmbEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbEmployee.Name = "CmbEmployee"
        Me.CmbEmployee.Size = New System.Drawing.Size(258, 35)
        Me.CmbEmployee.TabIndex = 1228
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadCashing)
        Me.Panel1.Controls.Add(Me.RadReceipt)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 43)
        Me.Panel1.TabIndex = 1231
        '
        'RadCashing
        '
        Me.RadCashing.AutoSize = True
        Me.RadCashing.Location = New System.Drawing.Point(510, 4)
        Me.RadCashing.Name = "RadCashing"
        Me.RadCashing.Size = New System.Drawing.Size(134, 35)
        Me.RadCashing.TabIndex = 1
        Me.RadCashing.TabStop = True
        Me.RadCashing.Text = "إيصالات الصرف"
        Me.RadCashing.UseVisualStyleBackColor = True
        '
        'RadReceipt
        '
        Me.RadReceipt.AutoSize = True
        Me.RadReceipt.Location = New System.Drawing.Point(710, 4)
        Me.RadReceipt.Name = "RadReceipt"
        Me.RadReceipt.Size = New System.Drawing.Size(134, 35)
        Me.RadReceipt.TabIndex = 0
        Me.RadReceipt.TabStop = True
        Me.RadReceipt.Text = "إيصالات القبض"
        Me.RadReceipt.UseVisualStyleBackColor = True
        '
        'TLPBottom
        '
        Me.TLPBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPBottom.ColumnCount = 7
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLPBottom.Controls.Add(Me.BtnPrint, 2, 0)
        Me.TLPBottom.Controls.Add(Me.BtnSearch, 6, 0)
        Me.TLPBottom.Controls.Add(Me.BtnPrintAll, 0, 0)
        Me.TLPBottom.Controls.Add(Me.BtnNew, 4, 0)
        Me.TLPBottom.Location = New System.Drawing.Point(17, 242)
        Me.TLPBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBottom.Name = "TLPBottom"
        Me.TLPBottom.RowCount = 1
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPBottom.Size = New System.Drawing.Size(902, 40)
        Me.TLPBottom.TabIndex = 1240
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(230, 2)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(214, 36)
        Me.BtnPrint.TabIndex = 34
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة صفحة واحدة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(684, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(218, 36)
        Me.BtnSearch.TabIndex = 29
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnPrintAll
        '
        Me.BtnPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrintAll.FlatAppearance.BorderSize = 0
        Me.BtnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnPrintAll.ForeColor = System.Drawing.Color.White
        Me.BtnPrintAll.Image = CType(resources.GetObject("BtnPrintAll.Image"), System.Drawing.Image)
        Me.BtnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintAll.Location = New System.Drawing.Point(0, 2)
        Me.BtnPrintAll.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnPrintAll.Name = "BtnPrintAll"
        Me.BtnPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrintAll.Size = New System.Drawing.Size(218, 36)
        Me.BtnPrintAll.TabIndex = 32
        Me.BtnPrintAll.Tag = "Dark"
        Me.BtnPrintAll.Text = "طباعة الكل"
        Me.BtnPrintAll.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(456, 2)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.Size = New System.Drawing.Size(218, 36)
        Me.BtnNew.TabIndex = 31
        Me.BtnNew.Tag = "Dark"
        Me.BtnNew.Text = "تحديث"
        Me.BtnNew.UseVisualStyleBackColor = False
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
        Me.DGVCashing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column11, Me.Column12, Me.Column10, Me.Column3, Me.DataGridViewTextBoxColumn4, Me.ColShow})
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
        Me.DGVCashing.Location = New System.Drawing.Point(17, 294)
        Me.DGVCashing.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCashing.MultiSelect = False
        Me.DGVCashing.Name = "DGVCashing"
        Me.DGVCashing.ReadOnly = True
        Me.DGVCashing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCashing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCashing.RowHeadersVisible = False
        Me.DGVCashing.RowHeadersWidth = 51
        Me.DGVCashing.RowTemplate.Height = 30
        Me.DGVCashing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCashing.Size = New System.Drawing.Size(902, 182)
        Me.DGVCashing.TabIndex = 1241
        Me.DGVCashing.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
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
        Me.DataGridViewTextBoxColumn3.Width = 121
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
        'Column10
        '
        Me.Column10.HeaderText = "الموظف"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "طريقة الدفع"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "البيان"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'ColShow
        '
        Me.ColShow.HeaderText = ""
        Me.ColShow.MinimumWidth = 6
        Me.ColShow.Name = "ColShow"
        Me.ColShow.ReadOnly = True
        Me.ColShow.Text = "عرض"
        Me.ColShow.UseColumnTextForButtonValue = True
        Me.ColShow.Width = 121
        '
        'FrmEmployeeCashingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 536)
        Me.Controls.Add(Me.TLPPages)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TLPBottom)
        Me.Controls.Add(Me.DGVCashing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeCashingReport"
        Me.Text = "تقارير ايصالات القبض و الصرف"
        Me.TLPPages.ResumeLayout(False)
        Me.TLPPages.PerformLayout()
        CType(Me.NUDPageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TLPSearch.ResumeLayout(False)
        Me.TLPSearch.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TLPBottom.ResumeLayout(False)
        CType(Me.DGVCashing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPrintAll As Button
    Friend WithEvents BtnRefreshPage As Button
    Friend WithEvents TLPPages As TableLayoutPanel
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
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TLPSearch As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ChkNum As CheckBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents ChkEmployee As CheckBox
    Friend WithEvents CmbPaymentType As ComboBox
    Friend WithEvents CmbBank As ComboBox
    Friend WithEvents TxtCheck As TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents ChkPayment As CheckBox
    Friend WithEvents Panel24 As Panel
    Friend WithEvents ChkBank As CheckBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ChkCheck As CheckBox
    Friend WithEvents TLPBottom As TableLayoutPanel
    Friend WithEvents DGVCashing As DataGridView
    Friend WithEvents CmbEmployee As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadCashing As RadioButton
    Friend WithEvents RadReceipt As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ColShow As DataGridViewButtonColumn
End Class
