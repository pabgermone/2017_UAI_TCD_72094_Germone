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
        Me.TxtTipoDoc = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblTipoDoc = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.DateTimeFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxtNumDoc = New System.Windows.Forms.TextBox()
        Me.TxtPasaporte = New System.Windows.Forms.TextBox()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCodPostal = New System.Windows.Forms.TextBox()
        Me.LstTelefonos = New System.Windows.Forms.ListBox()
        Me.LstMails = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAgregarTel = New System.Windows.Forms.Button()
        Me.BtnQuitarTel = New System.Windows.Forms.Button()
        Me.BtnQuitarMail = New System.Windows.Forms.Button()
        Me.BtnAgregarMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(124, 448)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(158, 44)
        Me.BtnNuevo.TabIndex = 50
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtTipoDoc
        '
        Me.TxtTipoDoc.Location = New System.Drawing.Point(11, 109)
        Me.TxtTipoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTipoDoc.Name = "TxtTipoDoc"
        Me.TxtTipoDoc.Size = New System.Drawing.Size(181, 20)
        Me.TxtTipoDoc.TabIndex = 39
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(11, 65)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(181, 20)
        Me.TxtApellido.TabIndex = 33
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(11, 21)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(181, 20)
        Me.TxtNombre.TabIndex = 32
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNac.Location = New System.Drawing.Point(8, 227)
        Me.LblFechaNac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(114, 13)
        Me.LblFechaNac.TabIndex = 28
        Me.LblFechaNac.Text = "Fecha de Nacimiento: "
        '
        'LblTipoDoc
        '
        Me.LblTipoDoc.AutoSize = True
        Me.LblTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoDoc.Location = New System.Drawing.Point(8, 94)
        Me.LblTipoDoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipoDoc.Name = "LblTipoDoc"
        Me.LblTipoDoc.Size = New System.Drawing.Size(104, 13)
        Me.LblTipoDoc.TabIndex = 27
        Me.LblTipoDoc.Text = "Tipo de Documento:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Location = New System.Drawing.Point(8, 50)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(47, 13)
        Me.LblApellido.TabIndex = 26
        Me.LblApellido.Text = "Apellido:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(8, 6)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 25
        Me.LblNombre.Text = "Nombre:"
        '
        'DateTimeFechaNac
        '
        Me.DateTimeFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaNac.Location = New System.Drawing.Point(11, 241)
        Me.DateTimeFechaNac.MinDate = New Date(1810, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaNac.Name = "DateTimeFechaNac"
        Me.DateTimeFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimeFechaNac.Size = New System.Drawing.Size(181, 20)
        Me.DateTimeFechaNac.TabIndex = 42
        '
        'TxtNumDoc
        '
        Me.TxtNumDoc.Location = New System.Drawing.Point(11, 153)
        Me.TxtNumDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumDoc.Name = "TxtNumDoc"
        Me.TxtNumDoc.Size = New System.Drawing.Size(181, 20)
        Me.TxtNumDoc.TabIndex = 40
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(11, 197)
        Me.TxtPasaporte.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(181, 20)
        Me.TxtPasaporte.TabIndex = 41
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(11, 285)
        Me.TxtPais.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(181, 20)
        Me.TxtPais.TabIndex = 43
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(11, 329)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(181, 20)
        Me.TxtDireccion.TabIndex = 44
        '
        'TxtCodPostal
        '
        Me.TxtCodPostal.Location = New System.Drawing.Point(11, 373)
        Me.TxtCodPostal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodPostal.Name = "TxtCodPostal"
        Me.TxtCodPostal.Size = New System.Drawing.Size(181, 20)
        Me.TxtCodPostal.TabIndex = 45
        '
        'LstTelefonos
        '
        Me.LstTelefonos.FormattingEnabled = True
        Me.LstTelefonos.Location = New System.Drawing.Point(229, 21)
        Me.LstTelefonos.Name = "LstTelefonos"
        Me.LstTelefonos.Size = New System.Drawing.Size(165, 147)
        Me.LstTelefonos.TabIndex = 56
        '
        'LstMails
        '
        Me.LstMails.FormattingEnabled = True
        Me.LstMails.Location = New System.Drawing.Point(229, 241)
        Me.LstMails.Name = "LstMails"
        Me.LstMails.Size = New System.Drawing.Size(165, 147)
        Me.LstMails.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Numero de Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Pasaporte:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Pais:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 314)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(8, 358)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Codigo Postal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(226, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Telefonos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(226, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "e-Mails:"
        '
        'BtnAgregarTel
        '
        Me.BtnAgregarTel.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAgregarTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarTel.Location = New System.Drawing.Point(229, 172)
        Me.BtnAgregarTel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarTel.Name = "BtnAgregarTel"
        Me.BtnAgregarTel.Size = New System.Drawing.Size(75, 33)
        Me.BtnAgregarTel.TabIndex = 46
        Me.BtnAgregarTel.Text = "Agregar"
        Me.BtnAgregarTel.UseVisualStyleBackColor = False
        '
        'BtnQuitarTel
        '
        Me.BtnQuitarTel.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnQuitarTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarTel.Location = New System.Drawing.Point(320, 173)
        Me.BtnQuitarTel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnQuitarTel.Name = "BtnQuitarTel"
        Me.BtnQuitarTel.Size = New System.Drawing.Size(75, 33)
        Me.BtnQuitarTel.TabIndex = 47
        Me.BtnQuitarTel.Text = "Quitar"
        Me.BtnQuitarTel.UseVisualStyleBackColor = False
        '
        'BtnQuitarMail
        '
        Me.BtnQuitarMail.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnQuitarMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarMail.Location = New System.Drawing.Point(320, 394)
        Me.BtnQuitarMail.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnQuitarMail.Name = "BtnQuitarMail"
        Me.BtnQuitarMail.Size = New System.Drawing.Size(75, 33)
        Me.BtnQuitarMail.TabIndex = 49
        Me.BtnQuitarMail.Text = "Quitar"
        Me.BtnQuitarMail.UseVisualStyleBackColor = False
        '
        'BtnAgregarMail
        '
        Me.BtnAgregarMail.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAgregarMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarMail.Location = New System.Drawing.Point(229, 393)
        Me.BtnAgregarMail.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarMail.Name = "BtnAgregarMail"
        Me.BtnAgregarMail.Size = New System.Drawing.Size(75, 33)
        Me.BtnAgregarMail.TabIndex = 48
        Me.BtnAgregarMail.Text = "Agregar"
        Me.BtnAgregarMail.UseVisualStyleBackColor = False
        '
        'AltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(406, 503)
        Me.Controls.Add(Me.BtnQuitarMail)
        Me.Controls.Add(Me.BtnAgregarMail)
        Me.Controls.Add(Me.BtnQuitarTel)
        Me.Controls.Add(Me.BtnAgregarTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstMails)
        Me.Controls.Add(Me.LstTelefonos)
        Me.Controls.Add(Me.TxtCodPostal)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.TxtPasaporte)
        Me.Controls.Add(Me.TxtNumDoc)
        Me.Controls.Add(Me.DateTimeFechaNac)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtTipoDoc)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblFechaNac)
        Me.Controls.Add(Me.LblTipoDoc)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AltaCliente"
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtTipoDoc As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblTipoDoc As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents DateTimeFechaNac As DateTimePicker
    Friend WithEvents TxtNumDoc As TextBox
    Friend WithEvents TxtPasaporte As TextBox
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCodPostal As TextBox
    Friend WithEvents LstTelefonos As ListBox
    Friend WithEvents LstMails As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAgregarTel As Button
    Friend WithEvents BtnQuitarTel As Button
    Friend WithEvents BtnQuitarMail As Button
    Friend WithEvents BtnAgregarMail As Button
End Class
