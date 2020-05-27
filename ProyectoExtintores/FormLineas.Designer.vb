<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLineas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLineas))
        Me.botonEliminar = New System.Windows.Forms.Button()
        Me.botonEditar = New System.Windows.Forms.Button()
        Me.botonAñadir = New System.Windows.Forms.Button()
        Me.botonVerDatos = New System.Windows.Forms.Button()
        Me.TablaLineas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TablaLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botonEliminar
        '
        Me.botonEliminar.BackColor = System.Drawing.Color.Black
        Me.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEliminar.ForeColor = System.Drawing.Color.White
        Me.botonEliminar.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeliminar
        Me.botonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEliminar.Location = New System.Drawing.Point(790, 440)
        Me.botonEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEliminar.Name = "botonEliminar"
        Me.botonEliminar.Size = New System.Drawing.Size(167, 77)
        Me.botonEliminar.TabIndex = 23
        Me.botonEliminar.Text = "Eliminar"
        Me.botonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEliminar.UseVisualStyleBackColor = False
        '
        'botonEditar
        '
        Me.botonEditar.BackColor = System.Drawing.Color.Black
        Me.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEditar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEditar.ForeColor = System.Drawing.Color.White
        Me.botonEditar.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.botonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditar.Location = New System.Drawing.Point(790, 324)
        Me.botonEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEditar.Name = "botonEditar"
        Me.botonEditar.Size = New System.Drawing.Size(167, 77)
        Me.botonEditar.TabIndex = 22
        Me.botonEditar.Text = "Editar"
        Me.botonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonEditar.UseVisualStyleBackColor = False
        '
        'botonAñadir
        '
        Me.botonAñadir.BackColor = System.Drawing.Color.Black
        Me.botonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAñadir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAñadir.ForeColor = System.Drawing.Color.White
        Me.botonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(790, 206)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.Size = New System.Drawing.Size(167, 77)
        Me.botonAñadir.TabIndex = 21
        Me.botonAñadir.Text = "Añadir"
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'botonVerDatos
        '
        Me.botonVerDatos.BackColor = System.Drawing.Color.Black
        Me.botonVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonVerDatos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonVerDatos.ForeColor = System.Drawing.Color.White
        Me.botonVerDatos.Image = Global.ProyectoExtintores.My.Resources.Resources.actualizaricono
        Me.botonVerDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonVerDatos.Location = New System.Drawing.Point(790, 76)
        Me.botonVerDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonVerDatos.Name = "botonVerDatos"
        Me.botonVerDatos.Size = New System.Drawing.Size(167, 77)
        Me.botonVerDatos.TabIndex = 20
        Me.botonVerDatos.Text = "Actualizar Datos"
        Me.botonVerDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonVerDatos.UseVisualStyleBackColor = False
        '
        'TablaLineas
        '
        Me.TablaLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TablaLineas.BackgroundColor = System.Drawing.Color.White
        Me.TablaLineas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaLineas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaLineas.ColumnHeadersHeight = 60
        Me.TablaLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaLineas.DefaultCellStyle = DataGridViewCellStyle2
        Me.TablaLineas.Location = New System.Drawing.Point(13, 59)
        Me.TablaLineas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TablaLineas.Name = "TablaLineas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaLineas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaLineas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TablaLineas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.TablaLineas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaLineas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.TablaLineas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaLineas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaLineas.RowTemplate.Height = 30
        Me.TablaLineas.Size = New System.Drawing.Size(769, 482)
        Me.TablaLineas.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(696, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(314, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(375, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Buscador Lineas por IDPEDIDO:   "
        '
        'FormLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.botonEliminar)
        Me.Controls.Add(Me.botonEditar)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.botonVerDatos)
        Me.Controls.Add(Me.TablaLineas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(990, 573)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(990, 573)
        Me.Name = "FormLineas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Pedidos"
        CType(Me.TablaLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonEliminar As Button
    Friend WithEvents botonEditar As Button
    Friend WithEvents botonAñadir As Button
    Friend WithEvents botonVerDatos As Button
    Friend WithEvents TablaLineas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
