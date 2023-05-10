Public Class frmFirstTimeSetup

    Public Shared StepNumber As Integer = 1
    Private Sub frmFirstTimeSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tutorial.CheckTutorialNumber()
    End Sub

    Private Sub LnkNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkNext.LinkClicked
        StepNumber = StepNumber + 1
        Tutorial.CheckTutorialNumber()
    End Sub

    Private Sub LnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBack.LinkClicked
        StepNumber = StepNumber - 1
        Tutorial.CheckTutorialNumber()
    End Sub

    Private Sub LnkContinue_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkContinue.LinkClicked
        MessageBox.Show("If you have any difficulties, a user-manue is also available for you to use. Make sure to read it!", "Another note!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class