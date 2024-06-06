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

    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmd.Click
        Dim vector(10) As Integer
        Dim mayor As Integer = 0
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
            Tabla3.Item(fila - 1, 0).Value = vector(fila)
        Next
        Tabla3.Item(9, 0).Value = vector(1)
        Tabla3.Item(0, 0).Value = vector(10)
    End Sub
End Class
