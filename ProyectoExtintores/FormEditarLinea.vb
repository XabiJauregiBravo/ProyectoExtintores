Public Class FormEditarLinea
    Private Sub botonEditarAlmacen_Click(sender As Object, e As EventArgs) Handles botonEditarAlmacen.Click
        ControladorDatos.UpdateLinea(TextboxIdExtintor.Text, TextboxIdAlmacen.Text, TextboxIdProveedor.Text, TextBox2.Text, TextBox1.Text)
        Me.Close()
    End Sub
End Class