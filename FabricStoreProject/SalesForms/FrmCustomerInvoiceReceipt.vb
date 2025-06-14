Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class FrmCustomerInvoiceReceipt

    Public CustomerID As Integer
    Private DS As DataSet
    Private ReceiptID As Integer

    Private Sub FrmCustomerInvoiceReceipt_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            GetData()

        Else
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

            DGVCustomerInvoices.Rows.Clear()
            ChangeControlColor(Me)

        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()

        Dim sqlcon As New SQLConClass()

        SQLQuery = " Select * From CustomerInvoiceSummaryView "
        DS = sqlcon.SelectData(SQLQuery)
        FillData()
    End Sub

    Private Sub FillData()

        Dim Total As Double
        Dim TotalReceipts As Double
        Dim RemainingDebt As Double

        DGVCustomerInvoices.Rows.Clear()
        For I = 0 To DS.Tables(0).Rows.Count - 1
            With DS.Tables(0).Rows(I)
                DGVCustomerInvoices.Rows.Add()
                DGVCustomerInvoices.Item(0, I).Value = .Item("ID") ' ID
                DGVCustomerInvoices.Item(1, I).Value = I + 1 ' ت
                DGVCustomerInvoices.Item(2, I).Value = .Item("Name")
                DGVCustomerInvoices.Item(3, I).Value = Format(.Item("Total"), "0.00")
                Total += .Item("Total")
                DGVCustomerInvoices.Item(4, I).Value = Format(.Item("TotalReceipts"), "0.00")
                TotalReceipts += .Item("TotalReceipts")
                DGVCustomerInvoices.Item(5, I).Value = Format(.Item("RemainingAmount"), "0.00")
                RemainingDebt += .Item("RemainingAmount")

            End With
        Next
        DGVCustomerInvoices.ClearSelection()

        LblTotal.Text = " اجمالي القيمة : " & Total & "   المدفوع :" & TotalReceipts & "    الباقي :" & RemainingDebt
    End Sub

    Private Sub DGVCustomerInvoices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCustomerInvoices.CellContentClick
        If DGVCustomerInvoices.RowCount = 0 Then Exit Sub

        CustomerID = DGVCustomerInvoices.Item(0, DGVCustomerInvoices.CurrentRow.Index).Value

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColReceipt" Then
            If CustomerID = 0 Then Exit Sub
            FrmReceipt.CIDSearch = CustomerID
            FrmReceipt.ShowDialog()
            GetData()

        End If
    End Sub
End Class