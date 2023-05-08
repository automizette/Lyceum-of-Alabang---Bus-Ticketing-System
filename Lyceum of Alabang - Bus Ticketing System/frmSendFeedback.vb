Public Class frmSendFeedback

    Public Shared FeedbackNumber As Integer

    Private Sub frmSendFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PbPicture.Image = PbPicture.InitialImage
    End Sub
    Private Sub BtnInsertImage_Click(sender As Object, e As EventArgs) Handles BtnInsertImage.Click
        If BtnInsertImage.Text = "Remove" Then
            BtnInsertImage.BackColor = Color.LightSkyBlue
            BtnInsertImage.Text = "Insert Image"
            PbPicture.Image = PbPicture.InitialImage
        Else
            Modify.InsertImage(PbPicture)
        End If
    End Sub

    Private Sub BtnSendFeedback_Click(sender As Object, e As EventArgs) Handles BtnSendFeedback.Click
        If CmbFeedbackType.Text = Nothing Then
            MessageBox.Show("Please choose the type of feedback you want to address", "Feedback type empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtTitle.Text = Nothing Then
            MessageBox.Show("Please enter a title for your feedback", "Title is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtFeedbackDesc.Text = Nothing Then
            MessageBox.Show("Please enter you feedback in the feedback box.", "Feedback box is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Your feedback is important to us, continue sending this feedback?", "Feedback confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                FeedbackNumber = CollectData.ToGenerateFeedbackNumber
                CollectData.SubmitFeedbackByUser(frmUserMainMenu.LblUniqueID_MainMenu.Text, frmUserMainMenu.LblFullName.Text, CmbFeedbackType.Text, frmUserMainMenu.LblLocalServerTime_Date.Text, TxtTitle.Text, TxtFeedbackDesc.Text, FeedbackNumber)
                If PbPicture.Image IsNot Nothing Then
                    Dim ImagePath As String = Application.StartupPath & "\frmFeedbackInsertImages"
                    Dim NewFile As String = CStr(FeedbackNumber) & ".jpg"

                    PbPicture.Image.Save(ImagePath & "\" & NewFile, System.Drawing.Imaging.ImageFormat.Jpeg)

                    MessageBox.Show("Feedback sent. Thank you!", "Feedback sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class