﻿Imports System.Data.OleDb
Public Class SearchEngine

    Public Shared Sub CheckLRN(Searchbox As TextBox)
        Dim DGV As New DataSet
        Dim FirstColumn As New AutoCompleteStringCollection
        Dim i As Integer

        Dim Filter As String = "Student/Staff"

        Sql = "SELECT LRN FROM UserAccounts WHERE AccountType ='" & Filter & "'"
        Command = New OleDbCommand(Sql, Connection)
        Dim Adapt As New OleDbDataAdapter
        Adapt.SelectCommand = Command
        DGV.Clear()
        Adapt.Fill(DGV)

        For i = 0 To DGV.Tables(0).Rows.Count - 1
            FirstColumn.Add(DGV.Tables(0).Rows(i)("LRN").ToString())
        Next
        Searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Searchbox.AutoCompleteCustomSource = FirstColumn
        Searchbox.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Public Shared Function CheckLRN_Changed(SearchBx As TextBox)
        Dim LRNUser As New DataTable
        Dim Filter As String = "Student/Staff"

        Sql = "SELECT LRN, FirstName FROM UserAccounts WHERE LRN=@ID"
        Command = New OleDbCommand(Sql, Connection)
        Command.Parameters.AddWithValue("ID", SearchBx.Text.Trim)
        DataReader = Command.ExecuteReader

        LRNUser.Load(DataReader)

        Return LRNUser
    End Function

    Public Shared Sub SearchLRN_Admin(Searchbox As TextBox)
        Dim DGV As New DataSet
        Dim FirstColumn As New AutoCompleteStringCollection
        Dim i As Integer

        Dim Filter As String = "Administrator"

        Sql = "SELECT LRN FROM UserAccounts WHERE NOT AccountType ='" & Filter & "'"
        Command = New OleDbCommand(Sql, Connection)
        Dim Adapt As New OleDbDataAdapter
        Adapt.SelectCommand = Command
        DGV.Clear()
        Adapt.Fill(DGV)

        For i = 0 To DGV.Tables(0).Rows.Count - 1
            FirstColumn.Add(DGV.Tables(0).Rows(i)("LRN").ToString())
        Next
        Searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Searchbox.AutoCompleteCustomSource = FirstColumn
        Searchbox.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Public Shared Function SearchLRN_Changed(SearchBx As TextBox)
        Dim LRNUser As New DataTable

        Sql = "SELECT LRN, FirstName, LastName FROM UserAccounts WHERE LRN=@ID"
        Command = New OleDbCommand(Sql, Connection)
        Command.Parameters.AddWithValue("ID", SearchBx.Text.Trim)
        DataReader = Command.ExecuteReader

        LRNUser.Load(DataReader)

        Return LRNUser
    End Function

    Public Shared Sub SearchFullName_Admin(Searchbox As TextBox)
        Dim DGV As New DataSet
        Dim FirstColumn As New AutoCompleteStringCollection
        Dim i As Integer

        Dim Filter As String = "Administrator"

        Sql = "SELECT FullName FROM UserSettings WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        Dim Adapt As New OleDbDataAdapter
        Adapt.SelectCommand = Command
        DGV.Clear()
        Adapt.Fill(DGV)

        For i = 0 To DGV.Tables(0).Rows.Count - 1
            FirstColumn.Add(DGV.Tables(0).Rows(i)("FullName").ToString())
        Next
        Searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Searchbox.AutoCompleteCustomSource = FirstColumn
        Searchbox.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Public Shared Function SearchFullName_Changed(SearchBx As TextBox)
        Dim LRNUser As New DataTable

        Sql = "SELECT UniqueID, FullName, HasAdministratorRole, CanAddUsers, CanEditUser, CanManageUser, CanManageBus, CanAddLCredits, CanLoadLCredits, CanModifyPrivileges, CanSeeTransactionList, HasHigherAdministratorPrivilege FROM UserSettings WHERE NOT UniqueID ='" & frmModAdminMainMenu.LblUniqueID_MainMenu.Text & "' AND FullName=@ID"
        Command = New OleDbCommand(Sql, Connection)
        Command.Parameters.AddWithValue("ID", SearchBx.Text.Trim)
        DataReader = Command.ExecuteReader

        LRNUser.Load(DataReader)

        Return LRNUser
    End Function

End Class
