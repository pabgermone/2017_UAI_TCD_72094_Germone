<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPermiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPermiso))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbFormularios = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seleccione Formulario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre del Permiso"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(11, 21)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(179, 95)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbFormularios
        '
        Me.cmbFormularios.FormattingEnabled = True
        Me.cmbFormularios.Location = New System.Drawing.Point(11, 60)
        Me.cmbFormularios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbFormularios.Name = "cmbFormularios"
        Me.cmbFormularios.Size = New System.Drawing.Size(248, 21)
        Me.cmbFormularios.TabIndex = 8
        '
        'ModificarPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(283, 143)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbFormularios)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ModificarPermiso"
        Me.Text = "ModificarPatente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbFormularios As ComboBox
End Class
