<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicantReports
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.cboreporttype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(51, 110)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(861, 427)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RegistrationNo"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Applicants Name"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ApplicantStatus"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DateAdded"
        Me.ColumnHeader6.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "As of Date:"
        '
        'lbldate
        '
        Me.lbldate.Location = New System.Drawing.Point(370, 69)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(200, 20)
        Me.lbldate.TabIndex = 133
        '
        'cboreporttype
        '
        Me.cboreporttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboreporttype.FormattingEnabled = True
        Me.cboreporttype.Items.AddRange(New Object() {"All", "Daily", "Monthly", "Yearly"})
        Me.cboreporttype.Location = New System.Drawing.Point(51, 68)
        Me.cboreporttype.Name = "cboreporttype"
        Me.cboreporttype.Size = New System.Drawing.Size(206, 21)
        Me.cboreporttype.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(696, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Total Applicants:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(813, 69)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(14, 16)
        Me.lbltotal.TabIndex = 136
        Me.lbltotal.Text = "0"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "AcademicYear"
        Me.ColumnHeader4.Width = 90
        '
        'ApplicantReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Admission_Module.My.Resources.Resources.Untitled_design__10_4
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboreporttype)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ApplicantReports"
        Me.Size = New System.Drawing.Size(960, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents cboreporttype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
