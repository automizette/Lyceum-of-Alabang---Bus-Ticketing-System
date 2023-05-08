Public Class frmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Private Sub BtnAuthenticate_Click(sender As Object, e As EventArgs) Handles BtnAuthenticate.Click
        If TxtUsername.Text = Nothing And TxtPassword.Text = Nothing Then
            MessageBox.Show("Please fill in the required fields.")
            LblUsername.ForeColor = Color.Red
            LblPassword.ForeColor = Color.Red
        ElseIf TxtUsername.Text = Nothing Then
            MessageBox.Show("Please fill in the username field.")
            LblUsername.ForeColor = Color.Red
        ElseIf TxtPassword.Text = Nothing Then
            MessageBox.Show("Please fill in the password field.")
            LblPassword.ForeColor = Color.Red
        Else
            Authentication.LoginAuthentication(TxtUsername.Text, TxtPassword.Text)
        End If
    End Sub

    Private Sub TxtUsername_Click(sender As Object, e As EventArgs) Handles TxtUsername.Click
        LblUsername.ForeColor = Color.Black
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        LblPassword.ForeColor = Color.Black
    End Sub

    Private Sub LnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSignUp.LinkClicked
        frmSignUp.Show()
        Me.Hide()
    End Sub
End Class
