<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVuelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarVuelo))
        Me.ComboDestinos = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtNroVuelo = New System.Windows.Forms.TextBox()
        Me.LblDestino = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblNroVuelo = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboDestinos
        '
        Me.ComboDestinos.FormattingEnabled = True
        Me.ComboDestinos.Location = New System.Drawing.Point(11, 146)
        Me.ComboDestinos.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboDestinos.Name = "ComboDestinos"
        Me.ComboDestinos.Size = New System.Drawing.Size(181, 21)
        Me.ComboDestinos.TabIndex = 64
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(37, 217)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(129, 43)
        Me.BtnNuevo.TabIndex = 63
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtHora
        '
        Me.TxtHora.Location = New System.Drawing.Point(11, 104)
        Me.TxtHora.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(181, 20)
        Me.TxtHora.TabIndex = 62
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(11, 62)
        Me.TxtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(181, 20)
        Me.TxtFecha.TabIndex = 61
        '
        'TxtNroVuelo
        '
        Me.TxtNroVuelo.Location = New System.Drawing.Point(11, 21)
        Me.TxtNroVuelo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNroVuelo.Name = "TxtNroVuelo"
        Me.TxtNroVuelo.Size = New System.Drawing.Size(181, 20)
        Me.TxtNroVuelo.TabIndex = 60
        '
        'LblDestino
        '
        Me.LblDestino.AutoSize = True
        Me.LblDestino.BackColor = System.Drawing.Color.Transparent
        Me.LblDestino.Location = New System.Drawing.Point(8, 131)
        Me.LblDestino.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Size = New System.Drawing.Size(46, 13)
        Me.LblDestino.TabIndex = 59
        Me.LblDestino.Text = "Destino:"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Location = New System.Drawing.Point(8, 89)
        Me.LblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(33, 13)
        Me.LblHora.TabIndex = 58
        Me.LblHora.Text = "Hora:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Location = New System.Drawing.Point(8, 47)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(40, 13)
        Me.LblFecha.TabIndex = 57
        Me.LblFecha.Text = "Fecha:"
        '
        'LblNroVuelo
        '
        Me.LblNroVuelo.AutoSize = True
        Me.LblNroVuelo.BackColor = System.Drawing.Color.Transparent
        Me.LblNroVuelo.Location = New System.Drawing.Point(8, 6)
        Me.LblNroVuelo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNroVuelo.Name = "LblNroVuelo"
        Me.LblNroVuelo.Size = New System.Drawing.Size(91, 13)
        Me.LblNroVuelo.TabIndex = 56
        Me.LblNroVuelo.Text = "Numero de vuelo:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(11, 184)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(181, 20)
        Me.TxtPrecio.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Precio:"
        '
        'ModificarVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(205, 273)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModificarVuelo"
        Me.Text = "ModificarVuelo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboDestinos As ComboBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents TxtNroVuelo As TextBox
    Friend WithEvents LblDestino As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblNroVuelo As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label1 As Label
End Class
