Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class FrmOrderData
    Private DSSearch As New DataSet


    Public OrderNum, Operation As String
    Public OrderID, ItemPlace, CustomerID As Integer



    Private Sub FrmOrderData_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub GetData()
        Dim SQLCon = New SQLConClass()
        Dim Param() As SqlParameter =
                    {New SqlParameter("@ItemStoreNum", OrderNum),
                    New SqlParameter("@CustomerID", CustomerID)}
        SQLQuery = " SELECT * From CustomerOrdersView WHERE CustomerOrdersView.INum= '" & OrderNum & "'"
        SQLQuery &= " Select ID,Name From TailorsTable where EndService IS NUll Order By Name  "
        SQLQuery &= " Select * From ServicesTable  Order By Name  "
        SQLQuery += "  Select * From CustomerSizesTable Where CustomerID = " & CustomerID

        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSSearch) Then
            FillData()

            If DSSearch.Tables(0).Rows.Count > 0 Then
                With DSSearch.Tables(0).Rows(0)
                    OrderID = .Item("ID")
                    LblCustomerName.Text = .Item("CustomerName")
                    'CustomerID = .Item("CustomerID")

                    CleanSizes()

                    TxtSize.Text = .Item("Size")
                    TxtTailorPrice.Text = .Item("TailorPrice")

                    If Not IsNothing(.Item("ServiceID")) Then
                        CmbServiceOrder.SelectedValue = .Item("ServiceID")
                    End If

                    If Not IsNothing(.Item("customerSizeID")) Then
                        CmbSizeName.SelectedValue = .Item("customerSizeID")
                        TxtSizeName.Text = CmbSizeName.Text
                    End If


                    If Not IsNothing(.Item("TailorID")) Then
                        CmbTailorOrder.SelectedValue = .Item("TailorID")
                    End If

                    If Not IsDBNull(.Item("Armpit")) Then
                        TxtArmpit.Text = .Item("Armpit")
                    End If
                    If Not IsDBNull(.Item("Chest")) Then
                        TxtChest.Text = .Item("Chest")
                    End If
                    If Not IsDBNull(.Item("Height")) Then
                        TxtHeight.Text = .Item("Height")
                    End If
                    If Not IsDBNull(.Item("Hip")) Then
                        TxtHip.Text = .Item("Hip")
                    End If
                    If Not IsDBNull(.Item("Shoulder")) Then
                        TxtShoulder.Text = .Item("Shoulder")
                    End If
                    If Not IsDBNull(.Item("Sleeve")) Then
                        TxtSleeve.Text = .Item("Sleeve")
                    End If
                    If Not IsDBNull(.Item("Waist")) Then
                        TxtWaist.Text = .Item("Waist")
                    End If
                End With

                If DSSearch.Tables(0).Rows(0).Item("place") = 1 Then
                    BtnSave.Enabled = True
                    BtnSend.Enabled = True
                    BtnReceive.Enabled = False
                    BtnSell.Enabled = False

                ElseIf DSSearch.Tables(0).Rows(0).Item("place") = 2 Then
                    BtnSave.Enabled = False
                    BtnSend.Enabled = False
                    BtnReceive.Enabled = True
                    BtnSell.Enabled = False

                ElseIf DSSearch.Tables(0).Rows(0).Item("place") = 3 Then
                    BtnSave.Enabled = False
                    BtnSend.Enabled = False
                    BtnReceive.Enabled = False
                    BtnSell.Enabled = True
                End If
            End If

        End If
    End Sub

    Private Sub CleanSizes()
        TxtSizeName.Text = ""
        TxtHeight.Text = ""
        TxtShoulder.Text = ""
        TxtSleeve.Text = ""
        TxtArmpit.Text = ""
        TxtChest.Text = ""
        TxtWaist.Text = ""
        TxtHip.Text = ""
    End Sub

    Private Sub FillData()

        If DSSearch.Tables(1).Rows.Count > 0 Then
            CmbTailorOrder.DataSource = DSSearch.Tables(1)
            CmbTailorOrder.DisplayMember = "Name"
            CmbTailorOrder.ValueMember = "ID"
            CmbTailorOrder.SelectedIndex = -1

        Else
            CmbTailorOrder.DisplayMember = Nothing
            CmbTailorOrder.Text = ""

        End If

        If DSSearch.Tables(2).Rows.Count > 0 Then
            CmbServiceOrder.DataSource = DSSearch.Tables(2)
            CmbServiceOrder.DisplayMember = "Name"
            CmbServiceOrder.ValueMember = "ID"
            CmbServiceOrder.SelectedIndex = -1

        Else
            CmbServiceOrder.DisplayMember = Nothing
            CmbServiceOrder.Text = ""

        End If

        If DSSearch.Tables(3).Rows.Count > 0 Then
            CmbSizeName.DataSource = DSSearch.Tables(3)
            CmbSizeName.DisplayMember = "Name"
            CmbSizeName.ValueMember = "ID"
            CmbSizeName.SelectedIndex = -1

        Else
            CmbSizeName.DisplayMember = Nothing
            CmbSizeName.Text = ""

        End If
    End Sub

    Private Sub CmbSizeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSizeName.SelectedIndexChanged

    End Sub

    Private Sub CmbSizeName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSizeName.SelectionChangeCommitted
        CleanSizes()
        If CmbSizeName.SelectedValue Is Nothing Or CmbSizeName.SelectedValue = -1 Then Exit Sub

        Dim ItemRow() As DataRow = DSSearch.Tables(3).Select("ID=" & CmbSizeName.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        If Not IsDBNull(ItemRow(0)("Name")) Then TxtSizeName.Text = ItemRow(0)("Name")
        If Not IsDBNull(ItemRow(0)("Height")) Then TxtHeight.Text = ItemRow(0)("Height")
        If Not IsDBNull(ItemRow(0)("Shoulder")) Then TxtShoulder.Text = ItemRow(0)("Shoulder")
        If Not IsDBNull(ItemRow(0)("Sleeve")) Then TxtSleeve.Text = ItemRow(0)("Sleeve")
        If Not IsDBNull(ItemRow(0)("Armpit")) Then TxtArmpit.Text = ItemRow(0)("Armpit")
        If Not IsDBNull(ItemRow(0)("Chest")) Then TxtChest.Text = ItemRow(0)("Chest")
        If Not IsDBNull(ItemRow(0)("Waist")) Then TxtWaist.Text = ItemRow(0)("Waist")
        If Not IsDBNull(ItemRow(0)("Hip")) Then TxtHip.Text = ItemRow(0)("Hip")
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Operation = "Send"
        EditOrder()
    End Sub

    Private Sub BtnReceive_Click(sender As Object, e As EventArgs) Handles BtnReceive.Click
        Operation = "Receive"
        EditOrder()
    End Sub

    Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
        Operation = "Sell"
        EditOrder()

        FrmReceipt.CIDSearch = CustomerID
        FrmReceipt.ShowDialog()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Operation = "Edit"
        EditOrder()
    End Sub

    Private Sub EditOrder()
        Dim TailorID As Integer = 0
        Dim ServiceID As Integer = 0
        Dim TailorPrice As Double = 0
        Dim Size As String = ""
        Dim Armpit As Double = 0
        Dim Chest As Double = 0
        Dim CusHeight As Double = 0
        Dim Hip As Double = 0
        Dim Shoulder As Double = 0
        Dim Sleeve As Double = 0
        Dim Waist As Double = 0

        If Not IsNothing(CmbTailorOrder.SelectedValue) Then
            TailorID = CmbTailorOrder.SelectedValue
        End If

        If Not IsNothing(CmbServiceOrder.SelectedValue) Then
            ServiceID = CmbServiceOrder.SelectedValue
        End If

        If TxtSize.Text <> "" Then
            Size = TxtSize.Text.Trim
        End If
        TailorPrice = Val(TxtTailorPrice.Text)

        If TxtArmpit.Text <> "" Then
            Armpit = Val(TxtArmpit.Text.Trim)
        End If
        If TxtChest.Text <> "" Then
            Chest = Val(TxtChest.Text.Trim)
        End If
        If TxtHeight.Text <> "" Then
            CusHeight = Val(TxtHeight.Text.Trim)
        End If
        If TxtHip.Text <> "" Then
            Hip = Val(TxtHip.Text.Trim)
        End If
        If TxtShoulder.Text <> "" Then
            Shoulder = Val(TxtShoulder.Text.Trim)
        End If
        If TxtSleeve.Text <> "" Then
            Sleeve = Val(TxtSleeve.Text.Trim)
        End If
        If TxtWaist.Text <> "" Then
            Waist = Val(TxtWaist.Text.Trim)
        End If

        'If (TailorID = 0 Or ServiceID = 0 Or TailorPrice = 0 Or Size = "") And Operation = "Edit" Then
        '    MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
        '    Exit Sub
        'End If

        'If (TailorID = 0 Or ServiceID = 0 Or TailorPrice = 0 Or Size = "") And Operation = "Send" Then
        '    MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
        '    Exit Sub
        'End If

        If OrderID <= 0 Then Exit Sub
        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", OrderID),
        New SqlParameter("@Operation", Operation),
        New SqlParameter("@TailorID", TailorID),
        New SqlParameter("@ServiceID", ServiceID),
        New SqlParameter("@Price", TailorPrice),
        New SqlParameter("@Size", Size),
        New SqlParameter("@Height", CusHeight),
        New SqlParameter("@Shoulder", Shoulder),
        New SqlParameter("@Sleeve", Sleeve),
        New SqlParameter("@Armpit", Armpit),
        New SqlParameter("@Chest", Chest),
        New SqlParameter("@Waist", Waist),
        New SqlParameter("@Hip", Hip),
        New SqlParameter("@ChkCustomer", ChkCustomerPrice.Checked)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("EditOrder", Param)
        Select Case Operation
            Case = "Edit"
                MsgTool("تم تعديل بيانات الطلب  ", 1)

            Case = "Send"
                MsgTool("تم ارسال الطلب للخياط  (" & CmbTailorOrder.Text & " ) ", 1)

            Case = "Receive"
                MsgTool("تم استلام الطلب من الخياط ", 1)

            Case = "Sell"
                MsgTool("تم تسليم الطلب للزبون ", 1)


        End Select
        'BtnSearch.PerformClick()
        'TLPOrderDetails.Visible = False
        'Clear(TLPOrder)
    End Sub

    Private Sub CmbTailorOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbTailorOrder.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbServiceOrder.Focus()
        End If
    End Sub

    Private Sub CmbServiceOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbServiceOrder.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSize.Focus()
        End If
    End Sub

    Private Sub TxtSize_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTailorPrice.Focus()
        End If
    End Sub

    Private Sub TxtTailorPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTailorPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtTailorPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTailorPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbSizeName.Focus()
        End If
    End Sub

    Private Sub CmbSizeName_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbSizeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSizeName.Focus()
        End If
    End Sub

    Private Sub TxtSizeName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSizeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHeight.Focus()
        End If
    End Sub

    Private Sub TxtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHeight.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtShoulder.Focus()
        End If
    End Sub

    Private Sub TxtShoulder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtShoulder.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtShoulder_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShoulder.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSleeve.Focus()
        End If
    End Sub

    Private Sub TxtSleeve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSleeve.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtSleeve_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSleeve.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtArmpit.Focus()
        End If
    End Sub

    Private Sub TxtArmpit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArmpit.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtArmpit_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArmpit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtChest.Focus()
        End If
    End Sub

    Private Sub TxtChest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChest.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtChest_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChest.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtWaist.Focus()
        End If
    End Sub

    Private Sub TxtWaist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtWaist.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtWaist_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWaist.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHip.Focus()
        End If
    End Sub

    Private Sub TxtHip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHip.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHip_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHip.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub FrmOrderData_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Clear(TLPOrder)
        Dispose()
    End Sub

    Private Sub PnlEditOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseDown, LblOrderData.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub CmbTailorOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTailorOrder.SelectedIndexChanged

    End Sub

    Private Sub PnlEditOrder_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseMove, LblOrderData.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub TxtArmpit_TextChanged(sender As Object, e As EventArgs) Handles TxtArmpit.TextChanged

    End Sub

    Private Sub CmbServiceOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServiceOrder.SelectedIndexChanged

    End Sub

    Private Sub PnlEditOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseUp, LblOrderData.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

End Class