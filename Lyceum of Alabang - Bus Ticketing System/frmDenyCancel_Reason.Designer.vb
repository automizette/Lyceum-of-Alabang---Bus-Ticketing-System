<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDenyCancel_Reason
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDenyCancel_Reason))
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.CmbReason = New System.Windows.Forms.ComboBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnEditCmb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.BackColor = System.Drawing.Color.Transparent
        Me.LblFullName.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName.ForeColor = System.Drawing.Color.White
        Me.LblFullName.Location = New System.Drawing.Point(131, 37)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(164, 29)
        Me.LblFullName.TabIndex = 4
        Me.LblFullName.Text = "State reason:"
        '
        'CmbReason
        '
        Me.CmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbReason.Font = New System.Drawing.Font("Raleway ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReason.FormattingEnabled = True
        Me.CmbReason.Items.AddRange(New Object() {"Too many reservation", "Bus is full", "Route/Destination has been cancelled", "Number Coding", "Prohibited"})
        Me.CmbReason.Location = New System.Drawing.Point(37, 79)
        Me.CmbReason.Name = "CmbReason"
        Me.CmbReason.Size = New System.Drawing.Size(272, 26)
        Me.CmbReason.TabIndex = 5
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirm.Font = New System.Drawing.Font("Raleway ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(151, 111)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(124, 32)
        Me.BtnConfirm.TabIndex = 6
        Me.BtnConfirm.Text = "Continue"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'BtnEditCmb
        '
        Me.BtnEditCmb.BackColor = System.Drawing.Color.LightBlue
        Me.BtnEditCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditCmb.Font = New System.Drawing.Font("Raleway ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditCmb.Location = New System.Drawing.Point(315, 79)
        Me.BtnEditCmb.Name = "BtnEditCmb"
        Me.BtnEditCmb.Size = New System.Drawing.Size(87, 26)
        Me.BtnEditCmb.TabIndex = 7
        Me.BtnEditCmb.Text = "Others"
        Me.BtnEditCmb.UseVisualStyleBackColor = False
        '
        'frmDenyCancel_Reason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(442, 186)
        Me.Controls.Add(Me.BtnEditCmb)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.CmbReason)
        Me.Controls.Add(Me.LblFullName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDenyCancel_Reason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please state your reason"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFullName As Label
    Friend WithEvents CmbReason As ComboBox
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents BtnEditCmb As Button
End Class
