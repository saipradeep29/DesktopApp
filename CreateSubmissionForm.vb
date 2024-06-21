Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Diagnostics
Imports System.Net.Http

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    ' Initialize form components
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form captures keyboard events
        Me.KeyPreview = True
        ' Set timer interval to 1 second
        tmrStopwatchUpdate.Interval = 1000
        ' Reset the stopwatch display
        display.Text = "00:00:00"
    End Sub

    ' Start/Stop stopwatch button click event
    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            tmrStopwatchUpdate.Stop()
            btnStopwatch.Text = "Start"
        Else
            stopwatch.Start()
            tmrStopwatchUpdate.Start()
            btnStopwatch.Text = "Stop"
        End If
    End Sub

    ' Timer tick event to update stopwatch display
    Private Sub tmrStopwatchUpdate_Tick(sender As Object, e As EventArgs) Handles tmrStopwatchUpdate.Tick
        UpdateStopwatchDisplay()
    End Sub

    ' Update the stopwatch display
    Private Sub UpdateStopwatchDisplay()
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        display.Text = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}"
    End Sub

    ' Submit button click event
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate inputs
        If Not ValidateInputs() Then
            Return
        End If

        ' Gather form data
        Dim nameValue As String = txtName.Text.Trim()
        Dim emailValue As String = txtEmail.Text.Trim()
        Dim phoneValue As String = txtPhone.Text.Trim()
        Dim githubLinkValue As String = txtGithub.Text.Trim()
        Dim stopwatchTimeValue As TimeSpan = TimeSpan.Parse(display.Text)  ' Convert display text to TimeSpan
        Dim submission As New FormSubmission(nameValue, emailValue, phoneValue, githubLinkValue, stopwatchTimeValue.ToString())

        Dim submissionData As New With {
        .name = nameValue,
        .email = emailValue,
        .phone = phoneValue,
        .github_link = githubLinkValue,
        .stopwatch_time = stopwatchTimeValue
    }

        ' Convert submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Send the JSON data to the server
        Try
            Using client As New HttpClient()
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful")
                Else
                    Dim errorMessage As String = "Error submitting data: " & response.ReasonPhrase
                    MessageBox.Show(errorMessage)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        End Try
        ' Reset the form and stopwatch
        ClearForm()
    End Sub

    ' Validate the form inputs
    Private Function ValidateInputs() As Boolean
        ' Validate required fields
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a Name.")
            txtName.Focus()
            Return False
        End If

        ' Validate email format
        Dim emailRegex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        If Not emailRegex.IsMatch(txtEmail.Text.Trim()) Then
            MessageBox.Show("Please enter a valid Email.")
            txtEmail.Focus()
            Return False
        End If

        ' Validate phone number (example: 10 digits)
        If Not IsNumeric(txtPhone.Text.Trim()) OrElse txtPhone.Text.Length <> 10 Then
            MessageBox.Show("Please enter a 10-digit Phone Number.")
            txtPhone.Focus()
            Return False
        End If

        ' Validate GitHub link format (example: starts with https://github.com/)
        If Not txtGithub.Text.Trim().StartsWith("https://github.com/") Then
            MessageBox.Show("Please enter a valid GitHub URL.")
            txtGithub.Focus()
            Return False
        End If

        Return True
    End Function

    ' Clear the form and reset stopwatch
    Private Sub ClearForm()
        ' Clear all textboxes
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()

        ' Reset stopwatch and stop the timer
        stopwatch.Reset()
        tmrStopwatchUpdate.Stop()
        display.Text = "00:00:00" ' Reset display
    End Sub

    ' Handle form keydown event for shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl + S shortcut for submission
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If

        ' Handle Ctrl + T shortcut for stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        End If
    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        ' Placeholder for display click event
    End Sub
End Class

Public Class FormSubmission
    Public Property FullName As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String

    Public Sub New(fullName As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        Me.FullName = fullName
        Me.Email = email
        Me.Phone = phone
        Me.GithubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
