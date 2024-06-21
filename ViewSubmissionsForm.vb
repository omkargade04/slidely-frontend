Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private currentIndex As Integer = 0

    Public Class User
        Public Property Name As String
        Public Property Email As String
        Public Property PhoneNum As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Async Sub DisplayUserData(index As Integer)

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:5000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

                Dim user As User = JsonConvert.DeserializeObject(Of User)(jsonResponse)
                Dim userObject As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonResponse)

                If user Is Nothing Then
                    MessageBox.Show("Error retrieving user details.")
                    Exit Sub
                End If

                If user IsNot Nothing Then
                    TextBox1.Text = userObject("Name")
                    TextBox2.Text = userObject("Email")
                    TextBox3.Text = userObject("Phone Num")
                    TextBox4.Text = userObject("Github Link")
                    TextBox5.Text = userObject("Stopwatch Time")
                End If

            End If
        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim index As Integer = 0
        DisplayUserData(index)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayUserData(currentIndex)
        Else
            MessageBox.Show("You are already at the first submission.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentIndex += 1
        DisplayUserData(currentIndex)
    End Sub




End Class