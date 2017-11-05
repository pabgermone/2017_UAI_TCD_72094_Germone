<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.RadioApellido = New System.Windows.Forms.RadioButton()
        Me.RadioDocumento = New System.Windows.Forms.RadioButton()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnReservas = New System.Windows.Forms.Button()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(11, 324)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(111, 41)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(126, 324)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(113, 41)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(11, 25)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(157, 20)
        Me.TxtBuscar.TabIndex = 10
        '
        'GridClientes
        '
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Location = New System.Drawing.Point(11, 51)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(570, 268)
        Me.GridClientes.TabIndex = 11
        '
        'RadioApellido
        '
        Me.RadioApellido.AutoSize = True
        Me.RadioApellido.Location = New System.Drawing.Point(193, 26)
        Me.RadioApellido.Name = "RadioApellido"
        Me.RadioApellido.Size = New System.Drawing.Size(62, 17)
        Me.RadioApellido.TabIndex = 12
        Me.RadioApellido.TabStop = True
        Me.RadioApellido.Text = "Apellido"
        Me.RadioApellido.UseVisualStyleBackColor = True
        '
        'RadioDocumento
        '
        Me.RadioDocumento.AutoSize = True
        Me.RadioDocumento.Location = New System.Drawing.Point(276, 26)
        Me.RadioDocumento.Name = "RadioDocumento"
        Me.RadioDocumento.Size = New System.Drawing.Size(80, 17)
        Me.RadioDocumento.TabIndex = 13
        Me.RadioDocumento.TabStop = True
        Me.RadioDocumento.Text = "Documento"
        Me.RadioDocumento.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(243, 324)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(113, 41)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnReservas
        '
        Me.BtnReservas.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservas.Location = New System.Drawing.Point(468, 324)
        Me.BtnReservas.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReservas.Name = "BtnReservas"
        Me.BtnReservas.Size = New System.Drawing.Size(113, 41)
        Me.BtnReservas.TabIndex = 15
        Me.BtnReservas.Text = "Reservas"
        Me.BtnReservas.UseVisualStyleBackColor = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(593, 376)
        Me.Controls.Add(Me.BtnReservas)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.RadioDocumento)
        Me.Controls.Add(Me.RadioApellido)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormClientes"
        Me.Text = "FormClientes"
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents RadioApellido As RadioButton
    Friend WithEvents RadioDocumento As RadioButton
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnReservas As Button
End Class
