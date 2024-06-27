Imports System.Data.OleDb

Public Class Subjects
    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadSubjects()
        SchoolYear()
    End Sub

    Private Sub LoadSubjects()
        sql = "Select * from qrySubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Description").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop

        lblTotalSubs.Text = ListView1.Items.Count.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = "SELECT * FROM qrySubjects WHERE SubjCode LIKE @searchText OR Description LIKE @searchText"
        If txtSearch.Text = "" Then
            sql = "SELECT * FROM qrySubjects "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("SubjCode").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("Description").ToString)
            LV1.SubItems.Add(dr("Units").ToString)
            LV1.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(LV1)
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

End Class
