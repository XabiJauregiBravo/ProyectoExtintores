Public Class FormAñadirProveedor
    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        ControladorDatos.InsertProveedor(TextboxIdProveedorAñadirProveedor.Text, TextboxNombreComercialAñadirProveedor.Text, TextboxTelefonoAñadirProveedor.Text, TextboxEmailAñadirProveedor.Text)
        Me.Close()
    End Sub
End Class