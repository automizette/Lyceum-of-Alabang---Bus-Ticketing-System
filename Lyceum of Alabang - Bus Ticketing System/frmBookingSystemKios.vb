Imports System.Data.OleDb

Public Class frmBookingSystemKios
    Private Sub frmBookingSystemKios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvBusList_Admin.DataSource = CollectData.FromBusList

        frmSeatPicker.AccountType_FilteredSeatin = LblPlateNumber
        frmSeatPicker.BookButton_Filtered = BtnBookNow
        frmSeatPicker.AssignedSeat = LblAssignedSeat
    End Sub

    Private Sub BtnConfirmEmail_Click(sender As Object, e As EventArgs) Handles BtnConfirmEmail.Click
        If BtnConfirmEmail.Text = "Cancel" Then
            LblBusName.Tag = "BusInputFalse"
            BtnBookNow.Enabled = False
            BtnConfirmEmail.Text = "Confirm"
            BtnConfirmEmail.BackColor = Color.PaleTurquoise
            TxtEmail.Enabled = Enabled
            PnlBookingCenter.Enabled = False
            LblTimeOfDepart.Text = "00:00(AM/PM)"
            LblDateOfDepart.Text = "MM/DD"
            LblBusName.Text = "Bus Name"
            LblPlateNumber.Text = "Plate Number"
            LblPointA.Text = "Location"
            LblPointB.Text = "Destination Point"
            LblAssignedSeat.Text = "N/A"
            LblAvailableSeats.Text = "00"
            LblPrice.Text = "0"
            TxtEmail.Text = Nothing

            LblUniqueID_Booking.Text = "LOA-XXXXXX"
            LblFullName_Booking.Text = "Full Name"
            LblLRN_Booking.Text = "000000000000"
        Else
            If TxtEmail.Text = Nothing Then
                MessageBox.Show("Please enter the user's email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sql = "SELECT * FROM UserAccounts WHERE EmailAddress ='" & TxtEmail.Text & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                If DataReader.Read = True Then
                    If MessageBox.Show("Welcome, " + DataReader("FirstName") + " " + DataReader("LastName") +
                                   " to the Self-service booking Kiosk. Please note that your transaction here will be deducted directly from your account, so make sure you have the proper L-Credit balance. Continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = vbYes Then
                        LblUniqueID_Booking.Text = DataReader("UniqueID")
                        LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        LblLRN_Booking.Text = DataReader("LRN")
                        TxtEmail.Enabled = False
                        PnlBookingCenter.Enabled = True
                        BtnConfirmEmail.Text = "Cancel"
                        BtnConfirmEmail.BackColor = Color.IndianRed

                    End If
                Else
                    MessageBox.Show("No user has been found associated with this email.", "User email not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnSeatPicker_Click(sender As Object, e As EventArgs) Handles BtnSeatPicker.Click
        If LblBusName.Tag.ToString = "BusInputTrue" Then
            frmSeatPicker.Show()
            frmSeatPicker.LblPointA.Text = LblPointA.Text
            frmSeatPicker.LblPointB.Text = LblPointB.Text
        Else
            MessageBox.Show("Please choose a route")
        End If
    End Sub

    Private Sub BtnBookNow_Click(sender As Object, e As EventArgs) Handles BtnBookNow.Click

        Sql = "SELECT UniqueID, FullName, BusName, Location, Destination, TimeOfDeparture, DateOfDeparture FROM BusPassengers WHERE UniqueID ='" &
            LblUniqueID_Booking.Text & "' AND FullName ='" & LblFullName_Booking.Text & "' AND BusName ='" & LblBusName.Text & "' AND Location ='" &
            LblPointA.Text & "' AND Destination ='" & LblPointB.Text & "' AND TimeOfDeparture ='" & LblTimeOfDepart.Text & "' AND DateOfDeparture ='" &
            LblDateOfDepart.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            MessageBox.Show("You have already booked this reservation with the exact same details.", "Error - Double booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf LblAvailableSeats.Text = 0 Then
            MessageBox.Show("This bus is now fully occupied. Try looking for another bus that has the same route.", "Bus fully occupied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            AdminControlData.CheckIfUserHasBalance(LblUniqueID_Booking.Text, LblPrice.Text)
            If AdminControlData.UserHasBalance = False Then
                MessageBox.Show("Your balance seems kind of low and you can't make this transaction. Please reload your L-Credits", "Insufficient L-Credit Balance", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("Your reservation details are as follows: User: " + LblFullName_Booking.Text + ", with the seat " + LblAssignedSeat.Text + " on Bus " + LblBusName.Text + " - Route " + LblPointA.Text + " -> " + LblPointB.Text + ". Proceed?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                    CollectData.FromBookingDetails_Import(LblUniqueID_Booking.Text, LblLocalServerDate_Time.Text, LblFullName_Booking.Text, LblLRN_Booking.Text, LblAssignedSeat.Text, LblBusName.Text,
                                                          LblPointA.Text, LblPointB.Text, LblTimeOfDepart.Text, LblDateOfDepart.Text, LblPlateNumber.Text, LblPrice.Text)
                    FrmReceipt.Tag = "PURCHASED_BY_ADMINISTRATOR"
                    MessageBox.Show("Booking details has been reserved successfully.", "Your reservation has been reserved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CollectData.FromBookingDetails_ToReceipt(LblAssignedSeat, LblLocalServerDate_Time, LblDateOfDepart, LblTimeOfDepart, LblBusName, LblPointA, LblPointB, LblPlateNumber, LblFullName_Booking, LblUniqueID_Booking, LblPrice)
                    FrmReceipt.Show()
                    CollectData.ToDeductSeatFromBus(LblPlateNumber.Text, LblBusName.Text)
                    DgvBusList_Admin.DataSource = CollectData.FromBusList
                    'Authentication.RequestUserCredits(LblUniqueID_MainMenu.Text)
                    'Modify.GetReservationCount(LblReservationActive)

                    LblBusName.Tag = "BusInputFalse"
                    BtnBookNow.Enabled = False
                    BtnConfirmEmail.Enabled = True
                    BtnConfirmEmail.Text = "Confirm"
                    BtnConfirmEmail.BackColor = Color.PaleTurquoise
                    TxtEmail.Enabled = Enabled
                    PnlBookingCenter.Enabled = False
                    LblTimeOfDepart.Text = "00:00(AM/PM)"
                    LblDateOfDepart.Text = "MM/DD"
                    LblBusName.Text = "Bus Name"
                    LblPlateNumber.Text = "Plate Number"
                    LblPointA.Text = "Location"
                    LblPointB.Text = "Destination Point"
                    LblAssignedSeat.Text = "N/A"
                    LblAvailableSeats.Text = "00"
                    LblPrice.Text = "0"
                    TxtEmail.Text = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblLocalServerDate_Time.Text = Now
    End Sub

    Private Sub DgvBusList_Admin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBusList_Admin.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBusList_Admin.Rows(Index)

            LblBusName.Tag = "BusInputTrue"
            LblAssignedSeat.Text = "N/A"
            BtnBookNow.Enabled = False
            LblPlateNumber.Text = SelectedRow.Cells(0).Value.ToString
            LblBusName.Text = SelectedRow.Cells(1).Value.ToString
            LblPointA.Text = SelectedRow.Cells(2).Value.ToString
            LblPointB.Text = SelectedRow.Cells(3).Value.ToString
            LblPrice.Text = SelectedRow.Cells(4).Value.ToString
            LblAvailableSeats.Text = SelectedRow.Cells(5).Value.ToString

            Sql = "SELECT TimeOfDeparture, DateOfDeparture FROM BusList WHERE BusName ='" & SelectedRow.Cells(1).Value.ToString & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblTimeOfDepart.Text = DataReader("TimeOfDeparture")
                LblDateOfDepart.Text = DataReader("DateOfDeparture")
            End While

        End If
    End Sub

    Private Sub PbExitKiosk_Click(sender As Object, e As EventArgs) Handles PbExitKiosk.Click
        If MessageBox.Show("Are you sure you want to exit this Kiosk? Exiting it will log out this system, as well as your account. Continue?", "Confirm Kiosk Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Close()
            frmAdminControls.Close()
            frmUserArrivalSystem.Close()
            frmConfirmKioskMode.Close()
            frmModAdminMainMenu.Close()
            frmLogin.Show()
            frmLogin.TxtPassword.Text = Nothing
        End If
    End Sub
End Class