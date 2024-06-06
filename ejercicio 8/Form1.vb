Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, verificar As String
        Dim longitud, contador As Integer
        palabra = TextBox1.Text
        longitud = palabra.Length
        For i = 1 To longitud
            verificar = palabra.Substring(i - 1, 1)
            If verificar = "," Then
                contador += 1
            End If
        Next
        TextBox2.Text = contador
    End Sub
End Class
