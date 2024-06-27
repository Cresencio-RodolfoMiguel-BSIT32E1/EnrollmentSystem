Imports System.Data.OleDb

Public Class AdmissionLogin
    Private Sub AdmissionLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(txtusername, "Username")
        SetPlaceholder(txtpw, "Password")

        Call connection()
    End Sub
    Private Sub SetPlaceholder(textBox As TextBox, placeholder As String)
        textBox.Text = placeholder
        textBox.ForeColor = Color.Gray
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtpw.Text) Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Information, "Error")
            Return
        End If

        sql = "SELECT * FROM tblUsers WHERE Username= @username AND Password= @password"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", txtusername.Text)
        cmd.Parameters.AddWithValue("@password", txtpw.Text)

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Me.Hide()
            MainDashboard.lblrole.Text = dr("Role").ToString ' Replace "" with the appropriate column name
            MainDashboard.Show()
        Else
            MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub



    Private Sub txtusername_MouseEnter(sender As Object, e As EventArgs) Handles txtusername.MouseEnter
        SetMouseEnter(txtusername, "Username")
    End Sub

    Private Sub txtusername_MouseLeave(sender As Object, e As EventArgs) Handles txtusername.MouseLeave
        SetMouseLeave(txtusername, "Username")
    End Sub

    Private Sub txtpw_MouseEnter(sender As Object, e As EventArgs) Handles txtpw.MouseEnter
        SetMouseEnter(txtpw, "Password")

    End Sub

    Private Sub txtpw_MouseLeave(sender As Object, e As EventArgs) Handles txtpw.MouseLeave
        SetMouseLeave(txtpw, "Password")
    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        ' Prevent editing if the text is the placeholder
        If txtusername.Text = "Username" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpw.KeyPress
        ' Prevent editing if the text is the placeholder
        If txtpw.Text = "Password" Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtpw_TextChanged(sender As Object, e As EventArgs) Handles txtpw.TextChanged
        ' Set PasswordChar to "●" when typing the password
        If txtpw.Text = "Password" Then
            txtpw.PasswordChar = ControlChars.NullChar
        Else
            txtpw.PasswordChar = "●"
        End If
    End Sub

    Private Sub SetMouseEnter(textBox As TextBox, placeholder As String)
        If textBox.Text = placeholder Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SetMouseLeave(textBox As TextBox, placeholder As String)
        If textBox.Text = "" Then
            SetPlaceholder(textBox, placeholder)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Code to execute when the CheckBox is checked
            txtpw.PasswordChar = ""
            txtpw.UseSystemPasswordChar = False
        Else
            ' Code to execute when the CheckBox is unchecked
            txtpw.PasswordChar = "●"
            txtpw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class