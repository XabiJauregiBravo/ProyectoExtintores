Imports System.Data.SQLite
Imports System.IO
Module CrearBD

    Public StringBaseDatos As String = "

CREATE TABLE ALMACENES (
            IDALMACEN varchar(10) NOT NULL PRIMARY KEY,
            DIRECCION varchar(20) NOT NULL,
            CIUDAD varchar(20) NOT NULL
            );

            INSERT INTO ALMACENES(IDALMACEN,DIRECCION,CIUDAD) VALUES
            ('ALM001','Edificio 22','Madrid'),
            ('ALM002','Edificio 23','Donosti'),
            ('ALM003','Edificio 24','Barcelona');

            CREATE TABLE PROVEEDORES (
            IDPROVEEDOR varchar(10) NOT NULL PRIMARY KEY,
            NOMBRECOMERCIAL varchar(20) NOT NULL,
            TELEFONO int NOT NULL,
            EMAIL varchar(20) NOT NULL
            );

            INSERT INTO PROVEEDORES(IDPROVEEDOR,NOMBRECOMERCIAL,TELEFONO,EMAIL) VALUES
            ('PRO001','EXTFIRE',935948604,'extfire@gmail.com'),
            ('PRO002','EXTFLAME',913123104,'extflame@gmail.com');

            CREATE TABLE PRODUCTOS (
            IDPRODUCTO varchar(10) NOT NULL PRIMARY KEY,
            DESCRIPCION varchar(40) NOT NULL,
            IDPROVEEDOR varchar(10) NOT NULL REFERENCES PROVEEDORES (IDPROVEEDOR),
			IDALMACEN varchar(10) NOT NULL REFERENCES ALMACENES (IDALMACEN)
            );

            INSERT INTO PRODUCTOS(IDPRODUCTO,DESCRIPCION,IDPROVEEDOR,IDALMACEN) 
            VALUES
            ('EXTPOLVO','Extintor de Polvo','PRO001','ALM001'),
            ('EXTCO2','Extintor de Co2','PRO002','ALM002');

            CREATE TABLE TRABAJADORES(
            IDTRABAJADOR varchar(10) NOT NULL PRIMARY KEY,
            NOMBRECOMPLETO varchar(30) NOT NULL,
            DNI varchar(9) NOT NULL
            );


            INSERT INTO TRABAJADORES(IDTRABAJADOR,NOMBRECOMPLETO,DNI) 
            VALUES
            ('REV001','JUAN GONZALEZ MONTALVO','49670323O'),
            ('REV002','MIGUEL PEREZ MANZANO','31230543Q');

            CREATE TABLE CLIENTES(
            IDCLIENTE varchar(10) NOT NULL PRIMARY KEY,
            NOMBRECOMPLETO varchar(30) NOT NULL,
            DIRECCION varchar(30) NOT NULL
            );

            INSERT INTO CLIENTES(IDCLIENTE,NOMBRECOMPLETO,DIRECCION) VALUES
            ('CLI001','JESUS ALVAREZ MARTINEZ','C/Miranda Irun'),
            ('CLI002','JOSE PEREZ VILLOSA','C/Sagrada Irun'),
            ('CLI003','MANUEL MARTINEZ GONZALEZ','C/Glorieta Bilbao');

            CREATE TABLE PEDIDOS (
            IDPEDIDO varchar(10) NOT NULL PRIMARY KEY,
            FECHA varchar(20) NOT NULL,
            DIRECCION varchar(20) NOT NULL,
            IDTRABAJADOR varchar(10) NOT NULL REFERENCES TRABAJADORES (IDTRABAJADOR),
            IDCLIENTE varchar(10) NOT NULL REFERENCES CLIENTES (IDCLIENTE)
            );

            INSERT INTO PEDIDOS(IDPEDIDO,FECHA,DIRECCION,IDTRABAJADOR,IDCLIENTE) VALUES
            ('PED001','22/05/2020','C/Miranda Irun','REV001','CLI001'),
            ('PED002','25/05/2020','C/Sagrada Irun','REV002','CLI002');

            CREATE TABLE LINEASPEDIDOS (
            IDLINEAS varchar(10) NOT NULL PRIMARY KEY,
            CANTIDAD int NOT NULL,
            PRECIOUNIDAD int NOT NULL,
            IDPEDIDO varchar(10) NOT NULL REFERENCES PEDIDOS (IDPEDIDO),
            IDPRODUCTO varchar(10) NOT NULL REFERENCES PRODUCTOS (IDPRODUCTO),
            SERVICIO varchar(3) NOT NULL
            );

            INSERT INTO LINEASPEDIDOS(IDLINEAS,CANTIDAD,PRECIOUNIDAD,IDPEDIDO,IDPRODUCTO,SERVICIO) VALUES
            ('LIN001',30,6,'PED001','EXTPOLVO','REV'),
            ('LIN002',23,6,'PED002','EXTCO2','VEN');"

    Public ConexionString As String = "Data Source=C:\database\ProyectoBBDDExtintores.db;Version=3"
    Public RutaDb = "C:\database\ProyectoBBDDExtintores.db"

    'Esta sub sirve para crear la base de datos o advertirte de si ya existe (Crea la carpeta y la db en caso de que no tengas la carpeta ya creada)
    Public Sub CrearDatabase()
        If Directory.Exists("C:\database") Then
            If File.Exists(RutaDb) Then
                MsgBox("La base de datos ya existe", MsgBoxStyle.Exclamation)
            Else
                Dim SQlcon As New SQLiteConnection(ConexionString)
                Dim cmd As New SQLiteCommand(StringBaseDatos, SQlcon)
                SQlcon.Open()
                cmd.ExecuteNonQuery()
                SQlcon.Close()
                MsgBox("Creada correctamente en la siguiente ruta: C:\database\ProyectoBBDDExtintores.db")
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("C:\database")
            Dim SQlcon As New SQLiteConnection(ConexionString)
            Dim cmd As New SQLiteCommand(StringBaseDatos, SQlcon)
            SQlcon.Open()
            cmd.ExecuteNonQuery()
            SQlcon.Close()
            MsgBox("Creada correctamente en la siguiente ruta: C:\database\ProyectoBBDDExtintores.db")
        End If
    End Sub

End Module
