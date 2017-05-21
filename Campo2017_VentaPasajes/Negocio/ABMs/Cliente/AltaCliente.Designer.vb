<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaCliente
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtFechaNac = New System.Windows.Forms.TextBox()
        Me.TxtPasaporte = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtNomAp = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblPasaporte = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNomAp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(47, 463)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(199, 30)
        Me.BtnNuevo.TabIndex = 39
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(12, 416)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(269, 26)
        Me.TxtEstado.TabIndex = 38
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(16, 352)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(269, 26)
        Me.TxtSexo.TabIndex = 37
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(16, 288)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(269, 26)
        Me.TxtTel.TabIndex = 36
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Location = New System.Drawing.Point(16, 224)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(269, 26)
        Me.TxtFechaNac.TabIndex = 35
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(16, 160)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(269, 26)
        Me.TxtPasaporte.TabIndex = 34
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(16, 96)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(269, 26)
        Me.TxtDNI.TabIndex = 33
        '
        'TxtNomAp
        '
        Me.TxtNomAp.Location = New System.Drawing.Point(16, 32)
        Me.TxtNomAp.Name = "TxtNomAp"
        Me.TxtNomAp.Size = New System.Drawing.Size(269, 26)
        Me.TxtNomAp.TabIndex = 32
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(12, 393)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(99, 20)
        Me.LblEstado.TabIndex = 31
        Me.LblEstado.Text = "Estado Civil: "
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(12, 329)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(53, 20)
        Me.LblSexo.TabIndex = 30
        Me.LblSexo.Text = "Sexo: "
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.Location = New System.Drawing.Point(12, 265)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(79, 20)
        Me.LblTel.TabIndex = 29
        Me.LblTel.Text = "Telefono: "
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.Location = New System.Drawing.Point(12, 201)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(167, 20)
        Me.LblFechaNac.TabIndex = 28
        Me.LblFechaNac.Text = "Fecha de Nacimiento: "
        '
        'LblPasaporte
        '
        Me.LblPasaporte.AutoSize = True
        Me.LblPasaporte.Location = New System.Drawing.Point(12, 137)
        Me.LblPasaporte.Name = "LblPasaporte"
        Me.LblPasaporte.Size = New System.Drawing.Size(90, 20)
        Me.LblPasaporte.TabIndex = 27
        Me.LblPasaporte.Text = "Pasaporte: "
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(12, 73)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(45, 20)
        Me.LblDNI.TabIndex = 26
        Me.LblDNI.Text = "DNI: "
        '
        'LblNomAp
        '
        Me.LblNomAp.AutoSize = True
        Me.LblNomAp.Location = New System.Drawing.Point(12, 9)
        Me.LblNomAp.Name = "LblNomAp"
        Me.LblNomAp.Size = New System.Drawing.Size(144, 20)
        Me.LblNomAp.TabIndex = 25
        Me.LblNomAp.Text = "Nombre y Apellido: "
        '
        'AltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 499)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.TxtSexo)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.TxtFechaNac)
        Me.Controls.Add(Me.TxtPasaporte)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtNomAp)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblTel)
        Me.Controls.Add(Me.LblFechaNac)
        Me.Controls.Add(Me.LblPasaporte)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblNomAp)
        Me.Name = "AltaCliente"
        Me.Text = "AltaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtFechaNac As TextBox
    Friend WithEvents TxtPasaporte As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtNomAp As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblPasaporte As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblNomAp As Label
End Class
