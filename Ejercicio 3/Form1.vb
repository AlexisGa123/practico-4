Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla1.ColumnCount = 5
        Tabla1.Rows.Add(5)
        Tabla2.ColumnCount = 5
        Tabla2.Rows.Add(1)
        Tabla3.ColumnCount = 5
        Tabla3.Rows.Add(1)
        For i = 0 To 4
            Tabla1.Columns(i).Width = 40
            Tabla2.Columns(i).Width = 40
            Tabla3.Columns(i).Width = 40
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim colu As Integer = 0
        Dim contra As Integer = 4

        For fila = 1 To 5
            Tabla2.Item(colu, 0).Value = Tabla1.Item(colu, fila - 1).Value
            Tabla3.Item(colu, 0).Value = Tabla1.Item(fila - 1, contra).Value
            colu += 1
            contra -= 1
        Next
    End Sub
End Class
