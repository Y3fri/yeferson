Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim a = CInt(TextBox1.Text)

        If (a = 4) Then
            Label2.Text = "Acceso permitido"
            TextBox1.Enabled = False
        Else
            Label2.Text = "Acceso denegado"
            TextBox1.Text = " "
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
