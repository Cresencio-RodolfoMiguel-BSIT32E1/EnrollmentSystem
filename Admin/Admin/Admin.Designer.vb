<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btnManage = New System.Windows.Forms.Button()
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tssUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tssRole = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tssDateTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnManageSY = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnManage
        '
        Me.btnManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManage.Location = New System.Drawing.Point(44, 188)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(156, 44)
        Me.btnManage.TabIndex = 22
        Me.btnManage.Text = "Manage Users"
        Me.btnManage.UseVisualStyleBackColor = False
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
        Me.btnActivityLogs.Location = New System.Drawing.Point(44, 138)
        Me.btnActivityLogs.Name = "btnActivityLogs"
        Me.btnActivityLogs.Size = New System.Drawing.Size(156, 44)
        Me.btnActivityLogs.TabIndex = 21
        Me.btnActivityLogs.Text = "Activity Logs"
        Me.btnActivityLogs.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(44, 603)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 44)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblUsers.Font = New System.Drawing.Font("Rockwell", 27.75!)
        Me.lblUsers.ForeColor = System.Drawing.Color.White
        Me.lblUsers.Location = New System.Drawing.Point(282, 315)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(38, 42)
        Me.lblUsers.TabIndex = 2
        Me.lblUsers.Text = "0"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(156, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 28)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "No. of Users"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(464, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(276, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "2023-2024 Second Semester"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(241, 675)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Username:"
        '
        'tssUsername
        '
        Me.tssUsername.AutoSize = True
        Me.tssUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssUsername.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssUsername.ForeColor = System.Drawing.Color.White
        Me.tssUsername.Location = New System.Drawing.Point(330, 675)
        Me.tssUsername.Name = "tssUsername"
        Me.tssUsername.Size = New System.Drawing.Size(13, 17)
        Me.tssUsername.TabIndex = 24
        Me.tssUsername.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(524, 675)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Role:"
        '
        'tssRole
        '
        Me.tssRole.AutoSize = True
        Me.tssRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssRole.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssRole.ForeColor = System.Drawing.Color.White
        Me.tssRole.Location = New System.Drawing.Point(574, 675)
        Me.tssRole.Name = "tssRole"
        Me.tssRole.Size = New System.Drawing.Size(13, 17)
        Me.tssRole.TabIndex = 26
        Me.tssRole.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(915, 675)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date/Time"
        '
        'tssDateTime
        '
        Me.tssDateTime.AutoSize = True
        Me.tssDateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tssDateTime.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.tssDateTime.ForeColor = System.Drawing.Color.White
        Me.tssDateTime.Location = New System.Drawing.Point(1005, 675)
        Me.tssDateTime.Name = "tssDateTime"
        Me.tssDateTime.Size = New System.Drawing.Size(13, 17)
        Me.tssDateTime.TabIndex = 28
        Me.tssDateTime.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(156, 270)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(455, 270)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 119)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(455, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 28)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Active School Year"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblUsers)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(241, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 672)
        Me.Panel1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "LYCEUM OF ALABANG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(26, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 11)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Km 30 National Road Tunasan Muntinlupa City, NCR"
        '
        'btnManageSY
        '
        Me.btnManageSY.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnManageSY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnManageSY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageSY.FlatAppearance.BorderSize = 0
        Me.btnManageSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageSY.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageSY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnManageSY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageSY.Location = New System.Drawing.Point(44, 238)
        Me.btnManageSY.Name = "btnManageSY"
        Me.btnManageSY.Size = New System.Drawing.Size(156, 44)
        Me.btnManageSY.TabIndex = 35
        Me.btnManageSY.Text = "Manage  S.Y"
        Me.btnManageSY.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1199, 697)
        Me.Controls.Add(Me.btnManageSY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tssDateTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tssRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tssUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnActivityLogs)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnManage)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminDashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnManage As Button
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblUsers As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tssUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tssRole As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tssDateTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnManageSY As Button
End Class
