<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAuthenticate = New System.Windows.Forms.Button()
        Me.LnkSignUp = New System.Windows.Forms.LinkLabel()
        Me.LblNotify = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(297, 152)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(82, 18)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(300, 173)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(228, 23)
        Me.TxtUsername.TabIndex = 1
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(297, 228)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(78, 18)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(300, 249)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(228, 23)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(378, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LOGIN"
        '
        'BtnAuthenticate
        '
        Me.BtnAuthenticate.BackColor = System.Drawing.Color.LightCyan
        Me.BtnAuthenticate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAuthenticate.Font = New System.Drawing.Font("Raleway ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAuthenticate.Location = New System.Drawing.Point(300, 335)
        Me.BtnAuthenticate.Name = "BtnAuthenticate"
        Me.BtnAuthenticate.Size = New System.Drawing.Size(228, 36)
        Me.BtnAuthenticate.TabIndex = 5
        Me.BtnAuthenticate.Text = "Login"
        Me.BtnAuthenticate.UseVisualStyleBackColor = False
        '
        'LnkSignUp
        '
        Me.LnkSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LnkSignUp.AutoSize = True
        Me.LnkSignUp.BackColor = System.Drawing.Color.Transparent
        Me.LnkSignUp.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkSignUp.LinkColor = System.Drawing.Color.White
        Me.LnkSignUp.Location = New System.Drawing.Point(365, 404)
        Me.LnkSignUp.Name = "LnkSignUp"
        Me.LnkSignUp.Size = New System.Drawing.Size(97, 18)
        Me.LnkSignUp.TabIndex = 6
        Me.LnkSignUp.TabStop = True
        Me.LnkSignUp.Text = "No account?"
        '
        'LblNotify
        '
        Me.LblNotify.BackColor = System.Drawing.Color.Transparent
        Me.LblNotify.Font = New System.Drawing.Font("Raleway SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotify.ForeColor = System.Drawing.Color.Red
        Me.LblNotify.Location = New System.Drawing.Point(300, 284)
        Me.LblNotify.Name = "LblNotify"
        Me.LblNotify.Size = New System.Drawing.Size(228, 48)
        Me.LblNotify.TabIndex = 7
        Me.LblNotify.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(830, 456)
        Me.Controls.Add(Me.LblNotify)
        Me.Controls.Add(Me.LnkSignUp)
        Me.Controls.Add(Me.BtnAuthenticate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lyceum of Alabang - Bus Ticketing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAuthenticate As Button
    Friend WithEvents LnkSignUp As LinkLabel
    Friend WithEvents LblNotify As Label
End Class
