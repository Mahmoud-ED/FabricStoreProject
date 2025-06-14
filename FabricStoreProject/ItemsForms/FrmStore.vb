Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmStore
    Private Ds As DataSet
    Public ID As Integer



    Private Sub FrmStore_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        GetData()
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmStore_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(Ds) Then
            Ds.Clear()
        End If

        Dispose()
    End Sub

    Private Sub GetData()
        'If ID = 0 Then Exit Sub
        Dim SqlCon As New SQLConClass()
        SQLQuery = " Select ROW_NUMBER() OVER (ORDER BY (ID)Desc) As ت, ID, Name, Num, Sum(Quantity) AS Quantity 
                    From ItemsView WHERE EndService IS NULL AND (StoreID = 1 Or StoreID = 3) GROUP BY Name, ID, Num ORDER BY Name DESC"
        Ds = SqlCon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then
            FillDGV()
        End If
    End Sub

    Private Sub FillDGV()
        DGVItem.Rows.Clear()
        For i = 0 To Ds.Tables(0).Rows.Count - 1
            With Ds.Tables(0).Rows(i)

                DGVItem.Rows.Add()
                DGVItem.Item(0, i).Value = i + 1
                DGVItem.Item(1, i).Value = .Item("Num")
                DGVItem.Item(2, i).Value = .Item("Name")
                DGVItem.Item(3, i).Value = .Item("Quantity")
                DGVItem.Item(4, i).Value = .Item("ID")

            End With
        Next
        DGVItem.ClearSelection()
    End Sub

    Private Sub DGVItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVItem.CellContentClick
        If DGVItem.RowCount = 0 Then Exit Sub

        ID = DGVItem.Item(4, DGVItem.CurrentRow.Index).Value

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColShow" Then
            If ID = 0 Then Exit Sub
            FrmItemDetails.ID = ID
            FrmItemDetails.ShowDialog()

        End If

        GetData()
    End Sub

End Class