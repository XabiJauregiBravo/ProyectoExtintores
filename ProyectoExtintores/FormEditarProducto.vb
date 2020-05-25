Public Class FormEditarProducto
    Private Sub botonEditarCliente_Click(sender As Object, e As EventArgs) Handles botonEditarCliente.Click
        ControladorDatos.UpdateProducto(TextboxIdProducto.Text, TextboxDescripcion.Text, TextBoxProveedor.Text)
        Me.Close()
    End Sub
End Class