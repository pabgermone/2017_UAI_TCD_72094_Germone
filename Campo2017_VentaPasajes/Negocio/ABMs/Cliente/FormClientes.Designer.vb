<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboClientes = New System.Windows.Forms.ComboBox()
        Me.LblNomAp = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblPasaporte = New System.Windows.Forms.Label()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboClientes
        '
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Location = New System.Drawing.Point(12, 12)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(312, 28)
        Me.ComboClientes.TabIndex = 0
        Me.ComboClientes.Text = "- Seleccione un Cliente -"
        '
        'LblNomAp
        '
        Me.LblNomAp.AutoSize = True
        Me.LblNomAp.Location = New System.Drawing.Point(8, 73)
        Me.LblNomAp.Name = "LblNomAp"
        Me.LblNomAp.Size = New System.Drawing.Size(144, 20)
        Me.LblNomAp.TabIndex = 1
        Me.LblNomAp.Text = "Nombre y Apellido: "
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(8, 114)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(45, 20)
        Me.LblDNI.TabIndex = 2
        Me.LblDNI.Text = "DNI: "
        '
        'LblPasaporte
        '
        Me.LblPasaporte.AutoSize = True
        Me.LblPasaporte.Location = New System.Drawing.Point(8, 155)
        Me.LblPasaporte.Name = "LblPasaporte"
        Me.LblPasaporte.Size = New System.Drawing.Size(90, 20)
        Me.LblPasaporte.TabIndex = 3
        Me.LblPasaporte.Text = "Pasaporte: "
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.Location = New System.Drawing.Point(8, 196)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(167, 20)
        Me.LblFechaNac.TabIndex = 4
        Me.LblFechaNac.Text = "Fecha de Nacimiento: "
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.Location = New System.Drawing.Point(8, 237)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(79, 20)
        Me.LblTel.TabIndex = 5
        Me.LblTel.Text = "Telefono: "
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(8, 278)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(53, 20)
        Me.LblSexo.TabIndex = 6
        Me.LblSexo.Text = "Sexo: "
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(12, 365)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(128, 30)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(196, 365)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(128, 30)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(8, 319)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(99, 20)
        Me.LblEstado.TabIndex = 9
        Me.LblEstado.Text = "Estado Civil: "
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 407)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblTel)
        Me.Controls.Add(Me.LblFechaNac)
        Me.Controls.Add(Me.LblPasaporte)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblNomAp)
        Me.Controls.Add(Me.ComboClientes)
        Me.Name = "FormClientes"
        Me.Text = "FormClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents LblNomAp As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblPasaporte As Label
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblEstado As Label
End Class
