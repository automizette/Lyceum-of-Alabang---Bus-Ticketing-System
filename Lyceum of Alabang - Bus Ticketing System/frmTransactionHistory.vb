Public Class frmTransactionHistory
    Private Sub frmTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CollectData.TransactionHistoryFilters(frmUserMainMenu.LblUniqueID_MainMenu.Text, DgvTransactionHistory, 1)
        Modify.TransactionHistory_ColumnText(DgvTransactionHistory, 1)
        LblFullName.Text = frmUserMainMenu.LblFullName.Text
    End Sub

    Private Sub BtnChangeFilter_Click(sender As Object, e As EventArgs) Handles BtnChangeFilter.Click
        If BtnChangeFilter.Text = "Transportation" Then
            CollectData.TransactionHistoryFilters(frmUserMainMenu.LblUniqueID_MainMenu.Text, DgvTransactionHistory, 2)
            Modify.TransactionHistory_ColumnText(DgvTransactionHistory, 2)
            BtnChangeFilter.Text = "L-Credits purchases"
            BtnChangeFilter.BackColor = Color.LightSeaGreen
        ElseIf BtnChangeFilter.Text = "L-Credits purchases" Then
            CollectData.TransactionHistoryFilters(frmUserMainMenu.LblUniqueID_MainMenu.Text, DgvTransactionHistory, 3)
            Modify.TransactionHistory_ColumnText(DgvTransactionHistory, 3)
            BtnChangeFilter.Text = "Premium purchases"
            BtnChangeFilter.BackColor = Color.DeepSkyBlue
        ElseIf BtnChangeFilter.Text = "Premium purchases" Then
            CollectData.TransactionHistoryFilters(frmUserMainMenu.LblUniqueID_MainMenu.Text, DgvTransactionHistory, 4)
            Modify.TransactionHistory_ColumnText(DgvTransactionHistory, 1)
            BtnChangeFilter.Text = "All transaction"
            BtnChangeFilter.BackColor = Color.DodgerBlue
        ElseIf BtnChangeFilter.Text = "All transaction" Then
            CollectData.TransactionHistoryFilters(frmUserMainMenu.LblUniqueID_MainMenu.Text, DgvTransactionHistory, 1)
            Modify.TransactionHistory_ColumnText(DgvTransactionHistory, 1)
            BtnChangeFilter.Text = "Transportation"
            BtnChangeFilter.BackColor = Color.Aquamarine
        End If
    End Sub
End Class