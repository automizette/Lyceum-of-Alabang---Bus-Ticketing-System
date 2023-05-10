Imports System.Data.OleDb
Imports Microsoft.SqlServer.Server

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

    Public Shared Sub DeniedLCredits(UniqueID As String, Load As String, RefNo As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your request to Load L-Credits of " + Load + " has been declined"
        Dim Description As String = "Our administrator has declined your load of L-Credits with an amount of " + Load + " with a reference number of " + RefNo + ". This may due to double transaction, or you got the wrong reference number. If you think this is not right, just request again on the Cash-in L-Credits button on the account information menu"
        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub PremiumMembershipNotif(UniqueID As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your premium membership is now active!"
        Dim Description As String = "Welcome to Premium! Enjoy free and safe transaction whenever you want to reserve a book for a ride. If you have any questions or problems, do not hesitate to send feedback to us! Enjoy your premium membership"
        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub DeniedPremiumMembership(UniqueID As String, RefNo As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your request for premium membership has been declined"
        Dim Description As String = "Your request to subscribe to premium membership with the reference number " + RefNo + " has been declined by our administrator. This maybe due to your reference number incorrect or your payment did not go through. If you think this is not right, just subscribe again in the Premium membership page."
        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub NotifyUser_BookApproved(UniqueID As String, Location As String, Destination As String)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "Your booking has been automatically approved"
        Dim Description As String = "Your booking reservation from " + Location + " to " + Destination + " has been automatically approved by our system. Enjoy"
        Sql = "INSERT INTO UserNotification([For_User],[NotifID],[DateNotified],[Title],[Description])VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday &
            "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub UserArrivedNotify(FullName As String, BusName As String, Location As String, Destination As String)
        Dim UniqueID As String = AdminControlData.CollectUniqueID(FullName)
        Dim NotificationID As Integer = CollectData.ToGenerateNotificationID
        Dim DateToday As Date = DateTime.Now.ToString("d")
        Dim Title As String = "You have arrived to your bus " + BusName + " "
        Dim Description As String = "You now confirmed your arrival on your reservation to bus " + BusName + " - going from " + Location + " to " + Destination + ". Have a safe trip!"
        Sql = "INSERT INTO UserNotification VALUES('" & UniqueID & "'," & NotificationID & ",'" & DateToday & "','" & Title & "','" & Description & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub
End Class
