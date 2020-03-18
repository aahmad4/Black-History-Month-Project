Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblShirtChoice.Text = "" Then
            MessageBox.Show("Please choose a shirt color before moving on!")
        Else
            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lblShirtChoice.Text = "You chose the blue shirt!"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lblShirtChoice.Text = "You chose the red shirt!"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim shirtColor As String
        shirtColor = TextBox1.Text
        lblShirtChoice.Text = "You chose a " & shirtColor & " shirt!"

        If TextBox1.Text = "" Then
            lblShirtChoice.Text = ""
            MessageBox.Show("Please enter a color!")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblShirtChoice.Text = ""
    End Sub
End Class