<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAsignacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboUsuarios = New System.Windows.Forms.ComboBox()
        Me.ComboRoles = New System.Windows.Forms.ComboBox()
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignacion de Roles"
        '
        'ComboUsuarios
        '
        Me.ComboUsuarios.FormattingEnabled = True
        Me.ComboUsuarios.Location = New System.Drawing.Point(12, 101)
        Me.ComboUsuarios.Name = "ComboUsuarios"
        Me.ComboUsuarios.Size = New System.Drawing.Size(343, 28)
        Me.ComboUsuarios.TabIndex = 1
        '
        'ComboRoles
        '
        Me.ComboRoles.FormattingEnabled = True
        Me.ComboRoles.Location = New System.Drawing.Point(12, 161)
        Me.ComboRoles.Name = "ComboRoles"
        Me.ComboRoles.Size = New System.Drawing.Size(343, 28)
        Me.ComboRoles.TabIndex = 2
        '
        'TreePermisos
        '
        Me.TreePermisos.Location = New System.Drawing.Point(12, 212)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(343, 357)
        Me.TreePermisos.TabIndex = 3
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(12, 575)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 34)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(213, 575)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(142, 34)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rol"
        '
        'FormAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 620)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TreePermisos)
        Me.Controls.Add(Me.ComboRoles)
        Me.Controls.Add(Me.ComboUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormAsignacion"
        Me.Text = "FormAsignacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboUsuarios As ComboBox
    Friend WithEvents ComboRoles As ComboBox
    Friend WithEvents TreePermisos As TreeView
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
