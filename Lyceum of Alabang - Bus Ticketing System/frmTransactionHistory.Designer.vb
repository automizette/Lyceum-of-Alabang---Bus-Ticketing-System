<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactionHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionHistory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnChangeFilter = New System.Windows.Forms.Button()
        Me.DgvTransactionHistory = New System.Windows.Forms.DataGridView()
        Me.PbTransactionList = New System.Windows.Forms.PictureBox()
        CType(Me.DgvTransactionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbTransactionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaction History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "For user:"
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.BackColor = System.Drawing.Color.Transparent
        Me.LblFullName.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName.ForeColor = System.Drawing.Color.White
        Me.LblFullName.Location = New System.Drawing.Point(81, 58)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(70, 15)
        Me.LblFullName.TabIndex = 3
        Me.LblFullName.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1029, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Filter:"
        '
        'BtnChangeFilter
        '
        Me.BtnChangeFilter.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnChangeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangeFilter.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangeFilter.Location = New System.Drawing.Point(891, 48)
        Me.BtnChangeFilter.Name = "BtnChangeFilter"
        Me.BtnChangeFilter.Size = New System.Drawing.Size(191, 34)
        Me.BtnChangeFilter.TabIndex = 5
        Me.BtnChangeFilter.Text = "Transportation"
        Me.BtnChangeFilter.UseVisualStyleBackColor = False
        '
        'DgvTransactionHistory
        '
        Me.DgvTransactionHistory.AllowUserToAddRows = False
        Me.DgvTransactionHistory.AllowUserToDeleteRows = False
        Me.DgvTransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTransactionHistory.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvTransactionHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTransactionHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTransactionHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTransactionHistory.Location = New System.Drawing.Point(17, 121)
        Me.DgvTransactionHistory.Name = "DgvTransactionHistory"
        Me.DgvTransactionHistory.ReadOnly = True
        Me.DgvTransactionHistory.Size = New System.Drawing.Size(1065, 401)
        Me.DgvTransactionHistory.TabIndex = 6
        '
        'PbTransactionList
        '
        Me.PbTransactionList.BackColor = System.Drawing.Color.Transparent
        Me.PbTransactionList.Enabled = False
        Me.PbTransactionList.Image = CType(resources.GetObject("PbTransactionList.Image"), System.Drawing.Image)
        Me.PbTransactionList.InitialImage = CType(resources.GetObject("PbTransactionList.InitialImage"), System.Drawing.Image)
        Me.PbTransactionList.Location = New System.Drawing.Point(13, 9)
        Me.PbTransactionList.Name = "PbTransactionList"
        Me.PbTransactionList.Size = New System.Drawing.Size(45, 42)
        Me.PbTransactionList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbTransactionList.TabIndex = 7
        Me.PbTransactionList.TabStop = False
        '
        'frmTransactionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1094, 534)
        Me.Controls.Add(Me.PbTransactionList)
        Me.Controls.Add(Me.DgvTransactionHistory)
        Me.Controls.Add(Me.BtnChangeFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransactionHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransactionHistory"
        CType(Me.DgvTransactionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbTransactionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnChangeFilter As Button
    Friend WithEvents DgvTransactionHistory As DataGridView
    Friend WithEvents PbTransactionList As PictureBox
End Class
