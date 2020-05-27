<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarAlmacen))
        Me.botonEditarAlmacen = New System.Windows.Forms.Button()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxDireccionEditarAlmacen = New System.Windows.Forms.TextBox()
        Me.TextboxIdAlmacenEditarAlmacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCiudad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonEditarAlmacen
        '
        Me.botonEditarAlmacen.BackColor = System.Drawing.Color.Black
        Me.botonEditarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditarAlmacen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditarAlmacen.ForeColor = System.Drawing.Color.White
        Me.botonEditarAlmacen.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditarAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditarAlmacen.Location = New System.Drawing.Point(78, 195)
        Me.botonEditarAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonEditarAlmacen.Name = "botonEditarAlmacen"
        Me.botonEditarAlmacen.Size = New System.Drawing.Size(110, 41)
        Me.botonEditarAlmacen.TabIndex = 40
        Me.botonEditarAlmacen.Text = "Editar"
        Me.botonEditarAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditarAlmacen.UseVisualStyleBackColor = False
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(14, 127)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(58, 16)
        Me.Direccion.TabIndex = 36
        Me.Direccion.Text = "Dirección"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(18, 94)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(72, 16)
        Me.IDALMACEN.TabIndex = 35
        Me.IDALMACEN.Text = "IDALMACEN"
        '
        'TextboxDireccionEditarAlmacen
        '
        Me.TextboxDireccionEditarAlmacen.Location = New System.Drawing.Point(78, 123)
        Me.TextboxDireccionEditarAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxDireccionEditarAlmacen.Name = "TextboxDireccionEditarAlmacen"
        Me.TextboxDireccionEditarAlmacen.Size = New System.Drawing.Size(179, 20)
        Me.TextboxDireccionEditarAlmacen.TabIndex = 33
        '
        'TextboxIdAlmacenEditarAlmacen
        '
        Me.TextboxIdAlmacenEditarAlmacen.Location = New System.Drawing.Point(96, 91)
        Me.TextboxIdAlmacenEditarAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdAlmacenEditarAlmacen.Name = "TextboxIdAlmacenEditarAlmacen"
        Me.TextboxIdAlmacenEditarAlmacen.Size = New System.Drawing.Size(161, 20)
        Me.TextboxIdAlmacenEditarAlmacen.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Editar Almacén"
        '
        'TextBoxCiudad
        '
        Me.TextBoxCiudad.Location = New System.Drawing.Point(78, 163)
        Me.TextBoxCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCiudad.Name = "TextBoxCiudad"
        Me.TextBoxCiudad.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxCiudad.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(93, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Introduce un ID que ya exista:"
        '
        'FormEditarAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 239)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCiudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botonEditarAlmacen)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxDireccionEditarAlmacen)
        Me.Controls.Add(Me.TextboxIdAlmacenEditarAlmacen)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 278)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 278)
        Me.Name = "FormEditarAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditarAlmacen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonEditarAlmacen As Button
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxDireccionEditarAlmacen As TextBox
    Friend WithEvents TextboxIdAlmacenEditarAlmacen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCiudad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
