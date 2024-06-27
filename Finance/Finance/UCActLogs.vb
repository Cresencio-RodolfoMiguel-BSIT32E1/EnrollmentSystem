Imports System.Data.OleDb
Imports Microsoft.Win32

Public Class UCActLogs
    Private Sub ActivityLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadActivityLog()
    End Sub

    Private Sub loadActivityLog()
        ' Assuming lblrole contains the role of the current user
        Dim role As String = financedashboard.lblrole.Text

        ' Modify the SQL query to filter by role
        sql = "Select * from tblActivityLogs where Role = @Role"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Role", role)

        dr = cmd.ExecuteReader()
        Dim x As ListViewItem
        ActLogs.Items.Clear()
        Do While dr.Read()
            x = New ListViewItem(dr("Username").ToString())
            x.SubItems.Add(dr("Role").ToString())
            x.SubItems.Add(dr("Activity").ToString())
            x.SubItems.Add(dr("DateTime").ToString())
            ActLogs.Items.Add(x)
        Loop

        dr.Close() ' Always good practice to close the data reader when done
    End Sub
End Class
