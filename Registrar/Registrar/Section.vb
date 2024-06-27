Imports System.Data.OleDb

Public Class Section
    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSection()
        Call SchoolYear()
        Call loadDepartment()
        Call loadCourse()
    End Sub

    Private Sub loadSection()
        sql = "Select * from qrySections"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("SectionName").ToString)
            x.SubItems.Add(dr("YearLevel").ToString)
            x.SubItems.Add(dr("SY").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Department").ToString)
            x.SubItems.Add(dr("CourseName").ToString)
            ListView1.Items.Add(x)
        Loop
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
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

    Private Sub getSYID()
        sql = "Select SYID from tblSY where SY= '" & cboSY.Text & "' and Semester='" & cboSemester.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblSYID.Text = dr(0)
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
        cboCourse.DataSource = dt
        cboCourse.DisplayMember = "CourseName"
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Call loadCourse()
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
        sql = "Select CourseID from tblCourse where CourseName= '" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblCourseID.Text = dr(0)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

    Private Sub checkSection()
        sql = "Select SectionName from tblSections where SectionName ='" & txtSectionName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("The class section is already exist", MsgBoxStyle.Critical)
        Else
            saveSection()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call checkSection()
    End Sub

    Private Sub saveSection()
        sql = "Insert into tblSections(SectionName, YearLevel, SYID, DepartmentID, Semester, CourseID) values 
        (@SectionName, @YearLevel, @SYID, @DepartmentID, @Semester, @CourseID)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", txtSectionName.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@SYID", lblSYID.Text)
            .Parameters.AddWithValue("@DepartmentID", lblDepartmentID.Text)
            .Parameters.AddWithValue("@Semester", cboSemester.Text)
            .Parameters.AddWithValue("@CourseID", lblCourseID.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("New Section Successfully Save", MsgBoxStyle.Information)
        Call loadSection()
        ActLogs("Add New Sections")
    End Sub

    Private Sub clear()
        txtSectionName.Clear()
        cboYearLevel.Text = " "
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call updateSection()
        loadSection()
    End Sub

    Private Sub updateSection()
        sql = "UPDATE tblSections SET [SectionName]=@SectionName, [YearLevel]=@YearLevel, [DepartmentID]=@DepartmentID, [CourseID]=@CourseID WHERE SectionName=@SectionName"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", txtSectionName.Text)
            .Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            .Parameters.AddWithValue("@DepartmentID", lblDepartmentID.Text)
            .Parameters.AddWithValue("@CourseID", lblCourseID.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Section Successfully Updated", MsgBoxStyle.Information)
        ActLogs("Updated the Section Information")
    End Sub

    Private Sub txtSSection_TextChanged(sender As Object, e As EventArgs) Handles txtSSection.TextChanged
        Dim sql As String = "Select * from qrySections WHERE SectionName LIKE @searchText"
        If txtSSection.Text = "" Then
            sql = "SELECT * FROM qrySections "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSSection.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("SectionName").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseName").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub



    Private Sub txtSectionName_TextChanged(sender As Object, e As EventArgs) Handles txtSectionName.TextChanged
        sql = "Select SectionName, YearLevel, SY, Semester, Department, CourseName from qrySections where SectionName = '" & txtSectionName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtSectionName.Text = dr("SectionName").ToString
            cboYearLevel.Text = dr("YearLevel").ToString
            cboSY.Text = dr("SY").ToString
            cboSemester.Text = dr("Semester").ToString
            cboDepartment.Text = dr("Department").ToString
            cboCourse.Text = dr("CourseName").ToString
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtSectionName.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select a section to delete.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim sectionName As String = selectedItem.Text
        Dim sql As String = "DELETE FROM tblSections WHERE SectionName = @SectionName"

        Dim cmd As New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SectionName", sectionName)
        End With

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Section Successfully Deleted", MsgBoxStyle.Information)
                Call loadSection()
                ActLogs("Delete Section")
            Else
                MsgBox("No matching section found to delete.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error deleting section: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
