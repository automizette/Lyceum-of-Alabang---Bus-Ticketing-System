Imports System.Data.OleDb
Public Class CheckBusData

    Public Shared Seat_NotOccupied As String = Application.StartupPath & "\frmIcons\frmSeat_NotOccupied.png"
    Public Shared Seat_Occupied As String = Application.StartupPath & "\frmIcons\frmSeat_Occupied.png"
    Public Shared Seat_UserInput As String = Application.StartupPath & "\frmIcons\frmSeat_Click.png"

    Public Shared Sub Seats(SeatNumber As String, PlateNumber As String, SeatIcon As PictureBox)
        Sql = "SELECT * FROM BusPassengers WHERE PlateNumber = '" & PlateNumber & "' AND Seat ='" & SeatNumber & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            SeatIcon.Image = Image.FromFile(Seat_Occupied)
            SeatIcon.Tag = "OCCUPIED"
        Else
            SeatIcon.Image = Image.FromFile(Seat_NotOccupied)
            SeatIcon.Tag = "NOT_OCCUPIED"
        End If
    End Sub



End Class
