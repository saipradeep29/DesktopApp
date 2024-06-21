Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Public Sub New(submissionList As List(Of Submission))
        InitializeComponent()
        Me.submissions = submissionList
        LoadSubmissions()
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(0)) ' Display the first submission
        Else
            ClearSubmissionFields()
        End If
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("http://localhost:3000/read?index=" & currentIndex), HttpWebRequest)
            request.Method = "GET"

            Using response As HttpWebResponse = CType(Await request.GetResponseAsync(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    Using reader As New StreamReader(response.GetResponseStream())
                        Dim responseText As String = Await reader.ReadToEndAsync()

                        ' Attempt to parse as array of submissions
                        Try
                            Dim submissionsArray As JArray = JArray.Parse(responseText)
                            submissions = submissionsArray.ToObject(Of List(Of Submission))()
                        Catch ex As JsonReaderException
                            ' If parsing as array fails, try to parse as single submission
                            Try
                                Dim singleSubmission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseText)
                                submissions = New List(Of Submission)() From {singleSubmission}
                            Catch ex2 As Exception
                                MessageBox.Show("Error parsing JSON: " & ex2.Message)
                                submissions = New List(Of Submission)()
                            End Try
                        End Try

                        ' Display the submissions
                        If submissions.Count > 0 Then
                            DisplaySubmission(submissions(currentIndex))
                        Else
                            ClearSubmissionFields()
                        End If
                    End Using
                Else
                    MessageBox.Show("Error loading submissions from server: " & response.StatusDescription)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading submissions from server: " & ex.Message)
        End Try
    End Sub




    Private Sub DisplaySubmission(submission As Submission)
        ' Display submission details in UI
        txtFullName.Text = submission.FullName
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.GitHubLink
        txtStopwatchTime.Text = submission.StopwatchTime.ToString()
    End Sub

    Private Sub ClearSubmissionFields()
        txtFullName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        txtStopwatchTime.Clear()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex)) ' Update to display current submission
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex)) ' Update to display current submission
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Implement deletion logic if needed
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property FullName As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As Integer

    Public Sub New(fullName As String, email As String, phone As String, githubLink As String, stopwatchTime As Integer)
        Me.FullName = fullName
        Me.Email = email
        Me.Phone = phone
        Me.GitHubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
