<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Khaki
        Me.btnViewSubmissions.Location = New System.Drawing.Point(201, 177)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(287, 23)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions  (CTRL+V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(202, 234)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(287, 23)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission  (CTRL+N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "sai pradeep, slidely AI Task2 - slidely  form app" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Label1 As Label
End Class
