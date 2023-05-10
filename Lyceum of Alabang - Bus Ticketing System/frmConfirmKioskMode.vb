Public Class frmConfirmKioskMode
    Private Sub BtnArriveSystem_Click(sender As Object, e As EventArgs) Handles BtnArriveSystem.Click
        frmUserArrivalSystem.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBookingSystemKios.Show()
        Me.Close()
    End Sub
End Class