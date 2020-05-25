Public Class FormGestionPedidos
    Private Sub botonFacturas_Click(sender As Object, e As EventArgs) Handles botonFacturas.Click
        FormPedidos.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLineas.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub
End Class