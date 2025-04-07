<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerInvoiceReceipt
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DGVCustomerInvoices = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReceipt = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCustomerInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.DGVCustomerInvoices)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(26, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(940, 511)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "قائمة الديون"
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTotal.Location = New System.Drawing.Point(109, 462)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(723, 28)
        Me.LblTotal.TabIndex = 26
        Me.LblTotal.Text = "الإجمالي والباقي يكتب هنا"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVCustomerInvoices
        '
        Me.DGVCustomerInvoices.AllowUserToAddRows = False
        Me.DGVCustomerInvoices.AllowUserToDeleteRows = False
        Me.DGVCustomerInvoices.AllowUserToResizeRows = False
        Me.DGVCustomerInvoices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCustomerInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCustomerInvoices.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCustomerInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCustomerInvoices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVCustomerInvoices.ColumnHeadersHeight = 32
        Me.DGVCustomerInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVCustomerInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.ColReceipt})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCustomerInvoices.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGVCustomerInvoices.EnableHeadersVisualStyles = False
        Me.DGVCustomerInvoices.GridColor = System.Drawing.Color.Gray
        Me.DGVCustomerInvoices.Location = New System.Drawing.Point(16, 48)
        Me.DGVCustomerInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCustomerInvoices.MultiSelect = False
        Me.DGVCustomerInvoices.Name = "DGVCustomerInvoices"
        Me.DGVCustomerInvoices.ReadOnly = True
        Me.DGVCustomerInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCustomerInvoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCustomerInvoices.RowHeadersVisible = False
        Me.DGVCustomerInvoices.RowHeadersWidth = 51
        Me.DGVCustomerInvoices.RowTemplate.Height = 30
        Me.DGVCustomerInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCustomerInvoices.Size = New System.Drawing.Size(909, 399)
        Me.DGVCustomerInvoices.TabIndex = 25
        Me.DGVCustomerInvoices.Tag = "Dark-SelectionVisible"
        '
        'Column1
        '
        Me.Column1.HeaderText = "CustomerID"
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
        'Column3
        '
        Me.Column3.HeaderText = "الزبون"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column5.FillWeight = 80.86427!
        Me.Column5.HeaderText = "اجمالي قيمة الفواتير"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "اجمالي المدفوع"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "اجمالي المتبقي"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'ColReceipt
        '
        Me.ColReceipt.HeaderText = ""
        Me.ColReceipt.MinimumWidth = 6
        Me.ColReceipt.Name = "ColReceipt"
        Me.ColReceipt.ReadOnly = True
        Me.ColReceipt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColReceipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColReceipt.Text = "ايصال قبض"
        Me.ColReceipt.UseColumnTextForButtonValue = True
        '
        'FrmCustomerInvoiceReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCustomerInvoiceReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حساب الزبائن"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVCustomerInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DGVCustomerInvoices As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ColReceipt As DataGridViewButtonColumn
End Class
