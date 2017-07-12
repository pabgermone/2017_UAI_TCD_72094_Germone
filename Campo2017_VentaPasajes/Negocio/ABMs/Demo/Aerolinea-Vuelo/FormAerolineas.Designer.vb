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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAerolineas))
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
        Me.GridAerolineas.Location = New System.Drawing.Point(8, 8)
        Me.GridAerolineas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridAerolineas.Name = "GridAerolineas"
        Me.GridAerolineas.RowTemplate.Height = 28
        Me.GridAerolineas.Size = New System.Drawing.Size(160, 229)
        Me.GridAerolineas.TabIndex = 0
        '
        'GridVuelos
        '
        Me.GridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVuelos.Location = New System.Drawing.Point(188, 8)
        Me.GridVuelos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridVuelos.Name = "GridVuelos"
        Me.GridVuelos.RowTemplate.Height = 28
        Me.GridVuelos.Size = New System.Drawing.Size(342, 229)
        Me.GridVuelos.TabIndex = 1
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEditar.Location = New System.Drawing.Point(37, 251)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(102, 27)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Renombrar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnAltaAerolinea
        '
        Me.BtnAltaAerolinea.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAltaAerolinea.Location = New System.Drawing.Point(37, 282)
        Me.BtnAltaAerolinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAltaAerolinea.Name = "BtnAltaAerolinea"
        Me.BtnAltaAerolinea.Size = New System.Drawing.Size(102, 31)
        Me.BtnAltaAerolinea.TabIndex = 3
        Me.BtnAltaAerolinea.Text = "Nueva Aerolinea"
        Me.BtnAltaAerolinea.UseVisualStyleBackColor = False
        '
        'BtnAltaVuelo
        '
        Me.BtnAltaVuelo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAltaVuelo.Location = New System.Drawing.Point(188, 251)
        Me.BtnAltaVuelo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAltaVuelo.Name = "BtnAltaVuelo"
        Me.BtnAltaVuelo.Size = New System.Drawing.Size(106, 27)
        Me.BtnAltaVuelo.TabIndex = 4
        Me.BtnAltaVuelo.Text = "Agregar Vuelo"
        Me.BtnAltaVuelo.UseVisualStyleBackColor = False
        '
        'BtnModifVuelo
        '
        Me.BtnModifVuelo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnModifVuelo.Location = New System.Drawing.Point(307, 251)
        Me.BtnModifVuelo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnModifVuelo.Name = "BtnModifVuelo"
        Me.BtnModifVuelo.Size = New System.Drawing.Size(104, 27)
        Me.BtnModifVuelo.TabIndex = 5
        Me.BtnModifVuelo.Text = "EditarVuelo"
        Me.BtnModifVuelo.UseVisualStyleBackColor = False
        '
        'BtnEliminarVuelo
        '
        Me.BtnEliminarVuelo.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminarVuelo.Location = New System.Drawing.Point(427, 251)
        Me.BtnEliminarVuelo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEliminarVuelo.Name = "BtnEliminarVuelo"
        Me.BtnEliminarVuelo.Size = New System.Drawing.Size(103, 27)
        Me.BtnEliminarVuelo.TabIndex = 6
        Me.BtnEliminarVuelo.Text = "Eliminar Vuelo"
        Me.BtnEliminarVuelo.UseVisualStyleBackColor = False
        '
        'FormAerolineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(556, 337)
        Me.Controls.Add(Me.BtnEliminarVuelo)
        Me.Controls.Add(Me.BtnModifVuelo)
        Me.Controls.Add(Me.BtnAltaVuelo)
        Me.Controls.Add(Me.BtnAltaAerolinea)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GridVuelos)
        Me.Controls.Add(Me.GridAerolineas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
