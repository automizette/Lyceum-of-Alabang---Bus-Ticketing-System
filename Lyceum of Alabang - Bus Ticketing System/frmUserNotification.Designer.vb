<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserNotification
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserNotification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvNotificationsMenu = New System.Windows.Forms.DataGridView()
        Me.BtnClearThisNotif = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        CType(Me.DgvNotificationsMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway ExtraBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notification"
        '
        'DgvNotificationsMenu
        '
        Me.DgvNotificationsMenu.AllowUserToAddRows = False
        Me.DgvNotificationsMenu.AllowUserToDeleteRows = False
        Me.DgvNotificationsMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNotificationsMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvNotificationsMenu.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvNotificationsMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvNotificationsMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotificationsMenu.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(197, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotificationsMenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvNotificationsMenu.GridColor = System.Drawing.Color.Black
        Me.DgvNotificationsMenu.Location = New System.Drawing.Point(12, 96)
        Me.DgvNotificationsMenu.MultiSelect = False
        Me.DgvNotificationsMenu.Name = "DgvNotificationsMenu"
        Me.DgvNotificationsMenu.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotificationsMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvNotificationsMenu.RowHeadersVisible = False
        Me.DgvNotificationsMenu.RowHeadersWidth = 20
        Me.DgvNotificationsMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvNotificationsMenu.RowTemplate.Height = 40
        Me.DgvNotificationsMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotificationsMenu.ShowEditingIcon = False
        Me.DgvNotificationsMenu.Size = New System.Drawing.Size(718, 435)
        Me.DgvNotificationsMenu.TabIndex = 2
        '
        'BtnClearThisNotif
        '
        Me.BtnClearThisNotif.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnClearThisNotif.Enabled = False
        Me.BtnClearThisNotif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClearThisNotif.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearThisNotif.Location = New System.Drawing.Point(578, 12)
        Me.BtnClearThisNotif.Name = "BtnClearThisNotif"
        Me.BtnClearThisNotif.Size = New System.Drawing.Size(152, 23)
        Me.BtnClearThisNotif.TabIndex = 3
        Me.BtnClearThisNotif.Text = "Clear this notification"
        Me.BtnClearThisNotif.UseVisualStyleBackColor = False
        '
        'ClearAll
        '
        Me.ClearAll.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearAll.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAll.Location = New System.Drawing.Point(578, 45)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(152, 23)
        Me.ClearAll.TabIndex = 4
        Me.ClearAll.Text = "Clear all"
        Me.ClearAll.UseVisualStyleBackColor = False
        '
        'frmUserNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(742, 543)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.BtnClearThisNotif)
        Me.Controls.Add(Me.DgvNotificationsMenu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Notification"
        CType(Me.DgvNotificationsMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DgvNotificationsMenu As DataGridView
    Friend WithEvents BtnClearThisNotif As Button
    Friend WithEvents ClearAll As Button
End Class
