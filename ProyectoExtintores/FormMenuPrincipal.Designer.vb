<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        Me.botonAlmacenes = New System.Windows.Forms.Button()
        Me.botonProveedores = New System.Windows.Forms.Button()
        Me.botonRevisores = New System.Windows.Forms.Button()
        Me.BotonInvExtintores = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Button()
        Me.botonFacturas = New System.Windows.Forms.Button()
        Me.LabelMenuPrincipal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonAlmacenes
        '
        Me.botonAlmacenes.BackColor = System.Drawing.Color.Black
        Me.botonAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAlmacenes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAlmacenes.ForeColor = System.Drawing.Color.White
        Me.botonAlmacenes.Location = New System.Drawing.Point(35, 203)
        Me.botonAlmacenes.Name = "botonAlmacenes"
        Me.botonAlmacenes.Size = New System.Drawing.Size(237, 175)
        Me.botonAlmacenes.TabIndex = 0
        Me.botonAlmacenes.Text = "Almacenes"
        Me.botonAlmacenes.UseVisualStyleBackColor = False
        '
        'botonProveedores
        '
        Me.botonProveedores.BackColor = System.Drawing.Color.Black
        Me.botonProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonProveedores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonProveedores.ForeColor = System.Drawing.Color.White
        Me.botonProveedores.Location = New System.Drawing.Point(369, 203)
        Me.botonProveedores.Name = "botonProveedores"
        Me.botonProveedores.Size = New System.Drawing.Size(237, 175)
        Me.botonProveedores.TabIndex = 1
        Me.botonProveedores.Text = "Proveedores"
        Me.botonProveedores.UseVisualStyleBackColor = False
        '
        'botonRevisores
        '
        Me.botonRevisores.BackColor = System.Drawing.Color.Black
        Me.botonRevisores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonRevisores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonRevisores.ForeColor = System.Drawing.Color.White
        Me.botonRevisores.Location = New System.Drawing.Point(709, 203)
        Me.botonRevisores.Name = "botonRevisores"
        Me.botonRevisores.Size = New System.Drawing.Size(237, 175)
        Me.botonRevisores.TabIndex = 2
        Me.botonRevisores.Text = "Revisores"
        Me.botonRevisores.UseVisualStyleBackColor = False
        '
        'BotonInvExtintores
        '
        Me.BotonInvExtintores.BackColor = System.Drawing.Color.Black
        Me.BotonInvExtintores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonInvExtintores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonInvExtintores.ForeColor = System.Drawing.Color.White
        Me.BotonInvExtintores.Location = New System.Drawing.Point(35, 436)
        Me.BotonInvExtintores.Name = "BotonInvExtintores"
        Me.BotonInvExtintores.Size = New System.Drawing.Size(237, 175)
        Me.BotonInvExtintores.TabIndex = 3
        Me.BotonInvExtintores.Text = "Productos"
        Me.BotonInvExtintores.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.Black
        Me.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.ForeColor = System.Drawing.Color.White
        Me.Clientes.Location = New System.Drawing.Point(369, 436)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(237, 175)
        Me.Clientes.TabIndex = 4
        Me.Clientes.Text = "Clientes"
        Me.Clientes.UseVisualStyleBackColor = False
        '
        'botonFacturas
        '
        Me.botonFacturas.BackColor = System.Drawing.Color.Black
        Me.botonFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonFacturas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonFacturas.ForeColor = System.Drawing.Color.White
        Me.botonFacturas.Location = New System.Drawing.Point(709, 436)
        Me.botonFacturas.Name = "botonFacturas"
        Me.botonFacturas.Size = New System.Drawing.Size(237, 175)
        Me.botonFacturas.TabIndex = 5
        Me.botonFacturas.Text = "Facturación"
        Me.botonFacturas.UseVisualStyleBackColor = False
        '
        'LabelMenuPrincipal
        '
        Me.LabelMenuPrincipal.AutoSize = True
        Me.LabelMenuPrincipal.BackColor = System.Drawing.Color.White
        Me.LabelMenuPrincipal.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMenuPrincipal.ForeColor = System.Drawing.Color.Black
        Me.LabelMenuPrincipal.Location = New System.Drawing.Point(131, 9)
        Me.LabelMenuPrincipal.Name = "LabelMenuPrincipal"
        Me.LabelMenuPrincipal.Size = New System.Drawing.Size(741, 115)
        Me.LabelMenuPrincipal.TabIndex = 6
        Me.LabelMenuPrincipal.Text = "Menú Principal"
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 629)
        Me.Controls.Add(Me.LabelMenuPrincipal)
        Me.Controls.Add(Me.botonFacturas)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.BotonInvExtintores)
        Me.Controls.Add(Me.botonRevisores)
        Me.Controls.Add(Me.botonProveedores)
        Me.Controls.Add(Me.botonAlmacenes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(996, 668)
        Me.MinimumSize = New System.Drawing.Size(996, 668)
        Me.Name = "FormMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonAlmacenes As Button
    Friend WithEvents botonProveedores As Button
    Friend WithEvents botonRevisores As Button
    Friend WithEvents BotonInvExtintores As Button
    Friend WithEvents Clientes As Button
    Friend WithEvents botonFacturas As Button
    Friend WithEvents LabelMenuPrincipal As Label
End Class
