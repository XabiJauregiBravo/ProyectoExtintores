Public Class FormLineas
    Public Sub FormLineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = ControladorDatos.VerTabla("LINEASPEDIDOS")
        TablaLineas.DataSource = dt
    End Sub

    Private Sub FormLineas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("LINEASPEDIDOS")
        TablaLineas.DataSource = dt
        TablaLineas.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirLineaPedido.Show()
        TablaLineas.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Linea Pedido"
        Dim IDLINEAELIMINAR As String = InputBox("Introduce el IDLinea de la Linea de Pedidos que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteLinea(IDLINEAELIMINAR)
        TablaLineas.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarLinea.Show()
        TablaLineas.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TablaLineas.Refresh()
    End Sub
End Class