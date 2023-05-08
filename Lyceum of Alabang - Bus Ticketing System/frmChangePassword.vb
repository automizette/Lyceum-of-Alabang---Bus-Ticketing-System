Imports System.Data.OleDb

Public Class frmChangePassword
    Private Sub BtnConfirmPassword_Click(sender As Object, e As EventArgs) Handles BtnConfirmPassword.Click
        If TxtPassword.Text = Nothing Then
            MessageBox.Show("Please enter your new password!", "Password text box empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtConfirmPassword.Text = Nothing Then
            MessageBox.Show("Please confirm your password", "Confirm password text box empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtPassword.TextLength < 8 Or TxtConfirmPassword.TextLength < 8 Then
            MessageBox.Show("Password must contain at least 8 characters!", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtConfirmPassword.Text = TxtPassword.Text Then
            Sql = "SELECT Password FROM UserAccounts WHERE UniqueID ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                If DataReader("Password") = TxtPassword.Text Then
                    MessageBox.Show("Your new password is the same old password you use! (Congratulations)", "Same password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If MessageBox.Show("Are you sure you want to change your password? You will be logged out from this program for security. Continue?", "Confirm change password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        CollectData.ChangePassword(frmUserMainMenu.LblUniqueID_MainMenu.Text, TxtConfirmPassword.Text)
                        MessageBox.Show("Your password has been changed. You are required to log-in again with your new password.", "Password change successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TxtPassword.Text = Nothing
                        TxtConfirmPassword.Text = Nothing
                        frmOTPValidation.Tag = "NO_TAG"
                        Me.Close()
                        frmUserMainMenu.Close()
                        frmLogin.Show()
                        frmLogin.TxtPassword.Text = Nothing
                    End If
                End If
            End While
        Else
            MessageBox.Show("Password doesn't match with confirm password", "Password not matched!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LnkExit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkExit.LinkClicked
        If MessageBox.Show("Exiting this menu will terminate the password change process. Continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            TxtPassword.Text = Nothing
            TxtConfirmPassword.Text = Nothing
            Me.Close()
        End If
    End Sub
End Class