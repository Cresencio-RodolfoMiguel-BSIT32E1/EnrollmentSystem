Imports System.Data.OleDb

Public Class Students
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadStudents()
        SchoolYear()
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
        sql = "Select * from qryEnrolled ORDER BY StudentNo ASC "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ' Dim x As ListViewItem
        ListView1.Items.Clear()
        'ListView2.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("StudentNo").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("ContactNo").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString & ", " & dr("Street").ToString & " " & dr("Brgy").ToString & " " & dr("City").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop

        lblStudents.Text = ListView1.Items.Count.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = " SELECT * FROM qryEnrolled WHERE StudentNo LIKE @searchText OR Lastname LIKE @searchText OR Firstname LIKE @searchText
       OR StudentStatus LIKE @searchText OR StudentType LIKE @searchText"
        If txtSearch.Text = "" Then
            sql = "SELECT * FROM qryEnrolled"
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("StudentNo").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("Age").ToString)
            LV1.SubItems.Add(dr("Bdate").ToString)
            LV1.SubItems.Add(dr("Gender").ToString)
            LV1.SubItems.Add(dr("HouseNo").ToString & ", " & dr("Street").ToString & ", " & dr("Brgy").ToString & ", " & dr("City").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("CourseChoices").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("StudentStatus").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub

End Class
