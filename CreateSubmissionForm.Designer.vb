<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.timerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tmrStopwatchUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(159, 92)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtName.Location = New System.Drawing.Point(326, 89)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 22)
        Me.txtName.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(159, 135)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone num"
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(159, 217)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(68, 16)
        Me.lblGithub.TabIndex = 4
        Me.lblGithub.Text = "Github link"
        '
        'display
        '
        Me.display.AutoSize = True
        Me.display.Location = New System.Drawing.Point(323, 263)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(55, 16)
        Me.display.TabIndex = 5
        Me.display.Text = "00:00:00"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmail.Location = New System.Drawing.Point(326, 129)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(182, 22)
        Me.txtEmail.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPhone.Location = New System.Drawing.Point(326, 170)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(182, 22)
        Me.txtPhone.TabIndex = 7
        '
        'txtGithub
        '
        Me.txtGithub.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGithub.Location = New System.Drawing.Point(326, 211)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(182, 22)
        Me.txtGithub.TabIndex = 8
        '
        'btnStopwatch
        '
        Me.btnStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.btnStopwatch.Location = New System.Drawing.Point(149, 281)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(160, 23)
        Me.btnStopwatch.TabIndex = 10
        Me.btnStopwatch.Text = "Start/Stop (CTRL+T)"
        Me.btnStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(211, 329)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(167, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "&Submit (CTRL+S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'timerUpdate
        '
        Me.timerUpdate.Interval = 1000
        '
        'tmrStopwatchUpdate
        '
        Me.tmrStopwatchUpdate.Interval = 1000
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "stopwatch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "sai pradeep, Slidely AI task2 - create form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.KeyPreview = True
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents display As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents timerUpdate As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrStopwatchUpdate As Timer
    Friend WithEvents lblStopwatch As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
