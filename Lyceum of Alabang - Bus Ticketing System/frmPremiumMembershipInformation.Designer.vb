<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPremiumMembershipInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPremiumMembershipInformation))
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnApply
        '
        Me.BtnApply.BackColor = System.Drawing.Color.Yellow
        Me.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnApply.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApply.Location = New System.Drawing.Point(272, 296)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(153, 53)
        Me.BtnApply.TabIndex = 0
        Me.BtnApply.Text = "Apply now!"
        Me.BtnApply.UseVisualStyleBackColor = False
        '
        'frmPremiumMembershipInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(708, 371)
        Me.Controls.Add(Me.BtnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPremiumMembershipInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What is premium membership?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnApply As Button
End Class
