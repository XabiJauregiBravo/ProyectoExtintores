<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAñadirPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAñadirPedidos))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxIDPEDIDO = New System.Windows.Forms.TextBox()
        Me.TextBoxIDCLIENTE = New System.Windows.Forms.TextBox()
        Me.TextBoxIDREVISOR = New System.Windows.Forms.TextBox()
        Me.TextBoxDIRECCION = New System.Windows.Forms.TextBox()
        Me.ButtonAñadir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IDPEDIDO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IDREVISOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IDCLIENTE"
        '
        'TextBoxIDPEDIDO
        '
        Me.TextBoxIDPEDIDO.Location = New System.Drawing.Point(100, 42)
        Me.TextBoxIDPEDIDO.Name = "TextBoxIDPEDIDO"
        Me.TextBoxIDPEDIDO.Size = New System.Drawing.Size(214, 20)
        Me.TextBoxIDPEDIDO.TabIndex = 8
        '
        'TextBoxIDCLIENTE
        '
        Me.TextBoxIDCLIENTE.Location = New System.Drawing.Point(102, 176)
        Me.TextBoxIDCLIENTE.Name = "TextBoxIDCLIENTE"
        Me.TextBoxIDCLIENTE.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxIDCLIENTE.TabIndex = 14
        '
        'TextBoxIDREVISOR
        '
        Me.TextBoxIDREVISOR.Location = New System.Drawing.Point(104, 129)
        Me.TextBoxIDREVISOR.Name = "TextBoxIDREVISOR"
        Me.TextBoxIDREVISOR.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxIDREVISOR.TabIndex = 15
        '
        'TextBoxDIRECCION
        '
        Me.TextBoxDIRECCION.Location = New System.Drawing.Point(110, 86)
        Me.TextBoxDIRECCION.Name = "TextBoxDIRECCION"
        Me.TextBoxDIRECCION.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxDIRECCION.TabIndex = 16
        '
        'ButtonAñadir
        '
        Me.ButtonAñadir.BackColor = System.Drawing.Color.Black
        Me.ButtonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAñadir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAñadir.ForeColor = System.Drawing.Color.White
        Me.ButtonAñadir.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoañadir
        Me.ButtonAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAñadir.Location = New System.Drawing.Point(80, 224)
        Me.ButtonAñadir.Name = "ButtonAñadir"
        Me.ButtonAñadir.Size = New System.Drawing.Size(165, 54)
        Me.ButtonAñadir.TabIndex = 18
        Me.ButtonAñadir.Text = " Añadir"
        Me.ButtonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAñadir.UseVisualStyleBackColor = False
        '
        'FormAñadirPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(337, 299)
        Me.Controls.Add(Me.ButtonAñadir)
        Me.Controls.Add(Me.TextBoxDIRECCION)
        Me.Controls.Add(Me.TextBoxIDREVISOR)
        Me.Controls.Add(Me.TextBoxIDCLIENTE)
        Me.Controls.Add(Me.TextBoxIDPEDIDO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(353, 338)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(353, 338)
        Me.Name = "FormAñadirPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAñadirPedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxIDPEDIDO As TextBox
    Friend WithEvents TextBoxIDCLIENTE As TextBox
    Friend WithEvents TextBoxIDREVISOR As TextBox
    Friend WithEvents TextBoxDIRECCION As TextBox
    Friend WithEvents ButtonAñadir As Button
End Class
