Imports System.Data.OleDb

Public Class Teachers
    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call SchoolYear()
        Call loadAccounts()
        loadCourse()
        loadDepartment()

        Bdate.MaxDate = DateTime.Now
    End Sub

    Private Sub loadAccounts()
        sql = "Select * from tblTeachers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While dr.Read = True
            Dim newItem As New ListViewItem(dr("EmployeeNo").ToString)
            newItem.SubItems.Add(dr("Lastname").ToString)
            newItem.SubItems.Add(dr("Firstname").ToString)
            newItem.SubItems.Add(dr("Mi").ToString)
            newItem.SubItems.Add(dr("Email").ToString)
            newItem.SubItems.Add(dr("PhoneNo").ToString)
            newItem.SubItems.Add(dr("Age").ToString)
            newItem.SubItems.Add(dr("Bdate").ToString)
            newItem.SubItems.Add(dr("HouseNo").ToString)
            newItem.SubItems.Add(dr("Brgy").ToString)
            newItem.SubItems.Add(dr("City").ToString)
            newItem.SubItems.Add(dr("Province").ToString)
            newItem.SubItems.Add(dr("Status").ToString)
            newItem.SubItems.Add(dr("Expertise").ToString)
            newItem.SubItems.Add(dr("Dept").ToString)
            newItem.SubItems.Add(dr("Course").ToString)
            newItem.SubItems.Add(dr("Title").ToString)
            newItem.SubItems.Add(dr("ContactPerson").ToString)
            newItem.SubItems.Add(dr("Relationship").ToString)
            newItem.SubItems.Add(dr("PhoneNoICE").ToString)
            ListView1.Items.Add(newItem)
        Loop
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call CheckIfExist()
        loadAccounts()
    End Sub

    Private Sub CheckIfExist()
        If txtEmployeeNo.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtEmail.Text = "" Or txtPhoneNo.Text = "" Then
            MsgBox("Fill in the textboxes", MsgBoxStyle.Critical)
        Else
            If MsgBox("Are you sure you want to save record?", vbQuestion + vbYesNo) = vbYes Then
                MsgBox("Saved Successfully!", MsgBoxStyle.Information, "New Record Saved")
                Call SaveInfo()
            Else
                MsgBox("Record not saved.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub SaveInfo()
        Dim formattedBdate As String = Bdate.Value.ToString("dd/MM/yyyy")

        sql = "INSERT into tblTeachers([EmployeeNo],[Lastname],[Firstname],[Mi],[Email],[PhoneNo],[Age],[Bdate],[HouseNo],[Brgy],[City],[Province],[Status],[Expertise],
        [Dept],[Course],[Title],[ContactPerson],[Relationship],[PhoneNoICE])values([@EmployeeNo],[@Lastname],[@Firstname],[@Mi],[@Email],[@PhoneNo],[@Age],[@Bdate],[@HouseNo],[@Brgy],[@City],[@Province],[@Status],[@Expertise],
        [@Dept], [@Course], [@Title], [@ContactPerson], [@Relationship], [@PhoneNoICE])"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@EmployeeNo]", txtEmployeeNo.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastName.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstName.Text)
            .Parameters.AddWithValue("[@Mi]", txtMiddleName.Text)
            .Parameters.AddWithValue("[@Email]", txtEmail.Text)
            .Parameters.AddWithValue("[@PhoneNo]", txtPhoneNo.Text)
            .Parameters.AddWithValue("[@Age]", txtAge.Text)
            .Parameters.AddWithValue("[@Bdate]", formattedBdate)
            .Parameters.AddWithValue("[@HouseNo]", txtHouseNo.Text)
            .Parameters.AddWithValue("[@Brgy]", txtBgy.Text)
            .Parameters.AddWithValue("[@City]", txtCity.Text)
            .Parameters.AddWithValue("[@Province]", txtProvince.Text)
            .Parameters.AddWithValue("[@Status]", cboStatus.Text)
            .Parameters.AddWithValue("[@Expertise]", txtExpertise.Text)
            .Parameters.AddWithValue("[@Dept]", cboDepartment.Text)
            .Parameters.AddWithValue("[@Course]", cboCourse.Text)
            .Parameters.AddWithValue("[@Title]", txtTitle.Text)
            .Parameters.AddWithValue("[@ContactPerson]", txtNameofICE.Text)
            .Parameters.AddWithValue("[@Relationship]", cboRS.Text)
            .Parameters.AddWithValue("[@PhoneNoICE]", txtICEPhone.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtEmployeeNo.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        txtHouseNo.Text = ""
        txtPhoneNo.Text = ""
        txtTitle.Text = ""
        txtAge.Text = ""
        txtBgy.Text = ""
        txtCity.Text = ""
        txtProvince.Text = ""
        txtNameofICE.Text = ""
        txtSearch.Text = ""
        txtEmail.Text = ""
        txtExpertise.Text = ""
        txtICEPhone.Text = ""
        cboCourse.Text = ""
        cboDepartment.Text = ""
        cboRS.Text = ""
        cboStatus.Text = ""
        Bdate.Text = ""
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
    Private Sub loadDepartment()
        sql = "Select distinct Department from tblDepartment"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboDepartment.DataSource = dt
        cboDepartment.DisplayMember = "Department"
    End Sub
    Private Sub loadCourse()
        sql = "Select distinct CourseName from qryDepartmentCourse where Department = '" & cboDepartment.Text & "' and status = 'Open'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboCourse.DataSource = dt
        cboCourse.DisplayMember = "CourseName"
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Call loadCourse()
        Call loadDepartmentID()
    End Sub
    Private Sub loadDepartmentID()
        sql = "Select DepartmentID from tblDepartment where Department= '" & cboDepartment.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblDepartmentID.Text = dr(0)
        End If
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        sql = "Select CourseID from tblCourse where CourseName= '" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblCourseID.Text = dr(0)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmployeeNo.Text = "" Then
            MsgBox("Please select a teacher to update.", MsgBoxStyle.Critical)
        Else
            Call UpdateInfo()
            loadAccounts()
        End If
    End Sub

    Private Sub UpdateInfo()
        sql = "UPDATE tblTeachers SET [Lastname]=@Lastname, [Firstname]=@Firstname, [Mi]=@Mi, [Email]=@Email, [PhoneNo]=@PhoneNo, [Age]=@Age, [Bdate]=@Bdate, [HouseNo]=@HouseNo, [Brgy]=@Brgy, [City]=@City, [Province]=@Province, [Status]=@Status, [Expertise]=@Expertise, [Dept]=@Dept, [Course]=@Course, [Title]=@Title, [ContactPerson]=@ContactPerson, [Relationship]=@Relationship, [PhoneNoICE]=@PhoneNoICE WHERE [EmployeeNo]=@EmployeeNo"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Lastname", txtLastName.Text)
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@Mi", txtMiddleName.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@Bdate", Bdate.Value)
            .Parameters.AddWithValue("@HouseNo", txtHouseNo.Text)
            .Parameters.AddWithValue("@Brgy", txtBgy.Text)
            .Parameters.AddWithValue("@City", txtCity.Text)
            .Parameters.AddWithValue("@Province", txtProvince.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .Parameters.AddWithValue("@Expertise", txtExpertise.Text)
            .Parameters.AddWithValue("@Dept", cboDepartment.Text)
            .Parameters.AddWithValue("@Course", cboCourse.Text)
            .Parameters.AddWithValue("@Title", txtTitle.Text)
            .Parameters.AddWithValue("@ContactPerson", txtNameofICE.Text)
            .Parameters.AddWithValue("@Relationship", cboRS.Text)
            .Parameters.AddWithValue("@PhoneNoICE", txtICEPhone.Text)
            .Parameters.AddWithValue("@EmployeeNo", txtEmployeeNo.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Updated Successfully!", MsgBoxStyle.Information, "Record Updated")
    End Sub

    Private Sub Bdate_ValueChanged(sender As Object, e As EventArgs) Handles Bdate.ValueChanged
        Dim birthDate As DateTime = Bdate.Value
        Dim today As DateTime = DateTime.Now
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust the age if the birthdate has not yet occurred this year
        If (birthDate > today.AddYears(-age)) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem = ListView1.SelectedItems(0)
            txtEmployeeNo.Text = selectedItem.SubItems(0).Text
            txtLastName.Text = selectedItem.SubItems(1).Text
            txtFirstName.Text = selectedItem.SubItems(2).Text
            txtMiddleName.Text = selectedItem.SubItems(3).Text
            txtEmail.Text = selectedItem.SubItems(4).Text
            txtPhoneNo.Text = selectedItem.SubItems(5).Text
            txtAge.Text = selectedItem.SubItems(6).Text

            ' Assuming the date is stored as a string in the format that can be parsed by DateTime.Parse
            Dim dateString As String = selectedItem.SubItems(7).Text
            Dim parsedDate As DateTime
            If DateTime.TryParse(dateString, parsedDate) Then
                Bdate.Value = parsedDate
            Else
                ' Handle the case where the date string is not valid
                MessageBox.Show("Invalid date format in the selected item.")
            End If

            txtHouseNo.Text = selectedItem.SubItems(8).Text
            txtBgy.Text = selectedItem.SubItems(9).Text
            txtCity.Text = selectedItem.SubItems(10).Text
            txtProvince.Text = selectedItem.SubItems(11).Text
            cboStatus.Text = selectedItem.SubItems(12).Text
            txtExpertise.Text = selectedItem.SubItems(13).Text
            cboDepartment.Text = selectedItem.SubItems(14).Text
            cboCourse.Text = selectedItem.SubItems(15).Text
            txtTitle.Text = selectedItem.SubItems(16).Text
            txtNameofICE.Text = selectedItem.SubItems(17).Text
            cboRS.Text = selectedItem.SubItems(18).Text
            txtICEPhone.Text = selectedItem.SubItems(19).Text

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = "SELECT * FROM tblTeachers WHERE EmployeeNo LIKE @searchText OR Lastname LIKE @searchText OR Firstname LIKE @searchText"
        If txtSearch.Text = "" Then
            sql = "SELECT * FROM tblteachers "
        End If

        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@searchText", txtSearch.Text & "%")
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Now you can use the data reader to read the results of the query
        ListView1.Items.Clear()


        Do While dr.Read = True
            Dim newItem As New ListViewItem(dr("EmployeeNo").ToString)
            newItem.SubItems.Add(dr("Lastname").ToString)
            newItem.SubItems.Add(dr("Firstname").ToString)
            newItem.SubItems.Add(dr("Mi").ToString)
            newItem.SubItems.Add(dr("Email").ToString)
            newItem.SubItems.Add(dr("PhoneNo").ToString)
            newItem.SubItems.Add(dr("Age").ToString)
            newItem.SubItems.Add(dr("Bdate").ToString)
            newItem.SubItems.Add(dr("HouseNo").ToString)
            newItem.SubItems.Add(dr("Brgy").ToString)
            newItem.SubItems.Add(dr("City").ToString)
            newItem.SubItems.Add(dr("Province").ToString)
            newItem.SubItems.Add(dr("Status").ToString)
            newItem.SubItems.Add(dr("Expertise").ToString)
            newItem.SubItems.Add(dr("Dept").ToString)
            newItem.SubItems.Add(dr("Course").ToString)
            newItem.SubItems.Add(dr("Title").ToString)
            newItem.SubItems.Add(dr("ContactPerson").ToString)
            newItem.SubItems.Add(dr("Relationship").ToString)
            newItem.SubItems.Add(dr("PhoneNoICE").ToString)
            ListView1.Items.Add(newItem)
        Loop
    End Sub
End Class
