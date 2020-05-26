Public Class FormAñadirTrabajador
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertTrabajador(TextboxIdRevisorAnadirRevisor.Text, TextboxNombreAñadirRevisor.Text, TextboxDNIAñadirRevisor.Text)
        Me.Close()
    End Sub
End Class