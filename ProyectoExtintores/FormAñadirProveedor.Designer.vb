<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirProveedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextboxTelefonoAñadirProveedor = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxEmailAñadirProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxNombreComercialAñadirProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxIdProveedorAñadirProveedor = New System.Windows.Forms.TextBox()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nuevo Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Teléfono"
        '
        'TextboxTelefonoAñadirProveedor
        '
        Me.TextboxTelefonoAñadirProveedor.Location = New System.Drawing.Point(79, 208)
        Me.TextboxTelefonoAñadirProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxTelefonoAñadirProveedor.Name = "TextboxTelefonoAñadirProveedor"
        Me.TextboxTelefonoAñadirProveedor.Size = New System.Drawing.Size(189, 21)
        Me.TextboxTelefonoAñadirProveedor.TabIndex = 18
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(19, 169)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(36, 16)
        Me.Cantidad.TabIndex = 17
        Me.Cantidad.Text = "Email"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 130)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(109, 16)
        Me.Direccion.TabIndex = 16
        Me.Direccion.Text = "Nombre Comercial"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(19, 85)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(87, 16)
        Me.IDALMACEN.TabIndex = 15
        Me.IDALMACEN.Text = "IDPROVEEDOR"
        '
        'TextboxEmailAñadirProveedor
        '
        Me.TextboxEmailAñadirProveedor.Location = New System.Drawing.Point(79, 164)
        Me.TextboxEmailAñadirProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxEmailAñadirProveedor.Name = "TextboxEmailAñadirProveedor"
        Me.TextboxEmailAñadirProveedor.Size = New System.Drawing.Size(189, 21)
        Me.TextboxEmailAñadirProveedor.TabIndex = 14
        '
        'TextboxNombreComercialAñadirProveedor
        '
        Me.TextboxNombreComercialAñadirProveedor.Location = New System.Drawing.Point(127, 130)
        Me.TextboxNombreComercialAñadirProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreComercialAñadirProveedor.Name = "TextboxNombreComercialAñadirProveedor"
        Me.TextboxNombreComercialAñadirProveedor.Size = New System.Drawing.Size(141, 21)
        Me.TextboxNombreComercialAñadirProveedor.TabIndex = 13
        '
        'TextboxIdProveedorAñadirProveedor
        '
        Me.TextboxIdProveedorAñadirProveedor.Location = New System.Drawing.Point(112, 82)
        Me.TextboxIdProveedorAñadirProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProveedorAñadirProveedor.Name = "TextboxIdProveedorAñadirProveedor"
        Me.TextboxIdProveedorAñadirProveedor.Size = New System.Drawing.Size(156, 21)
        Me.TextboxIdProveedorAñadirProveedor.TabIndex = 12
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(63, 246)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.Size = New System.Drawing.Size(139, 41)
        Me.botonAñadir.TabIndex = 20
        Me.botonAñadir.Text = "Añadir   "
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'FormAñadirProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 300)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextboxTelefonoAñadirProveedor)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxEmailAñadirProveedor)
        Me.Controls.Add(Me.TextboxNombreComercialAñadirProveedor)
        Me.Controls.Add(Me.TextboxIdProveedorAñadirProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 339)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 339)
        Me.Name = "FormAñadirProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextboxTelefonoAñadirProveedor As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxEmailAñadirProveedor As TextBox
    Friend WithEvents TextboxNombreComercialAñadirProveedor As TextBox
    Friend WithEvents TextboxIdProveedorAñadirProveedor As TextBox
    Friend WithEvents botonAñadir As Button
End Class
