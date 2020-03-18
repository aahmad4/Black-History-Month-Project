Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblInformation.Text = "" Then
            MessageBox.Show("View the additional information before moving on!")
        Else
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lblInformation.Text = "George Washington Carver was interested in a lot of science. The type of science he was interested in dealt with nature, real world problems, and how it all blended together. "
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lblInformation.Text = "George Washington Carver was interested in a lot of art. The type of art he was interested in dealt with making paintings and drawings which looked similar to blueprints for something. "
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        lblInformation.Text = "The whole science and art blended for him because he ended up in a mix between the agriculture industry as well as the art industry. He was apart of the agriculture industry as he studied lots of different plants. He was in the art industry as he found out how to make things out of the plants to help out in the real world. "
    End Sub
End Class