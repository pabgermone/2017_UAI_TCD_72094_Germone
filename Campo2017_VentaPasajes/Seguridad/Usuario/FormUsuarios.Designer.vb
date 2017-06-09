<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboUsuarios = New System.Windows.Forms.ComboBox()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LinkRol = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(11, 186)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(120, 30)
        Me.BtnRegistrar.TabIndex = 10
        Me.BtnRegistrar.Text = "Nuevo usuario"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 26)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Administracion de usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuarios"
        '
        'ComboUsuarios
        '
        Me.ComboUsuarios.FormattingEnabled = True
        Me.ComboUsuarios.Location = New System.Drawing.Point(11, 68)
        Me.ComboUsuarios.Name = "ComboUsuarios"
        Me.ComboUsuarios.Size = New System.Drawing.Size(184, 21)
        Me.ComboUsuarios.TabIndex = 13
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.BackColor = System.Drawing.Color.Transparent
        Me.LblUserName.Location = New System.Drawing.Point(215, 76)
        Me.LblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(101, 13)
        Me.LblUserName.TabIndex = 14
        Me.LblUserName.Text = "Nombre de Usuario:"
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.BackColor = System.Drawing.Color.Transparent
        Me.LblRol.Location = New System.Drawing.Point(215, 116)
        Me.LblRol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(82, 13)
        Me.LblRol.TabIndex = 15
        Me.LblRol.Text = "Rol del Usuario:"
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(157, 186)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(120, 30)
        Me.BtnModificar.TabIndex = 16
        Me.BtnModificar.Text = "Modificar usuario"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(303, 186)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(120, 30)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar usuario"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'LinkRol
        '
        Me.LinkRol.AutoSize = True
        Me.LinkRol.BackColor = System.Drawing.Color.Transparent
        Me.LinkRol.LinkColor = System.Drawing.Color.Black
        Me.LinkRol.Location = New System.Drawing.Point(215, 139)
        Me.LinkRol.Name = "LinkRol"
        Me.LinkRol.Size = New System.Drawing.Size(98, 13)
        Me.LinkRol.TabIndex = 18
        Me.LinkRol.TabStop = True
        Me.LinkRol.Text = "Ver detalles del Rol"
        Me.LinkRol.VisitedLinkColor = System.Drawing.Color.Black
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(435, 227)
        Me.Controls.Add(Me.LinkRol)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.LblRol)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.ComboUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboUsuarios As ComboBox
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblRol As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LinkRol As LinkLabel
End Class
