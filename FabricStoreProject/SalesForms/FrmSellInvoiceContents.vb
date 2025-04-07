Imports System.ComponentModel

Public Class FrmSellInvoiceContents


    Private Ds As DataSet
    Public SellID As Integer

    Private Sub FrmSellInvoiceContents_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub FrmSellInvoiceContents_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(Ds) Then
            Ds.Clear()
        End If

        TxtSumValue.Text = "0"
        TxtInvoNum.Text = ""
        TxtStore.Text = ""
        TxtUserName.Text = ""
        Dispose()
    End Sub

    Private Sub GetData()
        If SellID = 0 Then Exit Sub
        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select * From InvoiceContentView where InvoiceID=" & SellID
        SQLQuery &= " Select Total, Num,CustomersTable.Name, UserView.Name UserName  From InvoceTable ,CustomersTable  ,
                UserView where CustomersTable.ID=CustomerID  And UserView.ID=  InvoceTable.UserID  AND  InvoceTable.ID=" & SellID
        Ds = sqlcon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then
            FillDGV()
            TxtUserName.Text = Ds.Tables(1).Rows(0).Item("UserName")
            TxtStore.Text = Ds.Tables(1).Rows(0).Item("Name")
            If Val(Ds.Tables(1).Rows(0).Item("Total")) > 0 Then
                TxtSumValue.Text = Format(Ds.Tables(1).Rows(0).Item("Total"), "0.000")

            Else
                TxtSumValue.Text = "0"
            End If

            TxtInvoNum.Text = Format(Ds.Tables(1).Rows(0).Item("Num"), "000000")
            LblTitel.Text = LblTitel.Text + "-" + TxtInvoNum.Text
        End If
    End Sub

    Private Sub FillDGV()
        DGVInvoContent.Rows.Clear()
        For i = 0 To Ds.Tables(0).Rows.Count - 1
            With Ds.Tables(0).Rows(i)

                DGVInvoContent.Rows.Add()
                DGVInvoContent.Item(0, i).Value = i + 1
                DGVInvoContent.Item(1, i).Value = .Item("ItemName")
                DGVInvoContent.Item(2, i).Value = Format(.Item("Price"), "0.000")
                DGVInvoContent.Item(3, i).Value = .Item("Quantity")
                DGVInvoContent.Item(4, i).Value = Format(.Item("Total"), "0.000")
                If .Item("ItemType") = "Fabric" Then
                    DGVInvoContent.Item(5, i).Value = "قماش"

                Else
                    DGVInvoContent.Item(5, i).Value = "ملابس"
                End If
                'DGVInvoContent.Item(5, i).Value = .Item("ItemType")
                DGVInvoContent.Item(6, i).Value = .Item("Num")
                DGVInvoContent.Item(7, i).Value = .Item("ServiceName")
                DGVInvoContent.Item(8, i).Value = .Item("TailorName")
                DGVInvoContent.Item(9, i).Value = .Item("Size")
                DGVInvoContent.Item(10, i).Value = .Item("DeliveryDate")

                If IsDBNull(.Item("Place")) Then
                    DGVInvoContent.Item(11, i).Value = ""

                ElseIf .Item("Place") = "1" Then
                    DGVInvoContent.Item(11, i).Value = "في المخزن"

                ElseIf .Item("Place") = "2" Then
                    DGVInvoContent.Item(11, i).Value = "تحت التجهيز"

                ElseIf .Item("Place") = "3" Then
                    DGVInvoContent.Item(11, i).Value = "جاهز"

                ElseIf .Item("Place") = "4" Then
                    DGVInvoContent.Item(11, i).Value = "تم البيع"

                End If
            End With
        Next
        DGVInvoContent.ClearSelection()
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub PnlTitel_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseDown, LblTitel.MouseDown
        If e.Button = MouseButtons.Left Then
            SW = True
            Pos = e.Location
        End If
    End Sub

    Private Sub PnlTitel_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseMove, LblTitel.MouseMove
        If SW Then
            Me.Location += e.Location - Pos
        End If
    End Sub

    Private Sub PnlTitel_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseUp, LblTitel.MouseUp
        If e.Button = MouseButtons.Left Then
            SW = False
        End If
    End Sub

End Class