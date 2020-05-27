<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarTrabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarTrabajador))
        Me.BotonEditar = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.IDALMACEN = New System.Windows.Forms.Label()
        Me.TextboxNombreCompletoEditarRevisor = New System.Windows.Forms.TextBox()
        Me.TextboxIdRevisorEditarRevisor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDNIEditarRevisor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BotonEditar
        '
        Me.BotonEditar.BackColor = System.Drawing.Color.Black
        Me.BotonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonEditar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonEditar.ForeColor = System.Drawing.Color.White
        Me.BotonEditar.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.BotonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonEditar.Location = New System.Drawing.Point(78, 236)
        Me.BotonEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BotonEditar.Name = "BotonEditar"
        Me.BotonEditar.Size = New System.Drawing.Size(110, 41)
        Me.BotonEditar.TabIndex = 40
        Me.BotonEditar.Text = "Editar"
        Me.BotonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonEditar.UseVisualStyleBackColor = False
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.Color.Black
        Me.lblDNI.Location = New System.Drawing.Point(18, 187)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(27, 16)
        Me.lblDNI.TabIndex = 37
        Me.lblDNI.Text = "DNI"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(21, 136)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(62, 32)
        Me.Direccion.TabIndex = 36
        Me.Direccion.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completo"
        '
        'IDALMACEN
        '
        Me.IDALMACEN.AutoSize = True
        Me.IDALMACEN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDALMACEN.ForeColor = System.Drawing.Color.Black
        Me.IDALMACEN.Location = New System.Drawing.Point(7, 103)
        Me.IDALMACEN.Name = "IDALMACEN"
        Me.IDALMACEN.Size = New System.Drawing.Size(88, 16)
        Me.IDALMACEN.TabIndex = 35
        Me.IDALMACEN.Text = "IDTRABAJADOR"
        '
        'TextboxNombreCompletoEditarRevisor
        '
        Me.TextboxNombreCompletoEditarRevisor.Location = New System.Drawing.Point(101, 148)
        Me.TextboxNombreCompletoEditarRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxNombreCompletoEditarRevisor.Name = "TextboxNombreCompletoEditarRevisor"
        Me.TextboxNombreCompletoEditarRevisor.Size = New System.Drawing.Size(144, 20)
        Me.TextboxNombreCompletoEditarRevisor.TabIndex = 33
        '
        'TextboxIdRevisorEditarRevisor
        '
        Me.TextboxIdRevisorEditarRevisor.Location = New System.Drawing.Point(101, 101)
        Me.TextboxIdRevisorEditarRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextboxIdRevisorEditarRevisor.Name = "TextboxIdRevisorEditarRevisor"
        Me.TextboxIdRevisorEditarRevisor.Size = New System.Drawing.Size(144, 20)
        Me.TextboxIdRevisorEditarRevisor.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Editar Trabajador"
        '
        'TextBoxDNIEditarRevisor
        '
        Me.TextBoxDNIEditarRevisor.Location = New System.Drawing.Point(89, 185)
        Me.TextBoxDNIEditarRevisor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDNIEditarRevisor.Name = "TextBoxDNIEditarRevisor"
        Me.TextBoxDNIEditarRevisor.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDNIEditarRevisor.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(102, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Introduce un ID que ya exista:"
        '
        'FormEditarTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 300)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDNIEditarRevisor)
        Me.Controls.Add(Me.BotonEditar)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.IDALMACEN)
        Me.Controls.Add(Me.TextboxNombreCompletoEditarRevisor)
        Me.Controls.Add(Me.TextboxIdRevisorEditarRevisor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 339)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 339)
        Me.Name = "FormEditarTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Revisor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonEditar As Button
    Friend WithEvents lblDNI As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents IDALMACEN As Label
    Friend WithEvents TextboxNombreCompletoEditarRevisor As TextBox
    Friend WithEvents TextboxIdRevisorEditarRevisor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDNIEditarRevisor As TextBox
    Friend WithEvents Label2 As Label
End Class
