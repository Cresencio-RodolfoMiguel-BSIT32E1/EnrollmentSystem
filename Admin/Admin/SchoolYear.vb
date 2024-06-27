Imports System.Data.OleDb

Public Class SchoolYear
    Private Sub SchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSY()
    End Sub

    Private Sub loadSY()
        Dim sql As String = "Select * from tblSY"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("SYID").ToString)
            x.SubItems.Add(dr("SY").ToString)
            x.SubItems.Add(dr("Semester").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sy As String = txtSY.Text
        Dim semester As String = cboSemester.SelectedItem.ToString()
        Dim status As String = cboStatus.SelectedItem.ToString()

        If String.IsNullOrEmpty(sy) Or String.IsNullOrEmpty(semester) Or String.IsNullOrEmpty(status) Then
            MessageBox.Show("Please fill in all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim sql As String = "INSERT INTO tblSY (SY, Semester, Status) VALUES (@SY, @Semester, @Status)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@SY", sy)
                cmd.Parameters.AddWithValue("@Semester", semester)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call loadSY()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a record to update", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim syID As String = selectedItem.Text
        Dim sy As String = txtSY.Text
        Dim semester As String = cboSemester.SelectedItem.ToString()
        Dim status As String = cboStatus.SelectedItem.ToString()

        If String.IsNullOrEmpty(sy) Or String.IsNullOrEmpty(semester) Or String.IsNullOrEmpty(status) Then
            MessageBox.Show("Please fill in all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE tblSY SET SY = @SY, Semester = @Semester, Status = @Status WHERE SYID = @SYID"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@SY", sy)
                cmd.Parameters.AddWithValue("@Semester", semester)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@SYID", syID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call loadSY()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
