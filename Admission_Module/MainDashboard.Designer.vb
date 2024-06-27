<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldatetime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnlist = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnlogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(39, 608)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(156, 44)
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(1081, 674)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admission Module"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "LYCEUM OF ALABANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(24, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 11)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Km 30 National Road Tunasan Muntinlupa City, NCR"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbldatetime
        '
        Me.lbldatetime.AutoSize = True
        Me.lbldatetime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lbldatetime.ForeColor = System.Drawing.SystemColors.Control
        Me.lbldatetime.Location = New System.Drawing.Point(246, 674)
        Me.lbldatetime.Name = "lbldatetime"
        Me.lbldatetime.Size = New System.Drawing.Size(30, 13)
        Me.lbldatetime.TabIndex = 1
        Me.lbldatetime.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(489, 674)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "User :"
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblrole.ForeColor = System.Drawing.SystemColors.Control
        Me.lblrole.Location = New System.Drawing.Point(530, 674)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(39, 13)
        Me.lblrole.TabIndex = 31
        Me.lblrole.Text = "Label5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Admission_Module.My.Resources.Resources.Untitled_design__10_3
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 671)
        Me.Panel1.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(757, 648)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnreport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnreport.Image = Global.Admission_Module.My.Resources.Resources.icons8_graph_report_30
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(39, 289)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(156, 44)
        Me.btnreport.TabIndex = 2
        Me.btnreport.Text = "Reports"
        Me.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnregister.Image = Global.Admission_Module.My.Resources.Resources.icons8_registration_30
        Me.btnregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregister.Location = New System.Drawing.Point(39, 159)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(156, 44)
        Me.btnregister.TabIndex = 0
        Me.btnregister.Text = "Registration"
        Me.btnregister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlist.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnlist.Image = Global.Admission_Module.My.Resources.Resources.icons8_applicant_30
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(39, 225)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(156, 44)
        Me.btnlist.TabIndex = 1
        Me.btnlist.Text = "Applicant List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1202, 696)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbldatetime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.btnlist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnregister As Button
    Friend WithEvents btnlist As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldatetime As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents lblrole As Label
End Class
