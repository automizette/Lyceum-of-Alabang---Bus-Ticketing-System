Imports System.Data.OleDb
Imports System.IO

Public Class frmCheckFeedback
    Private Sub frmCheckFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Suggestions")

        Admin_Modify.FeedbackDGVColumns(DgvFeedbackList)


    End Sub

    Private Sub DgvFeedbackList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFeedbackList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvFeedbackList.Rows(Index)

            Sql = "SELECT * FROM UserFeedbacks WHERE FeedbackNumber =" & SelectedRow.Cells(0).Value & ""
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            LblFeedbackNumber.Text = SelectedRow.Cells(0).Value.ToString()

            While DataReader.Read
                LblFullName_FB.Text = DataReader("UserFullName")
                LblDateSub_FB.Text = DataReader("DateOfSubmission")
                LblType_FB.Text = DataReader("FeedbackType")

                LblTitle_FB.Text = DataReader("FeedbackTitle")
                LblDesc_FB.Text = DataReader("FeedbackDescription")
            End While

            Dim ImageAttached As String = SelectedRow.Cells(0).Value.ToString & ".jpg"
            Dim ImagePath As String = Application.StartupPath & "\frmFeedbackInsertImages\"

            If System.IO.File.Exists(ImagePath & ImageAttached) Then
                PbFeedbackAttached.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(ImagePath & ImageAttached)), True, False)
            Else
                PbFeedbackAttached.Image = PbFeedbackAttached.InitialImage
            End If

            BtnClearFeedback.Enabled = True
        End If
    End Sub

    Private Sub BtnClearFeedback_Click(sender As Object, e As EventArgs) Handles BtnClearFeedback.Click
        Sql = "DELETE FROM UserFeedbacks WHERE FeedbackNumber =" & LblFeedbackNumber.Text & ""
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()

        MessageBox.Show("Feedback number " + LblFeedbackNumber.Text + " has been cleared", "Feedback cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LblFullName_FB.Text = "Full Name"
        LblDateSub_FB.Text = "MM/DD/YYYY"
        LblType_FB.Text = "Type"
        LblFeedbackNumber.Text = "00000000"

        LblTitle_FB.Text = "Title"
        LblDesc_FB.Text = "Description"

        PbFeedbackAttached.Image = PbFeedbackAttached.InitialImage

        BtnClearFeedback.Enabled = False

        DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Suggestions")
        BtnFilters.Text = "Suggestions"
        BtnFilters.BackColor = Color.LawnGreen
    End Sub

    Private Sub BtnFilters_Click(sender As Object, e As EventArgs) Handles BtnFilters.Click
        If BtnFilters.Text = "Suggestions" Then
            BtnFilters.Text = "Bugs"
            BtnFilters.BackColor = Color.Yellow
            DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Bugs")
        ElseIf BtnFilters.Text = "Bugs" Then
            BtnFilters.Text = "Errors"
            BtnFilters.BackColor = Color.IndianRed
            DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Errors")
        ElseIf BtnFilters.Text = "Errors" Then
            BtnFilters.Text = "Transaction"
            BtnFilters.BackColor = Color.MediumPurple
            DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Transaction")
        ElseIf BtnFilters.Text = "Transaction" Then
            BtnFilters.Text = "Suggestions"
            BtnFilters.BackColor = Color.LawnGreen
            DgvFeedbackList.DataSource = AdminControlData.GetUserFeedbacks_Admin("Suggestions")
        End If
    End Sub
End Class