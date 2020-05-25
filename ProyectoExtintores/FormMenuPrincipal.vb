Public Class FormMenuPrincipal

    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormInicial.Show()
    End Sub

    Private Sub BotonAlmacenes_Click(sender As Object, e As EventArgs) Handles botonAlmacenes.Click
        FormAlmacenes.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub BotonProveedores_Click(sender As Object, e As EventArgs) Handles botonProveedores.Click
        FormProveedores.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub BotonRevisores_Click(sender As Object, e As EventArgs) Handles botonRevisores.Click
        FormRevisores.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub BotonInvExtintores_Click(sender As Object, e As EventArgs) Handles BotonInvExtintores.Click
        FormInventarioProductos.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Clientes_Click(sender As Object, e As EventArgs) Handles Clientes.Click
        FormClientes.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub BotonFacturas_Click(sender As Object, e As EventArgs) Handles botonFacturas.Click
        FormPedidos.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub
End Class