Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class Frmmain
    Private Showsetting As Boolean
    Private SwBasicData As Boolean = True
    Private SwReport As Boolean = True
    Private SwReservation As Boolean = True
    Private DSSearch As New DataSet
    Private OrderID, InvoID As Integer
    Private Operation As String

    Private Btnclicked As Boolean = False
    Private Title As String = "متجر الأقمشة والملابس الجاهزة "

    Private Sub FrmMain_load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnExpenses.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        BtnEmployees.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        BtnBasicData.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        BtnReports.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)

        ChangeSystemColors(Me)

        TSLUserName.Text = UserName
        TSLDateTime.Text = "التاريخ : " + Format(Now.Date, GetDateAndTimeFormat(DTFormat.DF)) + " الوقت : " + Format(Now, GetDateAndTimeFormat(DTFormat.TF))

        Me.Size = New Size(1300, 700)
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.MaximumSize = New Size(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)
        btnmax_click(sender, e)
        My.Settings.PageSize = 10
        MsgTool("مرحباً ( " & UserName & " ) نتمنى لك يوم عمل موفق", 1)
        SSLMessage.Margin = New Padding(((Width - SSLMessage.Width) / 2), 3, 0, 2)

    End Sub
    'public sub changecolor()
    '    changesystemcolors(me)
    'end sub
    Private Sub frmmain_resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If WindowState = FormWindowState.Maximized Then
            BtnMax.Image = My.Resources.maximize_16
            Me.Padding = New Padding(0, 0, 0, 0) ' to fix not full screen problem when maximizing
            ' if you didn't understadn stop code line 19 and 23 you will get it
        Else
            BtnMax.Image = My.Resources.Normal_16
            Me.Padding = New Padding(10, 10, 10, 10) ' to make border un visible when windowstate = normal
        End If

        metop = New Rectangle(0, 0, Me.Width, bordersize)
        mebottom = New Rectangle(0, Me.ClientSize.Height - bordersize, Me.ClientSize.Width, bordersize)
        meleft = New Rectangle(0, 0, bordersize, Me.ClientSize.Height)
        meright = New Rectangle(Me.ClientSize.Width - bordersize, 0, bordersize, Me.ClientSize.Height)

        metopleft = New Rectangle(0, 0, bordersize, bordersize)
        metopright = New Rectangle(Me.ClientSize.Width - bordersize, 0, bordersize, bordersize)
        mebottomleft = New Rectangle(0, Me.ClientSize.Height - bordersize, bordersize, bordersize)
        mebottomright = New Rectangle(Me.ClientSize.Width - bordersize, Me.ClientSize.Height - bordersize, bordersize, bordersize)

        LblTitel.Left = (PnlMenu.Width - LblTitel.Width) / 2
        SSLMessage.Margin = New Padding(((Me.Width - SSLMessage.Width) / 2), 3, 0, 2)
    End Sub

    '--------------------------------------sizing grip---------------------------------------------------

    ' warning: these are very important varriables don't change any thing for any reason

    ' note: you can chage the bordersize it's just to set border thick better set it
    ' to any value between 5 and 10

    Private Const htleft = 10, htright = 11, httop = 12, httopleft = 13, httopright = 14, htbottom = 15, htbottomleft = 16, htbottomright = 17

    Private Const bordersize As Integer = 10

    Private metop As Rectangle = New Rectangle(0, 0, Me.Width, bordersize)
    Private mebottom As Rectangle = New Rectangle(0, Me.ClientSize.Height - bordersize, Me.ClientSize.Width, bordersize)
    Private meleft As Rectangle = New Rectangle(0, 0, bordersize, Me.ClientSize.Height)
    Private meright As Rectangle = New Rectangle(Me.ClientSize.Width - bordersize, 0, bordersize, Me.ClientSize.Height)

    Private metopleft As Rectangle = New Rectangle(0, 0, bordersize, bordersize)
    Private metopright As Rectangle = New Rectangle(Me.ClientSize.Width - bordersize, 0, bordersize, bordersize)
    Private mebottomleft As Rectangle = New Rectangle(0, Me.ClientSize.Height - bordersize, bordersize, bordersize)
    Private mebottomright As Rectangle = New Rectangle(Me.ClientSize.Width - bordersize, Me.ClientSize.Height - bordersize, bordersize, bordersize)

    Private Sub frmmain_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        'note: in case you want to use custom colors

        'dim pnltop as new solidbrush(color.fromargb(6, 33, 42))
        'dim statusbar as new solidbrush(color.fromargb(26, 83, 92))
        'e.graphics.fillrectangle(pnltop, metop)
        'e.graphics.fillrectangle(statusbar, mebottom)

        e.Graphics.FillRectangle(Brushes.Transparent, metop)
        e.Graphics.FillRectangle(Brushes.Transparent, mebottom)
        e.Graphics.FillRectangle(Brushes.Transparent, meleft)
        e.Graphics.FillRectangle(Brushes.Transparent, meright)

    End Sub

    Protected Overrides Sub wndproc(ByRef message As Message)

        MyBase.WndProc(message)   'note: don't touch any letter of this block
        'this block is responsible for increasing and dicreasing the form size by using the border
        ' that we've made by code

        If (message.Msg = 132) Then '// wm_nchittest  ' note: 132 = 0x84

            Dim mycursor = Me.PointToClient(Cursor.Position)

            If (metopleft.Contains(mycursor)) Then
                message.Result = httopleft
            ElseIf (metopright.Contains(mycursor)) Then
                message.Result = httopright
            ElseIf (mebottomleft.Contains(mycursor)) Then
                message.Result = htbottomleft
            ElseIf (mebottomright.Contains(mycursor)) Then
                message.Result = htbottomright
            ElseIf (metop.Contains(mycursor)) Then
                message.Result = httop
            ElseIf (meleft.Contains(mycursor)) Then
                message.Result = htleft
            ElseIf (meright.Contains(mycursor)) Then
                message.Result = htright
            ElseIf (mebottom.Contains(mycursor)) Then
                message.Result = htbottom
            End If

        End If
    End Sub

    '--------------------------------------------------------------------------------------------------------

    Private Sub btnbasicdata_click(sender As Object, e As EventArgs) Handles BtnBasicData.Click

        ''Dim Perm() As DataRow = DTUserPermission.Select("OperationID=58")

        ''If Perm(0)(3) = False Then
        ''    MsgTool("ليس لديك صلاحية العرض", 0)
        ''    Exit Sub
        ''End If


        If SwReport = False Then
            BtnReports_Click(sender, e)
        End If


        BtnBasicData.FlatAppearance.MouseDownBackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        If SwBasicData = True Then
            PnlBasicData.Visible = True
            BtnBasicData.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            BtnBasicData.Text = "▽            البيانات الأساسية          "
            SwBasicData = False
            Exit Sub
        End If
        If SwBasicData = False Then
            PnlBasicData.Visible = False
            BtnBasicData.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
            BtnBasicData.Text = "◁            البيانات الأساسية          "
            SwBasicData = True
            For Each BB As Button In PnlBasicData.Controls
                If Btnclicked = True Then
                    HideFormsBtn(PnlBasicData, {Me.Name})
                    Btnclicked = False
                End If
            Next
            Exit Sub
        End If
    End Sub

    Private Sub BtnSupplers_click(sender As Object, e As EventArgs) Handles BtnSupplers.Click
        SubMenuOpened()
        If Not FrmSuppleirContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmSuppleirContainer, PnlMain, BtnSupplers)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If

    End Sub

    Private Sub BtnSupplers_mouseenter(sender As Object, e As EventArgs) Handles BtnSupplers.MouseEnter
        BtnSupplers.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSupplers_mouseleave(sender As Object, e As EventArgs) Handles BtnSupplers.MouseLeave
        BtnSupplers.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        SubMenuOpened()
        If Not FrmCustomerContainr.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmCustomerContainr, PnlMain, BtnCustomers)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnCustomers_MouseEnter(sender As Object, e As EventArgs) Handles BtnCustomers.MouseEnter
        BtnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnCustomers_MouseLeave(sender As Object, e As EventArgs) Handles BtnCustomers.MouseLeave
        BtnCustomers.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnTailors_Click(sender As Object, e As EventArgs) Handles BtnTailors.Click
        SubMenuOpened()
        If Not FrmTailorContainr.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmTailorContainr, PnlMain, BtnTailors)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnTailors_MouseEnter(sender As Object, e As EventArgs) Handles BtnTailors.MouseEnter
        BtnTailors.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnTailors_MouseLeave(sender As Object, e As EventArgs) Handles BtnTailors.MouseLeave
        BtnTailors.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnDeliveryCo_Click(sender As Object, e As EventArgs) Handles BtnDeliveryCo.Click
        SubMenuOpened()
        If Not FrmDeliveryContainr.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmDeliveryContainr, PnlMain, BtnDeliveryCo)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If

    End Sub

    Private Sub BtnDeliveryCo_MouseEnter(sender As Object, e As EventArgs) Handles BtnDeliveryCo.MouseEnter
        BtnDeliveryCo.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnDeliveryCo_MouseLeave(sender As Object, e As EventArgs) Handles BtnDeliveryCo.MouseLeave
        BtnDeliveryCo.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub picmenu_click(sender As Object, e As EventArgs) Handles PicMenu.Click

        If TLPButtons.Visible Then
            TLPButtons.Visible = False
            PicMenu.Left = PnlMenu.Width - PicMenu.Width
        Else
            TLPButtons.Visible = True
            PicMenu.Left = TLPButtons.Left - Padding.Left
        End If

    End Sub

    Private Sub btnexpensess_click(sender As Object, e As EventArgs) Handles BtnExpenses.Click
        SubMenuOpened()
        Btnclicked = False
        If Not FrmMangmentExpensesContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmMangmentExpensesContainer, PnlMain, BtnExpenses)
            Btnclicked = True

        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnExpenses_MouseEnter(sender As Object, e As EventArgs) Handles BtnExpenses.MouseEnter
        BtnExpenses.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnExpenses_MouseLeave(sender As Object, e As EventArgs) Handles BtnExpenses.MouseLeave
        BtnExpenses.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnusermanagement_click(sender As Object, e As EventArgs) Handles BtnUserManagement.Click
        SubMenuOpened()

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=59")
        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        'Dim PermissionRows() As DataRow = DTUserPermission.Select("UserID=" & UserID & "AND (InsertP=0 OR UpdateP=0 OR DeleteP=0 OR ViewP=0 OR PrintP=0)")
        'If PermissionRows.Length <> 0 Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        Btnclicked = False
        If Not FrmUserManagement.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmUserManagement, PnlMain, BtnUserManagement)
        Else
            HideFormsBtn(PnlButton, {Me.Name})
        End If

    End Sub

    Private Sub btnusermanagement_mouseenter(sender As Object, e As EventArgs) Handles BtnUserManagement.MouseEnter
        BtnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btnusermanagement_mouseleave(sender As Object, e As EventArgs) Handles BtnUserManagement.MouseLeave
        BtnUserManagement.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TSLDateTime.Text = "التاريخ : " + Format(Now.Date, GetDateAndTimeFormat(DTFormat.DF)) + " الوقت : " + Format(Now, GetDateAndTimeFormat(DTFormat.TF))

        If Timer1.Tag >= 1 Then
            Timer1.Tag = Timer1.Tag + 1
        End If
        If Timer1.Tag = 5 Then
            Timer1.Tag = 0
            SSLMessage.Visible = False
            TSLDateTime.Visible = True
            TSLUserName.Visible = True
            ResetStatusStripBackColor(StatusStrip1)

        End If

    End Sub

    Private Sub btnsettings_click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=61")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        SubMenuOpened()
        Btnclicked = False
        If Not FrmSettingsContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmSettingsContainer, PnlMain, BtnSettings)
        Else
            HideFormsBtn(PnlButton, {Me.Name})
        End If

    End Sub

    Private Sub btnsettings_mouseenter(sender As Object, e As EventArgs) Handles BtnSettings.MouseEnter
        BtnSettings.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btnsettings_mouseleave(sender As Object, e As EventArgs) Handles BtnSettings.MouseLeave
        BtnSettings.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnPurchase_click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
        SubMenuOpened()
        Btnclicked = False
        If Not FrmPurchasesContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmPurchasesContainer, PnlMain, BtnPurchase)
        Else
            HideFormsBtn(PnlButton, {Me.Name})
        End If
    End Sub

    Private Sub BtnPurchase_MouseEnter(sender As Object, e As EventArgs) Handles BtnPurchase.MouseEnter
        BtnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnPurchase_MouseLeave(sender As Object, e As EventArgs) Handles BtnPurchase.MouseLeave
        BtnPurchase.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnclose_click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAddItem_click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        SubMenuOpened()
        Btnclicked = False
        If Not FrmStoreContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmStoreContainer, PnlMain, BtnAddItem)
            Btnclicked = True

        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnAddItem_mouseenter(sender As Object, e As EventArgs) Handles BtnAddItem.MouseEnter
        BtnAddItem.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnAddItem_mouseleave(sender As Object, e As EventArgs) Handles BtnAddItem.MouseLeave
        BtnAddItem.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=105")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        SubMenuOpened()
        Btnclicked = False
        If Not FrmSalesContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmSalesContainer, PnlMain, BtnSales)
            Btnclicked = True

        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnSales_MouseEnter(sender As Object, e As EventArgs) Handles BtnSales.MouseEnter
        BtnSales.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSales_MouseLeave(sender As Object, e As EventArgs) Handles BtnSales.MouseLeave
        BtnSales.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnmax_click(sender As Object, e As EventArgs) Handles BtnMax.Click

        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub pnlmenu_mousedown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown, LblTitel.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub pnlmenu_mouseup(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp, LblTitel.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub pnlmenu_mousemove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove, LblTitel.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Public Sub pnlmenu_doubleclick(sender As Object, e As EventArgs) Handles PnlMenu.DoubleClick
        BtnMax.PerformClick()
    End Sub

    Private Sub btnmin_click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Do
            Opacity -= 0.1
            Threading.Thread.Sleep(10)
        Loop Until Opacity = 0
        WindowState = FormWindowState.Minimized
        Opacity = 1

    End Sub

    Private Sub Frmmain_closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'If My.Computer.FileSystem.Drives.Item(1).AvailableFreeSpace < 3000000000 Then
        '    MsgBox("المساحة المتاحة للنسخ الإحتياطي على وشك الانتهاء" +
        '           vbCritical + "سيتم ايقاف النسخ الإحتياطي", vbMsgBoxRight + vbExclamation, "تحذير")
        '    Exit Sub
        'End If

        Dim sqlcon As New SQLConClass()
        SQLQuery = "execute GetBackUp"
        Save = sqlcon.CMDExecute(SQLQuery, 0)
        FrmLogin.Dispose()
    End Sub

    Private Sub BtnBank_click(sender As Object, e As EventArgs) Handles BtnBank.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=52")
        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        HideFormsBtn(PnlButton, {Me.Name})
        FrmBank.ShowDialog()

    End Sub

    Private Sub BtnPaymentType_click(sender As Object, e As EventArgs) Handles BtnPaymentType.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=53")
        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If
        HideFormsBtn(PnlButton, {Me.Name})
        FrmPaymentType.ShowDialog()

    End Sub

    Private Sub BtnCountry_Click(sender As Object, e As EventArgs) Handles BtnCountry.Click
        HideFormsBtn(PnlButton, {Me.Name})
        FrmCountry.ShowDialog()
    End Sub

    Private Sub BtnCities_Click(sender As Object, e As EventArgs) Handles BtnCities.Click
        HideFormsBtn(PnlButton, {Me.Name})
        FrmCity.ShowDialog()
    End Sub

    Private Sub BtnCities_MouseEnter(sender As Object, e As EventArgs) Handles BtnCities.MouseEnter
        BtnCities.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnCities_MouseLeave(sender As Object, e As EventArgs) Handles BtnCities.MouseLeave
        BtnCities.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnCategories_Click(sender As Object, e As EventArgs) Handles BtnCategories.Click
        HideFormsBtn(PnlButton, {Me.Name})
        FrmCategory.ShowDialog()
    End Sub

    Private Sub BtnCategories_MouseEnter(sender As Object, e As EventArgs) Handles BtnCategories.MouseEnter
        BtnCategories.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnCategories_MouseLeave(sender As Object, e As EventArgs) Handles BtnCategories.MouseLeave
        BtnCategories.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnServices_Click(sender As Object, e As EventArgs) Handles BtnServices.Click
        HideFormsBtn(PnlButton, {Me.Name})
        FrmService.ShowDialog()
    End Sub

    Private Sub BtnServices_MouseEnter(sender As Object, e As EventArgs) Handles BtnServices.MouseEnter
        BtnServices.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnServices_MouseLeave(sender As Object, e As EventArgs) Handles BtnServices.MouseLeave
        BtnServices.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnExpensesType_Click(sender As Object, e As EventArgs) Handles BtnExpensesType.Click
        HideFormsBtn(PnlButton, {Me.Name})
        FrmExpensesType.ShowDialog()
    End Sub

    Private Sub BtnExpensesType_MouseEnter(sender As Object, e As EventArgs) Handles BtnExpensesType.MouseEnter
        BtnExpensesType.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnExpensesType_MouseLeave(sender As Object, e As EventArgs) Handles BtnExpensesType.MouseLeave
        BtnExpensesType.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btndentalservices_mouseenter(sender As Object, e As EventArgs) Handles BtnBank.MouseEnter
        BtnBank.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btndentalservices_mouseleave(sender As Object, e As EventArgs) Handles BtnBank.MouseLeave
        BtnBank.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnclinicexpenses_click(sender As Object, e As EventArgs)
        'If Not FrmMangmentExpensesContainer.Visible Then
        '    HideFormsBtn(PnlButton, {Me.Name})
        '    OpenFormBtn(FrmMangmentExpensesContainer, PnlMain, BtnClinicExpenses)
        '    Btnclicked = True
        'Else
        '    HideFormsBtn(PnlButton, {Me.Name})
        '    Btnclicked = False
        'End If
    End Sub

    Private Sub picusersettings_click(sender As Object, e As EventArgs) Handles PicUserSettings.Click
        If TLPSettings.Visible = True Then
            TLPSettings.Visible = False
        Else
            TLPSettings.Visible = True
        End If
    End Sub

    Private Sub picchangecolor_click(sender As Object, e As EventArgs) Handles PicChangeColor.Click
        FrmColor.ShowDialog()
    End Sub

    Private Sub picchangepass_click(sender As Object, e As EventArgs) Handles PicChangePass.Click
        FrmChangePassword.ShowDialog()
    End Sub

    Private Sub btnimagingandradiology_mouseenter(sender As Object, e As EventArgs) Handles BtnPaymentType.MouseEnter
        BtnPaymentType.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btnimagingandradiology_mouseleave(sender As Object, e As EventArgs) Handles BtnPaymentType.MouseLeave
        BtnPaymentType.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnsafe_click(sender As Object, e As EventArgs) Handles BtnSafe.Click



        If Not FrmMainSafeReport.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmMainSafeReport, PnlMain, BtnSafe)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub btnshiftaccount_mouseenter(sender As Object, e As EventArgs) Handles BtnSafe.MouseEnter
        BtnSafe.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btnshiftaccount_mouseleave(sender As Object, e As EventArgs) Handles BtnSafe.MouseLeave
        BtnSafe.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btndailyservices_click(sender As Object, e As EventArgs) Handles BtnDailyServices.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=30")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        'If Not FrmdailySales.Visible Then
        '    HideFormsBtn(PnlButton, {Me.Name})
        '    OpenFormBtn(FrmdailySales, PnlMain, BtnDailyServices)
        '    Btnclicked = True
        'Else
        '    HideFormsBtn(PnlButton, {Me.Name})
        '    Btnclicked = False
        'End If
    End Sub

    Private Sub btndailyservices_mouseenter(sender As Object, e As EventArgs) Handles BtnDailyServices.MouseEnter
        BtnDailyServices.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btndailyservices_mouseleave(sender As Object, e As EventArgs) Handles BtnDailyServices.MouseLeave
        BtnDailyServices.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub btnreceiptreport_click(sender As Object, e As EventArgs) Handles BtnReceiptReport.Click
        If Not FrmReceiptContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmReceiptContainer, PnlMain, BtnReceiptReport)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub btnreceiptreport_mouseenter(sender As Object, e As EventArgs) Handles BtnReceiptReport.MouseEnter
        BtnReceiptReport.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnEmployees_Click(sender As Object, e As EventArgs) Handles BtnEmployees.Click

        SubMenuOpened()
        Btnclicked = False
        If Not FrmEmployeeContainr.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmEmployeeContainr, PnlMain, BtnEmployees)
        Else
            HideFormsBtn(PnlButton, {Me.Name})
        End If

    End Sub
    Private Sub BtnEmployees_MouseLeave(sender As Object, e As EventArgs) Handles BtnEmployees.MouseLeave
        BtnEmployees.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnEmployees_MouseEnter(sender As Object, e As EventArgs) Handles BtnEmployees.MouseEnter
        BtnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub btnreceiptreport_mouseleave(sender As Object, e As EventArgs) Handles BtnReceiptReport.MouseLeave
        BtnReceiptReport.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnSalaryTailors_click(sender As Object, e As EventArgs) Handles BtnSalaryTailors.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=110")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        If Not FrmTailorInvoiceCashing.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmTailorInvoiceCashing, PnlMain, BtnSalaryTailors)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnSalaryTailors_mouseenter(sender As Object, e As EventArgs) Handles BtnSalaryTailors.MouseEnter
        BtnSalaryTailors.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSalaryTailors_mouseleave(sender As Object, e As EventArgs) Handles BtnSalaryTailors.MouseLeave
        BtnSalaryTailors.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnSalarySuppliers_Click(sender As Object, e As EventArgs) Handles BtnSalarySuppliers.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=110")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        If Not FrmSupplierInvoiceCashing.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmSupplierInvoiceCashing, PnlMain, BtnSalarySuppliers)
            FrmSupplierInvoiceCashing.BtnRefresh_Click(sender, e)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnSalarySuppliers_MouseEnter(sender As Object, e As EventArgs) Handles BtnSalarySuppliers.MouseEnter
        BtnSalarySuppliers.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSalarySuppliers_MouseLeave(sender As Object, e As EventArgs) Handles BtnSalarySuppliers.MouseLeave
        BtnSalarySuppliers.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnSalaryDelivery_Click(sender As Object, e As EventArgs) Handles BtnSalaryDelivery.Click
        If Not FrmDeliveryInvoiceCashing.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmDeliveryInvoiceCashing, PnlMain, BtnSalaryDelivery)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnSalaryDelivery_MouseEnter(sender As Object, e As EventArgs) Handles BtnSalaryDelivery.MouseEnter
        BtnSalaryDelivery.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSalaryDelivery_MouseLeave(sender As Object, e As EventArgs) Handles BtnSalaryDelivery.MouseLeave
        BtnSalaryDelivery.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub PicLogo_Click(sender As Object, e As EventArgs)
        FrmAbout.Show()
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        If SwBasicData = False Then
            btnbasicdata_click(sender, e)
        End If

        BtnReports.FlatAppearance.MouseDownBackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        If SwReport = True Then
            PnlReports.Visible = True
            BtnReports.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            BtnReports.Text = "▽              المالية          "
            SwReport = False
            Exit Sub
        End If
        If SwReport = False Then
            PnlReports.Visible = False
            BtnReports.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
            BtnReports.Text = "◁              المالية          "
            SwReport = True
            For Each BB As Button In PnlReports.Controls
                If Btnclicked = True Then
                    HideFormsBtn(PnlReports, {Me.Name})
                    Btnclicked = False
                End If
            Next
            Exit Sub
        End If
    End Sub


    Private Sub SubMenuOpened()
        If SwBasicData = False Then
            BtnBasicData.PerformClick()
        End If

        If SwReport = False Then
            BtnReports.PerformClick()
        End If

    End Sub

    Private Sub frmmain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If FrmAbout.IsHandleCreated = True Then
            FrmAbout.Close()
        End If
    End Sub

    Private Sub BtnReports_MouseEnter(sender As Object, e As EventArgs) Handles BtnReports.MouseEnter
        BtnReports.FlatAppearance.MouseOverBackColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
    End Sub

    Private Sub BtnTreasury_Click(sender As Object, e As EventArgs) Handles BtnTreasury.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=144")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        If Not FrmCashAndReceipt.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmCashAndReceipt, PnlMain, BtnTreasury)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub


    Private Sub BtnTreasury_MouseEnter(sender As Object, e As EventArgs) Handles BtnTreasury.MouseEnter
        BtnTreasury.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnTreasury_MouseLeave(sender As Object, e As EventArgs) Handles BtnTreasury.MouseLeave
        BtnTreasury.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnTreasuryReceipts_Click(sender As Object, e As EventArgs) Handles BtnTreasuryReceipts.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=145")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الدخول", 0)
        '    Exit Sub
        'End If

        If Not FrmTreasuryReceiptsContainer.Visible Then
            HideFormsBtn(PnlButton, {Me.Name})
            OpenFormBtn(FrmTreasuryReceiptsContainer, PnlMain, BtnTreasuryReceipts)
            Btnclicked = True
        Else
            HideFormsBtn(PnlButton, {Me.Name})
            Btnclicked = False
        End If
    End Sub

    Private Sub BtnTreasuryReceipts_MouseEnter(sender As Object, e As EventArgs) Handles BtnTreasuryReceipts.MouseEnter
        BtnTreasuryReceipts.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnTreasuryReceipts_MouseLeave(sender As Object, e As EventArgs) Handles BtnTreasuryReceipts.MouseLeave
        BtnTreasuryReceipts.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub BtnSrvicesPrice_MouseEnter(sender As Object, e As EventArgs) Handles BtnCountry.MouseEnter
        BtnCountry.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub BtnSrvicesPrice_MouseLeave(sender As Object, e As EventArgs) Handles BtnCountry.MouseLeave
        BtnCountry.TextImageRelation = TextImageRelation.TextBeforeImage
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Application.Restart()
    End Sub


    Private Sub TxtItemStoreNum_TextChanged(sender As Object, e As EventArgs) Handles TxtItemStoreNum.TextChanged

    End Sub

    Private Sub TxtItemStoreNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemStoreNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If TxtItemStoreNum.Text.Trim = "" Then
            MsgTool("يرجى التأكد من البيانات", 0)
            TxtItemStoreNum.Focus()
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass()

        SQLQuery = " SELECT ID, Place, CustomerID From CustomerOrdersView 
                     WHERE InvoiceEndService IS NULL And OrderEndService IS NULL 
AND CustomerOrdersView.InvoceID = 	 (select InvoiceID  from InvoiceContentView  where INUM ='" & TxtItemStoreNum.Text.Trim & "' ) "
        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)
        If DSSearch.Tables(0).Rows.Count > 0 Then
            OrderID = DSSearch.Tables(0).Rows(0).Item("ID")
            'FrmOrderData.CustomerID = DSSearch.Tables(0).Rows(0).Item("CustomerID")
            'FrmOrderData.OrderNum = TxtItemStoreNum.Text.Trim
            Select Case DSSearch.Tables(0).Rows(0).Item("Place")
                Case 1
                    LblPlace.Text = "في المخزن"
                Case 2
                    LblPlace.Text = "تحت التجهيز"
                Case 3
                    LblPlace.Text = "جاهز"

                Case 4
                    LblPlace.Text = "تم البيع"

                    FrmReceipt.CIDSearch = DSSearch.Tables(0).Rows(0).Item("CustomerID")
                    FrmReceipt.ShowDialog()
            End Select
            LblPlace.Visible = True

        Else
            LblPlace.Visible = False
            MsgTool("لا يوجد قطعة بهذا الرقم", 0)
            Exit Sub
            TxtItemStoreNum.Clear()
            TxtItemStoreNum.Focus()
        End If

    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        If OrderID <= 0 Then Exit Sub
        Dim ItemPlace As Integer = DSSearch.Tables(0).Rows(0).Item("Place")
        If ItemPlace = 1 Then
            Operation = "Send"

        ElseIf ItemPlace = 2 Then
            Operation = "Receive"

        ElseIf ItemPlace = 3 Then
            Operation = "Sell"

        ElseIf ItemPlace = 4 Then
            MsgTool("تم تسليم الطلب للزبون ", 1)
            Exit Sub
        End If
        FrmOrderData.OrderID = OrderID
        FrmOrderData.CustomerID = DSSearch.Tables(0).Rows(0).Item("CustomerID")
        FrmOrderData.OrderNum = TxtItemStoreNum.Text.Trim
        FrmOrderData.ShowDialog()
        BtnSearch_Click(sender, e)

        'Dim SQLCon = New SQLConClass

        'Dim Param() As SqlParameter = {
        'New SqlParameter("@ID", OrderID),
        'New SqlParameter("@Operation", Operation)}

        'Dim DS As DataSet = SQLCon.CMDExecuteData("MoveOrder", Param)

        'If Save = 1 Then
        '    Select Case Operation

        '        Case = "Send"
        '            MsgTool("تم ارسال الطلب للخياط ", 1)

        '        Case = "Receive"
        '            MsgTool("تم استلام الطلب من الخياط ", 1)

        '        Case = "Sell"
        '            MsgTool("تم تسليم الطلب للزبون ", 1)

        '    End Select
        'End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        TxtItemStoreNum.Clear()
        LblPlace.Text = ""
        LblPlace.Visible = False
        OrderID = 0
    End Sub

    Private Sub TxtInvoNum_TextChanged(sender As Object, e As EventArgs) Handles TxtInvoNum.TextChanged

    End Sub

    Private Sub TxtInvoNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtInvoNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearchDelivery_Click(sender, e)
        End If
    End Sub

    Private Sub BtnSearchDelivery_Click(sender As Object, e As EventArgs) Handles BtnSearchDelivery.Click
        If TxtInvoNum.Text.Trim = "" Then
            MsgTool("يرجى التأكد من البيانات", 0)
            TxtInvoNum.Focus()
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass()

        SQLQuery = " SELECT ID, Num, RegDate, DeliveryDate, CustomerID From DeliveryOrderView 
                    WHERE InvoiceEndService IS NULL And OrderEndService IS NULL AND Num='" & TxtInvoNum.Text.Trim & "'"

        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSSearch) Then
            Dim DeliveryCustomerID As Integer

            If DSSearch.Tables(0).Rows.Count > 0 Then

                InvoID = DSSearch.Tables(0).Rows(0).Item("ID")
                DeliveryCustomerID = DSSearch.Tables(0).Rows(0).Item("CustomerID")
                If IsDBNull(DSSearch.Tables(0).Rows(0).Item("RegDate")) Then
                    LblDeliveryPlace.Text = "في المخزن"

                ElseIf (Not IsDBNull(DSSearch.Tables(0).Rows(0).Item("RegDate"))) And (IsDBNull(DSSearch.Tables(0).Rows(0).Item("DeliveryDate"))) Then
                    LblDeliveryPlace.Text = "في الشحن"

                ElseIf Not IsDBNull(DSSearch.Tables(0).Rows(0).Item("DeliveryDate")) Then
                    LblDeliveryPlace.Text = "تم التسليم"

                    FrmReceipt.CIDSearch = DeliveryCustomerID
                    FrmReceipt.ShowDialog()
                End If

                LblDeliveryPlace.Visible = True

            Else
                LblDeliveryPlace.Visible = False
                MsgTool("لا يوجد فاتورة توصيل بهذا الرقم", 0)
                TxtInvoNum.SelectAll()
                TxtInvoNum.Focus()
                DeliveryCustomerID = 0
                Exit Sub
            End If

        Else
            LblDeliveryPlace.Visible = False
            MsgTool("لا يوجد فاتورة توصيل بهذا الرقم", 0)
            Exit Sub
            TxtInvoNum.Clear()
            TxtInvoNum.Focus()
        End If

    End Sub

    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles BtnDelivery.Click

        If InvoID <= 0 Then Exit Sub
        Dim DeliveryOrder As Integer

        If IsDBNull(DSSearch.Tables(0).Rows(0).Item("RegDate")) Then
            Operation = "Send"
            DeliveryOrder = 2

        ElseIf (Not IsDBNull(DSSearch.Tables(0).Rows(0).Item("RegDate"))) And (IsDBNull(DSSearch.Tables(0).Rows(0).Item("DeliveryDate"))) Then
            Operation = "Sell"
            DeliveryOrder = 3

        ElseIf Not IsDBNull(DSSearch.Tables(0).Rows(0).Item("DeliveryDate")) Then
            MsgTool("تم تسليم الطلب للزبون ", 1)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass

        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", InvoID),
        New SqlParameter("@Operation", Operation)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("DeliveryOrder", Param)

        If DeliveryOrder = 2 Then
            MsgTool("الطلب في الشحن", 1)

        ElseIf DeliveryOrder = 3 Then
            MsgTool("تم التسليم ", 1)

        End If

        BtnSearchDelivery_Click(sender, e)
    End Sub

    Private Sub BtnRefreshDelivery_Click(sender As Object, e As EventArgs) Handles BtnRefreshDelivery.Click
        TxtInvoNum.Clear()
        LblDeliveryPlace.Text = ""
        LblDeliveryPlace.Visible = False
        InvoID = 0

    End Sub

End Class
