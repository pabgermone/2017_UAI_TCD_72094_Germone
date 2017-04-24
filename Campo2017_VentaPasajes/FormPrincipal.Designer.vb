<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDefinirPatentes = New System.Windows.Forms.Button()
        Me.btnDefinirUsuarios = New System.Windows.Forms.Button()
        Me.btnDefinirFamilias = New System.Windows.Forms.Button()
        Me.btnIniciarSesionComoUsuario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuGeneradoDinamicamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpVistaUsuarios = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpVistaUsuarios.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirPatentes, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirUsuarios, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirFamilias, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIniciarSesionComoUsuario, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 93)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnDefinirPatentes
        '
        Me.btnDefinirPatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirPatentes.Location = New System.Drawing.Point(480, 3)
        Me.btnDefinirPatentes.Name = "btnDefinirPatentes"
        Me.btnDefinirPatentes.Size = New System.Drawing.Size(154, 87)
        Me.btnDefinirPatentes.TabIndex = 0
        Me.btnDefinirPatentes.Text = "Definir Permisos"
        Me.btnDefinirPatentes.UseVisualStyleBackColor = True
        '
        'btnDefinirUsuarios
        '
        Me.btnDefinirUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirUsuarios.Location = New System.Drawing.Point(162, 3)
        Me.btnDefinirUsuarios.Name = "btnDefinirUsuarios"
        Me.btnDefinirUsuarios.Size = New System.Drawing.Size(153, 87)
        Me.btnDefinirUsuarios.TabIndex = 2
        Me.btnDefinirUsuarios.Text = "Definir Usuarios"
        Me.btnDefinirUsuarios.UseVisualStyleBackColor = True
        '
        'btnDefinirFamilias
        '
        Me.btnDefinirFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirFamilias.Location = New System.Drawing.Point(321, 3)
        Me.btnDefinirFamilias.Name = "btnDefinirFamilias"
        Me.btnDefinirFamilias.Size = New System.Drawing.Size(153, 87)
        Me.btnDefinirFamilias.TabIndex = 1
        Me.btnDefinirFamilias.Text = "Definir Roles"
        Me.btnDefinirFamilias.UseVisualStyleBackColor = True
        '
        'btnIniciarSesionComoUsuario
        '
        Me.btnIniciarSesionComoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIniciarSesionComoUsuario.Location = New System.Drawing.Point(3, 3)
        Me.btnIniciarSesionComoUsuario.Name = "btnIniciarSesionComoUsuario"
        Me.btnIniciarSesionComoUsuario.Size = New System.Drawing.Size(153, 87)
        Me.btnIniciarSesionComoUsuario.TabIndex = 3
        Me.btnIniciarSesionComoUsuario.Text = "Iniciar Sesion Como Usuario"
        Me.btnIniciarSesionComoUsuario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 118)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel Administrador"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGeneradoDinamicamenteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 35)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuGeneradoDinamicamenteToolStripMenuItem
        '
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Name = "MenuGeneradoDinamicamenteToolStripMenuItem"
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Size = New System.Drawing.Size(279, 29)
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Text = "Menu Generado Dinamicamente"
        '
        'grpVistaUsuarios
        '
        Me.grpVistaUsuarios.Controls.Add(Me.TableLayoutPanel2)
        Me.grpVistaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVistaUsuarios.Location = New System.Drawing.Point(0, 35)
        Me.grpVistaUsuarios.Name = "grpVistaUsuarios"
        Me.grpVistaUsuarios.Size = New System.Drawing.Size(643, 169)
        Me.grpVistaUsuarios.TabIndex = 8
        Me.grpVistaUsuarios.TabStop = False
        Me.grpVistaUsuarios.Text = "Vista De Usuarios"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aqui se generan dinamicamente los botones al iniciar sesion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(637, 144)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 322)
        Me.Controls.Add(Me.grpVistaUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpVistaUsuarios.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDefinirPatentes As Button
    Friend WithEvents btnDefinirUsuarios As Button
    Friend WithEvents btnDefinirFamilias As Button
    Friend WithEvents btnIniciarSesionComoUsuario As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuGeneradoDinamicamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpVistaUsuarios As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
