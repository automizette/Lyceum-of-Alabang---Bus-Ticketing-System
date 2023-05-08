<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOTPValidation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOTPValidation))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtOTP = New System.Windows.Forms.TextBox()
        Me.BtnConfirmOTP = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(106, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter your OTP"
        '
        'TxtOTP
        '
        Me.TxtOTP.Font = New System.Drawing.Font("Raleway ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOTP.Location = New System.Drawing.Point(68, 90)
        Me.TxtOTP.MaxLength = 6
        Me.TxtOTP.Name = "TxtOTP"
        Me.TxtOTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOTP.Size = New System.Drawing.Size(171, 51)
        Me.TxtOTP.TabIndex = 2
        Me.TxtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnConfirmOTP
        '
        Me.BtnConfirmOTP.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnConfirmOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmOTP.Font = New System.Drawing.Font("Raleway", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmOTP.Location = New System.Drawing.Point(68, 147)
        Me.BtnConfirmOTP.Name = "BtnConfirmOTP"
        Me.BtnConfirmOTP.Size = New System.Drawing.Size(171, 33)
        Me.BtnConfirmOTP.TabIndex = 3
        Me.BtnConfirmOTP.Text = "Confirm"
        Me.BtnConfirmOTP.UseVisualStyleBackColor = False
        '
        'frmOTPValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(312, 206)
        Me.Controls.Add(Me.BtnConfirmOTP)
        Me.Controls.Add(Me.TxtOTP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOTPValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "NO_TAG"
        Me.Text = "Enter your OTP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtOTP As TextBox
    Friend WithEvents BtnConfirmOTP As Button
End Class
