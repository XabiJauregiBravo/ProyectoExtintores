Imports System.Data.SQLite

Public Class FormProveedores
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("PROVEEDORES")
        TablaProveedores.DataSource = dt
    End Sub

    Private Sub FormProveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirProveedor.Show()
        TablaProveedores.Refresh()
    End Sub
    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Try
            Dim Title As String = "Eliminar Proveedor"
            Dim IDPROVEEDORELIMINAR As String = InputBox("Introduce el IDPROVEEDOR del Proveedor que desees eliminar", Title)
            Dim MiConexion = ControladorDatos.Conexion()
            ControladorDatos.DeleteProveedor(IDPROVEEDORELIMINAR)
            TablaProveedores.Refresh()
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarProveedor.Show()
        TablaProveedores.Refresh()
    End Sub

    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click
        Dim dt = ControladorDatos.VerTabla("PROVEEDORES")
        TablaProveedores.DataSource = dt
        TablaProveedores.Refresh()
    End Sub
End Class