Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 10
        Tabla1.Rows.Add(1)
        Tabla2.ColumnCount = 10
        Tabla2.Rows.Add(1)
        Tabla3.ColumnCount = 15
        Tabla3.Rows.Add(1)
        For i = 0 To 9
            Tabla1.Columns(i).Width = 40
            Tabla2.Columns(i).Width = 40
        Next
        For i = 0 To 14
            Tabla3.Columns(i).Width = 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(10), vectorSuma(15), indice, a As Integer
        For i = 1 To 10
            vector(i) = Tabla1.Item(i - 1, 0).Value
            Tabla2.Item(i - 1, 0).Value = vector(i)
        Next
        indice = 3
        For i = 1 To 15
            If indice = i Then
                vectorSuma(i) = vectorSuma(i - 2) + vectorSuma(i - 1)
                indice += 3
                a += 1
            Else
                vectorSuma(i) = vector(i - a)
            End If
            Tabla3.Item(i - 1, 0).Value = vectorSuma(i)
        Next
    End Sub
End Class
