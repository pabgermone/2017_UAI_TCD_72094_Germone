<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadisticas
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
        Me.TxtPorcentajes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboAgno = New System.Windows.Forms.ComboBox()
        Me.ComboDestino = New System.Windows.Forms.ComboBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPorcentajes
        '
        Me.TxtPorcentajes.Enabled = False
        Me.TxtPorcentajes.Location = New System.Drawing.Point(8, 111)
        Me.TxtPorcentajes.Multiline = True
        Me.TxtPorcentajes.Name = "TxtPorcentajes"
        Me.TxtPorcentajes.Size = New System.Drawing.Size(244, 340)
        Me.TxtPorcentajes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año"
        '
        'ComboAgno
        '
        Me.ComboAgno.FormattingEnabled = True
        Me.ComboAgno.Location = New System.Drawing.Point(8, 25)
        Me.ComboAgno.Name = "ComboAgno"
        Me.ComboAgno.Size = New System.Drawing.Size(121, 21)
        Me.ComboAgno.TabIndex = 3
        '
        'ComboDestino
        '
        Me.ComboDestino.FormattingEnabled = True
        Me.ComboDestino.Location = New System.Drawing.Point(8, 84)
        Me.ComboDestino.Name = "ComboDestino"
        Me.ComboDestino.Size = New System.Drawing.Size(121, 21)
        Me.ComboDestino.TabIndex = 4
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(163, 78)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(89, 27)
        Me.BtnCalcular.TabIndex = 5
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'FormEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 463)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.ComboDestino)
        Me.Controls.Add(Me.ComboAgno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPorcentajes)
        Me.Name = "FormEstadisticas"
        Me.Text = "FormEstadisticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPorcentajes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboAgno As ComboBox
    Friend WithEvents ComboDestino As ComboBox
    Friend WithEvents BtnCalcular As Button
End Class
