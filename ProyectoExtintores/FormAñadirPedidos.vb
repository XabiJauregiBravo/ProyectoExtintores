Public Class FormAñadirPedidos
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        ControladorDatos.InsertPedido(TextBoxIDPEDIDO.Text, TextBoxDIRECCION.Text, TextBoxIDREVISOR.Text, TextBoxIDCLIENTE.Text)
        Me.Close()
    End Sub
End Class