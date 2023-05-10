Public Class frmSignUp
    Private Sub TxtLrnId_TextChanged(sender As Object, e As EventArgs) Handles TxtLrnId.TextChanged
        If TxtLrnId.Text.Length > 0 Then
            If Not IsNumeric(TxtLrnId.Text) Then
                Dim Selection As Integer = TxtLrnId.SelectionStart
                TxtLrnId.Text = TxtLrnId.Text.Remove(Selection - 1, 1)
                TxtLrnId.SelectionStart = Selection - 1
            End If
        End If
    End Sub

    Private Sub TxtLrnId_Click(sender As Object, e As EventArgs) Handles TxtLrnId.Click
        LblLRN.ForeColor = Color.Black
    End Sub

    Private Sub TxtValidateLrn_Click(sender As Object, e As EventArgs) Handles BtnValidateLrn.Click
        If TxtLrnId.Text = Nothing Then
            MessageBox.Show("Please put your LRN/ID number.", "LRN Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LblLRN.ForeColor = Color.Red
        ElseIf TxtLrnId.TextLength < 12 Then
            MessageBox.Show("LRN/ID Number must consist of 12 characters", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Authentication.LRNValidation(TxtLrnId.Text)
        End If
    End Sub

    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles BtnCreateAccount.Click
        If TxtUsername.Text = Nothing And TxtPassword.Text = Nothing And TxtConfirmPassword.Text = Nothing Then
            MessageBox.Show("Please fill in the required fields!", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LblUsername.ForeColor = Color.Red
            LblPassword.ForeColor = Color.Red
            LblConfirmPassword.ForeColor = Color.Red
        ElseIf TxtUsername.Text = Nothing Then
            MessageBox.Show("Please fill in the username field!", "Username field is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LblUsername.ForeColor = Color.Red
        ElseIf TxtPassword.Text = Nothing Then
            MessageBox.Show("Please fill in the password field!", "Password field is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LblPassword.ForeColor = Color.Red
        ElseIf TxtConfirmPassword.Text = Nothing Then
            MessageBox.Show("Please confirm your password!", "Confirm password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LblConfirmPassword.ForeColor = Color.Red
        ElseIf TxtPassword.TextLength < 8 Then
            MessageBox.Show("Password must consist of 8 characters", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtPassword.Text = txtConfirmPassword.Text Then
            Authentication.CreateAccount(LblUniqueID.Text, TxtEmailAddress.Text, TxtLrnId.Text, LblFirstName.Text, LblLastName.Text, TxtUsername.Text, TxtPassword.Text, LblBirthdate.Text, LblUserType.Text)
            Authentication.ClearLRNAvailabilityForUser(TxtLrnId.Text)
            Authentication.CreateUserPriveleges(LblUniqueID.Text, TxtUsername.Text)
            Modify.NewAccountValidation(LblUniqueID.Text)
            MessageBox.Show("Congratulations! Your account has been created. You may now proceed on signing into your account.", "Account created successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LblLastName.Text = "Last Name"
            LblFirstName.Text = "First Name"
            LblBirthdate.Text = "MM/DD/YYYY"
            LblUserType.Text = "N/A"
            GrpInputFields.Enabled = False
            BtnValidateLrn.BackColor = Color.Aqua
            BtnValidateLrn.Text = "Validate"
            TxtLrnId.Text = Nothing
            TxtUsername.Text = Nothing
            TxtEmailAddress.Text = Nothing
            TxtConfirmPassword.Text = Nothing
            TxtPassword.Text = Nothing
            TxtLrnId.Enabled = True
        Else
            MessageBox.Show("Password doesn't match!", "Password not match", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LblPassword.ForeColor = Color.Red
            LblConfirmPassword.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TxtUsername_Click(sender As Object, e As EventArgs) Handles TxtUsername.Click
        LblUsername.ForeColor = Color.Black
    End Sub
    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        LblPassword.ForeColor = Color.Black
    End Sub

    Private Sub TxtConfirmPassword_Click(sender As Object, e As EventArgs) Handles TxtConfirmPassword.Click
        LblConfirmPassword.ForeColor = Color.Black
    End Sub

    Private Sub LnkBacktoLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBacktoLogin.LinkClicked
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtLrnId.MaxLength = 12
    End Sub
End Class