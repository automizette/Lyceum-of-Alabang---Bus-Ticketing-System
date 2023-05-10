<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendFeedback))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpFeedbackInformation = New System.Windows.Forms.GroupBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbFeedbackType = New System.Windows.Forms.ComboBox()
        Me.TxtFeedbackDesc = New System.Windows.Forms.TextBox()
        Me.BtnInsertImage = New System.Windows.Forms.Button()
        Me.PbPicture = New System.Windows.Forms.PictureBox()
        Me.BtnSendFeedback = New System.Windows.Forms.Button()
        Me.GrpFeedbackInformation.SuspendLayout()
        CType(Me.PbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Send feedback:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Feedback Type:"
        '
        'GrpFeedbackInformation
        '
        Me.GrpFeedbackInformation.BackColor = System.Drawing.Color.Transparent
        Me.GrpFeedbackInformation.Controls.Add(Me.TxtTitle)
        Me.GrpFeedbackInformation.Controls.Add(Me.Label3)
        Me.GrpFeedbackInformation.Controls.Add(Me.CmbFeedbackType)
        Me.GrpFeedbackInformation.Controls.Add(Me.Label2)
        Me.GrpFeedbackInformation.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpFeedbackInformation.ForeColor = System.Drawing.Color.White
        Me.GrpFeedbackInformation.Location = New System.Drawing.Point(31, 72)
        Me.GrpFeedbackInformation.Name = "GrpFeedbackInformation"
        Me.GrpFeedbackInformation.Size = New System.Drawing.Size(338, 148)
        Me.GrpFeedbackInformation.TabIndex = 2
        Me.GrpFeedbackInformation.TabStop = False
        Me.GrpFeedbackInformation.Text = "Feedback Information"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(132, 88)
        Me.TxtTitle.MaxLength = 20
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(181, 23)
        Me.TxtTitle.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Title:"
        '
        'CmbFeedbackType
        '
        Me.CmbFeedbackType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFeedbackType.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFeedbackType.FormattingEnabled = True
        Me.CmbFeedbackType.Items.AddRange(New Object() {"Bugs", "Errors", "Transaction", "Suggestions"})
        Me.CmbFeedbackType.Location = New System.Drawing.Point(132, 40)
        Me.CmbFeedbackType.Name = "CmbFeedbackType"
        Me.CmbFeedbackType.Size = New System.Drawing.Size(181, 23)
        Me.CmbFeedbackType.TabIndex = 2
        '
        'TxtFeedbackDesc
        '
        Me.TxtFeedbackDesc.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFeedbackDesc.Location = New System.Drawing.Point(384, 80)
        Me.TxtFeedbackDesc.Multiline = True
        Me.TxtFeedbackDesc.Name = "TxtFeedbackDesc"
        Me.TxtFeedbackDesc.Size = New System.Drawing.Size(504, 360)
        Me.TxtFeedbackDesc.TabIndex = 3
        '
        'BtnInsertImage
        '
        Me.BtnInsertImage.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnInsertImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsertImage.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertImage.ForeColor = System.Drawing.Color.Black
        Me.BtnInsertImage.Location = New System.Drawing.Point(31, 238)
        Me.BtnInsertImage.Name = "BtnInsertImage"
        Me.BtnInsertImage.Size = New System.Drawing.Size(110, 34)
        Me.BtnInsertImage.TabIndex = 4
        Me.BtnInsertImage.Text = "Insert Image"
        Me.BtnInsertImage.UseVisualStyleBackColor = False
        '
        'PbPicture
        '
        Me.PbPicture.InitialImage = CType(resources.GetObject("PbPicture.InitialImage"), System.Drawing.Image)
        Me.PbPicture.Location = New System.Drawing.Point(31, 278)
        Me.PbPicture.Name = "PbPicture"
        Me.PbPicture.Size = New System.Drawing.Size(338, 209)
        Me.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbPicture.TabIndex = 5
        Me.PbPicture.TabStop = False
        '
        'BtnSendFeedback
        '
        Me.BtnSendFeedback.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSendFeedback.Font = New System.Drawing.Font("Raleway ExtraBold", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendFeedback.ForeColor = System.Drawing.Color.Black
        Me.BtnSendFeedback.Location = New System.Drawing.Point(384, 453)
        Me.BtnSendFeedback.Name = "BtnSendFeedback"
        Me.BtnSendFeedback.Size = New System.Drawing.Size(503, 34)
        Me.BtnSendFeedback.TabIndex = 6
        Me.BtnSendFeedback.Text = "Send Feedback"
        Me.BtnSendFeedback.UseVisualStyleBackColor = False
        '
        'frmSendFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(897, 498)
        Me.Controls.Add(Me.BtnSendFeedback)
        Me.Controls.Add(Me.PbPicture)
        Me.Controls.Add(Me.BtnInsertImage)
        Me.Controls.Add(Me.TxtFeedbackDesc)
        Me.Controls.Add(Me.GrpFeedbackInformation)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSendFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send feedback"
        Me.GrpFeedbackInformation.ResumeLayout(False)
        Me.GrpFeedbackInformation.PerformLayout()
        CType(Me.PbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GrpFeedbackInformation As GroupBox
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbFeedbackType As ComboBox
    Friend WithEvents TxtFeedbackDesc As TextBox
    Friend WithEvents BtnInsertImage As Button
    Friend WithEvents PbPicture As PictureBox
    Friend WithEvents BtnSendFeedback As Button
End Class
