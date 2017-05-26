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
        Me.ComboDestinos = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtNroVuelo = New System.Windows.Forms.TextBox()
        Me.LblDestino = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblNroVuelo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboDestinos
        '
        Me.ComboDestinos.FormattingEnabled = True
        Me.ComboDestinos.Location = New System.Drawing.Point(16, 224)
        Me.ComboDestinos.Name = "ComboDestinos"
        Me.ComboDestinos.Size = New System.Drawing.Size(269, 28)
        Me.ComboDestinos.TabIndex = 64
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(51, 276)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(199, 36)
        Me.BtnNuevo.TabIndex = 63
        Me.BtnNuevo.Text = "Guardar"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtHora
        '
        Me.TxtHora.Location = New System.Drawing.Point(16, 160)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(269, 26)
        Me.TxtHora.TabIndex = 62
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(16, 96)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(269, 26)
        Me.TxtFecha.TabIndex = 61
        '
        'TxtNroVuelo
        '
        Me.TxtNroVuelo.Location = New System.Drawing.Point(16, 32)
        Me.TxtNroVuelo.Name = "TxtNroVuelo"
        Me.TxtNroVuelo.Size = New System.Drawing.Size(269, 26)
        Me.TxtNroVuelo.TabIndex = 60
        '
        'LblDestino
        '
        Me.LblDestino.AutoSize = True
        Me.LblDestino.Location = New System.Drawing.Point(12, 201)
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Size = New System.Drawing.Size(68, 20)
        Me.LblDestino.TabIndex = 59
        Me.LblDestino.Text = "Destino:"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Location = New System.Drawing.Point(12, 137)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(48, 20)
        Me.LblHora.TabIndex = 58
        Me.LblHora.Text = "Hora:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(12, 73)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(58, 20)
        Me.LblFecha.TabIndex = 57
        Me.LblFecha.Text = "Fecha:"
        '
        'LblNroVuelo
        '
        Me.LblNroVuelo.AutoSize = True
        Me.LblNroVuelo.Location = New System.Drawing.Point(12, 9)
        Me.LblNroVuelo.Name = "LblNroVuelo"
        Me.LblNroVuelo.Size = New System.Drawing.Size(132, 20)
        Me.LblNroVuelo.TabIndex = 56
        Me.LblNroVuelo.Text = "Numero de vuelo:"
        '
        'ModificarVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 333)
        Me.Controls.Add(Me.ComboDestinos)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtHora)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtNroVuelo)
        Me.Controls.Add(Me.LblDestino)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblNroVuelo)
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
End Class
