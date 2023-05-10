<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstTimeSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstTimeSetup))
        Me.PbTutorial = New System.Windows.Forms.PictureBox()
        Me.LnkNext = New System.Windows.Forms.LinkLabel()
        Me.LnkBack = New System.Windows.Forms.LinkLabel()
        Me.LnkContinue = New System.Windows.Forms.LinkLabel()
        CType(Me.PbTutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbTutorial
        '
        Me.PbTutorial.Location = New System.Drawing.Point(12, 12)
        Me.PbTutorial.Name = "PbTutorial"
        Me.PbTutorial.Size = New System.Drawing.Size(722, 377)
        Me.PbTutorial.TabIndex = 0
        Me.PbTutorial.TabStop = False
        '
        'LnkNext
        '
        Me.LnkNext.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LnkNext.AutoSize = True
        Me.LnkNext.BackColor = System.Drawing.Color.Transparent
        Me.LnkNext.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkNext.LinkColor = System.Drawing.Color.White
        Me.LnkNext.Location = New System.Drawing.Point(388, 410)
        Me.LnkNext.Name = "LnkNext"
        Me.LnkNext.Size = New System.Drawing.Size(54, 18)
        Me.LnkNext.TabIndex = 1
        Me.LnkNext.TabStop = True
        Me.LnkNext.Text = "Next >"
        Me.LnkNext.VisitedLinkColor = System.Drawing.Color.White
        '
        'LnkBack
        '
        Me.LnkBack.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LnkBack.AutoSize = True
        Me.LnkBack.BackColor = System.Drawing.Color.Transparent
        Me.LnkBack.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkBack.LinkColor = System.Drawing.Color.White
        Me.LnkBack.Location = New System.Drawing.Point(268, 410)
        Me.LnkBack.Name = "LnkBack"
        Me.LnkBack.Size = New System.Drawing.Size(57, 18)
        Me.LnkBack.TabIndex = 2
        Me.LnkBack.TabStop = True
        Me.LnkBack.Text = "< Back"
        Me.LnkBack.VisitedLinkColor = System.Drawing.Color.White
        '
        'LnkContinue
        '
        Me.LnkContinue.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LnkContinue.AutoSize = True
        Me.LnkContinue.BackColor = System.Drawing.Color.Transparent
        Me.LnkContinue.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkContinue.LinkColor = System.Drawing.Color.White
        Me.LnkContinue.Location = New System.Drawing.Point(388, 410)
        Me.LnkContinue.Name = "LnkContinue"
        Me.LnkContinue.Size = New System.Drawing.Size(71, 18)
        Me.LnkContinue.TabIndex = 3
        Me.LnkContinue.TabStop = True
        Me.LnkContinue.Text = "Let's go!"
        Me.LnkContinue.Visible = False
        Me.LnkContinue.VisitedLinkColor = System.Drawing.Color.White
        '
        'frmFirstTimeSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(746, 447)
        Me.Controls.Add(Me.LnkContinue)
        Me.Controls.Add(Me.LnkBack)
        Me.Controls.Add(Me.LnkNext)
        Me.Controls.Add(Me.PbTutorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFirstTimeSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome, newcomer!"
        Me.TopMost = True
        CType(Me.PbTutorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbTutorial As PictureBox
    Friend WithEvents LnkNext As LinkLabel
    Friend WithEvents LnkBack As LinkLabel
    Friend WithEvents LnkContinue As LinkLabel
End Class
