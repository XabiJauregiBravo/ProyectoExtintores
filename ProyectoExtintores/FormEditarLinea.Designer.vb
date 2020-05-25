<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarLinea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarLinea))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDLINEA = New System.Windows.Forms.Label()
        Me.TextboxIdProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxIdAlmacen = New System.Windows.Forms.TextBox()
        Me.TextboxIdExtintor = New System.Windows.Forms.TextBox()
        Me.botonEditarAlmacen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "IDPRODUCTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "IDPEDIDO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 274)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 39
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 232)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 72)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Editar Linea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Pedido"
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(7, 197)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(85, 16)
        Me.Cantidad.TabIndex = 35
        Me.Cantidad.Text = "Precio Unidad"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(9, 157)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 16)
        Me.Direccion.TabIndex = 34
        Me.Direccion.Text = "Cantidad"
        '
        'IDLINEA
        '
        Me.IDLINEA.AutoSize = True
        Me.IDLINEA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLINEA.ForeColor = System.Drawing.Color.Black
        Me.IDLINEA.Location = New System.Drawing.Point(25, 113)
        Me.IDLINEA.Name = "IDLINEA"
        Me.IDLINEA.Size = New System.Drawing.Size(54, 16)
        Me.IDLINEA.TabIndex = 33
        Me.IDLINEA.Text = "IDLINEAS"
        '
        'TextboxIdProveedor
        '
        Me.TextboxIdProveedor.Location = New System.Drawing.Point(103, 193)
        Me.TextboxIdProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProveedor.Name = "TextboxIdProveedor"
        Me.TextboxIdProveedor.Size = New System.Drawing.Size(138, 20)
        Me.TextboxIdProveedor.TabIndex = 32
        '
        'TextboxIdAlmacen
        '
        Me.TextboxIdAlmacen.Location = New System.Drawing.Point(99, 155)
        Me.TextboxIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdAlmacen.Name = "TextboxIdAlmacen"
        Me.TextboxIdAlmacen.Size = New System.Drawing.Size(142, 20)
        Me.TextboxIdAlmacen.TabIndex = 31
        '
        'TextboxIdExtintor
        '
        Me.TextboxIdExtintor.Location = New System.Drawing.Point(97, 111)
        Me.TextboxIdExtintor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdExtintor.Name = "TextboxIdExtintor"
        Me.TextboxIdExtintor.Size = New System.Drawing.Size(128, 20)
        Me.TextboxIdExtintor.TabIndex = 30
        '
        'botonEditarAlmacen
        '
        Me.botonEditarAlmacen.BackColor = System.Drawing.Color.Black
        Me.botonEditarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditarAlmacen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditarAlmacen.ForeColor = System.Drawing.Color.White
        Me.botonEditarAlmacen.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditarAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditarAlmacen.Location = New System.Drawing.Point(83, 315)
        Me.botonEditarAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonEditarAlmacen.Name = "botonEditarAlmacen"
        Me.botonEditarAlmacen.Size = New System.Drawing.Size(110, 41)
        Me.botonEditarAlmacen.TabIndex = 42
        Me.botonEditarAlmacen.Text = "Editar"
        Me.botonEditarAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditarAlmacen.UseVisualStyleBackColor = False
        '
        'FormEditarLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 382)
        Me.Controls.Add(Me.botonEditarAlmacen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDLINEA)
        Me.Controls.Add(Me.TextboxIdProveedor)
        Me.Controls.Add(Me.TextboxIdAlmacen)
        Me.Controls.Add(Me.TextboxIdExtintor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 421)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 421)
        Me.Name = "FormEditarLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Linea Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDLINEA As Label
    Friend WithEvents TextboxIdProveedor As TextBox
    Friend WithEvents TextboxIdAlmacen As TextBox
    Friend WithEvents TextboxIdExtintor As TextBox
    Friend WithEvents botonEditarAlmacen As Button
End Class
