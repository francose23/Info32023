Public Class ArchivoSecuencial
    Dim strNombre, strApellido, strDNI, rutaArchivo As String
    Dim Fila, nroFila, nroArchivo As Integer


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSalida.CellContentClick

    End Sub

    Private Sub ArchivoSecuencial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rutaArchivo = "D:\datos.txt"     'Ruta del archivo .txt
        Fila = 0
        nroArchivo = 1


        'Dibujo de la grilla y titulo de las columnas (campos)
        For c = 1 To 3
            dgSalida.Columns.Add("", "")
            dgSalida.Columns(c - 1).Width = 250
        Next
        dgSalida.Columns(0).HeaderText = "Nombre"
        dgSalida.Columns(1).HeaderText = "Apellido"
        dgSalida.Columns(2).HeaderText = "DNI"


        lblEstado.Text = "Archivo " & nroArchivo
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        FileOpen(nroArchivo, rutaArchivo, OpenMode.Output)    'abre un archivo 1 nuevo o borra y abre el archivo 1
        FileClose()  'cierra todos los archivos de la aplicación

        Fila = 0        'Reinicia el número de lineas (registros) del archivo.
        dgSalida.Rows.Clear()    'Limpia el DataGrid, usado para representar que se trata de un archivo nuevo.

        lblEstado.Text = "Se creó el Archivo " & nroArchivo
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'Se leen los datos de las cajas de texto.
        strNombre = txtNombre.Text
        strApellido = txtApellido.Text
        strDNI = txtDNI.Text

        'Se agrega una linea al DataGrid para poder mostrar los datos ingresados.
        dgSalida.Rows.Add(1)

        'Se muestran los datos ingresados en el DataGrid.
        dgSalida.Item(0, Fila).Value = strNombre
        dgSalida.Item(1, Fila).Value = strApellido
        dgSalida.Item(2, Fila).Value = strDNI

        FileOpen(nroArchivo, rutaArchivo, OpenMode.Append) 'Se abre el archivo para agregar lineas.
        WriteLine(nroArchivo, strNombre, strApellido, strDNI) 'Se agregan los datos al archivo.
        FileClose(nroArchivo)      'Se cierra el archivo.

        Fila = Fila + 1    'Fila lleva la cuenta de la cantidad de lineas del archivo para escribir inmediatamente debajo de la última agregada.

        lblEstado.Text = "Registro añadido al Archivo " & nroArchivo

    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Nombre, Apellido, Dni As String
        nroFila = 0     'nroFila se usa para contar las filas del archivo cuando se lee. Cada vez que se lee arranca desde cero. 

        dgSalida.Rows.Clear()    'Borra las filas del DataGrid antes de mostrar la lectura.

        FileOpen(nroArchivo, rutaArchivo, OpenMode.Input) 'Abro el archivo en modo lectura

        While EOF(nroArchivo) = False          'EOF (End Of File). Mientras no se alcance al fin del archivo imprime linea a linea.
            dgSalida.Rows.Add(1)
            Input(nroArchivo, Nombre)
            Input(nroArchivo, Apellido)
            Input(nroArchivo, Dni)

            dgSalida.Item(0, nroFila).Value = Nombre
            dgSalida.Item(1, nroFila).Value = Apellido
            dgSalida.Item(2, nroFila).Value = Dni

            nroFila = nroFila + 1
            Fila = nroFila           'en Fila se guarda la cantidad de filas totales hasta al momento. Cuando se agregan lineas continúa desde la linea Fila.
        End While

        FileClose(nroArchivo)
        lblEstado.Text = "Estado actual del Archivo " & nroArchivo
    End Sub

    Private Sub Close(ByVal p1 As Integer)
        Throw New NotImplementedException
    End Sub

End Class
