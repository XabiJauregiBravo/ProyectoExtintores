Public Class FormAñadirClientes
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertCliente(TextboxIdCliente.Text, TextboxNombreCompleto.Text, TextboxDireccion.Text)
        Me.Close()
    End Sub
End Class