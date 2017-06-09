<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambioRolUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCambioRolUsuario))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.ComboRoles = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(7, 9)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(75, 26)
        Me.LblTitulo.TabIndex = 12
        Me.LblTitulo.Text = "Rol de"
        '
        'ComboRoles
        '
        Me.ComboRoles.FormattingEnabled = True
        Me.ComboRoles.Items.AddRange(New Object() {"- Seleccione un Rol -"})
        Me.ComboRoles.Location = New System.Drawing.Point(12, 69)
        Me.ComboRoles.Name = "ComboRoles"
        Me.ComboRoles.Size = New System.Drawing.Size(226, 21)
        Me.ComboRoles.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Roles"
        '
        'TreePermisos
        '
        Me.TreePermisos.Location = New System.Drawing.Point(14, 122)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(224, 275)
        Me.TreePermisos.TabIndex = 15
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(155, 402)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(83, 31)
        Me.BtnCancelar.TabIndex = 26
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(14, 402)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(83, 31)
        Me.BtnAceptar.TabIndex = 25
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Permisos"
        '
        'FormCambioRolUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(250, 438)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TreePermisos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboRoles)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "FormCambioRolUsuario"
        Me.Text = "FormCambioRolUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents ComboRoles As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TreePermisos As TreeView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Label2 As Label
End Class
