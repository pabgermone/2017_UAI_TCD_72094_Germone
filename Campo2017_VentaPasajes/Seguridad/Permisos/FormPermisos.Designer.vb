<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPermisos))
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.BtnNvoPermiso = New System.Windows.Forms.Button()
        Me.BtnNvoCompuesto = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TreePermisos
        '
        Me.TreePermisos.Location = New System.Drawing.Point(274, 82)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(326, 427)
        Me.TreePermisos.TabIndex = 0
        '
        'BtnNvoPermiso
        '
        Me.BtnNvoPermiso.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNvoPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNvoPermiso.Location = New System.Drawing.Point(12, 82)
        Me.BtnNvoPermiso.Name = "BtnNvoPermiso"
        Me.BtnNvoPermiso.Size = New System.Drawing.Size(256, 34)
        Me.BtnNvoPermiso.TabIndex = 1
        Me.BtnNvoPermiso.Text = "Nuevo Permiso"
        Me.BtnNvoPermiso.UseVisualStyleBackColor = False
        '
        'BtnNvoCompuesto
        '
        Me.BtnNvoCompuesto.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNvoCompuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNvoCompuesto.Location = New System.Drawing.Point(12, 138)
        Me.BtnNvoCompuesto.Name = "BtnNvoCompuesto"
        Me.BtnNvoCompuesto.Size = New System.Drawing.Size(256, 34)
        Me.BtnNvoCompuesto.TabIndex = 2
        Me.BtnNvoCompuesto.Text = "Nuevo Permiso Compuesto"
        Me.BtnNvoCompuesto.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(12, 197)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(256, 34)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar Permiso"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(12, 255)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(256, 34)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar Permiso"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Permisos"
        '
        'FormPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(614, 520)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNvoCompuesto)
        Me.Controls.Add(Me.BtnNvoPermiso)
        Me.Controls.Add(Me.TreePermisos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPermisos"
        Me.Text = "FormPermisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreePermisos As TreeView
    Friend WithEvents BtnNvoPermiso As Button
    Friend WithEvents BtnNvoCompuesto As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
End Class
