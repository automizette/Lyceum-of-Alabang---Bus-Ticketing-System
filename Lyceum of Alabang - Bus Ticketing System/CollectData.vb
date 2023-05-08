Imports System.Data.OleDb
Imports Microsoft.SqlServer.Server

Public Class CollectData

    Public Shared BookingImportingValidation_UniqueID As String

    Public Shared Sub FromSeat(PlateNumber As String)
        'FROM A SEAT COLUMN
        CheckBusData.Seats("A1", PlateNumber, frmSeatPicker.PictureBox1)
        CheckBusData.Seats("A2", PlateNumber, frmSeatPicker.PictureBox2)
        CheckBusData.Seats("A3", PlateNumber, frmSeatPicker.PictureBox3)
        CheckBusData.Seats("A4", PlateNumber, frmSeatPicker.PictureBox4)
        CheckBusData.Seats("A5", PlateNumber, frmSeatPicker.PictureBox5)
        'FROM B SEAT COLUMN
        CheckBusData.Seats("B1", PlateNumber, frmSeatPicker.PictureBox10)
        CheckBusData.Seats("B2", PlateNumber, frmSeatPicker.PictureBox9)
        CheckBusData.Seats("B3", PlateNumber, frmSeatPicker.PictureBox8)
        CheckBusData.Seats("B4", PlateNumber, frmSeatPicker.PictureBox7)
        CheckBusData.Seats("B5", PlateNumber, frmSeatPicker.PictureBox6)
        'FROM C SEAT COLUMN
        CheckBusData.Seats("C1", PlateNumber, frmSeatPicker.PictureBox15)
        CheckBusData.Seats("C2", PlateNumber, frmSeatPicker.PictureBox14)
        CheckBusData.Seats("C3", PlateNumber, frmSeatPicker.PictureBox13)
        CheckBusData.Seats("C4", PlateNumber, frmSeatPicker.PictureBox12)
        CheckBusData.Seats("C5", PlateNumber, frmSeatPicker.PictureBox11)
        'FROM D SEAT COLUMN
        CheckBusData.Seats("D1", PlateNumber, frmSeatPicker.PictureBox20)
        CheckBusData.Seats("D2", PlateNumber, frmSeatPicker.PictureBox19)
        CheckBusData.Seats("D3", PlateNumber, frmSeatPicker.PictureBox18)
        CheckBusData.Seats("D4", PlateNumber, frmSeatPicker.PictureBox17)
        CheckBusData.Seats("D5", PlateNumber, frmSeatPicker.PictureBox16)
        'FROM E SEAT COLUMN
        CheckBusData.Seats("E1", PlateNumber, frmSeatPicker.PictureBox25)
        CheckBusData.Seats("E2", PlateNumber, frmSeatPicker.PictureBox24)
        CheckBusData.Seats("E3", PlateNumber, frmSeatPicker.PictureBox23)
        CheckBusData.Seats("E4", PlateNumber, frmSeatPicker.PictureBox22)
        CheckBusData.Seats("E5", PlateNumber, frmSeatPicker.PictureBox21)
        'FROM F SEAT COLUMN
        CheckBusData.Seats("F1", PlateNumber, frmSeatPicker.PictureBox30)
        CheckBusData.Seats("F2", PlateNumber, frmSeatPicker.PictureBox29)
        CheckBusData.Seats("F3", PlateNumber, frmSeatPicker.PictureBox28)
        CheckBusData.Seats("F4", PlateNumber, frmSeatPicker.PictureBox27)
        CheckBusData.Seats("F5", PlateNumber, frmSeatPicker.PictureBox26)
        'FROM G SEAT COLUMN
        CheckBusData.Seats("G1", PlateNumber, frmSeatPicker.PictureBox35)
        CheckBusData.Seats("G2", PlateNumber, frmSeatPicker.PictureBox34)
        CheckBusData.Seats("G3", PlateNumber, frmSeatPicker.PictureBox33)
        CheckBusData.Seats("G4", PlateNumber, frmSeatPicker.PictureBox32)
        CheckBusData.Seats("G5", PlateNumber, frmSeatPicker.PictureBox31)
        'FROM H SEAT COLUMN
        CheckBusData.Seats("H1", PlateNumber, frmSeatPicker.PictureBox40)
        CheckBusData.Seats("H2", PlateNumber, frmSeatPicker.PictureBox39)
        CheckBusData.Seats("H3", PlateNumber, frmSeatPicker.PictureBox38)
        CheckBusData.Seats("H4", PlateNumber, frmSeatPicker.PictureBox36)
        CheckBusData.Seats("H5", PlateNumber, frmSeatPicker.PictureBox37)
        'FROM I SEAT COLUMN
        CheckBusData.Seats("I1", PlateNumber, frmSeatPicker.PictureBox45)
        CheckBusData.Seats("I2", PlateNumber, frmSeatPicker.PictureBox44)
        CheckBusData.Seats("I3", PlateNumber, frmSeatPicker.PictureBox43)
        CheckBusData.Seats("I4", PlateNumber, frmSeatPicker.PictureBox42)
        CheckBusData.Seats("I5", PlateNumber, frmSeatPicker.PictureBox41)
        'FROM J SEAT COLUMN
        CheckBusData.Seats("J1", PlateNumber, frmSeatPicker.PictureBox50)
        CheckBusData.Seats("J2", PlateNumber, frmSeatPicker.PictureBox49)
        CheckBusData.Seats("J3", PlateNumber, frmSeatPicker.PictureBox48)
        CheckBusData.Seats("J4", PlateNumber, frmSeatPicker.PictureBox47)
        CheckBusData.Seats("J5", PlateNumber, frmSeatPicker.PictureBox46)
        'FROM K SEAT COLUMN
        CheckBusData.Seats("K1", PlateNumber, frmSeatPicker.PictureBox55)
        CheckBusData.Seats("K2", PlateNumber, frmSeatPicker.PictureBox54)
        CheckBusData.Seats("K3", PlateNumber, frmSeatPicker.PictureBox53)
        CheckBusData.Seats("K4", PlateNumber, frmSeatPicker.PictureBox52)
        CheckBusData.Seats("K5", PlateNumber, frmSeatPicker.PictureBox51)
    End Sub

    Public Shared Sub SubmitFeedbackByUser(UniqueID As String, FullName As String, FeedbackType As String, DateOfSub As String, Title As String, Desc As String, FID As Integer)
        Sql = "INSERT INTO UserFeedbacks([UniqueID],[UserFullName],[FeedbackType],[DateOfSubmission],[FeedbackTitle],[FeedbackDescription],[FeedbackNumber])VALUES('" &
            UniqueID & "','" & FullName & "','" & FeedbackType & "','" & DateOfSub & "','" & Title & "','" & Desc & "'," & FID & ")"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ToSubmitReferenceNumber_LCredits(UniqueID As String, ReferenceNumber As Double, Price As Integer, DateRequested As Date)
        Sql = "INSERT INTO UserLCreditsReferenceNo([UniqueID],[ReferenceNumber],[Price],[DateRequested])VALUES('" & UniqueID & "'," & ReferenceNumber & "," & Price & ",'" & DateRequested & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub AccountActivation(UniqueID As String, ActiveStatus As Boolean)
        Sql = "UPDATE UserAccounts SET Activation =" & ActiveStatus & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteSpecificNotification(UniqueID As String)
        Sql = "DELETE FROM UserNotification WHERE NotifID =" & frmUserNotification.NotificationID & " AND (For_User ='" & UniqueID & "' OR For_User ='" & "ALL_USERS" & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteAllNotification(UniqueID As String)
        Sql = "DELETE FROM UserNotification WHERE For_User ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub TransactionHistoryFilters(ReplicaUniqueID As String, DataGrid As DataGridView, FilterType As Integer)
        Dim DGV As New DataTable

        Select Case FilterType
            Case 1
                DGV.Clear()
                Dim Transportation_Filtered As String = "Cash-in (L-Credits)"

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName, BusName, PlateNumber, Location, Destination, TimeOut, DateOut FROM TransactionHistory WHERE Replica_UniqueID ='" &
             ReplicaUniqueID & "' AND NOT TypeOfTransaction ='" & Transportation_Filtered & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 2
                DGV.Clear()
                Dim Transportation_Filtered As String = "Cash-in (L-Credits)"

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName FROM TransactionHistory WHERE Replica_UniqueID ='" &
             ReplicaUniqueID & "' AND TypeOfTransaction ='" & Transportation_Filtered & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 3
                Dim Transportation_Filtered As String = "Premium Membership
"
                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName FROM TransactionHistory WHERE Replica_UniqueID ='" &
             ReplicaUniqueID & "' AND TypeOfTransaction ='" & Transportation_Filtered & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 4
                DGV.Clear()

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName, BusName, PlateNumber, Location, Destination, TimeOut, DateOut FROM TransactionHistory WHERE Replica_UniqueID ='" &
             ReplicaUniqueID & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
        End Select
    End Sub

    Public Shared Sub UpdateUsername(UniqueID As String, NewUsername As String)
        Sql = "UPDATE UserAccounts SET Username ='" & NewUsername & "' WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()

        Sql = "UPDATE UserSettings SET Username ='" & NewUsername & "' WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub
    Public Shared Sub ChangePassword(UniqueID As String, Password As String)
        Sql = "UPDATE UserAccounts SET [Password] ='" & Password & "' WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub UpdateEmail(UniqueID As String, NewEmail As String)
        Sql = "UPDATE UserAccounts SET EmailAddress ='" & NewEmail & "' WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteSubscriptionDeadline(UniqueID As String)
        Sql = "DELETE FROM UserPremiumSubscription WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ChangePremiumState(UniqueID As String, State As Boolean)
        Sql = "UPDATE UserSettings SET IsPremium =" & State & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub InputReferenceNumber_Subscription(UniqueID As String, ReferenceNo As Double, DateToday As Date)
        Sql = "INSERT INTO UserSubscriptionReferenceNo([UniqueID],[ReferenceNumber],[RequestDate])VALUES('" & UniqueID & "'," & ReferenceNo & ",'" & DateToday & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub EditUserPremium_ToPending(UniqueID As String, Pending As Boolean)
        Sql = "UPDATE UserSettings SET IsPremiumPending =" & Pending & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ComputeRefundPrice(BusName As String, PlateNumber As String)
        Sql = "SELECT Price FROM BusList WHERE BusName ='" & BusName & "' AND PlateNumber ='" & PlateNumber & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            frmUserMainMenu.LblOriginalPrice.Text = DataReader("Price")
        End While

        Sql = "SELECT CancelReservation_Deduction FROM BookReservationSettings"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            frmUserMainMenu.LblRefundAmount.Text = Val(frmUserMainMenu.LblOriginalPrice.Text) - Val(DataReader("CancelReservation_Deduction"))
        End While
    End Sub

    Public Shared Sub ComputeRefundPrice_AdminMod(BusName As String, UniqueID As String)
        Sql = "SELECT Price FROM BusList WHERE BusName ='" & BusName & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        Dim OriginalPrice As Integer
        Dim RefundPrice As Integer

        While DataReader.Read
            OriginalPrice = DataReader("Price")
        End While

        Sql = "SELECT CancelReservation_Deduction FROM BookReservationSettings"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            RefundPrice = Val(OriginalPrice) - Val(DataReader("CancelReservation_Deduction"))
        End While

        Sql = "UPDATE UserAccounts SET CreditScore = CreditScore + " & RefundPrice & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub TransactCashIn_LCredits(UniqueID As String, ReplicaUniqueID As String, FullName As String, Price As String, DateTime As String)
        Dim TransactionNumber As Integer = ToGenerateTransactionNumber()
        Dim TypeOfTransaction As String = "Cash-in (L-Credits)"
        Dim NotAvailable As String = "Not Available"

        Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
            TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','+" & Price & "','" & NotAvailable & "','" &
            NotAvailable & "','" & DateTime & "','" & TypeOfTransaction & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub FromCancellation_Transact(UniqueID As String, ReplicaUniqueID As String, FullName As String, BusName As String, PlateNumber As String, Location As String, Destination As String, Price As String, TimeOut As String, DateOut As String, DOT As String)
        Dim TransactionNumber As Integer = ToGenerateTransactionNumber()
        Dim Type As String = "Refunded by you"

        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
                TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','" & "Free of charge (Premium)" & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Else
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
                TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','+" & Price & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            End If
        End While
    End Sub

    Public Shared Sub FromCancellation_AdminMod(UniqueID As String, ReplicaUniqueID As String, FullName As String, BusName As String, PlateNumber As String, Location As String, Destination As String, Price As String, TimeOut As String, DateOut As String, DOT As String)
        Dim TransactionNumber As Integer = ToGenerateTransactionNumber()
        Dim Type As String = "Transaction by administrator"

        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & frmModAdminMainMenu.LblUniqueID_Reserve.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
                TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','" & "Free of charge" & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Else
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
                TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','+" & Price & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            End If
        End While
    End Sub

    Public Shared Sub ToDeductSeatFromBus(PlateNumber As String, BusName As String)
        Sql = "UPDATE BusList SET AvailableSeats = AvailableSeats - 1 WHERE PlateNumber ='" & PlateNumber & "' AND BusName ='" & BusName & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ToAddSeatFromBus(PlateNumber As String, BusName As String)
        Sql = "UPDATE BusList SET AvailableSeats = AvailableSeats + 1 WHERE PlateNumber ='" & PlateNumber & "' AND BusName ='" & BusName & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteBusFromReservation(BusName As String, PlateNum As String, Location As String, Destination As String)
        Sql = "DELETE FROM BusPassengers WHERE BusName ='" & BusName & "' AND Location ='" & Location & "' AND Destination ='" & Destination & "' AND PlateNumber ='" & PlateNum & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeletePassengerData(ReplicaUniqueID As String, Seat As String, BusName As String, Location As String, Destination As String, Time As String, DateOfDepart As String, PlateNum As String)
        Sql = "DELETE FROM BusPassengers WHERE Replica_UniqueID ='" & ReplicaUniqueID & "' AND Seat ='" & Seat & "' AND BusName ='" & BusName & "' AND Location ='" & Location &
            "' AND Destination ='" & Destination & "' AND TimeOfDeparture ='" & Time & "' AND DateOfDeparture ='" & DateOfDepart & "' AND PlateNumber ='" & PlateNum & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Function FromDatabase_UserFilteredBooking()
        Dim DataTable_UserBook As New DataTable
        Sql = "SELECT FullName, Seat, BusName, TimeOfDeparture, DateOfDeparture FROM BusPassengers WHERE Replica_UniqueID ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        DataTable_UserBook.Load(DataReader)
        Return DataTable_UserBook
    End Function

    Public Shared Sub CmbBusFiltered(Cmb As ComboBox)
        Sql = "SELECT BusName FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        Cmb.Text = Nothing
        Cmb.Items.Clear()
        While DataReader.Read
            Cmb.Items.Add(DataReader("BusName"))
        End While
    End Sub

    Public Shared Function AllUserReservation(BusName As String)
        Dim UserReserves As New DataTable
        Sql = "SELECT FullName, Seat, BusName, TimeOfDeparture, DateOfDeparture FROM BusPassengers WHERE BusName ='" & BusName & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserReserves.Load(DataReader)
        Return UserReserves
    End Function

    Public Shared Sub FromBookingDetails_ToReceipt(AssignedSeatLbl As Label, LocalTimeLbl As Label, DODLbl As Label, TOD As Label, BusName As Label, PointA As Label, PointB As Label, PlateNum As Label, FullName As Label, UniqueID As Label, Price As Label)
        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & BookingImportingValidation_UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                FrmReceipt.LblTransactionID.Text = CollectData.ToGenerateTransactionNumber()
                FrmReceipt.LblPrice.Text = "Free of charge (Premium)"
                FrmReceipt.LblPrice.ForeColor = Color.Orange
                FrmReceipt.LblSeatCode_R1.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblSeatCode_R2.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblSeatCode_R3.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblDOT.Text = LocalTimeLbl.Text 'frmUserMainMenu.LblLocalServerTime_Date.Text
                FrmReceipt.LblDate.Text = DODLbl.Text 'frmUserMainMenu.LblDateOfDepart.Text
                FrmReceipt.LblTime.Text = TOD.Text 'frmUserMainMenu.LblTimeOfDepart.Text
                FrmReceipt.LblBusName.Text = BusName.Text 'frmUserMainMenu.LblBusName.Text
                FrmReceipt.LblPointA.Text = PointA.Text 'frmUserMainMenu.LblPointA.Text
                FrmReceipt.LblPointB.Text = PointB.Text 'frmUserMainMenu.LblPointB.Text
                FrmReceipt.LblPlateNumber.Text = PlateNum.Text 'frmUserMainMenu.LblPlateNumber.Text
                FrmReceipt.LblFullName.Text = FullName.Text 'frmUserMainMenu.LblFullName_Booking.Text
                FrmReceipt.LblUniqueID.Text = UniqueID.Text 'frmUserMainMenu.LblUniqueID_Booking.Text
            Else
                FrmReceipt.LblTransactionID.Text = CollectData.ToGenerateTransactionNumber()
                FrmReceipt.LblPrice.Text = "-" + Price.Text 'frmUserMainMenu.LblPrice.Text
                FrmReceipt.LblSeatCode_R1.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblSeatCode_R2.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblSeatCode_R3.Text = AssignedSeatLbl.Text 'frmUserMainMenu.LblAssignedSeat.Text
                FrmReceipt.LblDOT.Text = LocalTimeLbl.Text 'frmUserMainMenu.LblLocalServerTime_Date.Text
                FrmReceipt.LblDate.Text = DODLbl.Text 'frmUserMainMenu.LblDateOfDepart.Text
                FrmReceipt.LblTime.Text = TOD.Text 'frmUserMainMenu.LblTimeOfDepart.Text
                FrmReceipt.LblBusName.Text = BusName.Text 'frmUserMainMenu.LblBusName.Text
                FrmReceipt.LblPointA.Text = PointA.Text 'frmUserMainMenu.LblPointA.Text
                FrmReceipt.LblPointB.Text = PointB.Text 'frmUserMainMenu.LblPointB.Text
                FrmReceipt.LblPlateNumber.Text = PlateNum.Text 'frmUserMainMenu.LblPlateNumber.Text
                FrmReceipt.LblFullName.Text = FullName.Text 'frmUserMainMenu.LblFullName_Booking.Text
                FrmReceipt.LblUniqueID.Text = UniqueID.Text 'frmUserMainMenu.LblUniqueID_Booking.Text
            End If
        End While
    End Sub

    Public Shared Function ToGenerateTransactionNumber() As Integer
        Dim TID As Integer
        Sql = "SELECT MAX([TransactionNumber]) FROM TransactionHistory"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If IsDBNull(DataReader(0)) Then
                TID = 200000000
            ElseIf DataReader.HasRows Then
                TID = DataReader(0) + 1
            End If
        End While
        Return TID
    End Function

    Public Shared Function ToGenerateFeedbackNumber() As Integer
        Dim FID As Integer
        Sql = "SELECT MAX([FeedbackNumber]) FROM UserFeedbacks"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If IsDBNull(DataReader(0)) Then
                FID = 10000000
            ElseIf DataReader.HasRows Then
                FID = DataReader(0) + 1
            End If
        End While
        Return FID
    End Function

    Public Shared Function ToGenerateNotificationID() As Integer
        Dim FID As Integer
        Sql = "SELECT MAX([NotifID]) FROM UserNotification"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If IsDBNull(DataReader(0)) Then
                FID = 50000000
            ElseIf DataReader.HasRows Then
                FID = DataReader(0) + 1
            End If
        End While
        Return FID
    End Function

    Public Shared Sub FromReceipt_Import(TNum As Integer, UniqueID As String, ReplicaUniqueID As String, FullName As String, BusName As String, PlateNumber As String, Location As String, Destination As String, Price As String, TimeOut As String, DateOut As String, DOT As String, PurchaseByUser As Integer)
        Select Case PurchaseByUser
            Case 1
                Dim Type As String = "Purchased by you"
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES(" &
                TNum & ",'" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','" & Price & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case 2
                Dim Type As String = "Purchased for others"
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES(" &
                TNum & ",'" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','" & Price & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case 3
                Dim Type As String = "Transaction by administrator"
                Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES(" &
                TNum & ",'" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & BusName & "','" & PlateNumber & "','" & Location & "','" & Destination & "','" & Price & "','" & TimeOut & "','" &
                DateOut & "','" & DOT & "','" & Type & "')"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
        End Select
    End Sub

    Public Shared Sub SetApprovalState_ModAdmin(Approve As Boolean, FullName As String, LRN As Double)
        Sql = "UPDATE BusPassengers SET IsApproved =" & Approve & " WHERE FullName ='" & FullName & "' AND LRN =" & LRN & ""
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub SetApprovalState_2(Approve As Boolean, FullName As String)
        Sql = "UPDATE BusPassengers SET IsApproved =" & Approve & " WHERE FullName ='" & FullName & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub FromBookingDetails_Import(UniqueID As String, ReplicaID As String, FullName As String, LRN As Double, SeatCode As String, BusName As String, Location As String, Destination As String, TimeDepart As String, DateDepart As String, PlateNumber As String, Price As String)
        Dim TimeToday As Date = DateTime.Now.ToString()
        Dim Result As Date = DateAdd("n", 30, TimeToday)

        Sql = "INSERT INTO BusPassengers([UniqueID],[Replica_UniqueID],[FullName],[LRN],[Seat],[BusName],[Location],[Destination],[TimeOfDeparture],[DateOfDeparture],[PlateNumber],[Paid],[IsApproved],[IsArrived],[ValidUntil])VALUES('" &
            UniqueID & "','" & ReplicaID & "','" & FullName & "'," & LRN & ",'" & SeatCode & "','" & BusName & "','" & Location & "','" & Destination & "','" & TimeDepart & "','" & DateDepart & "','" & PlateNumber & "','" & Price & "'," & False & "," & False & ",'" & Result & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeletePassengerData_ModAdmin(FullName As String, BusName As String, Location As String, Destination As String)
        Sql = "DELETE FROM BusPassengers WHERE FullName ='" & FullName & "' AND BusName ='" & BusName & "' AND Location ='" & Location & "' AND Destination ='" & Destination & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteBusList(BusName As String, PlateNumber As String)
        Sql = "DELETE FROM BusList WHERE BusName ='" & BusName & "' AND PlateNumber ='" & PlateNumber & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub RefreshUserData_ToBooking()
        Sql = "SELECT * FROM UserAccounts WHERE LRN =" & frmUserMainMenu.LblLRN.Text & ""
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            frmUserMainMenu.LblUniqueID_Booking.Text = DataReader("UniqueID")
            frmUserMainMenu.LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
        End While
    End Sub

    Public Shared Sub FromBusData(ListView As ListView)
        ListView.View = View.Details
        ListView.GridLines = True
        ListView.FullRowSelect = True
        ListView.Items.Clear()

        Dim Data_BusRoutes As New ListViewItem
        Sql = "SELECT PlateNumber, BusName FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        While DataReader.Read
            Data_BusRoutes.Text = DataReader(0)
            For i = 1 To DataReader.FieldCount - 1
                Data_BusRoutes.SubItems.Add(DataReader(i))
            Next
            ListView.Items.Add(Data_BusRoutes)
            ListView.Items(Data_BusRoutes.Index).BackColor = Color.Aqua
        End While
    End Sub

    Public Shared Function FromBusList() As DataTable
        Dim Data_BusList As New DataTable

        Sql = "SELECT PlateNumber, BusName, PointA, PointB, Price, AvailableSeats FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        Data_BusList.Load(DataReader)
        Return Data_BusList
    End Function

    Public Shared Function BusListEdit_Customized() As DataTable
        Dim BusList As New DataTable

        Sql = "SELECT PlateNumber, BusName FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        BusList.Load(DataReader)
        Return BusList
    End Function

    Public Shared Function UserList() As DataTable
        Dim Users As New DataTable
        Dim Filter As String = "Student/Staff"

        Sql = "SELECT LRN, FirstName FROM UserAccounts WHERE AccountType ='" & Filter & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        Users.Load(DataReader)
        Return Users
    End Function
End Class
