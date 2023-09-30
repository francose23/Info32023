Public Class MetodoBurbuja
    Dim A(8) As Integer
    Public Function MetodoBurbuja(ByVal A() As Integer, ByVal N As Integer)
        Dim j, i, Temp As Integer

        For i = 2 To N
            For j = 1 To N - 1
                If A(j) > A(j + 1) Then
                    Temp = A(j)
                    A(j) = A(j + 1)
                    A(j + 1) = Temp
                End If
            Next

        Next
    End Function


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVectorDesordenado.CellContentClick

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k As Integer

        'Dibujado de la grilla para vector ordenado y vector desordenado. Ambas grillas de 8 columnas y 1 fila.
        For c = 1 To 8
            dgVectorDesordenado.Columns.Add("", "")
            dgVectorDesordenado.Columns(c - 1).Width = 40
        Next
        dgVectorDesordenado.Rows.Add(1)

        For c = 1 To 8
            dgVectorOrdenado.Columns.Add("", "")
            dgVectorOrdenado.Columns(c - 1).Width = 40
        Next
        dgVectorOrdenado.Rows.Add(1)

        'Carga del Vector A y lo muestra en la grilla de vector desordenado.
        A(1) = 13
        A(2) = 57
        A(3) = 11
        A(4) = 68
        A(5) = 24
        A(6) = 46
        A(7) = 34
        A(8) = 35

        For k = 1 To 8
            dgVectorDesordenado.Item(k - 1, 0).Value = A(k)
        Next


    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        'Ejecucion del MetodoBurbuja (ordena el vector) y lo muestra en la grilla de vector ordenado. El vector esta cargado de 1 a 8 y la grilla va de 0 a 7.
        Dim k As Integer

        MetodoBurbuja(A, 8)

        For k = 1 To 8
            dgVectorOrdenado.Item(k - 1, 0).Value = A(k)
        Next

    End Sub
End Class
