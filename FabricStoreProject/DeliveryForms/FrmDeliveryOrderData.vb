Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class FrmDeliveryOrderData
    Private DSSearch As New DataSet
    Public OrderID As Integer
    Private Operation As String


    Private Sub PnlEditOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseDown, Label1.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlEditOrder_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseMove, Label1.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlEditOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseUp, Label1.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FrmDeliveryOrderData_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub GetData()
        Dim SQLCon = New SQLConClass()
        Dim Param() As SqlParameter =
                    {New SqlParameter("@ID", OrderID)}
        SQLQuery = " Select ID,Name From DeliveryTable  Order By Name  "
        SQLQuery &= " Select * From CityTable  Order By Name  "
        SQLQuery += " SELECT  ID, DeliveryID, CityID, Address, Price, Phone From DeliveryOrderView WHERE ID = @ID"

        DSSearch = SQLCon.SelectData(SQLQuery, 0, param)
        If DSHasTables(DSSearch) Then
            FillData(DSSearch)

        End If
    End Sub

    Private Sub FillData(DS As DataSet)

        If DSSearch.Tables(0).Rows.Count > 0 Then
            CmbDeliveryOrder.DataSource = DS.Tables(0)
            CmbDeliveryOrder.DisplayMember = "Name"
            CmbDeliveryOrder.ValueMember = "ID"
            'CmbDeliveryOrder.SelectedIndex = -1

        Else
            CmbDeliveryOrder.DataSource = Nothing
        End If

        If DSSearch.Tables(1).Rows.Count > 0 Then
            CmbCityOrder.DataSource = DS.Tables(1)
            CmbCityOrder.DisplayMember = "Name"
            CmbCityOrder.ValueMember = "ID"
            'CmbCityOrder.SelectedIndex = -1

        Else
            CmbCityOrder.DataSource = Nothing
        End If

        If DSSearch.Tables(2).Rows.Count > 0 Then
            With DSSearch.Tables(2).Rows(0)
                If Not IsDBNull(.Item("CityID")) Then
                    CmbCityOrder.SelectedValue = .Item("CityID")
                End If

                If Not IsDBNull(.Item("DeliveryID")) Then
                    CmbDeliveryOrder.SelectedValue = .Item("DeliveryID")
                End If
                TxtAddress.Text = .Item("Address").ToString
                TxtDeliveryPrice.Text = .Item("Price").ToString
                TxtPhone.Text = .Item("Phone").ToString
            End With

        Else
            Clear(TLPDeliveryData)
            MsgTool("لا يوجد طلب توصيل لهذه الفاتورة", 0)
        End If
    End Sub

    Private Sub FrmDeliveryOrderData_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Clear(TLPDeliveryData)
        Dispose()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
        Operation = "Send"
        EditOrder()
    End Sub

    Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
        Operation = "Sell"
        EditOrder()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Operation = "Edit"
        EditOrder()
    End Sub

    Private Sub EditOrder()
        Dim DeliveryID As Integer = 0
        Dim CityID As Integer = 0
        Dim DeliveryPrice As Double = 0
        Dim Address As String = ""
        Dim Phone As String = ""

        If Not IsNothing(CmbDeliveryOrder.SelectedValue) Then
            DeliveryID = CmbDeliveryOrder.SelectedValue
        End If

        If Not IsNothing(CmbCityOrder.SelectedValue) Then
            CityID = CmbCityOrder.SelectedValue
        End If

        If TxtAddress.Text <> "" Then
            Address = TxtAddress.Text.Trim
        End If
        DeliveryPrice = Val(TxtDeliveryPrice.Text)

        Phone = TxtPhone.Text.Trim

        If (DeliveryID = 0 Or CityID = 0 Or DeliveryPrice = 0 Or Address = "" Or Phone = "") And Operation = "Edit" Then
            MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
            Exit Sub
        End If

        If (DeliveryID = 0 Or CityID = 0 Or DeliveryPrice = 0 Or Address = "" Or Phone = "") And Operation = "Send" Then
            MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
            Exit Sub
        End If

        If OrderID <= 0 Then Exit Sub
        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", OrderID),
        New SqlParameter("@Operation", Operation),
        New SqlParameter("@DeliveryID", DeliveryID),
        New SqlParameter("@CityID", CityID),
        New SqlParameter("@DeliveryPrice", DeliveryPrice),
        New SqlParameter("@Phone", Phone),
        New SqlParameter("@Address", Address)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("EditDeliveryOrder", Param)
        Select Case Operation
            Case = "Edit"
                MsgTool("تم تعديل بيانات الطلب  ", 1)

            Case = "Sell"
                MsgTool("تم تسليم الطلب للزبون ", 1)


        End Select
        'TLPOrderDetails.Visible = False
        'Clear(TLPDeliveryData)
    End Sub

    Private Sub CmbDeliveryOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDeliveryOrder.SelectedIndexChanged

    End Sub

    Private Sub CmbDeliveryOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbDeliveryOrder.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCityOrder.Focus()
        End If
    End Sub

    Private Sub CmbCityOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbCityOrder.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        End If
    End Sub

    Private Sub TxtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDeliveryPrice.Focus()
        End If
    End Sub

    Private Sub TxtDeliveryPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDeliveryPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPhone.Focus()
        End If
    End Sub

    Private Sub TxtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(sender, e)
        End If
    End Sub
End Class