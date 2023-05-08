Imports System.Data.OleDb
Public Class frmSeatPicker

    Public Shared AccountType_FilteredSeatin As Label
    Public Shared BookButton_Filtered As Button
    Public Shared AssignedSeat As Label

    Private GlobalSelectedSeat As Boolean = False
    Private Sub frmSeatPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CollectData.FromSeat(AccountType_FilteredSeatin.Text)
    End Sub

    Private Sub BtnConfirmSeat_Click(sender As Object, e As EventArgs) Handles BtnConfirmSeat.Click
        If LblPickedSeat.Text = "N/A" Then
            MessageBox.Show("Please choose your desired seat before confirming your seat.", "No seat has been choosen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Do you want to continue choosing the seat " + LblPickedSeat.Text + " as your preferred seat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                AssignedSeat.Text = LblPickedSeat.Text
                BookButton_Filtered.Enabled = True
                Close()
            End If
        End If
    End Sub

    Public Sub UserInput_SeatClick(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click,
        PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click,
        PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click,
        PictureBox19.Click, PictureBox20.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click, PictureBox25.Click,
        PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox30.Click, PictureBox31.Click, PictureBox32.Click,
        PictureBox33.Click, PictureBox34.Click, PictureBox35.Click, PictureBox36.Click, PictureBox37.Click, PictureBox38.Click, PictureBox39.Click,
        PictureBox40.Click, PictureBox41.Click, PictureBox42.Click, PictureBox43.Click, PictureBox44.Click, PictureBox45.Click, PictureBox46.Click,
        PictureBox47.Click, PictureBox48.Click, PictureBox49.Click, PictureBox50.Click, PictureBox51.Click, PictureBox52.Click, PictureBox53.Click,
        PictureBox54.Click, PictureBox55.Click

        Dim Pb As PictureBox = DirectCast(sender, PictureBox)



        'CountSelect = True
        Select Case Pb.Name
            Case "PictureBox1"
                Dim PicBox As PictureBox = PictureBox1
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "A1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox2"
                Dim PicBox As PictureBox = PictureBox2
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "A2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox3"
                Dim PicBox As PictureBox = PictureBox3
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "A3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox4"
                Dim PicBox As PictureBox = PictureBox4
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "A4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox5"
                Dim PicBox As PictureBox = PictureBox5
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "A5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox6"
                Dim PicBox As PictureBox = PictureBox6
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "B5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox7"
                Dim PicBox As PictureBox = PictureBox7
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "B4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox8"
                Dim PicBox As PictureBox = PictureBox8
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "B3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox9"
                Dim PicBox As PictureBox = PictureBox9
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "B2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox10"
                Dim PicBox As PictureBox = PictureBox10
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "B1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox11"
                Dim PicBox As PictureBox = PictureBox11
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "C5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox12"
                Dim PicBox As PictureBox = PictureBox12
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "C4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox13"
                Dim PicBox As PictureBox = PictureBox13
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "C3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox14"
                Dim PicBox As PictureBox = PictureBox14
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "C2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox15"
                Dim PicBox As PictureBox = PictureBox15
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "C1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox16"
                Dim PicBox As PictureBox = PictureBox16
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "D5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox17"
                Dim PicBox As PictureBox = PictureBox17
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "D4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox18"
                Dim PicBox As PictureBox = PictureBox18
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "D3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox19"
                Dim PicBox As PictureBox = PictureBox19
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "D2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox20"
                Dim PicBox As PictureBox = PictureBox20
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "D1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox21"
                Dim PicBox As PictureBox = PictureBox21
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "E5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox22"
                Dim PicBox As PictureBox = PictureBox22
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "E4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox23"
                Dim PicBox As PictureBox = PictureBox23
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "E3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox24"
                Dim PicBox As PictureBox = PictureBox24
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "E2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox25"
                Dim PicBox As PictureBox = PictureBox25
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "E1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox26"
                Dim PicBox As PictureBox = PictureBox26
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "F5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox27"
                Dim PicBox As PictureBox = PictureBox27
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "F4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox28"
                Dim PicBox As PictureBox = PictureBox28
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "F3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox29"
                Dim PicBox As PictureBox = PictureBox29
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "F2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox30"
                Dim PicBox As PictureBox = PictureBox30
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "F1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox31"
                Dim PicBox As PictureBox = PictureBox31
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "G5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox32"
                Dim PicBox As PictureBox = PictureBox32
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "G4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox33"
                Dim PicBox As PictureBox = PictureBox33
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "G3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox34"
                Dim PicBox As PictureBox = PictureBox34
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "G2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox35"
                Dim PicBox As PictureBox = PictureBox35
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "G1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox36"
                Dim PicBox As PictureBox = PictureBox36
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "H5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox37"
                Dim PicBox As PictureBox = PictureBox37
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "H4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox38"
                Dim PicBox As PictureBox = PictureBox38
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "H3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox39"
                Dim PicBox As PictureBox = PictureBox39
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "H2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox40"
                Dim PicBox As PictureBox = PictureBox40
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "H1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox41"
                Dim PicBox As PictureBox = PictureBox41
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "I5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox42"
                Dim PicBox As PictureBox = PictureBox42
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "I4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox43"
                Dim PicBox As PictureBox = PictureBox43
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "I3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox44"
                Dim PicBox As PictureBox = PictureBox44
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "I2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox45"
                Dim PicBox As PictureBox = PictureBox45
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "I1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox46"
                Dim PicBox As PictureBox = PictureBox46
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "J5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox47"
                Dim PicBox As PictureBox = PictureBox47
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "J4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox48"
                Dim PicBox As PictureBox = PictureBox48
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "J3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox49"
                Dim PicBox As PictureBox = PictureBox49
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "J2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox50"
                Dim PicBox As PictureBox = PictureBox50
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "J1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox51"
                Dim PicBox As PictureBox = PictureBox51
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "K5"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox52"
                Dim PicBox As PictureBox = PictureBox52
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "K4"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox53"
                Dim PicBox As PictureBox = PictureBox53
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "K3"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox54"
                Dim PicBox As PictureBox = PictureBox54
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "K2"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
            Case "PictureBox55"
                Dim PicBox As PictureBox = PictureBox55
                If PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = True Then
                    LblNotificationBarSeat.Text = "You can only choose one seat per user."
                ElseIf PicBox.Tag.ToString = "NOT_OCCUPIED" And GlobalSelectedSeat = False Then
                    GlobalSelectedSeat = True
                    PicBox.Tag = "CLICKED"
                    LblPickedSeat.Text = "K1"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_UserInput)
                ElseIf PicBox.Tag.ToString = "CLICKED" And GlobalSelectedSeat = True Then
                    GlobalSelectedSeat = False
                    PicBox.Tag = "NOT_OCCUPIED"
                    LblPickedSeat.Text = "N/A"
                    PicBox.Image = Image.FromFile(CheckBusData.Seat_NotOccupied)
                End If
        End Select

    End Sub
End Class