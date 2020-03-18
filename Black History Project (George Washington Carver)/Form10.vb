Public Class Form10
    Dim rating As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        rating = 5
        Label2.Text = "Your rating is " & rating.ToString & vbCrLf & "Thanks for the feedback!"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        rating = 4
        Label2.Text = "Your rating is " & rating.ToString & vbCrLf & "Thanks for the feedback!"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        rating = 3
        Label2.Text = "Your rating is " & rating.ToString & vbCrLf & "Thanks for the feedback!"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        rating = 2
        Label2.Text = "Your rating is " & rating.ToString & vbCrLf & "Thanks for the feedback!"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        rating = 1
        Label2.Text = "Your rating is " & rating.ToString & vbCrLf & "Thanks for the feedback!"
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class