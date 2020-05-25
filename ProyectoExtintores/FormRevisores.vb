

Public Class FormRevisores

    Public Sub FormRevisores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("REVISORES")
        TablaRevisores.DataSource = dt
        TablaRevisores.Refresh()
    End Sub

    Private Sub FormRevisores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub
    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click

        Dim dt = ControladorDatos.VerTabla("REVISORES")
        TablaRevisores.DataSource = dt
        TablaRevisores.Refresh()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirRevisor.Show()
        TablaRevisores.Refresh()
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Revisor"
        Dim IDREVISORELIMINAR As String = InputBox("Introduce el IDREVISOR del Revisor que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteRevisor(IDREVISORELIMINAR)
        TablaRevisores.Refresh()
    End Sub

    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarRevisor.Show()
        TablaRevisores.Refresh()
    End Sub

End Class