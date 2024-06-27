Imports System.Data.OleDb
Public Class FrmCreateAccount
    Private Sub FrmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        getEmployeeNo()
    End Sub
    Private Sub getEmployeeNo()
        sql = "Select EmployeeNo from tblUsers order by EmployeeNo desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtEmpNo.Text = Val(dr(0)) + 1
        Else
            txtEmpNo.Text = 10000
        End If
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If String.IsNullOrEmpty(txtEmpNo.Text) Or
           String.IsNullOrEmpty(txtLastname.Text) Or
           String.IsNullOrEmpty(txtFirstname.Text) Or
           String.IsNullOrEmpty(txtUsername.Text) Or
           String.IsNullOrEmpty(txtPassword.Text) Or
           String.IsNullOrEmpty(cboRole.Text) Then
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Password and Confirm Password Mismatch", MsgBoxStyle.Critical, "Re-type your Password")
        ElseIf txtPassword.TextLength < 6 Then
            MsgBox("Password is less than 6 characters", MsgBoxStyle.Critical)
        Else
            Call CheckifExist()
        End If
    End Sub

    Private Sub SaveData()
        sql = "Insert Into tblUsers([EmployeeNo],[Lastname], [Firstname], [Username], [Password],[Role], [AcctStatus]) values ([@EmployeeNo], [@Lastname], [@Firstname], [@Username], [@Password], [@Role], [@AcctStaus])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@EmployeeNo]", txtEmpNo.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastname.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstname.Text)
            .Parameters.AddWithValue("[@Username]", txtUsername.Text)
            .Parameters.AddWithValue("[@Password]", txtPassword.Text)
            .Parameters.AddWithValue("[@Role]", cboRole.Text)
            .Parameters.AddWithValue("[@AcctStatus]", "Active")
            .ExecuteNonQuery()
        End With
        MsgBox("New Record Successfully Added", MsgBoxStyle.Information, "Save Data")
    End Sub
    Private Sub CheckifExist()
        sql = "Select username from tblUsers where username ='" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Username already exist", MsgBoxStyle.Exclamation, "Duplicate Records")
        Else
            Call SaveData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmpNo.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Show()
    End Sub

End Class