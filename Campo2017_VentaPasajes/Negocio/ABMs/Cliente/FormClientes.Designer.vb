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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
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
        Me.ComboClientes.Location = New System.Drawing.Point(8, 8)
        Me.ComboClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(209, 21)
        Me.ComboClientes.TabIndex = 0
        Me.ComboClientes.Text = "- Seleccione un Cliente -"
        '
        'LblNomAp
        '
        Me.LblNomAp.AutoSize = True
        Me.LblNomAp.BackColor = System.Drawing.Color.Transparent
        Me.LblNomAp.Location = New System.Drawing.Point(5, 47)
        Me.LblNomAp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNomAp.Name = "LblNomAp"
        Me.LblNomAp.Size = New System.Drawing.Size(98, 13)
        Me.LblNomAp.TabIndex = 1
        Me.LblNomAp.Text = "Nombre y Apellido: "
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.BackColor = System.Drawing.Color.Transparent
        Me.LblDNI.Location = New System.Drawing.Point(5, 74)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(32, 13)
        Me.LblDNI.TabIndex = 2
        Me.LblDNI.Text = "DNI: "
        '
        'LblPasaporte
        '
        Me.LblPasaporte.AutoSize = True
        Me.LblPasaporte.BackColor = System.Drawing.Color.Transparent
        Me.LblPasaporte.Location = New System.Drawing.Point(5, 101)
        Me.LblPasaporte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPasaporte.Name = "LblPasaporte"
        Me.LblPasaporte.Size = New System.Drawing.Size(61, 13)
        Me.LblPasaporte.TabIndex = 3
        Me.LblPasaporte.Text = "Pasaporte: "
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNac.Location = New System.Drawing.Point(5, 127)
        Me.LblFechaNac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(114, 13)
        Me.LblFechaNac.TabIndex = 4
        Me.LblFechaNac.Text = "Fecha de Nacimiento: "
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.BackColor = System.Drawing.Color.Transparent
        Me.LblTel.Location = New System.Drawing.Point(5, 154)
        Me.LblTel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(55, 13)
        Me.LblTel.TabIndex = 5
        Me.LblTel.Text = "Telefono: "
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Location = New System.Drawing.Point(5, 181)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(37, 13)
        Me.LblSexo.TabIndex = 6
        Me.LblSexo.Text = "Sexo: "
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(8, 237)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(111, 41)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(131, 237)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(113, 41)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Location = New System.Drawing.Point(5, 207)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(68, 13)
        Me.LblEstado.TabIndex = 9
        Me.LblEstado.Text = "Estado Civil: "
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(548, 324)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
