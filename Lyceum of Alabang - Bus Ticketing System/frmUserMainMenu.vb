Imports System.Data.OleDb

Public Class frmUserMainMenu
    Private Sub FrmUserMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvBusList.DataSource = CollectData.FromBusList
        DgvBookList.DataSource = CollectData.FromDatabase_UserFilteredBooking

        Authentication.RequestUserCredits(LblUniqueID_MainMenu.Text)
        Authentication.OTPAuthenticated = False

        Modify.GetAvailableBus(LblAvailableBusCount)
        Modify.GetUsersReservation(LblUniqueID_MainMenu.Text, LblUserReservation)
        Modify.GetUserNotificationCount(LblUniqueID_MainMenu.Text)
        Modify.SystemAdvertise_Pb()

        Modify.OTP_CheckIfOn(LblUniqueID_MainMenu.Text)
        Modify.BookList_UserFiltered(DgvBookList)
        Modify.BusListDGV(DgvBusList)
        Modify.CheckProfilePicture_IfExist(LblUniqueID_MainMenu.Text)

        Modify.CheckIfPremiumDeadlineMeets(LblUniqueID_MainMenu.Text)

        Modify.SubscribeButton_Disallow(PnlSubscribeButton, LblUniqueID_MainMenu.Text)
        Modify.ProfileBanner_Premium(LblUniqueID_MainMenu.Text)
        Modify.PremiumAccount(frmLogin.TxtUsername.Text)
        Me.Text = "Welcome, " + LblFullName.Text + "."

        Modify.AutomaticApproveReservation(LblUniqueID_MainMenu.Text, LblFullName.Text, LblLRN.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblLocalServerTime_Date.Text = Now
    End Sub
    Private Sub PbHome_Click(sender As Object, e As EventArgs) Handles PbHome.Click
        TbControlCenter.SelectedTab = Me.TbHome
    End Sub

    Private Sub PbBook_Click(sender As Object, e As EventArgs) Handles PbBook.Click
        TbControlCenter.SelectedTab = Me.TbBook
    End Sub

    Private Sub PbBookList_Click(sender As Object, e As EventArgs) Handles PbBookList.Click
        TbControlCenter.SelectedTab = Me.TbBookingList
    End Sub

    Private Sub PbPremium_Click(sender As Object, e As EventArgs) Handles PbPremium.Click
        TbControlCenter.SelectedTab = Me.TbPremium
    End Sub

    Private Sub PbAccount_Click(sender As Object, e As EventArgs) Handles PbAccount.Click
        TbControlCenter.SelectedTab = Me.TbAccount
    End Sub

    Private Sub BtnTransactionHistory_Click(sender As Object, e As EventArgs) Handles BtnTransactionHistory.Click
        frmTransactionHistory.Show()
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
        ElseIf Val(LblPrice.Text) > Val(LblCreditScore.Text) Then
            MessageBox.Show("You don't have enough L-Credits to proceed this transaction. You may reload your L-Credits in the account menu", "Insufficient L-Credits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf LblAvailableSeats.Text = 0 Then
            MessageBox.Show("This bus is now fully occupied. Try looking for another bus that has the same route.", "Bus fully occupied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("The following details will be booked for the user " + LblFullName_Booking.Text + " with the seat " + LblAssignedSeat.Text + " on Bus " + LblBusName.Text + " - Route " + LblPointA.Text + " -> " + LblPointB.Text + ". Proceed?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                CollectData.FromBookingDetails_Import(LblUniqueID_Booking.Text, LblUniqueID_MainMenu.Text, LblFullName_Booking.Text, LblLRN.Text, LblAssignedSeat.Text, LblBusName.Text,
                                                      LblPointA.Text, LblPointB.Text, LblTimeOfDepart.Text, LblDateOfDepart.Text, LblPlateNumber.Text, LblPrice.Text)
                MessageBox.Show("Booking details has been reserved successfully.", "Your reservation has been reserved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CollectData.FromBookingDetails_ToReceipt(LblAssignedSeat, LblLocalServerTime_Date, LblDateOfDepart, LblTimeOfDepart, LblBusName, LblPointA, LblPointB, LblPlateNumber, LblFullName_Booking, LblUniqueID_Booking, LblPrice)
                FrmReceipt.Show()
                Authentication.DeductCreditScore_FromUser(LblUniqueID_MainMenu.Text, LblPrice.Text)
                CollectData.ToDeductSeatFromBus(LblPlateNumber.Text, LblBusName.Text)
                DgvBusList.DataSource = CollectData.FromBusList
                DgvBookList.DataSource = CollectData.FromDatabase_UserFilteredBooking
                Authentication.RequestUserCredits(LblUniqueID_MainMenu.Text)
                Modify.GetUsersReservation(LblUniqueID_MainMenu.Text, LblUserReservation)

                LblBusName.Tag = "BusInputFalse"
                BtnBookNow.Enabled = False
                BtnBookForSomeone.Enabled = True
                BtnBookForSomeone.BackColor = Color.DarkTurquoise
                TxtEmail.Enabled = True
                PnlBFSCenter.Visible = False
                BtnBookForSomeone.Text = "Book for someone"
                PnlBookingCenter.Enabled = False
                BtnOpenBook.Enabled = True
                BtnOpenBook.BackColor = Color.LightGreen
                LblTimeOfDepart.Text = "00:00(AM/PM)"
                LblDateOfDepart.Text = "MM/DD"
                BtnOpenBook.Text = "Book Now"
                LblBusName.Text = "Bus Name"
                LblPlateNumber.Text = "Plate Number"
                LblPointA.Text = "Location"
                LblPointB.Text = "Destination Point"
                LblAssignedSeat.Text = "N/A"
                LblAvailableSeats.Text = "00"
                LblPrice.Text = "0"

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

    Private Sub DgvBookList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBookList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBookList.Rows(Index)

            LblBusName_BookingList.Tag = "BusInputTrue"
            LblSeatCode_BookingList.Text = SelectedRow.Cells(1).Value.ToString
            LblBusName_BookingList.Text = SelectedRow.Cells(2).Value.ToString
            LblTime_BookingList.Text = SelectedRow.Cells(3).Value.ToString
            LblDate_BookingList.Text = SelectedRow.Cells(4).Value.ToString

            BtnCancelReservation.Enabled = True
            Authentication.CheckUserIfPremium_Booking(LblUniqueID_MainMenu.Text, 2)


            Sql = "SELECT Location, Destination, PlateNumber, IsApproved FROM BusPassengers WHERE Replica_UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblPointA_BookingList.Text = DataReader("Location")
                LblDestination_BookingList.Text = DataReader("Destination")
                LblPlateNumber_BookingList.Text = DataReader("PlateNumber")

                If DataReader("IsApproved") = False Then
                    LblUserBookStatus.ForeColor = Color.LightSalmon
                    LblUserBookStatus.Text = "Pending approval"
                Else
                    LblUserBookStatus.ForeColor = Color.LawnGreen
                    LblUserBookStatus.Text = "Approved"
                End If
            End While
        End If

        CollectData.ComputeRefundPrice(LblBusName_BookingList.Text, LblPlateNumber_BookingList.Text)
        LblRefundAmount.ForeColor = Color.LightCoral
    End Sub

    Private Sub DgvBusList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBusList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBusList.Rows(Index)

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

        Authentication.CheckUserIfPremium_Booking(LblUniqueID_MainMenu.Text, 1)
    End Sub

    Private Sub DgvBusList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvBusList.CellFormatting
        For Each Row As DataGridViewRow In DgvBusList.Rows
            If Row.Cells(5).Value > 20 Then
                Row.DefaultCellStyle.BackColor = Color.Yellow
            ElseIf Row.Cells(5).Value > 10 Then
                Row.DefaultCellStyle.BackColor = Color.IndianRed
            ElseIf Row.Cells(5).Value = 0 Then
                Row.DefaultCellStyle.BackColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub BtnOpenBook_Click(sender As Object, e As EventArgs) Handles BtnOpenBook.Click
        If BtnOpenBook.Text = "Book Now" Then
            PnlBookingCenter.Enabled = True
            BtnOpenBook.BackColor = Color.IndianRed
            BtnBookForSomeone.Enabled = False
            BtnOpenBook.Text = "Cancel"
        Else
            LblBusName.Tag = "BusInputFalse"
            BtnBookNow.Enabled = False
            BtnBookForSomeone.Enabled = True
            PnlBookingCenter.Enabled = False
            BtnOpenBook.BackColor = Color.LightGreen
            LblTimeOfDepart.Text = "00:00(AM/PM)"
            LblDateOfDepart.Text = "MM/DD"
            BtnOpenBook.Text = "Book Now"
            LblBusName.Text = "Bus Name"
            LblPlateNumber.Text = "Plate Number"
            LblPointA.Text = "Location"
            LblPointB.Text = "Destination Point"
            LblAssignedSeat.Text = "N/A"
            LblAvailableSeats.Text = "00"
            LblPrice.Text = "0"
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

    Private Sub BtnCancelReservation_Click(sender As Object, e As EventArgs) Handles BtnCancelReservation.Click
        If LblUserBookStatus.Text = "Approved" Then
            MessageBox.Show("This book reservation has been marked as approved by the bus' conductor. You can't cancel this reservation. Please contact the conductor or the administration regarding this.", "Reservation has been approved.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Sql = "SELECT * FROM BusPassengers WHERE Replica_UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            If DataReader.Read = True Then
                If MessageBox.Show("Do you want to proceed cancelling the reservation - " + DataReader("Location") + " to " + DataReader("Destination") + " for the user " + DataReader("FullName"), "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    CollectData.FromCancellation_Transact(DataReader("UniqueID"), LblUniqueID_MainMenu.Text, LblFullName.Text, LblBusName_BookingList.Text, LblPlateNumber_BookingList.Text, LblPointA_BookingList.Text, LblDestination_BookingList.Text, LblRefundAmount.Text, LblTime_BookingList.Text, LblDate_BookingList.Text, LblLocalServerTime_Date.Text)
                    CollectData.DeletePassengerData(LblUniqueID_MainMenu.Text, LblSeatCode_BookingList.Text, LblBusName_BookingList.Text, LblPointA_BookingList.Text, LblDestination_BookingList.Text, LblTime_BookingList.Text, LblDate_BookingList.Text, LblPlateNumber_BookingList.Text)
                    CollectData.ToAddSeatFromBus(LblPlateNumber_BookingList.Text, LblBusName_BookingList.Text)
                    MessageBox.Show("Your reservation has been cancelled and your L-Credits has been refunded", "Cancellation success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DgvBusList.DataSource = CollectData.FromBusList
                    DgvBookList.DataSource = CollectData.FromDatabase_UserFilteredBooking
                    Authentication.RefundBackCreditScore_ToUser(LblUniqueID_MainMenu.Text, LblRefundAmount.Text)
                    Authentication.RequestUserCredits(LblUniqueID_MainMenu.Text)
                    Modify.GetUsersReservation(LblUniqueID_MainMenu.Text, LblUserReservation)

                    PnlLCreditConverter.Visible = False
                    BtnCancelReservation.Enabled = False
                    LblBusName_BookingList.Text = "Bus Name"
                    LblPlateNumber_BookingList.Text = "Plate Number"
                    LblSeatCode_BookingList.Text = "Seat Code"
                    LblTime_BookingList.Text = "00:00PA"
                    LblDate_BookingList.Text = "MM/DD"
                    LblPointA_BookingList.Text = "Location"
                    LblDestination_BookingList.Text = "Destination"
                    LblUserBookStatus.Text = "---"
                    LblOriginalPrice.Text = "00"
                    LblRefundAmount.Text = "00"
                    LblRefundAmount.ForeColor = Color.White
                    LblUserBookStatus.ForeColor = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub BtnResetDetails_Click(sender As Object, e As EventArgs) Handles BtnResetDetails.Click
        LblBusName.Tag = "BusInputFalse"
        BtnBookNow.Enabled = False
        BtnOpenBook.Enabled = True
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

    Private Sub BtnBookForSomeone_Click(sender As Object, e As EventArgs) Handles BtnBookForSomeone.Click
        If PnlBFSCenter.Visible = False Then
            PnlBFSCenter.Visible = True
            BtnBookForSomeone.Text = "Cancel"
            BtnBookForSomeone.BackColor = Color.IndianRed
            BtnConfirmEmail.Enabled = True
            TxtEmail.Enabled = True
            TxtEmail.Text = Nothing
            FrmReceipt.Tag = "PURCHASED_FOR_SOMEONE"
        Else
            FrmReceipt.Tag = "PURCHASED_BY_YOU"
            LblBusName.Tag = "BusInputFalse"
            BtnOpenBook.Enabled = True
            PnlBookingCenter.Enabled = False
            CollectData.RefreshUserData_ToBooking()
            PnlBFSCenter.Visible = False
            TxtEmail.Text = Nothing
            LblTimeOfDepart.Text = "00:00(AM/PM)"
            LblDateOfDepart.Text = "MM/DD"
            BtnOpenBook.Text = "Book Now"
            LblBusName.Text = "Bus Name"
            LblPlateNumber.Text = "Plate Number"
            LblPointA.Text = "Location"
            LblPointB.Text = "Destination Point"
            LblAvailableSeats.Text = "00"
            LblPrice.Text = "0"
            LblAssignedSeat.Text = "N/A"
            BtnBookForSomeone.Text = "Book for someone"
            BtnBookForSomeone.BackColor = Color.DarkTurquoise
        End If
    End Sub

    Private Sub BtnChangePicture_Click(sender As Object, e As EventArgs) Handles BtnChangePicture.Click
        If BtnChangePicture.Text = "Remove" Then
            BtnSaveImage.Visible = False
            BtnChangePicture.BackColor = Color.PaleTurquoise
            BtnChangePicture.Text = "Change"
            Modify.CheckProfilePicture_IfExist(LblUniqueID_MainMenu.Text)
        Else
            Modify.Picture_Select(PbProfilePicture, LblUniqueID_MainMenu.Text)
        End If
    End Sub

    Private Sub BtnConfirmEmail_Click(sender As Object, e As EventArgs) Handles BtnConfirmEmail.Click
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
                        BtnOpenBook.Enabled = False
                        BtnConfirmEmail.Enabled = False
                        TxtEmail.Enabled = False
                        PnlBookingCenter.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("No user has been found associated with this email.", "User email not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnSubscribeButton_Click(sender As Object, e As EventArgs) Handles BtnSubscribeButton.Click
        If MessageBox.Show("You are only a few steps away from getting your premium membership. Before continuing, make sure that you read the information page about our premium membership so you better understand what you get. One more thing: once paying for the membership, please only pay in the exact amount of 55 pesos. Thank you!", "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            frmPayment_Subscribe.Show()
        End If
    End Sub

    Private Sub BtnSaveImage_Click(sender As Object, e As EventArgs) Handles BtnSaveImage.Click
        If MessageBox.Show("Before continuing, make sure you profile picture doesn't contain any material that is sensitive or controversial. Do you want to change your profile picture?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If PbProfilePicture.Image IsNot Nothing Then
                Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures"
                Dim NewFile As String = LblUniqueID_MainMenu.Text & ".jpg"

                PbProfilePicture.Image.Save(ImagePath & "\" & NewFile, System.Drawing.Imaging.ImageFormat.Jpeg)

                MessageBox.Show("Your profile picture has been saved!", "Profile picture changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Modify.CheckProfilePicture_IfExist(LblUniqueID_MainMenu.Text)
                BtnSaveImage.Visible = False
                BtnChangePicture.Text = "Change"
                BtnChangePicture.BackColor = Color.PaleTurquoise
            End If
        End If
    End Sub

    Private Sub BtnChangeUsername_Click(sender As Object, e As EventArgs) Handles BtnChangeUsername.Click
        If BtnChangeUsername.Text = "Change" Then
            TxtUsername_Account.Enabled = True
            BtnSaveUsername_Account.Visible = True
            BtnChangeUsername.Text = "Back"
            BtnChangeUsername.BackColor = Color.IndianRed
        Else
            Sql = "SELECT Username FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                TxtUsername_Account.Text = DataReader("Username")
            End While

            TxtUsername_Account.Enabled = False
            BtnSaveUsername_Account.Visible = False
            BtnChangeUsername.Text = "Change"
            BtnChangeUsername.BackColor = Color.Plum
        End If
    End Sub

    Private Sub BtnChangeEmail_Account_Click(sender As Object, e As EventArgs) Handles BtnChangeEmail_Account.Click
        Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If BtnChangeEmail_Account.Text = "Back" Then
            TxtEmail_Account.Enabled = False
            BtnSaveEmail_Account.Visible = False
            BtnChangeEmail_Account.Text = "Change"
            BtnChangeEmail_Account.BackColor = Color.Plum
        Else
            While DataReader.Read
                If DataReader("OTPEnabled") = True Then
                    If BtnChangeEmail_Account.Text = "Change" Then
                        frmOTPValidation.Tag = "CHANGE_EMAIL"
                        frmOTPValidation.Show()
                    Else
                        Sql = "SELECT EmailAddress FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
                        Command = New OleDbCommand(Sql, Connection)
                        DataReader = Command.ExecuteReader

                        While DataReader.Read
                            TxtEmail_Account.Text = DataReader("EmailAddress")
                        End While

                        TxtEmail_Account.Enabled = False
                        BtnSaveEmail_Account.Visible = False
                        BtnChangeEmail_Account.Text = "Change"
                        BtnChangeEmail_Account.BackColor = Color.Plum
                    End If
                Else
                    TxtEmail_Account.Enabled = True
                    BtnSaveEmail_Account.Visible = True
                    BtnChangeEmail_Account.Text = "Back"
                    BtnChangeEmail_Account.BackColor = Color.IndianRed
                End If
            End While
        End If
    End Sub

    Private Sub BtnSaveUsername_Account_Click(sender As Object, e As EventArgs) Handles BtnSaveUsername_Account.Click
        If MessageBox.Show("Are you sure you want to change your username from " + LblAccount_Username.Text + " to " + TxtUsername_Account.Text + "?", "Confirm username change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.UpdateUsername(LblUniqueID_MainMenu.Text, TxtUsername_Account.Text)
            MessageBox.Show("New username has been applied to your account", "Username change successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Sql = "SELECT Username FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblAccount_Username.Text = DataReader("Username")
                LblUsername.Text = DataReader("Username")
                TxtUsername_Account.Text = DataReader("Username")
            End While

            TxtUsername_Account.Enabled = False
            BtnSaveUsername_Account.Visible = False
            BtnChangeUsername.Text = "Change"
            BtnChangeUsername.BackColor = Color.Plum
        End If

    End Sub

    Private Sub BtnSaveEmail_Account_Click(sender As Object, e As EventArgs) Handles BtnSaveEmail_Account.Click
        If MessageBox.Show("Are you sure you want to change your email to " + TxtUsername_Account.Text + "?", "Confirm email change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.UpdateEmail(LblUniqueID_MainMenu.Text, TxtEmail_Account.Text)
            MessageBox.Show("New email addresss has been applied to your account", "Username change successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Sql = "SELECT EmailAddress FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                TxtEmail_Account.Text = DataReader("EmailAddress")
            End While

            TxtEmail_Account.Enabled = False
            BtnSaveEmail_Account.Visible = False
            BtnChangeEmail_Account.Text = "Change"
            BtnChangeEmail_Account.BackColor = Color.Plum
        End If
    End Sub

    Private Sub BtnLCredits_CashIn_Click(sender As Object, e As EventArgs) Handles BtnLCredits_CashIn.Click
        frmLCredits_CashIn.Show()
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("OTPEnabled") = True Then
                frmOTPValidation.Show()
                frmOTPValidation.Tag = "CHANGE_PASSWORD"
            Else
                frmChangePassword.Show()
            End If
        End While
    End Sub

    Private Sub BtnDeactivateAccount_Click(sender As Object, e As EventArgs) Handles BtnDeactivateAccount.Click
        If MessageBox.Show("Deactivating your account may result to lose your L-Credits, transactions, reservations, and maybe remove you from the account list. If you want to deactivate your account due to security reason, reach out to the admins or send feedback on the 'Send Feedback' page. Deactivate continue?", "Confirm deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_MainMenu.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                If DataReader("OTPEnabled") = True Then
                    frmOTPValidation.Show()
                    frmOTPValidation.Tag = "DEACTIVATE_ACCOUNT"
                Else
                    CollectData.AccountActivation(LblUniqueID_MainMenu.Text, False)
                    MessageBox.Show("Account has been deactivated. You will be logged out from this session", "Account deactivated successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmOTPValidation.Tag = Nothing
                End If
            End While
        End If
    End Sub

    Private Sub BtnSendFeedback_Click(sender As Object, e As EventArgs) Handles BtnSendFeedback.Click
        frmSendFeedback.Show()
    End Sub

    Private Sub BtnOTP_Account_Click(sender As Object, e As EventArgs) Handles BtnOTP_Account.Click
        If BtnOTP_Account.Text = "OTP Disabled" Then
            If MessageBox.Show("OTP is your one-time access on changing your credentials, as well as safeguarding your account. Do you want to enable OTP?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                frmAddOTP.Show()
            End If
        ElseIf BtnOTP_Account.Text = "OTP Enabled" Then
            If MessageBox.Show("Your OTP is enabled. If you wish to change your OTP, press Ok", "OTP enabled", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = vbOK Then
                frmOTPValidation.Tag = "CHANGE_OTP"
                frmOTPValidation.Show()
            End If
        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        frmUserNotification.Show()
    End Sub

    Private Sub BtnSubscription_PayAgain_Click(sender As Object, e As EventArgs) Handles BtnSubscription_PayAgain.Click
        If MessageBox.Show("Renewing your Premium Membership is as easy as you purchase your Premium Membership! Just enter the reference number and your premium membership will renew (for +30 from your membership due date.) Continue?", "Renew membership", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmPayment_Subscribe.Show()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.TxtPassword.Text = Nothing
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Lyceum of Alabang - Bus Ticketing System (Version 2.0.0 - B092381811032). Developed by G1 Technologies.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LnkMoreInfo_Premium_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMoreInfo_Premium.LinkClicked
        frmPremiumMembershipInformation.Show()
    End Sub

    Private Sub BtnChangeBanner_Click(sender As Object, e As EventArgs) Handles BtnChangeBanner.Click
        If BtnChangeBanner.Text = "Remove" Then
            BtnSaveBanner.Visible = False
            BtnChangeBanner.BackColor = Color.PaleTurquoise
            BtnChangeBanner.Text = "Change"
            Modify.ProfileBanner_Premium(LblUniqueID_MainMenu.Text)
        Else
            MessageBox.Show("Your profile banner size must be 461x111. If the size exceeds, your banner will result to a stretch image. Continue?", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Modify.Picture_Select_Banner(PbUserProfileBanner, LblUniqueID_MainMenu.Text)
            End If
    End Sub

    Private Sub BtnSaveBanner_Click(sender As Object, e As EventArgs) Handles BtnSaveBanner.Click
        If MessageBox.Show("Before continuing, make sure you profile banner doesn't contain any material that is sensitive or controversial. Do you want to change your profile banner?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If PbUserProfileBanner.Image IsNot Nothing Then
                Dim ImagePath As String = Application.StartupPath & "\frmUserProfileBanners"
                Dim NewBanner As String = LblUniqueID_MainMenu.Text & ".jpg"

                PbUserProfileBanner.Image.Save(ImagePath & "\" & NewBanner, System.Drawing.Imaging.ImageFormat.Jpeg)

                MessageBox.Show("Your profile banner has been updated.", "Profile banner changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Modify.ProfileBanner_Premium(LblUniqueID_MainMenu.Text)
                BtnSaveBanner.Visible = False
                BtnChangeBanner.Text = "Change"
                BtnChangeBanner.BackColor = Color.PaleTurquoise
            End If
        End If
    End Sub
End Class