﻿Public Class FormInventarioProductos
    Private Sub FormInventarioExtintores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = ControladorDatos.VerTabla("PRODUCTOS")
        TablaExtintores.DataSource = dt
    End Sub

    Private Sub FormProveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenuPrincipal.Show()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles botonAñadir.Click
        FormAñadirProducto.Show()
        TablaExtintores.Refresh()
    End Sub
    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim Title As String = "Eliminar Producto"
        Dim IDPRODUCTOELIMINAR As String = InputBox("Introduce el IDPRODUCTO del Producto que desees eliminar", Title)
        Dim MiConexion = ControladorDatos.Conexion()
        ControladorDatos.DeleteProducto(IDPRODUCTOELIMINAR)
        TablaExtintores.Refresh()
    End Sub
    Private Sub BotonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        FormEditarProducto.Show()
        TablaExtintores.Refresh()
    End Sub

    Private Sub BotonVerDatos_Click(sender As Object, e As EventArgs) Handles botonVerDatos.Click
        Dim dt = ControladorDatos.VerTabla("PRODUCTOS")
        TablaExtintores.DataSource = dt
        TablaExtintores.Refresh()
    End Sub

End Class