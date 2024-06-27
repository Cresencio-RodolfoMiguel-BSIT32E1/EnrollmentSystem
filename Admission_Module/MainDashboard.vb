Imports System.Data.OleDb
Public Class MainDashboard

    Private Sub Gymmanagementdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        DateTimePicker1.Hide()

        SetButtonColors(btnlogout)

        ' To set the text to the left side
        SetButtonProperties(btnreport, ContentAlignment.MiddleRight)
        SetButtonProperties(btnregister, ContentAlignment.MiddleRight)
        SetButtonProperties(btnlist, ContentAlignment.MiddleRight)
        SetButtonProperties(btnlogout, ContentAlignment.MiddleCenter)

        ' Attach MouseDown and MouseUp event handlers to each button
        AddHandler btnreport.MouseDown, AddressOf Button_MouseDown
        AddHandler btnreport.MouseUp, AddressOf Button_MouseUp
        AddHandler btnregister.MouseDown, AddressOf Button_MouseDown
        AddHandler btnregister.MouseUp, AddressOf Button_MouseUp
        AddHandler btnlist.MouseDown, AddressOf Button_MouseDown
        AddHandler btnlist.MouseUp, AddressOf Button_MouseUp
        AddHandler btnlogout.MouseDown, AddressOf Button_MouseDown
        AddHandler btnlogout.MouseUp, AddressOf Button_MouseUp

        ' Attach Click event handlers to change background color
        AddHandler btnreport.Click, AddressOf Button_Click
        AddHandler btnregister.Click, AddressOf Button_Click
        AddHandler btnlist.Click, AddressOf Button_Click
        AddHandler btnlogout.Click, AddressOf Button_Click
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.FromArgb(253, 197, 0)
        button.Capture = True
    End Sub

    Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs)
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.FromArgb(61, 169, 252)
    End Sub

    Private Sub Button_Click(sender As System.Object, e As System.EventArgs)
        Dim btnCurrent As Button = DirectCast(sender, Button)

        For Each myButton As Button In Me.Controls.OfType(Of Button)()
            myButton.BackColor = Color.FromArgb(253, 197, 0)
        Next
        btnCurrent.BackColor = Color.Blue
    End Sub

    Private Sub SetButtonProperties(button As Button, alignment As ContentAlignment)
        button.BackColor = Color.FromArgb(253, 197, 0)
        button.FlatAppearance.BorderColor = Color.FromArgb(253, 197, 0)

        ' Set flat appearance to make the button flat with rounded corners
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseDownBackColor = Color.FromArgb(253, 197, 0)
        'button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 41, 107)

        ' Set text alignment
        button.TextAlign = alignment

        ' Set rounded corners
        Dim rectangle As New Drawing2D.GraphicsPath()
        rectangle.StartFigure()
        rectangle.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        rectangle.AddLine(10, 0, button.Width - 10, 0)
        rectangle.AddArc(New Rectangle(button.Width - 10, 0, 10, 10), -90, 90)
        rectangle.AddLine(button.Width, 10, button.Width, button.Height - 10)
        rectangle.AddArc(New Rectangle(button.Width - 10, button.Height - 10, 10, 10), 0, 90)
        rectangle.AddLine(button.Width - 10, button.Height, 10, button.Height)
        rectangle.AddArc(New Rectangle(0, button.Height - 10, 10, 10), 90, 90)
        rectangle.CloseFigure()
        button.Region = New Region(rectangle)
    End Sub


    Private Sub SetButtonColors(button As Button)
        button.BackColor = Color.FromArgb(29, 41, 81)

        button.FlatAppearance.BorderColor = Color.FromArgb(168, 169, 173)
    End Sub


    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim RegistrationForm As New RegistrationForm()
        Panel1.Controls.Clear()
        RegistrationForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(RegistrationForm)
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim ListofApplicants As New ListofApplicants()
        Panel1.Controls.Clear()
        ListofApplicants.Dock = DockStyle.Fill
        Panel1.Controls.Add(ListofApplicants)
    End Sub
    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim ApplicantReports As New ApplicantReports
        Panel1.Controls.Clear()
        ApplicantReports.Dock = DockStyle.Fill
        Panel1.Controls.Add(ApplicantReports)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldatetime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub


End Class
