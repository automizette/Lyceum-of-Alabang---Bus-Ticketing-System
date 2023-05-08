Imports System.Data.OleDb

Public Class frmUserNotification
    Private Sub frmUserNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvNotificationsMenu.DataSource = Modify.GetUserNotification
        Modify.NotificationsColumns(DgvNotificationsMenu)
        DgvNotificationsMenu.Columns(1).Width = 70
        DgvNotificationsMenu.Columns(0).Visible = False
    End Sub

    Private Sub DgvNotificationsMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotificationsMenu.CellDoubleClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        Dim AllUsers As String = "ALL_USERS"

        If Index >= 0 Then
            SelectedRow = DgvNotificationsMenu.Rows(Index)
            frmNotificationInformation.Show()

            frmNotificationInformation.LblNotifTitle.Text = SelectedRow.Cells(2).Value.ToString

            Dim HiddenNotifID As String = SelectedRow.Cells(0).Value
            Sql = "SELECT Title, Description FROM UserNotification WHERE NotifID =" & HiddenNotifID & " AND For_User ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "' OR For_User ='" & AllUsers & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                frmNotificationInformation.LblNotifDescription.Text = DataReader("Description")
            End While

            frmNotificationInformation.Text = SelectedRow.Cells(2).Value.ToString
        End If
    End Sub

    Public Shared NotificationID As Integer
    Private Shared NotificationTitle As String

    Private Sub DgvNotificationsMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotificationsMenu.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvNotificationsMenu.Rows(Index)

            NotificationID = SelectedRow.Cells(0).Value
            NotificationTitle = SelectedRow.Cells(2).Value
            BtnClearThisNotif.Enabled = True
        End If
    End Sub

    Private Sub BtnClearThisNotif_Click(sender As Object, e As EventArgs) Handles BtnClearThisNotif.Click
        If MessageBox.Show("Do you want to delete the notification " + NotificationTitle + "?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.DeleteSpecificNotification(frmUserMainMenu.LblUniqueID_MainMenu.Text)
            NotificationID = Nothing
            NotificationTitle = Nothing
            MessageBox.Show("Notification has been cleared", "Notification clear", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BtnClearThisNotif.Enabled = False
            Modify.GetUserNotification()
            DgvNotificationsMenu.DataSource = Modify.GetUserNotification
            Modify.GetUserNotificationCount(frmUserMainMenu.LblUniqueID_MainMenu.Text)
        End If
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        If MessageBox.Show("Do you want to clear all your notifications?", "Clear notifications?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CollectData.DeleteAllNotification(frmUserMainMenu.LblUniqueID_MainMenu.Text)
            NotificationID = Nothing
            NotificationTitle = Nothing
            MessageBox.Show("All notifications has been cleared", "All notifications cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Modify.GetUserNotification()
            DgvNotificationsMenu.DataSource = Modify.GetUserNotification
            DgvNotificationsMenu.Columns(1).Width = 70
            Modify.GetUserNotificationCount(frmUserMainMenu.LblUniqueID_MainMenu.Text)
        End If
    End Sub
End Class