Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Module Globals
    Public studID As String = ""
End Module
Public Class UCStudentlist
    Private Sub UCStudentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call studentlog()

    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtsearchid.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            txtStudentNo.Text = selectedItem.SubItems(0).Text
            txtName.Text = selectedItem.SubItems(1).Text
            txtCourse.Text = selectedItem.SubItems(2).Text
            cboSY.Text = selectedItem.SubItems(3).Text
            cboSemester.Text = selectedItem.SubItems(4).Text

            Dim registrationNo As String = selectedItem.SubItems(8).Text
            LoadAssessmentData(registrationNo)
            LoadPaymentData(registrationNo)
        Else
            MsgBox("No item selected")
        End If
    End Sub
    Private Sub studentlog()
        sql = "SELECT * FROM qryCOR ORDER BY StudentNo ASC"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While dr.Read = True
            Dim LV1 As New ListViewItem(dr("StudentNo").ToString)
            LV1.SubItems.Add(dr("Lastname").ToString & ", " & dr("Firstname").ToString & " " & dr("Middlename").ToString)
            LV1.SubItems.Add(dr("Course").ToString)
            LV1.SubItems.Add(dr("Department").ToString)
            LV1.SubItems.Add(dr("YearLevel").ToString)
            LV1.SubItems.Add(dr("SY").ToString)
            LV1.SubItems.Add(dr("Semester").ToString)
            LV1.SubItems.Add(dr("StudentType").ToString)
            LV1.SubItems.Add(dr("RegistrationNo").ToString)
            ListView1.Items.Add(LV1)
        Loop
    End Sub
    Private Sub LoadAssessmentData(registrationNo As String)
        Dim sql As String = "SELECT * FROM tblAssessment WHERE RegistrationNo = @registrationNo"
        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@registrationNo", registrationNo)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        ListView2.Items.Clear()
        Dim totalAssessment As String = String.Empty

        Do While dr.Read = True
            Dim LV2 As New ListViewItem(dr("SY").ToString)
            LV2.SubItems.Add(dr("RegistrationNo").ToString)
            LV2.SubItems.Add(dr("TotalAssessment").ToString)
            LV2.SubItems.Add(dr("TuitionFee").ToString)
            LV2.SubItems.Add(dr("MiscFee").ToString)
            LV2.SubItems.Add(dr("LabFee").ToString)
            LV2.SubItems.Add(dr("OtherFees").ToString)
            LV2.SubItems.Add(dr("Discount").ToString)
            LV2.SubItems.Add(dr("UponEnrollment").ToString)
            LV2.SubItems.Add(dr("MonthlyPayment").ToString)
            LV2.SubItems.Add(dr("FullPayment").ToString)
            ListView2.Items.Add(LV2)

            ' Store the TotalAssessment value
            totalAssessment = dr("TotalAssessment").ToString()
        Loop

        ' Display the TotalAssessment in lblTotalAssess
        lblTotalAssess.Text = totalAssessment
        UpdateOutstandingBalance()
    End Sub
    Public Sub LoadPaymentData(registrationNo As String)
        Dim sql As String = "SELECT * FROM tblCollection WHERE RegistrationNo = @registrationNo"
        Dim cmd As New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@registrationNo", registrationNo)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        ListView3.Items.Clear()
        Dim totalPayment As Decimal = 0

        Do While dr.Read = True
            Dim LV3 As New ListViewItem(dr("RegistrationNo").ToString)
            LV3.SubItems.Add(dr("ORNo").ToString)
            LV3.SubItems.Add(dr("PaymentFor").ToString)
            LV3.SubItems.Add(dr("Payment").ToString)
            LV3.SubItems.Add(dr("DateTimePayment").ToString)
            LV3.SubItems.Add(dr("Cashier").ToString)
            ListView3.Items.Add(LV3)

            ' Add the payment to the totalPayment
            totalPayment += Convert.ToDecimal(dr("Payment"))
        Loop

        ' Display the total payment in lblTotalPay
        lblTotalPay.Text = totalPayment
        UpdateOutstandingBalance()
    End Sub
    Private Sub UpdateOutstandingBalance()
        Dim totalAssess As Decimal = 0
        Dim totalPay As Decimal = 0

        ' Parse the values from lblTotalAssess and lblTotalPay
        If Decimal.TryParse(lblTotalAssess.Text, totalAssess) AndAlso Decimal.TryParse(lblTotalPay.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, totalPay) Then
            ' Calculate the outstanding balance
            Dim outstandingBalance As Decimal = totalAssess - totalPay
            ' Display the outstanding balance in lblOutBal
            lblOutBal.Text = outstandingBalance
        Else
            ' Handle the case where parsing fails
            lblOutBal.Text = "0.00"
        End If
    End Sub

    Private Sub txtsearchid_TextChanged(sender As Object, e As EventArgs) Handles txtsearchid.TextChanged
        Dim searchText As String = txtsearchid.Text.ToLower()
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
        ''''''''''''
        Globals.studID = txtsearchid.Text
        ''''''''''''
        If String.IsNullOrWhiteSpace(txtsearchid.Text) Then
            paymentbtn.Enabled = False
        Else
            paymentbtn.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles paymentbtn.Click

        If ListView1.SelectedItems.Count > 0 Then
            ' Get the selected row
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Retrieve data from the selected row
            Dim studentno As String = txtStudentNo.Text
            Dim name As String = txtName.Text
            Dim course As String = txtCourse.Text
            Dim regno As String = selectedItem.SubItems(8).Text

            receipt.lblregno.Text = regno
            receipt.lblstudentno.Text = studentno
            receipt.lblname.Text = name
            receipt.lblcourse.Text = course
            receipt.lbloutbal.Text = lblOutBal.Text

        End If

        receipt.btnprint.Show()
        receipt.btncancel.Show()
        receipt.RichTextBox1.Text = "Type Here (Optional)"
        receipt.RichTextBox2.Text = "Type Here (Optional)"
        receipt.TextBox2.Text = "Type Here (Optional)"
        receipt.TextBox3.Text = "Type Here (Optional)"
        receipt.TextBox4.Text = "Type Here (Optional)"
        receipt.TextBox5.Text = "Type Here (Optional)"
        receipt.ShowDialog()
    End Sub


End Class
