Public Class FormAñadirPedidos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ControladorDatos.InsertPedido(TextBoxIDPEDIDO.Text, TextBoxDIRECCION.Text, TextBoxIDREVISOR.Text, TextBoxIDCLIENTE.Text, TextBoxCANTIDAD.Text, ComboBoxPRECIOUNIDAD.Text, TextBoxIDEXTINTOR.Text)
        Me.Close()
    End Sub
End Class