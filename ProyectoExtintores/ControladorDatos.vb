Imports System.Data.SQLite
Imports System.IO

Public Module ControladorDatos

    Public ConexionString As String = "Data Source=C:\database\ProyectoBBDDExtintores.db;Version=3"

    'CONEXION A LA BASE DE DATOS
    Public Function Conexion()
        Dim MiConexion As New SQLiteConnection(ConexionString)
        Return MiConexion
    End Function

    'DEVOLVER TABLA ENTERA
    Public Function VerTabla(tabla As String)
        Dim MiConexion = Conexion()
        Try
            MiConexion.Open()
        Catch ex As SQLiteException
            MsgBox("La base de datos no es valida o no existe", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Try
            Dim Comando As New SQLiteCommand()
            Comando.Connection = MiConexion
            Comando.CommandText = "SELECT * FROM " & tabla
            Dim datareader As SQLiteDataReader
            datareader = Comando.ExecuteReader()
            Dim datatable As New DataTable
            Try
                datatable.Load(datareader)
            Catch ex As System.FormatException
                MsgBox("Los valores son incorrectos", MsgBoxStyle.Exclamation)
                Return False
            End Try
            datareader.Close()
            MiConexion.Close()
            Return datatable
        Catch ex As SQLiteException
            MsgBox("El nombre de tabla incorrecto", MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function

    'ELIMINAR REGISTROS EN ALMACENES
    Public Sub DeleteAlmacen(IDALMACEN As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeleteAlmacenQuery As String = "DELETE FROM ALMACENES WHERE IDALMACEN = @IDALMACEN;"
                Dim Command As New SQLiteCommand(DeleteAlmacenQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN ALMACENES
    Public Sub InsertAlmacen(IDALMACEN As String, DIRECCION As String, CIUDAD As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim InsertAlmacenQuery As String = "INSERT INTO ALMACENES(IDALMACEN,DIRECCION,CIUDAD) VALUES (@IDALMACEN,@DIRECCION,@CIUDAD);"
                Dim Command As New SQLiteCommand(InsertAlmacenQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                Command.Parameters.AddWithValue("@CIUDAD", CIUDAD)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub UpdateAlmacen(IDALMACEN As String, DIRECCION As String, CIUDAD As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdateAlmacenQuery As String = "UPDATE ALMACENES SET DIRECCION = @DIRECCION, CIUDAD = @CIUDAD WHERE IDALMACEN = @IDALMACEN;"
                Dim Command As New SQLiteCommand(UpdateAlmacenQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                Command.Parameters.AddWithValue("@CIUDAD", CIUDAD)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN PROVEEDORES
    Public Sub InsertProveedor(IDPROVEEDOR As String, NOMBRECOMERCIAL As String, TELEFONO As Integer, EMAIL As String)
        Try
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
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'ELIMINAR REGISTROS EN PROVEEDORES
    Public Sub DeleteProveedor(IDPROVEEDOR As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeleteProveedorQuery As String = "DELETE FROM PROVEEDORES WHERE IDPROVEEDOR = @IDPROVEEDOR;"
                Dim Command As New SQLiteCommand(DeleteProveedorQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateProveedor(IDPROVEEDOR As String, NOMBRECOMERCIAL As String, TELEFONO As Integer, EMAIL As String)
        Try
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
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN TRABAJADORES
    Public Sub InsertTrabajador(IDTRABAJADOR As String, NOMBRECOMPLETO As String, DNI As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim InsertRevisorQuery As String = "INSERT INTO TRABAJADORES(IDTRABAJADOR,NOMBRECOMPLETO,DNI) VALUES (@IDTRABAJADOR,@NOMBRECOMPLETO,@DNI);"
                Dim Command As New SQLiteCommand(InsertRevisorQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
                Command.Parameters.AddWithValue("@DNI", DNI)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'ELIMINAR REGISTROS EN TRABAJADORES
    Public Sub DeleteTrabajador(IDTRABAJADOR As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeleteRevisorQuery As String = "DELETE FROM TRABAJADORES WHERE IDTRABAJADOR = @IDTRABAJADOR;"
                Dim Command As New SQLiteCommand(DeleteRevisorQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub UpdateTrabajador(IDTRABAJADOR As String, NOMBRECOMPLETO As String, DNI As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdateRevisorQuery As String = "UPDATE TRABAJADORES SET NOMBRECOMPLETO = @NOMBRECOMPLETO,DNI = @DNI WHERE IDTRABAJADOR = @IDTRABAJADOR;"
                Dim Command As New SQLiteCommand(UpdateRevisorQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
                Command.Parameters.AddWithValue("@DNI", DNI)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN PRODUCTOS
    Public Sub InsertProducto(IDPRODUCTO As String, DESCRIPCION As String, IDPROVEEDOR As String, IDALMACEN As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim InsertProductoQuery As String = "INSERT INTO PRODUCTOS(IDPRODUCTO,DESCRIPCION,IDPROVEEDOR,IDALMACEN) VALUES (@IDPRODUCTO,@DESCRIPCION,@IDPROVEEDOR,@IDALMACEN);"
                Dim Command As New SQLiteCommand(InsertProductoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
                Command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
                Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
                Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'ELIMINAR REGISTROS EN PRODUCTOS
    Public Sub DeleteProducto(IDPRODUCTO As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeleteProductoQuery As String = "DELETE FROM PRODUCTOS WHERE IDPRODUCTO = @IDPRODUCTO;"
                Dim Command As New SQLiteCommand(DeleteProductoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateProducto(IDPRODUCTO As String, DESCRIPCION As String, IDPROVEEDOR As String, IDALMACEN As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdateProductoQuery As String = "UPDATE PRODUCTOS SET DESCRIPCION = @DESCRIPCION, IDPROVEEDOR = @IDPROVEEDOR,IDALMACEN = @IDALMACEN WHERE IDPRODUCTO = @IDPRODUCTO;"
                Dim Command As New SQLiteCommand(UpdateProductoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
                Command.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
                Command.Parameters.AddWithValue("@IDPROVEEDOR", IDPROVEEDOR)
                Command.Parameters.AddWithValue("@IDALMACEN", IDALMACEN)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN CLIENTES

    Public Sub InsertCliente(IDCLIENTE As String, NOMBRECOMPLETO As String, DIRECCION As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim InsertClienteQuery As String = "INSERT INTO CLIENTES(IDCLIENTE,NOMBRECOMPLETO,DIRECCION) VALUES (@IDCLIENTE,@NOMBRECOMPLETO,@DIRECCION);"
                Dim Command As New SQLiteCommand(InsertClienteQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'ELIMINAR REGISTROS EN CLIENTES
    Public Sub DeleteCliente(IDCLIENTE As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeleteClienteQuery As String = "DELETE FROM CLIENTES WHERE IDCLIENTE = @IDCLIENTE;"
                Dim Command As New SQLiteCommand(DeleteClienteQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateCliente(IDCLIENTE As String, NOMBRECOMPLETO As String, DIRECCION As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdateClienteQuery As String = "UPDATE CLIENTES SET IDCLIENTE = @IDCLIENTE, NOMBRECOMPLETO = @NOMBRECOMPLETO,DIRECCION = @DIRECCION WHERE IDCLIENTE = @IDCLIENTE;"
                Dim Command As New SQLiteCommand(UpdateClienteQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                Command.Parameters.AddWithValue("@NOMBRECOMPLETO", NOMBRECOMPLETO)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub


    'ELIMINAR REGISTROS EN PEDIDOS Y TODAS SUS LINEAS DE PEDIDOS
    Public Sub DeletePedido(IDPEDIDO As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeletePedidoQuery As String = "DELETE FROM LINEASPEDIDOS WHERE IDPEDIDO = @IDPEDIDO;
                                                DELETE FROM PEDIDOS WHERE IDPEDIDO = @IDPEDIDO;"
                Dim Command As New SQLiteCommand(DeletePedidoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub UpdatePedido(IDPEDIDO As String, DIRECCION As String, IDTRABAJADOR As String, IDCLIENTE As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdatePedidoQuery As String = "UPDATE PEDIDOS SET IDPEDIDO = @IDPEDIDO, DIRECCION = @DIRECCION,IDTRABAJADOR = @IDTRABAJADOR WHERE IDPEDIDO = @IDPEDIDO; "
                Dim Command As New SQLiteCommand(UpdatePedidoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN PEDIDOS
    Public Sub InsertPedido(IDPEDIDO As String, DIRECCION As String, IDTRABAJADOR As String, IDCLIENTE As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim FECHAACTUAL As String = DateTime.Now.ToShortDateString()
                Dim InsertPedidoQuery As String = "INSERT INTO PEDIDOS(IDPEDIDO,FECHA,DIRECCION,IDTRABAJADOR,IDCLIENTE) VALUES(@IDPEDIDO,'" & FECHAACTUAL & "',@DIRECCION,@IDTRABAJADOR,@IDCLIENTE); "
                Dim Command As New SQLiteCommand(InsertPedidoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                Command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'ELIMINAR REGISTROS EN LINEASPEDIDOS
    Public Sub DeleteLinea(IDLINEAS As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim DeletePedidoQuery As String = "DELETE FROM LINEASPEDIDOS WHERE IDLINEAS = @IDLINEAS;"
                Dim Command As New SQLiteCommand(DeletePedidoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
                MiConexion.Open()
                Command.ExecuteNonQuery()

            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    ' EDITAR REGISTRO EN LINEASPEDIDOS
    Public Sub UpdateLinea(IDLINEAS As String, CANTIDAD As Integer, PRECIOUNIDAD As Integer, IDPEDIDO As String, IDPRODUCTO As String, SERVICIO As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim UpdatePedidoQuery As String = "UPDATE LINEASPEDIDOS SET IDLINEAS = @IDLINEAS, CANTIDAD = @CANTIDAD,PRECIOUNIDAD = @PRECIOUNIDAD,IDPEDIDO = @IDPEDIDO ,@IDPRODUCTO = IDPRODUCTO,SERVICIO = @SERVICIO  WHERE IDLINEAS = @IDLINEAS; "
                Dim Command As New SQLiteCommand(UpdatePedidoQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
                Command.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
                Command.Parameters.AddWithValue("@PRECIOUNIDAD", PRECIOUNIDAD)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
                Command.Parameters.AddWithValue("@SERVICIO", SERVICIO)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'INSERTAR REGISTRO EN LINEASPEDIDOS
    Public Sub InsertLinea(IDLINEAS As String, CANTIDAD As Integer, PRECIOUNIDAD As Integer, IDPEDIDO As String, IDPRODUCTO As String, SERVICIO As String)
        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim FECHAACTUAL As String = DateTime.Now.ToShortDateString()
                Dim InsertLineaQuery As String = "INSERT INTO LINEASPEDIDOS(IDLINEAS,CANTIDAD,PRECIOUNIDAD,IDPEDIDO,IDPRODUCTO,SERVICIO) VALUES(@IDLINEAS,@CANTIDAD,@PRECIOUNIDAD,@IDPEDIDO,@IDPRODUCTO,@SERVICIO); "
                Dim Command As New SQLiteCommand(InsertLineaQuery, MiConexion)
                Command.Parameters.AddWithValue("@IDLINEAS", IDLINEAS)
                Command.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
                Command.Parameters.AddWithValue("@PRECIOUNIDAD", PRECIOUNIDAD)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                Command.Parameters.AddWithValue("@IDPRODUCTO", IDPRODUCTO)
                Command.Parameters.AddWithValue("@SERVICIO", SERVICIO)
                MiConexion.Open()
                Command.ExecuteNonQuery()
            End Using
        Catch Ex As SQLiteException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'BUSCAR LINEAS POR IDPEDIDO
    Public Function BuscarLinea()
        Dim BUSCARLINEAS As String = "SELECT * FROM LINEASPEDIDOS WHERE IDPEDIDO LIKE '%" & FormLineas.TextBox1.Text & "%'; "
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim Command As New SQLiteCommand(BUSCARLINEAS, MiConexion)
            MiConexion.Open()
            Dim datareader As SQLiteDataReader
            datareader = Command.ExecuteReader()
            Dim datatable As New DataTable
            datatable.Load(datareader)
            datareader.Close()
            Return datatable
        End Using
    End Function

    Public Sub Facturar(IDPEDIDO As String)

        'ID DEL CLIENTE QUE REALIZO EL PEDIDO
        Dim QUERYIDCLIENTE As String = "SELECT IDCLIENTE FROM PEDIDOS WHERE IDPEDIDO = @IDPEDIDO ;"
        Dim IDCLIENTE As String = ""
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
            Dim Command As New SQLiteCommand(QUERYIDCLIENTE, MiConexion)
            Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
            MiConexion.Open()
            Dim Adapter As New SQLiteDataAdapter(Command)
            Dim Table As New DataTable()
            Adapter.Fill(Table)
            IDCLIENTE = Table.Rows(0)(0).ToString()
        End Using

        'ID DEL TRABAJADOR QUE REALIZO EL PEDIDO
        Dim QUERYIDTRABAJADOR As String = "SELECT IDTRABAJADOR FROM PEDIDOS WHERE IDPEDIDO  = @IDPEDIDO;"
            Dim IDTRABAJADOR As String
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYIDTRABAJADOR, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                IDTRABAJADOR = Table.Rows(0)(0).ToString()
            End Using

            'NOMBRE DEL CLIENTE QUE REALIZO EL PEDIDO
            Dim QUERYNombreCliente As String = "SELECT NOMBRECOMPLETO FROM CLIENTES WHERE IDCLIENTE = @IDCLIENTE;"
            Dim NombreCliente As String
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYNombreCliente, MiConexion)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                NombreCliente = Table.Rows(0)(0).ToString()
            End Using

            'DIRECCION DEL CLIENTE QUE REALIZO EL PEDIDO
            Dim QUERYDireccionCliente As String = "SELECT DIRECCION FROM CLIENTES WHERE IDCLIENTE = @IDCLIENTE"
            Dim DireccionCliente As String
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYDireccionCliente, MiConexion)
                Command.Parameters.AddWithValue("@IDCLIENTE", IDCLIENTE)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                DireccionCliente = Table.Rows(0)(0).ToString()
            End Using

            'NOMBRE DEL TRABAJADOR QUE REALIZO EL TRABAJO
            Dim QUERYNombreTrabajador As String = "SELECT NOMBRECOMPLETO FROM TRABAJADORES WHERE IDTRABAJADOR = @IDTRABAJADOR;"
            Dim NombreTrabajador As String
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYNombreTrabajador, MiConexion)
                Command.Parameters.AddWithValue("@IDTRABAJADOR", IDTRABAJADOR)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                NombreTrabajador = Table.Rows(0)(0).ToString()
            End Using

            'CANTIDAD TOTAL EN EUROS DEL PEDIDO INTRODUCIDO
            Dim QUERYTotalEUROS As String = "SELECT SUM(CANTIDAD*PRECIOUNIDAD) AS TOTAL FROM LINEASPEDIDOS WHERE IDPEDIDO = @IDPEDIDO;"
            Dim TotalEuros As String
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYTotalEUROS, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                TotalEuros = Table.Rows(0)(0).ToString()
            End Using

            'LEEMOS TODAS LAS LINEAS DE PEDIDO
            Dim LINEACOMPLETA As String = ""
        Dim QUERYLineas As String = "SELECT IDPRODUCTO,CANTIDAD,PRECIOUNIDAD,SERVICIO,(CANTIDAD*PRECIOUNIDAD) AS Total FROM LINEASPEDIDOS WHERE IDPEDIDO  = @IDPEDIDO ;"
        Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)
                Dim Command As New SQLiteCommand(QUERYLineas, MiConexion)
                Command.Parameters.AddWithValue("@IDPEDIDO", IDPEDIDO)
                MiConexion.Open()
                Dim Adapter As New SQLiteDataAdapter(Command)
                Dim Table As New DataTable()
                Adapter.Fill(Table)
                For Each row As DataRow In Table.Rows
                    For Each column As DataColumn In Table.Columns
                        LINEACOMPLETA = LINEACOMPLETA & "          " & row(column) & " "
                    Next
                    LINEACOMPLETA = LINEACOMPLETA & vbNewLine & vbNewLine
                Next

            End Using

        Try
            Using MiConexion As New SQLiteConnection(ControladorDatos.ConexionString)

                Dim Fecha As String = DateTime.Now.ToShortDateString()
                If Directory.Exists("C:\Facturas") Then

                    Using Factura As New StreamWriter("C:\Facturas\Facturas.txt", True)
                        Factura.Write("----------------------------------------------------------------------" & vbNewLine & vbNewLine &
                                 "                   Datos de la Factura               " & vbNewLine & vbNewLine &
                                 "Factura con IDPedido: " & IDPEDIDO & vbNewLine & vbNewLine &
                                 "Fecha de Facturación: " & Fecha & vbNewLine & vbNewLine &
                                 "                 Datos Del Cliente               " & vbNewLine & vbNewLine &
                                 "Nombre del Cliente: " & NombreCliente & vbNewLine & vbNewLine &
                                 "Direccion del Cliente: " & DireccionCliente & vbNewLine & vbNewLine &
                                 "                    Datos del Trabajador                    " & vbNewLine & vbNewLine &
                                 "Id del Trabajador: " & IDTRABAJADOR & vbNewLine & vbNewLine &
                                 "Atendido por: " & NombreTrabajador & vbNewLine & vbNewLine &
                                 "                          Datos del Pedido                    " & vbNewLine & vbNewLine &
                                 "         IDPRODUCTO        " & "CANTIDAD       " & "PRECIO     " & "SERVICIO    " & "SUBTOTAL" & vbNewLine &
                                 LINEACOMPLETA & vbNewLine & vbNewLine &
                                 "Total A Pagar: " & TotalEuros & " Euros" & vbNewLine & vbNewLine)

                        MsgBox("Factura Realizada Correctamente en: C:\Facturas\Facturas.txt")
                    End Using

                Else
                    My.Computer.FileSystem.CreateDirectory("C:\Facturas")
                    Using Factura As New StreamWriter("C:\Facturas\Facturas.txt", True)
                        Factura.Write("----------------------------------------------------------------------" & vbNewLine & vbNewLine &
                             "                   Datos de la Factura               " & vbNewLine & vbNewLine &
                             "Factura con IDPedido: " & IDPEDIDO & vbNewLine & vbNewLine &
                             "Fecha de Facturación: " & Fecha & vbNewLine & vbNewLine &
                             "                 Datos Del Cliente               " & vbNewLine & vbNewLine &
                             "Nombre del Cliente: " & NombreCliente & vbNewLine & vbNewLine &
                             "Direccion del Cliente: " & DireccionCliente & vbNewLine & vbNewLine &
                             "                    Datos del Trabajador                    " & vbNewLine & vbNewLine &
                             "Id del Trabajador: " & IDTRABAJADOR & vbNewLine & vbNewLine &
                             "Atendido por: " & NombreTrabajador & vbNewLine & vbNewLine &
                             "                          Datos del Pedido                    " & vbNewLine & vbNewLine &
                             "         IDPRODUCTO        " & "CANTIDAD       " & "PRECIO     " & "SERVICIO    " & "SUBTOTAL" & vbNewLine &
                             LINEACOMPLETA & vbNewLine & vbNewLine &
                             "Total A Pagar: " & TotalEuros & " Euros" & vbNewLine & vbNewLine)

                        MsgBox("Factura Realizada Correctamente en: C:\Facturas\Facturas.txt")
                    End Using
                End If
            End Using
        Catch ex As IOException
            MsgBox("ERROR", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Module
