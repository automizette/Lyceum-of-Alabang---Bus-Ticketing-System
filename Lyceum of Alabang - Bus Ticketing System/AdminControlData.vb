Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.SqlServer.Server

Public Class AdminControlData

    Public Shared ActiveState As Boolean

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

        Sql = "SELECT UniqueID, Username, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE UniqueID IN (SELECT [UniqueID] FROM UserAccounts WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "')"
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

End Class
