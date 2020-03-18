Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblMainCheese.Text = "" Then
            MessageBox.Show("Please view the additional information before moving on!")
        Else
            Form6.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lblMainCheese.Text = "In college, George Washington Carver studied art and painting. His teacher found him to have a lot of talent and interest in painting plants. This is where his agriculture interest began. Also, because of this he transferred schools to learn more about agriculture and that is what he studied."
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lblMainCheese.Text = "He earned his bachelor's degree in 1894 and a graduate degree in 1896."
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        lblMainCheese.Text = "Yes, he did proceed further in his studies, he ended up studying agriculture after he transferred schools. From this, he began to study a multitude of plants. "
    End Sub
End Class