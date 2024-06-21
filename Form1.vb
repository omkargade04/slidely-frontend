Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createForm As New CreateNewSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button2.PerformClick()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()

    End Sub

End Class
