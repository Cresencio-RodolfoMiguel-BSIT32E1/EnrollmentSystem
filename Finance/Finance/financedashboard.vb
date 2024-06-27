Public Class financedashboard
    Private Sub financedashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnstudentlist_Click(sender As Object, e As EventArgs) Handles btnstudentlist.Click
        Dim UCStudentlist As New UCStudentlist()
        Panel1.Controls.Clear()
        UCStudentlist.Dock = DockStyle.Fill
        Panel1.Controls.Add(UCStudentlist)
    End Sub
    Private Sub btnactlogs_Click(sender As Object, e As EventArgs) Handles btnactlogs.Click
        Dim UCActLogs As New UCActLogs()
        Panel1.Controls.Clear()
        UCActLogs.Dock = DockStyle.Fill
        Panel1.Controls.Add(UCActLogs)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo, "Information") = vbYes Then
            MsgBox("You are now logging out.", MsgBoxStyle.Information, "Information")
            'logout
            'Call savelogouttime()
            Login.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Now.ToString
    End Sub
End Class