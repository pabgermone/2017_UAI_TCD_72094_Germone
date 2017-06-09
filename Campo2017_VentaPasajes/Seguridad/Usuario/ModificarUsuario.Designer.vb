<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarUsuario))
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.LinkRol = New System.Windows.Forms.LinkLabel()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.BackColor = System.Drawing.Color.Transparent
        Me.LblUserName.Location = New System.Drawing.Point(11, 9)
        Me.LblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(101, 13)
        Me.LblUserName.TabIndex = 15
        Me.LblUserName.Text = "Nombre de Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Apellido:"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(12, 25)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(169, 20)
        Me.TxtUserName.TabIndex = 19
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(12, 76)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(169, 20)
        Me.TxtNombre.TabIndex = 20
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(12, 127)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(169, 20)
        Me.TxtApellido.TabIndex = 21
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(98, 183)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(83, 31)
        Me.BtnCancelar.TabIndex = 24
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(11, 183)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(83, 31)
        Me.BtnAceptar.TabIndex = 23
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'LinkRol
        '
        Me.LinkRol.AutoSize = True
        Me.LinkRol.BackColor = System.Drawing.Color.Transparent
        Me.LinkRol.LinkColor = System.Drawing.Color.Black
        Me.LinkRol.Location = New System.Drawing.Point(122, 159)
        Me.LinkRol.Name = "LinkRol"
        Me.LinkRol.Size = New System.Drawing.Size(59, 13)
        Me.LinkRol.TabIndex = 25
        Me.LinkRol.TabStop = True
        Me.LinkRol.Text = "Cambiar rol"
        Me.LinkRol.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.BackColor = System.Drawing.Color.Transparent
        Me.LblRol.Location = New System.Drawing.Point(11, 159)
        Me.LblRol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(26, 13)
        Me.LblRol.TabIndex = 26
        Me.LblRol.Text = "Rol:"
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(194, 225)
        Me.Controls.Add(Me.LblRol)
        Me.Controls.Add(Me.LinkRol)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblUserName)
        Me.Name = "ModificarUsuario"
        Me.Text = "ModificarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUserName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents LinkRol As LinkLabel
    Friend WithEvents LblRol As Label
End Class
