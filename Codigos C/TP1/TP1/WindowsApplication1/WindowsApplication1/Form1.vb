Public Class MetodoSeleccion
    Dim A(8) As Integer

    Public Function MetodoSeleccion(ByVal A() As Integer, ByVal N As Integer)
        Dim j, i, temp, ind As Integer

        For i = 1 To N - 1
            ind = i
            For j = i + 1 To N
                If A(ind) > A(j) Then
                    ind = j
                End If
            Next
            temp = A(i)
            A(i) = A(ind)
            A(ind) = temp
        Next
    End Function

    Private Sub MetodoSeleccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k As Integer

        'Dibujado de la grilla para vector ordenado y vector desordenado. Ambas grillas de 8 columnas y 1 fila.
        For c = 1 To 8
            dgVector.Columns.Add("", "")
            dgVector.Columns(c - 1).Width = 40
        Next
        dgVector.Rows.Add(1)

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
            dgVector.Item(k - 1, 0).Value = A(k)
        Next
    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        Dim k As Integer

        MetodoSeleccion(A, 8)
        For k = 1 To 8
            dgVectorOrdenado.Item(k - 1, 0).Value = A(k)
        Next

    End Sub
End Class
