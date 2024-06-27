Imports Microsoft.VisualBasic.Devices
Imports System.Reflection.Emit

Public Class PrintAssessment
    Public Property StudentNo As String
    Public Property StudentName As String
    Public Property Course As String
    Public Property YearLevel As String
    Public Property SchoolYear As String
    Public Property Semester As String
    Public Property AssessmentDateTime As DateTime
    Public Property TuitionFee As String
    Public Property MiscFee As String
    Public Property LabFee As String
    Public Property Discount As String
    Public Property Full As String
    Public Property Units As String
    Public Property TotalAssessment As String
    Public Property UponEnrollment As String
    Public Property Month1 As String
    Public Property Month2 As String
    Public Property month3 As String
    Public Property month As String
    Public Property ScheduleItems As List(Of ListViewItem)
    Public Property ScheduleItem As List(Of ListViewItem)
    Private Sub PrintAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        txtStudentNo.Text = StudentNo
        txtName.Text = StudentName
        txtCourse.Text = Course
        txtYearLevel.Text = YearLevel
        txtSY.Text = SchoolYear
        txtSemester.Text = Semester
        txtDatePrint.Text = AssessmentDateTime.ToString("MM/dd/yyyy hh:mm:ss tt")
        txtTuitionFee.Text = TuitionFee.ToString()
        txtMiscFee.Text = MiscFee.ToString()
        txtLabFee.Text = LabFee.ToString()
        txtAssessment.Text = TotalAssessment.ToString()
        txtFullPayment.Text = Full.ToString()
        txtUnits.Text = Units.ToString()
        txtmonth.Text = Month.ToString()
        txtMonth1.Text = Month1.ToString()
        txtMonth2.Text = Month2.ToString()
        txtmonth3.Text = month3.ToString()
        txtUpon.Text = UponEnrollment.ToString()

        For Each item As ListViewItem In ScheduleItems
            Dim newItem As New ListViewItem(item.SubItems(0).Text)
            LVSection.Items.Add(newItem)
        Next
        For Each item As ListViewItem In ScheduleItems
            Dim newItem As New ListViewItem(item.SubItems(1).Text)

            LVCode.Items.Add(newItem)
        Next
        For Each item As ListViewItem In ScheduleItems
            Dim newItem As New ListViewItem(item.SubItems(2).Text)

            LVDesc.Items.Add(newItem)
        Next
        For Each item As ListViewItem In ScheduleItems
            Dim newItem As New ListViewItem(item.SubItems(3).Text)

            LVUnits.Items.Add(newItem)
        Next
        For Each item As ListViewItem In ScheduleItem
            If item.Text <> "Discount" Then
                Dim newItem As New ListViewItem(item.SubItems(1).Text)
                LVOFAmount.Items.Add(newItem)
            End If
        Next

        For Each item As ListViewItem In ScheduleItem
            If item.Text <> "Discount" Then
                Dim newItem As New ListViewItem(item.SubItems(0).Text)
                LVOtherFee.Items.Add(newItem)
            End If
        Next

        For Each item As ListViewItem In ScheduleItem
            If item.Text = "Discount" Then
                Dim discountAmount As String = item.SubItems(1).Text
                txtDiscount.Text = discountAmount
                Exit For
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class