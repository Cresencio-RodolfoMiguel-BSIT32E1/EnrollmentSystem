<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        Me.btnSection = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSubjects = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tssUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tssRole = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tssDateTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSY = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSection
        '
        Me.btnSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSection.FlatAppearance.BorderSize = 0
        Me.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSection.Image = CType(resources.GetObject("btnSection.Image"), System.Drawing.Image)
        Me.btnSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSection.Location = New System.Drawing.Point(44, 138)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(156, 44)
        Me.btnSection.TabIndex = 28
        Me.btnSection.Text = "Sections"
        Me.btnSection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSection.UseVisualStyleBackColor = False
        '
        'btnEnrollment
        '
        Me.btnEnrollment.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEnrollment.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnrollment.FlatAppearance.BorderSize = 0
        Me.btnEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnEnrollment.Location = New System.Drawing.Point(44, 522)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(156, 44)
        Me.btnEnrollment.TabIndex = 27
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.UseVisualStyleBackColor = False
        '
        'btnActivityLogs
        '
        Me.btnActivityLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActivityLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnActivityLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivityLogs.FlatAppearance.BorderSize = 0
        Me.btnActivityLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivityLogs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnActivityLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnActivityLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivityLogs.Location = New System.Drawing.Point(44, 291)
        Me.btnActivityLogs.Name = "btnActivityLogs"
        Me.btnActivityLogs.Size = New System.Drawing.Size(156, 44)
        Me.btnActivityLogs.TabIndex = 26
        Me.btnActivityLogs.Text = "Activity Logs"
        Me.btnActivityLogs.UseVisualStyleBackColor = False
        '
        'btnSubjects
        '
        Me.btnSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubjects.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSubjects.FlatAppearance.BorderSize = 0
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSubjects.Image = CType(resources.GetObject("btnSubjects.Image"), System.Drawing.Image)
        Me.btnSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubjects.Location = New System.Drawing.Point(44, 238)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(156, 44)
        Me.btnSubjects.TabIndex = 24
        Me.btnSubjects.Text = "Subjects"
        Me.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubjects.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnStudent.Image = CType(resources.GetObject("btnStudent.Image"), System.Drawing.Image)
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(44, 188)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(156, 44)
        Me.btnStudent.TabIndex = 25
        Me.btnStudent.Text = "Students"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(44, 606)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 44)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblStudentNumber.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumber.ForeColor = System.Drawing.Color.White
        Me.lblStudentNumber.Location = New System.Drawing.Point(765, 312)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(38, 42)
        Me.lblStudentNumber.TabIndex = 2
        Me.lblStudentNumber.Text = "0"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(641, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 28)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "No. of Registered Student"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(22, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(293, 28)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Active School Year"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubjects
        '
        Me.lblSubjects.AutoSize = True
        Me.lblSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblSubjects.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjects.ForeColor = System.Drawing.Color.White
        Me.lblSubjects.Location = New System.Drawing.Point(455, 312)
        Me.lblSubjects.Name = "lblSubjects"
        Me.lblSubjects.Size = New System.Drawing.Size(38, 42)
        Me.lblSubjects.TabIndex = 3
        Me.lblSubjects.Text = "0"
        Me.lblSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(331, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(293, 28)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "No. of Subjects"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(247, 677)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Username:"
        '
        'tssUsername
        '
        Me.tssUsername.AutoSize = True
        Me.tssUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssUsername.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssUsername.ForeColor = System.Drawing.Color.White
        Me.tssUsername.Location = New System.Drawing.Point(336, 676)
        Me.tssUsername.Name = "tssUsername"
        Me.tssUsername.Size = New System.Drawing.Size(13, 17)
        Me.tssUsername.TabIndex = 30
        Me.tssUsername.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(494, 677)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Role:"
        '
        'tssRole
        '
        Me.tssRole.AutoSize = True
        Me.tssRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssRole.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssRole.ForeColor = System.Drawing.Color.White
        Me.tssRole.Location = New System.Drawing.Point(544, 677)
        Me.tssRole.Name = "tssRole"
        Me.tssRole.Size = New System.Drawing.Size(13, 17)
        Me.tssRole.TabIndex = 32
        Me.tssRole.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(913, 677)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Date/Time:"
        '
        'tssDateTime
        '
        Me.tssDateTime.AutoSize = True
        Me.tssDateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssDateTime.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssDateTime.ForeColor = System.Drawing.Color.White
        Me.tssDateTime.Location = New System.Drawing.Point(1008, 677)
        Me.tssDateTime.Name = "tssDateTime"
        Me.tssDateTime.Size = New System.Drawing.Size(13, 17)
        Me.tssDateTime.TabIndex = 34
        Me.tssDateTime.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.lblSemester)
        Me.Panel1.Controls.Add(Me.lblSY)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblStudentNumber)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblSubjects)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(239, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 671)
        Me.Panel1.TabIndex = 35
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblSemester.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.White
        Me.lblSemester.Location = New System.Drawing.Point(113, 331)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(100, 23)
        Me.lblSemester.TabIndex = 28
        Me.lblSemester.Text = "Semester"
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblSY.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.ForeColor = System.Drawing.Color.White
        Me.lblSY.Location = New System.Drawing.Point(113, 309)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(105, 23)
        Me.lblSY.TabIndex = 8
        Me.lblSY.Text = "2023-2024"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(22, 263)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(641, 263)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(331, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "LYCEUM OF ALABANG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 11)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Km 30 National Road Tunasan Muntinlupa City, NCR"
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1202, 700)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tssDateTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tssRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tssUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnActivityLogs)
        Me.Controls.Add(Me.btnSection)
        Me.Controls.Add(Me.btnEnrollment)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSubjects)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSection As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents btnSubjects As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblSubjects As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tssUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tssRole As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tssDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSY As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblSemester As Label
End Class
