<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreparingClothesReport
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ChkTailor = New System.Windows.Forms.CheckBox()
        Me.CmbTailor = New System.Windows.Forms.ComboBox()
        Me.TLPSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.DTPFromDate = New System.Windows.Forms.DateTimePicker()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.DTPToDate = New System.Windows.Forms.DateTimePicker()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TLPSearch.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkTailor
        '
        Me.ChkTailor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkTailor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkTailor.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.ChkTailor.ForeColor = System.Drawing.Color.Black
        Me.ChkTailor.Location = New System.Drawing.Point(1003, 4)
        Me.ChkTailor.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkTailor.Name = "ChkTailor"
        Me.ChkTailor.Size = New System.Drawing.Size(240, 45)
        Me.ChkTailor.TabIndex = 91
        Me.ChkTailor.Text = "التصنيف"
        Me.ChkTailor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkTailor.UseVisualStyleBackColor = True
        '
        'CmbTailor
        '
        Me.CmbTailor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbTailor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbTailor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTailor.BackColor = System.Drawing.SystemColors.Window
        Me.CmbTailor.Enabled = False
        Me.CmbTailor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTailor.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbTailor.FormattingEnabled = True
        Me.CmbTailor.Location = New System.Drawing.Point(630, 4)
        Me.CmbTailor.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbTailor.Name = "CmbTailor"
        Me.CmbTailor.Size = New System.Drawing.Size(365, 42)
        Me.CmbTailor.TabIndex = 90
        '
        'TLPSearch
        '
        Me.TLPSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPSearch.ColumnCount = 5
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.660786!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.76504!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.85485!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSearch.Controls.Add(Me.DTPFromDate, 3, 0)
        Me.TLPSearch.Controls.Add(Me.ChkTailor, 0, 0)
        Me.TLPSearch.Controls.Add(Me.ChkDate, 2, 0)
        Me.TLPSearch.Controls.Add(Me.CmbTailor, 1, 0)
        Me.TLPSearch.Controls.Add(Me.DTPToDate, 4, 0)
        Me.TLPSearch.Location = New System.Drawing.Point(16, 38)
        Me.TLPSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPSearch.Name = "TLPSearch"
        Me.TLPSearch.RowCount = 1
        Me.TLPSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPSearch.Size = New System.Drawing.Size(1247, 53)
        Me.TLPSearch.TabIndex = 1207
        Me.TLPSearch.Tag = "1"
        '
        'DTPFromDate
        '
        Me.DTPFromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFromDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTPFromDate.CustomFormat = ""
        Me.DTPFromDate.Enabled = False
        Me.DTPFromDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFromDate.Location = New System.Drawing.Point(288, 5)
        Me.DTPFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFromDate.Name = "DTPFromDate"
        Me.DTPFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPFromDate.RightToLeftLayout = True
        Me.DTPFromDate.Size = New System.Drawing.Size(229, 42)
        Me.DTPFromDate.TabIndex = 93
        '
        'ChkDate
        '
        Me.ChkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!)
        Me.ChkDate.ForeColor = System.Drawing.Color.Black
        Me.ChkDate.Location = New System.Drawing.Point(523, 4)
        Me.ChkDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(99, 45)
        Me.ChkDate.TabIndex = 92
        Me.ChkDate.Text = "التاريخ"
        Me.ChkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'DTPToDate
        '
        Me.DTPToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPToDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTPToDate.CustomFormat = ""
        Me.DTPToDate.Enabled = False
        Me.DTPToDate.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPToDate.Location = New System.Drawing.Point(2, 5)
        Me.DTPToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPToDate.Name = "DTPToDate"
        Me.DTPToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPToDate.RightToLeftLayout = True
        Me.DTPToDate.Size = New System.Drawing.Size(282, 42)
        Me.DTPToDate.TabIndex = 94
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSearch.Controls.Add(Me.TLPSearch)
        Me.GrpSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.Black
        Me.GrpSearch.Location = New System.Drawing.Point(12, 13)
        Me.GrpSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpSearch.Size = New System.Drawing.Size(1279, 116)
        Me.GrpSearch.TabIndex = 1246
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "بحث حسب"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.ColumnHeadersHeight = 32
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column9, Me.Column8, Me.Column5, Me.ColEdit})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(12, 135)
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
        Me.DGV.Size = New System.Drawing.Size(1295, 609)
        Me.DGV.TabIndex = 1303
        Me.DGV.Tag = "Dark-SelectionVisible"
        '
        'Column11
        '
        Me.Column11.HeaderText = "ID"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column6
        '
        Me.Column6.FillWeight = 30.0!
        Me.Column6.HeaderText = "ت"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 69.51871!
        Me.Column1.HeaderText = "الصنف"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 69.51871!
        Me.Column2.HeaderText = "رقم القطعة"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 69.51871!
        Me.Column3.HeaderText = "الكمية"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 69.51871!
        Me.Column4.HeaderText = "الحجم"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 69.51871!
        Me.Column7.HeaderText = "سعر الخياط"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.FillWeight = 69.51871!
        Me.Column9.HeaderText = "سعر القماش"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 69.51871!
        Me.Column8.HeaderText = "سعر القطعة"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 69.51871!
        Me.Column5.HeaderText = "الخياط"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'ColEdit
        '
        Me.ColEdit.FillWeight = 69.51871!
        Me.ColEdit.HeaderText = ""
        Me.ColEdit.MinimumWidth = 6
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.ReadOnly = True
        Me.ColEdit.Text = "عرض"
        Me.ColEdit.UseColumnTextForButtonValue = True
        '
        'FrmPreparingClothesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 769)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GrpSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPreparingClothesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقارير خياطة داخلية"
        Me.TLPSearch.ResumeLayout(False)
        Me.GrpSearch.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChkTailor As CheckBox
    Friend WithEvents CmbTailor As ComboBox
    Friend WithEvents TLPSearch As TableLayoutPanel
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents DTPFromDate As DateTimePicker
    Friend WithEvents DTPToDate As DateTimePicker
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ColEdit As DataGridViewButtonColumn
End Class
