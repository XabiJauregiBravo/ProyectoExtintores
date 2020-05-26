Imports System.Data.SQLite

Public Class FormPedidos
    Public Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = ControladorDatos.VerTabla("PEDIDOS")
        TablaPedidosxLineas.DataSource = dt
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub FormPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("PEDIDOS")
        TablaPedidosxLineas.DataSource = dt
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirPedidos.Show()
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Try
            Dim Title As String = "Eliminar Pedido"
            Dim IDPEDIDOELIMINAR As String = InputBox("Introduce el IDPEDIDO del Pedido que desees eliminar", Title)
            Dim MiConexion = ControladorDatos.Conexion()
            ControladorDatos.DeletePedido(IDPEDIDOELIMINAR)
            TablaPedidosxLineas.Refresh()
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarPedido.Show()
        TablaPedidosxLineas.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TablaPedidosxLineas.Refresh()
    End Sub
End Class