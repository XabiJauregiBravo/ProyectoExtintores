Public Class FormAñadirLineaPedido
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertLinea(TextboxIdExtintor.Text, TextboxIdAlmacen.Text, TextboxIdProveedor.Text, TextBox2.Text, TextBox1.Text, TextBox3.Text)
        Me.Close()
    End Sub

End Class