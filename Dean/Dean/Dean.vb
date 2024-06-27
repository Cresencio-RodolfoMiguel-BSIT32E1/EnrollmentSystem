Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class Dean
    Private Sub DeanDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        loadTeacher()
        loadTeacher()

    End Sub

    'Shows the count of total teachers
    Private Sub loadTeacher()
        'number of subjects
        sql = "SELECT COUNT(*) FROM tblTeachers"
        cmd = New OleDbCommand(sql, cn)

        Dim numberOfSubjects As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblTeacher.Text = numberOfSubjects.ToString()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Login.Show()
    End Sub

    'Button for Students
    Private Sub btnStudent_Click_1(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim Students As New Students
        Panel1.Controls.Clear()
        Students.Dock = DockStyle.Fill
        Panel1.Controls.Add(Students)
    End Sub

    'Button for Subjects
    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        Dim Subjects As New Subjects
        Panel1.Controls.Clear()
        Subjects.Dock = DockStyle.Fill
        Panel1.Controls.Add(Subjects)
    End Sub

    'Button for Teachers
    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        Dim Teachers As New Teachers
        Panel1.Controls.Clear()
        Teachers.Dock = DockStyle.Fill
        Panel1.Controls.Add(Teachers)
    End Sub

    'Button for Schedule
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim Scheduling As New Scheduling
        Panel1.Controls.Clear()
        Scheduling.Dock = DockStyle.Fill
        Panel1.Controls.Add(Scheduling)
    End Sub

    'Button for Activity Logs
    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click
        Dim ActivityLogs As New ActivityLogs
        Panel1.Controls.Clear()
        ActivityLogs.Dock = DockStyle.Fill
        Panel1.Controls.Add(ActivityLogs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssDateTime.Text = Now.ToString
    End Sub
End Class