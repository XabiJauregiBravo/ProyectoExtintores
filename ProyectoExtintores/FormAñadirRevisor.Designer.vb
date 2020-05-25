<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirRevisor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirRevisor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxDNIAñadirRevisor = New System.Windows.Forms.TextBox()
        Me.TextboxNombreAñadirRevisor = New System.Windows.Forms.TextBox()
        Me.TextboxIdRevisorAnadirRevisor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nuevo Revisor"
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(66, 246)
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
        Me.Cantidad.Location = New System.Drawing.Point(37, 192)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(27, 16)
        Me.Cantidad.TabIndex = 15
        Me.Cantidad.Text = "DNI"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(24, 129)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 32)
        Me.Direccion.TabIndex = 14
        Me.Direccion.Text = "Nomble " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completo"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(21, 78)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(65, 16)
        Me.IDALMACEN.TabIndex = 13
        Me.IDALMACEN.Text = "IDREVISOR"
        '
        'TextboxDNIAñadirRevisor
        '
        Me.TextboxDNIAñadirRevisor.Location = New System.Drawing.Point(89, 190)
        Me.TextboxDNIAñadirRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxDNIAñadirRevisor.Name = "TextboxDNIAñadirRevisor"
        Me.TextboxDNIAñadirRevisor.Size = New System.Drawing.Size(145, 20)
        Me.TextboxDNIAñadirRevisor.TabIndex = 12
        '
        'TextboxNombreAñadirRevisor
        '
        Me.TextboxNombreAñadirRevisor.Location = New System.Drawing.Point(92, 141)
        Me.TextboxNombreAñadirRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreAñadirRevisor.Name = "TextboxNombreAñadirRevisor"
        Me.TextboxNombreAñadirRevisor.Size = New System.Drawing.Size(142, 20)
        Me.TextboxNombreAñadirRevisor.TabIndex = 11
        '
        'TextboxIdRevisorAnadirRevisor
        '
        Me.TextboxIdRevisorAnadirRevisor.Location = New System.Drawing.Point(99, 73)
        Me.TextboxIdRevisorAnadirRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdRevisorAnadirRevisor.Name = "TextboxIdRevisorAnadirRevisor"
        Me.TextboxIdRevisorAnadirRevisor.Size = New System.Drawing.Size(128, 20)
        Me.TextboxIdRevisorAnadirRevisor.TabIndex = 10
        '
        'FormAñadirRevisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 300)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxDNIAñadirRevisor)
        Me.Controls.Add(Me.TextboxNombreAñadirRevisor)
        Me.Controls.Add(Me.TextboxIdRevisorAnadirRevisor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 339)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 339)
        Me.Name = "FormAñadirRevisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Revisor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents botonAñadir As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxDNIAñadirRevisor As TextBox
    Friend WithEvents TextboxNombreAñadirRevisor As TextBox
    Friend WithEvents TextboxIdRevisorAnadirRevisor As TextBox
End Class
