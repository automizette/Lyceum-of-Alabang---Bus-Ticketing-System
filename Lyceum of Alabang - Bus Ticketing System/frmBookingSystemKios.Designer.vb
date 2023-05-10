<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingSystemKios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingSystemKios))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConfirmEmail = New System.Windows.Forms.Button()
        Me.PnlBookingCenter = New System.Windows.Forms.Panel()
        Me.BtnResetDetails = New System.Windows.Forms.Button()
        Me.BtnBookNow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblDateOfDepart = New System.Windows.Forms.Label()
        Me.LblTimeOfDepart = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LblAvailableSeats = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LblPointB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblPointA = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblPlateNumber = New System.Windows.Forms.Label()
        Me.LblBusName = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BtnSeatPicker = New System.Windows.Forms.Button()
        Me.LblLRN_Booking = New System.Windows.Forms.Label()
        Me.LblAssignedSeat = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LblUniqueID_Booking = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblFullName_Booking = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DgvBusList_Admin = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblLocalServerDate_Time = New System.Windows.Forms.Label()
        Me.PbExitKiosk = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBookingCenter.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBusList_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbExitKiosk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(87, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 37)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Book Now!"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Raleway ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(375, 44)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(475, 32)
        Me.TxtEmail.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter your email"
        '
        'BtnConfirmEmail
        '
        Me.BtnConfirmEmail.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnConfirmEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmEmail.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmEmail.Location = New System.Drawing.Point(740, 82)
        Me.BtnConfirmEmail.Name = "BtnConfirmEmail"
        Me.BtnConfirmEmail.Size = New System.Drawing.Size(110, 37)
        Me.BtnConfirmEmail.TabIndex = 24
        Me.BtnConfirmEmail.Text = "Confirm"
        Me.BtnConfirmEmail.UseVisualStyleBackColor = False
        '
        'PnlBookingCenter
        '
        Me.PnlBookingCenter.BackColor = System.Drawing.Color.Transparent
        Me.PnlBookingCenter.Controls.Add(Me.BtnResetDetails)
        Me.PnlBookingCenter.Controls.Add(Me.BtnBookNow)
        Me.PnlBookingCenter.Controls.Add(Me.GroupBox2)
        Me.PnlBookingCenter.Controls.Add(Me.BtnSeatPicker)
        Me.PnlBookingCenter.Controls.Add(Me.LblLRN_Booking)
        Me.PnlBookingCenter.Controls.Add(Me.LblAssignedSeat)
        Me.PnlBookingCenter.Controls.Add(Me.Label18)
        Me.PnlBookingCenter.Controls.Add(Me.Label25)
        Me.PnlBookingCenter.Controls.Add(Me.LblUniqueID_Booking)
        Me.PnlBookingCenter.Controls.Add(Me.Label16)
        Me.PnlBookingCenter.Controls.Add(Me.LblFullName_Booking)
        Me.PnlBookingCenter.Controls.Add(Me.Label14)
        Me.PnlBookingCenter.Controls.Add(Me.Label12)
        Me.PnlBookingCenter.Controls.Add(Me.DgvBusList_Admin)
        Me.PnlBookingCenter.Enabled = False
        Me.PnlBookingCenter.Location = New System.Drawing.Point(15, 137)
        Me.PnlBookingCenter.Name = "PnlBookingCenter"
        Me.PnlBookingCenter.Size = New System.Drawing.Size(839, 397)
        Me.PnlBookingCenter.TabIndex = 25
        '
        'BtnResetDetails
        '
        Me.BtnResetDetails.BackColor = System.Drawing.Color.Crimson
        Me.BtnResetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetDetails.Font = New System.Drawing.Font("Raleway ExtraBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetDetails.Location = New System.Drawing.Point(739, 11)
        Me.BtnResetDetails.Name = "BtnResetDetails"
        Me.BtnResetDetails.Size = New System.Drawing.Size(93, 23)
        Me.BtnResetDetails.TabIndex = 22
        Me.BtnResetDetails.Text = "Reset"
        Me.BtnResetDetails.UseVisualStyleBackColor = False
        '
        'BtnBookNow
        '
        Me.BtnBookNow.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnBookNow.Enabled = False
        Me.BtnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBookNow.Font = New System.Drawing.Font("Raleway", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookNow.Location = New System.Drawing.Point(625, 231)
        Me.BtnBookNow.Name = "BtnBookNow"
        Me.BtnBookNow.Size = New System.Drawing.Size(205, 37)
        Me.BtnBookNow.TabIndex = 21
        Me.BtnBookNow.Text = "Book"
        Me.BtnBookNow.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LblDateOfDepart)
        Me.GroupBox2.Controls.Add(Me.LblTimeOfDepart)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.LblPrice)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.LblAvailableSeats)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.LblPointB)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.LblPointA)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.LblPlateNumber)
        Me.GroupBox2.Controls.Add(Me.LblBusName)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 115)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'LblDateOfDepart
        '
        Me.LblDateOfDepart.AutoSize = True
        Me.LblDateOfDepart.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateOfDepart.Location = New System.Drawing.Point(479, 69)
        Me.LblDateOfDepart.Name = "LblDateOfDepart"
        Me.LblDateOfDepart.Size = New System.Drawing.Size(70, 19)
        Me.LblDateOfDepart.TabIndex = 15
        Me.LblDateOfDepart.Text = "MM/DD"
        '
        'LblTimeOfDepart
        '
        Me.LblTimeOfDepart.AutoSize = True
        Me.LblTimeOfDepart.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeOfDepart.Location = New System.Drawing.Point(479, 48)
        Me.LblTimeOfDepart.Name = "LblTimeOfDepart"
        Me.LblTimeOfDepart.Size = New System.Drawing.Size(123, 19)
        Me.LblTimeOfDepart.TabIndex = 14
        Me.LblTimeOfDepart.Text = "00:00(AM/PM)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(478, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(132, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Date/Time of Departure"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.BackColor = System.Drawing.Color.Transparent
        Me.LblPrice.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.White
        Me.LblPrice.Location = New System.Drawing.Point(739, 33)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(19, 19)
        Me.LblPrice.TabIndex = 12
        Me.LblPrice.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(716, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(675, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Price:"
        '
        'LblAvailableSeats
        '
        Me.LblAvailableSeats.AutoSize = True
        Me.LblAvailableSeats.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvailableSeats.Location = New System.Drawing.Point(344, 45)
        Me.LblAvailableSeats.Name = "LblAvailableSeats"
        Me.LblAvailableSeats.Size = New System.Drawing.Size(29, 19)
        Me.LblAvailableSeats.TabIndex = 8
        Me.LblAvailableSeats.Text = "00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(345, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Available Seats:"
        '
        'LblPointB
        '
        Me.LblPointB.AutoSize = True
        Me.LblPointB.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPointB.Location = New System.Drawing.Point(133, 89)
        Me.LblPointB.Name = "LblPointB"
        Me.LblPointB.Size = New System.Drawing.Size(141, 19)
        Me.LblPointB.TabIndex = 6
        Me.LblPointB.Text = "Destination Point"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(137, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'LblPointA
        '
        Me.LblPointA.AutoSize = True
        Me.LblPointA.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPointA.Location = New System.Drawing.Point(133, 46)
        Me.LblPointA.Name = "LblPointA"
        Me.LblPointA.Size = New System.Drawing.Size(76, 19)
        Me.LblPointA.TabIndex = 4
        Me.LblPointA.Text = "Location"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(134, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Destination:"
        '
        'LblPlateNumber
        '
        Me.LblPlateNumber.AutoSize = True
        Me.LblPlateNumber.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlateNumber.Location = New System.Drawing.Point(16, 67)
        Me.LblPlateNumber.Name = "LblPlateNumber"
        Me.LblPlateNumber.Size = New System.Drawing.Size(85, 14)
        Me.LblPlateNumber.TabIndex = 2
        Me.LblPlateNumber.Text = "Plate Number"
        '
        'LblBusName
        '
        Me.LblBusName.AutoSize = True
        Me.LblBusName.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBusName.Location = New System.Drawing.Point(15, 47)
        Me.LblBusName.Name = "LblBusName"
        Me.LblBusName.Size = New System.Drawing.Size(88, 19)
        Me.LblBusName.TabIndex = 1
        Me.LblBusName.Tag = "BusInputFalse"
        Me.LblBusName.Text = "Bus Name"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Bus Name:"
        '
        'BtnSeatPicker
        '
        Me.BtnSeatPicker.BackColor = System.Drawing.Color.PowderBlue
        Me.BtnSeatPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeatPicker.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeatPicker.Location = New System.Drawing.Point(625, 200)
        Me.BtnSeatPicker.Name = "BtnSeatPicker"
        Me.BtnSeatPicker.Size = New System.Drawing.Size(205, 25)
        Me.BtnSeatPicker.TabIndex = 20
        Me.BtnSeatPicker.Text = "Choose Seat..."
        Me.BtnSeatPicker.UseVisualStyleBackColor = False
        '
        'LblLRN_Booking
        '
        Me.LblLRN_Booking.AutoSize = True
        Me.LblLRN_Booking.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLRN_Booking.ForeColor = System.Drawing.Color.White
        Me.LblLRN_Booking.Location = New System.Drawing.Point(586, 12)
        Me.LblLRN_Booking.Name = "LblLRN_Booking"
        Me.LblLRN_Booking.Size = New System.Drawing.Size(103, 15)
        Me.LblLRN_Booking.TabIndex = 19
        Me.LblLRN_Booking.Text = "000000000000"
        '
        'LblAssignedSeat
        '
        Me.LblAssignedSeat.AutoSize = True
        Me.LblAssignedSeat.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssignedSeat.ForeColor = System.Drawing.Color.White
        Me.LblAssignedSeat.Location = New System.Drawing.Point(681, 123)
        Me.LblAssignedSeat.Name = "LblAssignedSeat"
        Me.LblAssignedSeat.Size = New System.Drawing.Size(85, 37)
        Me.LblAssignedSeat.TabIndex = 19
        Me.LblAssignedSeat.Text = "N/A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(528, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 15)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "LRN/ID:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(656, 104)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(141, 19)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Passenger's Seat"
        '
        'LblUniqueID_Booking
        '
        Me.LblUniqueID_Booking.AutoSize = True
        Me.LblUniqueID_Booking.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUniqueID_Booking.ForeColor = System.Drawing.Color.White
        Me.LblUniqueID_Booking.Location = New System.Drawing.Point(233, 13)
        Me.LblUniqueID_Booking.Name = "LblUniqueID_Booking"
        Me.LblUniqueID_Booking.Size = New System.Drawing.Size(86, 15)
        Me.LblUniqueID_Booking.TabIndex = 17
        Me.LblUniqueID_Booking.Text = "LOA-000000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(91, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Passenger's UniqueID:"
        '
        'LblFullName_Booking
        '
        Me.LblFullName_Booking.AutoSize = True
        Me.LblFullName_Booking.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName_Booking.ForeColor = System.Drawing.Color.White
        Me.LblFullName_Booking.Location = New System.Drawing.Point(402, 13)
        Me.LblFullName_Booking.Name = "LblFullName_Booking"
        Me.LblFullName_Booking.Size = New System.Drawing.Size(70, 15)
        Me.LblFullName_Booking.TabIndex = 15
        Me.LblFullName_Booking.Text = "Full Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(328, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Full Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(5, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 18)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Bus Route:"
        '
        'DgvBusList_Admin
        '
        Me.DgvBusList_Admin.AllowUserToAddRows = False
        Me.DgvBusList_Admin.AllowUserToDeleteRows = False
        Me.DgvBusList_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBusList_Admin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvBusList_Admin.BackgroundColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvBusList_Admin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvBusList_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBusList_Admin.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvBusList_Admin.Location = New System.Drawing.Point(8, 31)
        Me.DgvBusList_Admin.MultiSelect = False
        Me.DgvBusList_Admin.Name = "DgvBusList_Admin"
        Me.DgvBusList_Admin.ReadOnly = True
        Me.DgvBusList_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvBusList_Admin.Size = New System.Drawing.Size(614, 240)
        Me.DgvBusList_Admin.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblLocalServerDate_Time
        '
        Me.LblLocalServerDate_Time.AutoSize = True
        Me.LblLocalServerDate_Time.BackColor = System.Drawing.Color.Transparent
        Me.LblLocalServerDate_Time.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocalServerDate_Time.ForeColor = System.Drawing.Color.White
        Me.LblLocalServerDate_Time.Location = New System.Drawing.Point(94, 100)
        Me.LblLocalServerDate_Time.Name = "LblLocalServerDate_Time"
        Me.LblLocalServerDate_Time.Size = New System.Drawing.Size(15, 15)
        Me.LblLocalServerDate_Time.TabIndex = 26
        Me.LblLocalServerDate_Time.Text = "0"
        '
        'PbExitKiosk
        '
        Me.PbExitKiosk.BackColor = System.Drawing.Color.Transparent
        Me.PbExitKiosk.Enabled = False
        Me.PbExitKiosk.Image = CType(resources.GetObject("PbExitKiosk.Image"), System.Drawing.Image)
        Me.PbExitKiosk.InitialImage = Nothing
        Me.PbExitKiosk.Location = New System.Drawing.Point(7, 5)
        Me.PbExitKiosk.Name = "PbExitKiosk"
        Me.PbExitKiosk.Size = New System.Drawing.Size(19, 18)
        Me.PbExitKiosk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbExitKiosk.TabIndex = 29
        Me.PbExitKiosk.TabStop = False
        '
        'frmBookingSystemKios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(862, 545)
        Me.Controls.Add(Me.PbExitKiosk)
        Me.Controls.Add(Me.LblLocalServerDate_Time)
        Me.Controls.Add(Me.PnlBookingCenter)
        Me.Controls.Add(Me.BtnConfirmEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBookingSystemKios"
        Me.Text = "BTS - Kiosk Mode (Booking System)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBookingCenter.ResumeLayout(False)
        Me.PnlBookingCenter.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBusList_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbExitKiosk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConfirmEmail As Button
    Friend WithEvents PnlBookingCenter As Panel
    Friend WithEvents BtnResetDetails As Button
    Friend WithEvents BtnBookNow As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblDateOfDepart As Label
    Friend WithEvents LblTimeOfDepart As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents LblAvailableSeats As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LblPointB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblPointA As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LblPlateNumber As Label
    Friend WithEvents LblBusName As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents BtnSeatPicker As Button
    Friend WithEvents LblLRN_Booking As Label
    Friend WithEvents LblAssignedSeat As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents LblUniqueID_Booking As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblFullName_Booking As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DgvBusList_Admin As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblLocalServerDate_Time As Label
    Friend WithEvents PbExitKiosk As PictureBox
End Class
