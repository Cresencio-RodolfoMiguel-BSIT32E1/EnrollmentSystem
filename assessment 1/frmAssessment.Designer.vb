<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssessment))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbosyear = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFullPay = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblUponEn = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboPayScheme = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOtherFee = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbOFee = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTotalAss = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblMiscFee = New System.Windows.Forms.Label()
        Me.lblLabFee = New System.Windows.Forms.Label()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTotalUnits = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.section = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subjcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subjtitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.day = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.teacher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAssess = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAssessOf = New System.Windows.Forms.Label()
        Me.lblRegNum = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Student Name"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(1098, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 42)
        Me.btnClose.TabIndex = 164
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 42)
        Me.Panel1.TabIndex = 166
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(2, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(149, 24)
        Me.Label20.TabIndex = 133
        Me.Label20.Text = "ASSESSMENT"
        '
        'cbosyear
        '
        Me.cbosyear.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosyear.Location = New System.Drawing.Point(377, 72)
        Me.cbosyear.Name = "cbosyear"
        Me.cbosyear.ReadOnly = True
        Me.cbosyear.Size = New System.Drawing.Size(120, 25)
        Me.cbosyear.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(282, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 18)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "School Year:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(89, 21)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(419, 25)
        Me.txtname.TabIndex = 166
        '
        'cboSection
        '
        Me.cboSection.Enabled = False
        Me.cboSection.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(377, 136)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(120, 24)
        Me.cboSection.TabIndex = 137
        '
        'cboSemester
        '
        Me.cboSemester.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(377, 105)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(120, 24)
        Me.cboSemester.TabIndex = 136
        '
        'cboCourse
        '
        Me.cboCourse.Enabled = False
        Me.cboCourse.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cboCourse.Location = New System.Drawing.Point(113, 106)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(120, 24)
        Me.cboCourse.TabIndex = 130
        '
        'cboDepartment
        '
        Me.cboDepartment.Enabled = False
        Me.cboDepartment.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cboDepartment.Location = New System.Drawing.Point(113, 76)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(120, 24)
        Me.cboDepartment.TabIndex = 129
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.cboYearLevel.Location = New System.Drawing.Point(113, 136)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(120, 24)
        Me.cboYearLevel.TabIndex = 125
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(18, 77)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 18)
        Me.Label30.TabIndex = 100
        Me.Label30.Text = "Department:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.cbosyear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboSection)
        Me.GroupBox2.Controls.Add(Me.cboSemester)
        Me.GroupBox2.Controls.Add(Me.cboCourse)
        Me.GroupBox2.Controls.Add(Me.cboDepartment)
        Me.GroupBox2.Controls.Add(Me.cboYearLevel)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(3, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 166)
        Me.GroupBox2.TabIndex = 165
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Informaton"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(282, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 18)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "Secton:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(282, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 18)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Semester:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(18, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "Year Level:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(18, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 18)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Course:"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Other Fee"
        Me.ColumnHeader3.Width = 160
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cboDiscount
        '
        Me.cboDiscount.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Items.AddRange(New Object() {"30%", "40%", "50%", "100%"})
        Me.cboDiscount.Location = New System.Drawing.Point(147, 137)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(122, 24)
        Me.cboDiscount.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.cboDiscount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblFullPay)
        Me.GroupBox1.Controls.Add(Me.lblMonthly)
        Me.GroupBox1.Controls.Add(Me.lblUponEn)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboPayScheme)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblOtherFee)
        Me.GroupBox1.Controls.Add(Me.ListView2)
        Me.GroupBox1.Controls.Add(Me.cbOFee)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.lblMiscFee)
        Me.GroupBox1.Controls.Add(Me.lblLabFee)
        Me.GroupBox1.Controls.Add(Me.lblTuition)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 386)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fees"
        '
        'lblFullPay
        '
        Me.lblFullPay.AutoSize = True
        Me.lblFullPay.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullPay.ForeColor = System.Drawing.Color.Black
        Me.lblFullPay.Location = New System.Drawing.Point(470, 297)
        Me.lblFullPay.Name = "lblFullPay"
        Me.lblFullPay.Size = New System.Drawing.Size(38, 22)
        Me.lblFullPay.TabIndex = 142
        Me.lblFullPay.Text = "0.00"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.ForeColor = System.Drawing.Color.Black
        Me.lblMonthly.Location = New System.Drawing.Point(270, 297)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(38, 22)
        Me.lblMonthly.TabIndex = 141
        Me.lblMonthly.Text = "0.00"
        '
        'lblUponEn
        '
        Me.lblUponEn.AutoSize = True
        Me.lblUponEn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUponEn.ForeColor = System.Drawing.Color.Black
        Me.lblUponEn.Location = New System.Drawing.Point(69, 297)
        Me.lblUponEn.Name = "lblUponEn"
        Me.lblUponEn.Size = New System.Drawing.Size(38, 22)
        Me.lblUponEn.TabIndex = 140
        Me.lblUponEn.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(435, 319)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 18)
        Me.Label25.TabIndex = 139
        Me.Label25.Text = "Full Payment:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(231, 319)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(138, 18)
        Me.Label24.TabIndex = 138
        Me.Label24.Text = "Monthy Payment:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(33, 319)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 18)
        Me.Label22.TabIndex = 137
        Me.Label22.Text = "Upon Enrollment:"
        '
        'cboPayScheme
        '
        Me.cboPayScheme.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayScheme.FormattingEnabled = True
        Me.cboPayScheme.Location = New System.Drawing.Point(156, 245)
        Me.cboPayScheme.Name = "cboPayScheme"
        Me.cboPayScheme.Size = New System.Drawing.Size(141, 26)
        Me.cboPayScheme.TabIndex = 135
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 18)
        Me.Label21.TabIndex = 134
        Me.Label21.Text = "Payment Scheme:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(485, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(462, 42)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(106, 25)
        Me.txtAmount.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(318, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Select Other Fees:"
        '
        'lblOtherFee
        '
        Me.lblOtherFee.AutoSize = True
        Me.lblOtherFee.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherFee.ForeColor = System.Drawing.Color.Black
        Me.lblOtherFee.Location = New System.Drawing.Point(156, 105)
        Me.lblOtherFee.Name = "lblOtherFee"
        Me.lblOtherFee.Size = New System.Drawing.Size(15, 22)
        Me.lblOtherFee.TabIndex = 110
        Me.lblOtherFee.Text = "-"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(296, 70)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(281, 118)
        Me.ListView2.TabIndex = 109
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 115
        '
        'cbOFee
        '
        Me.cbOFee.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOFee.FormattingEnabled = True
        Me.cbOFee.Location = New System.Drawing.Point(306, 40)
        Me.cbOFee.Name = "cbOFee"
        Me.cbOFee.Size = New System.Drawing.Size(141, 26)
        Me.cbOFee.TabIndex = 108
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblTotalAss)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Location = New System.Drawing.Point(0, 194)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(655, 42)
        Me.Panel4.TabIndex = 105
        '
        'lblTotalAss
        '
        Me.lblTotalAss.AutoSize = True
        Me.lblTotalAss.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAss.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAss.Location = New System.Drawing.Point(192, 11)
        Me.lblTotalAss.Name = "lblTotalAss"
        Me.lblTotalAss.Size = New System.Drawing.Size(18, 26)
        Me.lblTotalAss.TabIndex = 106
        Me.lblTotalAss.Text = "-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(6, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(180, 24)
        Me.Label23.TabIndex = 106
        Me.Label23.Text = "Total Assessment:"
        '
        'lblMiscFee
        '
        Me.lblMiscFee.AutoSize = True
        Me.lblMiscFee.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscFee.ForeColor = System.Drawing.Color.Black
        Me.lblMiscFee.Location = New System.Drawing.Point(156, 78)
        Me.lblMiscFee.Name = "lblMiscFee"
        Me.lblMiscFee.Size = New System.Drawing.Size(15, 22)
        Me.lblMiscFee.TabIndex = 101
        Me.lblMiscFee.Text = "-"
        '
        'lblLabFee
        '
        Me.lblLabFee.AutoSize = True
        Me.lblLabFee.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabFee.ForeColor = System.Drawing.Color.Black
        Me.lblLabFee.Location = New System.Drawing.Point(156, 52)
        Me.lblLabFee.Name = "lblLabFee"
        Me.lblLabFee.Size = New System.Drawing.Size(15, 22)
        Me.lblLabFee.TabIndex = 100
        Me.lblLabFee.Text = "-"
        '
        'lblTuition
        '
        Me.lblTuition.AutoSize = True
        Me.lblTuition.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuition.ForeColor = System.Drawing.Color.Black
        Me.lblTuition.Location = New System.Drawing.Point(156, 25)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(15, 22)
        Me.lblTuition.TabIndex = 99
        Me.lblTuition.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Other Fee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Miscellaneous Fee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Laboratory Fee"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 20)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Tuition Fee"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.Location = New System.Drawing.Point(149, 24)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(101, 23)
        Me.txtStudentNo.TabIndex = 181
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 548)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 125
        Me.Label19.Text = "Total Units:"
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.AutoSize = True
        Me.lblTotalUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUnits.ForeColor = System.Drawing.Color.Black
        Me.lblTotalUnits.Location = New System.Drawing.Point(103, 548)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(14, 20)
        Me.lblTotalUnits.TabIndex = 126
        Me.lblTotalUnits.Text = "."
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox7.Controls.Add(Me.txtStudentNo)
        Me.GroupBox7.Controls.Add(Me.btnSearch)
        Me.GroupBox7.Controls.Add(Me.ListView1)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.lblTotalUnits)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(592, 76)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(547, 572)
        Me.GroupBox7.TabIndex = 168
        Me.GroupBox7.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(256, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 23)
        Me.btnSearch.TabIndex = 180
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.section, Me.subjcode, Me.subjtitle, Me.units, Me.day, Me.Time, Me.teacher, Me.fee, Me.total})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(537, 474)
        Me.ListView1.TabIndex = 108
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'section
        '
        Me.section.Text = "Section"
        Me.section.Width = 130
        '
        'subjcode
        '
        Me.subjcode.Text = "Subject Code"
        Me.subjcode.Width = 110
        '
        'subjtitle
        '
        Me.subjtitle.Text = "Subject Title"
        Me.subjtitle.Width = 200
        '
        'units
        '
        Me.units.Text = "Units"
        Me.units.Width = 90
        '
        'day
        '
        Me.day.Text = "Day"
        Me.day.Width = 100
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 100
        '
        'teacher
        '
        Me.teacher.Text = "Teacher"
        Me.teacher.Width = 140
        '
        'fee
        '
        Me.fee.Text = "fee"
        Me.fee.Width = 1
        '
        'total
        '
        Me.total.Text = "total"
        Me.total.Width = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 18)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Student Number:"
        '
        'btnAssess
        '
        Me.btnAssess.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAssess.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAssess.FlatAppearance.BorderSize = 0
        Me.btnAssess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAssess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAssess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnAssess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAssess.Location = New System.Drawing.Point(984, 656)
        Me.btnAssess.Name = "btnAssess"
        Me.btnAssess.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAssess.Size = New System.Drawing.Size(155, 39)
        Me.btnAssess.TabIndex = 180
        Me.btnAssess.Text = "Pre-Assessment"
        Me.btnAssess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAssess.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.Location = New System.Drawing.Point(823, 656)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnUpdate.Size = New System.Drawing.Size(155, 39)
        Me.btnUpdate.TabIndex = 179
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(662, 656)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSave.Size = New System.Drawing.Size(155, 39)
        Me.btnSave.TabIndex = 178
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblAssessOf
        '
        Me.lblAssessOf.AutoSize = True
        Me.lblAssessOf.BackColor = System.Drawing.Color.Transparent
        Me.lblAssessOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssessOf.ForeColor = System.Drawing.Color.Black
        Me.lblAssessOf.Location = New System.Drawing.Point(161, 698)
        Me.lblAssessOf.Name = "lblAssessOf"
        Me.lblAssessOf.Size = New System.Drawing.Size(14, 20)
        Me.lblAssessOf.TabIndex = 176
        Me.lblAssessOf.Text = "."
        '
        'lblRegNum
        '
        Me.lblRegNum.AutoSize = True
        Me.lblRegNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRegNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNum.ForeColor = System.Drawing.Color.Black
        Me.lblRegNum.Location = New System.Drawing.Point(177, 49)
        Me.lblRegNum.Name = "lblRegNum"
        Me.lblRegNum.Size = New System.Drawing.Size(68, 18)
        Me.lblRegNum.TabIndex = 170
        Me.lblRegNum.Text = "0000-00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(1, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 18)
        Me.Label18.TabIndex = 169
        Me.Label18.Text = "Registration Number: "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(3, 698)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(152, 20)
        Me.Label27.TabIndex = 175
        Me.Label27.Text = "Assessment Officer:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(58, 677)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(14, 20)
        Me.lblTime.TabIndex = 174
        Me.lblTime.Text = "."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(3, 677)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 20)
        Me.Label26.TabIndex = 173
        Me.Label26.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(57, 656)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(14, 20)
        Me.lblDate.TabIndex = 172
        Me.lblDate.Text = "."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(2, 656)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 20)
        Me.Label28.TabIndex = 171
        Me.Label28.Text = "Date:"
        '
        'frmAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1148, 722)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.btnAssess)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblAssessOf)
        Me.Controls.Add(Me.lblRegNum)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label28)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAssessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAssessment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents cbosyear As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cboDiscount As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFullPay As Label
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblUponEn As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cboPayScheme As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOtherFee As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cbOFee As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalAss As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblMiscFee As Label
    Friend WithEvents lblLabFee As Label
    Friend WithEvents lblTuition As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblTotalUnits As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents section As ColumnHeader
    Friend WithEvents subjcode As ColumnHeader
    Friend WithEvents subjtitle As ColumnHeader
    Friend WithEvents units As ColumnHeader
    Friend WithEvents day As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents teacher As ColumnHeader
    Friend WithEvents fee As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAssess As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblAssessOf As Label
    Friend WithEvents lblRegNum As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label28 As Label
End Class
