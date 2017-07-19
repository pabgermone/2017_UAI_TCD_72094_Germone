<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogIn
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.lblPassChange = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 28)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(236, 20)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(12, 82)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(236, 20)
        Me.txtPass.TabIndex = 2
        '
        'btnIngreso
        '
        Me.btnIngreso.BackColor = System.Drawing.Color.LightSalmon
        Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.Location = New System.Drawing.Point(12, 153)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(235, 36)
        Me.btnIngreso.TabIndex = 4
        Me.btnIngreso.Text = "Ingresar"
        Me.btnIngreso.UseVisualStyleBackColor = False
        '
        'lblPassChange
        '
        Me.lblPassChange.AutoSize = True
        Me.lblPassChange.BackColor = System.Drawing.Color.Transparent
        Me.lblPassChange.LinkColor = System.Drawing.SystemColors.ControlText
        Me.lblPassChange.Location = New System.Drawing.Point(77, 102)
        Me.lblPassChange.Name = "lblPassChange"
        Me.lblPassChange.Size = New System.Drawing.Size(107, 13)
        Me.lblPassChange.TabIndex = 6
        Me.lblPassChange.TabStop = True
        Me.lblPassChange.Text = "Olvido su contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*Por favor, revise los datos ingresados"
        Me.Label3.Visible = False
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InterfazUsuario.My.Resources.Resources._584767382
        Me.ClientSize = New System.Drawing.Size(265, 201)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPassChange)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "FormLogIn"
        Me.Text = "Inicio de Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnIngreso As Button
    Friend WithEvents lblPassChange As LinkLabel
    Friend WithEvents Label3 As Label
End Class
