Imports System.Data.OleDb

Public Class Assesment

    Private txtStudentName As Object
    Private cboSY As Object

    Private Sub Assesment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        loadCourse()
        loadDepartment()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        sql = "SELECT * FROM qryEnrolled WHERE StudentNo = @StudentNo"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtname.Text = dr("Lastname").ToString & dr("Firstname") & dr("MiddleName")
        End If
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

    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        sql = "Select SectionName from qrySections where CourseName= '" & cboCourse.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboSection.DataSource = dt
        cboSection.DisplayMember = "SectionName"
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        If cboSection.SelectedItem IsNot Nothing Then
            If frmStudentList.ListView1.SelectedItems.Count > 0 Then
                loadSchedule()
            Else
                ListView1.Items.Clear()
            End If
        End If
    End Sub

    Private Sub loadSchedule()
        sql = "SELECT [Section], [SubjCode],[Description],[Units],[Days],[Time],[Teacher],[LabCode],[Hrs],[Fee] FROM qryClassScheduleNew WHERE Section= '" & cboSection.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        Dim x As ListViewItem
        ListView1.Items.Clear()

        Dim grandTotal As Double = 0
        Dim totalUnit As Integer = 0
        Dim totalUnits As Integer = 0

        Do While dr.Read()
            x = New ListViewItem(dr("Section").ToString())
            x.SubItems.Add(dr("SubjCode").ToString())
            x.SubItems.Add(dr("Description").ToString())
            x.SubItems.Add(dr("Units").ToString())
            x.SubItems.Add(dr("Days").ToString())
            x.SubItems.Add(dr("Time").ToString())
            x.SubItems.Add(dr("Teacher").ToString())
            x.SubItems.Add(dr("LabCode").ToString())
            x.SubItems.Add(dr("Hrs").ToString())
            x.SubItems.Add(dr("Fee").ToString())

            Dim hrs As Double = Double.Parse(dr("Hrs").ToString())
            Dim fee As Double = Double.Parse(dr("Fee").ToString())
            Dim total As Double = hrs * fee

            x.SubItems.Add(total.ToString("N2"))
            ListView1.Items.Add(x)

            grandTotal += total

            Dim units As Integer = Integer.Parse(dr("Units").ToString())
            totalUnit += units
        Loop

        Dim feeQuery As String = "SELECT Fee FROM tblFee WHERE FeeDesc = 'Units'"
        Dim feeCmd As New OleDbCommand(feeQuery, cn)
        Dim unitFee As Double = Convert.ToDouble(feeCmd.ExecuteScalar())

        For Each item As ListViewItem In ListView1.Items
            totalUnits += Integer.Parse(item.SubItems(3).Text)
        Next

        Dim totalFee As Double = unitFee * totalUnits

        Dim miscFeeQuery As String = "SELECT Fee FROM tblFee WHERE FeeDesc = 'Miscellaneous Fee'"
        Dim miscFeeCmd As New OleDbCommand(miscFeeQuery, cn)
        Dim miscFee As Double = Convert.ToDouble(miscFeeCmd.ExecuteScalar())

        Dim totalAssess As Double = totalFee + miscFee + grandTotal

        lblTotalAss.Text = totalAssess.ToString("N2")
        lblMiscFee.Text = miscFee.ToString("N2")
        lblTuition.Text = totalFee.ToString("N2")
        lblLabFee.Text = grandTotal.ToString("N2")
        lblTotalUnits.Text = totalUnits.ToString()

        cbOFee.Items.Clear()
        Dim othersFeeQuery As String = "SELECT DISTINCT FeeDesc FROM tblFee WHERE FeeType = 'Others'"
        Dim othersFeeCmd As New OleDbCommand(othersFeeQuery, cn)
        Dim drOthers As OleDbDataReader = othersFeeCmd.ExecuteReader()

        While drOthers.Read()
            cbOFee.Items.Add(drOthers("FeeDesc").ToString())
        End While

        cboPayScheme.Items.Clear()
        Dim paymentSchemeQuery As String = "SELECT * FROM tblPaymentScheme"
        Dim paymentSchemeCmd As New OleDbCommand(paymentSchemeQuery, cn)
        Dim drPaymentScheme As OleDbDataReader = paymentSchemeCmd.ExecuteReader()

        While drPaymentScheme.Read()
            cboPayScheme.Items.Add(drPaymentScheme("FeesDesc").ToString())
        End While
    End Sub

    Private Sub cboOtherType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOFee.SelectedIndexChanged
        If cbOFee.SelectedIndex <> -1 Then
            Dim selectedFeeDesc As String = cbOFee.SelectedItem.ToString()
            Dim feeQuery As String = "SELECT Fee FROM tblFee WHERE FeeDesc = @FeeDesc"
            Dim feeCmd As New OleDbCommand(feeQuery, cn)
            feeCmd.Parameters.AddWithValue("@FeeDesc", selectedFeeDesc)

            Dim fee As Object = feeCmd.ExecuteScalar()

            If fee IsNot DBNull.Value Then
                txtAmount.Text = Convert.ToDouble(fee).ToString("F2")
            Else
                txtAmount.Text = "Fee not found"
            End If

            Dim itemExists As Boolean = False
            For Each item As ListViewItem In ListView2.Items
                If item.Text = selectedFeeDesc Then
                    itemExists = True
                    Exit For
                End If
            Next

            If Not itemExists Then
                Dim listViewItem As New ListViewItem(selectedFeeDesc)
                listViewItem.SubItems.Add(txtAmount.Text)
                ListView2.Items.Add(listViewItem)
                UpdateTotalFee()

                UpdateTotalAssessment()
            End If
        Else
            txtAmount.Clear()
        End If
    End Sub

    Private Sub UpdateTotalAssessment()
        Dim labFee As Double
        Dim otherFee As Double
        Dim discountAmount As Double = 0

        If Double.TryParse(lblLabFee.Text, labFee) AndAlso Double.TryParse(lblOtherFee.Text, otherFee) Then
            Dim discountItem As ListViewItem = FindListViewItemByTag("Discount")
            If discountItem IsNot Nothing Then
                Double.TryParse(discountItem.SubItems(1).Text, discountAmount)
            End If

            Dim totalAssess As Double = labFee + otherFee + Convert.ToDouble(lblTuition.Text) + Convert.ToDouble(lblMiscFee.Text) - discountAmount
            lblTotalAss.Text = totalAssess.ToString("N2")
        End If
    End Sub

    Private Sub UpdateTotalFee()
        Dim total As Double = 0
        For Each item As ListViewItem In ListView2.Items
            If item.Tag Is Nothing OrElse item.Tag.ToString() <> "Discount" Then
                Dim amount As Double
                If Double.TryParse(item.SubItems(1).Text, amount) Then
                    total += amount
                End If
            End If
        Next
        lblOtherFee.Text = total.ToString("N2")
    End Sub
    Private Function FindListViewItemByTag(ByVal tag As String) As ListViewItem
        For Each item As ListViewItem In ListView2.Items
            If item.Tag IsNot Nothing AndAlso item.Tag.ToString() = tag Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Private Sub cboPaymentScheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayScheme.SelectedIndexChanged
        Dim selectedScheme As String = cboPayScheme.SelectedItem.ToString()
        Dim schemeAlreadyAdded As Boolean = False

        For Each item As ListViewItem In ListView2.Items
            If item.Text = selectedScheme Then
                schemeAlreadyAdded = True
                Exit For
            End If
        Next

        If selectedScheme = "Full Payment" Then
            lblUponEn.Text = "0.00"
            lblMonthly.Text = "0.00"
        ElseIf selectedScheme = "Installment" Then
            Dim totalAssessment As Double
            If Double.TryParse(lblTotalAss.Text, totalAssessment) Then
                Dim fullPaymentAmount As Double = totalAssessment - Convert.ToDouble(lblUponEn.Text)
                lblFullPay.Text = fullPaymentAmount.ToString("N2")
            End If
        End If

        If Not schemeAlreadyAdded Then

            Dim schemeFeesQuery As String = "SELECT FeesDesc, Fees FROM tblPaymentScheme WHERE FeeDesc = @FeeDesc"
            Dim schemeFeesCmd As New OleDbCommand(schemeFeesQuery, cn)
            schemeFeesCmd.Parameters.AddWithValue("@FeeDesc", selectedScheme)
            Dim drSchemeFees As OleDbDataReader = schemeFeesCmd.ExecuteReader()

            While drSchemeFees.Read()
                Dim feeDesc As String = drSchemeFees("FeesDesc").ToString()
                Dim fees As Object = drSchemeFees("Fees")

                If Not DBNull.Value.Equals(fees) Then
                    Dim feesValue As Double
                    If Double.TryParse(fees.ToString(), feesValue) Then
                        Dim feeExists As Boolean = False
                        For Each item As ListViewItem In ListView2.Items
                            If item.Text = feeDesc Then
                                feeExists = True
                                Exit For
                            End If
                        Next

                        If Not feeExists Then
                            Dim feeItem As New ListViewItem(feeDesc)
                            feeItem.SubItems.Add(feesValue.ToString("N2"))
                            ListView2.Items.Add(feeItem)
                        End If
                    End If
                End If
            End While

            UpdateTotalFee()
            UpdateTotalAssessment()

            If selectedScheme <> "Full Payment" Then
                Dim amountString As String = InputBox("Enter Upon Enrollment Amount " & selectedScheme & ":", "Enter Amount")

                If Not String.IsNullOrEmpty(amountString) Then
                    Dim amount As Double
                    If Double.TryParse(amountString, amount) Then
                        lblUponEn.Text = amount.ToString("N2")

                        Dim totalAssessment As Double
                        If Double.TryParse(lblTotalAss.Text, totalAssessment) Then
                            Dim remainingAmount As Double = totalAssessment - Convert.ToDouble(lblUponEn.Text)
                            Dim monthlyPayment As Double = remainingAmount / 4
                            lblMonthly.Text = monthlyPayment.ToString("F2")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Save Assessment?", vbQuestion + vbYesNo) = vbYes Then
            If txtStudentNo.Text = " " Or ListView1.Items.Count = 0 Then
                MsgBox("Kindly complete the information", MsgBoxStyle.Exclamation)
            Else
                Call checkAssessment()
            End If
        Else
            MsgBox("Cancel Saving", MsgBoxStyle.Information)
        End If
    End Sub
    Sub checkAssessment()
        sql = "SELECT RegistrationNo FROM tblAssessment WHERE RegistrationNo='" & lblRegNum.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            MsgBox("Student is already have assessment record", MsgBoxStyle.Critical)
        Else
            SaveAssessment()
        End If
    End Sub

    Private Sub SaveAssessment()

        sql = "INSERT INTO tblAssessment ([SY], [RegistrationNo], [TotalAssessment], [TuitionFee], [MiscFee], [LabFee], [OtherFees], [Discount], [PaymentScheme], [UponEnrollment], [MonthlyPayment], [FullPayment], [DateAssess], [Status], [AssessBy])" &
                     " VALUES (@SY, @RegistrationNo, @TotalAssessment, @TuitionFee, @MiscFee, @LabFee, @OtherFees, @Discount, @PaymentScheme, @UponEnrollment, @MonthlyPayment, @FullPayment, @DateAssess, @Status, @AssessBy)"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@SY", cbosyear.Text)
            .Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)
            .Parameters.AddWithValue("@TotalAssessment", lblTotalAss.Text)
            .Parameters.AddWithValue("@TuitionFee", lblTuition.Text)
            .Parameters.AddWithValue("@MiscFee", lblMiscFee.Text)
            .Parameters.AddWithValue("@LabFee", lblLabFee.Text)
            .Parameters.AddWithValue("@OtherFees", lblOtherFee.Text)
            .Parameters.AddWithValue("@Discount", cboDiscount.Text)
            .Parameters.AddWithValue("@PaymentScheme", cboPayScheme.Text)
            .Parameters.AddWithValue("@UponEnrollment", lblUponEn.Text)
            .Parameters.AddWithValue("@MonthlyPayment", lblMonthly.Text)
            .Parameters.AddWithValue("@FullPayment", lblFullPay.Text)
            .Parameters.AddWithValue("@DateAssess", lblDate.Text)
            .Parameters.AddWithValue("@DateAssess", lblTime.Text)
            .Parameters.AddWithValue("@Status", "Assessed")
            .Parameters.AddWithValue("@AssessBy", lblAssessOf.Text)
            .ExecuteNonQuery()
        End With

        For Each item As ListViewItem In ListView2.Items
            Dim feeDesc As String = item.Text
            Dim feeAmount As Double = Double.Parse(item.SubItems(1).Text)

            Dim feeSql As String = "INSERT INTO tblAssessmentOtherFees ([RegistrationNo], [FeeDescription], [Amount]) VALUES (@RegistrationNo, @FeeDescription, @Amount)"
            Using feeCmd As New OleDbCommand(feeSql, cn)
                With feeCmd
                    .Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)
                    .Parameters.AddWithValue("@FeeDescription", feeDesc)
                    .Parameters.AddWithValue("@Amount", feeAmount)
                    .ExecuteNonQuery()
                End With
            End Using
        Next

        MsgBox("Mr./Ms " & txtname.Text & " successfully saved assessment!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnAssess_Click(sender As Object, e As EventArgs) Handles btnAssess.Click
        Dim printForm As New PrintAssessment()

        printForm.StudentNo = txtStudentNo.Text
        printForm.StudentName = txtname.Text
        printForm.Course = cboCourse.Text
        printForm.YearLevel = cboYearLevel.Text
        printForm.SchoolYear = cbosyear.Text
        printForm.Semester = cboSemester.Text
        printForm.AssessmentDateTime = DateTime.Now
        printForm.TuitionFee = lblTuition.Text
        printForm.MiscFee = lblMiscFee.Text
        printForm.LabFee = lblLabFee.Text
        printForm.Discount = cboDiscount.Text
        printForm.TotalAssessment = lblTotalAss.Text
        printForm.Full = lblFullPay.Text
        printForm.Units = lblTotalUnits.Text
        printForm.UponEnrollment = lblUponEn.Text
        printForm.month = lblMonthly.Text
        printForm.Month1 = lblMonthly.Text
        printForm.Month2 = lblMonthly.Text
        printForm.month3 = lblMonthly.Text

        Dim scheduleItems As New List(Of ListViewItem)
        For Each item As ListViewItem In ListView1.Items
            scheduleItems.Add(item)
        Next
        Dim scheduleItem As New List(Of ListViewItem)
        For Each item As ListViewItem In ListView2.Items
            scheduleItem.Add(item)
        Next

        printForm.ScheduleItems = scheduleItems
        printForm.ScheduleItem = scheduleItem
        printForm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmStudentList.Show()
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscount.SelectedIndexChanged
        Dim selectedDiscount As String = cboDiscount.SelectedItem.ToString()
        Dim discountPercentage As Double = Convert.ToDouble(selectedDiscount.Replace("%", "")) / 100
        Dim discountedAmount As Double
        Dim originalTotalFee As Double
        CalculateDiscountedAmount(discountPercentage, discountedAmount, originalTotalFee)

        Dim discountItem As ListViewItem = FindListViewItemByTag("Discount")
        If discountItem IsNot Nothing Then
            discountItem.SubItems(1).Text = discountedAmount.ToString("N2")
        Else
            Dim newDiscountItem As New ListViewItem("Discount")
            newDiscountItem.SubItems.Add(discountedAmount.ToString("N2"))
            newDiscountItem.Tag = "Discount"
            ListView2.Items.Add(newDiscountItem)
        End If

        UpdateTotalAssessment(originalTotalFee, discountedAmount)
    End Sub
    Private Sub CalculateDiscountedAmount(ByVal discountPercentage As Double, ByRef discountedAmount As Double, ByRef originalTotalFee As Double)
        originalTotalFee = Convert.ToDouble(lblTuition.Text)
        discountedAmount = originalTotalFee * discountPercentage
    End Sub

    Private Sub UpdateTotalAssessment(ByVal originalTotalFee As Double, ByVal discountAmount As Double)
        Dim labFee As Double
        Dim otherFee As Double

        If Double.TryParse(lblLabFee.Text, labFee) AndAlso Double.TryParse(lblOtherFee.Text, otherFee) Then
            Dim totalAssess As Double = labFee + otherFee + originalTotalFee - discountAmount + Convert.ToDouble(lblMiscFee.Text)
            lblTotalAss.Text = totalAssess.ToString("N2")
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToString("MM-dd-yyyy")
        lblTime.Text = Now.ToString("hh:mm tt")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmationResult = DialogResult.Yes Then
            Dim checkSql As String = "SELECT COUNT(*) FROM tblAssessment WHERE [RegistrationNo] = @RegistrationNo"
            Dim checkCmd As New OleDbCommand(checkSql, cn)
            checkCmd.Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)

            Dim recordCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If recordCount > 0 Then
                sql = "UPDATE tblAssessment SET [SY] = @SY, [TotalAssessment] = @TotalAssessment, [TuitionFee] = @TuitionFee, [MiscFee] = @MiscFee, [LabFee] = @LabFee, [OtherFees] = @OtherFees, [Discount] = @Discount, [PaymentScheme] = @PaymentScheme, [UponEnrollment] = @UponEnrollment, [MonthlyPayment] = @MonthlyPayment, [FullPayment] = @FullPayment, [DateAssess] = @DateAssess, [AssessBy] = @AssessBy, [Status] = @Status WHERE [RegistrationNo] = @RegistrationNo"

                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@SY", cbosyear.Text)
                    .Parameters.AddWithValue("@TotalAssessment", lblTotalAss.Text)
                    .Parameters.AddWithValue("@TuitionFee", lblTuition.Text)
                    .Parameters.AddWithValue("@MiscFee", lblMiscFee.Text)
                    .Parameters.AddWithValue("@LabFee", lblLabFee.Text)
                    .Parameters.AddWithValue("@OtherFees", lblOtherFee.Text)
                    .Parameters.AddWithValue("@Discount", cboDiscount.Text)
                    .Parameters.AddWithValue("@PaymentScheme", cboPayScheme.Text)
                    .Parameters.AddWithValue("@UponEnrollment", lblUponEn.Text)
                    .Parameters.AddWithValue("@MonthlyPayment", lblMonthly.Text)
                    .Parameters.AddWithValue("@FullPayment", lblFullPay.Text)
                    .Parameters.AddWithValue("@DateAssess", lblDate.Text)
                    .Parameters.AddWithValue("@DateAssess", lblTime.Text)
                    .Parameters.AddWithValue("@AssessBy", lblAssessOf.Text)
                    .Parameters.AddWithValue("@Status", "Assessed")
                    .Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)
                    .ExecuteNonQuery()
                End With

                Dim deleteFeeSql As String = "DELETE FROM tblAssessmentOtherFees WHERE [RegistrationNo] = @RegistrationNo"
                Dim deleteFeeCmd As New OleDbCommand(deleteFeeSql, cn)
                With deleteFeeCmd
                    .Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)
                    .ExecuteNonQuery()
                End With

                For Each item As ListViewItem In ListView2.Items
                    Dim feeDesc As String = item.Text
                    Dim feeAmount As Double = Double.Parse(item.SubItems(1).Text)

                    Dim feeSql As String = "INSERT INTO tblAssessmentOtherFees ([RegistrationNo], [FeeDescription], [Amount]) VALUES (@RegistrationNo, @FeeDescription, @Amount)"
                    Using feeCmd As New OleDbCommand(feeSql, cn)
                        With feeCmd
                            .Parameters.AddWithValue("@RegistrationNo", lblRegNum.Text)
                            .Parameters.AddWithValue("@FeeDescription", feeDesc)
                            .Parameters.AddWithValue("@Amount", feeAmount)
                            .ExecuteNonQuery()
                        End With
                    End Using
                Next

                MsgBox("Mr./Ms " & txtname.Text & " successfully updated assessment!", MsgBoxStyle.Information)
            Else

                MsgBox("Registration number " & lblRegNum.Text & " does not exist.", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub
End Class
