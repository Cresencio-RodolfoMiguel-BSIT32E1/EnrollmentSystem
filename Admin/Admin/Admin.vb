Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Admin

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssDateTime.Text = Now.ToString
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Dim User As New User
        Panel1.Controls.Clear()
        User.Dock = DockStyle.Fill
        Panel1.Controls.Add(User)
    End Sub

    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click
        Dim ActivityLog As New ActivityLog
        Panel1.Controls.Clear()
        ActivityLog.Dock = DockStyle.Fill
        Panel1.Controls.Add(ActivityLog)
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'number of subjects
        sql = "SELECT COUNT(*) FROM tblUsers"
        cmd = New OleDbCommand(sql, cn)

        Dim numberOfSubjects As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblUsers.Text = numberOfSubjects.ToString()
    End Sub

    Private Sub btnManageSY_Click(sender As Object, e As EventArgs) Handles btnManageSY.Click
        Dim SchoolYear As New SchoolYear
        Panel1.Controls.Clear()
        SchoolYear.Dock = DockStyle.Fill
        Panel1.Controls.Add(SchoolYear)
    End Sub
End Class