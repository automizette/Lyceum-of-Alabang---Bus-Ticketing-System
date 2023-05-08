Public Class frmDenyCancel_Reason
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Select Case Me.Tag
            Case "DENY"
                Notification.BookDenied(frmModAdminMainMenu.LblUniqueID_Reserve.Text, frmModAdminMainMenu.LblBusName_Reserve.Text, frmModAdminMainMenu.LblPointA_Reserve.Text, frmModAdminMainMenu.LblPointB_Reserve.Text, frmModAdminMainMenu.LblTime_Reserve.Text, frmModAdminMainMenu.LblDate_Reserve.Text, CmbReason.Text)
                MessageBox.Show("User " + frmModAdminMainMenu.LblFullName_Reserve.Text + "'s reservation has been denied and has been notified.", "Reserve state denied successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                frmModAdminMainMenu.DgvBookReservations.DataSource = CollectData.AllUserReservation(frmModAdminMainMenu.CmbFilterBusName.Text)
                frmModAdminMainMenu.PnlButtons.Enabled = False
                frmModAdminMainMenu.LblBusName_Reserve.Text = "Bus Name"
                frmModAdminMainMenu.LblFullName_Reserve.Text = "Full Name"
                frmModAdminMainMenu.LblLRN_Reserve.Text = "LOA-XXXXXX"
                frmModAdminMainMenu.LblPlateNum_Reserve.Text = "Plate Number"
                frmModAdminMainMenu.LblDate_Reserve.Text = "MM/DD"
                frmModAdminMainMenu.LblTime_Reserve.Text = "00:00(P/A)"
                frmModAdminMainMenu.LblPointA_Reserve.Text = "Location"
                frmModAdminMainMenu.LblPointB_Reserve.Text = "Destination"
                frmModAdminMainMenu.LblSeatCode_Reserve.Text = "A0"
                frmModAdminMainMenu.LblStatus_Reserve.Text = "---"
                Modify.GetReservationCount(frmModAdminMainMenu.LblReservationActive)
                Me.Tag = Nothing
                Me.Close()
            Case "DELETE"
                Notification.BookCancelled(frmModAdminMainMenu.LblUniqueID_Reserve.Text, frmModAdminMainMenu.LblBusName_Reserve.Text, frmModAdminMainMenu.LblPointA_Reserve.Text, frmModAdminMainMenu.LblPointB_Reserve.Text, frmModAdminMainMenu.LblTime_Reserve.Text, frmModAdminMainMenu.LblDate_Reserve.Text, CmbReason.Text)
                CollectData.FromCancellation_AdminMod(frmModAdminMainMenu.LblUniqueID_Reserve.Text, frmModAdminMainMenu.LblUniqueID_Reserve.Text, frmModAdminMainMenu.LblFullName_Reserve.Text, frmModAdminMainMenu.LblBusName_Reserve.Text, frmModAdminMainMenu.LblPlateNum_Reserve.Text, frmModAdminMainMenu.LblPointA_Reserve.Text, frmModAdminMainMenu.LblPointB_Reserve.Text, "3", frmModAdminMainMenu.LblTime_Reserve.Text, frmModAdminMainMenu.LblDate_Reserve.Text, frmModAdminMainMenu.LblLocalServerDate_Time.Text)
                CollectData.ComputeRefundPrice_AdminMod(frmModAdminMainMenu.LblBusName_Reserve.Text, frmModAdminMainMenu.LblUniqueID_Reserve.Text)
                CollectData.ToAddSeatFromBus(frmModAdminMainMenu.LblPlateNum_Reserve.Text, frmModAdminMainMenu.LblBusName_Reserve.Text)
                CollectData.DeletePassengerData_ModAdmin(frmModAdminMainMenu.LblFullName_Reserve.Text, frmModAdminMainMenu.LblBusName_Reserve.Text, frmModAdminMainMenu.LblPointA_Reserve.Text, frmModAdminMainMenu.LblPointB_Reserve.Text)
                MessageBox.Show("User " + frmModAdminMainMenu.LblFullName_Reserve.Text + "'s reservation has been cancelled and deleted", "User reservation deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmModAdminMainMenu.DgvBusList_Admin.DataSource = CollectData.FromBusList
                frmModAdminMainMenu.DgvBookReservations.DataSource = CollectData.AllUserReservation(frmModAdminMainMenu.CmbFilterBusName.Text)
                frmModAdminMainMenu.PnlButtons.Enabled = False
                frmModAdminMainMenu.LblBusName_Reserve.Text = "Bus Name"
                frmModAdminMainMenu.LblFullName_Reserve.Text = "Full Name"
                frmModAdminMainMenu.LblLRN_Reserve.Text = "LOA-XXXXXX"
                frmModAdminMainMenu.LblPlateNum_Reserve.Text = "Plate Number"
                frmModAdminMainMenu.LblDate_Reserve.Text = "MM/DD"
                frmModAdminMainMenu.LblTime_Reserve.Text = "00:00(P/A)"
                frmModAdminMainMenu.LblPointA_Reserve.Text = "Location"
                frmModAdminMainMenu.LblPointB_Reserve.Text = "Destination"
                frmModAdminMainMenu.LblSeatCode_Reserve.Text = "A0"
                frmModAdminMainMenu.LblStatus_Reserve.Text = "---"
                Modify.GetReservationCount(frmModAdminMainMenu.LblReservationActive)
                Me.Tag = Nothing
                Me.Close()
        End Select
    End Sub

    Private Sub BtnEditCmb_Click(sender As Object, e As EventArgs) Handles BtnEditCmb.Click
        If BtnEditCmb.Text = "Others" Then
            CmbReason.DropDownStyle = ComboBoxStyle.DropDown
            BtnEditCmb.Text = "Remove"
            BtnEditCmb.BackColor = Color.IndianRed
        ElseIf BtnEditCmb.Text = "Remove" Then
            CmbReason.DropDownStyle = ComboBoxStyle.DropDown
            CmbReason.Text = Nothing
            BtnEditCmb.Text = "Others"
            BtnEditCmb.BackColor = Color.LightBlue
        End If
    End Sub
End Class