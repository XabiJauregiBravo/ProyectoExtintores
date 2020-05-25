<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicial))
        Me.botonGenerarBD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botonIniciar = New System.Windows.Forms.Button()
        Me.botonGithub = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'botonGenerarBD
        '
        Me.botonGenerarBD.BackColor = System.Drawing.SystemColors.ControlText
        Me.botonGenerarBD.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.botonGenerarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonGenerarBD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonGenerarBD.ForeColor = System.Drawing.Color.White
        Me.botonGenerarBD.Location = New System.Drawing.Point(460, 375)
        Me.botonGenerarBD.Name = "botonGenerarBD"
        Me.botonGenerarBD.Size = New System.Drawing.Size(138, 82)
        Me.botonGenerarBD.TabIndex = 0
        Me.botonGenerarBD.Text = "Generar DB"
        Me.botonGenerarBD.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¡Bienvenid@!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(664, 209)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'botonIniciar
        '
        Me.botonIniciar.BackColor = System.Drawing.Color.Black
        Me.botonIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.botonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonIniciar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonIniciar.ForeColor = System.Drawing.Color.White
        Me.botonIniciar.Location = New System.Drawing.Point(300, 375)
        Me.botonIniciar.Name = "botonIniciar"
        Me.botonIniciar.Size = New System.Drawing.Size(138, 82)
        Me.botonIniciar.TabIndex = 3
        Me.botonIniciar.Text = "Iniciar"
        Me.botonIniciar.UseVisualStyleBackColor = False
        '
        'botonGithub
        '
        Me.botonGithub.BackColor = System.Drawing.Color.Black
        Me.botonGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.botonGithub.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.botonGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonGithub.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonGithub.ForeColor = System.Drawing.Color.White
        Me.botonGithub.Location = New System.Drawing.Point(140, 375)
        Me.botonGithub.Name = "botonGithub"
        Me.botonGithub.Size = New System.Drawing.Size(138, 82)
        Me.botonGithub.TabIndex = 4
        Me.botonGithub.Text = "GitHub"
        Me.botonGithub.UseVisualStyleBackColor = False
        '
        'FormInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 478)
        Me.Controls.Add(Me.botonGithub)
        Me.Controls.Add(Me.botonIniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonGenerarBD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto Extintores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonGenerarBD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents botonIniciar As Button
    Friend WithEvents botonGithub As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
