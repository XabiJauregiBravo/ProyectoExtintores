Public Class FormEditarTrabajador
    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        ControladorDatos.UpdateTrabajador(TextboxIdRevisorEditarRevisor.Text, TextboxNombreCompletoEditarRevisor.Text, TextBoxDNIEditarRevisor.Text)
        Me.Close()
    End Sub

End Class