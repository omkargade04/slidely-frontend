Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class CreateNewSubmissionForm


    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub CreateNewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Enabled = True
        Timer1.Interval = 1000 ' 1 second interval
        Timer1.Start()
        Label7.Text = "00:00:00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update Label with elapsed time
        Label7.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub CreateNewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Async Function SendDataToBackend(jsonData As String) As Task(Of Boolean)
        Dim successful As Boolean = False

        Using client As New HttpClient()
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:5000/submit", content)

            If response.IsSuccessStatusCode Then
                successful = True
            Else
                ' Handle potential errors from the server (optional)
                Dim errorMessage As String = Await response.Content.ReadAsStringAsync()
                Console.WriteLine("Error message from server: " & errorMessage)
            End If
        End Using

        Return successful
    End Function

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim submission As New Dictionary(Of String, String) From {
            {"Name", TextBox1.Text},
            {"Email", TextBox2.Text},
            {"Phone Num", TextBox3.Text},
            {"Github Link", TextBox4.Text},
            {"Stopwatch Time", Label7.Text}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)

        Try
            Dim successful = Await SendDataToBackend(json)
            If successful Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error submitting form. Please check the network connection or server response.")
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Button1.Text = "Resume"
        Else
            stopwatch.Start()
            Button1.Text = "Pause"
        End If
    End Sub

End Class