<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRoles
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
        Me.ListRoles = New System.Windows.Forms.ListBox()
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNvoRol = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnDeshacer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListRoles
        '
        Me.ListRoles.FormattingEnabled = True
        Me.ListRoles.ItemHeight = 20
        Me.ListRoles.Location = New System.Drawing.Point(12, 98)
        Me.ListRoles.Name = "ListRoles"
        Me.ListRoles.Size = New System.Drawing.Size(236, 424)
        Me.ListRoles.TabIndex = 0
        '
        'TreePermisos
        '
        Me.TreePermisos.CheckBoxes = True
        Me.TreePermisos.Location = New System.Drawing.Point(285, 98)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(353, 424)
        Me.TreePermisos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Roles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Permisos del Rol"
        '
        'BtnNvoRol
        '
        Me.BtnNvoRol.Location = New System.Drawing.Point(12, 528)
        Me.BtnNvoRol.Name = "BtnNvoRol"
        Me.BtnNvoRol.Size = New System.Drawing.Size(146, 32)
        Me.BtnNvoRol.TabIndex = 4
        Me.BtnNvoRol.Text = "Nuevo Rol"
        Me.BtnNvoRol.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(285, 528)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(146, 32)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnDeshacer
        '
        Me.BtnDeshacer.Location = New System.Drawing.Point(437, 528)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(164, 32)
        Me.BtnDeshacer.TabIndex = 6
        Me.BtnDeshacer.Text = "Deshacer cambios"
        Me.BtnDeshacer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Roles del Sistema"
        '
        'FormRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 577)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnDeshacer)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNvoRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreePermisos)
        Me.Controls.Add(Me.ListRoles)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormRoles"
        Me.Text = "FormRoles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListRoles As ListBox
    Friend WithEvents TreePermisos As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnNvoRol As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnDeshacer As Button
    Friend WithEvents Label3 As Label
End Class
