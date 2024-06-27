Imports System.Data.OleDb
Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String
    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\aral\3rd yr32E1\systems integration and architecture\code\Finance\Finance\bin\Debug\Enrollment_db.accdb"
        cn.Open()
        'MsgBox("Connection Success", MsgBoxStyle.Information, "Database Connection")
    End Sub
End Module
