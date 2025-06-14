Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows
Imports TwainLib

Public Class FrmColor
    Private Dark, Primary, Light As Color
    Private DSDataBases As New DataSet
    Private NewCon As Boolean = True

    Private Sub FrmColor_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetFillSettings()
    End Sub

    Private Sub FrmColor_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DSDataBases) Then
            DSDataBases.Clear()
        End If

        Dispose()
    End Sub

    'Public Sub ChangeColor()
    '    ChangeSystemColors(Me)
    'End Sub
    Private Sub GetFillSettings()
        Dim SystemColors As String = Settings.GetSettings(ClassSettings.Setting.SystemColors)

        If SystemColors = "Blue" Then
            Checked(BtnBlue, GrpColor)
            BtnBlue.Text = "✔️"

        ElseIf SystemColors = "Green" Then
            Checked(BtnGreen, GrpColor)
            BtnGreen.Text = "✔️"

        ElseIf SystemColors = "Black" Then
            Checked(BtnBlack, GrpColor)
            BtnBlack.Text = "✔️"

        ElseIf SystemColors = "Purple" Then
            Checked(BtnPurple, GrpColor)
            BtnPurple.Text = "✔️"

        ElseIf SystemColors = "Gray" Then
            Checked(BtnGray, GrpColor)
            BtnGray.Text = "✔️"

        ElseIf SystemColors = "Pink" Then
            Checked(BtnPink, GrpColor)
            BtnPink.Text = "✔️"

        ElseIf SystemColors = "PurpleDark" Then
            Checked(BtnPurpleDark, GrpColor)
            BtnPurpleDark.Text = "✔️"

        ElseIf SystemColors = "Brown" Then
            Checked(BtnBrown, GrpColor)
            BtnBrown.Text = "✔️"

        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

    Public Sub ChangeAllFormsColors()
        Frmmain.BtnExpenses.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Frmmain.BtnEmployees.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Frmmain.BtnEmployees.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Frmmain.BtnBasicData.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Frmmain.BtnReports.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)

        'Frmmain.BtnStores.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorDark)



        'EmployeeForms:
        FrmEmployeeContainr.ChangeColor()
        FrmEmployeesData.ChangeColor()
        FrmEmployeesReport.ChangeColor()



        'CustomerForms:
        FrmCustomerContainr.ChangeColor()
        FrmCustomers.ChangeColor()
        FrmCustomerReport.ChangeColor()


        FrmPreparingClothesReport.ChangeColor()
        'TailorForms:
        FrmTailorContainr.ChangeColor()
        FrmTailors.ChangeColor()
        FrmTailorReport.ChangeColor()
        FrmTailorInvoiceCashing.ChangeColor()

        'FrmDeliveryCo
        FrmDeliveryCo.ChangeColor()
        FrmDeliveryContainr.ChangeColor()
        FrmDeliveryReport.ChangeColor()
        FrmDeliveryOrder.ChangeColor()
        FrmDeliveryInvoiceCashing.ChangeColor()

        'SupplierForms:
        FrmSupplierInvoiceCashing.ChangeColor()
        FrmSuppleirContainer.ChangeColor()
        FrmSuppleir.ChangeColor()
        FrmSuppleirReport.ChangeColor()

        FrmCashAndReceipt.ChangeColor()

        'ItemForms:
        FrmStoreContainer.ChangeColor()
        FrmStore.ChangeColor()
        FrmAddItem.ChangeColor()
        FrmItemReport.ChangeColor()

        ' PurchasesForms
        FrmPurchasesContainer.ChangeColor()
        FrmPurchasesReport.ChangeColor()
        FrmPurchasesInvoices.ChangeColor()

        'ExpensesForms
        FrmMangmentExpensesContainer.ChangeColor()
        FrmMangmentExpenses.ChangeColor()
        FrmMangmentExpensesReport.ChangeColor()

        'FrmReceipt
        FrmCashingReport.ChangeColor()
        FrmReceiptContainer.ChangeColor()
        FrmReceiptReport.ChangeColor()


        'SalesForms:
        FrmSales.ChangeColor()
        FrmSalesContainer.ChangeColor()
        FrmSalesReport.ChangeColor()
        FrmCustomerInvoiceReceipt.ChangeColor()
        FrmCustomerOrders.ChangeColor()
        FrmPreparingClothes.ChangeColor()
        'SystemForms:
        FrmBackupSettings.ChangeColor()
        FrmCenterInfoSettings.ChangeColor()

        FrmMainSafeReport.ChangeColor()

        'FrmMain.ChangeColor()
        FrmSettingsContainer.ChangeColor()

        'UserManagementForms:
        FrmUserManagement.ChangeColor()


        'FrmTreasuryReceiptsContainer
        FrmTreasury.ChangeColor()
        FrmTreasuryReceiptsContainer.ChangeColor()
        FrmEmployeeCashing.ChangeColor()
        FrmEmployeeReceipt.ChangeColor()
        FrmEmployeeCashingReport.ChangeColor()

        'SafeForms
        'FrmSafe.ChangeColor()
        'FrmMainSafeReport.ChangeColor()
        'FrmMainSafeContainer.ChangeColor()
        'FrmShowMainSafe.ChangeColor()

    End Sub

    Private Sub PnlTitel_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseDown, LblTitel.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlTitel_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseMove, LblTitel.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlTitel_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseUp, LblTitel.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub BtnBlue_Click(sender As Object, e As EventArgs) Handles BtnBlue.Click
        Checked(BtnBlue, GrpColor)
        If BtnBlue.Text = "" Then
            BtnBlue.Text = "✔️"
        Else
            BtnBlue.Text = ""
        End If

        SerColor(Color.FromArgb(59, 79, 129), Color.FromArgb(93, 107, 153), Color.FromArgb(204, 213, 240))
        'SerColor(ColorTranslator.FromHtml("#001970"), ColorTranslator.FromHtml("#303f9f"), ColorTranslator.FromHtml("#7F98EF"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnGreen_Click(sender As Object, e As EventArgs) Handles BtnGreen.Click
        Checked(BtnGreen, GrpColor)
        If BtnGreen.Text = "" Then
            BtnGreen.Text = "✔️"
        Else
            BtnGreen.Text = ""
        End If
        SerColor(ColorTranslator.FromHtml("#005662"), ColorTranslator.FromHtml("#00838f"), ColorTranslator.FromHtml("#7FD5E1"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnBlack_Click(sender As Object, e As EventArgs) Handles BtnBlack.Click
        Checked(BtnBlack, GrpColor)
        If BtnBlack.Text = "" Then
            BtnBlack.Text = "✔️"
        Else
            BtnBlack.Text = ""
        End If
        SerColor(Color.FromArgb(38, 50, 56), Color.FromArgb(55, 71, 79), ColorTranslator.FromHtml("#A5B1B7"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnPurple_Click(sender As Object, e As EventArgs) Handles BtnPurple.Click
        Checked(BtnPurple, GrpColor)
        If BtnPurple.Text = "" Then
            BtnPurple.Text = "✔️"
        Else
            BtnPurple.Text = ""
        End If
        SerColor(Color.FromArgb(95, 75, 17), Color.FromArgb(139, 115, 23), Color.FromArgb(185, 154, 36))
        ' SerColor(ColorTranslator.FromHtml("#12005e"), ColorTranslator.FromHtml("#4a148c"), ColorTranslator.FromHtml("#917FDD"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnGray_Click(sender As Object, e As EventArgs) Handles BtnGray.Click
        Checked(BtnGray, GrpColor)
        If BtnGray.Text = "" Then
            BtnGray.Text = "✔️"
        Else
            BtnGray.Text = ""
        End If
        SerColor(ColorTranslator.FromHtml("#29434e"), ColorTranslator.FromHtml("#546e7a"), ColorTranslator.FromHtml("#A8C2CD"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnPink_Click(sender As Object, e As EventArgs) Handles BtnPink.Click
        Checked(BtnPink, GrpColor)
        If BtnPink.Text = "" Then
            BtnPink.Text = "✔️"
        Else
            BtnPink.Text = ""
        End If
        SerColor(Color.FromArgb(140, 47, 49), Color.FromArgb(164, 55, 58), Color.FromArgb(199, 86, 89))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnPurpleDark_Click(sender As Object, e As EventArgs) Handles BtnPurpleDark.Click
        Checked(BtnPurpleDark, GrpColor)
        If BtnPurpleDark.Text = "" Then
            BtnPurpleDark.Text = "✔️"
        Else
            BtnPurpleDark.Text = ""
        End If
        SerColor(ColorTranslator.FromHtml("#560027"), ColorTranslator.FromHtml("#880e4f"), ColorTranslator.FromHtml("#D57FA6"))
        ChangeAllFormsColors()
    End Sub

    Private Sub BtnBrown_Click(sender As Object, e As EventArgs) Handles BtnBrown.Click
        Checked(BtnBrown, GrpColor)
        If BtnBrown.Text = "" Then
            BtnBrown.Text = "✔️"
        Else
            BtnBrown.Text = ""
        End If

        SerColor(Color.FromArgb(139, 103, 102), Color.FromArgb(182, 136, 136), Color.FromArgb(199, 151, 151))
        ChangeAllFormsColors()
    End Sub

    Private Sub Checked(Obj As Button, Container As Object)
        Dim Btn As Button = Nothing
        Dim Pnl As Panel = Nothing

        For Each C As Control In Container.Controls
            If TypeOf C Is Button Then
                Btn = DirectCast(C, Button)
                Btn.Text = ""
            End If

            If TypeOf C Is Panel Then
                Pnl = DirectCast(C, Panel)
                Checked(Obj, Pnl)
            End If
        Next

    End Sub

    Private Sub SerColor(DarkColor As Color, PrimaryColor As Color, LightColor As Color)
        Dim SystemColor As String = ""

        If BtnBlue.Text <> "" Then
            SystemColor = "Blue"

        ElseIf BtnGreen.Text <> "" Then
            SystemColor = "Green"

        ElseIf BtnBlack.Text <> "" Then
            SystemColor = "Black"

        ElseIf BtnPurple.Text <> "" Then
            SystemColor = "Purple"

        ElseIf BtnGray.Text <> "" Then
            SystemColor = "Gray"

        ElseIf BtnPink.Text <> "" Then
            SystemColor = "Pink"

        ElseIf BtnPurpleDark.Text <> "" Then
            SystemColor = "PurpleDark"

        ElseIf BtnBrown.Text <> "" Then
            SystemColor = "Brown"
        End If

        If NewCon = True Then
            Settings.SaveSettings(SystemColor, ClassSettings.Setting.SystemColors)
            Settings.SaveSettings(DarkColor, ClassSettings.Setting.ColorDark)
            Settings.SaveSettings(PrimaryColor, ClassSettings.Setting.ColorPrimary)
            Settings.SaveSettings(LightColor, ClassSettings.Setting.ColorLight)
            ChangeSystemColors(Me)
            ChangeSystemColors(Frmmain)

            MsgTool("تم حفظ الإعدادات", 1)
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

        Else

            MsgTool("لا يمكن حفظ الإعدادات خطأ في الإتصال", 0)
        End If
    End Sub

End Class