Imports System.Data.OleDb

Public Class ActivityLog
    Private Sub ActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadActivityLog()
    End Sub

    Private Sub loadActivityLog()
        sql = "Select * from tblActivityLogs"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", Admin.tssUsername.Text)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("Username").ToString)
            x.SubItems.Add(dr("Role").ToString)
            x.SubItems.Add(dr("Activity").ToString)
            x.SubItems.Add(dr("DateTime").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

End Class
