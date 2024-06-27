Imports System.Data.OleDb

Public Class Subjects
    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadSubjects()
        Call SchoolYear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub SaveSubject()
        sql = "Insert Into tblSubjects([SubjCode], [Description], [Units], [Status]) 
        values ([@SubjCode], [@Description], [@Units], [@Status])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@SubjCode]", txtCCode.Text)
            .Parameters.AddWithValue("[@Description]", txtCDescription.Text)
            .Parameters.AddWithValue("[@Units]", txtUnits.Text)
            .Parameters.AddWithValue("[@Status]", cboStatus.Text)
            .ExecuteNonQuery()
        End With

    End Sub

    Private Sub clear()
        txtCCode.Clear()
        txtCDescription.Clear()
        txtUnits.Clear()
        cboStatus.Text = " "
    End Sub

    Private Sub CheckSubjects()
        sql = "Select SubjCode from tblSubjects where SubjCode='" & txtCCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            MsgBox("Subject is already Exist", MsgBoxStyle.Exclamation)

        ElseIf String.IsNullOrWhiteSpace(txtCCode.Text) OrElse
            String.IsNullOrWhiteSpace(txtCDescription.Text) OrElse
            String.IsNullOrWhiteSpace(txtUnits.Text) _
            OrElse String.IsNullOrWhiteSpace(cboStatus.Text) Then
            MsgBox("All fields are required!", vbCritical, "Error")
            Return
        Else
            If MsgBox("Are you sure you want to save this subject?", vbQuestion + vbYesNo) = vbYes Then
                MsgBox("Saved Successfully!", MsgBoxStyle.Information, "New Subject Saved")
                SaveSubject()
                ActLogs("Saved a New Subjects")
            Else
                MsgBox("Subject not saved.", MsgBoxStyle.Information, "Operation Canceled")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CheckSubjects()
        LoadSubjects()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
        ActLogs("Add New Subjects")
    End Sub

    Private Sub LoadSubjects()
        sql = "Select * from qrySubjects"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("SubjCode").ToString)
            x.SubItems.Add(dr("Description").ToString)
            x.SubItems.Add(dr("Units").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub SchoolYear()
        sql = "Select distinct SY from tblSY where status= 'Open' "
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSY.DataSource = dt
        cboSY.DisplayMember = "SY"
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtCCode.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtCCode_TextChanged(sender As Object, e As EventArgs) Handles txtCCode.TextChanged
        'retrieving specific records from database
        sql = "Select SubjCode, Description, Units, Status from qrySubjects where SubjCode = '" & txtCCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtCCode.Text = dr("SubjCode").ToString
            txtCDescription.Text = dr("Description").ToString
            txtUnits.Text = dr("Units").ToString
            cboStatus.Text = dr("Status").ToString
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateSubjects()
    End Sub

    Private Sub updateSubjects()
        sql = "UPDATE tblSubjects SET [SubjCode]=@SubjCode, [Description]=@Description, [Units]=@Units, [Status]=@Status WHERE SubjCode=@SubjCode"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SubjCode", txtCCode.Text)
            .Parameters.AddWithValue("@Description", txtCDescription.Text)
            .Parameters.AddWithValue("@Units", txtUnits.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Subjects Successfully Updated", MsgBoxStyle.Information)
        LoadSubjects()
        ActLogs("Updated the Subject Information")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = " Select * from qrySubjects WHERE SubjCode LIKE @searchText OR Description LIKE @searchText"
        If txtSearch.Text = "" Then
            sql = "SELECT * FROM qrySubjects "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()

        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("SubjCode").ToString)
            ' x = New ListViewItem
            LV1.SubItems.Add(dr("Description").ToString)
            LV1.SubItems.Add(dr("Units").ToString)
            LV1.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub


End Class
