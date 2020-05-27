<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarProveedor))
        Me.botonEditarProveedor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextboxTelefonoEditarProveedor = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxEmailEditarProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxNombreComercialEditarProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxIdProveedorEditarProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonEditarProveedor
        '
        Me.botonEditarProveedor.BackColor = System.Drawing.Color.Black
        Me.botonEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditarProveedor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditarProveedor.ForeColor = System.Drawing.Color.White
        Me.botonEditarProveedor.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditarProveedor.Location = New System.Drawing.Point(79, 235)
        Me.botonEditarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonEditarProveedor.Name = "botonEditarProveedor"
        Me.botonEditarProveedor.Size = New System.Drawing.Size(110, 41)
        Me.botonEditarProveedor.TabIndex = 30
        Me.botonEditarProveedor.Text = "Editar"
        Me.botonEditarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditarProveedor.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Teléfono"
        '
        'TextboxTelefonoEditarProveedor
        '
        Me.TextboxTelefonoEditarProveedor.Location = New System.Drawing.Point(79, 206)
        Me.TextboxTelefonoEditarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxTelefonoEditarProveedor.Name = "TextboxTelefonoEditarProveedor"
        Me.TextboxTelefonoEditarProveedor.Size = New System.Drawing.Size(189, 20)
        Me.TextboxTelefonoEditarProveedor.TabIndex = 28
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(19, 167)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(36, 16)
        Me.Cantidad.TabIndex = 27
        Me.Cantidad.Text = "Email"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 128)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(109, 16)
        Me.Direccion.TabIndex = 26
        Me.Direccion.Text = "Nombre Comercial"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(19, 83)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(87, 16)
        Me.IDALMACEN.TabIndex = 25
        Me.IDALMACEN.Text = "IDPROVEEDOR"
        '
        'TextboxEmailEditarProveedor
        '
        Me.TextboxEmailEditarProveedor.Location = New System.Drawing.Point(79, 162)
        Me.TextboxEmailEditarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxEmailEditarProveedor.Name = "TextboxEmailEditarProveedor"
        Me.TextboxEmailEditarProveedor.Size = New System.Drawing.Size(189, 20)
        Me.TextboxEmailEditarProveedor.TabIndex = 24
        '
        'TextboxNombreComercialEditarProveedor
        '
        Me.TextboxNombreComercialEditarProveedor.Location = New System.Drawing.Point(127, 128)
        Me.TextboxNombreComercialEditarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreComercialEditarProveedor.Name = "TextboxNombreComercialEditarProveedor"
        Me.TextboxNombreComercialEditarProveedor.Size = New System.Drawing.Size(141, 20)
        Me.TextboxNombreComercialEditarProveedor.TabIndex = 23
        '
        'TextboxIdProveedorEditarProveedor
        '
        Me.TextboxIdProveedorEditarProveedor.Location = New System.Drawing.Point(112, 80)
        Me.TextboxIdProveedorEditarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProveedorEditarProveedor.Name = "TextboxIdProveedorEditarProveedor"
        Me.TextboxIdProveedorEditarProveedor.Size = New System.Drawing.Size(156, 20)
        Me.TextboxIdProveedorEditarProveedor.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Editar Proveedor"
        '
        'FormEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 300)
        Me.Controls.Add(Me.botonEditarProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextboxTelefonoEditarProveedor)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxEmailEditarProveedor)
        Me.Controls.Add(Me.TextboxNombreComercialEditarProveedor)
        Me.Controls.Add(Me.TextboxIdProveedorEditarProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 339)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 339)
        Me.Name = "FormEditarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonEditarProveedor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextboxTelefonoEditarProveedor As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxEmailEditarProveedor As TextBox
    Friend WithEvents TextboxNombreComercialEditarProveedor As TextBox
    Friend WithEvents TextboxIdProveedorEditarProveedor As TextBox
    Friend WithEvents Label1 As Label
End Class
