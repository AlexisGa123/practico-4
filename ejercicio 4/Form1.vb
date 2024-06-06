Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 8
        Tabla1.Rows.Add(10)
        Tabla2.ColumnCount = 10
        Tabla2.Rows.Add(1)
        For i = 0 To 7
            Tabla1.Columns(i).Width = 40
        Next
        For i = 0 To 9
            Tabla2.Columns(i).Width = 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim matriz(8, 10) As Integer
        Dim minimo, colum As Integer
        colum = 0
        For fila = 1 To 10
            minimo = Tabla1.Item(0, colum).Value
            For colu = 1 To 8
                matriz(colu, fila) = Tabla1.Item(colu - 1, fila - 1).Value
                If matriz(colu, fila) < minimo Then
                    minimo = matriz(colu, fila)
                End If
            Next
            Tabla2.Item(colum, 0).Value = minimo
            colum += 1
        Next
    End Sub
End Class
