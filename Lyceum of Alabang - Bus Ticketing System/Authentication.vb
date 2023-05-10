Imports System.Data.OleDb
Imports Microsoft.SqlServer.Server

Public Class Authentication

    Public Shared OTPAuthenticated As Boolean

    Public Shared Sub LoginAuthentication(Username As String, Password As String)
        Sql = "SELECT * FROM UserAccounts WHERE Username ='" & Username & "' AND Password ='" & Password & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            If DataReader("Activation") = True Then
                Select Case DataReader("AccountType")
                    Case "Student/Staff"
                        MessageBox.Show("Login Authentication Success! Welcome, " + DataReader("FirstName") + ".", "Login success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        frmUserMainMenu.LblFullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmUserMainMenu.LblUniqueID_Booking.Text = DataReader("UniqueID")
                        frmUserMainMenu.LblPremium_UniqueID.Text = DataReader("UniqueID")
                        frmUserMainMenu.LblUniqueID_Account.Text = DataReader("UniqueID")
                        frmUserMainMenu.LblFullName_Booking.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmUserMainMenu.LblAccountInformation_FullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmUserMainMenu.LblLRN.Text = DataReader("LRN")
                        frmUserMainMenu.LblLRN_Account.Text = DataReader("LRN")
                        frmUserMainMenu.LblLRN_Booking.Text = DataReader("LRN")
                        frmUserMainMenu.LblUsername.Text = DataReader("Username")
                        frmUserMainMenu.LblAccount_Username.Text = DataReader("Username")
                        frmUserMainMenu.TxtUsername_Account.Text = DataReader("Username")
                        frmUserMainMenu.LblUniqueID_MainMenu.Text = DataReader("UniqueId")
                        frmUserMainMenu.TxtEmail_Account.Text = DataReader("EmailAddress")
                        frmUserMainMenu.LblAccountType_Account.Text = DataReader("AccountType")

                        frmSeatPicker.AccountType_FilteredSeatin = frmUserMainMenu.LblPlateNumber
                        frmSeatPicker.BookButton_Filtered = frmUserMainMenu.BtnBookNow
                        frmSeatPicker.AssignedSeat = frmUserMainMenu.LblAssignedSeat

                        FrmReceipt.UniqueID = frmUserMainMenu.LblUniqueID_MainMenu
                        CollectData.BookingImportingValidation_UniqueID = DataReader("UniqueID")

                        Sql = "SELECT * FROM SystemSettings"
                        Command = New OleDbCommand(Sql, Connection)
                        DataReader = Command.ExecuteReader

                        While DataReader.Read
                            If DataReader("IsMaintenanceModeForUsersOnly") = True Then
                                MessageBox.Show("Lyceum of Alabang - Bus Ticketing System is currently undergoing maintenance. We ask for you kind patient as we try our best to improve your experience. Thank you!", "Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Else
                                frmUserMainMenu.Show()
                                frmLogin.Hide()
                            End If
                        End While
                    Case "Moderator"
                        MessageBox.Show("Login Authentication Success! Welcome, " + DataReader("FirstName") + ".", "Login (Moderator) success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        frmModAdminMainMenu.LblFullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmModAdminMainMenu.LblAboutYou_FullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmModAdminMainMenu.LblUsername.Text = DataReader("Username")
                        frmModAdminMainMenu.LblLRN.Text = DataReader("LRN")
                        frmModAdminMainMenu.LblUniqueID_AboutYou.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblUniqueID_MainMenu.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblAccountType.Text = DataReader("AccountType")

                        frmModAdminMainMenu.LblFullName_AccInfo.Text = DataReader("FullName")
                        frmModAdminMainMenu.LblUsername_AccInfo.Text = DataReader("Username")
                        frmModAdminMainMenu.LblUniqueID_AccInfo.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblLRN_AccInfo.Text = DataReader("LRN")
                        frmModAdminMainMenu.TxtEmail_Account.Text = DataReader("EmailAddress")
                        frmModAdminMainMenu.TxtUsername_Account.Text = DataReader("Username")

                        frmSeatPicker.AccountType_FilteredSeatin = frmModAdminMainMenu.LblPlateNumber
                        frmSeatPicker.BookButton_Filtered = frmModAdminMainMenu.BtnBookNow
                        frmSeatPicker.AssignedSeat = frmModAdminMainMenu.LblAssignedSeat

                        FrmReceipt.UniqueID = frmModAdminMainMenu.LblUniqueID_MainMenu
                        CollectData.BookingImportingValidation_UniqueID = DataReader("UniqueID")

                        frmModAdminMainMenu.PbAdminSettings.Visible = False

                        frmModAdminMainMenu.Show()
                        frmLogin.Hide()
                    Case "Administrator"
                        MessageBox.Show("Login Authentication Success! Welcome, " + DataReader("FirstName") + ".", "Login (Administrator) success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        frmModAdminMainMenu.LblFullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmModAdminMainMenu.LblAboutYou_FullName.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmModAdminMainMenu.LblUsername.Text = DataReader("Username")
                        frmModAdminMainMenu.LblLRN.Text = DataReader("LRN")
                        frmModAdminMainMenu.LblUniqueID_AboutYou.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblUniqueID_MainMenu.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblAccountType.Text = DataReader("AccountType")

                        frmModAdminMainMenu.LblFullName_AccInfo.Text = DataReader("FirstName") + " " + DataReader("LastName")
                        frmModAdminMainMenu.LblUsername_AccInfo.Text = DataReader("Username")
                        frmModAdminMainMenu.LblUniqueID_AccInfo.Text = DataReader("UniqueID")
                        frmModAdminMainMenu.LblLRN_AccInfo.Text = DataReader("LRN")
                        frmModAdminMainMenu.TxtEmail_Account.Text = DataReader("EmailAddress")
                        frmModAdminMainMenu.TxtUsername_Account.Text = DataReader("Username")
                        frmModAdminMainMenu.LblAccountType_Account.Text = DataReader("AccountType")

                        frmSeatPicker.AccountType_FilteredSeatin = frmModAdminMainMenu.LblPlateNumber
                        frmSeatPicker.BookButton_Filtered = frmModAdminMainMenu.BtnBookNow
                        frmSeatPicker.AssignedSeat = frmModAdminMainMenu.LblAssignedSeat

                        FrmReceipt.UniqueID = frmModAdminMainMenu.LblUniqueID_MainMenu
                        CollectData.BookingImportingValidation_UniqueID = DataReader("UniqueID")

                        frmModAdminMainMenu.PbAdminSettings.Visible = True

                        frmModAdminMainMenu.Show()
                        frmLogin.Hide()
                End Select
            Else
                MessageBox.Show("This user is currently deactivated due to an illegal access of your account or it has been deactivated by an administrator. Please contact the administrator to recover your account", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            frmLogin.LblNotify.Text = "User is not found or incorrect username and password. Please try again."
        End If
    End Sub

    Public Shared Sub AdministratorPriveleges(Username As String, UniqueID As String)
        Sql = "SELECT * FROM UserSettings WHERE Username ='" & Username & "' AND UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("HasAdministratorRole") = True Then
                frmModAdminMainMenu.PbAdminSettings.Visible = True
            ElseIf DataReader("HasAdministratorRole") = False Then
                frmModAdminMainMenu.PbAdminSettings.Visible = False
            End If
        End While
    End Sub

    Public Shared Sub OTPAuthentication(UniqueID As String, OTPInput As Integer)
        Sql = "SELECT OTPCode FROM UserOTP WHERE UniqueID ='" & UniqueID & "' AND OTPCode =" & OTPInput & ""
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("OTPCode") = OTPInput Then
                OTPAuthenticated = True
            Else
                OTPAuthenticated = False
            End If
        End While

        'If DataReader.Read = True Then
        'OTPAuthenticated = True
        'Else
        'OTPAuthenticated = False
        'End If
    End Sub

    Public Shared Sub CheckAvailableLCreditsCode(Code As String)
        Sql = "SELECT * FROM LCreditsCode WHERE Code ='" & Code & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            MessageBox.Show("L-Credits code successfully validated", "L-Credits code validated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmLCredits_CashIn.LblLCreditsObtained.Text = DataReader("Balance")
            frmLCredits_CashIn.LblLCreditsNewBalance.Text = Val(frmUserMainMenu.LblCreditScore.Text) + Val(frmLCredits_CashIn.LblLCreditsObtained.Text)
            frmLCredits_CashIn.PnlEnterCode.Enabled = True
            frmLCredits_CashIn.BtnCheckReferralCode.Text = "Cancel"
            frmLCredits_CashIn.BtnCheckReferralCode.BackColor = Color.IndianRed
            frmLCredits_CashIn.PnlLCreditStatus.Visible = True
        Else
            MessageBox.Show("L-Credits code not found, please check if the code is in correct format.", "L-Credits code not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Shared Sub DeleteLCreditsCode(Code As String)
        Sql = "DELETE FROM LCreditsCode WHERE Code ='" & Code & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub CashInLCredits_ToUser(LCredits As Integer, UniqueID As String)
        Sql = "UPDATE UserAccounts SET CreditScore = CreditScore +" & LCredits & " WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub CheckUserIfPremium_Booking(UniqueID As String, Role As Integer)
        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            Select Case Role
                Case 1
                    If DataReader("IsPremium") = True Then
                        frmUserMainMenu.LblUserIfPremium.Visible = True
                        frmUserMainMenu.LblPrice.ForeColor = Color.Orange
                    Else
                        'Nothing
                    End If
                Case 2
                    If DataReader("IsPremium") = True Then
                        'Nothing
                    Else
                        frmUserMainMenu.PnlLCreditConverter.Visible = True
                    End If
            End Select
        End While
    End Sub
    Public Shared Sub RequestUserCredits(UniqueID As String)
        Sql = "SELECT CreditScore FROM UserAccounts WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            frmUserMainMenu.LblCreditScore.Text = DataReader("CreditScore")
            frmUserMainMenu.LblCreditScore_Account.Text = DataReader("CreditScore")
        End While
    End Sub

    Public Shared Sub LRNValidation(LRN As Double)
        Sql = "SELECT * FROM LRNAvailability WHERE LRNNumber =" & LRN & ""
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            If frmSignUp.BtnValidateLrn.Text = "Validate" Then
                MessageBox.Show("LRN/ID number has been validated.")
                frmSignUp.LblFirstName.Text = DataReader("UserFirstName")
                frmSignUp.LblLastName.Text = DataReader("UserLastName")
                frmSignUp.LblBirthdate.Text = DataReader("UserBirthDate")
                frmSignUp.LblUserType.Text = DataReader("UserType")
                frmSignUp.LblUniqueID.Text = DataReader("AssignedUniqueID")
                frmSignUp.BtnValidateLrn.BackColor = Color.LightCoral
                frmSignUp.BtnValidateLrn.Text = "Cancel"
                frmSignUp.TxtLrnId.Enabled = False
                frmSignUp.GrpInputFields.Enabled = True
            ElseIf frmSignUp.BtnValidateLrn.Text = "Cancel" Then
                frmSignUp.GrpInputFields.Enabled = False
                frmSignUp.LblFirstName.Text = "First Name"
                frmSignUp.LblLastName.Text = "Last Name"
                frmSignUp.LblBirthdate.Text = "MM/DD/YYYY"
                frmSignUp.LblUserType.Text = "N/A"
                frmSignUp.TxtLrnId.Enabled = True
                frmSignUp.TxtLrnId.Text = ""
                frmSignUp.BtnValidateLrn.BackColor = Color.Aqua
                frmSignUp.BtnValidateLrn.Text = "Validate"
            End If
        Else
            MessageBox.Show("LRN Not found")
        End If
    End Sub

    Public Shared Sub RefundBackCreditScore_ToUser(UniqueID As String, RefundAmount As Integer)
        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & frmUserMainMenu.LblUniqueID_MainMenu.Text & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                'Nothing
            Else
                Sql = "UPDATE UserAccounts SET CreditScore = CreditScore + " & RefundAmount & " WHERE UniqueID ='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            End If
        End While
    End Sub

    Public Shared Sub DeductCreditScore_FromUser(UniqueID As String, Price As Integer)
        Sql = "SELECT IsPremium FROM UserSettings WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("IsPremium") = True Then
                'Nothing
            Else
                Sql = "UPDATE UserAccounts SET CreditScore = CreditScore - " & Price & " WHERE UniqueID ='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            End If
        End While
    End Sub

    Public Shared Sub CreateUserPriveleges(UniqueID As String, Username As String)
        Dim FullName As String = frmSignUp.LblFirstName.Text + " " + frmSignUp.LblLastName.Text
        Sql = "INSERT INTO UserSettings([UniqueID],[Username],[FullName])VALUES('" & UniqueID & "','" & Username & "','" & FullName & "')"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub CreateAccount(UniqueID As String, Email As String, LRN As Double, FirstName As String, LastName As String, Username As String, Password As String, Birthdate As String, UserType As String)
        Sql = "INSERT INTO UserAccounts([UniqueID],[EmailAddress],[Username],[FirstName],[LastName],[LRN],[Password],[Birthdate],[AccountType],[Activation],[OTPEnabled])VALUES('" _
            & UniqueID & "','" & Email & "','" & Username & "','" & FirstName & "','" & LastName & "'," & LRN & ",'" & Password & "','" & Birthdate & "','" & UserType & "'," & True & "," & False & ")"
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub

    Public Shared Sub ChangeOTPState(UniqueID As String, Enabled As Boolean)
        Sql = "SELECT OTPEnabled FROM UserAccounts WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        While DataReader.Read
            If DataReader("OTPEnabled") = False Then
                Sql = "UPDATE UserAccounts SET OTPEnabled =" & Enabled & " WHERE UniqueID ='" & UniqueID & "'"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()
            Else
                'Nothing
            End If
        End While
    End Sub

    Public Shared Sub CreateOTP(UniqueID As String, OTPCode As Integer)
        Sql = "SELECT * FROM UserOTP WHERE UniqueID ='" & UniqueID & "'"
        Command = New OleDbCommand(Sql, Connection)
        DataReader = Command.ExecuteReader

        If DataReader.Read = True Then
            Sql = "UPDATE UserOTP SET OTPCode =" & OTPCode & " WHERE UniqueID ='" & UniqueID & "'"
            Command = New OleDbCommand(Sql, Connection)
            Command.ExecuteNonQuery()
        ElseIf DataReader.Read = False Then
            Sql = "INSERT INTO UserOTP([UniqueID],[OTPCode])VALUES('" & UniqueID & "'," & OTPCode & ")"
            Command = New OleDbCommand(Sql, Connection)
            Command.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Sub ClearLRNAvailabilityForUser(LRNNumber As Double)
        Sql = "DELETE FROM LRNAvailability WHERE LRNNumber =" & LRNNumber & ""
        Command = New OleDbCommand(Sql, Connection)
        Command.ExecuteNonQuery()
    End Sub
End Class
