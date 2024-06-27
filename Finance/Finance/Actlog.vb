Imports System.Data.OleDb

Module Actlog
    Public Sub ActLogs(Action As String)
        Call connection()

        Dim time As String = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")
        Dim username As String = financedashboard.lbluser.Text
        Dim role As String = financedashboard.lblrole.Text

        sql = "INSERT INTO tblActivityLogs (Username, Role, [Activity], [DateTime]) VALUES (@Username, @Role, @Activity, @DateTime)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Role", role)
            .Parameters.AddWithValue("@Activity", Action)
            .Parameters.AddWithValue("@DateTime", time)
            .ExecuteNonQuery()
        End With
    End Sub
End Module
