<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirLineaPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirLineaPedido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDLINEA = New System.Windows.Forms.Label()
        Me.TextboxIdProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxIdAlmacen = New System.Windows.Forms.TextBox()
        Me.TextboxIdExtintor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 72)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nueva Linea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Pedido"
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(69, 366)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonAñadir.Size = New System.Drawing.Size(139, 41)
        Me.botonAñadir.TabIndex = 24
        Me.botonAñadir.Text = "Añadir     "
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(10, 197)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(85, 16)
        Me.Cantidad.TabIndex = 23
        Me.Cantidad.Text = "Precio Unidad"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 157)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 16)
        Me.Direccion.TabIndex = 22
        Me.Direccion.Text = "Cantidad"
        '
        'IDLINEA
        '
        Me.IDLINEA.AutoSize = True
        Me.IDLINEA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLINEA.ForeColor = System.Drawing.Color.Black
        Me.IDLINEA.Location = New System.Drawing.Point(28, 113)
        Me.IDLINEA.Name = "IDLINEA"
        Me.IDLINEA.Size = New System.Drawing.Size(54, 16)
        Me.IDLINEA.TabIndex = 21
        Me.IDLINEA.Text = "IDLINEAS"
        '
        'TextboxIdProveedor
        '
        Me.TextboxIdProveedor.Location = New System.Drawing.Point(106, 193)
        Me.TextboxIdProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProveedor.Name = "TextboxIdProveedor"
        Me.TextboxIdProveedor.Size = New System.Drawing.Size(138, 20)
        Me.TextboxIdProveedor.TabIndex = 20
        '
        'TextboxIdAlmacen
        '
        Me.TextboxIdAlmacen.Location = New System.Drawing.Point(102, 155)
        Me.TextboxIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdAlmacen.Name = "TextboxIdAlmacen"
        Me.TextboxIdAlmacen.Size = New System.Drawing.Size(142, 20)
        Me.TextboxIdAlmacen.TabIndex = 19
        '
        'TextboxIdExtintor
        '
        Me.TextboxIdExtintor.Location = New System.Drawing.Point(102, 111)
        Me.TextboxIdExtintor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdExtintor.Name = "TextboxIdExtintor"
        Me.TextboxIdExtintor.Size = New System.Drawing.Size(142, 20)
        Me.TextboxIdExtintor.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "IDPRODUCTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "IDPEDIDO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 274)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 232)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(39, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Servicio"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(95, 319)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(149, 20)
        Me.TextBox3.TabIndex = 31
        '
        'FormAñadirLineaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 433)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDLINEA)
        Me.Controls.Add(Me.TextboxIdProveedor)
        Me.Controls.Add(Me.TextboxIdAlmacen)
        Me.Controls.Add(Me.TextboxIdExtintor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 472)
        Me.Name = "FormAñadirLineaPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAñadirLineaPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents botonAñadir As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDLINEA As Label
    Friend WithEvents TextboxIdProveedor As TextBox
    Friend WithEvents TextboxIdAlmacen As TextBox
    Friend WithEvents TextboxIdExtintor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
