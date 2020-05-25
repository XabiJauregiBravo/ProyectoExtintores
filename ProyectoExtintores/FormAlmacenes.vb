Imports System.Data.SQLite

Public Class FormAlmacenes

    Public Sub FormAlmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("ALMACENES")
        TablaAlmacenes.DataSource = dt
        TablaAlmacenes.Refresh()
    End Sub

    Private Sub FormAlmacenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("ALMACENES")
        TablaAlmacenes.DataSource = dt
        TablaAlmacenes.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirAlmacen.Show()
        TablaAlmacenes.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Almacén"
        Dim IDALMACENELIMINAR As String = InputBox("Introduce el IDALMACEN del Almacén que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteAlmacen(IDALMACENELIMINAR)
        TablaAlmacenes.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarAlmacen.Show()
        TablaAlmacenes.Refresh()
    End Sub

End Class