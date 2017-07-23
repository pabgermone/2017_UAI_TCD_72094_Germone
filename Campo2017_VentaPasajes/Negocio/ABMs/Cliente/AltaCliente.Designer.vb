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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaCliente))
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtPasaporte = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtNomAp = New System.Windows.Forms.TextBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblPasaporte = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNomAp = New System.Windows.Forms.Label()
        Me.RadioMasculino = New System.Windows.Forms.RadioButton()
        Me.RadioFemenino = New System.Windows.Forms.RadioButton()
        Me.DateTimeFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 260)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(158, 44)
        Me.BtnNuevo.TabIndex = 39
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(11, 187)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(181, 20)
        Me.TxtTel.TabIndex = 36
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(11, 104)
        Me.TxtPasaporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(181, 20)
        Me.TxtPasaporte.TabIndex = 34
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(11, 62)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(181, 20)
        Me.TxtDNI.TabIndex = 33
        '
        'TxtNomAp
        '
        Me.TxtNomAp.Location = New System.Drawing.Point(11, 21)
        Me.TxtNomAp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNomAp.Name = "TxtNomAp"
        Me.TxtNomAp.Size = New System.Drawing.Size(181, 20)
        Me.TxtNomAp.TabIndex = 32
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Location = New System.Drawing.Point(8, 222)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(37, 13)
        Me.LblSexo.TabIndex = 30
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
        Me.LblTel.TabIndex = 29
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
        Me.LblFechaNac.TabIndex = 28
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
        Me.LblPasaporte.TabIndex = 27
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
        Me.LblDNI.TabIndex = 26
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
        Me.LblNomAp.TabIndex = 25
        Me.LblNomAp.Text = "Nombre y Apellido: "
        '
        'RadioMasculino
        '
        Me.RadioMasculino.AutoSize = True
        Me.RadioMasculino.BackColor = System.Drawing.Color.Transparent
        Me.RadioMasculino.Checked = True
        Me.RadioMasculino.Location = New System.Drawing.Point(56, 222)
        Me.RadioMasculino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioMasculino.Name = "RadioMasculino"
        Me.RadioMasculino.Size = New System.Drawing.Size(34, 17)
        Me.RadioMasculino.TabIndex = 40
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "M"
        Me.RadioMasculino.UseVisualStyleBackColor = False
        '
        'RadioFemenino
        '
        Me.RadioFemenino.AutoSize = True
        Me.RadioFemenino.BackColor = System.Drawing.Color.Transparent
        Me.RadioFemenino.Location = New System.Drawing.Point(125, 222)
        Me.RadioFemenino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioFemenino.Name = "RadioFemenino"
        Me.RadioFemenino.Size = New System.Drawing.Size(31, 17)
        Me.RadioFemenino.TabIndex = 41
        Me.RadioFemenino.Text = "F"
        Me.RadioFemenino.UseVisualStyleBackColor = False
        '
        'DateTimeFechaNac
        '
        Me.DateTimeFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaNac.Location = New System.Drawing.Point(11, 147)
        Me.DateTimeFechaNac.MinDate = New Date(1810, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaNac.Name = "DateTimeFechaNac"
        Me.DateTimeFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimeFechaNac.Size = New System.Drawing.Size(181, 20)
        Me.DateTimeFechaNac.TabIndex = 42
        '
        'AltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(205, 310)
        Me.Controls.Add(Me.DateTimeFechaNac)
        Me.Controls.Add(Me.RadioFemenino)
        Me.Controls.Add(Me.RadioMasculino)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.TxtPasaporte)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtNomAp)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblTel)
        Me.Controls.Add(Me.LblFechaNac)
        Me.Controls.Add(Me.LblPasaporte)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblNomAp)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AltaCliente"
        Me.Text = "AltaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtPasaporte As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtNomAp As TextBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblPasaporte As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblNomAp As Label
    Friend WithEvents RadioMasculino As RadioButton
    Friend WithEvents RadioFemenino As RadioButton
    Friend WithEvents DateTimeFechaNac As DateTimePicker
End Class
