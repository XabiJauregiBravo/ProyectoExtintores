Public Class FormEditarLinea
    Private Sub BotonEditarAlmacen_Click(sender As Object, e As EventArgs) Handles botonEditarAlmacen.Click
        ControladorDatos.UpdateLinea(TextboxIdExtintor.Text, TextboxIdAlmacen.Text, TextboxIdProveedor.Text, TextBox2.Text, TextBox1.Text, TextBox3.Text)
        Me.Close()
    End Sub
End Class