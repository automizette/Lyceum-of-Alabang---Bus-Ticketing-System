<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactionHistory_Admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionHistory_Admin))
        Me.DgvTransactionHistory_Admin = New System.Windows.Forms.DataGridView()
        Me.BtnExportToExcel_TH = New System.Windows.Forms.Button()
        Me.LblFileLocation_TH = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnExportNow_TH = New System.Windows.Forms.Button()
        Me.LblTextFileLocation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFilters_TH = New System.Windows.Forms.Button()
        CType(Me.DgvTransactionHistory_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTransactionHistory_Admin
        '
        Me.DgvTransactionHistory_Admin.AllowUserToAddRows = False
        Me.DgvTransactionHistory_Admin.AllowUserToDeleteRows = False
        Me.DgvTransactionHistory_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTransactionHistory_Admin.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvTransactionHistory_Admin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTransactionHistory_Admin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTransactionHistory_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(127, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTransactionHistory_Admin.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTransactionHistory_Admin.GridColor = System.Drawing.Color.White
        Me.DgvTransactionHistory_Admin.Location = New System.Drawing.Point(12, 91)
        Me.DgvTransactionHistory_Admin.Name = "DgvTransactionHistory_Admin"
        Me.DgvTransactionHistory_Admin.ReadOnly = True
        Me.DgvTransactionHistory_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTransactionHistory_Admin.Size = New System.Drawing.Size(1093, 401)
        Me.DgvTransactionHistory_Admin.TabIndex = 7
        '
        'BtnExportToExcel_TH
        '
        Me.BtnExportToExcel_TH.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnExportToExcel_TH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportToExcel_TH.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportToExcel_TH.ForeColor = System.Drawing.Color.Black
        Me.BtnExportToExcel_TH.Location = New System.Drawing.Point(937, 12)
        Me.BtnExportToExcel_TH.Name = "BtnExportToExcel_TH"
        Me.BtnExportToExcel_TH.Size = New System.Drawing.Size(168, 32)
        Me.BtnExportToExcel_TH.TabIndex = 13
        Me.BtnExportToExcel_TH.Text = "Export to excel"
        Me.BtnExportToExcel_TH.UseVisualStyleBackColor = False
        '
        'LblFileLocation_TH
        '
        Me.LblFileLocation_TH.BackColor = System.Drawing.Color.Transparent
        Me.LblFileLocation_TH.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFileLocation_TH.ForeColor = System.Drawing.Color.White
        Me.LblFileLocation_TH.Location = New System.Drawing.Point(563, 30)
        Me.LblFileLocation_TH.Name = "LblFileLocation_TH"
        Me.LblFileLocation_TH.Size = New System.Drawing.Size(368, 55)
        Me.LblFileLocation_TH.TabIndex = 14
        Me.LblFileLocation_TH.Text = "File Location"
        Me.LblFileLocation_TH.Visible = False
        '
        'BtnExportNow_TH
        '
        Me.BtnExportNow_TH.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnExportNow_TH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportNow_TH.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportNow_TH.ForeColor = System.Drawing.Color.Black
        Me.BtnExportNow_TH.Location = New System.Drawing.Point(937, 50)
        Me.BtnExportNow_TH.Name = "BtnExportNow_TH"
        Me.BtnExportNow_TH.Size = New System.Drawing.Size(168, 35)
        Me.BtnExportNow_TH.TabIndex = 15
        Me.BtnExportNow_TH.Text = "Export now"
        Me.BtnExportNow_TH.UseVisualStyleBackColor = False
        Me.BtnExportNow_TH.Visible = False
        '
        'LblTextFileLocation
        '
        Me.LblTextFileLocation.AutoSize = True
        Me.LblTextFileLocation.BackColor = System.Drawing.Color.Transparent
        Me.LblTextFileLocation.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTextFileLocation.ForeColor = System.Drawing.Color.White
        Me.LblTextFileLocation.Location = New System.Drawing.Point(563, 16)
        Me.LblTextFileLocation.Name = "LblTextFileLocation"
        Me.LblTextFileLocation.Size = New System.Drawing.Size(81, 14)
        Me.LblTextFileLocation.TabIndex = 16
        Me.LblTextFileLocation.Text = "File Location:"
        Me.LblTextFileLocation.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Transaction History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Filters:"
        '
        'BtnFilters_TH
        '
        Me.BtnFilters_TH.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnFilters_TH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilters_TH.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFilters_TH.Location = New System.Drawing.Point(61, 55)
        Me.BtnFilters_TH.Name = "BtnFilters_TH"
        Me.BtnFilters_TH.Size = New System.Drawing.Size(149, 23)
        Me.BtnFilters_TH.TabIndex = 19
        Me.BtnFilters_TH.Text = "ALL"
        Me.BtnFilters_TH.UseVisualStyleBackColor = False
        '
        'frmTransactionHistory_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1117, 504)
        Me.Controls.Add(Me.BtnFilters_TH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTextFileLocation)
        Me.Controls.Add(Me.BtnExportNow_TH)
        Me.Controls.Add(Me.LblFileLocation_TH)
        Me.Controls.Add(Me.BtnExportToExcel_TH)
        Me.Controls.Add(Me.DgvTransactionHistory_Admin)
        Me.Name = "frmTransactionHistory_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransactionHistory_Admin"
        CType(Me.DgvTransactionHistory_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvTransactionHistory_Admin As DataGridView
    Friend WithEvents BtnExportToExcel_TH As Button
    Friend WithEvents LblFileLocation_TH As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnExportNow_TH As Button
    Friend WithEvents LblTextFileLocation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFilters_TH As Button
End Class
