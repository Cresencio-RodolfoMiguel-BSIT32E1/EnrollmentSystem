<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class financedashboard
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
        Me.btnstudentlist = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldatetime = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnactlogs = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstudentlist
        '
        Me.btnstudentlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnstudentlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstudentlist.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnstudentlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnstudentlist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnstudentlist.Location = New System.Drawing.Point(31, 159)
        Me.btnstudentlist.Name = "btnstudentlist"
        Me.btnstudentlist.Size = New System.Drawing.Size(175, 44)
        Me.btnstudentlist.TabIndex = 9
        Me.btnstudentlist.Text = "Assessed Students" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnstudentlist.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(24, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "LYCEUM OF ALABANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 11)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Km 30 National Road Tunasan Muntinlupa City, NCR"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblr.ForeColor = System.Drawing.SystemColors.Control
        Me.lblr.Location = New System.Drawing.Point(800, 675)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(32, 13)
        Me.lblr.TabIndex = 34
        Me.lblr.Text = "Role:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(487, 675)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "User :"
        '
        'lbldatetime
        '
        Me.lbldatetime.AutoSize = True
        Me.lbldatetime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lbldatetime.ForeColor = System.Drawing.SystemColors.Control
        Me.lbldatetime.Location = New System.Drawing.Point(244, 675)
        Me.lbldatetime.Name = "lbldatetime"
        Me.lbldatetime.Size = New System.Drawing.Size(33, 13)
        Me.lbldatetime.TabIndex = 32
        Me.lbldatetime.Text = "Time:"
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnlogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(39, 606)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(156, 44)
        Me.btnlogout.TabIndex = 35
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnactlogs
        '
        Me.btnactlogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnactlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactlogs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnactlogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnactlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactlogs.Location = New System.Drawing.Point(31, 225)
        Me.btnactlogs.Name = "btnactlogs"
        Me.btnactlogs.Size = New System.Drawing.Size(175, 44)
        Me.btnactlogs.TabIndex = 9
        Me.btnactlogs.Text = "Activity Logs"
        Me.btnactlogs.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Finance.My.Resources.Resources.Untitled_design__10_
        Me.Panel1.Location = New System.Drawing.Point(236, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 669)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Finance.My.Resources.Resources.DASHBOARD1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1198, 702)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltime.Location = New System.Drawing.Point(276, 675)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(27, 13)
        Me.lbltime.TabIndex = 32
        Me.lbltime.Text = "oras"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lbluser.ForeColor = System.Drawing.SystemColors.Control
        Me.lbluser.Location = New System.Drawing.Point(528, 675)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(53, 13)
        Me.lbluser.TabIndex = 33
        Me.lbluser.Text = "username"
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblrole.ForeColor = System.Drawing.SystemColors.Control
        Me.lblrole.Location = New System.Drawing.Point(838, 675)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(24, 13)
        Me.lblrole.TabIndex = 34
        Me.lblrole.Text = "role"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'financedashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 697)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldatetime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnactlogs)
        Me.Controls.Add(Me.btnstudentlist)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "financedashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "financedashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstudentlist As Button
    Public WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblr As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbldatetime As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnactlogs As Button
    Friend WithEvents lbltime As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lblrole As Label
    Friend WithEvents Timer1 As Timer
End Class
