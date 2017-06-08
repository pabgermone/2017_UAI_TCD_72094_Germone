<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCliente))
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblPasaporte = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNomAp = New System.Windows.Forms.Label()
        Me.TxtNomAp = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtPasaporte = New System.Windows.Forms.TextBox()
        Me.TxtFechaNac = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.LinkEliminar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Location = New System.Drawing.Point(8, 255)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(68, 13)
        Me.LblEstado.TabIndex = 16
        Me.LblEstado.Text = "Estado Civil: "
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Location = New System.Drawing.Point(8, 214)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(37, 13)
        Me.LblSexo.TabIndex = 15
        Me.LblSexo.Text = "Sexo: "
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.BackColor = System.Drawing.Color.Transparent
        Me.LblTel.Location = New System.Drawing.Point(8, 172)
        Me.LblTel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(55, 13)
        Me.LblTel.TabIndex = 14
        Me.LblTel.Text = "Telefono: "
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNac.Location = New System.Drawing.Point(8, 131)
        Me.LblFechaNac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(114, 13)
        Me.LblFechaNac.TabIndex = 13
        Me.LblFechaNac.Text = "Fecha de Nacimiento: "
        '
        'LblPasaporte
        '
        Me.LblPasaporte.AutoSize = True
        Me.LblPasaporte.BackColor = System.Drawing.Color.Transparent
        Me.LblPasaporte.Location = New System.Drawing.Point(8, 89)
        Me.LblPasaporte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPasaporte.Name = "LblPasaporte"
        Me.LblPasaporte.Size = New System.Drawing.Size(61, 13)
        Me.LblPasaporte.TabIndex = 12
        Me.LblPasaporte.Text = "Pasaporte: "
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.BackColor = System.Drawing.Color.Transparent
        Me.LblDNI.Location = New System.Drawing.Point(8, 47)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(32, 13)
        Me.LblDNI.TabIndex = 11
        Me.LblDNI.Text = "DNI: "
        '
        'LblNomAp
        '
        Me.LblNomAp.AutoSize = True
        Me.LblNomAp.BackColor = System.Drawing.Color.Transparent
        Me.LblNomAp.Location = New System.Drawing.Point(8, 6)
        Me.LblNomAp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNomAp.Name = "LblNomAp"
        Me.LblNomAp.Size = New System.Drawing.Size(98, 13)
        Me.LblNomAp.TabIndex = 10
        Me.LblNomAp.Text = "Nombre y Apellido: "
        '
        'TxtNomAp
        '
        Me.TxtNomAp.Location = New System.Drawing.Point(11, 21)
        Me.TxtNomAp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNomAp.Name = "TxtNomAp"
        Me.TxtNomAp.Size = New System.Drawing.Size(181, 20)
        Me.TxtNomAp.TabIndex = 17
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(11, 62)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(181, 20)
        Me.TxtDNI.TabIndex = 18
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(11, 104)
        Me.TxtPasaporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(181, 20)
        Me.TxtPasaporte.TabIndex = 19
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Location = New System.Drawing.Point(11, 146)
        Me.TxtFechaNac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(181, 20)
        Me.TxtFechaNac.TabIndex = 20
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(11, 187)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(181, 20)
        Me.TxtTel.TabIndex = 21
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(11, 229)
        Me.TxtSexo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(181, 20)
        Me.TxtSexo.TabIndex = 22
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(8, 270)
        Me.TxtEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(181, 20)
        Me.TxtEstado.TabIndex = 23
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(33, 294)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(138, 38)
        Me.BtnEditar.TabIndex = 24
        Me.BtnEditar.Text = "Guardar Cambios"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'LinkEliminar
        '
        Me.LinkEliminar.AutoSize = True
        Me.LinkEliminar.BackColor = System.Drawing.Color.Transparent
        Me.LinkEliminar.LinkColor = System.Drawing.Color.Red
        Me.LinkEliminar.Location = New System.Drawing.Point(61, 341)
        Me.LinkEliminar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkEliminar.Name = "LinkEliminar"
        Me.LinkEliminar.Size = New System.Drawing.Size(72, 13)
        Me.LinkEliminar.TabIndex = 25
        Me.LinkEliminar.TabStop = True
        Me.LinkEliminar.Text = "Eliminar datos"
        '
        'ModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(218, 373)
        Me.Controls.Add(Me.LinkEliminar)
        Me.Controls.Add(Me.BtnEditar)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ModificarCliente"
        Me.Text = "ModificarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEstado As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblPasaporte As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblNomAp As Label
    Friend WithEvents TxtNomAp As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtPasaporte As TextBox
    Friend WithEvents TxtFechaNac As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents LinkEliminar As LinkLabel
End Class
