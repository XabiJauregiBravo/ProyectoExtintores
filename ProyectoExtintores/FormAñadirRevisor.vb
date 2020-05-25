Public Class FormAñadirRevisor
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertRevisor(TextboxIdRevisorAnadirRevisor.Text, TextboxNombreAñadirRevisor.Text, TextboxDNIAñadirRevisor.Text)
        Me.Close()
    End Sub
End Class