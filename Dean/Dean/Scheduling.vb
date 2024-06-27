Imports System.Data.OleDb

Public Class Scheduling
    Private Sub Scheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call SchoolYear()
        Call getSchedNo()
        Call getTeacher()
        Call loadSubjects()
        Call loadSection()
    End Sub

    Private Sub getSchedNo()
        Dim acctnum As New Random
        lblSchedNo.Text = acctnum.Next(0, 1000000000)
    End Sub

    Private Sub getTeacher()

        sql = "SELECT EmployeeNo, LastName & ', ' & FirstName AS FullName FROM tblTeachers WHERE Status = 'Open'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Dim dt As New DataTable()
            dt.Load(dr)
            cboProf.DataSource = dt
            cboProf.DisplayMember = "FullName"
            cboProf.ValueMember = "EmployeeNo"
        Else
            MsgBox("No teachers foundwith an open status.", MsgBoxStyle.Critical)
        End If

        dr.Close()
    End Sub
    Private Sub GetSectionInfo()
        Dim selectedSection As String = cboSection.Text
        sql = "SELECT YearLevel, SY, Semester, Department, CourseName FROM qrySections WHERE SectionName = @SectionName"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@SectionName", selectedSection)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            cboYearLevel.Text = dr("YearLevel").ToString()
            cboSY.Text = dr("SY").ToString()
            cboSemester.Text = dr("Semester").ToString()
            cboDept.Text = dr("Department").ToString()
            cboCourse.Text = dr("CourseName").ToString()
        End If

        sql = "SELECT SubjCode, Description, Units, Teacher FROM qrySectionSubject WHERE SectionName = @SectionName"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@SectionName", selectedSection)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Do While dr.Read()
            Dim newItem As New ListViewItem(dr("SubjCode").ToString())
            newItem.SubItems.Add(dr("Description").ToString())
            newItem.SubItems.Add(dr("Units").ToString())
            newItem.SubItems.Add(dr("Teacher").ToString())
            ListView1.Items.Add(newItem)
        Loop
    End Sub

    Private Sub getSubjects()
        sql = "SELECT Description, Units FROM qrySubjects WHERE SubjCode = '" & cboSubjectCode.Text & "'"
        Dim description As String = ""
        Dim units As String = ""
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read() Then
            description = dr("Description").ToString()
            units = dr("Units").ToString()
        End If

        ' Display the retrieved description and units in txtDescription and txtUnits respectively
        txtDescription.Text = description
        txtUnits.Text = units
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


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrEmpty(cboSubjectCode.Text) AndAlso Not String.IsNullOrEmpty(txtDescription.Text) AndAlso
            Not String.IsNullOrEmpty(txtUnits.Text) AndAlso Not String.IsNullOrEmpty(cboProf.Text) AndAlso
            Not String.IsNullOrEmpty(cboTime1.Text) AndAlso Not String.IsNullOrEmpty(cboTime2.Text) AndAlso
            Not String.IsNullOrEmpty(cboSection.Text) AndAlso Not String.IsNullOrEmpty(cboSemester.Text) AndAlso
            Not String.IsNullOrEmpty(cboDept.Text) AndAlso Not String.IsNullOrEmpty(cboCourse.Text) AndAlso
            Not String.IsNullOrEmpty(cboYearLevel.Text) Then
            Dim days As String = ""
            If cbxM.Checked Then days &= "M "
            If cbxT.Checked Then days &= "T "
            If cbxW.Checked Then days &= "W "
            If cbxTH.Checked Then days &= "TH "
            If cbxF.Checked Then days &= "F "
            If cbxS.Checked Then days &= "S "

            sql = "Insert into tblCSdetails ([CSNo],[SubjCode],[Description],[Units],[Teacher],[Days],[Time]) values (@CSNo, @SubjCode, @Description, @Units, @Teacher, @Days, @Time)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@CSno", lblSchedNo.Text)
                .Parameters.AddWithValue("@SubjCode", cboSubjectCode.Text)
                .Parameters.AddWithValue("@Description", txtDescription.Text)
                .Parameters.AddWithValue("@Units", txtUnits.Text)
                .Parameters.AddWithValue("@Teacher", cboProf.Text)
                .Parameters.AddWithValue("@Days", days)
                .Parameters.AddWithValue("@Time", cboTime1.Text & " - " & cboTime2.Text)
                .ExecuteNonQuery()
            End With

            sql = "Insert into tblClassSchedule ([SYID], [CSNo], [Section], [Semester],[Department],[Course],[YearLevel]) values (@SYID, @CSNo, @Section, @Semester, @Department, @Course, @YearLevel)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@SYID", cboSY.Text)
                .Parameters.AddWithValue("@CSNo", lblSchedNo.Text)
                .Parameters.AddWithValue("@Section", cboSection.Text)
                .Parameters.AddWithValue("@Semester", cboSemester.Text)
                .Parameters.AddWithValue("@Department", cboDept.Text)
                .Parameters.AddWithValue("@Course", cboCourse.Text)
                .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
                .ExecuteNonQuery()
            End With

            Dim newItem As New ListViewItem(cboSubjectCode.Text)
            newItem.SubItems.Add(txtDescription.Text)
            newItem.SubItems.Add(txtUnits.Text)
            newItem.SubItems.Add(cboProf.Text)
            newItem.SubItems.Add(days)
            Dim times As String = cboTime1.Text & " - " & cboTime2.Text
            newItem.SubItems.Add(times)

            ' Add the ListViewItem to the ListView
            ListView1.Items.Add(newItem)

            Call RemoveInfo()
        Else
            MessageBox.Show("Please fill in the blank textboxes.")
        End If

        getSchedNo()
    End Sub


    Private Sub RemoveInfo()
        txtDescription.Text = ""
        txtUnits.Text = ""
        cboSubjectCode.Text = ""
        txtDescription.Text = ""
        'cboCourse.Text = ""
        'cboDept.Text = ""
        cboTime1.Text = ""
        cboTime2.Text = ""
        'cboYearLevel.Text = ""
        'cboSection.Text = ""
        'cboSemester.Text = ""
    End Sub


    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        Call GetSectionInfo()

    End Sub

    Private Sub cboSubjectCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubjectCode.SelectedIndexChanged
        getSubjects()
    End Sub

    Private Sub loadSubjects()
        sql = "Select distinct SubjCode from tblSubjects where status= 'Open' "
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSubjectCode.DataSource = dt
        cboSubjectCode.DisplayMember = "SubjCode"
    End Sub

    Private Sub loadSection()
        sql = "Select distinct SectionName from tblSections"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSection.DataSource = dt
        cboSection.DisplayMember = "SectionName"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call RemoveInfo()
    End Sub
End Class
