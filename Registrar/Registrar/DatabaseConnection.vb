Imports System.Data.OleDb
Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tabin\OneDrive\Desktop\Enrollment System\Database\ES_Database.accdb"
        cn.Open()
        '  MsgBox("Connection Success", MsgBoxStyle.Information, "Database Connection")


    End Sub
End Module

