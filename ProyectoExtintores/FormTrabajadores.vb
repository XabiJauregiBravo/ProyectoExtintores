

Public Class FormTrabajadores

    Public Sub FormRevisores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("TRABAJADORES")
        TablaTrabajadores.DataSource = dt
        TablaTrabajadores.Refresh()
    End Sub

    Private Sub FormRevisores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("TRABAJADORES")
        TablaTrabajadores.DataSource = dt
        TablaTrabajadores.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirTrabajador.Show()
        TablaTrabajadores.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Trabajador"
        Dim IDTRABAJADORELIMINAR As String = InputBox("Introduce el IDTRABAJADOR del Trabajador que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteTrabajador(IDTRABAJADORELIMINAR)
        TablaTrabajadores.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarTrabajador.Show()
        TablaTrabajadores.Refresh()
    End Sub
End Class