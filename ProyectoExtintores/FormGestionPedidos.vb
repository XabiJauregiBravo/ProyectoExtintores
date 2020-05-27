Imports System.IO
Public Class FormGestionPedidos
    Private Sub BotonFacturas_Click(sender As Object, e As EventArgs) Handles botonFacturas.Click
        FormPedidos.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLineas.Show()
        FormInicial.Hide()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Title As String = "Facturacion Pedido"
        Dim IDPEDIDO As String = InputBox("Introduce el IDPEDIDO del Pedido que desees facturar", Title)
        ControladorDatos.Facturar(IDPEDIDO)
    End Sub

    Private Sub FormGestionPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        FormMenuPrincipal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("C:\Facturas\Facturas.txt")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("NO HA CREADO NINGUNA FACTURA AÚN", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class