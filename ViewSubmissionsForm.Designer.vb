<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtName.Location = New System.Drawing.Point(314, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(213, 22)
        Me.txtName.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Github link"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     time"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmail.Location = New System.Drawing.Point(314, 121)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(213, 22)
        Me.txtEmail.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPhone.Location = New System.Drawing.Point(314, 165)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(213, 22)
        Me.txtPhone.TabIndex = 8
        '
        'txtGithub
        '
        Me.txtGithub.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGithub.Location = New System.Drawing.Point(314, 210)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.ReadOnly = True
        Me.txtGithub.Size = New System.Drawing.Size(213, 22)
        Me.txtGithub.TabIndex = 9
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtStopwatchTime.Location = New System.Drawing.Point(314, 266)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(213, 22)
        Me.txtStopwatchTime.TabIndex = 10
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.Location = New System.Drawing.Point(166, 334)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(151, 28)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "Previous  (CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNext.Location = New System.Drawing.Point(376, 334)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(151, 28)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next (CTRL+N)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "sai pradeep, Slidely AI task2 - view submission" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(265, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(138, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete (CTRL+D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
End Class
