<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaVuelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaVuelo))
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtNroVuelo = New System.Windows.Forms.TextBox()
        Me.LblDestino = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblNroVuelo = New System.Windows.Forms.Label()
        Me.ComboDestinos = New System.Windows.Forms.ComboBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(42, 347)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(213, 65)
        Me.BtnNuevo.TabIndex = 54
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtHora
        '
        Me.TxtHora.Location = New System.Drawing.Point(16, 160)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(270, 26)
        Me.TxtHora.TabIndex = 49
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(16, 95)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(270, 26)
        Me.TxtFecha.TabIndex = 48
        '
        'TxtNroVuelo
        '
        Me.TxtNroVuelo.Location = New System.Drawing.Point(16, 32)
        Me.TxtNroVuelo.Name = "TxtNroVuelo"
        Me.TxtNroVuelo.Size = New System.Drawing.Size(270, 26)
        Me.TxtNroVuelo.TabIndex = 47
        '
        'LblDestino
        '
        Me.LblDestino.AutoSize = True
        Me.LblDestino.BackColor = System.Drawing.Color.Transparent
        Me.LblDestino.Location = New System.Drawing.Point(12, 202)
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Size = New System.Drawing.Size(68, 20)
        Me.LblDestino.TabIndex = 43
        Me.LblDestino.Text = "Destino:"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Location = New System.Drawing.Point(12, 137)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(48, 20)
        Me.LblHora.TabIndex = 42
        Me.LblHora.Text = "Hora:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Location = New System.Drawing.Point(12, 72)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(58, 20)
        Me.LblFecha.TabIndex = 41
        Me.LblFecha.Text = "Fecha:"
        '
        'LblNroVuelo
        '
        Me.LblNroVuelo.AutoSize = True
        Me.LblNroVuelo.BackColor = System.Drawing.Color.Transparent
        Me.LblNroVuelo.Location = New System.Drawing.Point(12, 9)
        Me.LblNroVuelo.Name = "LblNroVuelo"
        Me.LblNroVuelo.Size = New System.Drawing.Size(132, 20)
        Me.LblNroVuelo.TabIndex = 40
        Me.LblNroVuelo.Text = "Numero de vuelo:"
        '
        'ComboDestinos
        '
        Me.ComboDestinos.FormattingEnabled = True
        Me.ComboDestinos.Location = New System.Drawing.Point(16, 225)
        Me.ComboDestinos.Name = "ComboDestinos"
        Me.ComboDestinos.Size = New System.Drawing.Size(270, 28)
        Me.ComboDestinos.TabIndex = 55
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(16, 294)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(270, 26)
        Me.TxtPrecio.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Precio:"
        '
        'AltaVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(308, 424)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboDestinos)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtHora)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtNroVuelo)
        Me.Controls.Add(Me.LblDestino)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblNroVuelo)
        Me.Name = "AltaVuelo"
        Me.Text = "AltaVuelo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents TxtNroVuelo As TextBox
    Friend WithEvents LblDestino As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblNroVuelo As Label
    Friend WithEvents ComboDestinos As ComboBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label1 As Label
End Class
