<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOTP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddOTP))
        Me.TxtOTP = New System.Windows.Forms.TextBox()
        Me.TxtConfrimOTP = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConfirmOTP_1 = New System.Windows.Forms.Button()
        Me.Pnl1OTP = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pnl2OTP = New System.Windows.Forms.Panel()
        Me.BtnConfirmOTP_2 = New System.Windows.Forms.Button()
        Me.BtnEnableOTP = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl1OTP.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl2OTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtOTP
        '
        Me.TxtOTP.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOTP.Location = New System.Drawing.Point(12, 34)
        Me.TxtOTP.MaxLength = 6
        Me.TxtOTP.Name = "TxtOTP"
        Me.TxtOTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOTP.Size = New System.Drawing.Size(131, 45)
        Me.TxtOTP.TabIndex = 0
        Me.TxtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtConfrimOTP
        '
        Me.TxtConfrimOTP.Enabled = False
        Me.TxtConfrimOTP.Font = New System.Drawing.Font("Raleway Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfrimOTP.Location = New System.Drawing.Point(22, 39)
        Me.TxtConfrimOTP.MaxLength = 6
        Me.TxtConfrimOTP.Name = "TxtConfrimOTP"
        Me.TxtConfrimOTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfrimOTP.Size = New System.Drawing.Size(131, 45)
        Me.TxtConfrimOTP.TabIndex = 1
        Me.TxtConfrimOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BtnConfirmOTP_1
        '
        Me.BtnConfirmOTP_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConfirmOTP_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmOTP_1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmOTP_1.Location = New System.Drawing.Point(12, 97)
        Me.BtnConfirmOTP_1.Name = "BtnConfirmOTP_1"
        Me.BtnConfirmOTP_1.Size = New System.Drawing.Size(131, 31)
        Me.BtnConfirmOTP_1.TabIndex = 3
        Me.BtnConfirmOTP_1.Text = "Confirm OTP"
        Me.BtnConfirmOTP_1.UseVisualStyleBackColor = False
        '
        'Pnl1OTP
        '
        Me.Pnl1OTP.BackColor = System.Drawing.Color.Transparent
        Me.Pnl1OTP.Controls.Add(Me.BtnConfirmOTP_1)
        Me.Pnl1OTP.Controls.Add(Me.TxtOTP)
        Me.Pnl1OTP.Location = New System.Drawing.Point(12, 112)
        Me.Pnl1OTP.Name = "Pnl1OTP"
        Me.Pnl1OTP.Size = New System.Drawing.Size(155, 173)
        Me.Pnl1OTP.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Make your OTP"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(283, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Pnl2OTP
        '
        Me.Pnl2OTP.BackColor = System.Drawing.Color.Transparent
        Me.Pnl2OTP.Controls.Add(Me.BtnConfirmOTP_2)
        Me.Pnl2OTP.Controls.Add(Me.TxtConfrimOTP)
        Me.Pnl2OTP.Location = New System.Drawing.Point(243, 112)
        Me.Pnl2OTP.Name = "Pnl2OTP"
        Me.Pnl2OTP.Size = New System.Drawing.Size(173, 173)
        Me.Pnl2OTP.TabIndex = 7
        '
        'BtnConfirmOTP_2
        '
        Me.BtnConfirmOTP_2.BackColor = System.Drawing.Color.IndianRed
        Me.BtnConfirmOTP_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmOTP_2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmOTP_2.Location = New System.Drawing.Point(22, 97)
        Me.BtnConfirmOTP_2.Name = "BtnConfirmOTP_2"
        Me.BtnConfirmOTP_2.Size = New System.Drawing.Size(131, 31)
        Me.BtnConfirmOTP_2.TabIndex = 4
        Me.BtnConfirmOTP_2.Text = "Back"
        Me.BtnConfirmOTP_2.UseVisualStyleBackColor = False
        Me.BtnConfirmOTP_2.Visible = False
        '
        'BtnEnableOTP
        '
        Me.BtnEnableOTP.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnEnableOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnableOTP.Font = New System.Drawing.Font("Raleway Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnableOTP.Location = New System.Drawing.Point(67, 308)
        Me.BtnEnableOTP.Name = "BtnEnableOTP"
        Me.BtnEnableOTP.Size = New System.Drawing.Size(290, 47)
        Me.BtnEnableOTP.TabIndex = 4
        Me.BtnEnableOTP.Text = "ENABLE OTP"
        Me.BtnEnableOTP.UseVisualStyleBackColor = False
        Me.BtnEnableOTP.Visible = False
        '
        'frmAddOTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(428, 379)
        Me.Controls.Add(Me.BtnEnableOTP)
        Me.Controls.Add(Me.Pnl2OTP)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pnl1OTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddOTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTP Generating"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl1OTP.ResumeLayout(False)
        Me.Pnl1OTP.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl2OTP.ResumeLayout(False)
        Me.Pnl2OTP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOTP As TextBox
    Friend WithEvents TxtConfrimOTP As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnConfirmOTP_1 As Button
    Friend WithEvents Pnl1OTP As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Pnl2OTP As Panel
    Friend WithEvents BtnConfirmOTP_2 As Button
    Friend WithEvents BtnEnableOTP As Button
End Class
