<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserArrivalSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserArrivalSystem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbArriveKiosk = New System.Windows.Forms.TabControl()
        Me.TbSetup = New System.Windows.Forms.TabPage()
        Me.BtnSetupFinish = New System.Windows.Forms.Button()
        Me.LblPlateNumber = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblDestination = New System.Windows.Forms.Label()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.CmbBusList = New System.Windows.Forms.ComboBox()
        Me.TbArrivalSystem = New System.Windows.Forms.TabPage()
        Me.PbExitKiosk = New System.Windows.Forms.PictureBox()
        Me.LblBusName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblDestination_Sys = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LblLocation_Sys = New System.Windows.Forms.Label()
        Me.BtnArriveUser = New System.Windows.Forms.Button()
        Me.TxtUserFullName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbArriveKiosk.SuspendLayout()
        Me.TbSetup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbArrivalSystem.SuspendLayout()
        CType(Me.PbExitKiosk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(306, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Setting up Kiosk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(302, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "What bus is this?"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = CType(resources.GetObject("PictureBox5.InitialImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(236, 34)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 65)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(308, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "for User Arrival"
        '
        'TbArriveKiosk
        '
        Me.TbArriveKiosk.Controls.Add(Me.TbSetup)
        Me.TbArriveKiosk.Controls.Add(Me.TbArrivalSystem)
        Me.TbArriveKiosk.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbArriveKiosk.Location = New System.Drawing.Point(-6, -3)
        Me.TbArriveKiosk.Name = "TbArriveKiosk"
        Me.TbArriveKiosk.SelectedIndex = 0
        Me.TbArriveKiosk.Size = New System.Drawing.Size(858, 486)
        Me.TbArriveKiosk.TabIndex = 16
        '
        'TbSetup
        '
        Me.TbSetup.BackColor = System.Drawing.Color.White
        Me.TbSetup.BackgroundImage = CType(resources.GetObject("TbSetup.BackgroundImage"), System.Drawing.Image)
        Me.TbSetup.Controls.Add(Me.BtnSetupFinish)
        Me.TbSetup.Controls.Add(Me.LblPlateNumber)
        Me.TbSetup.Controls.Add(Me.PictureBox1)
        Me.TbSetup.Controls.Add(Me.LblDestination)
        Me.TbSetup.Controls.Add(Me.LblLocation)
        Me.TbSetup.Controls.Add(Me.CmbBusList)
        Me.TbSetup.Controls.Add(Me.PictureBox5)
        Me.TbSetup.Controls.Add(Me.Label3)
        Me.TbSetup.Controls.Add(Me.Label1)
        Me.TbSetup.Controls.Add(Me.Label2)
        Me.TbSetup.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSetup.Location = New System.Drawing.Point(4, 22)
        Me.TbSetup.Name = "TbSetup"
        Me.TbSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.TbSetup.Size = New System.Drawing.Size(850, 460)
        Me.TbSetup.TabIndex = 0
        Me.TbSetup.Text = "KioskSetup"
        '
        'BtnSetupFinish
        '
        Me.BtnSetupFinish.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnSetupFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSetupFinish.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetupFinish.ForeColor = System.Drawing.Color.White
        Me.BtnSetupFinish.Location = New System.Drawing.Point(313, 396)
        Me.BtnSetupFinish.Name = "BtnSetupFinish"
        Me.BtnSetupFinish.Size = New System.Drawing.Size(172, 50)
        Me.BtnSetupFinish.TabIndex = 21
        Me.BtnSetupFinish.Text = "Confirm Setup"
        Me.BtnSetupFinish.UseVisualStyleBackColor = False
        Me.BtnSetupFinish.Visible = False
        '
        'LblPlateNumber
        '
        Me.LblPlateNumber.AutoSize = True
        Me.LblPlateNumber.BackColor = System.Drawing.Color.Transparent
        Me.LblPlateNumber.Font = New System.Drawing.Font("Raleway SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlateNumber.ForeColor = System.Drawing.Color.White
        Me.LblPlateNumber.Location = New System.Drawing.Point(357, 270)
        Me.LblPlateNumber.Name = "LblPlateNumber"
        Me.LblPlateNumber.Size = New System.Drawing.Size(90, 18)
        Me.LblPlateNumber.TabIndex = 20
        Me.LblPlateNumber.Text = "Plate Num.:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(372, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'LblDestination
        '
        Me.LblDestination.BackColor = System.Drawing.Color.Transparent
        Me.LblDestination.Font = New System.Drawing.Font("Raleway Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestination.ForeColor = System.Drawing.Color.White
        Me.LblDestination.Location = New System.Drawing.Point(445, 324)
        Me.LblDestination.Name = "LblDestination"
        Me.LblDestination.Size = New System.Drawing.Size(320, 29)
        Me.LblDestination.TabIndex = 18
        Me.LblDestination.Text = "Destination"
        '
        'LblLocation
        '
        Me.LblLocation.BackColor = System.Drawing.Color.Transparent
        Me.LblLocation.Font = New System.Drawing.Font("Raleway Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocation.ForeColor = System.Drawing.Color.White
        Me.LblLocation.Location = New System.Drawing.Point(39, 324)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(320, 29)
        Me.LblLocation.TabIndex = 17
        Me.LblLocation.Text = "Location"
        Me.LblLocation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CmbBusList
        '
        Me.CmbBusList.Font = New System.Drawing.Font("Raleway Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBusList.FormattingEnabled = True
        Me.CmbBusList.Location = New System.Drawing.Point(262, 227)
        Me.CmbBusList.Name = "CmbBusList"
        Me.CmbBusList.Size = New System.Drawing.Size(278, 37)
        Me.CmbBusList.TabIndex = 16
        '
        'TbArrivalSystem
        '
        Me.TbArrivalSystem.BackgroundImage = CType(resources.GetObject("TbArrivalSystem.BackgroundImage"), System.Drawing.Image)
        Me.TbArrivalSystem.Controls.Add(Me.PbExitKiosk)
        Me.TbArrivalSystem.Controls.Add(Me.LblBusName)
        Me.TbArrivalSystem.Controls.Add(Me.Label8)
        Me.TbArrivalSystem.Controls.Add(Me.LblDestination_Sys)
        Me.TbArrivalSystem.Controls.Add(Me.PictureBox3)
        Me.TbArrivalSystem.Controls.Add(Me.LblLocation_Sys)
        Me.TbArrivalSystem.Controls.Add(Me.BtnArriveUser)
        Me.TbArrivalSystem.Controls.Add(Me.TxtUserFullName)
        Me.TbArrivalSystem.Controls.Add(Me.Label5)
        Me.TbArrivalSystem.Controls.Add(Me.PictureBox2)
        Me.TbArrivalSystem.Controls.Add(Me.Label4)
        Me.TbArrivalSystem.Location = New System.Drawing.Point(4, 22)
        Me.TbArrivalSystem.Name = "TbArrivalSystem"
        Me.TbArrivalSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.TbArrivalSystem.Size = New System.Drawing.Size(850, 460)
        Me.TbArrivalSystem.TabIndex = 1
        Me.TbArrivalSystem.Text = "ArrivalSystem"
        Me.TbArrivalSystem.UseVisualStyleBackColor = True
        '
        'PbExitKiosk
        '
        Me.PbExitKiosk.BackColor = System.Drawing.Color.Transparent
        Me.PbExitKiosk.Enabled = False
        Me.PbExitKiosk.Image = CType(resources.GetObject("PbExitKiosk.Image"), System.Drawing.Image)
        Me.PbExitKiosk.InitialImage = Nothing
        Me.PbExitKiosk.Location = New System.Drawing.Point(809, 5)
        Me.PbExitKiosk.Name = "PbExitKiosk"
        Me.PbExitKiosk.Size = New System.Drawing.Size(29, 28)
        Me.PbExitKiosk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbExitKiosk.TabIndex = 28
        Me.PbExitKiosk.TabStop = False
        '
        'LblBusName
        '
        Me.LblBusName.AutoSize = True
        Me.LblBusName.BackColor = System.Drawing.Color.Transparent
        Me.LblBusName.Font = New System.Drawing.Font("Raleway Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBusName.ForeColor = System.Drawing.Color.White
        Me.LblBusName.Location = New System.Drawing.Point(402, 429)
        Me.LblBusName.Name = "LblBusName"
        Me.LblBusName.Size = New System.Drawing.Size(104, 22)
        Me.LblBusName.TabIndex = 27
        Me.LblBusName.Text = "Bus Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Raleway ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(268, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "You are on bus:"
        '
        'LblDestination_Sys
        '
        Me.LblDestination_Sys.BackColor = System.Drawing.Color.Transparent
        Me.LblDestination_Sys.Font = New System.Drawing.Font("Raleway ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestination_Sys.ForeColor = System.Drawing.Color.White
        Me.LblDestination_Sys.Location = New System.Drawing.Point(336, 92)
        Me.LblDestination_Sys.Name = "LblDestination_Sys"
        Me.LblDestination_Sys.Size = New System.Drawing.Size(191, 22)
        Me.LblDestination_Sys.TabIndex = 25
        Me.LblDestination_Sys.Text = "Destination"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(286, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'LblLocation_Sys
        '
        Me.LblLocation_Sys.BackColor = System.Drawing.Color.Transparent
        Me.LblLocation_Sys.Font = New System.Drawing.Font("Raleway ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocation_Sys.ForeColor = System.Drawing.Color.White
        Me.LblLocation_Sys.Location = New System.Drawing.Point(145, 92)
        Me.LblLocation_Sys.Name = "LblLocation_Sys"
        Me.LblLocation_Sys.Size = New System.Drawing.Size(135, 22)
        Me.LblLocation_Sys.TabIndex = 23
        Me.LblLocation_Sys.Text = "Location"
        Me.LblLocation_Sys.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnArriveUser
        '
        Me.BtnArriveUser.BackColor = System.Drawing.Color.Lavender
        Me.BtnArriveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnArriveUser.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArriveUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BtnArriveUser.Location = New System.Drawing.Point(319, 311)
        Me.BtnArriveUser.Name = "BtnArriveUser"
        Me.BtnArriveUser.Size = New System.Drawing.Size(172, 50)
        Me.BtnArriveUser.TabIndex = 22
        Me.BtnArriveUser.Text = "I have arrived!"
        Me.BtnArriveUser.UseVisualStyleBackColor = False
        '
        'TxtUserFullName
        '
        Me.TxtUserFullName.Font = New System.Drawing.Font("Raleway Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserFullName.Location = New System.Drawing.Point(100, 253)
        Me.TxtUserFullName.Name = "TxtUserFullName"
        Me.TxtUserFullName.Size = New System.Drawing.Size(643, 39)
        Me.TxtUserFullName.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Raleway ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(196, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(425, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Enter your full name and confirm your arrival!"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(170, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Welcome aboard!"
        '
        'frmUserArrivalSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(847, 479)
        Me.Controls.Add(Me.TbArriveKiosk)
        Me.Name = "frmUserArrivalSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BTS - Kiosk Mode (User Arrival System)"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbArriveKiosk.ResumeLayout(False)
        Me.TbSetup.ResumeLayout(False)
        Me.TbSetup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbArrivalSystem.ResumeLayout(False)
        Me.TbArrivalSystem.PerformLayout()
        CType(Me.PbExitKiosk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbArriveKiosk As TabControl
    Friend WithEvents TbSetup As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblDestination As Label
    Friend WithEvents LblLocation As Label
    Friend WithEvents CmbBusList As ComboBox
    Friend WithEvents TbArrivalSystem As TabPage
    Friend WithEvents LblPlateNumber As Label
    Friend WithEvents BtnSetupFinish As Button
    Friend WithEvents LblDestination_Sys As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblLocation_Sys As Label
    Friend WithEvents BtnArriveUser As Button
    Friend WithEvents TxtUserFullName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblBusName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PbExitKiosk As PictureBox
End Class
