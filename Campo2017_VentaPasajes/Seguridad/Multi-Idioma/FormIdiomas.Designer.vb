<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIdiomas
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
        Me.GridDiccionario = New System.Windows.Forms.DataGridView()
        Me.ComboIdiomas = New System.Windows.Forms.ComboBox()
        Me.TxtPalabraSelec = New System.Windows.Forms.TextBox()
        Me.TxtTraduccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.GridDiccionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDiccionario
        '
        Me.GridDiccionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDiccionario.Location = New System.Drawing.Point(12, 42)
        Me.GridDiccionario.Name = "GridDiccionario"
        Me.GridDiccionario.Size = New System.Drawing.Size(219, 320)
        Me.GridDiccionario.TabIndex = 0
        '
        'ComboIdiomas
        '
        Me.ComboIdiomas.FormattingEnabled = True
        Me.ComboIdiomas.Location = New System.Drawing.Point(12, 12)
        Me.ComboIdiomas.Name = "ComboIdiomas"
        Me.ComboIdiomas.Size = New System.Drawing.Size(546, 21)
        Me.ComboIdiomas.TabIndex = 1
        '
        'TxtPalabraSelec
        '
        Me.TxtPalabraSelec.Location = New System.Drawing.Point(235, 63)
        Me.TxtPalabraSelec.Name = "TxtPalabraSelec"
        Me.TxtPalabraSelec.Size = New System.Drawing.Size(323, 20)
        Me.TxtPalabraSelec.TabIndex = 2
        '
        'TxtTraduccion
        '
        Me.TxtTraduccion.Location = New System.Drawing.Point(237, 121)
        Me.TxtTraduccion.Multiline = True
        Me.TxtTraduccion.Name = "TxtTraduccion"
        Me.TxtTraduccion.Size = New System.Drawing.Size(321, 114)
        Me.TxtTraduccion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Texto Seleccionado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Traduccion"
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Location = New System.Drawing.Point(237, 274)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(131, 23)
        Me.BtnCambiar.TabIndex = 6
        Me.BtnCambiar.Text = "Guardar cambios"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(237, 339)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(131, 23)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.Text = "Nuevo Idioma"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(427, 339)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(131, 23)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar Idioma"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FormIdiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 371)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTraduccion)
        Me.Controls.Add(Me.TxtPalabraSelec)
        Me.Controls.Add(Me.ComboIdiomas)
        Me.Controls.Add(Me.GridDiccionario)
        Me.Name = "FormIdiomas"
        Me.Text = "FormIdiomas"
        CType(Me.GridDiccionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridDiccionario As DataGridView
    Friend WithEvents ComboIdiomas As ComboBox
    Friend WithEvents TxtPalabraSelec As TextBox
    Friend WithEvents TxtTraduccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
End Class
