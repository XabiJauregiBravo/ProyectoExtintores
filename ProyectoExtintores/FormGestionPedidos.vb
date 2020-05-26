Public Class FormGestionPedidos
    Private Sub BotonFacturas_Click(sender As Object, e As EventArgs) Handles botonFacturas.Click
        FormPedidos.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLineas.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Title As String = "Facturacion Pedido"
        Dim IDPEDIDO As String = InputBox("Introduce el IDPEDIDO del Pedido que desees facturar", Title)
        ControladorDatos.Facturar(IDPEDIDO)
    End Sub

    Private Sub FormGestionPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        FormMenuPrincipal.Show()
    End Sub
End Class