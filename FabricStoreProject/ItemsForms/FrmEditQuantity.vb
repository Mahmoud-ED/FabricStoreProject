Imports System.Data.SqlClient

Public Class FrmEditQuantity

    Public ID As Integer
    Private Sub FrmEditQuantity_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub

    Private Sub GetData()
        Dim sqlcon As New SQLConClass
        SQLQuery = " select * from  ItemStoreTable where ID= " & ID
        Dim Ds As DataSet
        Ds = sqlcon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then

            'PurchasePrice

            TxtPrush.Text = Ds.Tables(0).Rows(0)("PurchasePrice").ToString()
            TxtNewPrush.Text = Ds.Tables(0).Rows(0)("PurchasePrice").ToString()

            TxtNewPrice.Text = Ds.Tables(0).Rows(0)("Price").ToString()
            TxtPrice.Text = Ds.Tables(0).Rows(0)("Price").ToString()

            TxtQuantity.Text = Ds.Tables(0).Rows(0)("Quantity").ToString()
            TxtNewQuantity.Text = Ds.Tables(0).Rows(0)("Quantity").ToString()
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        GetData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtNewQuantity.Text = "" Or TxtNewPrice.Text = "" Or TxtNewPrush.Text = "" Then
            MsgBox("Please fill all fields", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If


        Dim Param() As SqlParameter = {
            New SqlParameter("ID", ID),
            New SqlParameter("Quantity", TxtNewQuantity.Text),
            New SqlParameter("Price", TxtNewPrice.Text),
            New SqlParameter("PrushPrice", TxtNewPrush.Text)
        }
        Dim sqlcon As New SQLConClass
        Save = sqlcon.CMDExecute("UpdateQuantity", 1, Param)
        If Save = 1 Then
            MsgBox("Data Updated Successfully", MsgBoxStyle.Information, "Success")
            GetData()
        Else
            MsgBox("Error Updating Data", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class