Imports System.Data.OleDb

Public Class frmAddOTP_Admin
    Private Sub frmAddOTP_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub TxtConfrimOTP_TextChanged(sender As Object, e As EventArgs) Handles TxtConfrimOTP.TextChanged
        If TxtConfrimOTP.Text.Length > 0 Then
            If Not IsNumeric(TxtConfrimOTP.Text) Then
                Dim Selection As Integer = TxtConfrimOTP.SelectionStart
                TxtConfrimOTP.Text = TxtOTP.Text.Remove(Selection - 1, 1)
                TxtConfrimOTP.SelectionStart = Selection - 1
            ElseIf TxtConfrimOTP.TextLength = 6 Then
                BtnConfirmOTP_2.Text = "CONFIRM"
                BtnConfirmOTP_2.BackColor = Color.LightGreen
            ElseIf TxtConfrimOTP.TextLength < 6 Then
                BtnConfirmOTP_2.Text = "Back"
                BtnConfirmOTP_2.BackColor = Color.IndianRed
            End If
        End If
    End Sub

    Private Sub BtnConfirmOTP_1_Click(sender As Object, e As EventArgs) Handles BtnConfirmOTP_1.Click
        If TxtOTP.Text = Nothing Then
            MessageBox.Show("Please enter your desired OTP", "No pin entered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtOTP.TextLength < 6 Then
            MessageBox.Show("OTP must have at least 6 codes", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("First OTP has been validated", "First OTP attempt success")
            BtnConfirmOTP_1.Visible = False
            TxtConfrimOTP.Enabled = True
            Pnl1OTP.Enabled = False
            Pnl2OTP.Enabled = True
            BtnConfirmOTP_2.Visible = True
        End If
    End Sub

    Private Sub BtnConfirmOTP_2_Click(sender As Object, e As EventArgs) Handles BtnConfirmOTP_2.Click
        If BtnConfirmOTP_2.Text = "Back" Then
            Pnl2OTP.Enabled = False
            Pnl1OTP.Enabled = True
            TxtConfrimOTP.Enabled = False
            TxtOTP.Enabled = True
            BtnConfirmOTP_1.Visible = True
            BtnConfirmOTP_2.Visible = False
        ElseIf BtnConfirmOTP_2.Text = "CONFIRM" Then
            If TxtConfrimOTP.Text = Nothing Then
                MessageBox.Show("Please enter the OTP you have entered in the first OTP validation", "No pin entered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtConfrimOTP.TextLength < 6 Then
                MessageBox.Show("Second OTP validation must have at least 6 codes", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtConfrimOTP.Text = TxtOTP.Text Then
                MessageBox.Show("Final OTP has been validated.", "Second OTP attempt success")
                Sql = "SELECT * FROM UserOTP WHERE UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                If DataReader.Read = True Then
                    BtnEnableOTP.Text = "Change OTP"
                    BtnEnableOTP.Visible = True
                    BtnConfirmOTP_2.Visible = False
                    Pnl2OTP.Enabled = False
                Else
                    BtnEnableOTP.Visible = True
                    BtnEnableOTP.Text = "Enable OTP"
                    BtnConfirmOTP_2.Visible = False
                    Pnl2OTP.Enabled = False
                End If
            Else
                MessageBox.Show("This OTP doesn't matched to your first OTP. Each OTP validation must matched", "OTP not matched", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnEnableOTP_Click(sender As Object, e As EventArgs) Handles BtnEnableOTP.Click
        If MessageBox.Show("Your OTP is " + TxtConfrimOTP.Text + ". Please screenshot it or type it into a secured text file. Continue enabling this OTP?", "Confirm OTP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Authentication.CreateOTP(frmModAdminMainMenu.LblUniqueID_MainMenu.Text, TxtConfrimOTP.Text)
            Authentication.ChangeOTPState(frmModAdminMainMenu.LblUniqueID_MainMenu.Text, True)
            frmOTPValidation.Tag = "NO_TAG"
            MessageBox.Show("OTP has been enabled successfully. You will be logged out from this session for security", "OTP enabled successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            frmModAdminMainMenu.Close()
            frmLogin.Show()
            frmLogin.TxtPassword.Text = Nothing
        End If
    End Sub
End Class