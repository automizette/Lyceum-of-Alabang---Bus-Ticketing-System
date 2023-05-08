<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificationInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotificationInformation))
        Me.LblNotifTitle = New System.Windows.Forms.Label()
        Me.LblNotifDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNotifTitle
        '
        Me.LblNotifTitle.BackColor = System.Drawing.Color.DarkCyan
        Me.LblNotifTitle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotifTitle.ForeColor = System.Drawing.Color.White
        Me.LblNotifTitle.Location = New System.Drawing.Point(12, 82)
        Me.LblNotifTitle.Name = "LblNotifTitle"
        Me.LblNotifTitle.Size = New System.Drawing.Size(432, 70)
        Me.LblNotifTitle.TabIndex = 0
        Me.LblNotifTitle.Text = "---"
        Me.LblNotifTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNotifDescription
        '
        Me.LblNotifDescription.BackColor = System.Drawing.Color.White
        Me.LblNotifDescription.Font = New System.Drawing.Font("Raleway SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotifDescription.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblNotifDescription.Location = New System.Drawing.Point(12, 152)
        Me.LblNotifDescription.Name = "LblNotifDescription"
        Me.LblNotifDescription.Size = New System.Drawing.Size(432, 432)
        Me.LblNotifDescription.TabIndex = 1
        Me.LblNotifDescription.Text = "---"
        '
        'frmNotificationInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(456, 642)
        Me.Controls.Add(Me.LblNotifDescription)
        Me.Controls.Add(Me.LblNotifTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNotificationInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "--"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblNotifTitle As Label
    Friend WithEvents LblNotifDescription As Label
End Class
