<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItemReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemReport))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TLPSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.ChkCat = New System.Windows.Forms.CheckBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.CmbItem = New System.Windows.Forms.ComboBox()
        Me.ChkName = New System.Windows.Forms.CheckBox()
        Me.CmbCat = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShow = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSearch.SuspendLayout()
        Me.TLPSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 32
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column12, Me.Column11, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.ColShow, Me.ColEdit, Me.ColDel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(25, 171)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 30
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1336, 475)
        Me.DGV.TabIndex = 1242
        Me.DGV.Tag = "Dark-SelectionVisible"
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSearch.Controls.Add(Me.TLPSearch)
        Me.GrpSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.Black
        Me.GrpSearch.Location = New System.Drawing.Point(55, 33)
        Me.GrpSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpSearch.Size = New System.Drawing.Size(1279, 116)
        Me.GrpSearch.TabIndex = 1244
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "بحث حسب"
        '
        'TLPSearch
        '
        Me.TLPSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPSearch.ColumnCount = 7
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TLPSearch.Controls.Add(Me.ChkAll, 0, 0)
        Me.TLPSearch.Controls.Add(Me.ChkCat, 1, 0)
        Me.TLPSearch.Controls.Add(Me.BtnPrint, 6, 0)
        Me.TLPSearch.Controls.Add(Me.CmbItem, 5, 0)
        Me.TLPSearch.Controls.Add(Me.ChkName, 4, 0)
        Me.TLPSearch.Controls.Add(Me.CmbCat, 2, 0)
        Me.TLPSearch.Location = New System.Drawing.Point(16, 38)
        Me.TLPSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPSearch.Name = "TLPSearch"
        Me.TLPSearch.RowCount = 1
        Me.TLPSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPSearch.Size = New System.Drawing.Size(1247, 53)
        Me.TLPSearch.TabIndex = 1207
        Me.TLPSearch.Tag = "1"
        '
        'ChkAll
        '
        Me.ChkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.ChkAll.ForeColor = System.Drawing.Color.Black
        Me.ChkAll.Location = New System.Drawing.Point(1108, 4)
        Me.ChkAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(135, 45)
        Me.ChkAll.TabIndex = 1231
        Me.ChkAll.Text = "عرض الكل"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'ChkCat
        '
        Me.ChkCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkCat.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.ChkCat.ForeColor = System.Drawing.Color.Black
        Me.ChkCat.Location = New System.Drawing.Point(965, 4)
        Me.ChkCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkCat.Name = "ChkCat"
        Me.ChkCat.Size = New System.Drawing.Size(135, 45)
        Me.ChkCat.TabIndex = 91
        Me.ChkCat.Text = "التصنيف"
        Me.ChkCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkCat.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(6, 2)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 2, 3, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(221, 44)
        Me.BtnPrint.TabIndex = 1200
        Me.BtnPrint.Tag = "Dark"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'CmbItem
        '
        Me.CmbItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbItem.BackColor = System.Drawing.SystemColors.Window
        Me.CmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbItem.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.CmbItem.FormattingEnabled = True
        Me.CmbItem.Location = New System.Drawing.Point(236, 4)
        Me.CmbItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbItem.Name = "CmbItem"
        Me.CmbItem.Size = New System.Drawing.Size(271, 42)
        Me.CmbItem.TabIndex = 86
        '
        'ChkName
        '
        Me.ChkName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkName.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.ChkName.ForeColor = System.Drawing.Color.Black
        Me.ChkName.Location = New System.Drawing.Point(515, 4)
        Me.ChkName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkName.Name = "ChkName"
        Me.ChkName.Size = New System.Drawing.Size(143, 45)
        Me.ChkName.TabIndex = 92
        Me.ChkName.Text = "الصنف"
        Me.ChkName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkName.UseVisualStyleBackColor = True
        '
        'CmbCat
        '
        Me.CmbCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCat.BackColor = System.Drawing.SystemColors.Window
        Me.CmbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbCat.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbCat.FormattingEnabled = True
        Me.CmbCat.Location = New System.Drawing.Point(686, 4)
        Me.CmbCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbCat.Name = "CmbCat"
        Me.CmbCat.Size = New System.Drawing.Size(271, 42)
        Me.CmbCat.TabIndex = 90
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
        DataGridViewCellStyle2.Format = "000000"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "رقم الصنف"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Column12
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column12.HeaderText = "الاسم"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 220
        '
        'Column11
        '
        Me.Column11.HeaderText = "الكمية"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "سعر الشراء"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "سعر البيع"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "الصنع"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "النوع"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "المقاس"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "اللون"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Type"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 125
        '
        'ColShow
        '
        Me.ColShow.HeaderText = ""
        Me.ColShow.MinimumWidth = 6
        Me.ColShow.Name = "ColShow"
        Me.ColShow.ReadOnly = True
        Me.ColShow.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColShow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColShow.Text = "عرض"
        Me.ColShow.UseColumnTextForButtonValue = True
        Me.ColShow.Visible = False
        Me.ColShow.Width = 125
        '
        'ColEdit
        '
        Me.ColEdit.HeaderText = ""
        Me.ColEdit.MinimumWidth = 6
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.ReadOnly = True
        Me.ColEdit.Text = "تعديل"
        Me.ColEdit.UseColumnTextForButtonValue = True
        Me.ColEdit.Width = 125
        '
        'ColDel
        '
        Me.ColDel.HeaderText = ""
        Me.ColDel.MinimumWidth = 6
        Me.ColDel.Name = "ColDel"
        Me.ColDel.ReadOnly = True
        Me.ColDel.Text = ""
        Me.ColDel.Width = 88
        '
        'FrmItemReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 671)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmItemReport"
        Me.Text = "تقارير الأصناف"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSearch.ResumeLayout(False)
        Me.TLPSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents TLPSearch As TableLayoutPanel
    Friend WithEvents ChkCat As CheckBox
    Friend WithEvents ChkName As CheckBox
    Friend WithEvents CmbCat As ComboBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents CmbItem As ComboBox
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ColShow As DataGridViewButtonColumn
    Friend WithEvents ColEdit As DataGridViewButtonColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
End Class
