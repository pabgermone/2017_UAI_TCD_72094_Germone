<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPermiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaPermiso))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbFormularios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckFormulario = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 26)
        Me.txtNombre.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(261, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbFormularios
        '
        Me.cmbFormularios.FormattingEnabled = True
        Me.cmbFormularios.Location = New System.Drawing.Point(11, 123)
        Me.cmbFormularios.Name = "cmbFormularios"
        Me.cmbFormularios.Size = New System.Drawing.Size(370, 28)
        Me.cmbFormularios.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre del Permiso"
        '
        'CheckFormulario
        '
        Me.CheckFormulario.AutoSize = True
        Me.CheckFormulario.BackColor = System.Drawing.Color.Transparent
        Me.CheckFormulario.Location = New System.Drawing.Point(12, 93)
        Me.CheckFormulario.Name = "CheckFormulario"
        Me.CheckFormulario.Size = New System.Drawing.Size(175, 24)
        Me.CheckFormulario.TabIndex = 8
        Me.CheckFormulario.Text = "Asociar a formulario"
        Me.CheckFormulario.UseVisualStyleBackColor = False
        '
        'AltaPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(393, 238)
        Me.Controls.Add(Me.CheckFormulario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbFormularios)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AltaPermiso"
        Me.Text = "FormAgregarPatente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbFormularios As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckFormulario As CheckBox
End Class
