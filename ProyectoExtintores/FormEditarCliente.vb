Public Class FormEditarCliente
    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles botonEditarCliente.Click
        ControladorDatos.UpdateCliente(TextboxIdCliente.Text, TextboxNombreCompleto.Text, TextBoxDireccion.Text)
        Me.Close()
    End Sub
End Class