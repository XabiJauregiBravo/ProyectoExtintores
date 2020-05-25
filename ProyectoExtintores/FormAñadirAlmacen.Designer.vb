<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirAlmacen))
        Me.TextboxIdAlmacenAnadirAlmacen = New System.Windows.Forms.TextBox()
        Me.TextboxDireccionAnadirAlmacen = New System.Windows.Forms.TextBox()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCiudad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextboxIdAlmacenAnadirAlmacen
        '
        Me.TextboxIdAlmacenAnadirAlmacen.Location = New System.Drawing.Point(113, 61)
        Me.TextboxIdAlmacenAnadirAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdAlmacenAnadirAlmacen.Name = "TextboxIdAlmacenAnadirAlmacen"
        Me.TextboxIdAlmacenAnadirAlmacen.Size = New System.Drawing.Size(128, 21)
        Me.TextboxIdAlmacenAnadirAlmacen.TabIndex = 0
        '
        'TextboxDireccionAnadirAlmacen
        '
        Me.TextboxDireccionAnadirAlmacen.Location = New System.Drawing.Point(99, 102)
        Me.TextboxDireccionAnadirAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxDireccionAnadirAlmacen.Name = "TextboxDireccionAnadirAlmacen"
        Me.TextboxDireccionAnadirAlmacen.Size = New System.Drawing.Size(142, 21)
        Me.TextboxDireccionAnadirAlmacen.TabIndex = 1
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(35, 66)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(72, 16)
        Me.IDALMACEN.TabIndex = 3
        Me.IDALMACEN.Text = "IDALMACEN"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(34, 107)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(58, 16)
        Me.Direccion.TabIndex = 5
        Me.Direccion.Text = "Dirección"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nuevo Almacén"
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(69, 175)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonAñadir.Size = New System.Drawing.Size(139, 41)
        Me.botonAñadir.TabIndex = 8
        Me.botonAñadir.Text = "Añadir     "
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ciudad"
        '
        'TextBoxCiudad
        '
        Me.TextBoxCiudad.Location = New System.Drawing.Point(99, 143)
        Me.TextBoxCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCiudad.Name = "TextBoxCiudad"
        Me.TextBoxCiudad.Size = New System.Drawing.Size(142, 21)
        Me.TextBoxCiudad.TabIndex = 11
        '
        'FormAñadirAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 229)
        Me.Controls.Add(Me.TextBoxCiudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxDireccionAnadirAlmacen)
        Me.Controls.Add(Me.TextboxIdAlmacenAnadirAlmacen)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 268)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 268)
        Me.Name = "FormAñadirAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Almacén"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextboxIdAlmacenAnadirAlmacen As TextBox
    Friend WithEvents TextboxDireccionAnadirAlmacen As TextBox
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents botonAñadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCiudad As TextBox
End Class
