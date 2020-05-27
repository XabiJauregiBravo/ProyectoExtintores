Public Class FormEditarProducto
    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles botonEditarCliente.Click
        ControladorDatos.UpdateProducto(TextboxIdProducto.Text, TextboxDescripcion.Text, TextBoxProveedor.Text, TextBox1.Text)
        Me.Close()
    End Sub
End Class