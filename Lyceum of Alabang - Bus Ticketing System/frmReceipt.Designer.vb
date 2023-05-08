<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblSeatCode_R1 = New System.Windows.Forms.Label()
        Me.LblSeatCode_R2 = New System.Windows.Forms.Label()
        Me.LblSeatCode_R3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUniqueID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblBusName = New System.Windows.Forms.Label()
        Me.LblPlateNumber = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblTransactionID = New System.Windows.Forms.Label()
        Me.LblPointA = New System.Windows.Forms.Label()
        Me.LblPointB = New System.Windows.Forms.Label()
        Me.LblDOT = New System.Windows.Forms.Label()
        Me.LnkPrintReceipt = New System.Windows.Forms.LinkLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OFFICIAL RECEIPT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "-------------------------"
        '
        'LblSeatCode_R1
        '
        Me.LblSeatCode_R1.AutoSize = True
        Me.LblSeatCode_R1.BackColor = System.Drawing.Color.Transparent
        Me.LblSeatCode_R1.Font = New System.Drawing.Font("Raleway Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeatCode_R1.Location = New System.Drawing.Point(129, 226)
        Me.LblSeatCode_R1.Name = "LblSeatCode_R1"
        Me.LblSeatCode_R1.Size = New System.Drawing.Size(110, 75)
        Me.LblSeatCode_R1.TabIndex = 2
        Me.LblSeatCode_R1.Text = "A1"
        Me.LblSeatCode_R1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblSeatCode_R2
        '
        Me.LblSeatCode_R2.AutoSize = True
        Me.LblSeatCode_R2.BackColor = System.Drawing.Color.Transparent
        Me.LblSeatCode_R2.Font = New System.Drawing.Font("Raleway Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeatCode_R2.ForeColor = System.Drawing.Color.Gray
        Me.LblSeatCode_R2.Location = New System.Drawing.Point(130, 251)
        Me.LblSeatCode_R2.Name = "LblSeatCode_R2"
        Me.LblSeatCode_R2.Size = New System.Drawing.Size(110, 75)
        Me.LblSeatCode_R2.TabIndex = 3
        Me.LblSeatCode_R2.Text = "A1"
        Me.LblSeatCode_R2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblSeatCode_R3
        '
        Me.LblSeatCode_R3.AutoSize = True
        Me.LblSeatCode_R3.BackColor = System.Drawing.Color.Transparent
        Me.LblSeatCode_R3.Font = New System.Drawing.Font("Raleway Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeatCode_R3.ForeColor = System.Drawing.Color.Silver
        Me.LblSeatCode_R3.Location = New System.Drawing.Point(130, 270)
        Me.LblSeatCode_R3.Name = "LblSeatCode_R3"
        Me.LblSeatCode_R3.Size = New System.Drawing.Size(110, 75)
        Me.LblSeatCode_R3.TabIndex = 4
        Me.LblSeatCode_R3.Text = "A1"
        Me.LblSeatCode_R3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "-------------------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Raleway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Information:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Full Name:"
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.BackColor = System.Drawing.Color.Transparent
        Me.LblFullName.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName.Location = New System.Drawing.Point(152, 416)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(70, 15)
        Me.LblFullName.TabIndex = 8
        Me.LblFullName.Text = "Full Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "UniqueID:"
        '
        'LblUniqueID
        '
        Me.LblUniqueID.AutoSize = True
        Me.LblUniqueID.BackColor = System.Drawing.Color.Transparent
        Me.LblUniqueID.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUniqueID.Location = New System.Drawing.Point(152, 441)
        Me.LblUniqueID.Name = "LblUniqueID"
        Me.LblUniqueID.Size = New System.Drawing.Size(86, 15)
        Me.LblUniqueID.TabIndex = 10
        Me.LblUniqueID.Text = "LOA-XXXXXX"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 466)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Bus Name:"
        '
        'LblBusName
        '
        Me.LblBusName.AutoSize = True
        Me.LblBusName.BackColor = System.Drawing.Color.Transparent
        Me.LblBusName.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBusName.Location = New System.Drawing.Point(152, 466)
        Me.LblBusName.Name = "LblBusName"
        Me.LblBusName.Size = New System.Drawing.Size(70, 15)
        Me.LblBusName.TabIndex = 12
        Me.LblBusName.Text = "Bus Name"
        '
        'LblPlateNumber
        '
        Me.LblPlateNumber.AutoSize = True
        Me.LblPlateNumber.BackColor = System.Drawing.Color.Transparent
        Me.LblPlateNumber.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlateNumber.Location = New System.Drawing.Point(152, 481)
        Me.LblPlateNumber.Name = "LblPlateNumber"
        Me.LblPlateNumber.Size = New System.Drawing.Size(80, 13)
        Me.LblPlateNumber.TabIndex = 13
        Me.LblPlateNumber.Text = "Plate Number"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(81, 340)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(56, 15)
        Me.LblDate.TabIndex = 14
        Me.LblDate.Text = "MM/DD"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(227, 340)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(58, 15)
        Me.LblTime.TabIndex = 15
        Me.LblTime.Text = "00:00PA"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(119, 507)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Transaction Number:"
        '
        'LblTransactionID
        '
        Me.LblTransactionID.BackColor = System.Drawing.Color.Transparent
        Me.LblTransactionID.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactionID.Location = New System.Drawing.Point(96, 522)
        Me.LblTransactionID.Name = "LblTransactionID"
        Me.LblTransactionID.Size = New System.Drawing.Size(177, 21)
        Me.LblTransactionID.TabIndex = 17
        Me.LblTransactionID.Text = "XXXXXXXXX"
        Me.LblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPointA
        '
        Me.LblPointA.AutoSize = True
        Me.LblPointA.BackColor = System.Drawing.Color.Transparent
        Me.LblPointA.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPointA.Location = New System.Drawing.Point(81, 198)
        Me.LblPointA.Name = "LblPointA"
        Me.LblPointA.Size = New System.Drawing.Size(60, 15)
        Me.LblPointA.TabIndex = 18
        Me.LblPointA.Text = "POINT-A"
        '
        'LblPointB
        '
        Me.LblPointB.BackColor = System.Drawing.Color.Transparent
        Me.LblPointB.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPointB.Location = New System.Drawing.Point(160, 198)
        Me.LblPointB.Name = "LblPointB"
        Me.LblPointB.Size = New System.Drawing.Size(125, 19)
        Me.LblPointB.TabIndex = 19
        Me.LblPointB.Text = "POINT-B"
        Me.LblPointB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDOT
        '
        Me.LblDOT.BackColor = System.Drawing.Color.Transparent
        Me.LblDOT.Font = New System.Drawing.Font("Raleway SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDOT.Location = New System.Drawing.Point(50, 151)
        Me.LblDOT.Name = "LblDOT"
        Me.LblDOT.Size = New System.Drawing.Size(268, 17)
        Me.LblDOT.TabIndex = 21
        Me.LblDOT.Text = "MM/DD/YYYY"
        Me.LblDOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LnkPrintReceipt
        '
        Me.LnkPrintReceipt.ActiveLinkColor = System.Drawing.Color.Gray
        Me.LnkPrintReceipt.AutoSize = True
        Me.LnkPrintReceipt.BackColor = System.Drawing.Color.Transparent
        Me.LnkPrintReceipt.Font = New System.Drawing.Font("Raleway ExtraBold", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkPrintReceipt.LinkColor = System.Drawing.Color.White
        Me.LnkPrintReceipt.Location = New System.Drawing.Point(140, 577)
        Me.LnkPrintReceipt.Name = "LnkPrintReceipt"
        Me.LnkPrintReceipt.Size = New System.Drawing.Size(84, 15)
        Me.LnkPrintReceipt.TabIndex = 22
        Me.LnkPrintReceipt.TabStop = True
        Me.LnkPrintReceipt.Text = "Print Receipt"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Price:"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.BackColor = System.Drawing.Color.Transparent
        Me.LblPrice.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.Black
        Me.LblPrice.Location = New System.Drawing.Point(153, 394)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(31, 15)
        Me.LblPrice.TabIndex = 24
        Me.LblPrice.Text = "XXX"
        '
        'FrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(365, 600)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LnkPrintReceipt)
        Me.Controls.Add(Me.LblDOT)
        Me.Controls.Add(Me.LblPointB)
        Me.Controls.Add(Me.LblPointA)
        Me.Controls.Add(Me.LblTransactionID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblPlateNumber)
        Me.Controls.Add(Me.LblBusName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblUniqueID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblSeatCode_R1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSeatCode_R2)
        Me.Controls.Add(Me.LblSeatCode_R3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PURCHASED_BY_YOU"
        Me.Text = "This is your official receipt."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblSeatCode_R1 As Label
    Friend WithEvents LblSeatCode_R2 As Label
    Friend WithEvents LblSeatCode_R3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblUniqueID As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblBusName As Label
    Friend WithEvents LblPlateNumber As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblTransactionID As Label
    Friend WithEvents LblPointA As Label
    Friend WithEvents LblPointB As Label
    Friend WithEvents LblDOT As Label
    Friend WithEvents LnkPrintReceipt As LinkLabel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents LblPrice As Label
End Class
