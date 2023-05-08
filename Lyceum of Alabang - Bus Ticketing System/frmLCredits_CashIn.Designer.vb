<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLCredits_CashIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLCredits_CashIn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpEnterCode = New System.Windows.Forms.GroupBox()
        Me.PnlLCreditStatus = New System.Windows.Forms.Panel()
        Me.BtnConfirmCode = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LblLCreditsNewBalance = New System.Windows.Forms.Label()
        Me.LblLCreditsObtained = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PnlEnterCode = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.BtnCheckReferralCode = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.BtnSubmitReference = New System.Windows.Forms.Button()
        Me.BtnEnterCode = New System.Windows.Forms.Button()
        Me.PnlEnterReferenceNumber = New System.Windows.Forms.Panel()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpEnterCode.SuspendLayout()
        Me.PnlLCreditStatus.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEnterCode.SuspendLayout()
        Me.PnlEnterReferenceNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scan this!"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "and send at any amount. (PHP 1 = 1 L-Credit)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(305, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OR"
        '
        'GrpEnterCode
        '
        Me.GrpEnterCode.BackColor = System.Drawing.Color.Transparent
        Me.GrpEnterCode.Controls.Add(Me.PnlLCreditStatus)
        Me.GrpEnterCode.Controls.Add(Me.PnlEnterCode)
        Me.GrpEnterCode.Controls.Add(Me.BtnCheckReferralCode)
        Me.GrpEnterCode.Enabled = False
        Me.GrpEnterCode.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpEnterCode.ForeColor = System.Drawing.Color.White
        Me.GrpEnterCode.Location = New System.Drawing.Point(400, 81)
        Me.GrpEnterCode.Name = "GrpEnterCode"
        Me.GrpEnterCode.Size = New System.Drawing.Size(475, 229)
        Me.GrpEnterCode.TabIndex = 4
        Me.GrpEnterCode.TabStop = False
        '
        'PnlLCreditStatus
        '
        Me.PnlLCreditStatus.Controls.Add(Me.BtnConfirmCode)
        Me.PnlLCreditStatus.Controls.Add(Me.PictureBox3)
        Me.PnlLCreditStatus.Controls.Add(Me.LblLCreditsNewBalance)
        Me.PnlLCreditStatus.Controls.Add(Me.LblLCreditsObtained)
        Me.PnlLCreditStatus.Controls.Add(Me.Label8)
        Me.PnlLCreditStatus.Controls.Add(Me.Label7)
        Me.PnlLCreditStatus.Controls.Add(Me.PictureBox2)
        Me.PnlLCreditStatus.Location = New System.Drawing.Point(9, 122)
        Me.PnlLCreditStatus.Name = "PnlLCreditStatus"
        Me.PnlLCreditStatus.Size = New System.Drawing.Size(460, 100)
        Me.PnlLCreditStatus.TabIndex = 11
        Me.PnlLCreditStatus.Visible = False
        '
        'BtnConfirmCode
        '
        Me.BtnConfirmCode.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnConfirmCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmCode.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmCode.ForeColor = System.Drawing.Color.Black
        Me.BtnConfirmCode.Location = New System.Drawing.Point(367, 65)
        Me.BtnConfirmCode.Name = "BtnConfirmCode"
        Me.BtnConfirmCode.Size = New System.Drawing.Size(89, 29)
        Me.BtnConfirmCode.TabIndex = 12
        Me.BtnConfirmCode.Text = "Confirm"
        Me.BtnConfirmCode.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(152, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'LblLCreditsNewBalance
        '
        Me.LblLCreditsNewBalance.AutoSize = True
        Me.LblLCreditsNewBalance.BackColor = System.Drawing.Color.Transparent
        Me.LblLCreditsNewBalance.Font = New System.Drawing.Font("Raleway ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLCreditsNewBalance.ForeColor = System.Drawing.Color.Gold
        Me.LblLCreditsNewBalance.Location = New System.Drawing.Point(248, 38)
        Me.LblLCreditsNewBalance.Name = "LblLCreditsNewBalance"
        Me.LblLCreditsNewBalance.Size = New System.Drawing.Size(48, 31)
        Me.LblLCreditsNewBalance.TabIndex = 14
        Me.LblLCreditsNewBalance.Text = "00"
        '
        'LblLCreditsObtained
        '
        Me.LblLCreditsObtained.AutoSize = True
        Me.LblLCreditsObtained.BackColor = System.Drawing.Color.Transparent
        Me.LblLCreditsObtained.Font = New System.Drawing.Font("Raleway ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLCreditsObtained.ForeColor = System.Drawing.Color.PaleGreen
        Me.LblLCreditsObtained.Location = New System.Drawing.Point(47, 38)
        Me.LblLCreditsObtained.Name = "LblLCreditsObtained"
        Me.LblLCreditsObtained.Size = New System.Drawing.Size(48, 31)
        Me.LblLCreditsObtained.TabIndex = 8
        Me.LblLCreditsObtained.Text = "00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(251, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "New Balance:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Obtained:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PnlEnterCode
        '
        Me.PnlEnterCode.Controls.Add(Me.Label5)
        Me.PnlEnterCode.Controls.Add(Me.Label6)
        Me.PnlEnterCode.Controls.Add(Me.TxtCode)
        Me.PnlEnterCode.Location = New System.Drawing.Point(9, 26)
        Me.PnlEnterCode.Name = "PnlEnterCode"
        Me.PnlEnterCode.Size = New System.Drawing.Size(273, 90)
        Me.PnlEnterCode.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Example: ABCDE12345 (5 letters, 5 numbers)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(12, 45)
        Me.TxtCode.MaxLength = 10
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(257, 25)
        Me.TxtCode.TabIndex = 8
        '
        'BtnCheckReferralCode
        '
        Me.BtnCheckReferralCode.BackColor = System.Drawing.Color.LightGreen
        Me.BtnCheckReferralCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckReferralCode.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckReferralCode.ForeColor = System.Drawing.Color.Black
        Me.BtnCheckReferralCode.Location = New System.Drawing.Point(286, 71)
        Me.BtnCheckReferralCode.Name = "BtnCheckReferralCode"
        Me.BtnCheckReferralCode.Size = New System.Drawing.Size(97, 25)
        Me.BtnCheckReferralCode.TabIndex = 8
        Me.BtnCheckReferralCode.Text = "Check"
        Me.BtnCheckReferralCode.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter reference number:"
        '
        'TxtReferenceNumber
        '
        Me.TxtReferenceNumber.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferenceNumber.Location = New System.Drawing.Point(7, 31)
        Me.TxtReferenceNumber.MaxLength = 13
        Me.TxtReferenceNumber.Name = "TxtReferenceNumber"
        Me.TxtReferenceNumber.Size = New System.Drawing.Size(333, 25)
        Me.TxtReferenceNumber.TabIndex = 6
        '
        'BtnSubmitReference
        '
        Me.BtnSubmitReference.BackColor = System.Drawing.Color.PowderBlue
        Me.BtnSubmitReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmitReference.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmitReference.Location = New System.Drawing.Point(346, 62)
        Me.BtnSubmitReference.Name = "BtnSubmitReference"
        Me.BtnSubmitReference.Size = New System.Drawing.Size(113, 30)
        Me.BtnSubmitReference.TabIndex = 7
        Me.BtnSubmitReference.Text = "Submit"
        Me.BtnSubmitReference.UseVisualStyleBackColor = False
        '
        'BtnEnterCode
        '
        Me.BtnEnterCode.BackColor = System.Drawing.Color.PowderBlue
        Me.BtnEnterCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnterCode.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnterCode.ForeColor = System.Drawing.Color.Black
        Me.BtnEnterCode.Location = New System.Drawing.Point(399, 45)
        Me.BtnEnterCode.Name = "BtnEnterCode"
        Me.BtnEnterCode.Size = New System.Drawing.Size(105, 30)
        Me.BtnEnterCode.TabIndex = 8
        Me.BtnEnterCode.Text = "Enter Code"
        Me.BtnEnterCode.UseVisualStyleBackColor = False
        '
        'PnlEnterReferenceNumber
        '
        Me.PnlEnterReferenceNumber.BackColor = System.Drawing.Color.Transparent
        Me.PnlEnterReferenceNumber.Controls.Add(Me.TxtAmount)
        Me.PnlEnterReferenceNumber.Controls.Add(Me.Label9)
        Me.PnlEnterReferenceNumber.Controls.Add(Me.Label4)
        Me.PnlEnterReferenceNumber.Controls.Add(Me.BtnSubmitReference)
        Me.PnlEnterReferenceNumber.Controls.Add(Me.TxtReferenceNumber)
        Me.PnlEnterReferenceNumber.Location = New System.Drawing.Point(12, 342)
        Me.PnlEnterReferenceNumber.Name = "PnlEnterReferenceNumber"
        Me.PnlEnterReferenceNumber.Size = New System.Drawing.Size(467, 117)
        Me.PnlEnterReferenceNumber.TabIndex = 9
        '
        'TxtAmount
        '
        Me.TxtAmount.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(346, 31)
        Me.TxtAmount.MaxLength = 13
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(113, 25)
        Me.TxtAmount.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(342, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Amount:"
        '
        'frmLCredits_CashIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(887, 471)
        Me.Controls.Add(Me.BtnEnterCode)
        Me.Controls.Add(Me.GrpEnterCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PnlEnterReferenceNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLCredits_CashIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "L-Credits - Cash-in"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpEnterCode.ResumeLayout(False)
        Me.PnlLCreditStatus.ResumeLayout(False)
        Me.PnlLCreditStatus.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEnterCode.ResumeLayout(False)
        Me.PnlEnterCode.PerformLayout()
        Me.PnlEnterReferenceNumber.ResumeLayout(False)
        Me.PnlEnterReferenceNumber.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpEnterCode As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtReferenceNumber As TextBox
    Friend WithEvents BtnSubmitReference As Button
    Friend WithEvents BtnEnterCode As Button
    Friend WithEvents PnlEnterReferenceNumber As Panel
    Friend WithEvents PnlLCreditStatus As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCheckReferralCode As Button
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblLCreditsNewBalance As Label
    Friend WithEvents LblLCreditsObtained As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnConfirmCode As Button
    Friend WithEvents PnlEnterCode As Panel
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents Label9 As Label
End Class
