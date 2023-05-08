<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.BtnConfirmPassword = New System.Windows.Forms.Button()
        Me.LnkExit = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(132, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(30, 101)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(412, 26)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(30, 176)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(412, 26)
        Me.TxtConfirmPassword.TabIndex = 4
        Me.TxtConfirmPassword.UseSystemPasswordChar = True
        '
        'BtnConfirmPassword
        '
        Me.BtnConfirmPassword.BackColor = System.Drawing.Color.LightBlue
        Me.BtnConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmPassword.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmPassword.Location = New System.Drawing.Point(117, 213)
        Me.BtnConfirmPassword.Name = "BtnConfirmPassword"
        Me.BtnConfirmPassword.Size = New System.Drawing.Size(172, 43)
        Me.BtnConfirmPassword.TabIndex = 5
        Me.BtnConfirmPassword.Text = "Confirm"
        Me.BtnConfirmPassword.UseVisualStyleBackColor = False
        '
        'LnkExit
        '
        Me.LnkExit.AutoSize = True
        Me.LnkExit.BackColor = System.Drawing.Color.Transparent
        Me.LnkExit.Font = New System.Drawing.Font("Raleway", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkExit.LinkColor = System.Drawing.Color.White
        Me.LnkExit.Location = New System.Drawing.Point(311, 227)
        Me.LnkExit.Name = "LnkExit"
        Me.LnkExit.Size = New System.Drawing.Size(35, 18)
        Me.LnkExit.TabIndex = 6
        Me.LnkExit.TabStop = True
        Me.LnkExit.Text = "Exit"
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(477, 301)
        Me.Controls.Add(Me.LnkExit)
        Me.Controls.Add(Me.BtnConfirmPassword)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change your password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents BtnConfirmPassword As Button
    Friend WithEvents LnkExit As LinkLabel
End Class
