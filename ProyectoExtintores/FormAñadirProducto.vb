Public Class FormAñadirProducto
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertProducto(TextboxIdExtintor.Text, TextboxIdAlmacen.Text, TextboxIdProveedor.Text, TextBox1.Text)
        Me.Close()
    End Sub

End Class