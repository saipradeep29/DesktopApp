Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Public Sub New(submissions As List(Of Submission))
        InitializeComponent()
        Me.submissions = submissions
        LoadSubmissions()
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(0))
        Else
            ClearSubmissionFields()
        End If
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("http://localhost:3000/read?index=" & currentIndex), HttpWebRequest)
            request.Method = "GET"

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    Using reader As New StreamReader(response.GetResponseStream())
                        Dim responseText As String = reader.ReadToEnd()

                        ' Debug: Print response text
                        Console.WriteLine("Response Text: " & responseText)

                        ' Deserialize JSON response to Submission object
                        Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseText)

                        ' Debug: Print deserialized object
                        Console.WriteLine("Deserialized Submission: " & JsonConvert.SerializeObject(submission))

                        ' Display the submission data
                        DisplaySubmission(submission)
                    End Using
                Else
                    MessageBox.Show("Error loading submission from server: " & response.StatusDescription)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading submission from server: " & ex.Message)
        End Try
    End Sub


    Private Sub DisplaySubmission(submission As Submission)
        If submission IsNot Nothing Then
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithub.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime.ToString()
        Else
            ClearSubmissionFields()
        End If
    End Sub

    Private Sub ClearSubmissionFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        txtStopwatchTime.Clear()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex))
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
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As Integer

    Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As Integer)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GitHubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
