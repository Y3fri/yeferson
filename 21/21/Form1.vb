Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = CInt(TextBox1.Text())
        If (a = 1 Or a = 0) Then
            ListBox1.Items.Add("el numero " & a & " no es primo")
        End If
        If (a = 2) Then
            ListBox1.Items.Add("el numero " & a & " es primo")
        Else
            For i = 2 To a
                If (a Mod i = 0) Then
                    ListBox1.Items.Add("el numero " & a & " no es primo")
                    Exit For
                Else
                    ListBox1.Items.Add("el numero " & a & " es primo")
                    Exit For
                End If
            Next
        End If
        TextBox1.Text = " "

    End Sub
End Class
