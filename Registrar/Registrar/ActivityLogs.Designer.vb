<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogs
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityLogs))
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        Me.ActLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnActivityLogs
        '
        Me.btnActivityLogs.BackColor = System.Drawing.Color.Transparent
        Me.btnActivityLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnActivityLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivityLogs.FlatAppearance.BorderSize = 0
        Me.btnActivityLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivityLogs.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivityLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivityLogs.Location = New System.Drawing.Point(84, 62)
        Me.btnActivityLogs.Name = "btnActivityLogs"
        Me.btnActivityLogs.Size = New System.Drawing.Size(177, 44)
        Me.btnActivityLogs.TabIndex = 60
        Me.btnActivityLogs.Text = "Activity Logs"
        Me.btnActivityLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivityLogs.UseVisualStyleBackColor = False
        '
        'ActLogs
        '
        Me.ActLogs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ActLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ActLogs.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActLogs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ActLogs.GridLines = True
        Me.ActLogs.HideSelection = False
        Me.ActLogs.Location = New System.Drawing.Point(84, 111)
        Me.ActLogs.Margin = New System.Windows.Forms.Padding(2)
        Me.ActLogs.Name = "ActLogs"
        Me.ActLogs.Size = New System.Drawing.Size(786, 386)
        Me.ActLogs.TabIndex = 0
        Me.ActLogs.UseCompatibleStateImageBehavior = False
        Me.ActLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Username"
        Me.ColumnHeader18.Width = 300
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Role"
        Me.ColumnHeader19.Width = 300
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Action"
        Me.ColumnHeader20.Width = 300
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Date/Time"
        Me.ColumnHeader21.Width = 320
        '
        'ActivityLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.ActLogs)
        Me.Controls.Add(Me.btnActivityLogs)
        Me.Name = "ActivityLogs"
        Me.Size = New System.Drawing.Size(967, 671)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents ActLogs As ListView
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
End Class
