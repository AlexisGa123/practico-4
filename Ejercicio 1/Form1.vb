Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla3.ColumnCount = 10
        Tabla3.Rows.Add(1)
        For i = 0 To 9
            Tabla3.Columns(i).Width = 40
        Next
        Tabla2.ColumnCount = 10
        Tabla2.Rows.Add(1)
        For i = 0 To 9
            Tabla2.Columns(i).Width = 40
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(10), num As Integer
        Dim mayor As Integer = 0
        num = InputBox("numero a calcular")
        For fila = 1 To 10
                vector(fila) = Tabla2.Item(fila - 1, 0).Value
                If vector(fila) Mod (2) = 0 Then
                    ListBox2.Items.Add(vector(fila))
                Else
                    ListBox1.Items.Add(vector(fila))
                End If
                If vector(fila) > mayor Then
                    mayor = vector(fila)
                    TextBox1.Text = vector(fila)
                    TextBox2.Text = fila
                End If
            Next
            For a = 1 To 10
                Tabla3.Item(a - 1, 0).Value = vector(11 - a)
                If vector(a) Mod num = 0 Then
                    ListBox3.Items.Add(vector(a))
                End If
            Next
        Label7.Text = "Los multiplos de " & num & " son:"
    End Sub
End Class
