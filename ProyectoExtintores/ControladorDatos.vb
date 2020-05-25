Imports System.Data.SQLite
Public Module ControladorDatos

    Public ConexionString As String = "Data Source=C:\database\ProyectoBBDDExtintores.db;Version=3"

    'Esta función es la conexión con la base de datos
    Public Function Conexion()
        Dim MiConexion As New SQLiteConnection(ConexionString)
        Return MiConexion
    End Function

    'Devolver una tabla entera, pasar como parametro el nombre de la tabla que quieras ver
    Public Function VerTabla(tabla As String)
        Dim MiConexion = Conexion()
        Try
            MiConexion.Open()
        Catch ex As SQLiteException
            MsgBox("La base de datos no es valida o no existe", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Dim Comando As New SQLiteCommand
        Comando.Connection = MiConexion
        Comando.CommandText = "SELECT * FROM " & tabla
        Dim datareader As SQLiteDataReader
        Try
            datareader = Comando.ExecuteReader()
            Dim datatable As New DataTable
            Try
                datatable.Load(datareader)
            Catch ex As System.FormatException
                MsgBox("Los valores incorrectos", MsgBoxStyle.Exclamation)
            End Try
            datareader.Close()
            MiConexion.Close()
            Return datatable
        Catch ex As SQLiteException
            MsgBox("El nombre de tabla incorrecto", MsgBoxStyle.Exclamation)
        End Try
    End Function
    Public Sub DeleteAlmacen(IDALMACEN As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeleteAlmacenQuery As String = "DELETE FROM ALMACENES WHERE IDALMACEN = @IDALMACEN;"
            Dim Command As New SQLiteCommand(DeleteAlmacenQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub
    Public Sub InsertAlmacen(IDALMACEN As String, DIRECCION As String, CIUDAD As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim InsertAlmacenQuery As String = "INSERT INTO ALMACENES(IDALMACEN,DIRECCION,CIUDAD) VALUES (@IDALMACEN,@DIRECCION,@CIUDAD);"
            Dim Command As New SQLiteCommand(InsertAlmacenQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            Command.Parameters.AddWithValue("@CIUDAD", CIUDAD)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub

    Public Sub UpdateAlmacen(IDALMACEN As String, DIRECCION As String, CIUDAD As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdateAlmacenQuery As String = "UPDATE ALMACENES SET DIRECCION = @DIRECCION, CIUDAD = @CIUDAD WHERE IDALMACEN = @IDALMACEN;"
            Dim Command As New SQLiteCommand(UpdateAlmacenQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            Command.Parameters.AddWithValue("@CIUDAD", CIUDAD)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub

    Public Sub InsertProveedor(IDPROVEEDOR As String, NOMBRECOMERCIAL As String, TELEFONO As Integer, EMAIL As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim InsertProveedorQuery As String = "INSERT INTO PROVEEDORES(IDPROVEEDOR,NOMBRECOMERCIAL,TELEFONO,EMAIL) VALUES (@IDPROVEEDOR,@NOMBRECOMERCIAL,@TELEFONO,@EMAIL);"
            Dim Command As New SQLiteCommand(InsertProveedorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
            Command.Parameters.AddWithValue("@NOMBRECOMERCIAL", NOMBRECOMERCIAL)
            Command.Parameters.AddWithValue("@TELEFONO", TELEFONO)
            Command.Parameters.AddWithValue("@EMAIL", EMAIL)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub

    Public Sub DeleteProveedor(IDPROVEEDOR As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeleteProveedorQuery As String = "DELETE FROM PROVEEDORES WHERE IDPROVEEDOR = @IDPROVEEDOR;"
            Dim Command As New SQLiteCommand(DeleteProveedorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub UpdateProveedor(IDPROVEEDOR As String, NOMBRECOMERCIAL As String, TELEFONO As Integer, EMAIL As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdateProveedorQuery As String = "UPDATE PROVEEDORES SET NOMBRECOMERCIAL = @NOMBRECOMERCIAL,TELEFONO = @TELEFONO,EMAIL = @EMAIL WHERE IDPROVEEDOR = @IDPROVEEDOR;"
            Dim Command As New SQLiteCommand(UpdateProveedorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
            Command.Parameters.AddWithValue("@NOMBRECOMERCIAL", NOMBRECOMERCIAL)
            Command.Parameters.AddWithValue("@TELEFONO", TELEFONO)
            Command.Parameters.AddWithValue("@EMAIL", EMAIL)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub InsertRevisor(IDREVISOR As String, NOMBRECOMPLETO As String, DNI As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim InsertRevisorQuery As String = "INSERT INTO REVISORES(IDREVISOR,NOMBRECOMPLETO,DNI) VALUES (@IDREVISOR,@NOMBRECOMPLETO,@DNI);"
            Dim Command As New SQLiteCommand(InsertRevisorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDREVISOR", IDREVISOR)
            Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
            Command.Parameters.AddWithValue("@DNI", DNI)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub
    Public Sub DeleteRevisor(IDREVISOR As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeleteRevisorQuery As String = "DELETE FROM REVISORES WHERE IDREVISOR = @IDREVISOR;"
            Dim Command As New SQLiteCommand(DeleteRevisorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDREVISOR", IDREVISOR)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub
    Public Sub UpdateRevisor(IDREVISOR As String, NOMBRECOMPLETO As String, DNI As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdateRevisorQuery As String = "UPDATE REVISORES SET NOMBRECOMPLETO = @NOMBRECOMPLETO,DNI = @DNI WHERE IDREVISOR = @IDREVISOR;"
            Dim Command As New SQLiteCommand(UpdateRevisorQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDREVISOR", IDREVISOR)
            Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
            Command.Parameters.AddWithValue("@DNI", DNI)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub InsertProducto(IDPRODUCTO As String, DESCRIPCION As String, IDPROVEEDOR As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim InsertProductoQuery As String = "INSERT INTO PRODUCTOS(IDPRODUCTO,DESCRIPCION,IDPROVEEDOR) VALUES (@IDPRODUCTO,@DESCRIPCION,@IDPROVEEDOR);"
            Dim Command As New SQLiteCommand(InsertProductoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
            Command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
            Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)

            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub

    Public Sub DeleteProducto(IDPRODUCTO As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeleteProductoQuery As String = "DELETE FROM PRODUCTOS WHERE IDPRODUCTO = @IDPRODUCTO;"
            Dim Command As New SQLiteCommand(DeleteProductoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub UpdateProducto(IDPRODUCTO As String, DESCRIPCION As String, IDPROVEEDOR As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdateProductoQuery As String = "UPDATE PRODUCTOS SET DESCRIPCION = @DESCRIPCION, IDPROVEEDOR = @IDPROVEEDOR WHERE IDPRODUCTO = @IDPRODUCTO;"
            Dim Command As New SQLiteCommand(UpdateProductoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
            Command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
            Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub
    Public Sub InsertCliente(IDCLIENTE As String, NOMBRECOMPLETO As String, DIRECCION As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim InsertClienteQuery As String = "INSERT INTO CLIENTES(IDCLIENTE,NOMBRECOMPLETO,DIRECCION) VALUES (@IDCLIENTE,@NOMBRECOMPLETO,@DIRECCION);"
            Dim Command As New SQLiteCommand(InsertClienteQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
            Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub DeleteCliente(IDCLIENTE As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeleteClienteQuery As String = "DELETE FROM CLIENTES WHERE IDCLIENTE = @IDCLIENTE;"
            Dim Command As New SQLiteCommand(DeleteClienteQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub UpdateCliente(IDCLIENTE As String, NOMBRECOMPLETO As String, DIRECCION As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdateClienteQuery As String = "UPDATE CLIENTES SET IDCLIENTE = @IDCLIENTE, NOMBRECOMPLETO = @NOMBRECOMPLETO,DIRECCION = @DIRECCION WHERE IDCLIENTE = @IDCLIENTE;"
            Dim Command As New SQLiteCommand(UpdateClienteQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
            Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub

    Public Function PedidosLineas()
        Dim MiConexion = Conexion()
        Try
            MiConexion.Open()
        Catch ex As System.ArgumentException
            MsgBox("La direccion de la base de datos no es válida", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Dim Comando As New SQLiteCommand
        Comando.Connection = MiConexion
        Comando.CommandText = "SELECT PEDIDOS.IDPEDIDO, PEDIDOS.FECHA, PEDIDOS.DIRECCION,
                                PEDIDOS.IDREVISOR, PEDIDOS.IDCLIENTE,LINEASPEDIDOS.PRECIOUNIDAD*LINEASPEDIDOS.CANTIDAD AS TOTAL FROM PEDIDOS 
                                INNER JOIN  LINEASPEDIDOS ON  LINEASPEDIDOS.IDPEDIDO = PEDIDOS.IDPEDIDO;"
        Dim datareader As SQLiteDataReader
        Try
            datareader = Comando.ExecuteReader()
            Dim datatable As New DataTable
            Try
                datatable.Load(datareader)
            Catch ex As System.FormatException
                MsgBox("Los valores incorrectos", MsgBoxStyle.Exclamation)
            End Try
            datareader.Close()
            MiConexion.Close()
            Return datatable
        Catch ex As SQLiteException
            MsgBox("Ha ocurrido un error", MsgBoxStyle.Exclamation)
            Return Nothing
            datareader.Close()
        End Try
    End Function

    Public Function VerTablaPedidos()
        Dim MiConexion = Conexion()
        Try
            MiConexion.Open()
        Catch ex As SQLiteException
            MsgBox("La base de datos no es valida o no existe", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Dim Comando As New SQLiteCommand
        Comando.Connection = MiConexion
        Comando.CommandText = "SELECT * FROM PEDIDOS"
        Dim datareader As SQLiteDataReader
        Try
            datareader = Comando.ExecuteReader()
            Dim datatable As New DataTable
            Try
                datatable.Load(datareader)
            Catch ex As System.FormatException
                MsgBox("Los valores incorrectos", MsgBoxStyle.Exclamation)
            End Try
            datareader.Close()
            MiConexion.Close()
            Return datatable
        Catch ex As SQLiteException
            MsgBox("El nombre de tabla incorrecto", MsgBoxStyle.Exclamation)
        End Try
    End Function

    Public Sub DeletePedido(IDPEDIDO As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeletePedidoQuery As String = "DELETE FROM LINEASPEDIDOS WHERE IDPEDIDO = @IDPEDIDO;
                                                DELETE FROM PEDIDOS WHERE IDPEDIDO = @IDPEDIDO;"
            Dim Command As New SQLiteCommand(DeletePedidoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub
    Public Sub UpdatePedido(IDPEDIDO As String, DIRECCION As String, IDREVISOR As String, IDCLIENTE As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdatePedidoQuery As String = "UPDATE PEDIDOS SET IDPEDIDO = @IDPEDIDO, DIRECCION = @DIRECCION,IDREVISOR = @IDREVISOR WHERE IDPEDIDO = @IDPEDIDO; "
            Dim Command As New SQLiteCommand(UpdatePedidoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            Command.Parameters.AddWithValue("@IDREVISOR", IDREVISOR)
            Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub InsertPedido(IDPEDIDO As String, DIRECCION As String, IDREVISOR As String, IDCLIENTE As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim FECHAACTUAL As String = DateTime.Now.ToShortDateString()
            Dim InsertPedidoQuery As String = "INSERT INTO PEDIDOS(IDPEDIDO,FECHA,DIRECCION,IDREVISOR,IDCLIENTE) VALUES(@IDPEDIDO,'" & FECHAACTUAL & "',@DIRECCION,@IDREVISOR,@IDCLIENTE); "
            Dim Command As New SQLiteCommand(InsertPedidoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
            Command.Parameters.AddWithValue("@IDREVISOR", IDREVISOR)
            Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub DeleteLinea(IDLINEAS As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim DeletePedidoQuery As String = "DELETE FROM LINEASPEDIDOS WHERE IDLINEAS = @IDLINEAS;"
            Dim Command As New SQLiteCommand(DeletePedidoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
            MiConexion.Open()
            Command.ExecuteNonQuery()


        End Using
    End Sub
    Public Sub UpdateLinea(IDLINEAS As String, CANTIDAD As Integer, PRECIOUNIDAD As Integer, IDPEDIDO As String, IDPRODUCTO As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim UpdatePedidoQuery As String = "UPDATE LINEASPEDIDOS SET IDLINEAS = @IDLINEAS, CANTIDAD = @CANTIDAD,PRECIOUNIDAD = @PRECIOUNIDAD,IDPEDIDO = @IDPEDIDO ,@IDPRODUCTO = IDPRODUCTO WHERE IDLINEAS = @IDLINEAS; "
            Dim Command As New SQLiteCommand(UpdatePedidoQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
            Command.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
            Command.Parameters.AddWithValue("@PRECIOUNIDAD", PRECIOUNIDAD)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub InsertLinea(IDLINEAS As String, CANTIDAD As Integer, PRECIOUNIDAD As Integer, IDPEDIDO As String, IDPRODUCTO As String)
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim FECHAACTUAL As String = DateTime.Now.ToShortDateString()
            Dim InsertLineaQuery As String = "INSERT INTO LINEASPEDIDOS(IDLINEAS,CANTIDAD,PRECIOUNIDAD,IDPEDIDO,IDPRODUCTO) VALUES(@IDLINEAS,@CANTIDAD,@PRECIOUNIDAD,@IDPEDIDO,@IDPRODUCTO); "
            Dim Command As New SQLiteCommand(InsertLineaQuery, MiConexion)
            Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
            Command.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
            Command.Parameters.AddWithValue("@PRECIOUNIDAD", PRECIOUNIDAD)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
            MiConexion.Open()
            Command.ExecuteNonQuery()

        End Using
    End Sub
End Module
