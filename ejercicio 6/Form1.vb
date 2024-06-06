Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, contraPalabra As String
        Dim longitud As Integer
        palabra = TextBox1.Text
        longitud = palabra.Length
        contraPalabra = palabra.Substring(longitud - 1, 1)
        For a = 2 To longitud
            contraPalabra &= palabra.Substring(longitud - a, 1)
        Next
        If palabra = contraPalabra Then
            TextBox2.Text = "es palindroma"
        Else
            TextBox2.Text = "no es palindroma"
        End If
    End Sub
End Class
