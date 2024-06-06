Public Class Form1
    Dim palabra As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 4
        Tabla1.Rows.Add(5)
        For i = 0 To 3
            Tabla1.Columns(i).Width = 40
        Next
        Tabla2.ColumnCount = 4
        Tabla2.Rows.Add(5)
        For i = 0 To 3
            Tabla2.Columns(i).Width = 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim matriz(5, 4) As Integer
        Dim suma, mayor As Integer
        For fila = 1 To 5
            For columna = 1 To 4
                matriz(fila, columna) = Tabla1.Item(columna - 1, fila - 1).Value
                Tabla2.Item(columna - 1, fila - 1).Value = matriz(fila, columna)
            Next
        Next
        For columna = 1 To 4
            suma += matriz(2, columna)
            suma += matriz(3, columna)
            suma += matriz(4, columna)
            suma += matriz(5, columna)
        Next
        For fila = 1 To 5
            For columna = 2 To 4
                If matriz(fila, columna) > mayor Then
                    mayor = matriz(fila, columna)
                End If
            Next
        Next
        TextBox1.Text = suma
        TextBox2.Text = mayor

    End Sub
End Class
