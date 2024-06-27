<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListofApplicants
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbosex = New System.Windows.Forms.ComboBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.datebirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboapplicantstatus = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtblock = New System.Windows.Forms.TextBox()
        Me.txtfamilyname = New System.Windows.Forms.TextBox()
        Me.cbomunicipality = New System.Windows.Forms.ComboBox()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdmissionID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblregisno = New System.Windows.Forms.Label()
        Me.cbobrgy = New System.Windows.Forms.ComboBox()
        Me.txtdateadded = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(41, 347)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(873, 296)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AdmissionID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "RegistrationNo"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ApplicantName"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Birthdate"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Age"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sex"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Address"
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ContactNo"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "EmailAddress"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "ApplicantStatus"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DateAdded"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Course"
        '
        'cbosex
        '
        Me.cbosex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosex.FormattingEnabled = True
        Me.cbosex.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cbosex.Location = New System.Drawing.Point(41, 269)
        Me.cbosex.Name = "cbosex"
        Me.cbosex.Size = New System.Drawing.Size(162, 23)
        Me.cbosex.TabIndex = 264
        '
        'txtage
        '
        Me.txtage.Enabled = False
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(42, 228)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(161, 21)
        Me.txtage.TabIndex = 263
        '
        'datebirthdate
        '
        Me.datebirthdate.AllowDrop = True
        Me.datebirthdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebirthdate.Location = New System.Drawing.Point(41, 183)
        Me.datebirthdate.Name = "datebirthdate"
        Me.datebirthdate.Size = New System.Drawing.Size(162, 21)
        Me.datebirthdate.TabIndex = 262
        Me.datebirthdate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(621, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 13)
        Me.Label27.TabIndex = 259
        Me.Label27.Text = "Leave empty if needed"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Gray
        Me.Label26.Location = New System.Drawing.Point(621, 41)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(115, 13)
        Me.Label26.TabIndex = 258
        Me.Label26.Text = "Leave empty if needed"
        '
        'cboapplicantstatus
        '
        Me.cboapplicantstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboapplicantstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboapplicantstatus.FormattingEnabled = True
        Me.cboapplicantstatus.Items.AddRange(New Object() {"New (Freshmen)", "Transferee"})
        Me.cboapplicantstatus.Location = New System.Drawing.Point(306, 140)
        Me.cboapplicantstatus.Name = "cboapplicantstatus"
        Me.cboapplicantstatus.Size = New System.Drawing.Size(162, 23)
        Me.cboapplicantstatus.TabIndex = 245
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Gray
        Me.Label25.Location = New System.Drawing.Point(742, 103)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 256
        Me.Label25.Text = "number only"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 244
        Me.Label10.Text = "Applicant Status"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(742, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 13)
        Me.Label24.TabIndex = 257
        Me.Label24.Text = "number only"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Family Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(571, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 251
        Me.Label11.Text = "Municipality"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(306, 98)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(161, 20)
        Me.txtemail.TabIndex = 243
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(571, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 15)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Barangay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "First Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(571, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 15)
        Me.Label13.TabIndex = 253
        Me.Label13.Text = "Street"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(303, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 242
        Me.Label9.Text = "Email"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(571, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 15)
        Me.Label14.TabIndex = 254
        Me.Label14.Text = "LOT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Middle Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(571, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 15)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "BLK"
        '
        'txtstreet
        '
        Me.txtstreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstreet.Location = New System.Drawing.Point(574, 142)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(162, 21)
        Me.txtstreet.TabIndex = 248
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(574, 100)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(162, 21)
        Me.txtlot.TabIndex = 247
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 15)
        Me.Label8.TabIndex = 241
        Me.Label8.Text = "Sex"
        '
        'txtblock
        '
        Me.txtblock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtblock.Location = New System.Drawing.Point(574, 57)
        Me.txtblock.Name = "txtblock"
        Me.txtblock.Size = New System.Drawing.Size(162, 21)
        Me.txtblock.TabIndex = 246
        '
        'txtfamilyname
        '
        Me.txtfamilyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfamilyname.Location = New System.Drawing.Point(41, 137)
        Me.txtfamilyname.Multiline = True
        Me.txtfamilyname.Name = "txtfamilyname"
        Me.txtfamilyname.Size = New System.Drawing.Size(162, 20)
        Me.txtfamilyname.TabIndex = 234
        '
        'cbomunicipality
        '
        Me.cbomunicipality.BackColor = System.Drawing.Color.White
        Me.cbomunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomunicipality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomunicipality.FormattingEnabled = True
        Me.cbomunicipality.Items.AddRange(New Object() {""})
        Me.cbomunicipality.Location = New System.Drawing.Point(574, 186)
        Me.cbomunicipality.Name = "cbomunicipality"
        Me.cbomunicipality.Size = New System.Drawing.Size(162, 23)
        Me.cbomunicipality.TabIndex = 249
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmiddlename.Location = New System.Drawing.Point(41, 98)
        Me.txtmiddlename.Multiline = True
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(162, 20)
        Me.txtmiddlename.TabIndex = 235
        '
        'txtcontactno
        '
        Me.txtcontactno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(306, 57)
        Me.txtcontactno.MaxLength = 11
        Me.txtcontactno.Multiline = True
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(161, 20)
        Me.txtcontactno.TabIndex = 240
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(41, 58)
        Me.txtfirstname.Multiline = True
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(162, 20)
        Me.txtfirstname.TabIndex = 236
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 239
        Me.Label7.Text = "Contact No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 237
        Me.Label5.Text = "Age"
        '
        'txtAdmissionID
        '
        Me.txtAdmissionID.BackColor = System.Drawing.SystemColors.Control
        Me.txtAdmissionID.Enabled = False
        Me.txtAdmissionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmissionID.Location = New System.Drawing.Point(306, 185)
        Me.txtAdmissionID.Name = "txtAdmissionID"
        Me.txtAdmissionID.ReadOnly = True
        Me.txtAdmissionID.Size = New System.Drawing.Size(161, 21)
        Me.txtAdmissionID.TabIndex = 265
        Me.txtAdmissionID.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(303, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 15)
        Me.Label16.TabIndex = 266
        Me.Label16.Text = "Admission ID"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(829, 304)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(85, 33)
        Me.btnclear.TabIndex = 268
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(829, 259)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(84, 33)
        Me.btnupdate.TabIndex = 267
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(303, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 15)
        Me.Label17.TabIndex = 270
        Me.Label17.Text = "Search ID"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(306, 227)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(161, 21)
        Me.txtsearch.TabIndex = 269
        '
        'lblregisno
        '
        Me.lblregisno.AutoSize = True
        Me.lblregisno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregisno.Location = New System.Drawing.Point(555, 0)
        Me.lblregisno.Name = "lblregisno"
        Me.lblregisno.Size = New System.Drawing.Size(298, 15)
        Me.lblregisno.TabIndex = 271
        Me.lblregisno.Text = "LBLREGISNO AUTOHIDE PAG NAG BUKAS SYSTEM"
        '
        'cbobrgy
        '
        Me.cbobrgy.BackColor = System.Drawing.Color.White
        Me.cbobrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobrgy.FormattingEnabled = True
        Me.cbobrgy.Location = New System.Drawing.Point(574, 230)
        Me.cbobrgy.Name = "cbobrgy"
        Me.cbobrgy.Size = New System.Drawing.Size(162, 21)
        Me.cbobrgy.TabIndex = 272
        '
        'txtdateadded
        '
        Me.txtdateadded.BackColor = System.Drawing.Color.White
        Me.txtdateadded.Enabled = False
        Me.txtdateadded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdateadded.Location = New System.Drawing.Point(574, 271)
        Me.txtdateadded.Name = "txtdateadded"
        Me.txtdateadded.ReadOnly = True
        Me.txtdateadded.Size = New System.Drawing.Size(162, 21)
        Me.txtdateadded.TabIndex = 273
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 274
        Me.Label4.Text = "Date Added"
        '
        'cbocourse
        '
        Me.cbocourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cbocourse.Location = New System.Drawing.Point(306, 271)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(161, 21)
        Me.cbocourse.TabIndex = 276
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(303, 253)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(92, 15)
        Me.Label35.TabIndex = 275
        Me.Label35.Text = "Desired Course"
        '
        'ListofApplicants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbocourse)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtdateadded)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbobrgy)
        Me.Controls.Add(Me.lblregisno)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtAdmissionID)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbosex)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.datebirthdate)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cboapplicantstatus)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtstreet)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtblock)
        Me.Controls.Add(Me.txtfamilyname)
        Me.Controls.Add(Me.cbomunicipality)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ListofApplicants"
        Me.Size = New System.Drawing.Size(961, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents cbosex As ComboBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents datebirthdate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cboapplicantstatus As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtstreet As TextBox
    Friend WithEvents txtlot As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtblock As TextBox
    Friend WithEvents txtfamilyname As TextBox
    Friend WithEvents cbomunicipality As ComboBox
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents txtcontactno As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdmissionID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents lblregisno As Label
    Friend WithEvents cbobrgy As ComboBox
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txtdateadded As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents Label35 As Label
End Class
