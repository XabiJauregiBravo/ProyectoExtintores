<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionPedidos))
        Me.botonFacturas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelMenuPrincipal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonFacturas
        '
        Me.botonFacturas.BackColor = System.Drawing.Color.Black
        Me.botonFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonFacturas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonFacturas.ForeColor = System.Drawing.Color.White
        Me.botonFacturas.Location = New System.Drawing.Point(36, 137)
        Me.botonFacturas.Name = "botonFacturas"
        Me.botonFacturas.Size = New System.Drawing.Size(174, 153)
        Me.botonFacturas.TabIndex = 6
        Me.botonFacturas.Text = "Pedidos"
        Me.botonFacturas.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(270, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 153)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Productos Pedidos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelMenuPrincipal
        '
        Me.LabelMenuPrincipal.AutoSize = True
        Me.LabelMenuPrincipal.BackColor = System.Drawing.Color.White
        Me.LabelMenuPrincipal.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMenuPrincipal.ForeColor = System.Drawing.Color.Black
        Me.LabelMenuPrincipal.Location = New System.Drawing.Point(29, 30)
        Me.LabelMenuPrincipal.Name = "LabelMenuPrincipal"
        Me.LabelMenuPrincipal.Size = New System.Drawing.Size(401, 42)
        Me.LabelMenuPrincipal.TabIndex = 8
        Me.LabelMenuPrincipal.Text = "Menú Gestión Pedidos"
        '
        'FormGestionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 328)
        Me.Controls.Add(Me.LabelMenuPrincipal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.botonFacturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGestionPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonFacturas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelMenuPrincipal As Label
End Class
