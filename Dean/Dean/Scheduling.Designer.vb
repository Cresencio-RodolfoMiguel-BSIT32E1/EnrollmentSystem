<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scheduling
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scheduling))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboSY = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSubjectCode = New System.Windows.Forms.ComboBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cbxS = New System.Windows.Forms.CheckBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.cboProf = New System.Windows.Forms.ComboBox()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboTime2 = New System.Windows.Forms.ComboBox()
        Me.cboTime1 = New System.Windows.Forms.ComboBox()
        Me.cbxF = New System.Windows.Forms.CheckBox()
        Me.cbxTH = New System.Windows.Forms.CheckBox()
        Me.cbxW = New System.Windows.Forms.CheckBox()
        Me.cbxT = New System.Windows.Forms.CheckBox()
        Me.cbxM = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblSchedNo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(46, 381)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(838, 217)
        Me.ListView1.TabIndex = 200
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject Code"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject Description"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Units"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Teacher"
        Me.ColumnHeader4.Width = 200
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(547, 603)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 43)
        Me.Button2.TabIndex = 207
        Me.Button2.Text = "REMOVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(433, 603)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 43)
        Me.btnAdd.TabIndex = 206
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboSY
        '
        Me.cboSY.BackColor = System.Drawing.Color.DarkGray
        Me.cboSY.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.Location = New System.Drawing.Point(776, 13)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(108, 27)
        Me.cboSY.TabIndex = 204
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(737, 17)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 19)
        Me.Label38.TabIndex = 205
        Me.Label38.Text = "S.Y"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(775, 603)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 43)
        Me.btnCancel.TabIndex = 203
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(661, 603)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 43)
        Me.btnUpdate.TabIndex = 202
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cboSubjectCode)
        Me.GroupBox1.Controls.Add(Me.cboSection)
        Me.GroupBox1.Controls.Add(Me.cbxS)
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.cboProf)
        Me.GroupBox1.Controls.Add(Me.cboSemester)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.cboYearLevel)
        Me.GroupBox1.Controls.Add(Me.cboCourse)
        Me.GroupBox1.Controls.Add(Me.cboDept)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cboTime2)
        Me.GroupBox1.Controls.Add(Me.cboTime1)
        Me.GroupBox1.Controls.Add(Me.cbxF)
        Me.GroupBox1.Controls.Add(Me.cbxTH)
        Me.GroupBox1.Controls.Add(Me.cbxW)
        Me.GroupBox1.Controls.Add(Me.cbxT)
        Me.GroupBox1.Controls.Add(Me.cbxM)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(838, 271)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        '
        'cboSubjectCode
        '
        Me.cboSubjectCode.BackColor = System.Drawing.Color.White
        Me.cboSubjectCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboSubjectCode.FormattingEnabled = True
        Me.cboSubjectCode.Location = New System.Drawing.Point(540, 164)
        Me.cboSubjectCode.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSubjectCode.Name = "cboSubjectCode"
        Me.cboSubjectCode.Size = New System.Drawing.Size(184, 21)
        Me.cboSubjectCode.TabIndex = 195
        '
        'cboSection
        '
        Me.cboSection.BackColor = System.Drawing.Color.White
        Me.cboSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(116, 71)
        Me.cboSection.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(183, 21)
        Me.cboSection.TabIndex = 194
        '
        'cbxS
        '
        Me.cbxS.AutoSize = True
        Me.cbxS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxS.Location = New System.Drawing.Point(264, 243)
        Me.cbxS.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxS.Name = "cbxS"
        Me.cbxS.Size = New System.Drawing.Size(34, 17)
        Me.cbxS.TabIndex = 193
        Me.cbxS.Text = "S"
        Me.cbxS.UseVisualStyleBackColor = True
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.White
        Me.txtUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUnits.Location = New System.Drawing.Point(540, 117)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(184, 20)
        Me.txtUnits.TabIndex = 192
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboProf
        '
        Me.cboProf.BackColor = System.Drawing.Color.White
        Me.cboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboProf.FormattingEnabled = True
        Me.cboProf.Location = New System.Drawing.Point(540, 71)
        Me.cboProf.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProf.Name = "cboProf"
        Me.cboProf.Size = New System.Drawing.Size(184, 21)
        Me.cboProf.TabIndex = 189
        '
        'cboSemester
        '
        Me.cboSemester.BackColor = System.Drawing.Color.White
        Me.cboSemester.Enabled = False
        Me.cboSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(116, 117)
        Me.cboSemester.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(183, 21)
        Me.cboSemester.TabIndex = 187
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(113, 52)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "Section"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(112, 145)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 184
        Me.Label16.Text = "Course"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(329, 164)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription.TabIndex = 181
        Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboYearLevel
        '
        Me.cboYearLevel.BackColor = System.Drawing.Color.White
        Me.cboYearLevel.Enabled = False
        Me.cboYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(329, 117)
        Me.cboYearLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(184, 21)
        Me.cboYearLevel.TabIndex = 178
        '
        'cboCourse
        '
        Me.cboCourse.BackColor = System.Drawing.Color.White
        Me.cboCourse.Enabled = False
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cboCourse.Location = New System.Drawing.Point(115, 164)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(184, 21)
        Me.cboCourse.TabIndex = 177
        '
        'cboDept
        '
        Me.cboDept.BackColor = System.Drawing.Color.White
        Me.cboDept.Enabled = False
        Me.cboDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(329, 71)
        Me.cboDept.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(184, 21)
        Me.cboDept.TabIndex = 176
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(683, 237)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "-"
        '
        'cboTime2
        '
        Me.cboTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTime2.FormattingEnabled = True
        Me.cboTime2.Items.AddRange(New Object() {"7:00 am", "7:30 am", "8:00 am", "8:30 am", "9:00 am", "9:30 am", "10:00 am", "10:30 am", "11:00 am", "11:30 am", "12:00 pm", "12:30 pm", "1:00 pm", "1:30 pm", "2:00 pm", "2:30 pm", "3:00 pm", "3:30 pm", "4:00 pm", "4:30 pm", "5:00 pm", "5:30 pm", "6:00 pm", "6:30 pm", "7:00 pm", "7:30 pm", "8:00 pm", "8:30 pm", "9:00 pm", "9:30 pm", "10:00 pm"})
        Me.cboTime2.Location = New System.Drawing.Point(700, 237)
        Me.cboTime2.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTime2.Name = "cboTime2"
        Me.cboTime2.Size = New System.Drawing.Size(123, 21)
        Me.cboTime2.TabIndex = 162
        '
        'cboTime1
        '
        Me.cboTime1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTime1.FormattingEnabled = True
        Me.cboTime1.Items.AddRange(New Object() {"7:00 am", "7:30 am", "8:00 am", "8:30 am", "9:00 am", "9:30 am", "10:00 am", "10:30 am", "11:00 am", "11:30 am", "12:00 pm", "12:30 pm", "1:00 pm", "1:30 pm", "2:00 pm", "2:30 pm", "3:00 pm", "3:30 pm", "4:00 pm", "4:30 pm", "5:00 pm", "5:30 pm", "6:00 pm", "6:30 pm", "7:00 pm", "7:30 pm", "8:00 pm", "8:30 pm", "9:00 pm", "9:30 pm", "10:00 pm"})
        Me.cboTime1.Location = New System.Drawing.Point(556, 237)
        Me.cboTime1.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTime1.Name = "cboTime1"
        Me.cboTime1.Size = New System.Drawing.Size(123, 21)
        Me.cboTime1.TabIndex = 161
        '
        'cbxF
        '
        Me.cbxF.AutoSize = True
        Me.cbxF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxF.Location = New System.Drawing.Point(227, 243)
        Me.cbxF.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxF.Name = "cbxF"
        Me.cbxF.Size = New System.Drawing.Size(33, 17)
        Me.cbxF.TabIndex = 160
        Me.cbxF.Text = "F"
        Me.cbxF.UseVisualStyleBackColor = True
        '
        'cbxTH
        '
        Me.cbxTH.AutoSize = True
        Me.cbxTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxTH.Location = New System.Drawing.Point(179, 243)
        Me.cbxTH.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTH.Name = "cbxTH"
        Me.cbxTH.Size = New System.Drawing.Size(43, 17)
        Me.cbxTH.TabIndex = 159
        Me.cbxTH.Text = "TH"
        Me.cbxTH.UseVisualStyleBackColor = True
        '
        'cbxW
        '
        Me.cbxW.AutoSize = True
        Me.cbxW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxW.Location = New System.Drawing.Point(140, 243)
        Me.cbxW.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxW.Name = "cbxW"
        Me.cbxW.Size = New System.Drawing.Size(38, 17)
        Me.cbxW.TabIndex = 158
        Me.cbxW.Text = "W"
        Me.cbxW.UseVisualStyleBackColor = True
        '
        'cbxT
        '
        Me.cbxT.AutoSize = True
        Me.cbxT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxT.Location = New System.Drawing.Point(102, 243)
        Me.cbxT.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxT.Name = "cbxT"
        Me.cbxT.Size = New System.Drawing.Size(34, 17)
        Me.cbxT.TabIndex = 157
        Me.cbxT.Text = "T"
        Me.cbxT.UseVisualStyleBackColor = True
        '
        'cbxM
        '
        Me.cbxM.AutoSize = True
        Me.cbxM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxM.Location = New System.Drawing.Point(59, 243)
        Me.cbxM.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxM.Name = "cbxM"
        Me.cbxM.Size = New System.Drawing.Size(36, 17)
        Me.cbxM.TabIndex = 156
        Me.cbxM.Text = "M"
        Me.cbxM.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(555, 221)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "TIME"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(14, 245)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "DAYS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(538, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Units"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(325, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(537, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Subject Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(537, 52)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Professor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(326, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(113, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(326, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Year Level"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(43, 23)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 13)
        Me.Label31.TabIndex = 122
        Me.Label31.Text = "Scheduling No.:"
        '
        'lblSchedNo
        '
        Me.lblSchedNo.AutoSize = True
        Me.lblSchedNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSchedNo.Location = New System.Drawing.Point(147, 23)
        Me.lblSchedNo.Name = "lblSchedNo"
        Me.lblSchedNo.Size = New System.Drawing.Size(49, 13)
        Me.lblSchedNo.TabIndex = 121
        Me.lblSchedNo.Text = "100000"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(46, 350)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(838, 31)
        Me.PictureBox1.TabIndex = 208
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(416, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "List View"
        '
        'Scheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboSY)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lblSchedNo)
        Me.Name = "Scheduling"
        Me.Size = New System.Drawing.Size(945, 668)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboSY As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSubjectCode As ComboBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents cbxS As CheckBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents cboProf As ComboBox
    Friend WithEvents cboSemester As ComboBox
    Public WithEvents Label15 As Label
    Public WithEvents Label16 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboDept As ComboBox
    Public WithEvents Label14 As Label
    Friend WithEvents cboTime2 As ComboBox
    Friend WithEvents cboTime1 As ComboBox
    Friend WithEvents cbxF As CheckBox
    Friend WithEvents cbxTH As CheckBox
    Friend WithEvents cbxW As CheckBox
    Friend WithEvents cbxT As CheckBox
    Friend WithEvents cbxM As CheckBox
    Public WithEvents Label13 As Label
    Public WithEvents Label12 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label9 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblSchedNo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
