<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAerolineas
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
        Me.GridAerolineas = New System.Windows.Forms.DataGridView()
        Me.GridVuelos = New System.Windows.Forms.DataGridView()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAltaAerolinea = New System.Windows.Forms.Button()
        Me.BtnAltaVuelo = New System.Windows.Forms.Button()
        Me.BtnModifVuelo = New System.Windows.Forms.Button()
        Me.BtnEliminarVuelo = New System.Windows.Forms.Button()
        CType(Me.GridAerolineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAerolineas
        '
        Me.GridAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAerolineas.Location = New System.Drawing.Point(12, 12)
        Me.GridAerolineas.Name = "GridAerolineas"
        Me.GridAerolineas.RowTemplate.Height = 28
        Me.GridAerolineas.Size = New System.Drawing.Size(240, 353)
        Me.GridAerolineas.TabIndex = 0
        '
        'GridVuelos
        '
        Me.GridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVuelos.Location = New System.Drawing.Point(282, 12)
        Me.GridVuelos.Name = "GridVuelos"
        Me.GridVuelos.RowTemplate.Height = 28
        Me.GridVuelos.Size = New System.Drawing.Size(513, 353)
        Me.GridVuelos.TabIndex = 1
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(72, 386)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(121, 34)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Renombrar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAltaAerolinea
        '
        Me.BtnAltaAerolinea.Location = New System.Drawing.Point(56, 434)
        Me.BtnAltaAerolinea.Name = "BtnAltaAerolinea"
        Me.BtnAltaAerolinea.Size = New System.Drawing.Size(153, 34)
        Me.BtnAltaAerolinea.TabIndex = 3
        Me.BtnAltaAerolinea.Text = "Nueva Aerolinea"
        Me.BtnAltaAerolinea.UseVisualStyleBackColor = True
        '
        'BtnAltaVuelo
        '
        Me.BtnAltaVuelo.Location = New System.Drawing.Point(282, 386)
        Me.BtnAltaVuelo.Name = "BtnAltaVuelo"
        Me.BtnAltaVuelo.Size = New System.Drawing.Size(155, 34)
        Me.BtnAltaVuelo.TabIndex = 4
        Me.BtnAltaVuelo.Text = "Agregar Vuelo"
        Me.BtnAltaVuelo.UseVisualStyleBackColor = True
        '
        'BtnModifVuelo
        '
        Me.BtnModifVuelo.Location = New System.Drawing.Point(461, 386)
        Me.BtnModifVuelo.Name = "BtnModifVuelo"
        Me.BtnModifVuelo.Size = New System.Drawing.Size(155, 34)
        Me.BtnModifVuelo.TabIndex = 5
        Me.BtnModifVuelo.Text = "EditarVuelo"
        Me.BtnModifVuelo.UseVisualStyleBackColor = True
        '
        'BtnEliminarVuelo
        '
        Me.BtnEliminarVuelo.Location = New System.Drawing.Point(640, 386)
        Me.BtnEliminarVuelo.Name = "BtnEliminarVuelo"
        Me.BtnEliminarVuelo.Size = New System.Drawing.Size(155, 34)
        Me.BtnEliminarVuelo.TabIndex = 6
        Me.BtnEliminarVuelo.Text = "Eliminar Vuelo"
        Me.BtnEliminarVuelo.UseVisualStyleBackColor = True
        '
        'FormAerolineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 480)
        Me.Controls.Add(Me.BtnEliminarVuelo)
        Me.Controls.Add(Me.BtnModifVuelo)
        Me.Controls.Add(Me.BtnAltaVuelo)
        Me.Controls.Add(Me.BtnAltaAerolinea)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GridVuelos)
        Me.Controls.Add(Me.GridAerolineas)
        Me.Name = "FormAerolineas"
        Me.Text = "FormAerolineas"
        CType(Me.GridAerolineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridAerolineas As DataGridView
    Friend WithEvents GridVuelos As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAltaAerolinea As Button
    Friend WithEvents BtnAltaVuelo As Button
    Friend WithEvents BtnModifVuelo As Button
    Friend WithEvents BtnEliminarVuelo As Button
End Class
