﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarPedido))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxPRECIOUNIDAD = New System.Windows.Forms.ComboBox()
        Me.TextBoxDIRECCION = New System.Windows.Forms.TextBox()
        Me.TextBoxIDREVISOR = New System.Windows.Forms.TextBox()
        Me.TextBoxIDCLIENTE = New System.Windows.Forms.TextBox()
        Me.TextBoxIDPRODUCTO = New System.Windows.Forms.TextBox()
        Me.TextBoxCANTIDAD = New System.Windows.Forms.TextBox()
        Me.TextBoxIDPEDIDO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.ProyectoExtintores.My.Resources.Resources.iconoeditar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(72, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 54)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Editar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBoxPRECIOUNIDAD
        '
        Me.ComboBoxPRECIOUNIDAD.FormattingEnabled = True
        Me.ComboBoxPRECIOUNIDAD.Items.AddRange(New Object() {"6", "8"})
        Me.ComboBoxPRECIOUNIDAD.Location = New System.Drawing.Point(113, 255)
        Me.ComboBoxPRECIOUNIDAD.Name = "ComboBoxPRECIOUNIDAD"
        Me.ComboBoxPRECIOUNIDAD.Size = New System.Drawing.Size(179, 21)
        Me.ComboBoxPRECIOUNIDAD.TabIndex = 32
        '
        'TextBoxDIRECCION
        '
        Me.TextBoxDIRECCION.Location = New System.Drawing.Point(89, 62)
        Me.TextBoxDIRECCION.Name = "TextBoxDIRECCION"
        Me.TextBoxDIRECCION.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxDIRECCION.TabIndex = 31
        '
        'TextBoxIDREVISOR
        '
        Me.TextBoxIDREVISOR.Location = New System.Drawing.Point(83, 105)
        Me.TextBoxIDREVISOR.Name = "TextBoxIDREVISOR"
        Me.TextBoxIDREVISOR.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxIDREVISOR.TabIndex = 30
        '
        'TextBoxIDCLIENTE
        '
        Me.TextBoxIDCLIENTE.Location = New System.Drawing.Point(81, 152)
        Me.TextBoxIDCLIENTE.Name = "TextBoxIDCLIENTE"
        Me.TextBoxIDCLIENTE.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxIDCLIENTE.TabIndex = 29
        '
        'TextBoxIDPRODUCTO
        '
        Me.TextBoxIDPRODUCTO.Location = New System.Drawing.Point(101, 304)
        Me.TextBoxIDPRODUCTO.Name = "TextBoxIDPRODUCTO"
        Me.TextBoxIDPRODUCTO.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxIDPRODUCTO.TabIndex = 28
        '
        'TextBoxCANTIDAD
        '
        Me.TextBoxCANTIDAD.Location = New System.Drawing.Point(81, 199)
        Me.TextBoxCANTIDAD.Name = "TextBoxCANTIDAD"
        Me.TextBoxCANTIDAD.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxCANTIDAD.TabIndex = 27
        '
        'TextBoxIDPEDIDO
        '
        Me.TextBoxIDPEDIDO.Location = New System.Drawing.Point(79, 18)
        Me.TextBoxIDPEDIDO.Name = "TextBoxIDPEDIDO"
        Me.TextBoxIDPEDIDO.Size = New System.Drawing.Size(214, 20)
        Me.TextBoxIDPEDIDO.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "IDPRODUCTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "PRECIO UNIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "CANTIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "IDCLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "IDREVISOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "DIRECCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "IDPEDIDO"
        '
        'FormEditarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 424)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxPRECIOUNIDAD)
        Me.Controls.Add(Me.TextBoxDIRECCION)
        Me.Controls.Add(Me.TextBoxIDREVISOR)
        Me.Controls.Add(Me.TextBoxIDCLIENTE)
        Me.Controls.Add(Me.TextBoxIDPRODUCTO)
        Me.Controls.Add(Me.TextBoxCANTIDAD)
        Me.Controls.Add(Me.TextBoxIDPEDIDO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(336, 463)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(336, 463)
        Me.Name = "FormEditarPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxPRECIOUNIDAD As ComboBox
    Friend WithEvents TextBoxDIRECCION As TextBox
    Friend WithEvents TextBoxIDREVISOR As TextBox
    Friend WithEvents TextBoxIDCLIENTE As TextBox
    Friend WithEvents TextBoxIDPRODUCTO As TextBox
    Friend WithEvents TextBoxCANTIDAD As TextBox
    Friend WithEvents TextBoxIDPEDIDO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class