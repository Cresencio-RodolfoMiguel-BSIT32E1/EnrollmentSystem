Imports System.Drawing.Printing
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class receipt
    Dim bmp As Bitmap
    Dim val As String
    Dim ddate As String
    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the desired paper size here
        Dim paperSize As New PaperSize("CustomPaperSize", 560, 700) ' Width and Height in hundredths of an inch
        PrintDocument1.DefaultPageSettings.PaperSize = paperSize
        lbldate.Text = Date.Now.ToString("MM-dd-yyyy")
        lblgrandtotal.Text = lbloutbal.Text


    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If bmp IsNot Nothing Then
            btnprint.Hide()
            btncancel.Hide()
            e.Graphics.DrawImage(bmp, 0, 0)
        End If
    End Sub
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim grandTotal As Integer
        Dim amount As Integer

        If Integer.TryParse(txtgrandtotal.Text, grandTotal) AndAlso Integer.TryParse(txtamount.Text, amount) Then
            ' Compare the numeric values
            If grandTotal > amount Then
                MessageBox.Show("User Pay Amount is Insufficient", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            ElseIf cboPaymentFor.Text = "Downpayment" Then

                If txtamount.Text < 5000 Then
                    MessageBox.Show("Downpayment amount cannot be below 5000.", "Payment Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    If RichTextBox1.Text = "Type Here (Optional)" Then
                        RichTextBox1.Text = ""
                    End If
                    If RichTextBox2.Text = "Type Here (Optional)" Then
                        RichTextBox2.Text = ""
                    End If
                    If TextBox2.Text = "Type Here (Optional)" Then
                        TextBox2.Text = ""
                    End If
                    If TextBox3.Text = "Type Here (Optional)" Then
                        TextBox3.Text = ""
                    End If
                    If TextBox4.Text = "Type Here (Optional)" Then
                        TextBox4.Text = ""
                    End If
                    If TextBox5.Text = "Type Here (Optional)" Then
                        TextBox5.Text = ""
                    End If
                    If lblpayamount.Text = "Amount" Then
                        lblpayamount.Text = ""
                    End If
                    If lblpaymenttype.Text = "Payment Type" Then
                        lblpaymenttype.Text = ""
                    End If
                    If lblgrandtotal.Text = "0.00" Then
                        lblpaymenttype.Text = ""
                    End If
                    If lblchangeamt.Text = "###" Then
                        lblchangeamt.Text = ""
                    End If

                    CaptureFormContent()
                    If bmp IsNot Nothing Then
                        Me.Hide()
                        btncancel.Hide()
                        PrintPreviewDialog1.Document = PrintDocument1
                        PrintPreviewDialog1.ShowDialog()
                    End If


                    Dim sql As String = "INSERT INTO tblCollection ([StudentNo], [ORNo], [RegistrationNo], [PaymentFor], [Payment], [DateTimePayment], [Cashier])" &
                            " VALUES (@StudentNo, @ORNo, @RegistrationNo, @PaymentFor, @Payment, @DateTimePayment, @Cashier)"

                    Using cmd As New OleDbCommand(sql, cn)
                        ' Set parameters
                        cmd.Parameters.AddWithValue("@StudentNo", lblstudentno.Text)
                        cmd.Parameters.AddWithValue("@ORNo", txtorno.Text)
                        cmd.Parameters.AddWithValue("@RegistrationNo", lblregno.Text)
                        cmd.Parameters.AddWithValue("@PaymentFor", cboPaymentFor.Text)
                        cmd.Parameters.AddWithValue("@Payment", Convert.ToDecimal(txtamount.Text)) ' Ensure txtAmount.Text is converted to Decimal
                        cmd.Parameters.AddWithValue("@DateTimePayment", DateTime.Now) ' Use DateTime.Now for current date and time
                        cmd.Parameters.AddWithValue("@Cashier", financedashboard.lbluser.Text)

                        ' Execute query
                        cmd.ExecuteNonQuery()

                        ' Inform user
                        MessageBox.Show("Payment successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear fields after successful insert
                        txtorno.Text = ""
                        cboPaymentFor.SelectedIndex = -1
                        txtamount.Text = ""
                    End Using

                    'LoadPaymentData(lblregno.Text)

                End If
            Else
                If RichTextBox1.Text = "Type Here (Optional)" Then
                    RichTextBox1.Text = ""
                End If
                If RichTextBox2.Text = "Type Here (Optional)" Then
                    RichTextBox2.Text = ""
                End If
                If TextBox2.Text = "Type Here (Optional)" Then
                    TextBox2.Text = ""
                End If
                If TextBox3.Text = "Type Here (Optional)" Then
                    TextBox3.Text = ""
                End If
                If TextBox4.Text = "Type Here (Optional)" Then
                    TextBox4.Text = ""
                End If
                If TextBox5.Text = "Type Here (Optional)" Then
                    TextBox5.Text = ""
                End If
                If lblpayamount.Text = "Amount" Then
                    lblpayamount.Text = ""
                End If
                If lblpaymenttype.Text = "Payment Type" Then
                    lblpaymenttype.Text = ""
                End If
                If lblgrandtotal.Text = "0.00" Then
                    lblpaymenttype.Text = ""
                End If
                If lblchangeamt.Text = "###" Then
                    lblchangeamt.Text = ""
                End If

                CaptureFormContent()
                If bmp IsNot Nothing Then
                    Me.Hide()
                    btncancel.Hide()
                    PrintPreviewDialog1.Document = PrintDocument1
                    PrintPreviewDialog1.ShowDialog()
                End If

                Dim sql As String = "INSERT INTO tblCollection ([StudentNo], [ORNo], [RegistrationNo], [PaymentFor], [Payment], [DateTimePayment], [Cashier])" &
                         " VALUES (@StudentNo, @ORNo, @RegistrationNo, @PaymentFor, @Payment, @DateTimePayment, @Cashier)"

                Using cmd As New OleDbCommand(sql, cn)
                    ' Set parameters
                    cmd.Parameters.AddWithValue("@StudentNo", lblstudentno.Text)
                    cmd.Parameters.AddWithValue("@ORNo", txtorno.Text)
                    cmd.Parameters.AddWithValue("@RegistrationNo", lblregno.Text)
                    cmd.Parameters.AddWithValue("@PaymentFor", cboPaymentFor.Text)
                    cmd.Parameters.AddWithValue("@Payment", Convert.ToDecimal(txtamount.Text)) ' Ensure txtAmount.Text is converted to Decimal
                    cmd.Parameters.AddWithValue("@DateTimePayment", DateTime.Now) ' Use DateTime.Now for current date and time
                    cmd.Parameters.AddWithValue("@Cashier", financedashboard.lbluser.Text)

                    ' Execute query
                    cmd.ExecuteNonQuery()

                    ' Inform user
                    MessageBox.Show("Payment successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear fields after successful insert
                    txtorno.Text = ""
                    cboPaymentFor.SelectedIndex = -1
                    txtamount.Text = ""
                End Using
            End If
        End If
    End Sub

    Private Sub CaptureFormContent()
        ' Create a bitmap with the same size as the form
        btnprint.Hide()
        btncancel.Hide()
        bmp = New Bitmap(Me.Width, Me.Height)

        ' Draw the form onto the bitmap
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, rect)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtorno_TextChanged(sender As Object, e As EventArgs) Handles txtorno.TextChanged
        lblorno.Text = txtorno.Text
    End Sub

    Private Sub cboPaymentFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentFor.SelectedIndexChanged
        lblpaymenttype.Text = cboPaymentFor.SelectedItem
    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        lblpayamount.Text = txtamount.Text
        Call calcchange()
    End Sub

    Private Sub txtgrandtotal_TextChanged(sender As Object, e As EventArgs) Handles txtgrandtotal.TextChanged
        lblgrandtotal.Text = txtgrandtotal.Text
        Call calcchange()
        ' Assume Label1.Text contains the maximum allowed value
        Dim maxValue As Double
        If Double.TryParse(lbloutbal.Text, maxValue) Then
            ' Check if TextBox1.Text is a valid number
            Dim userInput As Double
            If Integer.TryParse(txtgrandtotal.Text, userInput) Then
                ' Compare userInput with maxValue
                If userInput > maxValue Then
                    ' If userInput exceeds maxValue, adjust TextBox1.Text accordingly
                    txtgrandtotal.Text = maxValue.ToString()
                    ' Optionally, you can notify the user about the maximum allowed value
                    MessageBox.Show("Input value exceeds maximum allowed value.")
                End If
            Else
                ' Handle case where TextBox1.Text is not a valid integer
                MessageBox.Show("Please enter a valid integer.")
                txtgrandtotal.Text = "" ' Clear invalid input or take other appropriate action
            End If
        Else
            ' Handle case where Label1.Text is not a valid integer (if applicable)
            MessageBox.Show("Maximum value is not set correctly.")
        End If
    End Sub

    Private Sub calcchange()
        Dim amount As Integer
        Dim grandTotal As Integer

        ' Try to convert the text to integer values
        If Integer.TryParse(txtamount.Text, amount) AndAlso Integer.TryParse(txtgrandtotal.Text, grandTotal) Then
            ' Perform the subtraction and set the result as the text of lblChange
            lblChange.Text = (amount - grandTotal).ToString()
        End If
    End Sub


    Private Sub lblChange_TextChanged(sender As Object, e As EventArgs) Handles lblChange.TextChanged
        lblchangeamt.Text = lblChange.Text
    End Sub
End Class
