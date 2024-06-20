Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class MainForm

    Private BaseUrl As String = "http://localhost:3000"

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim submissions As New List(Of Submission)() ' Populate this list with actual data
        Dim viewForm As New ViewSubmissionsForm(submissions)
        viewForm.Show()
    End Sub

    Private Async Function FetchSubmissions() As Task(Of List(Of Submission))
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"{BaseUrl}/read?index=0")

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                Return submissions
            Else
                Throw New Exception($"Failed to fetch submissions. Status code: {response.StatusCode}")
            End If
        End Using
    End Function

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check for keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Placeholder for Label1 click event
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
