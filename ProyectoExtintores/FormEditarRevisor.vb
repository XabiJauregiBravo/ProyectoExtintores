Public Class FormEditarRevisor
    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        ControladorDatos.UpdateRevisor(TextboxIdRevisorEditarRevisor.Text, TextboxNombreCompletoEditarRevisor.Text, TextBoxDNIEditarRevisor.Text)
        Me.Close()
    End Sub

End Class