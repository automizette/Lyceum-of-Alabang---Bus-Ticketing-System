<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckFeedback))
        Me.DgvFeedbackList = New System.Windows.Forms.DataGridView()
        Me.LblTitle_FB = New System.Windows.Forms.Label()
        Me.LblDesc_FB = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblFeedbackNumber = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblFullName_FB = New System.Windows.Forms.Label()
        Me.LblDateSub_FB = New System.Windows.Forms.Label()
        Me.LblType_FB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbFeedbackAttached = New System.Windows.Forms.PictureBox()
        Me.BtnClearFeedback = New System.Windows.Forms.Button()
        Me.BtnFilters = New System.Windows.Forms.Button()
        CType(Me.DgvFeedbackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbFeedbackAttached, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvFeedbackList
        '
        Me.DgvFeedbackList.AllowUserToAddRows = False
        Me.DgvFeedbackList.AllowUserToDeleteRows = False
        Me.DgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFeedbackList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvFeedbackList.BackgroundColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvFeedbackList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFeedbackList.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvFeedbackList.EnableHeadersVisualStyles = False
        Me.DgvFeedbackList.GridColor = System.Drawing.Color.Black
        Me.DgvFeedbackList.Location = New System.Drawing.Point(6, 52)
        Me.DgvFeedbackList.MultiSelect = False
        Me.DgvFeedbackList.Name = "DgvFeedbackList"
        Me.DgvFeedbackList.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(101, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFeedbackList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvFeedbackList.RowTemplate.Height = 40
        Me.DgvFeedbackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFeedbackList.Size = New System.Drawing.Size(282, 533)
        Me.DgvFeedbackList.TabIndex = 5
        '
        'LblTitle_FB
        '
        Me.LblTitle_FB.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblTitle_FB.Font = New System.Drawing.Font("Raleway ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle_FB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.LblTitle_FB.Location = New System.Drawing.Point(294, 125)
        Me.LblTitle_FB.Name = "LblTitle_FB"
        Me.LblTitle_FB.Size = New System.Drawing.Size(383, 68)
        Me.LblTitle_FB.TabIndex = 6
        Me.LblTitle_FB.Text = "Title"
        Me.LblTitle_FB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblDesc_FB
        '
        Me.LblDesc_FB.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblDesc_FB.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc_FB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.LblDesc_FB.Location = New System.Drawing.Point(294, 193)
        Me.LblDesc_FB.Name = "LblDesc_FB"
        Me.LblDesc_FB.Size = New System.Drawing.Size(383, 392)
        Me.LblDesc_FB.TabIndex = 7
        Me.LblDesc_FB.Text = "Description"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblFeedbackNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblFullName_FB)
        Me.GroupBox1.Controls.Add(Me.LblDateSub_FB)
        Me.GroupBox1.Controls.Add(Me.LblType_FB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Raleway SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(293, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 106)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Feedback Information:"
        '
        'LblFeedbackNumber
        '
        Me.LblFeedbackNumber.AutoSize = True
        Me.LblFeedbackNumber.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFeedbackNumber.Location = New System.Drawing.Point(106, 84)
        Me.LblFeedbackNumber.Name = "LblFeedbackNumber"
        Me.LblFeedbackNumber.Size = New System.Drawing.Size(71, 15)
        Me.LblFeedbackNumber.TabIndex = 7
        Me.LblFeedbackNumber.Text = "00000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Feedback No.:"
        '
        'LblFullName_FB
        '
        Me.LblFullName_FB.AutoSize = True
        Me.LblFullName_FB.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFullName_FB.Location = New System.Drawing.Point(114, 19)
        Me.LblFullName_FB.Name = "LblFullName_FB"
        Me.LblFullName_FB.Size = New System.Drawing.Size(70, 15)
        Me.LblFullName_FB.TabIndex = 5
        Me.LblFullName_FB.Text = "Full Name"
        '
        'LblDateSub_FB
        '
        Me.LblDateSub_FB.AutoSize = True
        Me.LblDateSub_FB.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateSub_FB.Location = New System.Drawing.Point(114, 40)
        Me.LblDateSub_FB.Name = "LblDateSub_FB"
        Me.LblDateSub_FB.Size = New System.Drawing.Size(101, 15)
        Me.LblDateSub_FB.TabIndex = 4
        Me.LblDateSub_FB.Text = "MM/DD/YYYY"
        '
        'LblType_FB
        '
        Me.LblType_FB.AutoSize = True
        Me.LblType_FB.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType_FB.Location = New System.Drawing.Point(54, 62)
        Me.LblType_FB.Name = "LblType_FB"
        Me.LblType_FB.Size = New System.Drawing.Size(37, 15)
        Me.LblType_FB.TabIndex = 3
        Me.LblType_FB.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date Submitted:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name of sender:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(680, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Image attached:"
        '
        'PbFeedbackAttached
        '
        Me.PbFeedbackAttached.InitialImage = CType(resources.GetObject("PbFeedbackAttached.InitialImage"), System.Drawing.Image)
        Me.PbFeedbackAttached.Location = New System.Drawing.Point(683, 27)
        Me.PbFeedbackAttached.Name = "PbFeedbackAttached"
        Me.PbFeedbackAttached.Size = New System.Drawing.Size(338, 209)
        Me.PbFeedbackAttached.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFeedbackAttached.TabIndex = 10
        Me.PbFeedbackAttached.TabStop = False
        '
        'BtnClearFeedback
        '
        Me.BtnClearFeedback.BackColor = System.Drawing.Color.IndianRed
        Me.BtnClearFeedback.Enabled = False
        Me.BtnClearFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearFeedback.Font = New System.Drawing.Font("Raleway ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearFeedback.Location = New System.Drawing.Point(682, 533)
        Me.BtnClearFeedback.Name = "BtnClearFeedback"
        Me.BtnClearFeedback.Size = New System.Drawing.Size(338, 52)
        Me.BtnClearFeedback.TabIndex = 11
        Me.BtnClearFeedback.Text = "Clear this Feedback"
        Me.BtnClearFeedback.UseVisualStyleBackColor = False
        '
        'BtnFilters
        '
        Me.BtnFilters.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilters.Font = New System.Drawing.Font("Raleway Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFilters.Location = New System.Drawing.Point(55, 12)
        Me.BtnFilters.Name = "BtnFilters"
        Me.BtnFilters.Size = New System.Drawing.Size(137, 26)
        Me.BtnFilters.TabIndex = 12
        Me.BtnFilters.Text = "Suggestions"
        Me.BtnFilters.UseVisualStyleBackColor = False
        '
        'frmCheckFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1032, 597)
        Me.Controls.Add(Me.BtnFilters)
        Me.Controls.Add(Me.BtnClearFeedback)
        Me.Controls.Add(Me.PbFeedbackAttached)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblDesc_FB)
        Me.Controls.Add(Me.LblTitle_FB)
        Me.Controls.Add(Me.DgvFeedbackList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCheckFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Feedback"
        CType(Me.DgvFeedbackList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbFeedbackAttached, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvFeedbackList As DataGridView
    Friend WithEvents LblTitle_FB As Label
    Friend WithEvents LblDesc_FB As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblFullName_FB As Label
    Friend WithEvents LblDateSub_FB As Label
    Friend WithEvents LblType_FB As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PbFeedbackAttached As PictureBox
    Friend WithEvents BtnClearFeedback As Button
    Friend WithEvents LblFeedbackNumber As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnFilters As Button
End Class
