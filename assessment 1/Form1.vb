Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class Form1

    Private Sub btnPreAssessment_Click(sender As Object, e As EventArgs) Handles btnassess.Click
        Dim Assesment As New Assesment
        Panel2.Controls.Clear()
        Assesment.Dock = DockStyle.Fill
        Panel2.Controls.Add(Assesment)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click
        Dim ActivityLogs As New ActivityLogs
        Panel2.Controls.Clear()
        ActivityLogs.Dock = DockStyle.Fill
        Panel2.Controls.Add(ActivityLogs)
    End Sub
End Class