Public Class FormEditarProveedor
    Private Sub BotonEditarProveedor_Click(sender As Object, e As EventArgs) Handles botonEditarProveedor.Click
        ControladorDatos.UpdateProveedor(TextboxIdProveedorEditarProveedor.Text, TextboxNombreComercialEditarProveedor.Text, TextboxTelefonoEditarProveedor.Text, TextboxEmailEditarProveedor.Text)
        Me.Close()
    End Sub

End Class