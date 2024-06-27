Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Registrar
    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        Me.Close()
        frmEnrollment.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim Students As New Students
        Panel1.Controls.Clear()
        Students.Dock = DockStyle.Fill
        Panel1.Controls.Add(Students)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        Dim Subjects As New Subjects
        Panel1.Controls.Clear()
        Subjects.Dock = DockStyle.Fill
        Panel1.Controls.Add(Subjects)
    End Sub

    'Section Button
    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        Dim Section As New Section
        Panel1.Controls.Clear()
        Section.Dock = DockStyle.Fill
        Panel1.Controls.Add(Section)
    End Sub

    'Activity Logs Button
    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click
        Dim ActivityLogs As New ActivityLogs
        Panel1.Controls.Clear()
        ActivityLogs.Dock = DockStyle.Fill
        Panel1.Controls.Add(ActivityLogs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssDateTime.Text = Now.ToString
    End Sub

    Private Sub frmRegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadSubjectNo()
        LoadSY()
        LoadSemester()
        loadRegisterStudent()
    End Sub

    Private Sub loadRegisterStudent()
        'number of subjects
        sql = "SELECT COUNT(*) FROM tblEnrollment"
        cmd = New OleDbCommand(sql, cn)

        Dim numberOfSubjects As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblStudentNumber.Text = numberOfSubjects.ToString()
    End Sub

    Private Sub loadSubjectNo()
        'number of subjects
        sql = "SELECT COUNT(*) FROM tblSubjects"
        cmd = New OleDbCommand(sql, cn)

        Dim numberOfSubjects As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblSubjects.Text = numberOfSubjects.ToString()
    End Sub

    Private Sub LoadSY()
        ' SQL query to retrieve the open SY
        sql = "SELECT SY FROM tblSY WHERE Status = 'Open'"

        ' Create and execute the command
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            lblSY.Text = result.ToString()
        Else
            lblSY.Text = "No open SY found"
        End If
    End Sub

    Private Sub LoadSemester()
        ' SQL query to retrieve the open Semester
        Dim sql As String = "SELECT Semester FROM tblSY WHERE Status = 'Open'"

        ' Create and execute the command
        Using cmd As New OleDbCommand(sql, cn)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                lblSemester.Text = result.ToString()
            Else
                lblSemester.Text = "No open Semester found"
            End If
        End Using
    End Sub

    Private Sub lblSY_Click(sender As Object, e As EventArgs) Handles lblSY.Click

    End Sub
End Class
