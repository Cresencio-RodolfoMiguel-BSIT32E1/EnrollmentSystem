Imports System.Data.OleDb
Public Class ListofApplicants

    Private Sub ListofApplicants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadApplicants()
        Call disableupdatebtn()
        lblregisno.Hide()
    End Sub
    Dim x As ListViewItem
    Private Sub loadApplicants()
        sql = "Select * from tblAdmissionRegistration"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("AdmissionID").ToString)
            x.SubItems.Add(dr("RegistrationNo").ToString)
            x.SubItems.Add(dr("Firstname").ToString & " " & dr("Middlename").ToString & " " & dr("Familyname").ToString)
            x.SubItems.Add(dr("Birthdate").ToString)
            x.SubItems.Add(dr("Age").ToString)
            x.SubItems.Add(dr("Sex").ToString)
            x.SubItems.Add("BLK-" & dr("Block").ToString & " LOT-" & dr("Lot").ToString & " " & dr("Street").ToString & " Street " & dr("Barangay").ToString & " " & dr("Municipality").ToString)
            x.SubItems.Add(dr("ContactNo").ToString)
            x.SubItems.Add(dr("EmailAddress").ToString)
            x.SubItems.Add(dr("ApplicantStatus").ToString)
            x.SubItems.Add(dr("Course").ToString)
            If cboapplicantstatus.Text = "New (Freshmen)" Then
                x.SubItems.Add(12).Text = "New (Freshmen)"
            ElseIf cboapplicantstatus.Text = "Transferee" Then
                x.SubItems.Add(12).Text = "Transferee"
            End If
            x.SubItems.Add(dr("DateAdded").ToString)
            ListView1.Items.Add(x)
        Loop

    End Sub

    Private Sub txtAdmissionID_TextChanged(sender As Object, e As EventArgs) Handles txtAdmissionID.TextChanged
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            sql = "SELECT RegistrationNo, Firstname, Middlename, Familyname, Birthdate, Age, Sex, Block, Lot, Street, Barangay, Municipality, ContactNo, EmailAddress, Course, ApplicantStatus, DateAdded FROM tblAdmissionRegistration WHERE AdmissionID = @AdmissionID"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AdmissionID", Convert.ToInt32(txtAdmissionID.Text))
            dr = cmd.ExecuteReader()

            If dr.Read Then
                lblregisno.Text = dr("RegistrationNo").ToString()
                txtfirstname.Text = dr("Firstname").ToString()
                txtmiddlename.Text = dr("Middlename").ToString()
                txtfamilyname.Text = dr("Familyname").ToString()
                datebirthdate.Text = dr("Birthdate").ToString()
                txtage.Text = dr("Age").ToString()
                cbosex.Text = dr("Sex").ToString()
                txtblock.Text = dr("Block").ToString()
                txtlot.Text = dr("Lot").ToString()
                txtstreet.Text = dr("Street").ToString()
                cbomunicipality.Text = dr("Municipality").ToString()
                cbobrgy.Text = dr("Barangay").ToString()
                txtcontactno.Text = dr("ContactNo").ToString()
                txtemail.Text = dr("EmailAddress").ToString()
                cboapplicantstatus.Text = dr("ApplicantStatus").ToString()
                txtdateadded.Text = dr("DateAdded").ToString()
                cbocourse.Text = dr("Course").ToString()
                Call disableupdatebtn()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    'Private Sub txtAdmissionID_TextChanged(sender As Object, e As EventArgs) Handles txtAdmissionID.TextChanged
    '    sql = "SELECT RegistrationNo,Firstname,Middlename,Familyname,Birthdate,Age,Sex,Block,Lot,Street,Barangay,Municipality,ContactNo,EmailAddress,ApplicantStatus FROM tblAdmissionRegistration WHERE AdmissionID = @AdmissionID"
    '    cmd = New OleDbCommand(sql, cn)
    '    cmd.Parameters.AddWithValue("@AdmissionID", Convert.ToInt32(txtAdmissionID.Text))
    '    dr = cmd.ExecuteReader
    '    If dr.Read Then
    '        lblregisno.Text = dr("RegistrationNo").ToString
    '        txtfirstname.Text = dr("Firstname").ToString
    '        txtmiddlename.Text = dr("Middlename").ToString
    '        txtfamilyname.Text = dr("Familyname").ToString
    '        datebirthdate.Text = dr("Birthdate").ToString
    '        txtage.Text = dr("Age").ToString
    '        cbosex.Text = dr("Sex").ToString
    '        txtblock.Text = dr("Block").ToString
    '        txtlot.Text = dr("Lot").ToString
    '        txtstreet.Text = dr("Street").ToString
    '        cbobrgy.Text = dr("Barangay").ToString
    '        cbomunicipality.Text = dr("Municipality").ToString
    '        txtcontactno.Text = dr("ContactNo").ToString
    '        txtemail.Text = dr("EmailAddress").ToString
    '        cboapplicantstatus.Text = dr("ApplicantStatus").ToString
    '        Call disableupdatebtn()
    '    End If
    'End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtAdmissionID.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub disableupdatebtn()
        If txtAdmissionID.Text = 0 Then
            btnupdate.Enabled = False

        Else
            btnupdate.Enabled = True

        End If
    End Sub

    Private Sub clearboxes()
        txtAdmissionID.Text = "0"
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtfamilyname.Text = ""
        txtblock.Text = ""
        txtlot.Text = ""
        txtstreet.Text = ""
        txtage.Text = ""
        txtcontactno.Text = ""
        txtemail.Text = ""
        cbobrgy.Text = ""
        'combo
        cbomunicipality.SelectedItem = ""
        cbosex.SelectedItem = ""
        cboapplicantstatus.SelectedItem = ""

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call clearboxes()
        Call disableupdatebtn()

    End Sub

    Private Sub UpdateApplicantData()
        Try
            cn.Open() ' Open the connection

            Dim sql As String = "UPDATE tblAdmissionRegistration SET Firstname=@Firstname, Middlename=@Middlename, Familyname=@Familyname, Birthdate=@Birthdate, Age=@Age, Sex=@Sex, Block=@Block, Lot=@Lot, Street=@Street, Barangay=@Barangay, Municipality=@Municipality, ContactNo=@ContactNo, EmailAddress=@EmailAddress, ApplicantStatus=@ApplicantStatus WHERE AdmissionID=@AdmissionID"

            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)
                cmd.Parameters.AddWithValue("@Middlename", txtmiddlename.Text)
                cmd.Parameters.AddWithValue("@Familyname", txtfamilyname.Text)
                cmd.Parameters.AddWithValue("@Birthdate", datebirthdate.Value)
                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                cmd.Parameters.AddWithValue("@Sex", cbosex.Text)
                cmd.Parameters.AddWithValue("@Block", txtblock.Text)
                cmd.Parameters.AddWithValue("@Lot", txtlot.Text)
                cmd.Parameters.AddWithValue("@Street", txtstreet.Text)
                cmd.Parameters.AddWithValue("@Barangay", cbobrgy.Text)
                cmd.Parameters.AddWithValue("@Municipality", cbomunicipality.Text)
                cmd.Parameters.AddWithValue("@ContactNo", txtcontactno.Text)
                cmd.Parameters.AddWithValue("@EmailAddress", txtemail.Text)
                cmd.Parameters.AddWithValue("@ApplicantStatus", cboapplicantstatus.Text)
                cmd.Parameters.AddWithValue("@AdmissionID", txtAdmissionID.Text)

                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Member Record Successfully updated", MsgBoxStyle.Information, "Information")
            Call loadApplicants()

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close() ' Close the connection if it's still open
            End If
        End Try
    End Sub

    'Private Sub UpdateApplicantData()
    '    sql = "Update tblAdmissionRegistration set Firstname=@Firstname,Middlename=@Middlename,Familyname=@Familyname,Birthdate=@Birthdate,Age=@Age,Sex=@Sex,Block=@Block,Lot=@Lot,Street=@Street,Barangay=@Barangay,Municipality=@Municipality,ContactNo=@ContactNo,EmailAddress=@EmailAddress,ApplicantStatus=@ApplicantStatus where AdmissionID=@AdmissionID"
    '    cmd = New OleDbCommand(sql, cn)
    '    With cmd

    '        .Parameters.AddWithValue("[@Firstname]", txtfirstname.Text)
    '        .Parameters.AddWithValue("[@Middlename]", txtmiddlename.Text)
    '        .Parameters.AddWithValue("[@Familyname]", txtfamilyname.Text)
    '        .Parameters.AddWithValue("[@Birthdate]", datebirthdate.Text)
    '        .Parameters.AddWithValue("[@Age]", txtage.Text)
    '        .Parameters.AddWithValue("[@Sex]", cbosex.Text)
    '        .Parameters.AddWithValue("[@Block]", txtblock.Text)
    '        .Parameters.AddWithValue("[@Lot]", txtlot.Text)
    '        .Parameters.AddWithValue("[@Street]", txtstreet.Text)
    '        .Parameters.AddWithValue("[@Barangay]", cbobrgy.Text)
    '        .Parameters.AddWithValue("[@Municipality]", cbomunicipality.Text)
    '        .Parameters.AddWithValue("[@ContactNo]", txtcontactno.Text)
    '        .Parameters.AddWithValue("[@EmailAddress]", txtemail.Text)
    '        .Parameters.AddWithValue("[@ApplicantStatus]", cboapplicantstatus.Text)
    '        If cboapplicantstatus.Text = "New (Freshmen)" Then
    '            x.SubItems.Add(12).Text = "New (Freshmen)"
    '        ElseIf cboapplicantstatus.Text = "Transferee" Then
    '            x.SubItems.Add(12).Text = "Transferee"
    '        End If
    '        .Parameters.AddWithValue("@AdmissionID", txtAdmissionID.Text)
    '        .ExecuteNonQuery()

    '    End With

    '    MsgBox("Member Record Successfully updated", MsgBoxStyle.Information, "Information")
    '    Call loadApplicants()
    'End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim searchText As String = txtsearch.Text.ToLower()
        If searchText.Trim() <> String.Empty Then
            For Each item As ListViewItem In ListView1.Items
                ' Compare the text of each ListViewItem to the search text
                If item.Text.ToLower().Contains(searchText) Then
                    ' If it matches, make the item visible
                    item.EnsureVisible()
                    item.Selected = True ' Optionally select the item
                Else
                    ' If it doesn't match, hide the item
                    item.Selected = False ' Optionally deselect the item
                    item.EnsureVisible() ' Optionally, ensure the item is not visible
                End If
            Next
        Else
            ' If the search text is empty, make all items visible
            For Each item As ListViewItem In ListView1.Items
                item.Selected = False ' Optionally deselect the item
                item.EnsureVisible() ' Optionally, ensure the item is visible
            Next
        End If
    End Sub


    Private Sub datebirthdate_ValueChanged(sender As Object, e As EventArgs) Handles datebirthdate.TextChanged
        UpdateAge()
    End Sub
    Private Sub UpdateAge()
        Dim selectedDate As Date = datebirthdate.Value
        Dim age As Integer = DateTime.Now.Year - selectedDate.Year

        If DateTime.Now < selectedDate.AddYears(age) Then
            age -= 1
        End If

        txtage.Text = age.ToString()
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtage.TextChanged
        If Integer.TryParse(txtage.Text, Nothing) Then
            Dim age As Integer = Integer.Parse(txtage.Text)
            Dim birthDate As Date = DateTime.Now.AddYears(-age)
        Else
            ' Handle cases where the text is not a valid age
        End If
    End Sub
    Private Function Isvalidcontactno(contactno As String) As Boolean
        ' Use a simple email validation logic
        If contactno.Length = 11 AndAlso contactno.StartsWith("09") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function IsValidEmail(email As String) As Boolean
        ' Use a simple email validation logic
        If email.Contains("@") AndAlso email.EndsWith(".com") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub datebirthdate_ValueChanged_1(sender As Object, e As EventArgs) Handles datebirthdate.ValueChanged
        ' Get the current date
        Dim currentDate As Date = Date.Now

        ' Check if the selected date is less than the current date
        If datebirthdate.Value > currentDate Then
            ' If it is, set the selected date to the current date
            datebirthdate.Value = currentDate
        End If
    End Sub

    Private Sub txtcontactno_TextChanged(sender As Object, e As EventArgs) Handles txtcontactno.TextChanged
        ' Iterate through each character in the TextBox text
        For Each c As Char In txtcontactno.Text
            ' Check if the character is not a digit
            If Not Char.IsDigit(c) Then
                ' If it's not a digit, remove the character from the TextBox text
                txtcontactno.Text = txtcontactno.Text.Remove(txtblock.Text.IndexOf(c), 1)
            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbomunicipality.Items.Add("San Pedro City")
        cbomunicipality.Items.Add("Muntinlupa City")
        cbomunicipality.Items.Add("Biñan City")

    End Sub
    Private Sub cbomunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomunicipality.TextChanged
        ' Clear existing items in ComboBox2
        cbobrgy.Items.Clear()

        ' Check the selected value in ComboBox1
        If cbomunicipality.SelectedItem IsNot Nothing Then
            Dim selectedCity As String = cbomunicipality.SelectedItem.ToString()

            ' Depending on the selected city, populate ComboBox2 with corresponding barangays
            If selectedCity = "San Pedro City" Then
                cbobrgy.Items.Add("Bagong Silang")
                cbobrgy.Items.Add("Calendola")
                cbobrgy.Items.Add("Chrysanthemum")
                cbobrgy.Items.Add("Cuyab")
                cbobrgy.Items.Add("Estrella")
                cbobrgy.Items.Add("Fatima")
                cbobrgy.Items.Add("G.S.I.S.")
                cbobrgy.Items.Add("Landayan")
                cbobrgy.Items.Add("Langgam")
                cbobrgy.Items.Add("Laram")
                cbobrgy.Items.Add("Magsaysay")
                cbobrgy.Items.Add("Maharlika")
                cbobrgy.Items.Add("Narra")
                cbobrgy.Items.Add("Nueva")
                cbobrgy.Items.Add("Pacita 1")
                cbobrgy.Items.Add("Pacita 2")
                cbobrgy.Items.Add("Poblacion")
                cbobrgy.Items.Add("Riverside")
                cbobrgy.Items.Add("Rosario")
                cbobrgy.Items.Add("Sampaguita Village")
                cbobrgy.Items.Add("San Antonio")
                cbobrgy.Items.Add("San Lorenzo Ruiz")
                cbobrgy.Items.Add("San Roque")
                cbobrgy.Items.Add("Santo Niño")
                cbobrgy.Items.Add("San Vicente")
                cbobrgy.Items.Add("United Bayanihan")
                cbobrgy.Items.Add("United Better Living")
            ElseIf selectedCity = "Muntinlupa City" Then
                cbobrgy.Items.Add("Alabang")
                cbobrgy.Items.Add("Bayanan")
                cbobrgy.Items.Add("Buli")
                cbobrgy.Items.Add("Cupang")
                cbobrgy.Items.Add("New Alabang Village")
                cbobrgy.Items.Add("Poblacion")
                cbobrgy.Items.Add("Putatan")
                cbobrgy.Items.Add("Sucat")
                cbobrgy.Items.Add("Tunasan")
            ElseIf selectedCity = "Biñan City" Then
                cbobrgy.Items.Add("Biñan Poblacion")
                cbobrgy.Items.Add("Bungahan")
                cbobrgy.Items.Add("Canlalay")
                cbobrgy.Items.Add("Casile")
                cbobrgy.Items.Add("De La Paz")
                cbobrgy.Items.Add("Ganado")
                cbobrgy.Items.Add("Langkiwa")
                cbobrgy.Items.Add("Loma")
                cbobrgy.Items.Add("Malaban")
                cbobrgy.Items.Add("Malamig")
                cbobrgy.Items.Add("Mampalasan")
                cbobrgy.Items.Add("Platero")
                cbobrgy.Items.Add("Poblacion")
                cbobrgy.Items.Add("San Antonio")
                cbobrgy.Items.Add("San Francisco (Halang)")
                cbobrgy.Items.Add("San Jose")
                cbobrgy.Items.Add("Santo Domingo")
                cbobrgy.Items.Add("Santo Niño")
                cbobrgy.Items.Add("Santo Tomas (Calabuso)")
                cbobrgy.Items.Add("San Vicente")
                cbobrgy.Items.Add("Soro-Soro")
                cbobrgy.Items.Add("Timbao")
                cbobrgy.Items.Add("Tubigan")
                cbobrgy.Items.Add("Zapote")
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call UpdateApplicantData()
    End Sub


End Class
