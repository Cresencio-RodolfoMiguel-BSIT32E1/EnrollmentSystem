Imports System.Data.OleDb
Public Class frmStudentsRecord

    Private Sub loadStudents()
        sql = "SELECT * FROM qryEnrolled WHERE StudentNo IS NOT NULL AND StudentNo <> '' ORDER BY StudentNo ASC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()

        Do While dr.Read = True
            If Not IsDBNull(dr("StudentNo")) AndAlso Not String.IsNullOrEmpty(dr("StudentNo").ToString()) Then
                Dim LV1 As New ListViewItem(dr("StudentNo").ToString)
                LV1.SubItems.Add(dr("Lastname").ToString)
                LV1.SubItems.Add(dr("Firstname").ToString)
                LV1.SubItems.Add(dr("Middlename").ToString)
                LV1.SubItems.Add(dr("Department").ToString)
                LV1.SubItems.Add(dr("CourseChoices").ToString)
                LV1.SubItems.Add(dr("Semester").ToString)
                LV1.SubItems.Add(dr("StudentType").ToString)
                LV1.SubItems.Add(dr("YearLevel").ToString)
                ListView1.Items.Add(LV1)
            End If
        Loop
    End Sub

    Private Sub frmStudentsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadStudents()
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
            If Not IsDBNull(dr("StudentNo")) AndAlso Not String.IsNullOrEmpty(dr("StudentNo").ToString()) Then
                Dim LV1 As New ListViewItem(dr("StudentNo").ToString)
                LV1.SubItems.Add(dr("Lastname").ToString)
                LV1.SubItems.Add(dr("Firstname").ToString)
                LV1.SubItems.Add(dr("Middlename").ToString)
                LV1.SubItems.Add(dr("Department").ToString)
                LV1.SubItems.Add(dr("CourseChoices").ToString)
                LV1.SubItems.Add(dr("Semester").ToString)
                LV1.SubItems.Add(dr("StudentType").ToString)
                LV1.SubItems.Add(dr("YearLevel").ToString)
                ListView1.Items.Add(LV1)
            End If
        Loop
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            frmEnrollment.txtStudentNo.Text = selectedItem.SubItems(0).Text
            frmEnrollment.txtLastName.Text = selectedItem.SubItems(1).Text
            frmEnrollment.txtFirstName.Text = selectedItem.SubItems(2).Text
            frmEnrollment.txtMiddlename.Text = selectedItem.SubItems(3).Text
            frmEnrollment.cboDepartment.Text = selectedItem.SubItems(4).Text
            frmEnrollment.cboCourse.Text = selectedItem.SubItems(5).Text
            frmEnrollment.cboSemester.Text = selectedItem.SubItems(6).Text
            frmEnrollment.txtStudentType.Text = selectedItem.SubItems(7).Text
            frmEnrollment.cboYearLevel.Text = selectedItem.SubItems(8).Text
            frmEnrollment.Show()
        Else
            MsgBox("No item selected")
        End If
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class