Public Class FormEditarAlmacen
    Private Sub BotonEditarAlmacen_Click(sender As Object, e As EventArgs) Handles botonEditarAlmacen.Click
        ControladorDatos.UpdateAlmacen(TextboxIdAlmacenEditarAlmacen.Text, TextboxDireccionEditarAlmacen.Text, TextBoxCiudad.Text)
        Me.Close()
    End Sub
End Class