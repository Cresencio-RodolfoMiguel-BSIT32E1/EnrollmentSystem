<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dean
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dean))
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnTeachers = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tssUsername = New System.Windows.Forms.Label()
        Me.tssRole = New System.Windows.Forms.Label()
        Me.tssDateTime = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSchedule.Location = New System.Drawing.Point(44, 371)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(156, 44)
        Me.btnSchedule.TabIndex = 23
        Me.btnSchedule.Text = "Scheduling"
        Me.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnTeachers
        '
        Me.btnTeachers.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeachers.FlatAppearance.BorderSize = 0
        Me.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeachers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTeachers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnTeachers.Location = New System.Drawing.Point(44, 298)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(156, 44)
        Me.btnTeachers.TabIndex = 22
        Me.btnTeachers.Text = "Teachers"
        Me.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeachers.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnSubjects
        '
        Me.btnSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubjects.FlatAppearance.BorderSize = 0
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSubjects.Location = New System.Drawing.Point(44, 159)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(156, 44)
        Me.btnSubjects.TabIndex = 11
        Me.btnSubjects.Text = "Subjects"
        Me.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubjects.UseVisualStyleBackColor = False
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblTeacher.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher.ForeColor = System.Drawing.Color.White
        Me.lblTeacher.Location = New System.Drawing.Point(430, 311)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(38, 42)
        Me.lblTeacher.TabIndex = 2
        Me.lblTeacher.Text = "0"
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnStudent.Location = New System.Drawing.Point(44, 226)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(156, 44)
        Me.btnStudent.TabIndex = 24
        Me.btnStudent.Text = "List of Students"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(250, 679)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(518, 679)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Role:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(946, 679)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Date/Time:"
        '
        'tssUsername
        '
        Me.tssUsername.AutoSize = True
        Me.tssUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssUsername.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssUsername.ForeColor = System.Drawing.Color.White
        Me.tssUsername.Location = New System.Drawing.Point(352, 679)
        Me.tssUsername.Name = "tssUsername"
        Me.tssUsername.Size = New System.Drawing.Size(13, 17)
        Me.tssUsername.TabIndex = 34
        Me.tssUsername.Text = "-"
        '
        'tssRole
        '
        Me.tssRole.AutoSize = True
        Me.tssRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssRole.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssRole.ForeColor = System.Drawing.Color.White
        Me.tssRole.Location = New System.Drawing.Point(575, 679)
        Me.tssRole.Name = "tssRole"
        Me.tssRole.Size = New System.Drawing.Size(13, 17)
        Me.tssRole.TabIndex = 35
        Me.tssRole.Text = "-"
        '
        'tssDateTime
        '
        Me.tssDateTime.AutoSize = True
        Me.tssDateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssDateTime.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssDateTime.ForeColor = System.Drawing.Color.White
        Me.tssDateTime.Location = New System.Drawing.Point(1048, 679)
        Me.tssDateTime.Name = "tssDateTime"
        Me.tssDateTime.Size = New System.Drawing.Size(13, 17)
        Me.tssDateTime.TabIndex = 36
        Me.tssDateTime.Text = "-"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(302, 262)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(302, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "No. of Registered Teachers"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(22, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "LYCEUM OF ALABANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(24, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 11)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Km 30 National Road Tunasan Muntinlupa City, NCR"
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
        Me.btnLogout.Location = New System.Drawing.Point(44, 611)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 44)
        Me.btnLogout.TabIndex = 40
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblTeacher)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 673)
        Me.Panel1.TabIndex = 41
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
        Me.btnActivityLogs.Location = New System.Drawing.Point(44, 437)
        Me.btnActivityLogs.Name = "btnActivityLogs"
        Me.btnActivityLogs.Size = New System.Drawing.Size(156, 44)
        Me.btnActivityLogs.TabIndex = 42
        Me.btnActivityLogs.Text = "Activity Logs"
        Me.btnActivityLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActivityLogs.UseVisualStyleBackColor = False
        '
        'Dean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1202, 700)
        Me.Controls.Add(Me.btnActivityLogs)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnTeachers)
        Me.Controls.Add(Me.tssDateTime)
        Me.Controls.Add(Me.tssRole)
        Me.Controls.Add(Me.tssUsername)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSubjects)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dean"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnTeachers As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSubjects As Button
    Friend WithEvents lblTeacher As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tssUsername As Label
    Friend WithEvents tssRole As Label
    Friend WithEvents tssDateTime As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnActivityLogs As Button
End Class
