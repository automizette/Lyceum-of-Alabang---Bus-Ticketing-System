Imports System.Data.OleDb

Public Class frmModAdminMainMenu
    Private Sub frmModAdminMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvBusList_Admin.DataSource = CollectData.FromBusList
        DgvBookReservations.DataSource = CollectData.AllUserReservation(CmbFilterBusName.Text)
        DgvBusList_Editing.DataSource = CollectData.BusListEdit_Customized
        DgvUserList.DataSource = CollectData.UserList()

        CollectData.CmbBusFiltered(CmbFilterBusName)

        Modify.GetAvailableBus(LblAvailableBus)
        Modify.GetReservationCount(LblReservationActive)
        Modify.GetUserCount(LblRegisteredUsers, True)
        Modify.GetUnregisteredUsers(LblUnregisteredUser)
        Modify.GetUserCount(LblDeactivatedUser, False)

        Modify.BookList_UserFiltered(DgvBookReservations)
        Modify.BusListDGV(DgvBusList_Admin)
        Modify.BusEditDGV(DgvBusList_Editing)
        Modify.UserList_EditColumn(DgvUserList)

        Modify.BusListDGV(DgvBusList_Admin)

        Authentication.AdministratorPriveleges(LblUsername.Text, LblUniqueID_MainMenu.Text)

        SearchEngine.CheckLRN(TxtSearchLRN_EditUsers)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblLocalServerDate_Time.Text = Now
    End Sub

    Private Sub PbInformationDesk_Click(sender As Object, e As EventArgs) Handles PbInformationDesk.Click
        TbModAdminCenter.SelectedTab = Me.TbInformationTab
    End Sub

    Private Sub PbBook_Click(sender As Object, e As EventArgs) Handles PbBook.Click
        TbModAdminCenter.SelectedTab = Me.TbBookingPage
    End Sub

    Private Sub PbEditReservations_Click(sender As Object, e As EventArgs) Handles PbEditReservations.Click
        TbModAdminCenter.SelectedTab = Me.TbEditReservation
    End Sub

    Private Sub PbEditBus_Click(sender As Object, e As EventArgs) Handles PbEditBus.Click
        TbModAdminCenter.SelectedTab = Me.TbEditBuses
    End Sub

    Private Sub PbEditUser_Click(sender As Object, e As EventArgs) Handles PbEditUser.Click
        TbModAdminCenter.SelectedTab = Me.TbEditUsers
    End Sub

    Private Sub DgvBusList_Admin_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvBusList_Admin.CellFormatting
        For Each Row As DataGridViewRow In DgvBusList_Admin.Rows
            If Row.Cells(5).Value > 20 Then
                Row.DefaultCellStyle.BackColor = Color.Yellow
            ElseIf Row.Cells(5).Value > 10 Then
                Row.DefaultCellStyle.BackColor = Color.IndianRed
            ElseIf Row.Cells(5).Value = 0 Then
                Row.DefaultCellStyle.BackColor = Color.DarkGray
            End If
        Next
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

    Private Sub BtnResetDetails_Click(sender As Object, e As EventArgs) Handles BtnResetDetails.Click
        LblBusName.Tag = "BusInputFalse"
        BtnBookNow.Enabled = False
        BtnConfirmEmail.Enabled = True
        LblBusName.Text = "Bus Name"
        LblTimeOfDepart.Text = "00:00(AM/PM)"
        LblDateOfDepart.Text = "MM/DD"
        LblPlateNumber.Text = "Plate Number"
        LblPointA.Text = "Location"
        LblAssignedSeat.Text = "N/A"
        LblPointB.Text = "Destination Point"
        LblAvailableSeats.Text = "00"
        LblPrice.Text = "0"
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

    Private Sub BtnBookNow_Click(sender As Object, e As EventArgs) Handles BtnBookNow.Click
        Sql = "SELECT UniqueID, FullName, BusName, Location, Destination, TimeOfDeparture, DateOfDeparture FROM BusPassengers WHERE UniqueID ='" &
            LblUniqueID_Booking.Text & "' AND FullName ='" & LblFullName_Booking.Text & "' AND BusName ='" & LblBusName.Text & "' AND Location ='" &
            LblPointA.Text & "' AND Destination ='" & LblPointB.Text & "' AND TimeOfDeparture ='" & LblTimeOfDepart.Text & "' AND DateOfDeparture ='" &
            LblDateOfDepart.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            MessageBox.Show("This user have already booked this reservation with the exact same details.", "Error - Double booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf LblAvailableSeats.Text = 0 Then
            MessageBox.Show("This bus is now fully occupied. Try looking for another bus that has the same route.", "Bus fully occupied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("The following details will be booked for the user " + LblFullName_Booking.Text + " with the seat " + LblAssignedSeat.Text + " on Bus " + LblBusName.Text + " - Route " + LblPointA.Text + " -> " + LblPointB.Text + ". Proceed?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                CollectData.FromBookingDetails_Import(LblUniqueID_Booking.Text, LblUniqueID_MainMenu.Text, LblFullName_Booking.Text, LblLRN.Text, LblAssignedSeat.Text, LblBusName.Text,
                                                      LblPointA.Text, LblPointB.Text, LblTimeOfDepart.Text, LblDateOfDepart.Text, LblPlateNumber.Text, LblPrice.Text)
                FrmReceipt.Tag = "PURCHASED_BY_ADMINISTRATOR"
                MessageBox.Show("Booking details has been reserved successfully.", "Your reservation has been reserved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CollectData.FromBookingDetails_ToReceipt(LblAssignedSeat, LblLocalServerDate_Time, LblDateOfDepart, LblTimeOfDepart, LblBusName, LblPointA, LblPointB, LblPlateNumber, LblFullName_Booking, LblUniqueID_Booking, LblPrice)
                FrmReceipt.Show()
                CollectData.ToDeductSeatFromBus(LblPlateNumber.Text, LblBusName.Text)
                DgvBusList_Admin.DataSource = CollectData.FromBusList
                Authentication.RequestUserCredits(LblUniqueID_MainMenu.Text)
                Modify.GetReservationCount(LblReservationActive)

                LblBusName.Tag = "BusInputFalse"
                BtnBookNow.Enabled = False
                BtnConfirmEmail.Enabled = True
                BtnConfirmEmail.Text = "Confirm"
                BtnConfirmEmail.BackColor = Color.HotPink
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

                Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                While DataReader.Read
                    LblUniqueID_Booking.Text = DataReader("UniqueID")
                    LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
                    LblLRN_Booking.Text = DataReader("LRN")
                End While
            End If
        End If
    End Sub

    Private Sub BtnConfirmEmail_Click(sender As Object, e As EventArgs) Handles BtnConfirmEmail.Click
        If BtnConfirmEmail.Text = "Cancel" Then
            Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            While DataReader.Read
                LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
                LblUniqueID_Booking.Text = DataReader("UniqueID")
                LblLRN_Booking.Text = DataReader("LRN")

                LblBusName.Tag = "BusInputFalse"
                BtnBookNow.Enabled = False
                BtnConfirmEmail.Text = "Confirm"
                BtnConfirmEmail.BackColor = Color.HotPink
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
            End While
        Else
            If TxtEmail.Text = Nothing Then
                MessageBox.Show("Please enter the user's email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sql = "SELECT * FROM UserAccounts WHERE EmailAddress ='" & TxtEmail.Text & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                If DataReader.Read = True Then
                    If DataReader("UniqueID") = LblUniqueID_MainMenu.Text Then
                        MessageBox.Show("You can't book yourself in the book for someone page. Please click 'Book now' instead.", "You are booking yourself", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf DataReader("EmailAddress") = TxtEmail.Text Then
                        If MessageBox.Show("You will book for the user " + DataReader("FirstName") + " " + DataReader("LastName") +
                                       ". Do you want to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = vbYes Then
                            LblUniqueID_Booking.Text = DataReader("UniqueID")
                            LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
                            LblLRN_Booking.Text = DataReader("LRN")
                            TxtEmail.Enabled = False
                            PnlBookingCenter.Enabled = True
                            BtnConfirmEmail.Text = "Cancel"
                            BtnConfirmEmail.BackColor = Color.IndianRed
                        End If
                    End If
                Else
                    MessageBox.Show("No user has been found associated with this email.", "User email not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub CmbFilterBusName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFilterBusName.SelectedIndexChanged
        DgvBookReservations.DataSource = CollectData.AllUserReservation(CmbFilterBusName.Text)
    End Sub

    Private Sub DgvBookReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBookReservations.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBookReservations.Rows(Index)

            PnlButtons.Enabled = True

            LblFullName_Reserve.Text = SelectedRow.Cells(0).Value.ToString
            LblSeatCode_Reserve.Text = SelectedRow.Cells(1).Value.ToString
            LblBusName_Reserve.Text = SelectedRow.Cells(2).Value.ToString
            LblTime_Reserve.Text = SelectedRow.Cells(3).Value.ToString
            LblDate_Reserve.Text = SelectedRow.Cells(4).Value.ToString

            Sql = "SELECT UniqueID, Location, Destination, PlateNumber, IsApproved, IsArrived, LRN FROM BusPassengers WHERE FullName ='" & SelectedRow.Cells(0).Value.ToString &
                "' AND BusName ='" & SelectedRow.Cells(2).Value.ToString & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblLRN_Reserve.Text = DataReader("LRN")
                LblPointA_Reserve.Text = DataReader("Location")
                LblPointB_Reserve.Text = DataReader("Destination")
                LblPlateNum_Reserve.Text = DataReader("PlateNumber")
                LblUniqueID_Reserve.Text = DataReader("UniqueID")

                If DataReader("IsApproved") = False Then
                    LblStatus_Reserve.ForeColor = Color.LightSalmon
                    LblStatus_Reserve.Text = "Pending approval"
                    BtnApprove.Enabled = True
                    BtnDenyBooking.Enabled = True
                Else
                    LblStatus_Reserve.ForeColor = Color.LawnGreen
                    LblStatus_Reserve.Text = "Approved"
                    BtnApprove.Enabled = False
                    BtnDenyBooking.Enabled = False
                End If
            End While
        End If
    End Sub

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles BtnApprove.Click
        CollectData.SetApprovalState_2(True, LblFullName_Reserve.Text)
        MessageBox.Show("User " + LblFullName_Reserve.Text + "'s  reservartion has been approved", "User reservation approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DgvBookReservations.DataSource = CollectData.AllUserReservation(CmbFilterBusName.Text)
        PnlButtons.Enabled = False
        Modify.GetReservationCount(LblReservationActive)
        LblBusName_Reserve.Text = "Bus Name"
        LblFullName_Reserve.Text = "Full Name"
        LblLRN_Reserve.Text = "LOA-XXXXXX"
        LblPlateNum_Reserve.Text = "Plate Number"
        LblDate_Reserve.Text = "MM/DD"
        LblTime_Reserve.Text = "00:00(P/A)"
        LblPointA_Reserve.Text = "Location"
        LblPointB_Reserve.Text = "Destination"
        LblSeatCode_Reserve.Text = "A0"
        LblStatus_Reserve.Text = "---"
    End Sub

    Private Sub BtnDenyBooking_Click(sender As Object, e As EventArgs) Handles BtnDenyBooking.Click
        frmDenyCancel_Reason.Tag = "DENY"
        frmDenyCancel_Reason.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        frmDenyCancel_Reason.Tag = "DELETE"
        frmDenyCancel_Reason.Show()
    End Sub

    Private Sub DgvBusList_Editing_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBusList_Editing.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBusList_Editing.Rows(Index)

            BtnClearBus_EditBus.Enabled = True

            LblBusName_EditBus.Text = SelectedRow.Cells(1).Value.ToString
            LblPlateNum_EditBus.Text = SelectedRow.Cells(0).Value.ToString

            Sql = "SELECT PointA, PointB, TimeOfDeparture, DateOfDeparture, AvailableSeats, Price FROM BusList WHERE PlateNumber ='" & SelectedRow.Cells(0).Value.ToString & "' AND BusName ='" & SelectedRow.Cells(1).Value.ToString & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblLocation_EditBus.Text = DataReader("PointA")
                LblDestination_EditBus.Text = DataReader("PointB")
                LblTime_EditBus.Text = DataReader("TimeOfDeparture")
                LblDate_EditBus.Text = DataReader("DateOfDeparture")
                LblSeatsAvailable_EditBus.Text = DataReader("AvailableSeats")
                LblFare_EditBus.Text = DataReader("Price")
            End While

            If Val(LblSeatsAvailable_EditBus.Text) > 35 Then
                LblSeatsAvailable_EditBus.ForeColor = Color.LightGreen
            ElseIf Val(LblSeatsAvailable_EditBus.Text) > 15 Then
                LblSeatsAvailable_EditBus.ForeColor = Color.Orange
            ElseIf Val(LblSeatsAvailable_EditBus.Text) > 1 Then
                LblSeatsAvailable_EditBus.ForeColor = Color.IndianRed
            Else
                LblSeatsAvailable_EditBus.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub BtnClearBus_EditBus_Click(sender As Object, e As EventArgs) Handles BtnClearBus_EditBus.Click
        If MessageBox.Show("Do you want to clear and delete bus " + LblBusName_EditBus.Text + "? Users can't book a reservation to this bus anymore if proceed. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.DeleteBusList(LblBusName_EditBus.Text, LblPlateNum_EditBus.Text)
            MessageBox.Show("Bus " + LblBusName_EditBus.Text + " has been successfully deleted", "Bus deleted successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DgvBusList_Admin.DataSource = CollectData.FromBusList
            DgvBusList_Editing.DataSource = CollectData.BusListEdit_Customized
            Modify.GetAvailableBus(LblAvailableBus)
            BtnClearBus_EditBus.Enabled = False
            LblBusName_EditBus.Text = "Bus Name"
            LblPlateNum_EditBus.Text = "Plate Number"
            LblLocation_EditBus.Text = "Location"
            LblDestination_EditBus.Text = "Destination"
            LblTime_EditBus.Text = "00:00(P/A)"
            LblDate_EditBus.Text = "MM/DD"
            LblSeatsAvailable_EditBus.Text = "00"
            LblSeatsAvailable_EditBus.ForeColor = Color.White
            LblFare_EditBus.Text = "00"
        End If
    End Sub

    Private Sub TxtSearchLRN_EditUsers_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchLRN_EditUsers.TextChanged
        If TxtSearchLRN_EditUsers.Text.Length > 0 Then
            If Not IsNumeric(TxtSearchLRN_EditUsers.Text) Then
                Dim Selection As Integer = TxtSearchLRN_EditUsers.SelectionStart
                TxtSearchLRN_EditUsers.Text = TxtSearchLRN_EditUsers.Text.Remove(Selection - 1, 1)
                TxtSearchLRN_EditUsers.SelectionStart = Selection - 1
            End If
        End If

        DgvUserList.DataSource = SearchEngine.CheckLRN_Changed(TxtSearchLRN_EditUsers)

        If TxtSearchLRN_EditUsers.Text = "" Then
            DgvUserList.DataSource = CollectData.UserList()
        End If
    End Sub

    Private Sub DgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUserList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvUserList.Rows(Index)


            Sql = "SELECT * FROM UserAccounts WHERE LRN =" & SelectedRow.Cells(0).Value & ""
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                If DataReader("Activation") = True Then
                    LblActiveStatus_EditUser.Text = "Active"
                    LblActiveStatus_EditUser.ForeColor = Color.LightGreen
                    BtnActivateUser.Enabled = False
                    BtnDeactivateUser.Enabled = True
                Else
                    LblActiveStatus_EditUser.Text = "Inactive"
                    LblActiveStatus_EditUser.ForeColor = Color.LightCoral
                    BtnActivateUser.Enabled = True
                    BtnDeactivateUser.Enabled = False
                End If

                LblLastName_EditUser.Text = DataReader("LastName")
                LblFirstName_EditUser.Text = DataReader("FirstName")
                LblUsername_EditUser.Text = DataReader("Username")
                LblLRN_EditUser.Text = DataReader("LRN")
                LblUniqueID_EditUser.Text = DataReader("UniqueID")
                LblEmail_EditUser.Text = DataReader("EmailAddress")
                LblBDay_EditUser.Text = DataReader("Birthdate").ToString
                LblAccType_EditUser.Text = DataReader("AccountType")

                Dim UserImage As String = DataReader("UniqueID") & ".jpg"
                Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

                If System.IO.File.Exists(ImagePath & UserImage) Then
                    PbProfilePicture.Image = Image.FromFile(ImagePath & UserImage)
                Else
                    PbProfilePicture.Image = PbProfilePicture.InitialImage
                End If
            End While
        End If
    End Sub

    Private Sub BtnActivateUser_Click(sender As Object, e As EventArgs) Handles BtnActivateUser.Click
        If MessageBox.Show("Do you want to activate user " + LblFirstName_EditUser.Text + " " + LblLastName_EditUser.Text + "?", "Confirm account activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.AccountActivation(LblUniqueID_EditUser.Text, True)
            MessageBox.Show("User " + LblFirstName_EditUser.Text + " " + LblLastName_EditUser.Text + "has been activated successfully!", "Activation success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtSearchLRN_EditUsers.Text = Nothing
            DgvUserList.DataSource = CollectData.UserList()
            Modify.UserList_EditColumn(DgvUserList)

            BtnActivateUser.Enabled = False
            PbProfilePicture.Image = PbProfilePicture.InitialImage
            LblFirstName_EditUser.Text = "First Name"
            LblLastName_EditUser.Text = "Last Name"
            LblUniqueID_EditUser.Text = "LOA-XXXXXX"
            LblLRN_EditUser.Text = "000000000000"
            LblUsername_EditUser.Text = "Username"
            LblEmail_EditUser.Text = "Email"
            LblBDay_EditUser.Text = "MM/DD/YYYY"
            LblAccType_EditUser.Text = "///"
            LblActiveStatus_EditUser.Text = "N/A"
            LblActiveStatus_EditUser.ForeColor = Color.White
        End If
    End Sub

    Private Sub BtnDeactivateUser_Click(sender As Object, e As EventArgs) Handles BtnDeactivateUser.Click
        If MessageBox.Show("Do you want to deactivate user " + LblFirstName_EditUser.Text + " " + LblLastName_EditUser.Text + "?", "Confirm account deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.AccountActivation(LblUniqueID_EditUser.Text, False)
            MessageBox.Show("User " + LblFirstName_EditUser.Text + " " + LblLastName_EditUser.Text + "has been deactivated successfully.", "Deactivation success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtSearchLRN_EditUsers.Text = Nothing
            DgvUserList.DataSource = CollectData.UserList()
            Modify.UserList_EditColumn(DgvUserList)

            BtnDeactivateUser.Enabled = False
            PbProfilePicture.Image = PbProfilePicture.InitialImage
            LblFirstName_EditUser.Text = "First Name"
            LblLastName_EditUser.Text = "Last Name"
            LblUniqueID_EditUser.Text = "LOA-XXXXXX"
            LblLRN_EditUser.Text = "000000000000"
            LblUsername_EditUser.Text = "Username"
            LblEmail_EditUser.Text = "Email"
            LblBDay_EditUser.Text = "MM/DD/YYYY"
            LblAccType_EditUser.Text = "///"
            LblActiveStatus_EditUser.Text = "N/A"
            LblActiveStatus_EditUser.ForeColor = Color.White
        End If
    End Sub
End Class