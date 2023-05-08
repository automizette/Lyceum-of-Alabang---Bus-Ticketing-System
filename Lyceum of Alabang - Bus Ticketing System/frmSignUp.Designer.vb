<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        Me.LblLRN = New System.Windows.Forms.Label()
        Me.TxtLrnId = New System.Windows.Forms.TextBox()
        Me.BtnValidateLrn = New System.Windows.Forms.Button()
        Me.GrpInputFields = New System.Windows.Forms.GroupBox()
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblUniqueID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCreateAccount = New System.Windows.Forms.Button()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.LblConfirmPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblBirthdate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LnkBacktoLogin = New System.Windows.Forms.LinkLabel()
        Me.GrpInputFields.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLRN
        '
        Me.LblLRN.AutoSize = True
        Me.LblLRN.BackColor = System.Drawing.Color.Transparent
        Me.LblLRN.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLRN.Location = New System.Drawing.Point(206, 117)
        Me.LblLRN.Name = "LblLRN"
        Me.LblLRN.Size = New System.Drawing.Size(93, 18)
        Me.LblLRN.TabIndex = 1
        Me.LblLRN.Text = "LRN/ID No."
        '
        'TxtLrnId
        '
        Me.TxtLrnId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLrnId.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLrnId.Location = New System.Drawing.Point(305, 112)
        Me.TxtLrnId.MaxLength = 12
        Me.TxtLrnId.Name = "TxtLrnId"
        Me.TxtLrnId.Size = New System.Drawing.Size(228, 23)
        Me.TxtLrnId.TabIndex = 2
        '
        'BtnValidateLrn
        '
        Me.BtnValidateLrn.BackColor = System.Drawing.Color.Aqua
        Me.BtnValidateLrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValidateLrn.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidateLrn.Location = New System.Drawing.Point(539, 112)
        Me.BtnValidateLrn.Name = "BtnValidateLrn"
        Me.BtnValidateLrn.Size = New System.Drawing.Size(75, 23)
        Me.BtnValidateLrn.TabIndex = 3
        Me.BtnValidateLrn.Text = "Validate"
        Me.BtnValidateLrn.UseVisualStyleBackColor = False
        '
        'GrpInputFields
        '
        Me.GrpInputFields.BackColor = System.Drawing.Color.Transparent
        Me.GrpInputFields.Controls.Add(Me.TxtEmailAddress)
        Me.GrpInputFields.Controls.Add(Me.Label4)
        Me.GrpInputFields.Controls.Add(Me.LblUniqueID)
        Me.GrpInputFields.Controls.Add(Me.Label1)
        Me.GrpInputFields.Controls.Add(Me.BtnCreateAccount)
        Me.GrpInputFields.Controls.Add(Me.TxtConfirmPassword)
        Me.GrpInputFields.Controls.Add(Me.LblConfirmPassword)
        Me.GrpInputFields.Controls.Add(Me.TxtPassword)
        Me.GrpInputFields.Controls.Add(Me.LblPassword)
        Me.GrpInputFields.Controls.Add(Me.LblUserType)
        Me.GrpInputFields.Controls.Add(Me.Label5)
        Me.GrpInputFields.Controls.Add(Me.LblBirthdate)
        Me.GrpInputFields.Controls.Add(Me.Label3)
        Me.GrpInputFields.Controls.Add(Me.LblLastName)
        Me.GrpInputFields.Controls.Add(Me.LblFirstName)
        Me.GrpInputFields.Controls.Add(Me.Label2)
        Me.GrpInputFields.Controls.Add(Me.TxtUsername)
        Me.GrpInputFields.Controls.Add(Me.LblUsername)
        Me.GrpInputFields.Enabled = False
        Me.GrpInputFields.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInputFields.Location = New System.Drawing.Point(38, 153)
        Me.GrpInputFields.Name = "GrpInputFields"
        Me.GrpInputFields.Size = New System.Drawing.Size(753, 237)
        Me.GrpInputFields.TabIndex = 4
        Me.GrpInputFields.TabStop = False
        Me.GrpInputFields.Text = "Personal Information"
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailAddress.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailAddress.Location = New System.Drawing.Point(19, 117)
        Me.TxtEmailAddress.MaxLength = 100
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(228, 23)
        Me.TxtEmailAddress.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Email:"
        '
        'LblUniqueID
        '
        Me.LblUniqueID.AutoSize = True
        Me.LblUniqueID.BackColor = System.Drawing.Color.Transparent
        Me.LblUniqueID.Font = New System.Drawing.Font("Raleway Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUniqueID.Location = New System.Drawing.Point(310, 113)
        Me.LblUniqueID.Name = "LblUniqueID"
        Me.LblUniqueID.Size = New System.Drawing.Size(104, 18)
        Me.LblUniqueID.TabIndex = 18
        Me.LblUniqueID.Text = "LOA-XXXXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "UniqueID:"
        '
        'BtnCreateAccount
        '
        Me.BtnCreateAccount.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateAccount.Location = New System.Drawing.Point(501, 161)
        Me.BtnCreateAccount.Name = "BtnCreateAccount"
        Me.BtnCreateAccount.Size = New System.Drawing.Size(228, 36)
        Me.BtnCreateAccount.TabIndex = 5
        Me.BtnCreateAccount.Text = "Create Account"
        Me.BtnCreateAccount.UseVisualStyleBackColor = False
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(501, 117)
        Me.TxtConfirmPassword.MaxLength = 20
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(228, 23)
        Me.TxtConfirmPassword.TabIndex = 16
        Me.TxtConfirmPassword.UseSystemPasswordChar = True
        '
        'LblConfirmPassword
        '
        Me.LblConfirmPassword.AutoSize = True
        Me.LblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblConfirmPassword.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmPassword.Location = New System.Drawing.Point(498, 96)
        Me.LblConfirmPassword.Name = "LblConfirmPassword"
        Me.LblConfirmPassword.Size = New System.Drawing.Size(143, 18)
        Me.LblConfirmPassword.TabIndex = 15
        Me.LblConfirmPassword.Text = "Confirm Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(501, 51)
        Me.TxtPassword.MaxLength = 20
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(228, 23)
        Me.TxtPassword.TabIndex = 14
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(498, 30)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(82, 18)
        Me.LblPassword.TabIndex = 13
        Me.LblPassword.Text = "Password:"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.BackColor = System.Drawing.Color.Transparent
        Me.LblUserType.Font = New System.Drawing.Font("Raleway Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserType.Location = New System.Drawing.Point(311, 201)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(40, 18)
        Me.LblUserType.TabIndex = 12
        Me.LblUserType.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "User Type:"
        '
        'LblBirthdate
        '
        Me.LblBirthdate.AutoSize = True
        Me.LblBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.LblBirthdate.Font = New System.Drawing.Font("Raleway Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthdate.Location = New System.Drawing.Point(310, 56)
        Me.LblBirthdate.Name = "LblBirthdate"
        Me.LblBirthdate.Size = New System.Drawing.Size(120, 18)
        Me.LblBirthdate.TabIndex = 10
        Me.LblBirthdate.Text = "MM/DD/YYYY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Birthdate:"
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.BackColor = System.Drawing.Color.Transparent
        Me.LblLastName.Font = New System.Drawing.Font("Raleway Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastName.Location = New System.Drawing.Point(16, 183)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(86, 18)
        Me.LblLastName.TabIndex = 8
        Me.LblLastName.Text = "Last Name"
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.LblFirstName.Font = New System.Drawing.Font("Raleway Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstName.Location = New System.Drawing.Point(16, 201)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(86, 18)
        Me.LblFirstName.TabIndex = 7
        Me.LblFirstName.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Full Name:"
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsername.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(19, 51)
        Me.TxtUsername.MaxLength = 20
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(228, 23)
        Me.TxtUsername.TabIndex = 5
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(16, 30)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(86, 18)
        Me.LblUsername.TabIndex = 5
        Me.LblUsername.Text = "Username:"
        '
        'LnkBacktoLogin
        '
        Me.LnkBacktoLogin.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.LnkBacktoLogin.AutoSize = True
        Me.LnkBacktoLogin.BackColor = System.Drawing.Color.Transparent
        Me.LnkBacktoLogin.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkBacktoLogin.LinkColor = System.Drawing.Color.White
        Me.LnkBacktoLogin.Location = New System.Drawing.Point(35, 416)
        Me.LnkBacktoLogin.Name = "LnkBacktoLogin"
        Me.LnkBacktoLogin.Size = New System.Drawing.Size(67, 18)
        Me.LnkBacktoLogin.TabIndex = 5
        Me.LnkBacktoLogin.TabStop = True
        Me.LnkBacktoLogin.Text = "Go back"
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(830, 456)
        Me.Controls.Add(Me.LnkBacktoLogin)
        Me.Controls.Add(Me.GrpInputFields)
        Me.Controls.Add(Me.BtnValidateLrn)
        Me.Controls.Add(Me.TxtLrnId)
        Me.Controls.Add(Me.LblLRN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSignUp"
        Me.GrpInputFields.ResumeLayout(False)
        Me.GrpInputFields.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLRN As Label
    Friend WithEvents TxtLrnId As TextBox
    Friend WithEvents BtnValidateLrn As Button
    Friend WithEvents GrpInputFields As GroupBox
    Friend WithEvents LblLastName As Label
    Friend WithEvents LblFirstName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents BtnCreateAccount As Button
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents LblConfirmPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblBirthdate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LnkBacktoLogin As LinkLabel
    Friend WithEvents LblUniqueID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmailAddress As TextBox
    Friend WithEvents Label4 As Label
End Class
