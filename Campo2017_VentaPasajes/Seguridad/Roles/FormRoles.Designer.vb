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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRoles))
        Me.ListRoles = New System.Windows.Forms.ListBox()
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNvoRol = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnDeshacer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRenombrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListRoles
        '
        Me.ListRoles.FormattingEnabled = True
        Me.ListRoles.Location = New System.Drawing.Point(8, 64)
        Me.ListRoles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListRoles.Name = "ListRoles"
        Me.ListRoles.Size = New System.Drawing.Size(159, 277)
        Me.ListRoles.TabIndex = 0
        '
        'TreePermisos
        '
        Me.TreePermisos.CheckBoxes = True
        Me.TreePermisos.Location = New System.Drawing.Point(190, 64)
        Me.TreePermisos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(237, 277)
        Me.TreePermisos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Roles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(187, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Permisos del Rol"
        '
        'BtnNvoRol
        '
        Me.BtnNvoRol.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNvoRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNvoRol.Location = New System.Drawing.Point(8, 354)
        Me.BtnNvoRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNvoRol.Name = "BtnNvoRol"
        Me.BtnNvoRol.Size = New System.Drawing.Size(73, 40)
        Me.BtnNvoRol.TabIndex = 4
        Me.BtnNvoRol.Text = "Nuevo Rol"
        Me.BtnNvoRol.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(190, 354)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 40)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnDeshacer
        '
        Me.BtnDeshacer.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnDeshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeshacer.Location = New System.Drawing.Point(291, 354)
        Me.BtnDeshacer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(109, 40)
        Me.BtnDeshacer.TabIndex = 6
        Me.BtnDeshacer.Text = "Deshacer cambios"
        Me.BtnDeshacer.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Roles del Sistema"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(85, 354)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(82, 40)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnRenombrar
        '
        Me.BtnRenombrar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnRenombrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRenombrar.Location = New System.Drawing.Point(8, 411)
        Me.BtnRenombrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnRenombrar.Name = "BtnRenombrar"
        Me.BtnRenombrar.Size = New System.Drawing.Size(86, 41)
        Me.BtnRenombrar.TabIndex = 10
        Me.BtnRenombrar.Text = "Renombrar"
        Me.BtnRenombrar.UseVisualStyleBackColor = False
        '
        'FormRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(435, 463)
        Me.Controls.Add(Me.BtnRenombrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnDeshacer)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNvoRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreePermisos)
        Me.Controls.Add(Me.ListRoles)
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
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRenombrar As Button
End Class
