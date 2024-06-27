Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class ApplicantReports
    Private Sub ApplicantReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboreporttype.SelectedItem = "All"
        lbldate.Format = DateTimePickerFormat.Short
        lbldate.Text = Now.ToShortDateString
    End Sub
    'Private Sub GetTotal()
    '    Const col As Integer = 2
    '    Dim total As Integer
    '    Dim lvsi As ListViewItem.ListViewSubItem
    '    For i As Integer = 0 To ListView1.Items.Count - 1
    '        lvsi = ListView1.Items(i).SubItems(col)
    '        total += Double.Parse(lvsi.Text)
    '    Next
    '    lbltotal.Text = total.ToString
    'End Sub
    Private Sub GetTotal()
        Const col As Integer = 1 ' Assuming column index starts from 0
        Dim total As Integer = 0

        For Each item As ListViewItem In ListView1.Items
            If item.SubItems.Count > col Then ' Check if the item has the specified column
                Dim name As String = item.SubItems(col).Text ' Get the name from the specified column
                ' Check if the name is not empty before counting
                If Not String.IsNullOrEmpty(name) Then
                    total += 1 ' Increment total for each non-empty name
                End If
            End If
        Next

        lbltotal.Text = total.ToString()
    End Sub
    Private Sub AllApplicants()
        sql = "SELECT RegistrationNo, Firstname, Middlename, Familyname, ApplicantStatus, DateAdded,  Course, AcademicYear FROM qryApplicants"
        cmd = New OleDbCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("RegistrationNo").ToString)
            x.SubItems.Add(dr("Firstname").ToString & " " & dr("Middlename").ToString & " " & dr("Familyname").ToString)
            x.SubItems.Add(dr("ApplicantStatus").ToString)
            x.SubItems.Add(dr("DateAdded").ToString)
            x.SubItems.Add(dr("Course").ToString)
            x.SubItems.Add(dr("AcademicYear").ToString)
            ListView1.Items.Add(x)
        Loop
        dr.Close()

        ' Close the connection after done using it
        cn.Close()
        Call GetTotal()
    End Sub
    Private Sub DailyApplicants()
        sql = "SELECT RegistrationNo, Firstname, Middlename, Familyname, ApplicantStatus, DateAdded, Course, AcademicYear FROM qryApplicants"
        cmd = New OleDbCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim DateAdded As DateTime = Convert.ToDateTime(dr("DateAdded"))

            If DateAdded.Date = lbldate.Value.Date Then
                x = New ListViewItem(dr("RegistrationNo").ToString)
                x.SubItems.Add(dr("Firstname").ToString & " " & dr("Middlename").ToString & " " & dr("Familyname").ToString)
                x.SubItems.Add(dr("ApplicantStatus").ToString)
                x.SubItems.Add(dr("DateAdded").ToString)
                x.SubItems.Add(dr("Course").ToString)
                x.SubItems.Add(dr("AcademicYear").ToString)
                ListView1.Items.Add(x)
            End If
        Loop
        dr.Close()

        ' Close the connection after done using it
        cn.Close()
        Call GetTotal()
    End Sub
    Private Sub MonthlyApplicants()
        sql = "SELECT RegistrationNo, Firstname, Middlename, Familyname, ApplicantStatus, DateAdded, Course, AcademicYear FROM qryApplicants"
        cmd = New OleDbCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim DateAdded As DateTime = Convert.ToDateTime(dr("DateAdded"))


            If DateAdded.Year = lbldate.Value.Year AndAlso DateAdded.Month = lbldate.Value.Month Then
                x = New ListViewItem(dr("RegistrationNo").ToString)
                x.SubItems.Add(dr("Firstname").ToString & " " & dr("Middlename").ToString & " " & dr("Familyname").ToString)
                x.SubItems.Add(dr("ApplicantStatus").ToString)
                x.SubItems.Add(dr("DateAdded").ToString)
                x.SubItems.Add(dr("Course").ToString)
                x.SubItems.Add(dr("AcademicYear").ToString)
                ListView1.Items.Add(x)
            End If
        Loop
        dr.Close()

        ' Close the connection after done using it
        cn.Close()
        Call GetTotal()
    End Sub
    Private Sub YearlyApplicants()
        sql = "SELECT RegistrationNo, Firstname, Middlename, Familyname, ApplicantStatus, DateAdded, Course, AcademicYear FROM qryApplicants"
        cmd = New OleDbCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim DateAdded As DateTime = Convert.ToDateTime(dr("DateAdded"))
            If DateAdded.Year = lbldate.Value.Year Then
                x = New ListViewItem(dr("RegistrationNo").ToString)
                x.SubItems.Add(dr("Firstname").ToString & " " & dr("Middlename").ToString & " " & dr("Familyname").ToString)
                x.SubItems.Add(dr("ApplicantStatus").ToString)
                x.SubItems.Add(dr("DateAdded").ToString)
                x.SubItems.Add(dr("Course").ToString)
                x.SubItems.Add(dr("AcademicYear").ToString)
                ListView1.Items.Add(x)
            End If
        Loop
        dr.Close()

        ' Close the connection after done using it
        cn.Close()
        Call GetTotal()
    End Sub
    Private Sub cboreporttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboreporttype.SelectedIndexChanged
        Select Case cboreporttype.Text.ToString
            Case "All"
                lbldate.Format = DateTimePickerFormat.Short
                lbldate.Text = Now.ToShortDateString
                Call AllApplicants()
            Case "Daily"
                lbldate.Format = DateTimePickerFormat.Short
                lbldate.Text = Now.ToShortDateString
                Call DailyApplicants()
            Case "Monthly"
                lbldate.Format = DateTimePickerFormat.Custom
                lbldate.CustomFormat = "MM/yyyy"
                Call MonthlyApplicants()
            Case "Yearly"
                Dim startOfYear As New DateTime(Now.Year, 1, 1)
                lbldate.Format = DateTimePickerFormat.Custom
                lbldate.CustomFormat = "yyyy"
                Call YearlyApplicants()
        End Select
    End Sub
    Private Sub lbldate_ValueChanged(sender As Object, e As EventArgs) Handles lbldate.ValueChanged
        Select Case cboreporttype.SelectedItem.ToString()
            Case "All"
                Call AllApplicants()
            Case "Daily"
                Call DailyApplicants()
            Case "Monthly"
                Call MonthlyApplicants()
            Case "Yearly"
                Call YearlyApplicants()
        End Select
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub
End Class
