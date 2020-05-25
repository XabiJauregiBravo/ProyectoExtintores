Public Class FormClientes

    Public Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("CLIENTES")
        TablaClientes.DataSource = dt
        TablaClientes.Refresh()
    End Sub

    Private Sub FormRevisores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("CLIENTES")
        TablaClientes.DataSource = dt
        TablaClientes.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirClientes.Show()
        TablaClientes.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Cliente"
        Dim IDCLIENTEELIMINAR As String = InputBox("Introduce el IDCLIENTE del Cliente que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteCliente(IDCLIENTEELIMINAR)
        TablaClientes.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarCliente.Show()
        TablaClientes.Refresh()
    End Sub
End Class