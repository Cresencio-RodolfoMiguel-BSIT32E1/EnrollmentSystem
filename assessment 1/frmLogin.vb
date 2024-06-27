Imports System.Data.OleDb

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        CheckLogin()
    End Sub

    Private Sub CheckLogin()
        sql = "Select AcctStatus from tblUsers where Username=@Username"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            lblStatus.Text = dr("AcctStatus").ToString()

            If lblStatus.Text = "Disable" Then
                MsgBox("Your Account is Disabled. Contact the admin to activate your account.", MsgBoxStyle.Exclamation, "Disabled")
                Exit Sub
            Else
                PerformLogin()
            End If
        End If
    End Sub

    Private Sub PerformLogin()
        sql = "Select * from tblUsers where username = @username and password = @password"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Dim lastname As String = dr("lastname").ToString()
            Dim firstname As String = dr("firstname").ToString()

            Dim fullname As String = lastname & ", " & firstname

            MsgBox("Login Success", MsgBoxStyle.Information)
            Form1.tssUsername.Text = fullname
            Form1.tssRole.Text = Me.lblRole.Text
            Form1.tssDateTime.Text = Now.ToString
            Form1.Show()
            Me.Hide()
            clear()

        Else
            MsgBox("Login failed. Incorrect username or password.", MsgBoxStyle.Critical)
            lblAttempts.Text = lblAttempts.Text - 1
            If lblAttempts.Text = 0 Then
                MsgBox("You reached the maximum attempt limits", MsgBoxStyle.Critical)
                Call DisableAccount()
                btnLogin.Enabled = False
            End If
        End If
    End Sub

    Private Sub DisableAccount()
        sql = "Update tblUsers SET AcctStatus=@AcctStatus where Username=@Username"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AcctStatus", "Disable")
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Your account is disabled, Contact the admin to activate your account", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        lblRole.Text = " "
        lblAttempts.Text = 3
    End Sub

    Private Sub frmClientLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        sql = "Select [lastname], [firstname], [role], [AcctStatus] from tblUsers where username=@Username"

        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

        dr = cmd.ExecuteReader()

        If dr.Read() Then

            Dim lastname As String = dr("lastname").ToString()
            Dim firstname As String = dr("firstname").ToString()

            Dim fullname As String = lastname & ", " & firstname

            lblRole.Text = dr("role").ToString()
            lblStatus.Text = dr("AcctStatus").ToString()

        End If
    End Sub
End Class