Public Class frmLCredits_CashIn
    Private Sub BtnEnterCode_Click(sender As Object, e As EventArgs) Handles BtnEnterCode.Click
        If BtnEnterCode.Text = "Enter Code" Then
            BtnEnterCode.Text = "Cancel"
            BtnEnterCode.BackColor = Color.IndianRed
            PnlEnterReferenceNumber.Enabled = False
            GrpEnterCode.Enabled = True
        Else
            BtnEnterCode.Text = "Enter Code"
            BtnEnterCode.BackColor = Color.PowderBlue
            PnlEnterReferenceNumber.Enabled = True
            GrpEnterCode.Enabled = False
        End If
    End Sub

    Private Sub BtnCheckReferralCode_Click(sender As Object, e As EventArgs) Handles BtnCheckReferralCode.Click
        If TxtCode.Text = Nothing Then
            MessageBox.Show("Please enter the code", "No code", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtCode.TextLength < 10 Then
            MessageBox.Show("Code must have at least 5 numbers, 5 letters.", "Wrong format of code", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If BtnCheckReferralCode.Text = "Cancel" Then
                PnlEnterCode.Enabled = True
                PnlLCreditStatus.Visible = False
                BtnCheckReferralCode.Text = "Check"
                TxtCode.Text = Nothing
                LblLCreditsNewBalance.Text = "00"
                LblLCreditsObtained.Text = "00"
                BtnCheckReferralCode.BackColor = Color.LightGreen
            Else
                Authentication.CheckAvailableLCreditsCode(TxtCode.Text)
            End If
        End If
    End Sub

    Private Sub BtnConfirmCode_Click(sender As Object, e As EventArgs) Handles BtnConfirmCode.Click
        If MessageBox.Show("You are about to make a transaction - L-Credits Cash-in in amount of " + LblLCreditsObtained.Text + ". Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            Authentication.CashInLCredits_ToUser(LblLCreditsObtained.Text, frmUserMainMenu.LblUniqueID_MainMenu.Text)
            Authentication.DeleteLCreditsCode(TxtCode.Text)
            CollectData.TransactCashIn_LCredits(frmUserMainMenu.LblUniqueID_MainMenu.Text, frmUserMainMenu.LblUniqueID_MainMenu.Text, frmUserMainMenu.LblFullName.Text, LblLCreditsObtained.Text, frmUserMainMenu.LblLocalServerTime_Date.Text)
            MessageBox.Show("Transaction complete. Your new balance has been refreshed", "Transaction complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Authentication.RequestUserCredits(frmUserMainMenu.LblUniqueID_MainMenu.Text)
            TxtCode.Text = Nothing
            LblLCreditsNewBalance.Text = Nothing
            LblLCreditsObtained.Text = Nothing
            PnlLCreditStatus.Visible = False
            BtnCheckReferralCode.Text = "Check"
            BtnCheckReferralCode.BackColor = Color.LightGreen
            GrpEnterCode.Enabled = False
            BtnEnterCode.Text = "Enter Code"
            BtnEnterCode.BackColor = Color.PowderBlue
            PnlEnterReferenceNumber.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub BtnSubmitReference_Click(sender As Object, e As EventArgs) Handles BtnSubmitReference.Click
        If TxtReferenceNumber.Text = Nothing Or TxtAmount.Text = Nothing Then
            MessageBox.Show("Please enter the reference number of your proof of transaction (Receipt or e-receipt)", "Reference number field is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtReferenceNumber.TextLength < 13 Then
            MessageBox.Show("Reference number incomplete, please try again", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(TxtAmount.Text) < 1 Then
            MessageBox.Show("Amount of L-Credits must be above 1, maximum to 10000", "Invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Confirming reference number " + TxtReferenceNumber.Text + " This reference number will be used to verify your payment of " + TxtAmount.Text + " L-Credits. Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                CollectData.ToSubmitReferenceNumber_LCredits(frmUserMainMenu.LblUniqueID_MainMenu.Text, TxtReferenceNumber.Text, TxtAmount.Text, DateTime.Now.ToString("dd/MM/yyyy"))
                MessageBox.Show("Your reference number " + TxtReferenceNumber.Text + " has been sent. Our administration team will validated your request and receive the amount of L-Credits you requested. Thank you", "Reference number submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtReferenceNumber.Text = Nothing
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        If TxtAmount.Text.Length > 0 Then
            If Not IsNumeric(TxtAmount.Text) Then
                Dim Selection As Integer = TxtAmount.SelectionStart
                TxtAmount.Text = TxtAmount.Text.Remove(Selection - 1, 1)
                TxtAmount.SelectionStart = Selection - 1
            End If
        End If
    End Sub
End Class