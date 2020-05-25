Public Class FormPedidos
    Public Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = ControladorDatos.PedidosLineas()
        TablaPedidosxLineas.DataSource = dt
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub FormPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.PedidosLineas()
        TablaPedidosxLineas.DataSource = dt
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirPedidos.Show()
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Pedido"
        Dim IDPEDIDOELIMINAR As String = InputBox("Introduce el IDPEDIDO del Pedido que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeletePedido(IDPEDIDOELIMINAR)
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarPedido.Show()
        TablaPedidosxLineas.Refresh()
    End Sub

End Class