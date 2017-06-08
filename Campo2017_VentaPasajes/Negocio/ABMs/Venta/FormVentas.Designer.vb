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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
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
        Me.GridVentas.Location = New System.Drawing.Point(8, 42)
        Me.GridVentas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.RowTemplate.Height = 28
        Me.GridVentas.Size = New System.Drawing.Size(415, 296)
        Me.GridVentas.TabIndex = 0
        '
        'ComboClientes
        '
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Location = New System.Drawing.Point(8, 20)
        Me.ComboClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(240, 21)
        Me.ComboClientes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'BtnNueva
        '
        Me.BtnNueva.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueva.Location = New System.Drawing.Point(8, 349)
        Me.BtnNueva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(126, 36)
        Me.BtnNueva.TabIndex = 3
        Me.BtnNueva.Text = "Nueva Venta"
        Me.BtnNueva.UseVisualStyleBackColor = False
        '
        'BtnModificacion
        '
        Me.BtnModificacion.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificacion.Location = New System.Drawing.Point(158, 349)
        Me.BtnModificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnModificacion.Name = "BtnModificacion"
        Me.BtnModificacion.Size = New System.Drawing.Size(125, 36)
        Me.BtnModificacion.TabIndex = 4
        Me.BtnModificacion.Text = "Editar"
        Me.BtnModificacion.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(308, 349)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(115, 36)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(487, 396)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificacion)
        Me.Controls.Add(Me.BtnNueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboClientes)
        Me.Controls.Add(Me.GridVentas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
