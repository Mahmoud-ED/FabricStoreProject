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
                TxtSumValue.Text = Format(Ds.Tables(1).Rows(0).Item("Total"), "0.00")

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
                DGVInvoContent.Item(1, i).Value = .Item("INum")
                DGVInvoContent.Item(2, i).Value = .Item("ItemName")
                DGVInvoContent.Item(3, i).Value = Format(.Item("Price"), "0.00")
                DGVInvoContent.Item(4, i).Value = .Item("Quantity")
                DGVInvoContent.Item(5, i).Value = Format(.Item("Total"), "0.00")
                If .Item("ItemType") = "Fabric" Then
                    DGVInvoContent.Item(6, i).Value = "قماش"

                Else
                    DGVInvoContent.Item(6, i).Value = "ملابس"
                End If
                DGVInvoContent.Item(7, i).Value = .Item("Num_Tailor")
                DGVInvoContent.Item(8, i).Value = .Item("ServiceName")
                DGVInvoContent.Item(9, i).Value = .Item("TailorName")
                DGVInvoContent.Item(10, i).Value = .Item("Size")
                DGVInvoContent.Item(11, i).Value = .Item("DeliveryDate")

                If IsDBNull(.Item("Place")) Then
                    DGVInvoContent.Item(12, i).Value = ""

                ElseIf .Item("Place") = "1" Then
                    DGVInvoContent.Item(12, i).Value = "في المخزن"

                ElseIf .Item("Place") = "2" Then
                    DGVInvoContent.Item(12, i).Value = "تحت التجهيز"

                ElseIf .Item("Place") = "3" Then
                    DGVInvoContent.Item(12, i).Value = "جاهز"

                ElseIf .Item("Place") = "4" Then
                    DGVInvoContent.Item(12, i).Value = "تم البيع"

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

    Private Sub DGVInvoContent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoContent.CellContentClick

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If SellID = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = " Select ID, FORMAT(Num,'000000') AS Num, Date, Name, [User],Total, Phone1, Phone2 FROM InvoiceView  WHERE ID=" & SellID
        SQLQuery &= " Select * From InvoiceContentView Where InvoiceID=" & SellID
        SQLQuery &= " Select * FROM CenterInfoTable"
        SQLQuery += " Select Address, Phone, Price, CityName, DeliveryName From DeliveryOrderView where InvoiceID= " & SellID

        Dim Address As String = ""
        Dim Phone As String = ""
        Dim Price As String = ""
        Dim CityName As String = ""
        Dim DeliveryName As String = ""

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSPrint.Tables(3).Rows.Count > 0 Then
            Address = DSPrint.Tables(3).Rows(0).Item("Address")
            Phone = DSPrint.Tables(3).Rows(0).Item("Phone")
            Price = DSPrint.Tables(3).Rows(0).Item("Price")
            CityName = DSPrint.Tables(3).Rows(0).Item("CityName")
            DeliveryName = DSPrint.Tables(3).Rows(0).Item("DeliveryName")
        End If
        Dim F As New FrmPrint
        Dim C As New CRSalesInvoice

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        C.Subreports(2).SetDataSource(DSPrint.Tables(2))
        C.SetParameterValue("Address", Address)
        C.SetParameterValue("Phone", Phone)
        C.SetParameterValue("Price", Price)
        C.SetParameterValue("CityName", CityName)
        C.SetParameterValue("DeliveryName", DeliveryName)
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub
End Class