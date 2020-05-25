Public Class FormEditarPedido
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ControladorDatos.UpdatePedido(TextBoxIDPEDIDO.Text, TextBoxDIRECCION.Text, TextBoxIDREVISOR.Text, TextBoxIDCLIENTE.Text)
        Me.Close()
    End Sub

End Class