Public Class frmPayment_Subscribe
    Private Sub frmPayment_Subscribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtReferenceNumber.MaxLength = 15
    End Sub

    Private Sub TxtReferenceNumber_TextChanged(sender As Object, e As EventArgs) Handles TxtReferenceNumber.TextChanged
        If TxtReferenceNumber.Text.Length > 0 Then
            If Not IsNumeric(TxtReferenceNumber.Text) Then
                Dim Selection As Integer = TxtReferenceNumber.SelectionStart
                TxtReferenceNumber.Text = TxtReferenceNumber.Text.Remove(Selection - 1, 1)
                TxtReferenceNumber.SelectionStart = Selection - 1
            End If
        End If
    End Sub

    Private Sub BtnConfirmReferenceNumber_Click(sender As Object, e As EventArgs) Handles BtnConfirmReferenceNumber.Click
        If TxtReferenceNumber.Text = Nothing Then
            MessageBox.Show("Please enter a reference number", "Reference number missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtReferenceNumber.TextLength <= 13 Then
            MessageBox.Show("Reference number must have at least 13-15 characters.", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Confirming reference number " + TxtReferenceNumber.Text + " . This reference number will be used to verify your payment for the Premium plan subscription system of Lyceum of Alabang - Bus Ticketing System. Continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                CollectData.InputReferenceNumber_Subscription(frmUserMainMenu.LblUniqueID_MainMenu.Text, TxtReferenceNumber.Text, DateTime.Now.ToString("dd/MM/yyyy"))
                CollectData.EditUserPremium_ToPending(frmUserMainMenu.LblUniqueID_MainMenu.Text, True)
                Modify.EditPremiumStatusMessage(frmUserMainMenu.LblUniqueID_MainMenu.Text)
                MessageBox.Show("Reference number " + TxtReferenceNumber.Text + " has been confirmed and will be validated by our administrators. Please wait while we verify your payment. Thank you!")
                TxtReferenceNumber.Text = Nothing
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TxtReferenceNumber.Text IsNot Nothing Then
            If MessageBox.Show("Are you sure you want to exit? Any unsaved reference number will be deleted.", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
                TxtReferenceNumber.Text = Nothing
                Me.Close()
            End If
        End If
    End Sub
End Class