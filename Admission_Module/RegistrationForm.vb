Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class RegistrationForm
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getRegistrationNo()

    End Sub

    Private Sub getRegistrationNo()
        sql = "Select RegistrationNo from tblAdmissionRegistration order by RegistrationNo desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtregistrationno.Text = Val(dr(0)) + 1
        Else
            txtregistrationno.Text = 1000
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbomunicipality.Items.Add("San Pedro City")
        cbomunicipality.Items.Add("Muntinlupa City")
        cbomunicipality.Items.Add("Biñan City")

    End Sub
    Private Sub cbomunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomunicipality.SelectedIndexChanged
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
    Private Sub SaveApplicantData()
        If String.IsNullOrEmpty(txtfirstname.Text) OrElse
           String.IsNullOrEmpty(txtmiddlename.Text) OrElse
           String.IsNullOrEmpty(txtfamilyname.Text) OrElse
           String.IsNullOrEmpty(datebirthdate.Text) OrElse
           String.IsNullOrEmpty(cbosex.Text) OrElse
           String.IsNullOrEmpty(txtnationality.Text) OrElse
           String.IsNullOrEmpty(txtage.Text) OrElse
           String.IsNullOrEmpty(txtstreet.Text) OrElse
           String.IsNullOrEmpty(cbobrgy.Text) OrElse
           String.IsNullOrEmpty(cbomunicipality.Text) OrElse
           String.IsNullOrEmpty(cboSyear.Text) Then
            'String.IsNullOrEmpty(txtFLastname.Text) OrElse
            'String.IsNullOrEmpty(txtFFirstname.Text) OrElse
            'String.IsNullOrEmpty(txtFMiddlename.Text) OrElse
            'String.IsNullOrEmpty(txtFAddress.Text) OrElse
            'String.IsNullOrEmpty(txtMLastname.Text) OrElse
            'String.IsNullOrEmpty(txtMFirstname.Text) OrElse
            'String.IsNullOrEmpty(txtMMiddlename.Text) OrElse
            'String.IsNullOrEmpty(txtMAddress.Text) OrElse
            'String.IsNullOrEmpty(txtGLastname.Text) OrElse
            'String.IsNullOrEmpty(txtGFirstname.Text) OrElse
            'String.IsNullOrEmpty(txtGMiddlename.Text) OrElse
            'String.IsNullOrEmpty(txtGRelation.Text) Then
            'String.IsNullOrEmpty(cbBirthCert.Checked) OrElse
            'String.IsNullOrEmpty(cbCGM.Checked) OrElse
            'String.IsNullOrEmpty(cbpicture.Checked) OrElse
            'String.IsNullOrEmpty(cbTOR.Checked) OrElse
            'String.IsNullOrEmpty(cbTOR2.Checked) OrElse
            'String.IsNullOrEmpty(cbForm.Checked) Then

            MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not IsValidEmail(txtemail.Text) Then
            MessageBox.Show("Please provide a valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not Isvalidcontactno(txtcontactno.Text) Then
            MessageBox.Show("Provide a valid Contact Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        sql = "Insert into tblAdmissionRegistration ([RegistrationNo],[Firstname],[Middlename],[Familyname],[Birthdate],[Age],[Sex],[Nationality],[Block],[Lot],[Street],[Barangay],[Municipality],[ContactNo],[EmailAddress],[Course],[ApplicantStatus], [DateAdded],[AcademicYear]) VALUES ([@RegistrationNo],[@Firstname],[@Middlename],[@Familyname],[@Birthdate],[@Age],[@Sex],[@Nationality],[@Block],[@Lot],[@Street],[@Barangay],[@Municipality],[@ContactNo],[@EmailAddress],[Course],[@ApplicantStatus],[@DateAdded],[@AcademicYear])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@RegistrationNo]", txtregistrationno.Text)
            .Parameters.AddWithValue("[@Firstname]", txtfirstname.Text)
            .Parameters.AddWithValue("[@Middlename]", txtmiddlename.Text)
            .Parameters.AddWithValue("[@Familyname]", txtfamilyname.Text)
            .Parameters.AddWithValue("[@Birthdate]", datebirthdate.Text)
            .Parameters.AddWithValue("[@Age]", txtage.Text)
            .Parameters.AddWithValue("[@Sex]", cbosex.Text)
            .Parameters.AddWithValue("[@Nationality]", txtnationality.Text)
            .Parameters.AddWithValue("[@Block]", txtblock.Text)
            .Parameters.AddWithValue("[@Lot]", txtlot.Text)
            .Parameters.AddWithValue("[@Street]", txtstreet.Text)
            .Parameters.AddWithValue("[@Barangay]", cbobrgy.Text)
            .Parameters.AddWithValue("[@Municipality]", cbomunicipality.Text)
            .Parameters.AddWithValue("[@ContactNo]", txtcontactno.Text)
            .Parameters.AddWithValue("[@EmailAddress]", txtemail.Text)
            .Parameters.AddWithValue("[@Course]", cbocourse.Text)
            .Parameters.AddWithValue("[@ApplicantStatus]", cboapplicantstatus.Text)
            .Parameters.AddWithValue("[@DateAdded]", DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt"))
            .Parameters.AddWithValue("[@AcademicYear]", cboSyear.Text)
            .ExecuteNonQuery()

        End With
        sql = "Insert into tblRequirements([RegistrationNo],[TranscriptofRecords(Orig)],[TranscriptofRecords(Copy)],[2x2Picture],[GoodMoralCertificate],[Form138(Orig)],[BirthCertificate]) VALUES ([@RegistrationNo],[@TranscriptofRecords(Orig)],[@TranscriptofRecords(Copy)],[@2x2Picture],[@GoodMoralCertificate],[@Form138(Orig)],[@BirthCertificate])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            cmd.Parameters.AddWithValue("[@RegistrationNo]", txtregistrationno.Text)
            cmd.Parameters.AddWithValue("[@TranscriptofRecords(Orig)]", If(cbTOR.Checked, "Yes", "No"))
            cmd.Parameters.AddWithValue("[@TranscriptofRecords(Copy)]", If(cbTOR2.Checked, "Yes", "No"))
            cmd.Parameters.AddWithValue("[2x2Picture]", If(cbpicture.Checked, "Yes", "No"))
            cmd.Parameters.AddWithValue("[GoodMoralCertificate]", If(cbCGM.Checked, "Yes", "No"))
            cmd.Parameters.AddWithValue("[Form138(Orig)]", If(cbForm.Checked, "Yes", "No"))
            cmd.Parameters.AddWithValue("[BirthCertificate]", If(cbBirthCert.Checked, "Yes", "No"))
            cmd.ExecuteNonQuery()
        End With
        sql = "Insert into tblParentsGuardianInformation ([RegistrationNo],[FatherLastName],[FatherFirstName],[FatherMiddleName],[FatherContactNo],[FatherAddress],[MotherLastName],[MotherFirstName],[MotherMiddleName],[MotherContactNo],[MotherAddress],[GuardianLastName],[GuardianFirstName],[GuardianMiddleName],[GuardianContactNo],[GuardianRelation]) VALUES ([@RegistrationNo],[@FatherLastName],[@FatherFirstName],[@FatherMiddleName],[@FatherContactNo],[@FatherAddress],[@MotherLastName],[@MotherFirstName],[@MotherMiddleName],[@MotherContactNo],[@MotherAddress],[@GuardianLastName],[@GuardianFirstName],[@GuardianMiddleName],[@GuardianContactNo],[@GuardianRelation])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@RegistrationNo]", txtregistrationno.Text)
            .Parameters.AddWithValue("[@FatherLastName]", txtFLastname.Text)
            .Parameters.AddWithValue("[@FatherFirstName]", txtFFirstname.Text)
            .Parameters.AddWithValue("[@FatherMiddleName]", txtFMiddlename.Text)
            .Parameters.AddWithValue("[@FatherContactNo]", txtFContact.Text)
            .Parameters.AddWithValue("[@FatherAddress]", txtFAddress.Text)
            .Parameters.AddWithValue("[@MotherLastName]", txtMLastname.Text)
            .Parameters.AddWithValue("[@MotherFirstName]", txtMFirstname.Text)
            .Parameters.AddWithValue("[@MotherMiddleName]", txtMMiddlename.Text)
            .Parameters.AddWithValue("[@MotherContactNo]", txtMContact.Text)
            .Parameters.AddWithValue("[@MotherAddress]", txtMAddress.Text)
            .Parameters.AddWithValue("[@GuardianLastName]", txtGLastname.Text)
            .Parameters.AddWithValue("[@GuardianFirstName]", txtGFirstname.Text)
            .Parameters.AddWithValue("[@GuardianMiddleName]", txtGMiddlename.Text)
            .Parameters.AddWithValue("[@GuardianContactNo]", txtGContact.Text)
            .Parameters.AddWithValue("[@GuardianRelation]", txtGRelation.Text)
            .ExecuteNonQuery()
        End With

        MsgBox("Applicant Information Successfully Saved", MsgBoxStyle.Information, "Information")
        Call Clearboxes()
        Call uncheckboxes()
    End Sub
    'Private Sub SaveParentsInformation()
    '    sql = "Insert into tblParentsGuardianInformation ([RegistrationNo],[FatherLastName],[FatherFirstName],[FatherMiddleName],[FatherContactNo],[FatherAddress],[MotherLastName],[MotherFirstName],[MotherMiddleName],[MotherContactNo],[MotherAddress],[GuardianLastName],[GuardianFirstName],[GuardianMiddleName],[GuardianContactNo],[GuardianRelation] VALUES [@RegistrationNo],[@FatherLastName],[@FatherFirstName],[@FatherMiddleName],[@FatherContactNo],[@FatherAddress],[@MotherLastName],[@MotherFirstName],[@MotherMiddleName],[@MotherContactNo],[@MotherAddress],[@GuardianLastName],[@GuardianFirstName],[@GuardianMiddleName],[@GuardianContactNo],[@GuardianRelation])
    '    cmd = New OleDbCommand(sql, cn)
    '    With cmd
    '        .Parameters.AddWithValue("[@RegistrationNo]", txtregistrationno.Text)
    '        .Parameters.AddWithValue("[@FatherLastName]", txtFLastname.Text)
    '        .Parameters.AddWithValue("[@FatherFirstName]", txtFFirstname.Text)
    '        .Parameters.AddWithValue("[@FatherMiddleName]", txtFMiddlename.Text)
    '        .Parameters.AddWithValue("[@FatherContactNo]", txtFContact.Text)
    '        .Parameters.AddWithValue("[@FatherAddress]", txtFAddress.Text)
    '        .Parameters.AddWithValue("[@MotherLastName]", txtMLastname.Text)
    '        .Parameters.AddWithValue("[@MotherFirstName]", txtMFirstname.Text)
    '        .Parameters.AddWithValue("[@MotherMiddleName]", txtMMiddlename.Text)
    '        .Parameters.AddWithValue("[@MotherContactNo]", txtMContact.Text)
    '        .Parameters.AddWithValue("[@MotherAddress]", txtMAddress.Text)
    '        .Parameters.AddWithValue("[@GuardianLastName]", txtGLastname.Text)
    '        .Parameters.AddWithValue("[@GuardianFirstName]", txtGFirstname.Text)
    '        .Parameters.AddWithValue("[@GuardianMiddleName]", txtGMiddlename.Text)
    '        .Parameters.AddWithValue("[@GuardianContactNo]", txtGContact.Text)
    '        .Parameters.AddWithValue("[@GuardianRelation]", txtGRelation.Text)
    '    End With
    'End Sub



    'Private Sub SaveApplicantRequirments()
    '    sql = "Insert into tblRequirements([RegistrationNo],[TranscriptofRecords(Orig)],[TranscriptofRecords(Copy)],[2x2Picture],[GoodMoralCertificate],[Form138(Orig)],[BirthCertificate]) VALUES ([@RegistrationNo],[@TranscriptofRecords(Orig)],[@TranscriptofRecords(Copy)],[@2x2Picture],[@GoodMoralCertificate],[@Form138(Orig)],[@BirthCertificate])"
    '    cmd = New OleDbCommand(sql, cn)
    '    With cmd
    '        cmd.Parameters.AddWithValue("[@RegistrationNo]", txtregistrationno.Text)
    '        cmd.Parameters.AddWithValue("[@TranscriptofRecords(Orig)]", If(cbTOR.Checked, "Yes", "No"))
    '        cmd.Parameters.AddWithValue("[@TranscriptofRecords(Copy)]", If(cbTOR2.Checked, "Yes", "No"))
    '        cmd.Parameters.AddWithValue("[2x2Picture]", If(cbpicture.Checked, "Yes", "No"))
    '        cmd.Parameters.AddWithValue("[GoodMoralCertificate]", If(cbCGM.Checked, "Yes", "No"))
    '        cmd.Parameters.AddWithValue("[Form138(Orig)]", If(cbForm.Checked, "Yes", "No"))
    '        cmd.Parameters.AddWithValue("[BirthCertificate]", If(cbBirthCert.Checked, "Yes", "No"))
    '        cmd.ExecuteNonQuery()
    '    End With
    '    MsgBox("Applicant Information Successfully Saved", MsgBoxStyle.Information, "Information")
    '    Call Clearboxes()
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveApplicantData()
        'Call SaveApplicantRequirments()
        Call getRegistrationNo()
    End Sub

    Private Sub txtage_TextChanged(sender As Object, e As EventArgs) Handles txtage.TextChanged
        If Integer.TryParse(txtage.Text, Nothing) Then
            Dim age As Integer = Integer.Parse(txtage.Text)
            Dim birthDate As Date = DateTime.Now.AddYears(-age)
        Else
            ' Handle cases where the text is not a valid age
        End If
    End Sub
    Private Sub UpdateAge()
        Dim selectedDate As Date = datebirthdate.Value
        Dim age As Integer = DateTime.Now.Year - selectedDate.Year

        If DateTime.Now < selectedDate.AddYears(age) Then
            age -= 1
        End If

        txtage.Text = age.ToString()
    End Sub

    Private Sub datebirthdate_ValueChanged(sender As Object, e As EventArgs) Handles datebirthdate.ValueChanged
        UpdateAge()
        ' Get the current date
        Dim currentDate As Date = Date.Now

        ' Check if the selected date is less than the current date
        If datebirthdate.Value > currentDate Then
            ' If it is, set the selected date to the current date
            datebirthdate.Value = currentDate
        End If
    End Sub
    Private Sub txtblock_TextChanged(sender As Object, e As EventArgs) Handles txtblock.TextChanged
        ' Iterate through each character in the TextBox text
        For Each c As Char In txtblock.Text
            ' Check if the character is not a digit
            If Not Char.IsDigit(c) Then
                ' If it's not a digit, remove the character from the TextBox text
                txtblock.Text = txtblock.Text.Remove(txtblock.Text.IndexOf(c), 1)
            End If
        Next
    End Sub
    Private Sub txtlot_TextChanged(sender As Object, e As EventArgs) Handles txtlot.TextChanged
        ' Iterate through each character in the TextBox text
        For Each c As Char In txtlot.Text
            ' Check if the character is not a digit
            If Not Char.IsDigit(c) Then
                ' If it's not a digit, remove the character from the TextBox text
                txtlot.Text = txtlot.Text.Remove(txtlot.Text.IndexOf(c), 1)
            End If
        Next
    End Sub
    Private Function Isvalidcontactno(contactno As String) As Boolean
        ' Use a simple email validation logic
        If contactno.Length = 11 AndAlso contactno.StartsWith("09") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub txtcontactno_TextChanged(sender As Object, e As EventArgs) Handles txtcontactno.TextChanged
        ' Iterate through each character in the TextBox text
        For Each c As Char In txtcontactno.Text
            ' Check if the character is not a digit
            If Not Char.IsDigit(c) Then
                ' If it's not a digit, remove the character from the TextBox text
                txtcontactno.Text = txtcontactno.Text.Remove(txtcontactno.Text.IndexOf(c), 1)
            End If
        Next
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        ' Use a simple email validation logic
        If email.Contains("@") AndAlso email.EndsWith(".com") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clearboxes()
        Call uncheckboxes()
    End Sub
    Private Sub Clearboxes()
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtfamilyname.Text = ""
        txtblock.Text = ""
        txtlot.Text = ""
        txtstreet.Text = ""
        txtage.Text = ""
        txtnationality.Text = ""
        txtcontactno.Text = ""
        txtemail.Text = ""
        cbobrgy.Text = ""
        cboSyear.Text = ""
        txtFFirstname.Text = ""
        txtFMiddlename.Text = ""
        txtFLastname.Text = ""
        txtFContact.Text = ""
        txtFAddress.Text = ""
        txtMFirstname.Text = ""
        txtMMiddlename.Text = ""
        txtMLastname.Text = ""
        txtMContact.Text = ""
        txtMAddress.Text = ""
        txtGFirstname.Text = ""
        txtGMiddlename.Text = ""
        txtGLastname.Text = ""
        txtGContact.Text = ""
        txtGRelation.Text = ""
        'combo
        cbomunicipality.SelectedItem = ""
        cbosex.SelectedItem = ""
        cboapplicantstatus.SelectedItem = ""
    End Sub
    Private Sub uncheckboxes()
        cbForm.Checked = False
        cbCGM.Checked = False
        cbBirthCert.Checked = False
        cbpicture.Checked = False
        cbTOR.Checked = False
        cbTOR2.Checked = False

    End Sub


End Class
