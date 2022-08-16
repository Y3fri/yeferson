Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = CInt(TextBox1.Text)
        Dim b = CInt(TextBox2.Text)
        Dim c = CInt(TextBox3.Text)
        For i = a To b Step c
            ListBox1.Items.Add(i.ToString)

        Next
    End Sub
End Class
