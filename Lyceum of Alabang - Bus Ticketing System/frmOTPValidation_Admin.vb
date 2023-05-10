Public Class frmOTPValidation_Admin
    Private InputAttempts As Integer = 5

    Private Sub frmOTPValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Authentication.OTPAuthenticated = False
    End Sub

    Private Sub BtnConfirmOTP_Click(sender As Object, e As EventArgs) Handles BtnConfirmOTP.Click
        If TxtOTP.Text = Nothing Then
            MessageBox.Show("Please enter your OTP at the text box", "OTP box is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtOTP.TextLength < 6 Then
            MessageBox.Show("Your OTP must have 6 characters", "Insufficient character", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Authentication.OTPAuthentication(frmModAdminMainMenu.LblUniqueID_MainMenu.Text, TxtOTP.Text)
            If Authentication.OTPAuthenticated = True Then
                Select Case Me.Tag
                    Case "CHANGE_EMAIL_ADMIN"
                        frmModAdminMainMenu.TxtEmail_Account.Enabled = True
                        frmModAdminMainMenu.BtnSaveEmail_Account.Visible = True
                        frmModAdminMainMenu.BtnChangeEmail_Account.Text = "Back"
                        frmModAdminMainMenu.BtnChangeEmail_Account.BackColor = Color.IndianRed
                        Me.Close()
                        Me.Tag = "NO_TAG"
                    Case "CHANGE_PASSWORD_ADMIN"
                        frmChangePassword_Admin.Show()
                        Me.Close()
                        Me.Tag = "NO_TAG"
                    Case "CHANGE_OTP_ADMIN"
                        Me.Close()
                        frmAddOTP_Admin.Show()
                    Case "DEACTIVATE_ACCOUNT_ADMIN"
                        CollectData.AccountActivation(frmModAdminMainMenu.LblUniqueID_MainMenu.Text, False)
                        MessageBox.Show("Account has been deactivated. If you want to reactivated your account, please reach out to the administration", "Account deactivation complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmChangePassword.Close()
                        frmModAdminMainMenu.Close()
                        frmLogin.Show()
                        frmLogin.TxtUsername.Text = Nothing
                        frmLogin.TxtPassword.Text = Nothing
                End Select
            Else
                Select Case InputAttempts
                    Case 5
                        MessageBox.Show("Wrong OTP. Please try again.", "OTP Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InputAttempts = InputAttempts - 1
                    Case 4
                        MessageBox.Show("Wrong OTP. Please try again.", "OTP Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InputAttempts = InputAttempts - 1
                    Case 3
                        MessageBox.Show("Wrong OTP. Please try again.", "OTP Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InputAttempts = InputAttempts - 1
                    Case 2
                        MessageBox.Show("Wrong OTP. Please try again.", "OTP Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InputAttempts = InputAttempts - 1
                    Case 1
                        MessageBox.Show("Wrong OTP. Please try again.", "OTP Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InputAttempts = InputAttempts - 1
                        MessageBox.Show("OTP number of attempts has been reached. For the safety of this account, we will deactivate this account. Please contact the administrator in order to recover your account.", "Number of attempts reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        CollectData.AccountActivation(frmModAdminMainMenu.LblUniqueID_MainMenu.Text, False)
                        Me.Close()
                        frmUserMainMenu.Close()
                        frmAdminControls.Close()
                        frmModAdminMainMenu.Close()
                        frmAdminControls.Close()
                        frmLogin.Show()
                        frmLogin.TxtUsername.Text = Nothing
                        frmLogin.TxtPassword.Text = Nothing
                End Select
            End If
        End If
    End Sub

    Private Sub TxtOTP_TextChanged(sender As Object, e As EventArgs) Handles TxtOTP.TextChanged
        If TxtOTP.Text.Length > 0 Then
            If Not IsNumeric(TxtOTP.Text) Then
                Dim Selection As Integer = TxtOTP.SelectionStart
                TxtOTP.Text = TxtOTP.Text.Remove(Selection - 1, 1)
                TxtOTP.SelectionStart = Selection - 1
            End If
        End If
    End Sub
End Class