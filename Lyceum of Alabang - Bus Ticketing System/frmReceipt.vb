Public Class FrmReceipt
    Dim GFX, MGFX As Graphics
    Dim bitmap As Bitmap

    Public Shared UniqueID As Label

    Private Sub FrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Tag.ToString = "PURCHASED_BY_YOU" Then
            CollectData.FromReceipt_Import(LblTransactionID.Text, LblUniqueID.Text, UniqueID.Text, LblFullName.Text, LblBusName.Text, LblPlateNumber.Text, LblPointA.Text, LblPointB.Text, LblPrice.Text, LblTime.Text, LblDate.Text, LblDOT.Text, 1)
        ElseIf Me.Tag.ToString = "PURCHASED_FOR_SOMEONE" Then
            CollectData.FromReceipt_Import(LblTransactionID.Text, LblUniqueID.Text, UniqueID.Text, LblFullName.Text, LblBusName.Text, LblPlateNumber.Text, LblPointA.Text, LblPointB.Text, LblPrice.Text, LblTime.Text, LblDate.Text, LblDOT.Text, 2)
        ElseIf Me.Tag.ToString = "PURCHASED_BY_ADMINISTRATOR" Then
            CollectData.FromReceipt_Import(LblTransactionID.Text, LblUniqueID.Text, LblUniqueID.Text, LblFullName.Text, LblBusName.Text, LblPlateNumber.Text, LblPointA.Text, LblPointB.Text, LblPrice.Text, LblTime.Text, LblDate.Text, LblDOT.Text, 1)
        End If


        'CollectData.FromReceipt_Import(LblTransactionID.Text, LblUniqueID.Text, LblFullName.Text, LblBusName.Text, LblPlateNumber.Text, LblPointA.Text, LblPointB.Text, LblTime.Text, LblDate.Text, LblDOT.Text, 1)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, -20, -44)
    End Sub

    Private Sub LnkPrintReceipt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkPrintReceipt.LinkClicked
        GFX = CreateGraphics()
        bitmap = New Bitmap(Me.Width, Me.Height, GFX)
        MGFX = Graphics.FromImage(bitmap)
        MGFX.CopyFromScreen(Location.X, Location.Y, 10, 9, Size)
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Paper Size Name", 381, 639)
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class