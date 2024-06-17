Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 7
        Tabla1.Rows.Add(7)
        Tabla2.ColumnCount = 7
        Tabla2.Rows.Add(1)
        For i = 0 To 6
            Tabla1.Columns(i).Width = 40
            Tabla2.Columns(i).Width = 40
        Next
        Tabla3.ColumnCount = 4
        Tabla3.Rows.Add(3)
        For i = 0 To 3
            Tabla3.Columns(i).Width = 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(7), matrizNueva(3, 4), matriz(7, 7), mayor As Integer
        For fil = 1 To 7
            For col = 1 To 7
                matriz(fil, col) = Tabla1.Item(col - 1, fil - 1).Value
            Next
        Next
        For pi = 1 To 7
            If matriz(8 - pi, pi) > mayor Then
                mayor = matriz(8 - pi, pi)
            End If
        Next
        For beta = 1 To 4
            vector(beta) = matriz(beta, 3 + beta)
        Next
        For bi = 1 To 3
            vector(4 + bi) = matriz(4 + bi, bi)
        Next
        For col = 1 To 7
            Tabla2.Item(col - 1, 0).Value = vector(col)
        Next
        For fi = 1 To 3
            For colu = 1 To 4
                matrizNueva(fi, colu) = matriz(2 + fi, colu + fi)
                Tabla3.Item(colu - 1, fi - 1).Value = matrizNueva(fi, colu)
            Next
        Next
        TextBox1.Text = mayor
    End Sub
End Class
