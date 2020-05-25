Public Class FormAñadirAlmacen
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertAlmacen(TextboxIdAlmacenAnadirAlmacen.Text, TextboxDireccionAnadirAlmacen.Text, TextBoxCiudad.Text)
        Me.Close()
    End Sub

    Private Sub FormAñadirAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class