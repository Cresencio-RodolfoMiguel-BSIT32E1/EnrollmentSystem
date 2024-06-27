Imports System.Data.OleDb

Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        getRegNo()
        Call SchoolYear()
        'Call LoadSections()
        Call loadDepartment()
        Call loadCourse()
    End Sub

    Private Sub getRegNo()
        Dim year As String = DateAndTime.Now.Year.ToString.Substring(2)
        sql = "Select RegistrationNo from tblEnrollment Order by RegistrationNo Desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If dr.Read = True Then
            lblRegNo.Text = String.Format("{0:00000-}" + year, (Val(dr(0)) + 1))
        Else
            lblRegNo.Text = String.Format("{0:00000-}" + year, 1000000)
        End If

    End Sub

    Private Sub clear()
        txtStudentNo.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddlename.Clear()
        cboYearLevel.Text = " "
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmStudentsRecord.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        sql = "SELECT * FROM qryEnrolled WHERE StudentNo = @StudentNo"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtLastName.Text = dr("Lastname").ToString
            txtFirstName.Text = dr("Firstname").ToString
            txtMiddlename.Text = dr("MiddleName").ToString
        End If
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.ToString
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
        cboCourse.DataSource = dt
        cboCourse.DisplayMember = "CourseName"
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Call loadCourse()
        'Call LoadSections()
        Call loadDepartmentID()
    End Sub

    Private Sub loadDepartmentID()
        sql = "Select DepartmentID from tblDepartment where Department= '" & cboDepartment.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblDepartmentID.Text = dr(0)
        End If
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        sql = "Select SectionName from qrySections where CourseName= '" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSection.DataSource = dt
        cboSection.DisplayMember = "SectionName"
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        If cboSection.SelectedItem IsNot Nothing Then
            loadSchedule()
        Else
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub loadSchedule()
        sql = "SELECT [SubjCode],[Description],[Units],[Days],[Time],[Teacher],[LabCode],[Hrs],[Fee] FROM qryClassScheduleNew WHERE Section= '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Dim grandTotal As Double = 0
        Dim totalUnit As Integer = 0
        Dim totalUnits As Integer = 0

        Do While dr.Read()
            x = New ListViewItem(dr("SubjCode").ToString())
            x.SubItems.Add(dr("Description").ToString())
            x.SubItems.Add(dr("Units").ToString())
            x.SubItems.Add(dr("Days").ToString())
            x.SubItems.Add(dr("Time").ToString())
            x.SubItems.Add(dr("Teacher").ToString())
            x.SubItems.Add(dr("LabCode").ToString())
            x.SubItems.Add(dr("Hrs").ToString())
            x.SubItems.Add(dr("Fee").ToString())

            Dim hrs As Double = Double.Parse(dr("Hrs").ToString())
            Dim fee As Double = Double.Parse(dr("Fee").ToString())
            Dim total As Double = hrs * fee

            x.SubItems.Add(total.ToString("F2"))
            ListView1.Items.Add(x)

            grandTotal += total

            Dim units As Integer = Integer.Parse(dr("Units").ToString())
            totalUnit += units

        Loop
        Dim feeQuery As String = "SELECT Fee FROM tblFee WHERE FeeDesc = 'Units'"
        Dim feeCmd As New OleDbCommand(feeQuery, cn)
        Dim unitFee As Double = Convert.ToDouble(feeCmd.ExecuteScalar())

        For Each item As ListViewItem In ListView1.Items
            totalUnits += Integer.Parse(item.SubItems(2).Text)
        Next

        Dim totalFee As Double = unitFee * totalUnits

        txtUnits.Text = totalUnits.ToString()


    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If MsgBox("Enroll Student?", vbQuestion + vbYesNo) = vbYes Then
            If txtStudentNo.Text = " " Or ListView1.Items.Count = 0 Then
                MsgBox("Kindly complete the information", MsgBoxStyle.Exclamation)
            Else
                Call checkAssessment()
            End If
        Else
            MsgBox("Cancel Saving", MsgBoxStyle.Information)
        End If
    End Sub
    Sub checkAssessment()
        sql = "SELECT StudentNo FROM tblEnrollment WHERE StudentNo='" & txtStudentNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            MsgBox("Student is already assessed", MsgBoxStyle.Critical)
        Else
            SaveAssessment()
        End If
    End Sub

    Private Sub SaveAssessment()
        sql = "Insert into [tblEnrollment] ([RegistrationNo], [StudentNo], [Lastname], [Firstname], [Middlename],
        [YearLevel], [Department], [Course],[Section], [Assessor], [DateReg], [TimeReg], [Status], [SY], [Semester], [StudentType]) 
        values ([@RegistrationNo], [@StudentNo], [@Lastname], [@Firstname], [@Middlename],
        [@YearLevel], [@Department], [@Course],[@Section], [@Assessor], [@DateReg], [@TimeReg], [@Status], [@SY], [@Semester], [@StudentType])"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@RegistrationNo]", lblRegNo.Text)
            .Parameters.AddWithValue("[@StudentNo]", txtStudentNo.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastName.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstName.Text)
            .Parameters.AddWithValue("[@Middlename]", txtMiddlename.Text)
            .Parameters.AddWithValue("[@YearLevel]", cboYearLevel.Text)
            .Parameters.AddWithValue("[@Department]", cboDepartment.Text)
            .Parameters.AddWithValue("[@Course]", cboCourse.Text)
            .Parameters.AddWithValue("[@Section]", cboSection.Text)
            .Parameters.AddWithValue("[@Assessor]", lblEnrollmentOfficer.Text)
            .Parameters.AddWithValue("[@DateReg]", Now.ToShortDateString)
            .Parameters.AddWithValue("[@TimeReg]", Now.ToShortTimeString)
            .Parameters.AddWithValue("[@Status]", "Assessed")
            .Parameters.AddWithValue("[@SY]", cboSY.Text)
            .Parameters.AddWithValue("[@Semester]", cboSemester.Text)
            .Parameters.AddWithValue("[@StudentType]", txtStudentType.Text)
            .ExecuteNonQuery()
        End With

        For Each item As ListViewItem In ListView1.Items
            Dim subjectCode As String = item.SubItems(0).Text
            Dim Day As String = item.SubItems(3).Text
            Dim Time As String = item.SubItems(4).Text
            Dim teacher As String = item.SubItems(5).Text
            Dim LC As String = item.SubItems(6).Text
            Dim Hrs As String = item.SubItems(7).Text
            Dim Fee As String = item.SubItems(8).Text
            Dim Total As String = item.SubItems(9).Text

            ' SQL insert command
            Dim sql As String = "INSERT INTO tblEnrollmentDetails ([RegistrationNo],[SubjectCode], [Day], [Time], [Teacher], [LC], [Hrs], [Fee], [Total])" &
            "VALUES (@RegistrationNo, @SubjectCode, @Day, @Time, @Teacher, @LC, @Hrs, @Fee, @Total)"

            ' Create a new command with parameters
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("[@RegistrationNo]", lblRegNo.Text)
                cmd.Parameters.AddWithValue("[@SubjectCode]", subjectCode)
                cmd.Parameters.AddWithValue("[@Day]", Day)
                cmd.Parameters.AddWithValue("[@Time]", Time)
                cmd.Parameters.AddWithValue("[@Teacher]", teacher)
                cmd.Parameters.AddWithValue("[@LC]", LC)
                cmd.Parameters.AddWithValue("[@Hrs]", Hrs)
                cmd.Parameters.AddWithValue("[@Fee]", Fee)
                cmd.Parameters.AddWithValue("[@Total]", Total)
                cmd.ExecuteNonQuery()
            End Using
        Next
        MsgBox("Mr./Ms" & " " & txtLastName.Text & " " & "Successfully Enrolled", MsgBoxStyle.Information)
        Call UpdateStudentStatus()
        clear()

    End Sub

    Private Sub UpdateStudentStatus()
        ' SQL update command
        Dim sql As String = "UPDATE tblListOfEnrolled SET StudentStatus = 'Enrolled' WHERE StudentNo = @StudentNo"


        Using cmd As New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text)


            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        getRegNo()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class