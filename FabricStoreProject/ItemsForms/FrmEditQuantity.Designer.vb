<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditQuantity))
        Me.PnlTitel = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.Label()
        Me.TxtPrush = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.Label()
        Me.TxtNewQuantity = New System.Windows.Forms.TextBox()
        Me.TxtNewPrush = New System.Windows.Forms.TextBox()
        Me.TxtNewPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlTitel.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitel
        '
        Me.PnlTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlTitel.Controls.Add(Me.BtnClose)
        Me.PnlTitel.Controls.Add(Me.LblTitel)
        Me.PnlTitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitel.ForeColor = System.Drawing.Color.Transparent
        Me.PnlTitel.Location = New System.Drawing.Point(3, 3)
        Me.PnlTitel.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitel.Name = "PnlTitel"
        Me.PnlTitel.Size = New System.Drawing.Size(794, 34)
        Me.PnlTitel.TabIndex = 31
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
        'LblTitel
        '
        Me.LblTitel.BackColor = System.Drawing.Color.Transparent
        Me.LblTitel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.LblTitel.ForeColor = System.Drawing.Color.White
        Me.LblTitel.Location = New System.Drawing.Point(171, 0)
        Me.LblTitel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(429, 34)
        Me.LblTitel.TabIndex = 1
        Me.LblTitel.Text = "تعديل مخزون"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtQuantity.ForeColor = System.Drawing.Color.Black
        Me.TxtQuantity.Location = New System.Drawing.Point(66, 94)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtQuantity.Size = New System.Drawing.Size(265, 45)
        Me.TxtQuantity.TabIndex = 1302
        Me.TxtQuantity.Tag = "AutoC"
        Me.TxtQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPrush
        '
        Me.TxtPrush.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrush.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPrush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrush.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPrush.ForeColor = System.Drawing.Color.Black
        Me.TxtPrush.Location = New System.Drawing.Point(66, 165)
        Me.TxtPrush.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPrush.Name = "TxtPrush"
        Me.TxtPrush.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrush.Size = New System.Drawing.Size(265, 45)
        Me.TxtPrush.TabIndex = 1303
        Me.TxtPrush.Tag = "AutoC"
        Me.TxtPrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPrice
        '
        Me.TxtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPrice.ForeColor = System.Drawing.Color.Black
        Me.TxtPrice.Location = New System.Drawing.Point(66, 243)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrice.Size = New System.Drawing.Size(265, 45)
        Me.TxtPrice.TabIndex = 1304
        Me.TxtPrice.Tag = "AutoC"
        Me.TxtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNewQuantity
        '
        Me.TxtNewQuantity.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNewQuantity.Location = New System.Drawing.Point(466, 96)
        Me.TxtNewQuantity.Name = "TxtNewQuantity"
        Me.TxtNewQuantity.Size = New System.Drawing.Size(220, 42)
        Me.TxtNewQuantity.TabIndex = 1305
        '
        'TxtNewPrush
        '
        Me.TxtNewPrush.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNewPrush.Location = New System.Drawing.Point(466, 167)
        Me.TxtNewPrush.Name = "TxtNewPrush"
        Me.TxtNewPrush.Size = New System.Drawing.Size(220, 42)
        Me.TxtNewPrush.TabIndex = 1306
        '
        'TxtNewPrice
        '
        Me.TxtNewPrice.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtNewPrice.Location = New System.Drawing.Point(466, 245)
        Me.TxtNewPrice.Name = "TxtNewPrice"
        Me.TxtNewPrice.Size = New System.Drawing.Size(220, 42)
        Me.TxtNewPrice.TabIndex = 1307
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 28)
        Me.Label3.TabIndex = 1308
        Me.Label3.Text = "الكمية"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 28)
        Me.Label4.TabIndex = 1309
        Me.Label4.Text = "سعر الشراء"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(359, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 28)
        Me.Label5.TabIndex = 1310
        Me.Label5.Text = "سعر البيع"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(708, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 28)
        Me.Label6.TabIndex = 1313
        Me.Label6.Text = "سعر البيع"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(708, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 28)
        Me.Label7.TabIndex = 1312
        Me.Label7.Text = "سعر الشراء"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(708, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 28)
        Me.Label8.TabIndex = 1311
        Me.Label8.Text = "الكمية"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnRefresh, 2, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(92, 316)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(619, 38)
        Me.TableLayoutPanel3.TabIndex = 1314
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(316, 1)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(303, 36)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.Location = New System.Drawing.Point(0, 1)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefresh.Size = New System.Drawing.Size(303, 36)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 380)
        Me.Panel1.TabIndex = 1315
        '
        'FrmEditQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 386)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNewPrice)
        Me.Controls.Add(Me.TxtNewPrush)
        Me.Controls.Add(Me.TxtNewQuantity)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtPrush)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.PnlTitel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditQuantity"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEditQuantity"
        Me.PnlTitel.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTitel As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTitel As Label
    Friend WithEvents TxtQuantity As Label
    Friend WithEvents TxtPrush As Label
    Friend WithEvents TxtPrice As Label
    Friend WithEvents TxtNewQuantity As TextBox
    Friend WithEvents TxtNewPrush As TextBox
    Friend WithEvents TxtNewPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Panel1 As Panel
End Class
