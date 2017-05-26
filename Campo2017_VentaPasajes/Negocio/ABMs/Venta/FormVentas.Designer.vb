<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.GridVentas = New System.Windows.Forms.DataGridView()
        Me.ComboClientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNueva = New System.Windows.Forms.Button()
        Me.BtnModificacion = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridVentas
        '
        Me.GridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVentas.Location = New System.Drawing.Point(12, 65)
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.RowTemplate.Height = 28
        Me.GridVentas.Size = New System.Drawing.Size(623, 455)
        Me.GridVentas.TabIndex = 0
        '
        'ComboClientes
        '
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Location = New System.Drawing.Point(12, 31)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(358, 28)
        Me.ComboClientes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'BtnNueva
        '
        Me.BtnNueva.Location = New System.Drawing.Point(12, 537)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(173, 35)
        Me.BtnNueva.TabIndex = 3
        Me.BtnNueva.Text = "Nueva Venta"
        Me.BtnNueva.UseVisualStyleBackColor = True
        '
        'BtnModificacion
        '
        Me.BtnModificacion.Location = New System.Drawing.Point(237, 537)
        Me.BtnModificacion.Name = "BtnModificacion"
        Me.BtnModificacion.Size = New System.Drawing.Size(173, 35)
        Me.BtnModificacion.TabIndex = 4
        Me.BtnModificacion.Text = "Editar"
        Me.BtnModificacion.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(462, 537)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(173, 35)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 584)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificacion)
        Me.Controls.Add(Me.BtnNueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboClientes)
        Me.Controls.Add(Me.GridVentas)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridVentas As DataGridView
    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNueva As Button
    Friend WithEvents BtnModificacion As Button
    Friend WithEvents BtnEliminar As Button
End Class
