<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDestinos
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
        Me.GridDestinos = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.GridDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDestinos
        '
        Me.GridDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDestinos.Location = New System.Drawing.Point(12, 12)
        Me.GridDestinos.Name = "GridDestinos"
        Me.GridDestinos.RowTemplate.Height = 28
        Me.GridDestinos.Size = New System.Drawing.Size(367, 506)
        Me.GridDestinos.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(385, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(164, 37)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Agregar"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(385, 76)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(164, 37)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FormDestinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 530)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GridDestinos)
        Me.Name = "FormDestinos"
        Me.Text = "FormDestinos"
        CType(Me.GridDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridDestinos As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
End Class
