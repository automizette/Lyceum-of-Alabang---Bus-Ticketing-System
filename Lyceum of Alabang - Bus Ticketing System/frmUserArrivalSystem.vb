Imports System.Data.OleDb

Public Class frmUserArrivalSystem
    Private Sub frmUserArrivalSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminControlData.GetBusListToKiosk(CmbBusList)
    End Sub

    Private Sub CmbBusList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBusList.SelectedIndexChanged
        Sql = "SELECT * FROM BusList WHERE BusName ='" & CmbBusList.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            LblLocation.Text = DataReader("PointA")
            LblDestination.Text = DataReader("PointB")
            LblPlateNumber.Text = DataReader("PlateNumber")

            LblBusName.Text = DataReader("BusName")
            LblLocation_Sys.Text = DataReader("PointA")
            LblDestination_Sys.Text = DataReader("PointB")
            BtnSetupFinish.Visible = True
        End While
    End Sub

    Private Sub BtnSetupFinish_Click(sender As Object, e As EventArgs) Handles BtnSetupFinish.Click
        MessageBox.Show("Setup complete. System will now initialized.", "Kiosk system setup complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TbArriveKiosk.SelectedTab = TbArrivalSystem
    End Sub

    Private Sub BtnArriveUser_Click(sender As Object, e As EventArgs) Handles BtnArriveUser.Click
        If TxtUserFullName.Text = Nothing Then
            MessageBox.Show("Please enter your full name", "Full name field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Sql = "SELECT FullName FROM BusPassengers WHERE BusName ='" & LblBusName.Text & "' AND Location ='" & LblLocation_Sys.Text & "' AND Destination ='" & LblDestination_Sys.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            If DataReader.Read = True Then
                AdminControlData.UserArrivalConfirmed(TxtUserFullName.Text, LblLocation_Sys.Text, LblDestination_Sys.Text)
                Notification.UserArrivedNotify(TxtUserFullName.Text, LblBusName.Text, LblLocation_Sys.Text, LblDestination_Sys.Text)

                MessageBox.Show("Thanks for confirming, " + TxtUserFullName.Text + "! Your reservation has been marked as arrived safely. Thank you for your cooperation!", "Confirmed Arrival", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TxtUserFullName.Text = Nothing
            End If
        End If
    End Sub

    Private Sub PbExitKiosk_Click(sender As Object, e As EventArgs) Handles PbExitKiosk.Click
        If MessageBox.Show("Are you sure you want to exit this Kiosk? Exiting it will log out this system, as well as your account. Continue?", "Confirm Kiosk Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Close()
            frmAdminControls.Close()
            frmBookingSystemKios.Close()
            frmConfirmKioskMode.Close()
            frmModAdminMainMenu.Close()
            frmLogin.Show()
            frmLogin.TxtPassword.Text = Nothing
        End If
    End Sub
End Class