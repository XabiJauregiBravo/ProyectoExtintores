<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlmacenes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlmacenes))
        Me.botonVerDatos = New System.Windows.Forms.Button()
        Me.TablaAlmacenes = New System.Windows.Forms.DataGridView()
        Me.botonEliminar = New System.Windows.Forms.Button()
        Me.botonEditar = New System.Windows.Forms.Button()
        Me.botonAñadir = New System.Windows.Forms.Button()
        CType(Me.TablaAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botonVerDatos
        '
        Me.botonVerDatos.BackColor = System.Drawing.Color.Black
        Me.botonVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonVerDatos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonVerDatos.ForeColor = System.Drawing.Color.White

        Me.botonVerDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonVerDatos.Location = New System.Drawing.Point(631, 33)
        Me.botonVerDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonVerDatos.Name = "botonVerDatos"
        Me.botonVerDatos.Size = New System.Drawing.Size(165, 77)
        Me.botonVerDatos.TabIndex = 0
        Me.botonVerDatos.Text = "Actualizar Datos"
        Me.botonVerDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonVerDatos.UseVisualStyleBackColor = False
        '
        'TablaAlmacenes
        '
        Me.TablaAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TablaAlmacenes.BackgroundColor = System.Drawing.Color.White
        Me.TablaAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaAlmacenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaAlmacenes.ColumnHeadersHeight = 60
        Me.TablaAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaAlmacenes.DefaultCellStyle = DataGridViewCellStyle2
        Me.TablaAlmacenes.Location = New System.Drawing.Point(0, 0)
        Me.TablaAlmacenes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TablaAlmacenes.Name = "TablaAlmacenes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaAlmacenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaAlmacenes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TablaAlmacenes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.TablaAlmacenes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaAlmacenes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.TablaAlmacenes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaAlmacenes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.TablaAlmacenes.RowTemplate.Height = 30
        Me.TablaAlmacenes.Size = New System.Drawing.Size(585, 548)
        Me.TablaAlmacenes.TabIndex = 1
        '
        'botonEliminar
        '
        Me.botonEliminar.BackColor = System.Drawing.Color.Black
        Me.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEliminar.ForeColor = System.Drawing.Color.White

        Me.botonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEliminar.Location = New System.Drawing.Point(631, 419)
        Me.botonEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEliminar.Name = "botonEliminar"
        Me.botonEliminar.Size = New System.Drawing.Size(165, 77)
        Me.botonEliminar.TabIndex = 3
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
        Me.botonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonEditar.Location = New System.Drawing.Point(631, 298)
        Me.botonEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonEditar.Name = "botonEditar"
        Me.botonEditar.Size = New System.Drawing.Size(165, 77)
        Me.botonEditar.TabIndex = 4
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
        Me.botonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonAñadir.Location = New System.Drawing.Point(631, 156)
        Me.botonAñadir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonAñadir.Name = "botonAñadir"
        Me.botonAñadir.Size = New System.Drawing.Size(165, 77)
        Me.botonAñadir.TabIndex = 5
        Me.botonAñadir.Text = "Añadir"
        Me.botonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAñadir.UseVisualStyleBackColor = False
        '
        'FormAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 545)
        Me.Controls.Add(Me.botonAñadir)
        Me.Controls.Add(Me.botonEditar)
        Me.Controls.Add(Me.botonEliminar)
        Me.Controls.Add(Me.TablaAlmacenes)
        Me.Controls.Add(Me.botonVerDatos)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 2000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 584)
        Me.Name = "FormAlmacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Almacenes"
        CType(Me.TablaAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents botonVerDatos As Button
    Friend WithEvents TablaAlmacenes As DataGridView
    Friend WithEvents botonEliminar As Button
    Friend WithEvents botonEditar As Button
    Friend WithEvents botonAñadir As Button
End Class
