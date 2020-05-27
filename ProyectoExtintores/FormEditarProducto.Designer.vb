<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarProducto))
        Me.TextBoxProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botonEditarCliente = New System.Windows.Forms.Button()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextboxIdProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxProveedor
        '
        Me.TextBoxProveedor.Location = New System.Drawing.Point(100, 182)
        Me.TextBoxProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxProveedor.Name = "TextBoxProveedor"
        Me.TextBoxProveedor.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxProveedor.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "IDPROVEEDOR"
        '
        'botonEditarCliente
        '
        Me.botonEditarCliente.BackColor = System.Drawing.Color.Black
        Me.botonEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditarCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditarCliente.ForeColor = System.Drawing.Color.White
        Me.botonEditarCliente.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditarCliente.Location = New System.Drawing.Point(86, 273)
        Me.botonEditarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonEditarCliente.Name = "botonEditarCliente"
        Me.botonEditarCliente.Size = New System.Drawing.Size(110, 41)
        Me.botonEditarCliente.TabIndex = 56
        Me.botonEditarCliente.Text = "Editar"
        Me.botonEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditarCliente.UseVisualStyleBackColor = False
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 142)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(70, 16)
        Me.Direccion.TabIndex = 55
        Me.Direccion.Text = "Descripción"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(7, 110)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(83, 16)
        Me.IDALMACEN.TabIndex = 54
        Me.IDALMACEN.Text = "IDPRODUCTO"
        '
        'TextboxDescripcion
        '
        Me.TextboxDescripcion.Location = New System.Drawing.Point(86, 140)
        Me.TextboxDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxDescripcion.Name = "TextboxDescripcion"
        Me.TextboxDescripcion.Size = New System.Drawing.Size(171, 20)
        Me.TextboxDescripcion.TabIndex = 53
        '
        'TextboxIdProducto
        '
        Me.TextboxIdProducto.Location = New System.Drawing.Point(96, 108)
        Me.TextboxIdProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProducto.Name = "TextboxIdProducto"
        Me.TextboxIdProducto.Size = New System.Drawing.Size(161, 20)
        Me.TextboxIdProducto.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Editar Producto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 221)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "IDALMACEN"
        '
        'FormEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 339)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botonEditarCliente)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxDescripcion)
        Me.Controls.Add(Me.TextboxIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 378)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 378)
        Me.Name = "FormEditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Extintor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents botonEditarCliente As Button
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxDescripcion As TextBox
    Friend WithEvents TextboxIdProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
