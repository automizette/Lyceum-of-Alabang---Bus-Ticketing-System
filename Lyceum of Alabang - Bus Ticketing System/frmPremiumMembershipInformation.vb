Public Class frmPremiumMembershipInformation
    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        If MessageBox.Show("You are only a few steps away from getting your premium membership. Before continuing, make sure that you read the information page about our premium membership so you better understand what you get. One more thing: once paying for the membership, please only pay in the exact amount of 55 pesos. Thank you!", "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            frmPayment_Subscribe.Show()
            Me.Close()
        End If
    End Sub
End Class