Imports System.Data.OleDb
Imports System.IO
Imports System.Text


Public Class AdminControlData

    Public Shared ActiveState As Boolean
    Public Shared UserHasBalance As Boolean

    Public Shared Sub GetBusListToKiosk(Cmb As ComboBox)
        Sql = "SELECT BusName FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        Cmb.Text = ""
        Cmb.Items.Clear()

        While DataReader.Read
            Cmb.Items.Add(DataReader("BusName"))
        End While
    End Sub

    Public Shared Sub UserArrivalConfirmed(FullName As String, Loc As String, Des As String)
        Sql = "DELETE FROM BusPassengers WHERE FullName ='" & FullName & "' AND Location ='" & Loc & "' AND Destination ='" & Des & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
    End Sub

    Public Shared Function CollectUniqueID(FullName As String) As String
        Dim UniqueID As String
        Sql = "SELECT UniqueID FROM UserSettings WHERE FullName ='" & FullName & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        DataReader.Read()
        UniqueID = DataReader("UniqueID")

        Return UniqueID
    End Function

    Public Shared Sub CheckIfUserHasBalance(UniqueID As String, Price As Integer)
        Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        DataReader.Read()

        If DataReader("CreditScore") < Price Then
            UserHasBalance = False
        Else
            UserHasBalance = True
        End If
    End Sub

    Public Shared Sub CheckMod_AdminProfilePic(UniqueID As String, PB As PictureBox)
        Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"
        Dim AdminImage As String = UniqueID & ".jpg"

        If System.IO.File.Exists(ImagePath & AdminImage) Then
            PB.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & AdminImage)), True, False)
        Else
            PB.Image = PB.InitialImage
        End If
    End Sub

    Public Shared Sub InitiateMaintenanceMode(Initiate As Boolean)
        Select Case Initiate
            Case True
                Sql = "UPDATE SystemSettings SET [IsMaintenanceModeForUsersOnly] = True"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case False
                Sql = "UPDATE SystemSettings SET [IsMaintenanceModeForUsersOnly] = False"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
        End Select
    End Sub

    Public Shared Sub CheckMaintenanceModeInitialize(Btn As Button, Lbl As Label)
        Sql = "SELECT IsMaintenanceModeForUsersOnly FROM SystemSettings"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsMaintenanceModeForUsersOnly") = True Then
                Btn.Text = "Maintenance Mode ON"
                Btn.BackColor = Color.MediumSpringGreen
                Lbl.Text = "ON"
                Lbl.BackColor = Color.IndianRed
            End If
        End While
    End Sub

    Public Shared Sub GenerateUniqueCode_ForUniqueID(Lbl As Label)
        Dim RowSize1 As Integer
        Dim RowSize2 As Integer
        Dim UCode As Integer
        Sql = "SELECT COUNT(*) FROM UserAccounts"
        Command = New OleDbCommand(Sql, Connection)
        RowSize1 = Command.ExecuteScalar

        Sql = "SELECT COUNT(*) FROM LRNAvailability"
        Command = New OleDbCommand(Sql, Connection)
        RowSize2 = Command.ExecuteScalar

        UCode = RowSize1 + (100000 + RowSize2)

        Lbl.Text = UCode
    End Sub

    Public Shared Sub CheckActiveBanner(Pb As PictureBox)
        Dim ImageName As String = "300000.jpg"
        Dim ImagePath As String = Application.StartupPath & "\frmAdvertise\"

        If System.IO.File.Exists(ImagePath & ImageName) Then
            Pb.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & ImageName)), True, False)
        Else
            Pb.Image = Pb.InitialImage
        End If
    End Sub

    Public Shared Sub GetVersionNumber(Txt As TextBox)
        Sql = "SELECT CurrentVersion FROM SystemSettings"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            Txt.Text = DataReader("CurrentVersion")
        End While
    End Sub

    Public Shared Sub ChangeVersionNumber(VerNum As String)
        Sql = "UPDATE SystemSettings SET CurrentVersion ='" & VerNum & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub UpdateVersionNumber(Txt As TextBox)
        Sql = "SELECT CurrentVersion FROM SystemSettings"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            Txt.Text = DataReader("CurrentVersion")
        End While
    End Sub

    Public Shared Sub CountLCreditCodes(Lbl As Label)
        Dim Result As Integer

        Sql = "SELECT COUNT(*) FROM LCreditsCode"
        Command = New OleDbCommand(Sql, Connection)
        Result = Command.ExecuteScalar

        Lbl.Text = Result
    End Sub

    Public Shared Sub UpdateUserInformation(UniqueID As String, Username As String, Email As String, BDay As String, Password As String, CmbAccTyp As String)
        If frmAdminControls.CmbActiveStatus_EditUser.Text = "Active" Then
            ActiveState = True
        ElseIf frmAdminControls.CmbActiveStatus_EditUser.Text = "Inactive" Then
            ActiveState = False
        End If

        Sql = "UPDATE UserAccounts SET EmailAddress ='" & Email & "', Username ='" & Username & "', [Password] ='" & Password & "', Birthdate ='" & BDay & "', AccountType ='" & CmbAccTyp & "', Activation =" & ActiveState & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ImportNewUser(LRN As Double, UniqueID As String, FirstName As String, LastName As String, BDay As Date, Role As String)
        Sql = "INSERT INTO LRNAvailability([LRNNumber],[AssignedUniqueID],[UserFirstName],[UserLastName],[UserBirthDate],[UserType])VALUES(" &
            LRN & ",'" & UniqueID & "','" & FirstName & "','" & LastName & "','" & BDay & "','" & Role & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ImportNewBus(PlateNum As String, BusName As String, PointA As String, PointB As String, TOD As Date, DOD As Date, SeatCap As Integer, Fare As Integer)
        Sql = "INSERT INTO BusList([PlateNumber],[BusName],[PointA],[PointB],[TimeOfDeparture],[DateOfDeparture],[AvailableSeats],[Price])VALUES('" &
            PlateNum & "','" & BusName & "','" & PointA & "','" & PointB & "','" & TOD & "','" & DOD & "'," & SeatCap & "," & Fare & ")"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub UpdateBus(PlateNum As String, PointA As String, PointB As String, TOD As Date, DOD As Date, Fare As Integer)
        Sql = "UPDATE BusList SET PointA ='" & PointA & "', PointB ='" & PointB & "', TimeOfDeparture ='" & TOD & "', DateOfDeparture ='" & DOD & "', Price =" & Fare & " WHERE PlateNumber ='" & PlateNum & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Function GetBusList() As DataTable
        Dim BusList As New DataTable

        Sql = "SELECT PlateNumber, BusName FROM BusList"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader
        BusList.Load(DataReader)
        Return BusList
    End Function

    Public Shared Function GetLCreditCodes() As DataTable
        Dim Codes As New DataTable

        Sql = "SELECT Code, Balance FROM LCreditsCode ORDER BY Balance DESC"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        Codes.Load(DataReader)
        Return Codes
    End Function

    Public Shared Sub DeleteBus(PlateNumber As String)
        Sql = "DELETE FROM BusList WHERE PlateNumber ='" & PlateNumber & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Function GetUserPrivileges_ALL() As DataTable
        Dim UserPriv As New DataTable

        Sql = "SELECT UniqueID, FullName, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE UniqueID IN (SELECT [UniqueID] FROM UserAccounts WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "')"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserPriv.Load(DataReader)

        Return UserPriv
    End Function

    Public Shared Function GenerateCode1() As String
        Dim Letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim Randomize As New Random
        Dim Builder As New StringBuilder

        For i As Integer = 1 To 5
            Dim IDX As Integer = Randomize.Next(0, Letters.Length)
            Dim Random As Char = Letters(IDX)
            Builder.Append(Random)
        Next

        Return Builder.ToString()
    End Function

    Public Shared Function GenerateCode2() As Integer
        Dim Code2 As System.Random = New System.Random

        Return Code2.Next(10000, 99999)
    End Function

    Public Shared Function GetUserPrivileges_Students() As DataTable
        Dim UserPriv As New DataTable

        Sql = "SELECT UniqueID, Username, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE UniqueID IN (SELECT [UniqueID] FROM UserAccounts WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "' AND AccountType = 'Student/Staff')"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserPriv.Load(DataReader)

        Return UserPriv
    End Function

    Public Shared Function GetUserPrivileges_Moderators() As DataTable
        Dim UserPriv As New DataTable

        Sql = "SELECT UniqueID, Username, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE UniqueID IN (SELECT [UniqueID] FROM UserAccounts WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "' AND AccountType = 'Moderator')"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserPriv.Load(DataReader)

        Return UserPriv
    End Function

    Public Shared Function GetUserPrivileges_Admin() As DataTable
        Dim UserPriv As New DataTable

        Sql = "SELECT UniqueID, Username, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE UniqueID IN (SELECT [UniqueID] FROM UserAccounts WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "' AND AccountType = 'Administrator')"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserPriv.Load(DataReader)

        Return UserPriv
    End Function

    Public Shared Function GetUserRequest_Load() As DataTable
        Dim UserLoad As New DataTable

        Sql = "SELECT * FROM UserLCreditsReferenceNo"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserLoad.Load(DataReader)

        Return UserLoad
    End Function

    Public Shared Function GetUserRequest_Premium() As DataTable
        Dim UserLoad As New DataTable

        Sql = "SELECT * FROM UserSubscriptionReferenceNo"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        UserLoad.Load(DataReader)

        Return UserLoad
    End Function

    Public Shared Function GetUserFeedbacks_Admin(Type As String) As DataTable
        Dim FeedbackList As New DataTable

        Sql = "SELECT FeedbackNumber FROM UserFeedbacks WHERE FeedbackType ='" & Type & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        FeedbackList.Load(DataReader)
        Return FeedbackList
    End Function

    Public Shared Sub SendLoadToUser(UniqueID As String, Price As Integer)
        Sql = "UPDATE UserAccounts SET CreditScore = CreditScore +" & Price & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Transaction_Import_Load(UniqueID As String, ReplicaUniqueID As String, FullName As String, Price As String, DateTime As String)
        Dim NotAvailable As String = "Not Available"
        Dim TransactionNumber As Integer = CollectData.ToGenerateTransactionNumber()
        Dim TypeOfTransaction As String = "Cash-in (L-Credits)"

        Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
            TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','+" & Price & "','" & NotAvailable & "','" &
            NotAvailable & "','" & DateTime & "','" & TypeOfTransaction & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Transaction_Import_Premium(UniqueID As String, ReplicaUniqueID As String, FullName As String, Price As String, DateTime As String)
        Dim NotAvailable As String = "Not Available"
        Dim TransactionNumber As Integer = CollectData.ToGenerateTransactionNumber()
        Dim TypeOfTransaction As String = "Premium Membership"

        Sql = "INSERT INTO TransactionHistory([TransactionNumber],[UniqueID],[Replica_UniqueID],[FullName],[BusName],[PlateNumber],[Location],[Destination],[Price],[TimeOut],[DateOut],[DateTimeOfTransaction],[TypeOfTransaction])VALUES('" &
            TransactionNumber & "','" & UniqueID & "','" & ReplicaUniqueID & "','" & FullName & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','" & NotAvailable & "','" & "PHP55" & "','" & NotAvailable & "','" &
            NotAvailable & "','" & DateTime & "','" & TypeOfTransaction & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeleteReference(UniqueID As String, RefNo As Double, Type As Integer)
        Select Case Type
            Case 1
                Sql = "DELETE FROM UserLCreditsReferenceNo WHERE UniqueID ='" & UniqueID & "' AND ReferenceNumber =" & RefNo & ""
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case 2
                Sql = "DELETE FROM UserSubscriptionReferenceNo WHERE UniqueID ='" & UniqueID & "' AND ReferenceNumber =" & RefNo & ""
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
        End Select
    End Sub

    Public Shared Sub PromoteUser(UniqueID As String, Role As Integer)
        Select Case Role
            Case 1
                Sql = "UPDATE UserAccounts SET AccountType = 'Administrator' WHERE UniqueID='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case 2
                Sql = "UPDATE UserAccounts SET AccountType = 'Moderator' WHERE UniqueID='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Case 3
                Sql = "UPDATE UserAccounts SET AccountType = 'Student/Staff' WHERE UniqueID='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
        End Select
    End Sub

    Public Shared Sub MakeUser_Premium(UniqueID As String)
        Sql = "UPDATE UserSettings SET IsPremium = True, IsPremiumPending = False WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Add30Day_Premium(UniqueID As String)
        Dim TimeToday As Date = DateTime.Now.ToString("d")
        Dim Deadline As Date = DateAdd("d", 30, TimeToday)

        Sql = "SELECT UniqueID FROM UserPremiumSubscription WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            Sql = "UPDATE UserPremiumSubscription SET Ends ='" & Deadline & "' WHERE UniqueID ='" & UniqueID & "'"
            Command = New OleDbCommand(Sql, Connection)
            Command.ExecuteNonQuery()
        Else
            Sql = "INSERT INTO UserPremiumSubscription([UniqueID],[SubscriptionType],[Ends])VALUES('" &
            UniqueID & "','" & "Premium" & "','" & Deadline & "')"
            Command = New OleDbCommand(Sql, Connection)
            Command.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Sub ProfileChange_Admin(UniqueID As String, Picture As PictureBox)
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

                    frmAdminControls.BtnChangePfp.BackColor = Color.IndianRed
                    frmAdminControls.BtnChangePfp.Text = "Remove"
                    frmAdminControls.BtnPicSave.Visible = True
                Else
                    If System.IO.File.Exists(ImagePath & UserImage) Then
                        Picture.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & UserImage)), True, False)
                    Else
                        Picture.Image = Picture.InitialImage
                    End If
                    .Dispose()
                End If
            End With
        End If
    End Sub

End Class
