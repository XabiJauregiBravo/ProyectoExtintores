<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarCliente))
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botonEditarCliente = New System.Windows.Forms.Button()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxNombreCompleto = New System.Windows.Forms.TextBox()
        Me.TextboxIdCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(91, 149)
        Me.TextBoxDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxDireccion.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Email"
        '
        'botonEditarCliente
        '
        Me.botonEditarCliente.BackColor = System.Drawing.Color.Black
        Me.botonEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditarCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditarCliente.ForeColor = System.Drawing.Color.White
        Me.botonEditarCliente.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditarCliente.Location = New System.Drawing.Point(83, 179)
        Me.botonEditarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonEditarCliente.Name = "botonEditarCliente"
        Me.botonEditarCliente.Size = New System.Drawing.Size(110, 41)
        Me.botonEditarCliente.TabIndex = 48
        Me.botonEditarCliente.Text = "Editar"
        Me.botonEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditarCliente.UseVisualStyleBackColor = False
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 107)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 32)
        Me.Direccion.TabIndex = 47
        Me.Direccion.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completo"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(12, 77)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(61, 16)
        Me.IDALMACEN.TabIndex = 46
        Me.IDALMACEN.Text = "IDCLIENTE"
        '
        'TextboxNombreCompleto
        '
        Me.TextboxNombreCompleto.Location = New System.Drawing.Point(91, 107)
        Me.TextboxNombreCompleto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreCompleto.Name = "TextboxNombreCompleto"
        Me.TextboxNombreCompleto.Size = New System.Drawing.Size(171, 20)
        Me.TextboxNombreCompleto.TabIndex = 45
        '
        'TextboxIdCliente
        '
        Me.TextboxIdCliente.Location = New System.Drawing.Point(101, 75)
        Me.TextboxIdCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdCliente.Name = "TextboxIdCliente"
        Me.TextboxIdCliente.Size = New System.Drawing.Size(161, 20)
        Me.TextboxIdCliente.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Editar Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(98, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Introduce un ID que ya exista:"
        '
        'FormEditarCliente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 239)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botonEditarCliente)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxNombreCompleto)
        Me.Controls.Add(Me.TextboxIdCliente)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 278)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 278)
        Me.Name = "FormEditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents botonEditarCliente As Button
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxNombreCompleto As TextBox
    Friend WithEvents TextboxIdCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
