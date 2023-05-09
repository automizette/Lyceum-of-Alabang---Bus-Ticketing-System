Imports System.Data.OleDb

Public Class frmAdminControls
    Private Sub frmAdminControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminControlData.CountLCreditCodes(LblCountCodes)

        DgvUserList.DataSource = CollectData.UserList_Admin
        DgvBusList.DataSource = AdminControlData.GetBusList
        DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL
        DgvLCreditCodes.DataSource = AdminControlData.GetLCreditCodes
        DgvLoadRequest.DataSource = AdminControlData.GetUserRequest_Load

        Admin_Modify.CheckUserAccess_AdminControls(frmModAdminMainMenu.LblUniqueID_MainMenu.Text)
        'Admin_Modify.ModifyDTP(DtpDOD)
        Admin_Modify.ModifyTTP(DtpTOD)
        Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        Admin_Modify.UserRequestColumns_LC(DgvLoadRequest)

        SearchEngine.SearchLRN_Admin(TxtSearchLRN_EditUsers)
    End Sub

    Private Sub DgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUserList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvUserList.Rows(Index)


            Sql = "SELECT * FROM UserAccounts WHERE LRN =" & SelectedRow.Cells(0).Value & ""
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                If DataReader("Activation") = True Then
                    CmbActiveStatus_EditUser.Text = "Active"
                    'BtnActivateUser.Enabled = False
                    'BtnDeactivateUser.Enabled = True
                Else
                    CmbActiveStatus_EditUser.Text = "Inactive"
                    'BtnActivateUser.Enabled = True
                    'BtnDeactivateUser.Enabled = False
                End If

                LblLastName_EditUser.Text = DataReader("LastName")
                LblFirstName_EditUser.Text = DataReader("FirstName")
                TxtUsername_EditUser.Text = DataReader("Username")
                LblLRN_EditUser.Text = DataReader("LRN")
                LblUniqueID_EditUser.Text = DataReader("UniqueID")
                TxtEmail_EditUser.Text = DataReader("EmailAddress")
                DtpBirthdate.Text = DataReader("Birthdate")
                CmbAccType_EditUser.Text = DataReader("AccountType")
                TxtPassword_EditUser.Text = DataReader("Password")

                TxtUsername_EditUser.Enabled = True
                TxtEmail_EditUser.Enabled = True
                DtpBirthdate.Enabled = True
                CmbAccType_EditUser.Enabled = True
                CmbActiveStatus_EditUser.Enabled = True
                BtnChangePassword.Enabled = True

                BtnSaveInformation.Enabled = True
                BtnChangePfp.Enabled = True

                Dim UserImage As String = DataReader("UniqueID") & ".jpg"
                Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

                If System.IO.File.Exists(ImagePath & UserImage) Then
                    PbProfilePicture.Image = Image.FromFile(ImagePath & UserImage)
                Else
                    PbProfilePicture.Image = PbProfilePicture.InitialImage
                End If
            End While
        End If
    End Sub

    Private Sub TxtSearchLRN_EditUsers_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchLRN_EditUsers.TextChanged
        If TxtSearchLRN_EditUsers.Text.Length > 0 Then
            If Not IsNumeric(TxtSearchLRN_EditUsers.Text) Then
                Dim Selection As Integer = TxtSearchLRN_EditUsers.SelectionStart
                TxtSearchLRN_EditUsers.Text = TxtSearchLRN_EditUsers.Text.Remove(Selection - 1, 1)
                TxtSearchLRN_EditUsers.SelectionStart = Selection - 1
            End If
        End If

        DgvUserList.DataSource = SearchEngine.SearchLRN_Changed(TxtSearchLRN_EditUsers)

        If TxtSearchLRN_EditUsers.Text = "" Then
            DgvUserList.DataSource = CollectData.UserList_Admin()
        End If
    End Sub

    Private Sub BtnChangePfp_Click(sender As Object, e As EventArgs) Handles BtnChangePfp.Click
        If BtnChangePfp.Text = "Remove" Then
            BtnPicSave.Visible = False
            BtnChangePfp.BackColor = Color.Aquamarine
            BtnChangePfp.Text = "Change"
            Modify.UniversalProfilPictureCheck_Admin(LblUniqueID_EditUser.Text, PbProfilePicture)
        Else
            Modify.UniversalOpenDialog_Admin(LblUniqueID_EditUser.Text, PbProfilePicture, BtnChangePfp, BtnPicSave)
        End If
    End Sub

    Private Sub BtnPicSave_Click(sender As Object, e As EventArgs) Handles BtnPicSave.Click
        If MessageBox.Show("Do you want to change " + LblFirstName_EditUser.Text + "'s profile picture?", "Confirm Profile picture change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If PbProfilePicture.Image IsNot Nothing Then
                Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures"
                Dim NewFile As String = LblUniqueID_EditUser.Text & ".jpg"

                PbProfilePicture.Image.Save(ImagePath & "\" & NewFile, System.Drawing.Imaging.ImageFormat.Jpeg)

                MessageBox.Show("Profile picture saved successfully", "Profile picture change success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Modify.UniversalProfilPictureCheck_Admin(LblUniqueID_EditUser.Text, PbProfilePicture)

                BtnPicSave.Visible = False
                BtnChangePfp.Text = "Change"
                BtnChangePfp.BackColor = Color.Aquamarine
            End If
        End If
    End Sub

    Private Sub BtnSaveInformation_Click(sender As Object, e As EventArgs) Handles BtnSaveInformation.Click
        If MessageBox.Show("Do you want to change this user's information?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            AdminControlData.UpdateUserInformation(LblUniqueID_EditUser.Text, TxtUsername_EditUser.Text, TxtEmail_EditUser.Text, DtpBirthdate.Text, TxtPassword_EditUser.Text, CmbAccType_EditUser.Text)
            MessageBox.Show("User information changed successfully", "User information change success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtEmail_EditUser.Text = Nothing
            TxtUsername_EditUser.Text = Nothing
            TxtPassword_EditUser.Text = Nothing
            CmbAccType_EditUser.Text = Nothing
            CmbActiveStatus_EditUser.Text = Nothing
            BtnPicSave.Visible = False
            LblLastName_EditUser.Text = "Last Name"
            LblFirstName_EditUser.Text = "First Name"
            LblLRN_EditUser.Text = "000000000000"
            LblUniqueID_EditUser.Text = "LOA-XXXXXX"

            TxtEmail_EditUser.Enabled = False
            TxtUsername_EditUser.Enabled = False
            TxtPassword_EditUser.Enabled = False
            CmbAccType_EditUser.Enabled = False
            CmbActiveStatus_EditUser.Enabled = False
            BtnChangePassword.Enabled = False
            BtnChangePfp.Enabled = False
            BtnSaveInformation.Enabled = False
        End If
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        If BtnChangePassword.Text = "Back" Then
            Sql = "SELECT Password FROM UserAccounts WHERE UniqueID ='" & LblUniqueID_EditUser.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            BtnChangePassword.Text = "Change"
            BtnChangePassword.BackColor = Color.SteelBlue
            TxtPassword_EditUser.Enabled = False

            While DataReader.Read
                TxtPassword_EditUser.Text = DataReader("Password")
            End While
        Else
            MessageBox.Show("Changing someone's password may loss the user's access to their account. Please only change the password with the user's permission or permission by the administrator.", "Accessing Sensitive Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword_EditUser.Enabled = True
            BtnChangePassword.BackColor = Color.IndianRed
            BtnChangePassword.Text = "Back"
        End If
    End Sub

    Private Sub TxtLRN_Create_TextChanged(sender As Object, e As EventArgs) Handles TxtLRN_Create.TextChanged
        If TxtLRN_Create.Text.Length > 0 Then
            If Not IsNumeric(TxtLRN_Create.Text) Then
                Dim Selection As Integer = TxtLRN_Create.SelectionStart
                TxtLRN_Create.Text = TxtLRN_Create.Text.Remove(Selection - 1, 1)
                TxtLRN_Create.SelectionStart = Selection - 1
            End If
        End If
    End Sub

    Private Sub BtnConfirmIDNumber_Create_Click(sender As Object, e As EventArgs) Handles BtnConfirmIDNumber_Create.Click
        If BtnConfirmIDNumber_Create.Text = "Change" Then
            TxtLRN_Create.Text = Nothing
            TxtLRN_Create.Enabled = True
            TxtFirstName_Create.Text = Nothing
            TxtLastName_Create.Text = Nothing
            LblUniqueCode_Create.Text = Nothing
            CmbAccType_Create.Text = Nothing
            BtnContinueToNext.Visible = False

            TxtFirstName_Create.Enabled = False
            TxtLastName_Create.Enabled = False

            GrpAccType.Enabled = False
            LblUniqueCode_Create.Text = "000000"

            BtnConfirmIDNumber_Create.Text = "Confirm"
            BtnConfirmIDNumber_Create.BackColor = Color.PaleGreen
        Else
            If TxtLRN_Create.Text = Nothing Then
                MessageBox.Show("Please enter the LRN/ID number of the student/staff.", "LRN/ID number missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtLRN_Create.TextLength < 12 Then
                MessageBox.Show("LRN/ID number must be 12 characters max", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sql = "SELECT * FROM LRNAvailability WHERE LRNNumber =" & TxtLRN_Create.Text & ""
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                If DataReader.Read = True Then
                    MessageBox.Show("LRN/ID has already been added to the database and ready to be registered by the user", "LRN/ID already exists", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    'DataReader.Close()
                Else
                    Sql = "SELECT * FROM UserAccounts WHERE LRN =" & TxtLRN_Create.Text & ""
                    Command = New OleDbCommand(Sql, Connection)
                    DataReader = Command.ExecuteReader

                    If DataReader.Read = True Then
                        MessageBox.Show("LRN/ID has already been registered by the user", "LRN/ID already registered", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        'DataReader.Close()
                    Else
                        If MessageBox.Show("Do you want to continue registering the user with LRN " + TxtLRN_Create.Text + "?", "Confirm creation of account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            BtnConfirmIDNumber_Create.Text = "Change"
                            BtnConfirmIDNumber_Create.BackColor = Color.IndianRed

                            TxtLRN_Create.Enabled = False
                            TxtFirstName_Create.Enabled = True
                            TxtLastName_Create.Enabled = True
                            BtnContinueToNext.Visible = True
                            'DataReader.Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnContinueToNext_Click(sender As Object, e As EventArgs) Handles BtnContinueToNext.Click
        If TxtFirstName_Create.Text = Nothing Or TxtLastName_Create.Text = Nothing Then
            MessageBox.Show("Please fill all the required information!", "Required information is empty", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            If MessageBox.Show("Do you want to confirm the following details: Full Name - " + TxtFirstName_Create.Text + " " + TxtLastName_Create.Text + " associated with the LRN/ID number " + TxtLRN_Create.Text + "?", "Confirm user details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                GrpAccType.Enabled = True
                BtnContinueToNext.Visible = False
                BtnConfirmAllDetails.Visible = True
                GrpImportantInfo.Enabled = False
                LnkGenerate.Enabled = True
            End If
        End If
    End Sub

    Private Sub LnkGenerate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkGenerate.LinkClicked
        AdminControlData.GenerateUniqueCode_ForUniqueID(LblUniqueCode_Create)
        LnkGenerate.Enabled = False
    End Sub

    Private Sub BtnConfirmAllDetails_Click(sender As Object, e As EventArgs) Handles BtnConfirmAllDetails.Click
        If LnkGenerate.Enabled = True Then
            MessageBox.Show("Please generate a UniqueID for the user", "No UniqueID generated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CmbAccType_Create.Text = Nothing Then
            MessageBox.Show("Please select an account role for the user", "Account role is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            BtnCreateAccount.Enabled = True
            BtnResetAll.Enabled = True
            GrpAccType.Enabled = False
            GrpImportantInfo.Enabled = False
        End If
    End Sub

    Private Sub PbAddUser_Click(sender As Object, e As EventArgs) Handles PbAddUser.Click
        TbAdminControlCenter.SelectedTab = Me.TbAddUsers
    End Sub

    Private Sub PbManageUser_Click(sender As Object, e As EventArgs) Handles PbManageUser.Click
        TbAdminControlCenter.SelectedTab = Me.TbManageUsers
    End Sub

    Private Sub PbManageBus_Click(sender As Object, e As EventArgs) Handles PbManageBus.Click
        TbAdminControlCenter.SelectedTab = TbManageBus
    End Sub

    Private Sub PbManagePrivileges_Click(sender As Object, e As EventArgs) Handles PbManagePrivileges.Click
        TbAdminControlCenter.SelectedTab = TbManagePrivileges
    End Sub

    Private Sub PbAddLCredits_Click(sender As Object, e As EventArgs) Handles PbAddLCredits.Click
        TbAdminControlCenter.SelectedTab = TbAddLCredits
    End Sub

    Private Sub PbLoadLCredits_Click(sender As Object, e As EventArgs) Handles PbLoadLCredits.Click
        TbAdminControlCenter.SelectedTab = TbLoadLCredits
    End Sub

    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles BtnCreateAccount.Click
        Dim FullUCode As String = "LOA-" & LblUniqueCode_Create.Text
        If MessageBox.Show("The following details will be imported to the database - Full Name: " + TxtFirstName_Create.Text + " " + LblLastName_EditUser.Text + ", born in " + DtpBDay_Create.Text + ", associated with an LRN/ID number " + TxtLRN_Create.Text + ", with a newly generated UniqueID: " +
                           LblUniqueCode_Create.Text + ", and will be marked with a role of " + CmbAccType_Create.Text + ". Click OK if all details are correct", "Double check if details are correct", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = vbYes Then
            AdminControlData.ImportNewUser(TxtLRN_Create.Text, FullUCode, TxtFirstName_Create.Text, TxtLastName_Create.Text, DtpBDay_Create.Text, CmbAccType_Create.Text)
            MessageBox.Show("A new user has been imported successfully!", "Import user data success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            GrpAccType.Enabled = False
            LblUniqueCode_Create.Text = "000000"
            CmbAccType_Create.Text = Nothing
            BtnConfirmAllDetails.Visible = False
            BtnCreateAccount.Enabled = False
            BtnResetAll.Enabled = False

            GrpImportantInfo.Enabled = True
            TxtLRN_Create.Text = Nothing
            TxtLRN_Create.Enabled = True
            TxtFirstName_Create.Enabled = False
            TxtLastName_Create.Enabled = False
            TxtFirstName_Create.Text = Nothing
            TxtLastName_Create.Text = Nothing
            BtnContinueToNext.Visible = False
            BtnConfirmIDNumber_Create.Text = "Confirm"
            BtnConfirmIDNumber_Create.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub BtnResetAll_Click(sender As Object, e As EventArgs) Handles BtnResetAll.Click
        GrpAccType.Enabled = False
        LblUniqueCode_Create.Text = "000000"
        CmbAccType_Create.Text = Nothing
        BtnConfirmAllDetails.Visible = False

        GrpImportantInfo.Enabled = True
        TxtLRN_Create.Text = Nothing
        TxtLRN_Create.Enabled = True
        TxtFirstName_Create.Enabled = False
        TxtLastName_Create.Enabled = False
        TxtFirstName_Create.Text = Nothing
        TxtLastName_Create.Text = Nothing
        BtnContinueToNext.Visible = False
        BtnConfirmIDNumber_Create.Text = "Confirm"
        BtnConfirmIDNumber_Create.BackColor = Color.PaleGreen
    End Sub

    Private Sub BtnBackToImpo_Click(sender As Object, e As EventArgs) Handles BtnBackToImpo.Click
        GrpAccType.Enabled = False
        LblUniqueCode_Create.Text = "000000"
        CmbAccType_Create.Text = Nothing
        GrpImportantInfo.Enabled = True
        BtnContinueToNext.Visible = True
        BtnBackToImpo.Visible = False
        BtnConfirmAllDetails.Visible = False
    End Sub

    Private Sub DgvBusList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBusList.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvBusList.Rows(Index)

            Sql = "SELECT * FROM BusList WHERE PlateNumber ='" & SelectedRow.Cells(0).Value.ToString & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                GrpBusInformation.Enabled = False
                TxtBusName_AddBus.Text = SelectedRow.Cells(1).Value.ToString
                TxtPlateNum_AddBus.Text = SelectedRow.Cells(0).Value.ToString

                TxtSeatCap_AddBus.Text = DataReader("AvailableSeats")
                TxtLocation_AddBus.Text = DataReader("PointA")
                TxtDestination_AddBus.Text = DataReader("PointB")
                DtpDOD.Text = DataReader("DateOfDeparture")
                DtpTOD.Text = DataReader("TimeOfDeparture")
                TxtFare_AddBus.Text = DataReader("Price")
            End While

            BtnAddBus.Text = "Change info"
            BtnAddBus.BackColor = Color.Orange

            BtnDelete_AddBus.Enabled = True
        End If
    End Sub

    Private Sub BtnAddBus_Click(sender As Object, e As EventArgs) Handles BtnAddBus.Click
        If BtnAddBus.Text = "Change info" Then
            If MessageBox.Show("Do you want to modify bus " + TxtBusName_AddBus.Text + "?", "Continue modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AdminControlData.UpdateBus(TxtPlateNum_AddBus.Text, TxtLocation_AddBus.Text, TxtDestination_AddBus.Text, DtpTOD.Text, DtpDOD.Text, TxtFare_AddBus.Text)
                MessageBox.Show("Bus information has been updated!", "Bus info updated successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GrpBusInformation.Enabled = True
                TxtFare_AddBus.Text = "5"
                TxtLocation_AddBus.Text = Nothing
                TxtDestination_AddBus.Text = Nothing
                TxtPlateNum_AddBus.Text = Nothing
                TxtBusName_AddBus.Text = Nothing
                TxtSeatCap_AddBus.Text = "55"

                BtnAddBus.Text = "Create"
                BtnAddBus.BackColor = Color.MediumSpringGreen
            End If
        Else
            If TxtBusName_AddBus.Text = Nothing Then
                MessageBox.Show("Please enter the bus name or the model of the bus", "Bus Name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtPlateNum_AddBus.Text = Nothing Then
                MessageBox.Show("Please enter the plate number of the bus", "Plate number is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtPlateNum_AddBus.TextLength < 7 Then
                MessageBox.Show("Plate number must be 7 characters (3 letters, 4 numbers)", "Insufficent characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtLocation_AddBus.Text = Nothing Then
                MessageBox.Show("Please enter the location (Point A) of the bus", "Bus location is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtDestination_AddBus.Text = Nothing Then
                MessageBox.Show("Please enter the destination (Point B) of the bus", "Bus destination is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If TxtSeatCap_AddBus.Text > 55 Then
                    MessageBox.Show("Bus' max seat capacity is 55.", "Bus' seat capacity is too high", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    TxtSeatCap_AddBus.Text = "55"
                Else
                    If TxtSeatCap_AddBus.Text < 55 Then
                        If MessageBox.Show("Bus' seat capacity is lower than its full capacity. If this is a reserved bus, you may continue.", "Bus' seat capacity is not full", MessageBoxButtons.OK, MessageBoxIcon.Question) = vbOK Then
                            'Nothing
                        End If
                        If TxtFare_AddBus.Text > 15 Then
                            If MessageBox.Show("Fare price is too high. Continue?", "Fare price too high", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                                'Nothing
                            Else
                                TxtFare_AddBus.Text = "15"
                            End If
                        Else
                            Sql = "SELECT PlateNumber FROM BusList WHERE PlateNumber ='" & TxtPlateNum_AddBus.Text & "'"
                            Command = New OleDbCommand(Sql, Connection)
                            DataReader = Command.ExecuteReader

                            If DataReader.Read = True Then
                                MessageBox.Show("This bus is now present and can't make a duplicate. If you want to change this bus with a plate number " + TxtPlateNum_AddBus.Text + ", please go to manage bus.", "Bus information has already been added", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If MessageBox.Show("Do you want to continue creating the bus: " + TxtBusName_AddBus.Text + ", plate number " + TxtPlateNum_AddBus.Text + ", with the desired route from " + TxtLocation_AddBus.Text + " to " + TxtDestination_AddBus.Text + ", with a departure time and date of " + DtpTOD.Text + ", " + DtpDOD.Text + ". With available " + TxtSeatCap_AddBus.Text + " and a fare of " + TxtFare_AddBus.Text + " L-Credits. Continue?", "Continue Bus Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                    AdminControlData.ImportNewBus(TxtPlateNum_AddBus.Text, TxtBusName_AddBus.Text, TxtLocation_AddBus.Text, TxtDestination_AddBus.Text, DtpTOD.Text, DtpDOD.Text, TxtSeatCap_AddBus.Text, TxtFare_AddBus.Text)
                                    MessageBox.Show("A new bus has been imported to the database!", "Bus has been added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    TxtFare_AddBus.Text = "5"
                                    TxtLocation_AddBus.Text = Nothing
                                    TxtDestination_AddBus.Text = Nothing
                                    TxtPlateNum_AddBus.Text = Nothing
                                    TxtBusName_AddBus.Text = Nothing
                                    TxtSeatCap_AddBus.Text = "55"

                                    DgvBusList.DataSource = AdminControlData.GetBusList
                                End If
                            End If
                        End If
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub BtnReset_AddBus_Click(sender As Object, e As EventArgs) Handles BtnReset_AddBus.Click
        GrpBusInformation.Enabled = True
        TxtFare_AddBus.Text = "5"
        TxtLocation_AddBus.Text = Nothing
        TxtDestination_AddBus.Text = Nothing
        TxtPlateNum_AddBus.Text = Nothing
        TxtBusName_AddBus.Text = Nothing
        TxtSeatCap_AddBus.Text = "55"

        BtnDelete_AddBus.Enabled = False

        BtnAddBus.Text = "Create"
        BtnAddBus.BackColor = Color.MediumSpringGreen
    End Sub

    Private Sub BtnDelete_AddBus_Click(sender As Object, e As EventArgs) Handles BtnDelete_AddBus.Click
        If MessageBox.Show("Are you sure you want to delete the bus " + TxtBusName_AddBus.Text + ", plate number " + TxtPlateNum_AddBus.Text + "?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            AdminControlData.DeleteBus(TxtPlateNum_AddBus.Text)
            MessageBox.Show("Bus " + TxtBusName_AddBus.Text + " has been successfully deleted.", "Bus has been deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            GrpBusInformation.Enabled = True
            TxtFare_AddBus.Text = "5"
            TxtLocation_AddBus.Text = Nothing
            TxtDestination_AddBus.Text = Nothing
            TxtPlateNum_AddBus.Text = Nothing
            TxtBusName_AddBus.Text = Nothing
            TxtSeatCap_AddBus.Text = "55"

            BtnDelete_AddBus.Enabled = False
        End If
    End Sub

    Private Sub DgvManagePrivileges_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvManagePrivileges.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvManagePrivileges.Rows(Index)

            LblUniqueID_ManagePriv.Text = SelectedRow.Cells(0).Value.ToString

            PnlButtons_ManagePriv.Enabled = True

            Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & SelectedRow.Cells(0).Value.ToString & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            While DataReader.Read
                LblFirstName_ManagePriv.Text = DataReader("FirstName")
                LblLastName_ManagePriv.Text = DataReader("LastName")
                LblLRN_ManagePriv.Text = DataReader("LRN")
                LblAccType_ManagePriv.Text = DataReader("AccountType")
                LblUniqueID_ManagePriv.Text = DataReader("UniqueID")
            End While

            Dim UserImage As String = SelectedRow.Cells(0).Value.ToString & ".jpg"
            Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

            If System.IO.File.Exists(ImagePath & UserImage) Then
                PbProfile_ManagePriv.Image = Image.FromFile(ImagePath & UserImage)
            Else
                PbProfile_ManagePriv.Image = PbProfile_ManagePriv.InitialImage
            End If
        End If
    End Sub

    Private Sub BtnFilter_ManagePriv_Click(sender As Object, e As EventArgs) Handles BtnFilter_ManagePriv.Click
        If BtnFilter_ManagePriv.Text = "ALL" Then
            DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_Students
            BtnFilter_ManagePriv.Text = "STUDENTS"
            BtnFilter_ManagePriv.BackColor = Color.LemonChiffon
            Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        ElseIf BtnFilter_ManagePriv.Text = "STUDENTS" Then
            DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_Moderators
            BtnFilter_ManagePriv.Text = "MODERATORS"
            BtnFilter_ManagePriv.BackColor = Color.Orange
            Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        ElseIf BtnFilter_ManagePriv.Text = "MODERATORS" Then
            DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_Admin
            BtnFilter_ManagePriv.Text = "ADMIN"
            BtnFilter_ManagePriv.BackColor = Color.Pink
            Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        ElseIf BtnFilter_ManagePriv.Text = "ADMIN" Then
            DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL
            BtnFilter_ManagePriv.Text = "ALL"
            BtnFilter_ManagePriv.BackColor = Color.PaleTurquoise
            Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        End If
    End Sub

    Private Sub BtnPromoteAdmin_ManagePriv_Click(sender As Object, e As EventArgs) Handles BtnPromoteAdmin_ManagePriv.Click
        If LblAccType_ManagePriv.Text = "Administrator" Then
            MessageBox.Show("This user is already an administrator and can't be promote again.", "User is now an administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Are you sure you want to promote " + LblFirstName_ManagePriv.Text + " " + LblLastName_ManagePriv.Text + " to administrator. " + LblFirstName_ManagePriv.Text + " will now have access to administrator tools after this.", "Confirm promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AdminControlData.PromoteUser(LblUniqueID_ManagePriv.Text, 1)
                MessageBox.Show("User has been promoted to admin.", "Promotion success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PnlButtons_ManagePriv.Enabled = False
                LblFirstName_ManagePriv.Text = "First Name"
                LblLastName_ManagePriv.Text = "Last Name"
                LblLRN_ManagePriv.Text = "000000000000"
                LblUniqueID_ManagePriv.Text = "LOA-000000"
                LblAccType_ManagePriv.Text = "---"
                PbProfile_ManagePriv.Image = PbProfile_ManagePriv.InitialImage

                BtnFilter_ManagePriv.Text = "ALL"
                BtnFilter_ManagePriv.BackColor = Color.PaleTurquoise
                DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL

                Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
            End If
        End If
    End Sub

    Private Sub BtnPromoteMod_ManagePriv_Click(sender As Object, e As EventArgs) Handles BtnPromoteMod_ManagePriv.Click
        If LblAccType_ManagePriv.Text = "Moderator" Then
            MessageBox.Show("This user is already a moderator and can't be promote again.", "User is now a moderator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Are you sure you want to promote " + LblFirstName_ManagePriv.Text + " " + LblLastName_ManagePriv.Text + " to moderator. " + LblFirstName_ManagePriv.Text + " will now have access to moderator tools after this.", "Confirm promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AdminControlData.PromoteUser(LblUniqueID_ManagePriv.Text, 2)
                MessageBox.Show("User has been promoted to moderator.", "Promotion success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PnlButtons_ManagePriv.Enabled = False
                LblFirstName_ManagePriv.Text = "First Name"
                LblLastName_ManagePriv.Text = "Last Name"
                LblLRN_ManagePriv.Text = "000000000000"
                LblUniqueID_ManagePriv.Text = "LOA-000000"
                LblAccType_ManagePriv.Text = "---"
                PbProfile_ManagePriv.Image = PbProfile_ManagePriv.InitialImage

                BtnFilter_ManagePriv.Text = "ALL"
                BtnFilter_ManagePriv.BackColor = Color.PaleTurquoise
                DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL

                Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
            End If
        End If
    End Sub

    Private Sub BtnDemote_ManagePriv_Click(sender As Object, e As EventArgs) Handles BtnDemote_ManagePriv.Click
        If LblAccType_ManagePriv.Text = "Student/Staff" Then
            MessageBox.Show("This user is already a student or a staff and can't be demoted again.", "User is now on student/staff account", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Are you sure you want to demote " + LblFirstName_ManagePriv.Text + " " + LblLastName_ManagePriv.Text + "? " + LblFirstName_ManagePriv.Text + " will loss access to either administrator tools or moderator tools after this.", "Confirm demotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AdminControlData.PromoteUser(LblUniqueID_ManagePriv.Text, 3)
                MessageBox.Show("User has been demoted and his/her account is now on Student/Staff state", "Demotion success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PnlButtons_ManagePriv.Enabled = False
                LblFirstName_ManagePriv.Text = "First Name"
                LblLastName_ManagePriv.Text = "Last Name"
                LblLRN_ManagePriv.Text = "000000000000"
                LblUniqueID_ManagePriv.Text = "LOA-000000"
                LblAccType_ManagePriv.Text = "---"
                PbProfile_ManagePriv.Image = PbProfile_ManagePriv.InitialImage

                BtnFilter_ManagePriv.Text = "ALL"
                BtnFilter_ManagePriv.BackColor = Color.PaleTurquoise
                DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL

                Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
            End If
        End If
    End Sub

    Private Sub BtnUpdatePriv_Click(sender As Object, e As EventArgs) Handles BtnUpdatePriv.Click
        If MessageBox.Show("Do you want to change this user's privileges? (Note: Privilege access depends on the user's account type. Before editing their privileges, make sure to promote/demote the user)", "Confirm edit privileges", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Admin_Modify.Privileges_User(LblUniqueID_ManagePriv.Text, DgvManagePrivileges)
            MessageBox.Show("User " + LblFirstName_ManagePriv.Text + "'s privilege/s has been updated", "User privilege edit success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PnlButtons_ManagePriv.Enabled = False
            LblFirstName_ManagePriv.Text = "First Name"
            LblLastName_ManagePriv.Text = "Last Name"
            LblLRN_ManagePriv.Text = "000000000000"
            LblUniqueID_ManagePriv.Text = "LOA-000000"
            LblAccType_ManagePriv.Text = "---"
            PbProfile_ManagePriv.Image = PbProfile_ManagePriv.InitialImage

            BtnFilter_ManagePriv.Text = "ALL"
            BtnFilter_ManagePriv.BackColor = Color.PaleTurquoise
            DgvManagePrivileges.DataSource = AdminControlData.GetUserPrivileges_ALL

            Admin_Modify.UserPrivilegeColumns(DgvManagePrivileges)
        End If
    End Sub

    Private Sub DgvLCreditCodes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvLCreditCodes.CellFormatting
        If e.ColumnIndex = 0 Then
            If e.Value IsNot Nothing Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub BtnAddLCreditCode_Click(sender As Object, e As EventArgs) Handles BtnAddLCreditCode.Click
        Dim FullCode As String = LblCode1.Text & LblCode2.Text

        If LblCode1.Text = "AAAAA" Or LblCode2.Text = "00000" Then
            MessageBox.Show("Please generate a code.", "Code 1 and 2 is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtAmount.Text = Nothing Then
            MessageBox.Show("Please enter the amount", "Code balance is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtAmount.Text > 700 Then
            MessageBox.Show("You can't add a balance above 700 (700 max).", "Amount is too high", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAmount.Text = "700"
        Else
            Sql = "SELECT Code FROM LCreditsCode WHERE Code ='" & FullCode & "'"
            Command = New OleDbCommand(Sql, Connection)
            DataReader = Command.ExecuteReader

            If DataReader.Read = True Then
                MessageBox.Show("Seems like this code has already been added unexpectedly. Please generate again.", "Code duplication error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sql = "INSERT INTO LCreditsCode([Code],[Balance])VALUES('" & FullCode & "'," & TxtAmount.Text & ")"
                Command = New OleDbCommand(Sql, Connection)
                Command.ExecuteNonQuery()

                MessageBox.Show("Code added successfully", "Code creation success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LblCode1.Text = "AAAAA"
                LblCode2.Text = "00000"
                TxtAmount.Text = Nothing

                AdminControlData.CountLCreditCodes(LblCountCodes)
                DgvLCreditCodes.DataSource = AdminControlData.GetLCreditCodes
            End If
        End If
    End Sub

    Private Sub LnkGenerateCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkGenerateCode.LinkClicked
        LblCode1.Text = AdminControlData.GenerateCode1
        LblCode2.Text = AdminControlData.GenerateCode2
    End Sub

    Private Sub DgvLCreditCodes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLCreditCodes.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvLCreditCodes.Rows(Index)

            TxtCode_Check.Text = SelectedRow.Cells(0).Value.ToString
            LblAmount_Check.Text = SelectedRow.Cells(1).Value.ToString

            BtnDeleteCode.Enabled = True
        End If
    End Sub

    Private Sub PbShowCode_Click(sender As Object, e As EventArgs) Handles PbShowCode.Click
        If TxtCode_Check.UseSystemPasswordChar = False Then
            TxtCode_Check.UseSystemPasswordChar = True
        Else
            TxtCode_Check.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnDeleteCode_Click(sender As Object, e As EventArgs) Handles BtnDeleteCode.Click
        If MessageBox.Show("Are you sure you want to delete Code " + TxtCode_Check.Text + "?", "Confirm code deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Sql = "DELETE FROM LCreditsCode WHERE Code ='" & TxtCode_Check.Text & "'"
            Command = New OleDbCommand(Sql, Connection)
            Command.ExecuteNonQuery()

            MessageBox.Show("Code " + TxtCode_Check.Text + " has been deleted successfully", "Code deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtCode_Check.Text = Nothing
            LblAmount_Check.Text = "000"

            BtnDeleteCode.Enabled = False

            AdminControlData.CountLCreditCodes(LblCountCodes)
            DgvLCreditCodes.DataSource = AdminControlData.GetLCreditCodes
        End If
    End Sub

    Private Sub TxtLRN_Load_TextChanged(sender As Object, e As EventArgs) Handles TxtLRN_Load.TextChanged
        If TxtLRN_Load.Text.Length > 0 Then
            If Not IsNumeric(TxtLRN_Load.Text) Then
                Dim Selection As Integer = TxtLRN_Load.SelectionStart
                TxtLRN_Load.Text = TxtLRN_Load.Text.Remove(Selection - 1, 1)
                TxtLRN_Load.SelectionStart = Selection - 1
            End If
        End If
    End Sub

    Private Sub BtnSearchLRN_Click(sender As Object, e As EventArgs) Handles BtnSearchLRN.Click
        If BtnSearchLRN.Text = "Cancel" Then
            TxtLRN_Load.Text = Nothing
            LblFullName_Load.Text = "Full Name"
            LblUniqueID_Load.Text = "LOA-XXXXXX"
            TxtAmount_Load.Text = Nothing
            LblLoadAmount_Load.Text = "0"

            BtnSearchLRN.Text = "Search"
            BtnSearchLRN.BackColor = Color.PaleTurquoise

            PnlLoadInfo.Enabled = False
            PbProfilePic_Load.Image = PbProfilePic_Load.InitialImage
        Else
            If TxtLRN_Load.Text = Nothing Then
                MessageBox.Show("Please enter the user's LRN/ID number", "LRN/ID field is empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TxtLRN_Load.TextLength < 12 Then
                MessageBox.Show("LRN/ID number must consist of 12 characters", "Insufficient characters", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sql = "SELECT * FROM UserAccounts WHERE LRN =" & TxtLRN_Load.Text & ""
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                If DataReader.Read = True Then
                    MessageBox.Show("Loading for user " + DataReader("FirstName") + " " + DataReader("LastName") + ".", "LRN/ID found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PnlLoadInfo.Enabled = True

                    LblFullName_Load.Text = DataReader("FirstName") + " " + DataReader("LastName")
                    LblUniqueID_Load.Text = DataReader("UniqueID")

                    Dim UserImage As String = DataReader("UniqueID") & ".jpg"
                    Dim ImagePath As String = Application.StartupPath & "\frmUserProfilePictures\"

                    If System.IO.File.Exists(ImagePath & UserImage) Then
                        PbProfilePic_Load.Image = Image.FromFile(ImagePath & UserImage)
                    Else
                        PbProfilePic_Load.Image = PbProfilePic_Load.InitialImage
                    End If

                    BtnSearchLRN.Text = "Cancel"
                    BtnSearchLRN.BackColor = Color.IndianRed
                End If
            End If
        End If
    End Sub

    Private Sub BtnConfirmAmount_Click(sender As Object, e As EventArgs) Handles BtnConfirmAmount.Click
        If TxtAmount_Load.Text < 10 Then
            MessageBox.Show("Minimum load amount is 10 L-Credits.", "Minimum load amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            LblLoadAmount_Load.Text = TxtAmount_Load.Text
        End If
    End Sub

    Private Sub BtnSendLoad_Click(sender As Object, e As EventArgs) Handles BtnSendLoad.Click
        If LblLoadAmount_Load.Text = "0" Then
            MessageBox.Show("Please enter the load amount for user " + LblFullName_Load.Text + ".", "Load amount field empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Confirming load: For " + LblFullName_Load.Text + ", amount of " + LblLoadAmount_Load.Text + " L-Credits", "Confirm load details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AdminControlData.SendLoadToUser(LblUniqueID_Load.Text, LblLoadAmount_Load.Text)
                AdminControlData.Transaction_Import_Load(LblUniqueID_Load.Text, LblUniqueID_Load.Text, LblFullName_Load.Text, LblLoadAmount_Load.Text, frmModAdminMainMenu.LblLocalServerDate_Time.Text)
                MessageBox.Show("Load for " + LblFullName_Load.Text + " has been sent", "Load sent successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TxtLRN_Load.Text = Nothing
                LblFullName_Load.Text = "Full Name"
                LblUniqueID_Load.Text = "LOA-XXXXXX"
                TxtAmount_Load.Text = Nothing
                LblLoadAmount_Load.Text = "0"

                BtnSearchLRN.Text = "Search"
                BtnSearchLRN.BackColor = Color.PaleTurquoise

                PnlLoadInfo.Enabled = False
                PbProfilePic_Load.Image = PbProfilePic_Load.InitialImage
            End If
        End If
    End Sub

    Private Sub BtnFilter_Req_Click(sender As Object, e As EventArgs) Handles BtnFilter_Req.Click
        If BtnFilter_Req.Text = "L-Credits" Then
            DgvLoadRequest.DataSource = AdminControlData.GetUserRequest_Premium
            Admin_Modify.UserRequestColumns_PR(DgvLoadRequest)
            BtnFilter_Req.Text = "Premium"
            BtnFilter_Req.BackColor = Color.Gold
        ElseIf BtnFilter_Req.Text = "Premium" Then
            DgvLoadRequest.DataSource = AdminControlData.GetUserRequest_Load
            Admin_Modify.UserRequestColumns_LC(DgvLoadRequest)
            BtnFilter_Req.Text = "L-Credits"
            BtnFilter_Req.BackColor = Color.PaleTurquoise
        End If
    End Sub

    Private Sub DgvLoadRequest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLoadRequest.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim SelectedRow As DataGridViewRow

        If Index >= 0 Then
            SelectedRow = DgvLoadRequest.Rows(Index)

            If BtnFilter_Req.Text = "L-Credits" Then
                LblUniqueID_Req.Text = SelectedRow.Cells(0).Value.ToString
                LblRefNo_Req.Text = SelectedRow.Cells(1).Value.ToString
                LblReqState_Req.Text = "Cash-in (L-Credits)"

                Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & SelectedRow.Cells(0).Value.ToString & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                While DataReader.Read
                    LblFullName_Req.Text = DataReader("FirstName") + " " + DataReader("LastName")
                End While

                PnlButtonP_Req.Enabled = False
                PnlButtonLC_Req.Enabled = True

            ElseIf BtnFilter_Req.Text = "Premium" Then
                LblUniqueID_Req.Text = SelectedRow.Cells(0).Value.ToString
                LblRefNo_Req.Text = SelectedRow.Cells(1).Value.ToString
                LblReqState_Req.Text = "Premium Membership"

                Sql = "SELECT * FROM UserAccounts WHERE UniqueID ='" & SelectedRow.Cells(0).Value.ToString & "'"
                Command = New OleDbCommand(Sql, Connection)
                DataReader = Command.ExecuteReader

                While DataReader.Read
                    LblFullName_Req.Text = DataReader("FirstName") + " " + DataReader("LastName")
                End While

                PnlButtonP_Req.Enabled = True
                PnlButtonLC_Req.Enabled = False
            End If

        End If
    End Sub
End Class