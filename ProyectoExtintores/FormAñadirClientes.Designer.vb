<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDCLIENTE = New System.Windows.Forms.Label()
        Me.TextboxDireccion = New System.Windows.Forms.TextBox()
        Me.TextboxNombreCompleto = New System.Windows.Forms.TextBox()
        Me.TextboxIdCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nuevo Cliente"
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(84, 242)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonAñadir.Size = New System.Drawing.Size(139, 41)
        Me.botonAñadir.TabIndex = 28
        Me.botonAñadir.Text = "Añadir     "
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(30, 193)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(58, 16)
        Me.Cantidad.TabIndex = 27
        Me.Cantidad.Text = "Direccion"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(26, 117)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 32)
        Me.Direccion.TabIndex = 26
        Me.Direccion.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completo"
        '
        'IDCLIENTE
        '
        Me.IDCLIENTE.AutoSize = True
        Me.IDCLIENTE.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCLIENTE.ForeColor = System.Drawing.Color.Black
        Me.IDCLIENTE.Location = New System.Drawing.Point(30, 73)
        Me.IDCLIENTE.Name = "IDCLIENTE"
        Me.IDCLIENTE.Size = New System.Drawing.Size(61, 16)
        Me.IDCLIENTE.TabIndex = 24
        Me.IDCLIENTE.Text = "IDCLIENTE"
        '
        'TextboxDireccion
        '
        Me.TextboxDireccion.Location = New System.Drawing.Point(107, 189)
        Me.TextboxDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxDireccion.Name = "TextboxDireccion"
        Me.TextboxDireccion.Size = New System.Drawing.Size(138, 20)
        Me.TextboxDireccion.TabIndex = 22
        '
        'TextboxNombreCompleto
        '
        Me.TextboxNombreCompleto.Location = New System.Drawing.Point(107, 129)
        Me.TextboxNombreCompleto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreCompleto.Name = "TextboxNombreCompleto"
        Me.TextboxNombreCompleto.Size = New System.Drawing.Size(142, 20)
        Me.TextboxNombreCompleto.TabIndex = 21
        '
        'TextboxIdCliente
        '
        Me.TextboxIdCliente.Location = New System.Drawing.Point(117, 69)
        Me.TextboxIdCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdCliente.Name = "TextboxIdCliente"
        Me.TextboxIdCliente.Size = New System.Drawing.Size(128, 20)
        Me.TextboxIdCliente.TabIndex = 20
        '
        'FormAñadirClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 300)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDCLIENTE)
        Me.Controls.Add(Me.TextboxDireccion)
        Me.Controls.Add(Me.TextboxNombreCompleto)
        Me.Controls.Add(Me.TextboxIdCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 339)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 339)
        Me.Name = "FormAñadirClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents botonAñadir As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDCLIENTE As Label
    Friend WithEvents TextboxDireccion As TextBox
    Friend WithEvents TextboxNombreCompleto As TextBox
    Friend WithEvents TextboxIdCliente As TextBox
End Class
