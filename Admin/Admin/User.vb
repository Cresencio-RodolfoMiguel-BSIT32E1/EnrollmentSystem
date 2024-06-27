Imports System.Data.OleDb

Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadAccounts()
        getEmployeeNo()
    End Sub

    Private Sub loadAccounts()
        'retrieving all the records on the database
        sql = "Select * from qryUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("EmployeeNo").ToString)
            x.SubItems.Add(dr("Username").ToString)
            x.SubItems.Add(dr("Password").ToString)
            x.SubItems.Add(dr("ConfirmPassword").ToString)
            x.SubItems.Add(dr("Lastname").ToString)
            x.SubItems.Add(dr("Firstname").ToString)
            x.SubItems.Add(dr("Role").ToString)
            x.SubItems.Add(dr("AcctStatus").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        'retrieving specific records from database
        sql = "Select Username, Password, ConfirmPassword, Lastname, Firstname, Role, AcctStatus from qryUsers where EmployeeNo = '" & txtEmpNo.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtUsername.Text = dr("Username").ToString
            txtPassword.Text = dr("Password").ToString
            txtConfirmPassword.Text = dr("ConfirmPassword").ToString
            txtLastname.Text = dr("Lastname").ToString
            txtFirstname.Text = dr("Firstname").ToString
            cboRole.Text = dr("Role").ToString
            cboAcctStatus.Text = dr("AcctStatus").ToString
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Password is mismatched!", MsgBoxStyle.Critical)
        ElseIf txtPassword.TextLength < 6 Or txtConfirmPassword.TextLength < 6 Then
            MsgBox("Password must atleast 6 characters or above", MsgBoxStyle.Exclamation)
        Else
            Call updateData()
        End If
    End Sub

    Private Sub updateData()
        Dim sql As String = "UPDATE tblUsers SET Username=@Username, [Password]=@Password, ConfirmPassword=@ConfirmPassword, Lastname=@Lastname, Firstname=@Firstname, Role=@Role, AcctStatus=@AcctStatus WHERE EmployeeNo=@EmployeeNo"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@ConfirmPassword", txtConfirmPassword.Text)
            .Parameters.AddWithValue("@Lastname", txtLastname.Text)
            .Parameters.AddWithValue("@Firstname", txtFirstname.Text)
            .Parameters.AddWithValue("@Role", cboRole.Text)
            .Parameters.AddWithValue("@AcctStatus", cboAcctStatus.Text)
            .Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text) 'Assuming employeeNo is a variable holding the value of the employee number to be updated
            .ExecuteNonQuery()
        End With

        updatePassword()
        MsgBox("User record successfully updated", MsgBoxStyle.Information)
        loadAccounts()
    End Sub
    Private Sub updatePassword()
        sql = "UPDATE tblUsers SET [Password]=@Password WHERE EmployeeNo=@EmployeeNo"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtEmpNo.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        getEmployeeNo()
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CheckRecords()
        loadAccounts()
    End Sub

    Private Sub SaveData()
        sql = "Insert Into tblUsers ([EmployeeNo], [Username], [Password], [ConfirmPassword], [Lastname], [Firstname], [Role], [AcctStatus]) 
        values ([@EmployeeNo], [@Username], [@Password], [@ConfirmPassword], [@Lastname], [@Firstname], [@Role], [@AcctStatus])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@EmployeeNo]", txtEmpNo.Text)
            .Parameters.AddWithValue("[@Username]", txtUsername.Text)
            .Parameters.AddWithValue("[@Password]", txtPassword.Text)
            .Parameters.AddWithValue("[@ConfirmPassword]", txtConfirmPassword.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastname.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstname.Text)
            .Parameters.AddWithValue("[@Role]", cboRole.Text)
            .Parameters.AddWithValue("[@AcctStatus]", cboAcctStatus.Text)
            .ExecuteNonQuery()
        End With

    End Sub

    Private Sub CheckRecords()
        sql = "Select Username from tblUsers where Username='" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            MsgBox("User account is already Exist", MsgBoxStyle.Exclamation)

        ElseIf String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtLastname.Text) OrElse String.IsNullOrWhiteSpace(txtFirstname.Text) _
            OrElse String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtConfirmPassword.Text) _
            OrElse String.IsNullOrWhiteSpace(cboRole.Text) OrElse String.IsNullOrWhiteSpace(cboAcctStatus.Text) Then
            MsgBox("All fields are required!", vbCritical, "Error")
            Return
        Else
            If MsgBox("Are you sure you want to save this user account?", vbQuestion + vbYesNo) = vbYes Then
                MsgBox("Saved Successfully!", MsgBoxStyle.Information, "New User Saved")
                SaveData()
                ActLogs("Saved a New User Account")
            Else
                MsgBox("User account not saved.", MsgBoxStyle.Information, "Operation Canceled")
            End If
        End If
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

    Private Sub clear()
        txtUsername.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cboRole.Text = " "
        cboAcctStatus.Text = " "
    End Sub

End Class
