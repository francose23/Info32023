Public Class Form1
    Dim strNombre, strLa, strDNI, strNombre2, strLa2, strDNI2 As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        FileOpen(1, "C:\datos.txt", OpenMode.Output)
        WriteLine(1, "Franco", "Catena", "37.380.812")
        FileClose()

        FileOpen(1, "C:\datos.txt", OpenMode.Input)
        Input(1, strNombre)
        Input(1, strLa)
        Input(1, strDNI)

        txtEntrada.Text = strNombre
        txtSalida.Text = strLa
        txtDNI.Text = strDNI
        FileClose()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged

    End Sub

    Private Sub btnB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB2.Click
        FileOpen(1, "C:\datos.txt", OpenMode.Append)
        WriteLine(1, "Luis", "Cranterrier", "49.380.813")
        FileClose()

        FileOpen(1, "C:\datos.txt", OpenMode.Input)
        Input(1, strNombre)
        Input(1, strLa)
        Input(1, strDNI)
        Input(1, strNombre2)
        Input(1, strLa2)
        Input(1, strDNI2)

        TextBox3.Text = strNombre2
        TextBox2.Text = strLa2
        TextBox1.Text = strDNI2
        FileClose()
    End Sub
End Class
