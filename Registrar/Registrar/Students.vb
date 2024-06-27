Imports System.Data.OleDb

Public Class Students
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        SchoolYear()
        loadStudents()
        loadDepartment()
        'loadCourse()
        getStudentNo()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
        getStudentNo()
    End Sub

    Private Sub getStudentNo()
        sql = "SELECT StudentNo FROM tblListOfEnrolled ORDER BY StudentNo DESC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read() Then
            If Not dr.IsDBNull(0) Then
                lblStudentNo.Text = (Convert.ToInt32(dr(0)) + 1).ToString()
            Else
                lblStudentNo.Text = "1010"
            End If
        Else
            lblStudentNo.Text = "1010"
        End If
    End Sub

    Private Sub loadDepartment()
        sql = "Select distinct Department from tblDepartment"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboDepartment.DataSource = dt
        cboDepartment.DisplayMember = "Department"
    End Sub
    Private Sub loadCourse()
        sql = "Select distinct CourseName from qryDepartmentCourse where Department = '" & cboDepartment.Text & "' and status = 'Open'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboCourseChoices.DataSource = dt
        cboCourseChoices.DisplayMember = "CourseName"
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Call loadCourse()
    End Sub

    Private Sub SchoolYear()
        sql = "Select distinct SY from tblSY where status= 'Open' "
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSY.DataSource = dt
        cboSY.DisplayMember = "SY"
    End Sub
    Private Sub loadStudents()
        sql = "Select * from qryEnrolled ORDER BY StudentNo ASC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ' Dim x As ListViewItem
        ListView1.Items.Clear()
        'ListView2.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString & ", " & dr("Street").ToString & " " & dr("Brgy").ToString & " " & dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString & ", " & dr("MFirstname").ToString & " " & dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString & ", " & dr("FFirstname").ToString & " " & dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString & ", " & dr("GFirstname").ToString & " " & dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
        getStudentNo()

        'lblTotalApplicants.Text = ListView1.Items.Count.ToString()
    End Sub

    Private Sub SaveEnrolled()
        sql = "Insert Into tblStudentsInformation([LRN], [Lastname], [Firstname], [Middlename],
        [HouseNo], [Street], [Brgy],[City], [ContactNo], [Bdate], [Gender], [Age],[Email], [StudentType], 
        [MLastName], [MFirstName], [MMiddleName], [MContactNo], [FLastName], [FFirstName], 
        [FMiddleName], [FContactNo],[GLastName],[GFirstName],[GMiddleName],[Relationship],[GContactNo], [PSA], [COR], [Form137], [Form138], [AcademicRecords], 
        [LettersofRecommendation], [SY]) 
        values ([@LRN], [@Lastname], [@Firstname], [@Middlename],
        [@HouseNo], [@Street], [@Brgy],[@City], [@ContactNo], [@Bdate], [@Gender],[@Age],[@Email], [@StudentType], 
        [@MLastName], [@MFirstName], [@MMiddleName], [@MContactNo], [@FLastName], [@FFirstName], 
        [@FMiddleName], [@FContactNo],[@GLastName],[@GFirstName],[@GMiddleName],[@Relationship],[@GContactNo], [@PSA], [@COR], [@Form137], [@Form138], [@AcademicRecords], 
        [@LettersofRecommendation], [@SY])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@LRN]", txtLRN.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastname.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstname.Text)
            .Parameters.AddWithValue("[@Middlename]", txtMiddleName.Text)
            .Parameters.AddWithValue("[@HouseNo]", txtHouseNo.Text)
            .Parameters.AddWithValue("[@Street]", txtStreet.Text)
            .Parameters.AddWithValue("[@Brgy]", txtBrgy.Text)
            .Parameters.AddWithValue("[@City]", txtCity.Text)
            .Parameters.AddWithValue("[@ContactNo]", txtContactNo.Text)
            .Parameters.AddWithValue("[@Bdate]", Bdate.Value.ToString)
            .Parameters.AddWithValue("[@Gender]", cboGender.Text)
            .Parameters.AddWithValue("[@Age]", txtAge.Text)
            .Parameters.AddWithValue("[@Email]", txtEmail.Text)
            .Parameters.AddWithValue("[@StudentType]", cboType.Text)
            .Parameters.AddWithValue("[@MLastName]", txtMLastname.Text)
            .Parameters.AddWithValue("[@MFirstName]", txtMFirstname.Text)
            .Parameters.AddWithValue("[@MMiddleName]", txtMMiddleName.Text)
            .Parameters.AddWithValue("[@MContactNo]", txtMContactNo.Text)
            .Parameters.AddWithValue("[@FLastName]", txtFLastname.Text)
            .Parameters.AddWithValue("[@FFirstName]", txtFFirstname.Text)
            .Parameters.AddWithValue("[@FMiddleName]", txtFMiddleName.Text)
            .Parameters.AddWithValue("[@FContactNo]", txtFContactNo.Text)
            .Parameters.AddWithValue("[@GLastName]", txtGLastname.Text)
            .Parameters.AddWithValue("[@GFirstName]", txtGFirstname.Text)
            .Parameters.AddWithValue("[@GMiddleName]", txtGMiddlename.Text)
            .Parameters.AddWithValue("[@Relationship]", txtRelationship.Text)
            .Parameters.AddWithValue("[@GContactNo]", txtGContactNo.Text)
            .Parameters.AddWithValue("[@PSA]", If(ckPSA.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@COR]", If(ckCOR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@Form137]", If(ck137.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@Form138]", If(ck138.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@AcademicRecords]", If(ckAR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@LettersofRecommendation]", If(ckLOR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@SY]", cboSY.Text)
            .ExecuteNonQuery()
        End With

        sql = "Insert Into tblListOfEnrolled ([StudentNo], [Semester], [Department], [CourseChoices], 
        [YearLevel], [StudentStatus])
        values ([@StudentNo], [@Semester], [@Department], [@CourseChoices], 
        [@YearLevel], [@StudentStatus])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@StudentNo]", lblStudentNo.Text)
            .Parameters.AddWithValue("[@Semester]", cboSemester.Text)
            .Parameters.AddWithValue("[@Department]", cboDepartment.Text)
            .Parameters.AddWithValue("[@CourseChoices]", cboCourseChoices.Text)
            .Parameters.AddWithValue("[@YearLevel]", cboYearLevel.Text)
            .Parameters.AddWithValue("[@StudentStatus]", cboStudentStatus.Text)
            .ExecuteNonQuery()
        End With
    End Sub


    Private Sub updateInfo()
        sql = "UPDATE qryEnrolled SET [LRN] = @LRN, [StudentNo] = @StudentNo, [Lastname] = @Lastname, [Firstname] = @Firstname, 
[MiddleName] = @MiddleName, [ContactNo] = @ContactNo, [Bdate] = @Bdate, [Age] = @Age,[Email] = @Email, [Gender] = @Gender,
[HouseNo] = @HouseNo, [Street] = @Street, [Brgy] = @Brgy, [City] = @City, 
[MLastname] = @MLastname, [MFirstname] = @MFirstname, 
[MMiddleName] = @MMiddleName, [MContactNo] = @MContactNo, [FLastname] = @FLastname, 
[FFirstname] = @FFirstname, [FMiddleName] = @FMiddleName, [FContactNo] = @FContactNo,
[PSA] = @PSA, [COR] = @COR, [Form137] = @Form137, [Form138] = @Form138, [AcademicRecords] = @AcademicRecords, 
[LettersofRecommendation] = @LettersofRecommendation, [Semester] = @Semester, [YearLevel] = @YearLevel, 
[Department] = @Department, [CourseChoices] = @CourseChoices, [StudentType] = @StudentType,  
[StudentStatus] = @StudentStatus, [GLastName] = @GLastName, [GFirstName] = @GFirstName, 
[GMiddleName] = @GMiddleName, [Relationship] = @Relationship, [GContactNo] = @GContactNo 
WHERE LRN = @LRN"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@LRN]", txtLRN.Text)
            .Parameters.AddWithValue("[@StudentNo]", lblStudentNo.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastname.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstname.Text)
            .Parameters.AddWithValue("[@Middlename]", txtMiddleName.Text)
            .Parameters.AddWithValue("[@ContactNo]", txtContactNo.Text)
            .Parameters.AddWithValue("[@Bdate]", Bdate.Value.ToString)
            .Parameters.AddWithValue("[@Age]", txtAge.Text)
            .Parameters.AddWithValue("[@Email]", txtEmail.Text)
            .Parameters.AddWithValue("[@Gender]", cboGender.Text)
            .Parameters.AddWithValue("[@HouseNo]", txtHouseNo.Text)
            .Parameters.AddWithValue("[@Street]", txtStreet.Text)
            .Parameters.AddWithValue("[@Brgy]", txtBrgy.Text)
            .Parameters.AddWithValue("[@City]", txtCity.Text)
            .Parameters.AddWithValue("[@MLastname]", txtMLastname.Text)
            .Parameters.AddWithValue("[@MFirstame]", txtMFirstname.Text)
            .Parameters.AddWithValue("[@MMiddleName]", txtMMiddleName.Text)
            .Parameters.AddWithValue("[@MContactNo]", txtMContactNo.Text)
            .Parameters.AddWithValue("[@FLastname]", txtFLastname.Text)
            .Parameters.AddWithValue("[@FFirstame]", txtFFirstname.Text)
            .Parameters.AddWithValue("[@FMiddleName]", txtFMiddleName.Text)
            .Parameters.AddWithValue("[@FContactNo]", txtFContactNo.Text)
            .Parameters.AddWithValue("[@GLastName]", txtGLastname.Text)
            .Parameters.AddWithValue("[@GFirstName]", txtGFirstname.Text)
            .Parameters.AddWithValue("[@GMiddleName]", txtGMiddlename.Text)
            .Parameters.AddWithValue("[@Relationship]", txtRelationship.Text)
            .Parameters.AddWithValue("[@GContactNo]", txtGContactNo.Text)
            .Parameters.AddWithValue("[@PSA]", If(ckPSA.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@COR]", If(ckCOR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@Form137]", If(ck137.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@Form138]", If(ck138.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@AcademicRecords]", If(ckAR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@LettersofRecommendation]", If(ckLOR.Checked, "Passed", "Not Passed"))
            .Parameters.AddWithValue("[@Semester]", cboSemester.Text)
            .Parameters.AddWithValue("[@YearLevel]", cboYearLevel.Text)
            .Parameters.AddWithValue("[@Department]", cboDepartment.Text)
            .Parameters.AddWithValue("[@CourseChoices]", cboCourseChoices.Text)
            .Parameters.AddWithValue("[@StudentType]", cboType.Text)
            .Parameters.AddWithValue("[@StudentStatus]", cboStudentStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Students Successfully Updated", MsgBoxStyle.Information)
        loadStudents()
    End Sub
    Private Sub clear()
        txtLRN.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMiddleName.Clear()
        txtAge.Clear()
        txtEmail.Clear()
        cboGender.Text = " "
        cboType.Text = " "
        txtContactNo.Clear()
        txtHouseNo.Clear()
        txtStreet.Clear()
        txtBrgy.Clear()
        txtCity.Clear()
        txtMLastname.Clear()
        txtMFirstname.Clear()
        txtMMiddleName.Clear()
        txtMContactNo.Clear()
        txtFFirstname.Clear()
        txtFLastname.Clear()
        txtFFirstname.Clear()
        txtFMiddleName.Clear()
        txtFContactNo.Clear()
        txtGFirstname.Clear()
        txtGMiddlename.Clear()
        txtGLastname.Clear()
        txtGContactNo.Clear()
        txtRelationship.Clear()
        ckPSA.Text = " "
        ckLOR.Text = " "
        ckCOR.Text = " "
        ckAR.Text = " "
        ck137.Text = " "
        ck138.Text = " "
        cboGender.Text = " "
        cboStudentStatus.Text = " "
        cboType.Text = " "
        cboYearLevel.Text = " "
        cboDepartment.Text = " "
        cboCourseChoices.Text = " "

    End Sub

    Private Sub CheckEnrolled()
        sql = "Select LRN from qryEnrolled where LRN='" & txtLRN.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            MsgBox("Student is already Exist", MsgBoxStyle.Exclamation)

        Else
            If MsgBox("Are you sure you want to save record?", vbQuestion + vbYesNo) = vbYes Then
                MsgBox("Saved Successfully!", MsgBoxStyle.Information, "New Record Saved")
                SaveEnrolled()
            Else
                MsgBox("Record not saved.", MsgBoxStyle.Information, "Operation Canceled")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call CheckEnrolled()
        Call loadStudents()
    End Sub


    Private Sub cboSemester_SelectedIndexChanged(sender As Object, e As EventArgs)
        sql = "Select distinct Semester from tblSY where SY = '" & cboSY.Text & "' and status = 'Open'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSemester.DataSource = dt
        cboSemester.DisplayMember = "Semester"
        Call getSYID()
    End Sub

    Private Sub getSYID()
        sql = "Select SYID from tblSY where SY= '" & cboSY.Text & "' and Semester='" & cboSemester.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblSYID.Text = dr(0)
        End If
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sql = "Select distinct Semester from tblSY where SY = '" & cboSY.Text & "' and status = 'Open'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSemester.DataSource = dt
        cboSemester.DisplayMember = "Semester"
        Call getSYID()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call updateInfo()
        Call loadStudents()
        clear()
    End Sub

    Private Sub txtLRN_TextChanged(sender As Object, e As EventArgs) Handles txtLRN.TextChanged
        sql = "SELECT * FROM qryEnrolled WHERE LRN = @LRN"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@LRN", txtLRN.Text)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtLastname.Text = dr("Lastname").ToString
            txtFirstname.Text = dr("Firstname").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
            txtContactNo.Text = dr("ContactNo").ToString
            Bdate.Value = Convert.ToDateTime(dr("Bdate"))
            txtAge.Text = dr("Age").ToString
            txtEmail.Text = dr("Email").ToString
            cboGender.Text = dr("Gender").ToString
            txtHouseNo.Text = dr("HouseNo").ToString
            txtStreet.Text = dr("Street").ToString
            txtBrgy.Text = dr("Brgy").ToString
            txtCity.Text = dr("City").ToString
            txtMLastname.Text = dr("MLastname").ToString
            txtMFirstname.Text = dr("MFirstname").ToString
            txtMMiddleName.Text = dr("MMiddleName").ToString
            txtMContactNo.Text = dr("MContactNo").ToString
            txtFLastname.Text = dr("FLastname").ToString
            txtFFirstname.Text = dr("FFIrstname").ToString
            txtFMiddleName.Text = dr("FMiddleName").ToString
            txtFContactNo.Text = dr("FContactNo").ToString
            txtGLastname.Text = dr("GLastname").ToString
            txtGFirstname.Text = dr("GFirstname").ToString
            txtGMiddlename.Text = dr("GMiddlename").ToString
            txtRelationship.Text = dr("Relationship").ToString
            txtGContactNo.Text = dr("GContactNo").ToString
            ckPSA.Checked = (dr("PSA").ToString = "Passed")
            ckCOR.Checked = (dr("COR").ToString = "Passed")
            ck137.Checked = (dr("Form137").ToString = "Passed")
            ck138.Checked = (dr("Form138").ToString = "Passed")
            ckAR.Checked = (dr("AcademicRecords").ToString = "Passed")
            ckLOR.Checked = (dr("LettersOfRecommendation").ToString = "Passed")
            cboSemester.Text = dr("Semester").ToString
            cboCourseChoices.Text = dr("CourseChoices").ToString
            cboDepartment.Text = dr("Department").ToString
            cboYearLevel.Text = dr("YearLevel").ToString
            cboType.Text = dr("StudentType").ToString
            cboStudentStatus.Text = dr("StudentStatus").ToString
        End If
        lblStudentNo.Visible = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call getStudentNo()
        lblStudentNo.Visible = True
        clear()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            txtLRN.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = "SELECT * FROM qryEnrolled WHERE Lastname LIKE @searchText OR Firstname LIKE @searchText OR LRN LIKE @searchText OR StudentNo LIKE @searchText"
        If txtSearch.Text = "" Then
            sql = "SELECT * FROM qryEnrolled "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString)
            LV1.SubItems.Add(dr("Firstname").ToString)
            LV1.SubItems.Add(dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString)
            LV1.SubItems.Add(dr("Street").ToString)
            LV1.SubItems.Add(dr("Brgy").ToString)
            LV1.SubItems.Add(dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString)
            LV1.SubItems.Add(dr("MFirstname").ToString)
            LV1.SubItems.Add(dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString)
            LV1.SubItems.Add(dr("FFirstname").ToString)
            LV1.SubItems.Add(dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString)
            LV1.SubItems.Add(dr("GFirstname").ToString)
            LV1.SubItems.Add(dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        sql = "Select * from qryEnrolled"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ' Dim x As ListViewItem
        ListView1.Items.Clear()
        'ListView2.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString)
            LV1.SubItems.Add(dr("Firstname").ToString)
            LV1.SubItems.Add(dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString)
            LV1.SubItems.Add(dr("Street").ToString)
            LV1.SubItems.Add(dr("Brgy").ToString)
            LV1.SubItems.Add(dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString)
            LV1.SubItems.Add(dr("MFirstname").ToString)
            LV1.SubItems.Add(dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString)
            LV1.SubItems.Add(dr("FFirstname").ToString)
            LV1.SubItems.Add(dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString)
            LV1.SubItems.Add(dr("GFirstname").ToString)
            LV1.SubItems.Add(dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub btnEnrolled_Click(sender As Object, e As EventArgs) Handles btnEnrolled.Click
        sql = "Select * from qryEnrolled where StudentStatus = 'Enrolled'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ' Dim x As ListViewItem
        ListView1.Items.Clear()
        'ListView2.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString)
            LV1.SubItems.Add(dr("Firstname").ToString)
            LV1.SubItems.Add(dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString)
            LV1.SubItems.Add(dr("Street").ToString)
            LV1.SubItems.Add(dr("Brgy").ToString)
            LV1.SubItems.Add(dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString)
            LV1.SubItems.Add(dr("MFirstname").ToString)
            LV1.SubItems.Add(dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString)
            LV1.SubItems.Add(dr("FFirstname").ToString)
            LV1.SubItems.Add(dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString)
            LV1.SubItems.Add(dr("GFirstname").ToString)
            LV1.SubItems.Add(dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub btnPEnrolled_Click(sender As Object, e As EventArgs) Handles btnPEnrolled.Click
        sql = "SELECT * FROM qryEnrolled WHERE StudentStatus = 'Partially Enrolled'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString)
            LV1.SubItems.Add(dr("Firstname").ToString)
            LV1.SubItems.Add(dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString)
            LV1.SubItems.Add(dr("Street").ToString)
            LV1.SubItems.Add(dr("Brgy").ToString)
            LV1.SubItems.Add(dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString)
            LV1.SubItems.Add(dr("MFirstname").ToString)
            LV1.SubItems.Add(dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString)
            LV1.SubItems.Add(dr("FFirstname").ToString)
            LV1.SubItems.Add(dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString)
            LV1.SubItems.Add(dr("GFirstname").ToString)
            LV1.SubItems.Add(dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub btnReserved_Click(sender As Object, e As EventArgs) Handles btnReserved.Click
        sql = "SELECT * FROM qryEnrolled WHERE StudentStatus = 'Reserved'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("LRN").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString)
            LV1.SubItems.Add(dr("Firstname").ToString)
            LV1.SubItems.Add(dr("Middlename").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Email").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString)
            LV1.SubItems.Add(dr("Street").ToString)
            LV1.SubItems.Add(dr("Brgy").ToString)
            LV1.SubItems.Add(dr("City").ToString)
            LV1.SubItems.Add(dr("MLastname").ToString)
            LV1.SubItems.Add(dr("MFirstname").ToString)
            LV1.SubItems.Add(dr("MMiddleName").ToString)
            LV1.SubItems.Add(dr("MContactNo").ToString)
            LV1.SubItems.Add(dr("FLastname").ToString)
            LV1.SubItems.Add(dr("FFirstname").ToString)
            LV1.SubItems.Add(dr("FMiddleName").ToString)
            LV1.SubItems.Add(dr("FContactNo").ToString)
            LV1.SubItems.Add(dr("GLastname").ToString)
            LV1.SubItems.Add(dr("GFirstname").ToString)
            LV1.SubItems.Add(dr("GMiddleName").ToString)
            LV1.SubItems.Add(dr("Relationship").ToString)
            LV1.SubItems.Add(dr("GContactNo").ToString)
            LV1.SubItems.Add(dr("PSA").ToString)
            LV1.SubItems.Add(dr("COR").ToString)
            LV1.SubItems.Add(dr("Form137").ToString)
            LV1.SubItems.Add(dr("Form138").ToString)
            LV1.SubItems.Add(dr("AcademicRecords").ToString)
            LV1.SubItems.Add(dr("LettersOfRecommendation").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select an Information to delete.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim studentNo As String = selectedItem.SubItems(1).Text ' Assuming StudentNo is in the second column (index 1)

        ' Define your SQL statements for deletion
        Dim sqlDeleteStudents As String = "DELETE FROM tblStudentsInformation WHERE StudentNo = @StudentNo"
        Dim sqlDeleteEnrolled As String = "DELETE FROM tblListOfEnrolled WHERE StudentNo = @StudentNo"

        ' Use a transaction to ensure atomicity (either both delete or none)
        Dim transaction As OleDbTransaction = Nothing

        Try
            cn.Open()
            transaction = cn.BeginTransaction()

            ' Delete from tblStudentsInformation
            Dim cmdDeleteStudents As New OleDbCommand(sqlDeleteStudents, cn, transaction)
            cmdDeleteStudents.Parameters.AddWithValue("@StudentNo", studentNo)
            Dim rowsAffectedStudents As Integer = cmdDeleteStudents.ExecuteNonQuery()

            ' Delete from tblListOfEnrolled
            Dim cmdDeleteEnrolled As New OleDbCommand(sqlDeleteEnrolled, cn, transaction)
            cmdDeleteEnrolled.Parameters.AddWithValue("@StudentNo", studentNo)
            Dim rowsAffectedEnrolled As Integer = cmdDeleteEnrolled.ExecuteNonQuery()

            ' Commit the transaction if both deletes are successful
            transaction.Commit()

            ' Check if any rows were affected
            If rowsAffectedStudents > 0 AndAlso rowsAffectedEnrolled > 0 Then
                MsgBox("Information Successfully Deleted", MsgBoxStyle.Information)
                loadStudents() ' Reload data in ListView
                ActLogs("Delete Information")
            Else
                MsgBox("No matching Information found to delete.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            ' Rollback the transaction in case of any error
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MsgBox("Error deleting Information: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            ' Close connection and clean up
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


End Class
