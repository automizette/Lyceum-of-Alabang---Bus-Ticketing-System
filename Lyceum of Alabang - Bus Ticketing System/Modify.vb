Imports System.Data.OleDb
Imports System.IO

Public Class Modify
    Public Shared Sub CheckIfPremiumDeadlineMeets(UniqueID As String)
        Sql = "SELECT Ends FROM UserPremiumSubscription WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("Ends") <= DateTime.Now.ToString("dd/MM/yy") Then
                MessageBox.Show("Your subscription to premium membership has finally ended on " + DataReader("Ends") + ". Thank you for using our system and trying out the features of premium. If you want to experience premium again, you can visit the Premium page on the Main Menu.", "Premium Membership Ended", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CollectData.DeleteSubscriptionDeadline(frmUserMainMenu.LblUniqueID_MainMenu.Text)
                CollectData.ChangePremiumState(frmUserMainMenu.LblUniqueID_MainMenu.Text, False)
            Else
                'Nothing
            End If
        End While
    End Sub

    Public Shared Sub AutomaticApproveReservation(UniqueID As String, FullName As String, LRN As Double)
        Sql = "SELECT ValidUntil, IsApproved FROM BusPassengers WHERE Replica_UniqueID ='" & UniqueID & "' AND FullName ='" & FullName & "' AND LRN =" & LRN & ""
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        'Dim TimeToday = DateTime.Now.ToLongTimeString("T")

        If DataReader.Read = True Then
            If DataReader("ValidUntil") <= Now And DataReader("IsApproved") = False Then
                CollectData.SetApprovalState_ModAdmin(True, FullName, LRN)
            Else
                'Nothing
            End If
        Else
            'Nothing
        End If
    End Sub

    Public Shared Sub OTP_CheckIfOn(UniqueID As String)
        Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("OTPEnabled") = True Then
                frmUserMainMenu.BtnOTP_Account.Text = "OTP Enabled"
                frmUserMainMenu.BtnOTP_Account.BackColor = Color.PaleGreen
            End If
        End While
    End Sub

    Public Shared Sub GetAvailableBus(Lbl As Label)
        Dim AvailableBus As Integer

        Sql = "SELECT COUNT(*) FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        AvailableBus = Command.ExecuteScalar
        'frmUserMainMenu.LblAvailableBusCount.Text = AvailableBus
        Lbl.Text = AvailableBus
    End Sub

    Public Shared Sub GetUsersReservation(UniqueID As String, Lbl As Label)
        Dim UserReservation As Integer

        Sql = "SELECT COUNT(*) FROM BusPassengers WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        UserReservation = Command.ExecuteScalar
        Lbl.Text = UserReservation
    End Sub

    Public Shared Sub GetUserNotificationCount(UniqueID As String)
        Dim UserNotif As Integer
        Dim AllUsers As String = "ALL_USERS"

        Sql = "SELECT COUNT(*) FROM UserNotification WHERE For_User ='" & UniqueID & "' OR For_User ='" & AllUsers & "'"
        Command = New OleDbCommand(Sql, Connection)
        UserNotif = Command.ExecuteScalar
        frmUserMainMenu.LblNotificationCount.Text = UserNotif
    End Sub

    Public Shared Sub GetReservationCount(Lbl As Label)
        Dim Reservations As Integer

        Sql = "SELECT COUNT(*) FROM BusPassengers"
        Command = New OleDbCommand(Sql, Connection)
        Reservations = Command.ExecuteScalar

        Lbl.Text = Reservations
    End Sub

    Public Shared Sub GetUserCount(Lbl As Label, ActiveState As Boolean)
        Dim UserActive As Integer

        Sql = "SELECT COUNT(*) FROM UserAccounts WHERE Activation =" & ActiveState & ""
        Command = New OleDbCommand(Sql, Connection)
        UserActive = Command.ExecuteScalar

        Lbl.Text = UserActive
    End Sub

    Public Shared Sub GetUnregisteredUsers(Lbl As Label)
        Dim UnregUsers As Integer

        Sql = "SELECT COUNT(*) FROM LRNAvailability"
        Command = New OleDbCommand(Sql, Connection)
        UnregUsers = Command.ExecuteScalar

        Lbl.Text = UnregUsers
    End Sub

    Public Shared Function GetUserNotification()
        'ORDER BY NotifID DESC
        Dim DataTable_Notification As New DataTable
        Dim AllUser As String = "ALL_USERS"
        Sql = "SELECT NotifID, DateNotified, Title FROM UserNotification WHERE For_User ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "' OR For_User ='" & AllUser & "' ORDER BY NotifID DESC"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        DataTable_Notification.Load(DataReader)
        Return DataTable_Notification
    End Function

    Public Shared Sub NotificationsColumns(DGV As DataGridView)
        DGV.Columns(1).HeaderText = "Date"
        DGV.Columns(2).HeaderText = "Notification Title"
    End Sub

    Public Shared Sub TransactionHistory_ColumnText(DataGrid As DataGridView, Type As Integer)
        Select Case Type
            Case 1
                DataGrid.Columns(0).HeaderText = "Transaction Number"
                DataGrid.Columns(1).HeaderText = "Type of Transaction"
                DataGrid.Columns(2).HeaderText = "Paid on"
                DataGrid.Columns(3).HeaderText = "L-Credits"
                DataGrid.Columns(4).HeaderText = "Passenger's Name"
                DataGrid.Columns(5).HeaderText = "Bus Name"
                DataGrid.Columns(6).HeaderText = "Bus' Plate Number"
                DataGrid.Columns(7).HeaderText = "Location (From:)"
                DataGrid.Columns(8).HeaderText = "Destination (To:)"
                DataGrid.Columns(9).HeaderText = "Time of Departure"
                DataGrid.Columns(10).HeaderText = "Date of Departure"
            Case 2
                DataGrid.Columns(0).HeaderText = "Transaction Number"
                DataGrid.Columns(1).HeaderText = "Type of Transaction"
                DataGrid.Columns(2).HeaderText = "Paid on"
                DataGrid.Columns(3).HeaderText = "Tendered Amount"
                DataGrid.Columns(4).HeaderText = "Full Name"
            Case 3
                DataGrid.Columns(0).HeaderText = "Transaction Number"
                DataGrid.Columns(1).HeaderText = "Type of Transaction"
                DataGrid.Columns(2).HeaderText = "Paid on"
                DataGrid.Columns(3).HeaderText = "L-Credits"
                DataGrid.Columns(4).HeaderText = "Received by"
        End Select
    End Sub

    Public Shared Sub CheckProfilePicture_IfExist(UniqueID As String)
        Dim UserImage As String = UniqueID & ".jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

        If System.IO.File.Exists(ImagePath & UserImage) Then
            frmUserMainMenu.PbProfilePicture.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
        Else
            frmUserMainMenu.PbProfilePicture.Image = frmUserMainMenu.PbProfilePicture.InitialImage
        End If
    End Sub

    Public Shared Sub UniversalProfilPictureCheck_Admin(UniqueID As String, Pic As PictureBox)
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"
        Dim UserImage As String = UniqueID & ".jpg"

        If System.IO.File.Exists(ImagePath & UserImage) Then
            Pic.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
        Else
            Pic.Image = Pic.InitialImage
        End If
    End Sub

    Public Shared Sub UniversalOpenDialog_Admin(UniqueID As String, Pb As PictureBox, Btn1 As Button, Btn2 As Button)
        Dim OFD As New OpenFileDialog
        Dim DuplicateImage As Image

        Dim UserImage As String = UniqueID & ".jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"



        If Btn1.Text = "Change" Then
            With OFD
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "JPEG files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png|ALL files (*.*)|*.*"
                .FilterIndex = 1

                If .ShowDialog = DialogResult.OK Then
                    DuplicateImage = Image.FromStream(New MemoryStream(File.ReadAllBytes(.FileName)), True, False)
                    'DuplicateImage = Image.FromFile(.FileName)
                    Pb.Image = DuplicateImage

                    Btn1.BackColor = Color.IndianRed
                    Btn1.Text = "Remove"
                    Btn2.Visible = True
                Else
                    If System.IO.File.Exists(ImagePath & UserImage) Then
                        Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
                    End If
                    .Dispose()
                End If
            End With
        End If
    End Sub

    Public Shared Sub SubscribeButton_Disallow(Panel As Panel, UniqueID As String)
        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = False Then
                Panel.Visible = True
                'CollectData.EditUserPremium_ToPending(frmUserMainMenu.LblUniqueID_MainMenu.Text, True)

            Else
                Panel.Visible = False
            End If
        End While
    End Sub

    Public Shared Sub BusListDGV(DGV As DataGridView)
        DGV.Columns(0).HeaderText = "Plate No."
        DGV.Columns(1).HeaderText = "Bus Name (Model)"
        DGV.Columns(2).HeaderText = "From"
        DGV.Columns(3).HeaderText = "To"
        DGV.Columns(4).HeaderText = "Price"
        DGV.Columns(5).HeaderText = "Available"
    End Sub

    Public Shared Sub BusEditDGV(DGV As DataGridView)
        DGV.Columns(0).HeaderText = "Plate Number"
        DGV.Columns(1).HeaderText = "Bus Name (or Model)"
    End Sub

    Public Shared Sub UserList_EditColumn(DGV As DataGridView)
        DGV.Columns(0).HeaderText = "LRN/ID Number"
        DGV.Columns(1).HeaderText = "User's first name"
    End Sub

    Public Shared Sub LCreditCodesCensored(DGV As DataGridViewCellFormattingEventArgs)
        If DGV.ColumnIndex = 0 Then
            If DGV.Value IsNot Nothing Then
                DGV.Value = New String("*", DGV.Value.ToString().Length)
            End If
        End If
    End Sub

    Public Shared Sub BookList_UserFiltered(DGV As DataGridView)
        DGV.Columns(0).HeaderText = "Name"
        DGV.Columns(1).HeaderText = "Seat Code"
        DGV.Columns(2).HeaderText = "Bus Name"
        DGV.Columns(3).HeaderText = "Time of Departure"
        DGV.Columns(4).HeaderText = "Date of Departure"
    End Sub
    Public Shared Sub EditPremiumStatusMessage(UniqueID As String)
        Sql = "SELECT IsPremiumPending FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            If DataReader("IsPremiumPending") = True Then
                frmUserMainMenu.LblPremiumSubscriptionStatus.Text = "Pending subsciption payment in process. Please wait."
                frmUserMainMenu.LblPremiumSubscriptionStatus.ForeColor = Color.DarkOrange
                frmUserMainMenu.LblPremiumSubscriptionStatus.Visible = True
                frmUserMainMenu.PnlSubscribeButton.Enabled = False
                frmUserMainMenu.LblPremiumStatus.Visible = False
            End If
        End If
    End Sub

    Public Shared Sub Picture_Select(Picture As PictureBox, UniqueID As String)
        Dim OFD As New OpenFileDialog
        Dim DuplicateImage As Image

        Dim UserImage As String = UniqueID & ".jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

        If frmUserMainMenu.BtnChangePicture.Text = "Change" Then
            With OFD
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "JPEG files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png|ALL files (*.*)|*.*"
                .FilterIndex = 1

                If .ShowDialog = DialogResult.OK Then
                    DuplicateImage = Image.FromStream(New MemoryStream(File.ReadAllBytes(.FileName)), True, False)
                    'DuplicateImage = Image.FromFile(.FileName)
                    Picture.Image = DuplicateImage

                    frmUserMainMenu.BtnChangePicture.BackColor = Color.IndianRed
                    frmUserMainMenu.BtnChangePicture.Text = "Remove"
                    frmUserMainMenu.BtnSaveImage.Visible = True
                Else
                    If System.IO.File.Exists(ImagePath & UserImage) Then
                        Picture.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
                        'Dim Profile = ImagePath & UserImage
                        'Dim st = New MemoryStream(Profile)
                    Else
                        Picture.Image = Picture.InitialImage
                    End If
                    .Dispose()
                End If
            End With
        End If
    End Sub

    Public Shared Sub Picture_Select_Banner(Picture As PictureBox, UniqueID As String)
        Dim OFD As New OpenFileDialog
        Dim DuplicateImage As Image

        Dim UserImage As String = UniqueID & ".jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfileBanners\"

        If frmUserMainMenu.BtnChangePicture.Text = "Change" Then
            With OFD
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "JPEG files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png|ALL files (*.*)|*.*"
                .FilterIndex = 1

                If .ShowDialog = DialogResult.OK Then
                    frmUserMainMenu.PbProfilePicture.Image.Dispose()
                    DuplicateImage = Image.FromStream(New MemoryStream(File.ReadAllBytes(.FileName)), True, False)
                    'DuplicateImage = Image.FromFile(.FileName)
                    Picture.Image = DuplicateImage

                    frmUserMainMenu.BtnChangeBanner.BackColor = Color.IndianRed
                    frmUserMainMenu.BtnChangeBanner.Text = "Remove"
                    frmUserMainMenu.BtnSaveBanner.Visible = True
                Else
                    If System.IO.File.Exists(ImagePath & UserImage) Then
                        frmUserMainMenu.PbProfilePicture.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
                    End If
                    .Dispose()
                End If
            End With
        End If
    End Sub

    Public Shared Sub InsertImage(Pictures As PictureBox)
        Dim OFD As New OpenFileDialog
        Dim DuplicateImage As Image
        Dim ImagePath As String = Application.StartupPath & "\frmFeedbackInsertImages\"

        If frmSendFeedback.BtnInsertImage.Text = "Insert Image" Then
            With OFD
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "JPEG files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png|ALL files (*.*)|*.*"
                .FilterIndex = 1

                If .ShowDialog = DialogResult.OK Then
                    DuplicateImage = Image.FromStream(New MemoryStream(File.ReadAllBytes(.FileName)), True, False)
                    'DuplicateImage = Image.FromFile(.FileName)
                    Pictures.Image = DuplicateImage

                    frmSendFeedback.BtnInsertImage.BackColor = Color.IndianRed
                    frmSendFeedback.BtnInsertImage.Text = "Remove"
                Else
                    Pictures.Image = Pictures.InitialImage
                End If
                .Dispose()
            End With
        End If
    End Sub

    Public Shared Sub SystemAdvertise_Pb()
        Dim ImageName As String = "300000.jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmAdvertise\"

        If System.IO.File.Exists(ImagePath & ImageName) Then
            frmUserMainMenu.PbBanner_ForToday.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & ImageName)), True, False)
        Else
            frmUserMainMenu.PbBanner_ForToday.Image = frmUserMainMenu.PbBanner_ForToday.InitialImage
        End If
    End Sub

    Public Shared Sub ProfileBanner_Premium(UniqueID As String)
        Dim UserImage As String = UniqueID & ".jpg"
        Dim PremiumBannerFolder As String = Application.StartupPath & "\frmUserProfileBanners\"

        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                If System.IO.File.Exists(PremiumBannerFolder & UserImage) Then
                    frmUserMainMenu.PbUserProfileBanner.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(PremiumBannerFolder & UserImage)), True, False)
                Else
                    frmUserMainMenu.PbUserProfileBanner.Image = frmUserMainMenu.PbUserProfileBanner.InitialImage
                End If
            End If
        End While
    End Sub

    Public Shared Sub PremiumAccount(Username As String)
        Dim PremiumImageIcon As String = Application.StartupPath & "\frmIcons\frmPremium_True.png"
        Dim PremiumAdvertise As String = Application.StartupPath & "\frmBG\frmAdvertisement_PremiumTrue.png"

        Sql = "SELECT IsPremium FROM UserSettings WHERE Username ='" & Username & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        If DataReader.Read = True Then
            If DataReader("IsPremium") = True Then
                Sql = "SELECT Ends FROM UserPremiumSubscription WHERE UniqueID ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                While DataReader.Read
                    frmUserMainMenu.LblPremium_Deadline.Text = DataReader("Ends")
                End While

                frmUserMainMenu.PnlInformation.Location = New Point(8, 6)

                frmUserMainMenu.LblCreditScore.Visible = False
                frmUserMainMenu.LblLCredits_Premium.Visible = True
                frmUserMainMenu.PbPremium.Image = Image.FromFile(PremiumImageIcon)
                frmUserMainMenu.PbAdvertisement.Image = Image.FromFile(PremiumAdvertise)
                frmUserMainMenu.PbProfile_Premium.Visible = True
                frmUserMainMenu.LblPremiumSubscriptionStatus.Text = "You currently have a premium membership. Awesome!"
                frmUserMainMenu.LblPremiumSubscriptionStatus.ForeColor = Color.LightGreen
                frmUserMainMenu.LblPremiumSubscriptionStatus.Visible = True
                frmUserMainMenu.PbUserProfileBanner.Visible = True
                frmUserMainMenu.BtnChangeBanner.Visible = True

                frmUserMainMenu.PnlPremiumMembershipInformation.Visible = True

                frmUserMainMenu.PnlInformation.Parent = frmUserMainMenu.PbUserProfileBanner

                frmUserMainMenu.PbPremiumLogo.Visible = True
                frmUserMainMenu.PnlLCredits_Account.Visible = False
            End If
        End If
    End Sub

    Public Shared Sub NewAccountValidation(UniqueID As String)
        Sql = "UPDATE UserSettings SET IsAccountNew = True WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub CheckUserSetup(UniqueID As String)
        Sql = "SELECT IsAccountNew FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsAccountNew") = True Then
                frmFirstTimeSetup.Show()

                Sql = "UPDATE UserSettings SET IsAccountNew =" & False & " WHERE UniqueID ='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Else
                'Nothing
            End If
        End While
    End Sub

End Class
