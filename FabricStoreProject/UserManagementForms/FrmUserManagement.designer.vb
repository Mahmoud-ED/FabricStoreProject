<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserManagement
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserManagement))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnResetPassword = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnLockedOut = New System.Windows.Forms.Button()
        Me.BtnSavePermission = New System.Windows.Forms.Button()
        Me.CmbEmp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPpermission = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.CmbOperation = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ChkAdmin = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TLPChks = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkSelectAll = New System.Windows.Forms.CheckBox()
        Me.ChkPrint = New System.Windows.Forms.CheckBox()
        Me.ChkUpdate = New System.Windows.Forms.CheckBox()
        Me.ChkDelete = New System.Windows.Forms.CheckBox()
        Me.ChkInsert = New System.Windows.Forms.CheckBox()
        Me.TLPData = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblActive = New System.Windows.Forms.Label()
        Me.CmbUser = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PicShowPassword = New System.Windows.Forms.PictureBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblEmpName = New System.Windows.Forms.Label()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlReport = New System.Windows.Forms.Panel()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.TLPSearchOption = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadNotActive = New System.Windows.Forms.RadioButton()
        Me.RadActive = New System.Windows.Forms.RadioButton()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.ChkName = New System.Windows.Forms.CheckBox()
        Me.ChkState = New System.Windows.Forms.CheckBox()
        Me.ChkDel = New System.Windows.Forms.CheckBox()
        Me.ChkNotDel = New System.Windows.Forms.CheckBox()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGVUser = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRestore = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLPBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnRefreshSearch = New System.Windows.Forms.Button()
        Me.PnlSelectEmp = New System.Windows.Forms.Panel()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.LblShadow2 = New System.Windows.Forms.Label()
        Me.LblShadow1 = New System.Windows.Forms.Label()
        Me.LblUserReport = New System.Windows.Forms.Label()
        Me.LblUserData = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TLP.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPpermission.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TLPChks.SuspendLayout()
        Me.TLPData.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlReport.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.TLPSearchOption.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPBottom.SuspendLayout()
        Me.PnlSelectEmp.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.PnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        '
        'BtnResetPassword
        '
        Me.BtnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnResetPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResetPassword.FlatAppearance.BorderSize = 0
        Me.BtnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetPassword.ForeColor = System.Drawing.Color.White
        Me.BtnResetPassword.Location = New System.Drawing.Point(93, 4)
        Me.BtnResetPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnResetPassword.Name = "BtnResetPassword"
        Me.BtnResetPassword.Size = New System.Drawing.Size(110, 35)
        Me.BtnResetPassword.TabIndex = 1230
        Me.BtnResetPassword.Tag = "Dark"
        Me.BtnResetPassword.Text = "ضبط كلمة المرور"
        Me.ToolTip1.SetToolTip(Me.BtnResetPassword, " (0000) ضبط كلمة المرور إلى")
        Me.BtnResetPassword.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.Location = New System.Drawing.Point(2, 2)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefresh.Size = New System.Drawing.Size(188, 35)
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Tag = "Dark"
        Me.BtnRefresh.Text = "تحديث"
        Me.ToolTip1.SetToolTip(Me.BtnRefresh, "تحديث")
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(406, 2)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDelete.Size = New System.Drawing.Size(188, 35)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Tag = "Dark"
        Me.BtnDelete.Text = "حذف"
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "حذف")
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(608, 2)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.Size = New System.Drawing.Size(188, 35)
        Me.BtnNew.TabIndex = 3
        Me.BtnNew.Tag = "Dark"
        Me.BtnNew.Text = "جديد"
        Me.ToolTip1.SetToolTip(Me.BtnNew, "جديد")
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(810, 2)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(188, 35)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Tag = "Dark"
        Me.BtnSave.Text = "حفظ"
        Me.ToolTip1.SetToolTip(Me.BtnSave, "حفظ")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnLockedOut
        '
        Me.BtnLockedOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnLockedOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLockedOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLockedOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLockedOut.FlatAppearance.BorderSize = 0
        Me.BtnLockedOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLockedOut.Font = New System.Drawing.Font("Droid Arabic Kufi", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLockedOut.ForeColor = System.Drawing.Color.White
        Me.BtnLockedOut.Image = CType(resources.GetObject("BtnLockedOut.Image"), System.Drawing.Image)
        Me.BtnLockedOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLockedOut.Location = New System.Drawing.Point(204, 2)
        Me.BtnLockedOut.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLockedOut.Name = "BtnLockedOut"
        Me.BtnLockedOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnLockedOut.Size = New System.Drawing.Size(188, 35)
        Me.BtnLockedOut.TabIndex = 6
        Me.BtnLockedOut.Tag = "Dark"
        Me.BtnLockedOut.Text = "ايقاف"
        Me.ToolTip1.SetToolTip(Me.BtnLockedOut, "ايقاف")
        Me.BtnLockedOut.UseVisualStyleBackColor = False
        '
        'BtnSavePermission
        '
        Me.BtnSavePermission.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSavePermission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSavePermission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSavePermission.FlatAppearance.BorderSize = 0
        Me.BtnSavePermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavePermission.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePermission.ForeColor = System.Drawing.Color.White
        Me.BtnSavePermission.Image = CType(resources.GetObject("BtnSavePermission.Image"), System.Drawing.Image)
        Me.BtnSavePermission.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSavePermission.Location = New System.Drawing.Point(5, 1)
        Me.BtnSavePermission.Margin = New System.Windows.Forms.Padding(10, 1, 5, 1)
        Me.BtnSavePermission.Name = "BtnSavePermission"
        Me.BtnSavePermission.Size = New System.Drawing.Size(188, 36)
        Me.BtnSavePermission.TabIndex = 1006
        Me.BtnSavePermission.Tag = "Dark"
        Me.BtnSavePermission.Text = "حفظ الصلاحية"
        Me.ToolTip1.SetToolTip(Me.BtnSavePermission, "حفظ الصلاحية")
        Me.BtnSavePermission.UseVisualStyleBackColor = False
        '
        'CmbEmp
        '
        Me.CmbEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmp.DropDownHeight = 160
        Me.CmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEmp.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbEmp.FormattingEnabled = True
        Me.CmbEmp.IntegralHeight = False
        Me.CmbEmp.Location = New System.Drawing.Point(24, 29)
        Me.CmbEmp.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbEmp.MaxLength = 100
        Me.CmbEmp.Name = "CmbEmp"
        Me.CmbEmp.Size = New System.Drawing.Size(313, 35)
        Me.CmbEmp.TabIndex = 1002
        Me.CmbEmp.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(343, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 34)
        Me.Label4.TabIndex = 1001
        Me.Label4.Tag = ""
        Me.Label4.Text = "الاسم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.GroupBox1)
        Me.Panel9.Controls.Add(Me.GroupBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(436, 193)
        Me.Panel9.TabIndex = 1005
        Me.Panel9.Tag = "Gry"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(416, 74)
        Me.GroupBox1.TabIndex = 1006
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "قائمة الموظفين"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnOk)
        Me.GroupBox2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 99)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(416, 84)
        Me.GroupBox2.TabIndex = 1005
        Me.GroupBox2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(20, 31)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(176, 36)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Tag = "Dark"
        Me.BtnCancel.Text = "إغلاق"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderSize = 0
        Me.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.Location = New System.Drawing.Point(220, 31)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnOk.Size = New System.Drawing.Size(176, 36)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Tag = "Dark"
        Me.BtnOk.Text = "موافق"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 546.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1010, 546)
        Me.TableLayoutPanel2.TabIndex = 979
        Me.TableLayoutPanel2.Tag = "Gry"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.58416!))
        Me.TableLayoutPanel4.Controls.Add(Me.TLP, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 15)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1010, 531)
        Me.TableLayoutPanel4.TabIndex = 978
        '
        'TLP
        '
        Me.TLP.ColumnCount = 1
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TLP.Controls.Add(Me.TLPpermission, 0, 2)
        Me.TLP.Controls.Add(Me.TLPData, 0, 0)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.Location = New System.Drawing.Point(3, 3)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 3
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP.Size = New System.Drawing.Size(1004, 505)
        Me.TLP.TabIndex = 979
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLockedOut, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnRefresh, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDelete, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnNew, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSave, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 138)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 39)
        Me.TableLayoutPanel1.TabIndex = 981
        '
        'TLPpermission
        '
        Me.TLPpermission.ColumnCount = 1
        Me.TLPpermission.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPpermission.Controls.Add(Me.TableLayoutPanel13, 0, 1)
        Me.TLPpermission.Controls.Add(Me.Label1, 0, 0)
        Me.TLPpermission.Controls.Add(Me.Panel11, 0, 2)
        Me.TLPpermission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPpermission.Location = New System.Drawing.Point(3, 189)
        Me.TLPpermission.Name = "TLPpermission"
        Me.TLPpermission.RowCount = 3
        Me.TLPpermission.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TLPpermission.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TLPpermission.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPpermission.Size = New System.Drawing.Size(998, 313)
        Me.TLPpermission.TabIndex = 980
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 4
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.BtnSavePermission, 3, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.CmbOperation, 2, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.Panel10, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 42)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(998, 38)
        Me.TableLayoutPanel13.TabIndex = 1004
        '
        'CmbOperation
        '
        Me.CmbOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbOperation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbOperation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOperation.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbOperation.FormattingEnabled = True
        Me.CmbOperation.Location = New System.Drawing.Point(203, 1)
        Me.CmbOperation.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbOperation.MaxLength = 100
        Me.CmbOperation.Name = "CmbOperation"
        Me.CmbOperation.Size = New System.Drawing.Size(555, 35)
        Me.CmbOperation.TabIndex = 1004
        Me.CmbOperation.Tag = "1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(762, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 32)
        Me.Label2.TabIndex = 1003
        Me.Label2.Tag = ""
        Me.Label2.Text = "العملية"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel10.Controls.Add(Me.ChkAdmin)
        Me.Panel10.Location = New System.Drawing.Point(878, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(111, 29)
        Me.Panel10.TabIndex = 1005
        '
        'ChkAdmin
        '
        Me.ChkAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAdmin.AutoSize = True
        Me.ChkAdmin.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkAdmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAdmin.Location = New System.Drawing.Point(0, -3)
        Me.ChkAdmin.Name = "ChkAdmin"
        Me.ChkAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAdmin.Size = New System.Drawing.Size(111, 35)
        Me.ChkAdmin.TabIndex = 1
        Me.ChkAdmin.Tag = "1"
        Me.ChkAdmin.Text = "مدير النظام"
        Me.ChkAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAdmin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(990, 35)
        Me.Label1.TabIndex = 1002
        Me.Label1.Tag = ""
        Me.Label1.Text = "الصلاحيات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(20, 90)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(958, 213)
        Me.Panel11.TabIndex = 1007
        Me.Panel11.Tag = "Back"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.Controls.Add(Me.TLPChks)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(956, 211)
        Me.Panel12.TabIndex = 1
        '
        'TLPChks
        '
        Me.TLPChks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPChks.ColumnCount = 3
        Me.TLPChks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.86826!))
        Me.TLPChks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.47904!))
        Me.TLPChks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.65269!))
        Me.TLPChks.Controls.Add(Me.ChkSelectAll, 0, 0)
        Me.TLPChks.Controls.Add(Me.ChkPrint, 2, 2)
        Me.TLPChks.Controls.Add(Me.ChkUpdate, 2, 1)
        Me.TLPChks.Controls.Add(Me.ChkDelete, 1, 2)
        Me.TLPChks.Controls.Add(Me.ChkInsert, 1, 1)
        Me.TLPChks.Location = New System.Drawing.Point(60, 4)
        Me.TLPChks.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.TLPChks.Name = "TLPChks"
        Me.TLPChks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPChks.RowCount = 3
        Me.TLPChks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPChks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPChks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPChks.Size = New System.Drawing.Size(835, 203)
        Me.TLPChks.TabIndex = 1003
        '
        'ChkSelectAll
        '
        Me.ChkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSelectAll.AutoSize = True
        Me.ChkSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.ChkSelectAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkSelectAll.Location = New System.Drawing.Point(622, 16)
        Me.ChkSelectAll.Name = "ChkSelectAll"
        Me.ChkSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSelectAll.Size = New System.Drawing.Size(210, 35)
        Me.ChkSelectAll.TabIndex = 0
        Me.ChkSelectAll.Tag = "1"
        Me.ChkSelectAll.Text = "تحديد الكل"
        Me.ChkSelectAll.UseVisualStyleBackColor = False
        '
        'ChkPrint
        '
        Me.ChkPrint.AutoSize = True
        Me.ChkPrint.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkPrint.Location = New System.Drawing.Point(329, 137)
        Me.ChkPrint.Name = "ChkPrint"
        Me.ChkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPrint.Size = New System.Drawing.Size(116, 35)
        Me.ChkPrint.TabIndex = 4
        Me.ChkPrint.Tag = "1"
        Me.ChkPrint.Text = "طباعة تقارير"
        Me.ChkPrint.UseVisualStyleBackColor = True
        '
        'ChkUpdate
        '
        Me.ChkUpdate.AutoSize = True
        Me.ChkUpdate.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkUpdate.Location = New System.Drawing.Point(370, 70)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUpdate.Size = New System.Drawing.Size(75, 35)
        Me.ChkUpdate.TabIndex = 2
        Me.ChkUpdate.Tag = "1"
        Me.ChkUpdate.Text = "تعديل"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'ChkDelete
        '
        Me.ChkDelete.AutoSize = True
        Me.ChkDelete.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkDelete.Location = New System.Drawing.Point(549, 137)
        Me.ChkDelete.Name = "ChkDelete"
        Me.ChkDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkDelete.Size = New System.Drawing.Size(67, 35)
        Me.ChkDelete.TabIndex = 3
        Me.ChkDelete.Tag = "1"
        Me.ChkDelete.Text = "حذف"
        Me.ChkDelete.UseVisualStyleBackColor = True
        '
        'ChkInsert
        '
        Me.ChkInsert.AutoSize = True
        Me.ChkInsert.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.ChkInsert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkInsert.Location = New System.Drawing.Point(541, 70)
        Me.ChkInsert.Name = "ChkInsert"
        Me.ChkInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkInsert.Size = New System.Drawing.Size(75, 35)
        Me.ChkInsert.TabIndex = 1
        Me.ChkInsert.Tag = "1"
        Me.ChkInsert.Text = "اضافة"
        Me.ChkInsert.UseVisualStyleBackColor = True
        '
        'TLPData
        '
        Me.TLPData.ColumnCount = 2
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TLPData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPData.Controls.Add(Me.TableLayoutPanel11, 1, 0)
        Me.TLPData.Controls.Add(Me.TableLayoutPanel8, 1, 2)
        Me.TLPData.Controls.Add(Me.Label8, 0, 2)
        Me.TLPData.Controls.Add(Me.Label3, 0, 0)
        Me.TLPData.Controls.Add(Me.Label6, 0, 1)
        Me.TLPData.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TLPData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPData.Location = New System.Drawing.Point(3, 3)
        Me.TLPData.Name = "TLPData"
        Me.TLPData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPData.RowCount = 3
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPData.Size = New System.Drawing.Size(998, 130)
        Me.TLPData.TabIndex = 977
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.LblActive, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.CmbUser, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(858, 43)
        Me.TableLayoutPanel11.TabIndex = 1002
        '
        'LblActive
        '
        Me.LblActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblActive.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.LblActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblActive.Location = New System.Drawing.Point(4, 4)
        Me.LblActive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblActive.Name = "LblActive"
        Me.LblActive.Size = New System.Drawing.Size(198, 34)
        Me.LblActive.TabIndex = 1001
        Me.LblActive.Tag = ""
        Me.LblActive.Text = "فعّال"
        Me.LblActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbUser
        '
        Me.CmbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUser.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.CmbUser.FormattingEnabled = True
        Me.CmbUser.Location = New System.Drawing.Point(206, 3)
        Me.CmbUser.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbUser.MaxLength = 100
        Me.CmbUser.Name = "CmbUser"
        Me.CmbUser.Size = New System.Drawing.Size(652, 35)
        Me.CmbUser.TabIndex = 987
        Me.CmbUser.Tag = "1"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.BtnResetPassword, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 86)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(858, 44)
        Me.TableLayoutPanel8.TabIndex = 990
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PicShowPassword)
        Me.Panel5.Controls.Add(Me.TxtPassword)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(206, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(649, 38)
        Me.Panel5.TabIndex = 1231
        '
        'PicShowPassword
        '
        Me.PicShowPassword.BackColor = System.Drawing.Color.White
        Me.PicShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShowPassword.Image = CType(resources.GetObject("PicShowPassword.Image"), System.Drawing.Image)
        Me.PicShowPassword.Location = New System.Drawing.Point(10, 10)
        Me.PicShowPassword.Name = "PicShowPassword"
        Me.PicShowPassword.Size = New System.Drawing.Size(19, 19)
        Me.PicShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicShowPassword.TabIndex = 993
        Me.PicShowPassword.TabStop = False
        Me.PicShowPassword.Tag = "1"
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.TxtPassword.Location = New System.Drawing.Point(3, 3)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtPassword.MaxLength = 200
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPassword.Size = New System.Drawing.Size(646, 35)
        Me.TxtPassword.TabIndex = 992
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(862, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 32)
        Me.Label8.TabIndex = 963
        Me.Label8.Tag = ""
        Me.Label8.Text = "كلمة المرور"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(862, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 34)
        Me.Label3.TabIndex = 1001
        Me.Label3.Tag = ""
        Me.Label3.Text = "اسم المستخدم"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(862, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 34)
        Me.Label6.TabIndex = 1000
        Me.Label6.Tag = ""
        Me.Label6.Text = "اسم الموظف"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LblEmpName, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 43)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(858, 43)
        Me.TableLayoutPanel6.TabIndex = 1001
        '
        'LblEmpName
        '
        Me.LblEmpName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmpName.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.LblEmpName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblEmpName.Location = New System.Drawing.Point(205, 4)
        Me.LblEmpName.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEmpName.Name = "LblEmpName"
        Me.LblEmpName.Size = New System.Drawing.Size(653, 34)
        Me.LblEmpName.TabIndex = 1003
        Me.LblEmpName.Tag = "Black"
        Me.LblEmpName.Text = "اسم الموظف"
        Me.LblEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.SystemColors.Control
        Me.PnlUser.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlUser.Location = New System.Drawing.Point(0, 0)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlUser.Size = New System.Drawing.Size(1010, 546)
        Me.PnlUser.TabIndex = 972
        Me.PnlUser.Tag = "Back"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlUser)
        Me.Panel2.Controls.Add(Me.PnlReport)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 546)
        Me.Panel2.TabIndex = 982
        Me.Panel2.Tag = "Back"
        '
        'PnlReport
        '
        Me.PnlReport.BackColor = System.Drawing.SystemColors.Control
        Me.PnlReport.Controls.Add(Me.GrpSearch)
        Me.PnlReport.Controls.Add(Me.ChkAll)
        Me.PnlReport.Controls.Add(Me.GroupBox7)
        Me.PnlReport.Controls.Add(Me.TLPBottom)
        Me.PnlReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlReport.Location = New System.Drawing.Point(0, 0)
        Me.PnlReport.Name = "PnlReport"
        Me.PnlReport.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlReport.Size = New System.Drawing.Size(1010, 546)
        Me.PnlReport.TabIndex = 983
        Me.PnlReport.Tag = "Gry"
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GrpSearch.Controls.Add(Me.TLPSearchOption)
        Me.GrpSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.GrpSearch.ForeColor = System.Drawing.Color.Black
        Me.GrpSearch.Location = New System.Drawing.Point(13, 8)
        Me.GrpSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpSearch.Size = New System.Drawing.Size(980, 143)
        Me.GrpSearch.TabIndex = 971
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Tag = "Secondary"
        Me.GrpSearch.Text = "بحث حسب"
        '
        'TLPSearchOption
        '
        Me.TLPSearchOption.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPSearchOption.ColumnCount = 2
        Me.TLPSearchOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TLPSearchOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPSearchOption.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSearchOption.Controls.Add(Me.TableLayoutPanel14, 1, 2)
        Me.TLPSearchOption.Controls.Add(Me.TxtName, 1, 1)
        Me.TLPSearchOption.Controls.Add(Me.ChkName, 0, 1)
        Me.TLPSearchOption.Controls.Add(Me.ChkState, 0, 2)
        Me.TLPSearchOption.Controls.Add(Me.ChkDel, 1, 0)
        Me.TLPSearchOption.Controls.Add(Me.ChkNotDel, 0, 0)
        Me.TLPSearchOption.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLPSearchOption.Location = New System.Drawing.Point(6, 29)
        Me.TLPSearchOption.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPSearchOption.Name = "TLPSearchOption"
        Me.TLPSearchOption.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.TLPSearchOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TLPSearchOption.RowCount = 3
        Me.TLPSearchOption.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearchOption.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearchOption.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPSearchOption.Size = New System.Drawing.Size(962, 106)
        Me.TLPSearchOption.TabIndex = 11
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 3
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.81374!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.12021!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.RadNotActive, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.RadActive, 0, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(23, 73)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(814, 30)
        Me.TableLayoutPanel14.TabIndex = 970
        '
        'RadNotActive
        '
        Me.RadNotActive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadNotActive.Enabled = False
        Me.RadNotActive.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.RadNotActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadNotActive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadNotActive.Location = New System.Drawing.Point(272, 0)
        Me.RadNotActive.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RadNotActive.Name = "RadNotActive"
        Me.RadNotActive.Size = New System.Drawing.Size(393, 30)
        Me.RadNotActive.TabIndex = 1
        Me.RadNotActive.TabStop = True
        Me.RadNotActive.Text = "موقوف"
        Me.RadNotActive.UseVisualStyleBackColor = True
        '
        'RadActive
        '
        Me.RadActive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadActive.Enabled = False
        Me.RadActive.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.RadActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadActive.Location = New System.Drawing.Point(675, 0)
        Me.RadActive.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RadActive.Name = "RadActive"
        Me.RadActive.Size = New System.Drawing.Size(129, 30)
        Me.RadActive.TabIndex = 0
        Me.RadActive.TabStop = True
        Me.RadActive.Text = "فعًال"
        Me.RadActive.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Enabled = False
        Me.TxtName.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.TxtName.Location = New System.Drawing.Point(20, 38)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtName.MaxLength = 8
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(820, 29)
        Me.TxtName.TabIndex = 948
        '
        'ChkName
        '
        Me.ChkName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkName.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkName.Location = New System.Drawing.Point(843, 38)
        Me.ChkName.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.ChkName.Name = "ChkName"
        Me.ChkName.Size = New System.Drawing.Size(109, 29)
        Me.ChkName.TabIndex = 1
        Me.ChkName.Text = "الاسم"
        Me.ChkName.UseVisualStyleBackColor = True
        '
        'ChkState
        '
        Me.ChkState.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkState.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkState.Location = New System.Drawing.Point(843, 74)
        Me.ChkState.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.ChkState.Name = "ChkState"
        Me.ChkState.Size = New System.Drawing.Size(109, 28)
        Me.ChkState.TabIndex = 967
        Me.ChkState.Text = "الحالة"
        Me.ChkState.UseVisualStyleBackColor = True
        '
        'ChkDel
        '
        Me.ChkDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkDel.Location = New System.Drawing.Point(23, 4)
        Me.ChkDel.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.ChkDel.Name = "ChkDel"
        Me.ChkDel.Size = New System.Drawing.Size(807, 27)
        Me.ChkDel.TabIndex = 963
        Me.ChkDel.Text = "المحذوفين"
        Me.ChkDel.UseVisualStyleBackColor = True
        '
        'ChkNotDel
        '
        Me.ChkNotDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNotDel.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkNotDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkNotDel.Location = New System.Drawing.Point(843, 3)
        Me.ChkNotDel.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.ChkNotDel.Name = "ChkNotDel"
        Me.ChkNotDel.Size = New System.Drawing.Size(109, 29)
        Me.ChkNotDel.TabIndex = 971
        Me.ChkNotDel.Text = "النشطون"
        Me.ChkNotDel.UseVisualStyleBackColor = True
        '
        'ChkAll
        '
        Me.ChkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAll.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.ChkAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAll.Location = New System.Drawing.Point(884, 205)
        Me.ChkAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(97, 30)
        Me.ChkAll.TabIndex = 969
        Me.ChkAll.Text = "عرض الكل"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.DGVUser)
        Me.GroupBox7.Location = New System.Drawing.Point(13, 215)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(980, 313)
        Me.GroupBox7.TabIndex = 1236
        Me.GroupBox7.TabStop = False
        '
        'DGVUser
        '
        Me.DGVUser.AllowUserToAddRows = False
        Me.DGVUser.AllowUserToResizeRows = False
        Me.DGVUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUser.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGVUser.ColumnHeadersHeight = 32
        Me.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column10, Me.Column11, Me.DataGridViewTextBoxColumn4, Me.ColRestore, Me.Column6, Me.ColDelete, Me.ColDel, Me.Column13})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUser.DefaultCellStyle = DataGridViewCellStyle16
        Me.DGVUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVUser.GridColor = System.Drawing.Color.Gray
        Me.DGVUser.Location = New System.Drawing.Point(7, 27)
        Me.DGVUser.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVUser.MultiSelect = False
        Me.DGVUser.Name = "DGVUser"
        Me.DGVUser.ReadOnly = True
        Me.DGVUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVUser.RowHeadersVisible = False
        Me.DGVUser.RowHeadersWidth = 51
        Me.DGVUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVUser.RowTemplate.Height = 30
        Me.DGVUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUser.Size = New System.Drawing.Size(963, 274)
        Me.DGVUser.TabIndex = 1235
        Me.DGVUser.Tag = "Dark-SelectionVisible"
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "ت"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "الإسم"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "الحالة"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn4.HeaderText = "محذوف"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ColRestore
        '
        Me.ColRestore.HeaderText = ""
        Me.ColRestore.Name = "ColRestore"
        Me.ColRestore.ReadOnly = True
        Me.ColRestore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColRestore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column6
        '
        Me.Column6.HeaderText = "EndService"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'ColDelete
        '
        Me.ColDelete.HeaderText = ""
        Me.ColDelete.Name = "ColDelete"
        Me.ColDelete.ReadOnly = True
        Me.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColDel
        '
        Me.ColDel.HeaderText = ""
        Me.ColDel.Name = "ColDel"
        Me.ColDel.ReadOnly = True
        Me.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColDel.Text = "حذف بشكل نهائي"
        Me.ColDel.UseColumnTextForButtonValue = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "LockedOut"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
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
        Me.TLPBottom.Controls.Add(Me.BtnSearch, 2, 0)
        Me.TLPBottom.Controls.Add(Me.BtnRefreshSearch, 4, 0)
        Me.TLPBottom.Location = New System.Drawing.Point(2, 160)
        Me.TLPBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.TLPBottom.Name = "TLPBottom"
        Me.TLPBottom.RowCount = 1
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLPBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLPBottom.Size = New System.Drawing.Size(1000, 40)
        Me.TLPBottom.TabIndex = 1234
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
        Me.BtnSearch.Location = New System.Drawing.Point(506, 2)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSearch.Size = New System.Drawing.Size(242, 36)
        Me.BtnSearch.TabIndex = 34
        Me.BtnSearch.Tag = "Dark"
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnRefreshSearch
        '
        Me.BtnRefreshSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefreshSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefreshSearch.FlatAppearance.BorderSize = 0
        Me.BtnRefreshSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BtnRefreshSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnRefreshSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshSearch.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.BtnRefreshSearch.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshSearch.Image = CType(resources.GetObject("BtnRefreshSearch.Image"), System.Drawing.Image)
        Me.BtnRefreshSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefreshSearch.Location = New System.Drawing.Point(254, 2)
        Me.BtnRefreshSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnRefreshSearch.Name = "BtnRefreshSearch"
        Me.BtnRefreshSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRefreshSearch.Size = New System.Drawing.Size(242, 36)
        Me.BtnRefreshSearch.TabIndex = 31
        Me.BtnRefreshSearch.Tag = "Dark"
        Me.BtnRefreshSearch.Text = "تحديث"
        Me.BtnRefreshSearch.UseVisualStyleBackColor = False
        '
        'PnlSelectEmp
        '
        Me.PnlSelectEmp.BackColor = System.Drawing.SystemColors.Control
        Me.PnlSelectEmp.Controls.Add(Me.Panel9)
        Me.PnlSelectEmp.Controls.Add(Me.Lbl)
        Me.PnlSelectEmp.Controls.Add(Me.Panel6)
        Me.PnlSelectEmp.Controls.Add(Me.Panel13)
        Me.PnlSelectEmp.Controls.Add(Me.PnlMenu)
        Me.PnlSelectEmp.Location = New System.Drawing.Point(0, 0)
        Me.PnlSelectEmp.Name = "PnlSelectEmp"
        Me.PnlSelectEmp.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlSelectEmp.Size = New System.Drawing.Size(442, 297)
        Me.PnlSelectEmp.TabIndex = 983
        Me.PnlSelectEmp.Visible = False
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!)
        Me.Lbl.ForeColor = System.Drawing.Color.White
        Me.Lbl.Location = New System.Drawing.Point(3, 36)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Padding = New System.Windows.Forms.Padding(2)
        Me.Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl.Size = New System.Drawing.Size(436, 37)
        Me.Lbl.TabIndex = 983
        Me.Lbl.Tag = "Primary"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(436, 5)
        Me.Panel6.TabIndex = 1006
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(3, 266)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(436, 28)
        Me.Panel13.TabIndex = 985
        Me.Panel13.TabStop = True
        Me.Panel13.Tag = "Dark"
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnClose)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(3, 3)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(436, 28)
        Me.PnlMenu.TabIndex = 984
        Me.PnlMenu.TabStop = True
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
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(38, 28)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PnlButtons
        '
        Me.PnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlButtons.Controls.Add(Me.LblShadow2)
        Me.PnlButtons.Controls.Add(Me.LblShadow1)
        Me.PnlButtons.Controls.Add(Me.LblUserReport)
        Me.PnlButtons.Controls.Add(Me.LblUserData)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlButtons.Location = New System.Drawing.Point(0, 0)
        Me.PnlButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(1010, 45)
        Me.PnlButtons.TabIndex = 984
        Me.PnlButtons.Tag = "Primary"
        '
        'LblShadow2
        '
        Me.LblShadow2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblShadow2.BackColor = System.Drawing.Color.White
        Me.LblShadow2.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.LblShadow2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblShadow2.Location = New System.Drawing.Point(276, 36)
        Me.LblShadow2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblShadow2.Name = "LblShadow2"
        Me.LblShadow2.Size = New System.Drawing.Size(212, 4)
        Me.LblShadow2.TabIndex = 2
        Me.LblShadow2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblShadow2.Visible = False
        '
        'LblShadow1
        '
        Me.LblShadow1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblShadow1.BackColor = System.Drawing.Color.White
        Me.LblShadow1.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!)
        Me.LblShadow1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblShadow1.Location = New System.Drawing.Point(523, 36)
        Me.LblShadow1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblShadow1.Name = "LblShadow1"
        Me.LblShadow1.Size = New System.Drawing.Size(212, 4)
        Me.LblShadow1.TabIndex = 1
        Me.LblShadow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblShadow1.Visible = False
        '
        'LblUserReport
        '
        Me.LblUserReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUserReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblUserReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblUserReport.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUserReport.Location = New System.Drawing.Point(276, 0)
        Me.LblUserReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserReport.Name = "LblUserReport"
        Me.LblUserReport.Size = New System.Drawing.Size(212, 45)
        Me.LblUserReport.TabIndex = 1
        Me.LblUserReport.Tag = "Primary"
        Me.LblUserReport.Text = "تقارير المستخدمين"
        Me.LblUserReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserData
        '
        Me.LblUserData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUserData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.LblUserData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblUserData.Font = New System.Drawing.Font("Droid Arabic Kufi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUserData.Location = New System.Drawing.Point(523, 0)
        Me.LblUserData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserData.Name = "LblUserData"
        Me.LblUserData.Size = New System.Drawing.Size(212, 45)
        Me.LblUserData.TabIndex = 0
        Me.LblUserData.Tag = "Primary"
        Me.LblUserData.Text = "بيانات المستخدمين"
        Me.LblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1010, 591)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.PnlSelectEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إدارة المستخدمين"
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TLP.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TLPpermission.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.TLPChks.ResumeLayout(False)
        Me.TLPChks.PerformLayout()
        Me.TLPData.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PicShowPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.PnlUser.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnlReport.ResumeLayout(False)
        Me.GrpSearch.ResumeLayout(False)
        Me.TLPSearchOption.ResumeLayout(False)
        Me.TLPSearchOption.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPBottom.ResumeLayout(False)
        Me.PnlSelectEmp.ResumeLayout(False)
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CmbEmp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TLP As TableLayoutPanel
    Friend WithEvents TLPpermission As TableLayoutPanel
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents CmbOperation As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents ChkAdmin As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TLPChks As TableLayoutPanel
    Friend WithEvents ChkSelectAll As CheckBox
    Friend WithEvents ChkPrint As CheckBox
    Friend WithEvents ChkUpdate As CheckBox
    Friend WithEvents ChkDelete As CheckBox
    Friend WithEvents ChkInsert As CheckBox
    Friend WithEvents TLPData As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents LblActive As Label
    Friend WithEvents CmbUser As ComboBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents LblEmpName As Label
    Friend WithEvents PnlUser As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlReport As Panel
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents TLPSearchOption As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents RadNotActive As RadioButton
    Friend WithEvents RadActive As RadioButton
    Friend WithEvents TxtName As TextBox
    Friend WithEvents ChkDel As CheckBox
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents ChkName As CheckBox
    Friend WithEvents ChkState As CheckBox
    Friend WithEvents PnlSelectEmp As Panel
    Friend WithEvents BtnSavePermission As Button
    Friend WithEvents BtnResetPassword As Button
    Friend WithEvents PnlButtons As Panel
    Friend WithEvents LblShadow2 As Label
    Friend WithEvents LblShadow1 As Label
    Friend WithEvents LblUserReport As Label
    Friend WithEvents LblUserData As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Lbl As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnLockedOut As Button
    Friend WithEvents TLPBottom As TableLayoutPanel
    Friend WithEvents BtnRefreshSearch As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DGVUser As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ChkNotDel As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ColRestore As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ColDelete As DataGridViewButtonColumn
    Friend WithEvents ColDel As DataGridViewButtonColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents PicShowPassword As PictureBox
End Class
