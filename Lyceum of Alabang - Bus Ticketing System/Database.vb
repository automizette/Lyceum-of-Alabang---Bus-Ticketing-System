Imports System.Data.OleDb
Module Database
    Public Connection As New OleDbConnection
    Public Command As OleDbCommand
    Public DataReader As OleDbDataReader
    Public Sql As String

    Public Sub Connect()
        Connection.Close()
        Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" & Application.StartupPath & "\loabtsdb.mdb"
        Connection.Open()
    End Sub
End Module
