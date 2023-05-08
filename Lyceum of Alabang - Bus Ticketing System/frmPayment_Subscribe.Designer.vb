<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment_Subscribe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment_Subscribe))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.BtnConfirmReferenceNumber = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DateTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 261)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(86, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scan this QR Code!"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 103)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtReferenceNumber
        '
        Me.TxtReferenceNumber.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferenceNumber.Location = New System.Drawing.Point(34, 477)
        Me.TxtReferenceNumber.Name = "TxtReferenceNumber"
        Me.TxtReferenceNumber.Size = New System.Drawing.Size(367, 26)
        Me.TxtReferenceNumber.TabIndex = 3
        Me.TxtReferenceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnConfirmReferenceNumber
        '
        Me.BtnConfirmReferenceNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnConfirmReferenceNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmReferenceNumber.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmReferenceNumber.Location = New System.Drawing.Point(119, 513)
        Me.BtnConfirmReferenceNumber.Name = "BtnConfirmReferenceNumber"
        Me.BtnConfirmReferenceNumber.Size = New System.Drawing.Size(201, 39)
        Me.BtnConfirmReferenceNumber.TabIndex = 4
        Me.BtnConfirmReferenceNumber.Text = "Confirm Reference No."
        Me.BtnConfirmReferenceNumber.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(200, 562)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 18)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Exit"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'DateTimer
        '
        Me.DateTimer.Interval = 1000
        '
        'frmPayment_Subscribe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(429, 614)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnConfirmReferenceNumber)
        Me.Controls.Add(Me.TxtReferenceNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPayment_Subscribe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You are about to subscribe to the premium plan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtReferenceNumber As TextBox
    Friend WithEvents BtnConfirmReferenceNumber As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DateTimer As Timer
End Class
