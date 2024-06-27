Imports System.Data.OleDb

Public Class frmStudentList
    Private Sub frmStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadStudents()
    End Sub
    Private Sub loadStudents()
        sql = "SELECT * FROM tblEnrollment ORDER BY RegistrationNo ASC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("RegistrationNo").ToString)
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("Course").ToString)
            LV1.SubItems.Add(dr("Section").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("Assessor").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim sql As String = "SELECT * FROM tblEnrollment WHERE Lastname LIKE @searchText OR StudentNo LIKE @searchText OR Firstname LIKE @searchText "

        If txtSearch.Text = "" Then
            sql = "SELECT * FROM tblEnrollment "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("RegistrationNo").ToString)
            LV1.SubItems.Add(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("Course").ToString)
            LV1.SubItems.Add(dr("Section").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("Assessor").ToString)
            ListView1.Items.Add(LV1)
        Loop


    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            frmAssessment.lblRegNum.Text = selectedItem.SubItems(0).Text
            frmAssessment.txtStudentNo.Text = selectedItem.SubItems(1).Text
            frmAssessment.txtname.Text = selectedItem.SubItems(2).Text
            frmAssessment.cboYearLevel.Text = selectedItem.SubItems(3).Text
            frmAssessment.cboDepartment.Text = selectedItem.SubItems(4).Text
            frmAssessment.cboCourse.Text = selectedItem.SubItems(5).Text
            frmAssessment.cboSection.Text = selectedItem.SubItems(6).Text
            frmAssessment.cbosyear.Text = selectedItem.SubItems(7).Text
            frmAssessment.cboSemester.Text = selectedItem.SubItems(8).Text
            frmAssessment.lblAssessOf.Text = selectedItem.SubItems(10).Text

            frmAssessment.Show()

        Else
            MsgBox("No item selected")
        End If
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class