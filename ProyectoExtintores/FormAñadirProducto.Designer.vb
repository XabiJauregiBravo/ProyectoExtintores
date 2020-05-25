<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAñadirProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirProducto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxIdProveedor = New System.Windows.Forms.TextBox()
        Me.TextboxIdAlmacen = New System.Windows.Forms.TextBox()
        Me.TextboxIdExtintor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nuevo Extintor"
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(56, 183)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonAñadir.Size = New System.Drawing.Size(139, 41)
        Me.botonAñadir.TabIndex = 16
        Me.botonAñadir.Text = "Añadir     "
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.Location = New System.Drawing.Point(6, 144)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(87, 16)
        Me.Cantidad.TabIndex = 15
        Me.Cantidad.Text = "IDPROVEEDOR"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(12, 113)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(84, 16)
        Me.Direccion.TabIndex = 14
        Me.Direccion.Text = "DESCRIPCION"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(14, 82)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(70, 16)
        Me.IDALMACEN.TabIndex = 13
        Me.IDALMACEN.Text = "IDEXTINTOR"
        '
        'TextboxIdProveedor
        '
        Me.TextboxIdProveedor.Location = New System.Drawing.Point(105, 141)
        Me.TextboxIdProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdProveedor.Name = "TextboxIdProveedor"
        Me.TextboxIdProveedor.Size = New System.Drawing.Size(138, 20)
        Me.TextboxIdProveedor.TabIndex = 12
        '
        'TextboxIdAlmacen
        '
        Me.TextboxIdAlmacen.Location = New System.Drawing.Point(101, 113)
        Me.TextboxIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdAlmacen.Name = "TextboxIdAlmacen"
        Me.TextboxIdAlmacen.Size = New System.Drawing.Size(142, 20)
        Me.TextboxIdAlmacen.TabIndex = 11
        '
        'TextboxIdExtintor
        '
        Me.TextboxIdExtintor.Location = New System.Drawing.Point(101, 78)
        Me.TextboxIdExtintor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdExtintor.Name = "TextboxIdExtintor"
        Me.TextboxIdExtintor.Size = New System.Drawing.Size(128, 20)
        Me.TextboxIdExtintor.TabIndex = 10
        '
        'FormAñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxIdProveedor)
        Me.Controls.Add(Me.TextboxIdAlmacen)
        Me.Controls.Add(Me.TextboxIdExtintor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 281)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 281)
        Me.Name = "FormAñadirProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Extintor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents botonAñadir As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxIdProveedor As TextBox
    Friend WithEvents TextboxIdAlmacen As TextBox
    Friend WithEvents TextboxIdExtintor As TextBox
End Class
