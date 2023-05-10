Imports System.Data.OleDb
Imports System.Threading

Public Class Admin_Modify

    Public Shared Sub TransactionHistory_AdminFilters(DataGrid As DataGridView, FilterType As Integer)
        Dim DGV As New DataTable

        Select Case FilterType
            Case 1
                DGV.Clear()
                Dim Transportation_0 As String = "Purchased by you"
                Dim Transportation_1 As String = "Purchased for other"
                Dim Transportation_2 As String = "Transaction by administrator"

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName, BusName, PlateNumber, Location, Destination, TimeOut, DateOut FROM TransactionHistory WHERE TypeOfTransaction ='" & Transportation_0 &
                    "' OR TypeOfTransaction ='" & Transportation_1 & "' OR TypeOfTransaction ='" & Transportation_2 & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 2
                DGV.Clear()
                Dim Transportation_Filtered As String = "Cash-in (L-Credits)"

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName FROM TransactionHistory WHERE TypeOfTransaction ='" & Transportation_Filtered & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 3
                Dim Transportation_Filtered As String = "Premium Membership
"
                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName FROM TransactionHistory WHERE TypeOfTransaction ='" & Transportation_Filtered & "' ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
            Case 4
                DGV.Clear()

                Sql = "SELECT TransactionNumber, TypeOfTransaction, DateTimeOfTransaction, Price, FullName, BusName, PlateNumber, Location, Destination, TimeOut, DateOut FROM TransactionHistory ORDER BY TransactionNumber DESC"
                Command = New OleDbCommand(Sql, Connection)
                Dim DataAdapt As New OleDbDataAdapter
                DataAdapt.SelectCommand = Command
                DGV.Clear()
                DataAdapt.Fill(DGV)
                DataGrid.DataSource = DGV
        End Select
    End Sub

    Public Shared Sub CheckOTPEnable(UniqueID As String)
        Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("OTPEnabled") = True Then
                frmModAdminMainMenu.BtnOTP_Account.Text = "OTP Enabled"
                frmModAdminMainMenu.BtnOTP_Account.BackColor = Color.PaleGreen
            End If
        End While
    End Sub

    Public Shared Sub CheckUserAccess_MainMenu(UniqueID As String)
        Sql = "SELECT CanEditUser FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("CanEditUser") = True Then
                frmModAdminMainMenu.PbEditUser.Enabled = True
            Else
                frmModAdminMainMenu.PbEditUser.Image = frmModAdminMainMenu.PbEditUser.InitialImage
            End If
        End While
    End Sub

    Public Shared Sub CheckUserAccess_AdminControls(UniqueID As String)
        Sql = "SELECT * FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read

            If DataReader("CanAddUsers") = True Then
                frmAdminControls.PbAddUser.Enabled = True
            Else
                frmAdminControls.PbAddUser.Image = frmAdminControls.PbAddUser.InitialImage
            End If

            If DataReader("CanManageUser") = True Then
                frmAdminControls.PbManageUser.Enabled = True
            Else
                frmAdminControls.PbManageUser.Image = frmAdminControls.PbManageUser.InitialImage
            End If

            If DataReader("CanManageBus") = True Then
                frmAdminControls.PbManageBus.Enabled = True
            Else
                frmAdminControls.PbManageBus.Image = frmAdminControls.PbManageBus.InitialImage
            End If

            If DataReader("CanAddLCredits") = True Then
                frmAdminControls.PbAddLCredits.Enabled = True
            Else
                frmAdminControls.PbAddLCredits.Image = frmAdminControls.PbAddLCredits.InitialImage
            End If

            If DataReader("CanLoadLCredits") = True Then
                frmAdminControls.PbLoadLCredits.Enabled = True
            Else
                frmAdminControls.PbLoadLCredits.Image = frmAdminControls.PbAddLCredits.InitialImage
            End If

            If DataReader("CanModifyPrivileges") = True Then
                frmAdminControls.PbManagePrivileges.Enabled = True
            Else
                frmAdminControls.PbManagePrivileges.Image = frmAdminControls.PbManagePrivileges.InitialImage
            End If

            If DataReader("CanSeeTransactionList") = True Then
                frmAdminControls.PbTransactionList.Enabled = True
            Else
                frmAdminControls.PbTransactionList.Image = frmAdminControls.PbTransactionList.InitialImage
            End If

            If DataReader("HasHigherAdministratorPrivilege") = True Then
                frmAdminControls.PbSystemSettings.Enabled = True
            Else
                frmAdminControls.PbSystemSettings.Image = frmAdminControls.PbSystemSettings.InitialImage
            End If

        End While
    End Sub

    Public Shared Sub ModifyDTP(Dtp As DateTimePicker)
        Dtp.CustomFormat = "MM/dd"
    End Sub

    Public Shared Sub ModifyTTP(Ttp As DateTimePicker)
        Ttp.CustomFormat = "hh:mm tt"
    End Sub

    Public Shared Sub UserPrivilegeColumns(DGV As DataGridView)
        With DGV
            .Columns(0).HeaderText = "UniqueID"
            .Columns(1).HeaderText = "Username"
            .Columns(2).HeaderText = "Administrator Control Access"
            .Columns(3).HeaderText = "Account Creation Access"
            .Columns(4).HeaderText = "Edit User Access"
            .Columns(5).HeaderText = "Manage User Access"
            .Columns(6).HeaderText = "Manage Bus Access"
            .Columns(7).HeaderText = "Manage L-Credit System"
            .Columns(8).HeaderText = "Load L-Credits Access"
            .Columns(9).HeaderText = "Modify Privileges Access"
            .Columns(10).HeaderText = "Transaction List Access"
            .Columns(11).HeaderText = "High Administrator Access"

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
        End With
    End Sub

    Public Shared Sub FeedbackDGVColumns(DGV As DataGridView)
        With DGV
            .Columns(0).HeaderText = "Feedback Number"
        End With
    End Sub

    Public Shared Sub UserRequestColumns_LC(DGV As DataGridView)
        With DGV
            .Columns(0).HeaderText = "User's UniqueID"
            .Columns(1).HeaderText = "Given Reference Number"
            .Columns(2).HeaderText = "L-Credits Requested"
            .Columns(3).HeaderText = "Date Requested"
        End With
    End Sub

    Public Shared Sub UserRequestColumns_PR(DGV As DataGridView)
        With DGV
            .Columns(0).HeaderText = "User's UniqueID"
            .Columns(1).HeaderText = "Given Reference Number"
            .Columns(2).HeaderText = "Date Requested"
        End With
    End Sub

    Public Shared Sub Privileges_User(UniqueID As String, DGV As DataGridView)
        Dim AdminAcces As Boolean = CBool(DGV.CurrentRow.Cells(2).Value)
        Dim AccountCreateAccess As Boolean = CBool(DGV.CurrentRow.Cells(3).Value)
        Dim EditUserAccess As Boolean = CBool(DGV.CurrentRow.Cells(4).Value)
        Dim ManageUserAccess As Boolean = CBool(DGV.CurrentRow.Cells(5).Value)
        Dim ManageBusAccess As Boolean = CBool(DGV.CurrentRow.Cells(6).Value)
        Dim ManageLCreditSys As Boolean = CBool(DGV.CurrentRow.Cells(7).Value)
        Dim LoadLCreditAccess As Boolean = CBool(DGV.CurrentRow.Cells(8).Value)
        Dim ModifyPrivAccess As Boolean = CBool(DGV.CurrentRow.Cells(9).Value)
        Dim TransactListAccess As Boolean = CBool(DGV.CurrentRow.Cells(10).Value)
        Dim HighAdminAccess As Boolean = CBool(DGV.CurrentRow.Cells(11).Value)

        Sql = "UPDATE UserSettings SET HasAdministratorRole =" & AdminAcces & ", CanAddUsers =" & AccountCreateAccess & ", CanEditUser =" & EditUserAccess &
            ", CanManageUser =" & ManageUserAccess & ", CanManageBus =" & ManageBusAccess & ", CanAddLCredits =" & ManageLCreditSys & ", CanLoadLCredits =" &
            LoadLCreditAccess & ", CanModifyPrivileges =" & ModifyPrivAccess & ", CanSeeTransactionList =" & TransactListAccess & ", HasHigherAdministratorPrivilege =" &
            HighAdminAccess & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

End Class
