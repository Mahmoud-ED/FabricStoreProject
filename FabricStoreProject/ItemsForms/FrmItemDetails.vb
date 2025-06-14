Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Web.Services.Description
Imports ZXing

Public Class FrmItemDetails
    Private Ds As DataSet
    Public ID As Integer
    Private CR As Integer = -1

    Private Sub FrmItemDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub FrmItemDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(Ds) Then
            Ds.Clear()
        End If

        Dispose()
    End Sub


    Private Sub GetData()
        If ID = 0 Then Exit Sub
        Dim sqlcon As New SQLConClass()
        If RadAll.Checked Then
            SQLQuery = "  Select ROW_NUMBER() OVER (ORDER BY (ID)Desc) As ت,Num, Name, Price, PurchasePrice, Quantity,ItemStoreNum,type, Size, Country, Color
                     , Category, ItemStoreID From ItemsView Where EndService Is Null And (StoreID =1 Or StoreID = 3) And ID =" & ID

        ElseIf RadReady.Checked Then
            SQLQuery = "  Select ROW_NUMBER() OVER (ORDER BY (ID)Desc) As ت,Num, Name, Price, PurchasePrice, Quantity,ItemStoreNum,type, Size, Country, Color
                     , Category, ItemStoreID From ItemsView Where EndService Is Null And (StoreID =1 Or StoreID = 3) And ItemStoreID not in(Select ItemStoreID From TailorContentTable) And ID =" & ID


        ElseIf RadOrder.Checked Then
            SQLQuery = "  Select ROW_NUMBER() OVER (ORDER BY (ID)Desc) As ت,Num, Name, Price, PurchasePrice, Quantity,ItemStoreNum,type, Size, Country, Color
                     , Category, ItemStoreID From ItemsView Where EndService Is Null And (StoreID =1 Or StoreID = 3) And ItemStoreID in(Select ItemStoreID From TailorContentTable) And ID =" & ID

        End If
        Ds = sqlcon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then
            FillDGV()
        End If
    End Sub

    Private Sub FillDGV()
        Dim SumQuantity As Integer
        DGVItem.Rows.Clear()
        LblTitel.Text = ""
        TxtSumQuantity.Text = "0"
        If Ds.Tables(0).Rows.Count > 0 Then
            LblTitel.Text = "تفاصيل الصنف رقم " + " - " + Ds.Tables(0).Rows(0).Item("ItemStoreNum").ToString + " تصنيف - " + Ds.Tables(0).Rows(0).Item("Category")
            For i = 0 To Ds.Tables(0).Rows.Count - 1
                With Ds.Tables(0).Rows(i)

                    DGVItem.Rows.Add()
                    DGVItem.Item(0, i).Value = .Item("ت") ' + 1
                    DGVItem.Item(1, i).Value = .Item("ItemStoreNum")
                    DGVItem.Item(2, i).Value = .Item("Name")
                    DGVItem.Item(3, i).Value = Format(.Item("PurchasePrice"), "0.00")
                    DGVItem.Item(4, i).Value = Format(.Item("Price"), "0.00")
                    DGVItem.Item(5, i).Value = .Item("Quantity")
                    DGVItem.Item(6, i).Value = .Item("Num")
                    If .Item("type").ToString = "1" Then
                        DGVItem.Item(7, i).Value = "قماش"


                    Else
                        DGVItem.Item(7, i).Value = "ملابس"
                    End If
                    DGVItem.Item(8, i).Value = .Item("Size")
                    DGVItem.Item(9, i).Value = .Item("Country")
                    DGVItem.Item(10, i).Value = .Item("Color")
                    DGVItem.Item(11, i).Value = .Item("ItemStoreID")
                    SumQuantity += DGVItem.Item(5, i).Value
                End With
            Next
            DGVItem.ClearSelection()
            TxtSumQuantity.Text = SumQuantity.ToString
        End If

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

    Private Sub RadAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadAll.CheckedChanged
        GetData()
    End Sub

    Private Sub RadReady_CheckedChanged(sender As Object, e As EventArgs) Handles RadReady.CheckedChanged
        GetData()
    End Sub

    Private Sub RadOrder_CheckedChanged(sender As Object, e As EventArgs) Handles RadOrder.CheckedChanged
        GetData()
    End Sub

    Private Sub DGVItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVItem.CellContentClick
        If CheckDGVError(DGVItem) Then Exit Sub
        If DGVItem.Rows.Count = 0 Then Exit Sub
        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name

        CR = DGVItem.CurrentRow.Index


        If Col = "ColPrint" Then
            Try
                ' النص الذي سيتم تحويله إلى باركود
                Dim barcodeText As String = DGVItem.Item(1, CR).Value  ' مثال نص الباركود
                Dim itemName As String = DGVItem.Item(2, CR).Value
                Dim itemPrice As String = DGVItem.Item(4, CR).Value + " د.ل "

                Dim CompanyName As String = My.Settings.CompanyArabicName

                ' إنشاء مولد الباركود
                Dim barcodeWriter As New BarcodeWriter()
                barcodeWriter.Format = BarcodeFormat.CODE_128
                barcodeWriter.Options = New ZXing.Common.EncodingOptions With {
               .Height = 100,  ' ارتفاع الباركود
               .Width = 300,   ' عرض الباركود
               .Margin = 2}

                ' توليد صورة الباركود
                Dim barcodeImage As Bitmap = barcodeWriter.Write(barcodeText)

                ' إنشاء صورة جديدة تجمع بين الباركود والنصوص
                Dim combinedImage As New Bitmap(300, 150) ' ضبط حجم الصورة الجديدة
                Using g As Graphics = Graphics.FromImage(combinedImage)
                    g.Clear(Color.White) ' خلفية بيضاء

                    ' رسم الباركود
                    g.DrawImage(barcodeImage, New Point(0, 0))

                    ' إعداد الخطوط للنصوص
                    Dim font As New Font("Arial", 18, FontStyle.Bold)
                    Dim brush As New SolidBrush(Color.Black)

                    ' رسم النص أسفل الباركود
                    g.DrawString(itemName, font, brush, New PointF(10, 100)) ' اسم الصنف
                    g.DrawString(itemPrice, font, brush, New PointF(10, 125)) ' سعر الصنف
                    'If ChkCompanyName.Checked Then
                    ' حساب موضع النص بحيث يكون في منتصف العرض
                    Dim companyNameSize As SizeF = g.MeasureString(CompanyName, font)
                    Dim companyNameX As Single = combinedImage.Width - companyNameSize.Width - 10 ' الحافة اليمنى مع مسافة 10 بكسل
                    Dim companyNameY As Single = combinedImage.Height - companyNameSize.Height - 10 ' الحافة السفلية مع مسافة 10 بكسل

                    ' رسم اسم الشركة في منتصف الصورة
                    g.DrawString(CompanyName, font, brush, New PointF(companyNameX, companyNameY))
                    'End If
                End Using

                ' عرض الصورة النهائية في PictureBox
                PicBarcode.Image = combinedImage

            Catch ex As Exception
                MessageBox.Show("حدث خطأ: " & ex.Message)
            End Try

            Dim DT As DataTable

            Dim F As New FrmPrint
            Dim C As New CrBarcode
            'Dim DT As DataTable
            Dim DSPrint As DataSet

            Dim param() As SqlParameter = {
             New SqlParameter("barcode", Format(DGVItem.Item(6, CR).Value, "*0000*")),
                New SqlParameter("@FrameType", DGVItem.Item(2, CR).Value),
                New SqlParameter("@BarcodeImage", ImageToByte(PicBarcode)),
                New SqlParameter("Price", DGVItem.Item(3, CR).Value)
                 }
            param(2).SqlDbType = SqlDbType.VarBinary

            Dim sqlcon = New SQLConClass()

            DSPrint = sqlcon.CMDExecuteData("SaveBarcode", param)
            DT = DSPrint.Tables(0).Copy

            C.SetDataSource(DT)
            F.CrystalReportViewer1.ReportSource = C
            F.CrystalReportViewer1.Refresh()

            F.Text = "طباعة باركود "
            F.CrystalReportViewer1.Zoom(100%)
            F.WindowState = FormWindowState.Maximized
            F.Show()
            DSPrint.Clear()


        ElseIf Col = "ColSizes" Then
            If DGVItem.CurrentRow.Cells(7).Value.ToString = "ملابس" Then
                FrmItemSizes.ItemID = Convert.ToInt32(DGVItem.CurrentRow.Cells(11).Value)
                FrmItemSizes.ShowDialog()
            End If

        ElseIf Col = "ColEdit" Then
            If ID = 0 Then Exit Sub
            FrmEditQuantity.ID = ID
            FrmEditQuantity.ShowDialog()
            RadAll_CheckedChanged(sender, e)
        End If
    End Sub
End Class