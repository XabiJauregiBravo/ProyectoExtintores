<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedores))
        Me.TablaProveedores = New System.Windows.Forms.DataGridView()
        Me.botonVerDatos = New System.Windows.Forms.Button()
        Me.botonEliminar = New System.Windows.Forms.Button()
        Me.botonEditar = New System.Windows.Forms.Button()
        Me.botonAñadir = New System.Windows.Forms.Button()
        CType(Me.TablaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaProveedores
        '
        Me.TablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TablaProveedores.BackgroundColor = System.Drawing.Color.White
        Me.TablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaProveedores.ColumnHeadersHeight = 60
        Me.TablaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaProveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.TablaProveedores.Location = New System.Drawing.Point(-4, 0)
        Me.TablaProveedores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TablaProveedores.Name = "TablaProveedores"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaProveedores.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TablaProveedores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.TablaProveedores.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaProveedores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.TablaProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaProveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaProveedores.RowTemplate.Height = 30
        Me.TablaProveedores.Size = New System.Drawing.Size(625, 548)
        Me.TablaProveedores.TabIndex = 2
        '
        'botonVerDatos
        '
        Me.botonVerDatos.BackColor = System.Drawing.Color.Black
        Me.botonVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonVerDatos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonVerDatos.ForeColor = System.Drawing.Color.White
        Me.botonVerDatos.Image = Global.ProyectoExtintores.My.Resources.Resources.actualizaricono
        Me.botonVerDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonVerDatos.Location = New System.Drawing.Point(629, 33)
        Me.botonVerDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonVerDatos.Name = "botonVerDatos"
        Me.botonVerDatos.Size = New System.Drawing.Size(167, 77)
        Me.botonVerDatos.TabIndex = 3
        Me.botonVerDatos.Text = "Actualizar Datos"
        Me.botonVerDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonVerDatos.UseVisualStyleBackColor = False
        '
        'botonEliminar
        '
        Me.botonEliminar.BackColor = System.Drawing.Color.Black
        Me.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEliminar.ForeColor = System.Drawing.Color.White
        Me.botonEliminar.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeliminar
        Me.botonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEliminar.Location = New System.Drawing.Point(629, 404)
        Me.botonEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEliminar.Name = "botonEliminar"
        Me.botonEliminar.Size = New System.Drawing.Size(167, 77)
        Me.botonEliminar.TabIndex = 8
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
        Me.botonEditar.Location = New System.Drawing.Point(629, 276)
        Me.botonEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEditar.Name = "botonEditar"
        Me.botonEditar.Size = New System.Drawing.Size(167, 77)
        Me.botonEditar.TabIndex = 7
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
        Me.botonAñadir.Location = New System.Drawing.Point(629, 157)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.Size = New System.Drawing.Size(167, 77)
        Me.botonAñadir.TabIndex = 6
        Me.botonAñadir.Text = "Añadir"
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'FormProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 545)
        Me.Controls.Add(Me.botonEliminar)
        Me.Controls.Add(Me.botonEditar)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.botonVerDatos)
        Me.Controls.Add(Me.TablaProveedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 584)
        Me.Name = "FormProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Proveedores"
        CType(Me.TablaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaProveedores As DataGridView
    Friend WithEvents botonVerDatos As Button
    Friend WithEvents botonAñadir As Button
    Friend WithEvents botonEditar As Button
    Friend WithEvents botonEliminar As Button
End Class
