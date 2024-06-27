<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnrollment))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEnrollmentOfficer = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SubjectCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubjectDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Teacher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboSY = New System.Windows.Forms.ComboBox()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDepartmentID = New System.Windows.Forms.Label()
        Me.lblSectionID = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtStudentType = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(446, 333)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "List View"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(81, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(838, 31)
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSection)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboSemester)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboDepartment)
        Me.GroupBox1.Controls.Add(Me.cboYearLevel)
        Me.GroupBox1.Controls.Add(Me.cboCourse)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 198)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrollment"
        '
        'cboSection
        '
        Me.cboSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(640, 109)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(171, 28)
        Me.cboSection.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(25, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "First Name"
        '
        'cboSemester
        '
        Me.cboSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(441, 109)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(171, 28)
        Me.cboSemester.TabIndex = 143
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(26, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(438, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLastName.Location = New System.Drawing.Point(25, 51)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(171, 26)
        Me.txtLastName.TabIndex = 93
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(25, 109)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(171, 26)
        Me.txtFirstName.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(438, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "Semester"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.White
        Me.txtMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMiddlename.Location = New System.Drawing.Point(441, 45)
        Me.txtMiddlename.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.ReadOnly = True
        Me.txtMiddlename.Size = New System.Drawing.Size(171, 26)
        Me.txtMiddlename.TabIndex = 99
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(227, 90)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Course"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(637, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 16)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Year Level"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(637, 90)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Section"
        '
        'cboDepartment
        '
        Me.cboDepartment.Enabled = False
        Me.cboDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cboDepartment.Location = New System.Drawing.Point(230, 45)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(171, 28)
        Me.cboDepartment.TabIndex = 108
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.cboYearLevel.Location = New System.Drawing.Point(640, 45)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(171, 28)
        Me.cboYearLevel.TabIndex = 104
        '
        'cboCourse
        '
        Me.cboCourse.Enabled = False
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cboCourse.Location = New System.Drawing.Point(230, 109)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(171, 28)
        Me.cboCourse.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(227, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Department"
        '
        'lblEnrollmentOfficer
        '
        Me.lblEnrollmentOfficer.AutoSize = True
        Me.lblEnrollmentOfficer.BackColor = System.Drawing.Color.White
        Me.lblEnrollmentOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblEnrollmentOfficer.Location = New System.Drawing.Point(447, 50)
        Me.lblEnrollmentOfficer.Name = "lblEnrollmentOfficer"
        Me.lblEnrollmentOfficer.Size = New System.Drawing.Size(11, 16)
        Me.lblEnrollmentOfficer.TabIndex = 170
        Me.lblEnrollmentOfficer.Text = "."
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.White
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.Location = New System.Drawing.Point(197, 50)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(11, 16)
        Me.lblDateTime.TabIndex = 168
        Me.lblDateTime.Text = "."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(81, 594)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 16)
        Me.Label34.TabIndex = 179
        Me.Label34.Text = "Units"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(308, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 16)
        Me.Label16.TabIndex = 169
        Me.Label16.Text = "Enrollment Officer:"
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.White
        Me.txtUnits.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(130, 589)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ReadOnly = True
        Me.txtUnits.Size = New System.Drawing.Size(79, 25)
        Me.txtUnits.TabIndex = 180
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(78, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 16)
        Me.Label14.TabIndex = 167
        Me.Label14.Text = "Date and Time:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubjectCode, Me.SubjectDescription, Me.Units, Me.ColumnHeader1, Me.ColumnHeader2, Me.Teacher, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(81, 357)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(838, 217)
        Me.ListView1.TabIndex = 181
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SubjectCode
        '
        Me.SubjectCode.Text = "Subject Code"
        Me.SubjectCode.Width = 200
        '
        'SubjectDescription
        '
        Me.SubjectDescription.Text = "Subject Description"
        Me.SubjectDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubjectDescription.Width = 300
        '
        'Units
        '
        Me.Units.Text = "Units"
        Me.Units.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Units.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Day"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time"
        Me.ColumnHeader2.Width = 200
        '
        'Teacher
        '
        Me.Teacher.Text = "Teacher"
        Me.Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Teacher.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LC"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Hrs"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Fee"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Total"
        Me.ColumnHeader8.Width = 120
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNew.Location = New System.Drawing.Point(473, 581)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(107, 43)
        Me.btnNew.TabIndex = 183
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(827, 297)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 27)
        Me.btnSearch.TabIndex = 178
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.BackColor = System.Drawing.Color.White
        Me.lblRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblRegNo.Location = New System.Drawing.Point(193, 306)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(12, 16)
        Me.lblRegNo.TabIndex = 182
        Me.lblRegNo.Text = "-"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Enabled = False
        Me.txtStudentNo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.Location = New System.Drawing.Point(687, 299)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(134, 23)
        Me.txtStudentNo.TabIndex = 177
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(603, 304)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(78, 16)
        Me.Label40.TabIndex = 176
        Me.Label40.Text = "Student ID"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(812, 580)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 43)
        Me.btnClose.TabIndex = 173
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'cboSY
        '
        Me.cboSY.BackColor = System.Drawing.Color.White
        Me.cboSY.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSY.Location = New System.Drawing.Point(809, 45)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(108, 27)
        Me.cboSY.TabIndex = 174
        '
        'btnEnroll
        '
        Me.btnEnroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnroll.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnroll.Location = New System.Drawing.Point(586, 581)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(107, 43)
        Me.btnEnroll.TabIndex = 172
        Me.btnEnroll.Text = "ENROLL STUDENT"
        Me.btnEnroll.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(770, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "S.Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Enrollment No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDepartmentID)
        Me.GroupBox3.Controls.Add(Me.lblSectionID)
        Me.GroupBox3.Controls.Add(Me.lblCourseID)
        Me.GroupBox3.Controls.Add(Me.txtStudentType)
        Me.GroupBox3.Location = New System.Drawing.Point(801, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(118, 116)
        Me.GroupBox3.TabIndex = 184
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ID"
        Me.GroupBox3.Visible = False
        '
        'lblDepartmentID
        '
        Me.lblDepartmentID.AutoSize = True
        Me.lblDepartmentID.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentID.Location = New System.Drawing.Point(5, 38)
        Me.lblDepartmentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartmentID.Name = "lblDepartmentID"
        Me.lblDepartmentID.Size = New System.Drawing.Size(108, 17)
        Me.lblDepartmentID.TabIndex = 155
        Me.lblDepartmentID.Text = "DepartmentID"
        '
        'lblSectionID
        '
        Me.lblSectionID.AutoSize = True
        Me.lblSectionID.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionID.Location = New System.Drawing.Point(5, 16)
        Me.lblSectionID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSectionID.Name = "lblSectionID"
        Me.lblSectionID.Size = New System.Drawing.Size(77, 17)
        Me.lblSectionID.TabIndex = 154
        Me.lblSectionID.Text = "SectionID"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.Location = New System.Drawing.Point(5, 66)
        Me.lblCourseID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(75, 17)
        Me.lblCourseID.TabIndex = 156
        Me.lblCourseID.Text = "CourseID"
        '
        'txtStudentType
        '
        Me.txtStudentType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtStudentType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentType.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentType.Location = New System.Drawing.Point(5, 85)
        Me.txtStudentType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentType.Name = "txtStudentType"
        Me.txtStudentType.ReadOnly = True
        Me.txtStudentType.Size = New System.Drawing.Size(108, 16)
        Me.txtStudentType.TabIndex = 162
        '
        'Timer1
        '
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(699, 581)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 43)
        Me.btnCancel.TabIndex = 188
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(999, 668)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEnrollmentOfficer)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.txtStudentNo)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboSY)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEnrollment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSection As ComboBox
    Public WithEvents Label7 As Label
    Friend WithEvents cboSemester As ComboBox
    Public WithEvents Label6 As Label
    Public WithEvents Label9 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Public WithEvents Label12 As Label
    Friend WithEvents txtMiddlename As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents Label15 As Label
    Public WithEvents Label17 As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Public WithEvents Label11 As Label
    Friend WithEvents lblEnrollmentOfficer As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SubjectCode As ColumnHeader
    Friend WithEvents SubjectDescription As ColumnHeader
    Friend WithEvents Units As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Teacher As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents cboSY As ComboBox
    Friend WithEvents btnEnroll As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents lblDepartmentID As Label
    Public WithEvents lblSectionID As Label
    Public WithEvents lblCourseID As Label
    Friend WithEvents txtStudentType As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCancel As Button
End Class
