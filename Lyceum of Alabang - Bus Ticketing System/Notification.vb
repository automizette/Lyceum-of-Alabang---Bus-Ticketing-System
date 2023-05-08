Imports System.Data.OleDb
Public Class Notification


    Public Shared Sub BookDenied(UniqueID As String, BusName As String, Location As String, Destination As String, TOD As String, DOD As String, Reason As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your reservation " + Location + " to " + Destination + " has been denied."
        Dim Description As String = "Your booking for " + BusName + " - From " + Location + " to " + Destination + " set to depart at " + TOD + ", " + DOD +
            " has been denied by our administrators for the reason of: " + Reason + ". Please reach out to the administrator for your concerns"

        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub BookCancelled(UniqueID As String, BusName As String, Location As String, Destination As String, TOD As String, DOD As String, Reason As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your reservation " + Location + " to " + Destination + " has been cancelled and deleted."
        Dim Description As String = "Your booking for " + BusName + " - From " + Location + " to " + Destination + " set to depart at " + TOD + ", " + DOD +
            " has been canceleld by our administrators for the reason of: " + Reason + ". A refund has been initiated for compensation. Please reach out to the administrator for your concerns"
        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub AllPassengers_Remove(niqueID As String, BusName As String, Location As String, Destination As String, TOD As String, DOD As String, Reason As String)


    End Sub

End Class
