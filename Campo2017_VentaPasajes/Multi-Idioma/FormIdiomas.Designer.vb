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
        Me.GridTextos = New System.Windows.Forms.DataGridView()
        Me.ComboIdiomas = New System.Windows.Forms.ComboBox()
        Me.TxtPalabraSelec = New System.Windows.Forms.TextBox()
        Me.TxtTraduccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        CType(Me.GridTextos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridTextos
        '
        Me.GridTextos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTextos.Location = New System.Drawing.Point(18, 65)
        Me.GridTextos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridTextos.Name = "GridTextos"
        Me.GridTextos.Size = New System.Drawing.Size(328, 492)
        Me.GridTextos.TabIndex = 0
        '
        'ComboIdiomas
        '
        Me.ComboIdiomas.FormattingEnabled = True
        Me.ComboIdiomas.Location = New System.Drawing.Point(18, 18)
        Me.ComboIdiomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboIdiomas.Name = "ComboIdiomas"
        Me.ComboIdiomas.Size = New System.Drawing.Size(817, 28)
        Me.ComboIdiomas.TabIndex = 1
        '
        'TxtPalabraSelec
        '
        Me.TxtPalabraSelec.Enabled = False
        Me.TxtPalabraSelec.Location = New System.Drawing.Point(352, 97)
        Me.TxtPalabraSelec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPalabraSelec.Name = "TxtPalabraSelec"
        Me.TxtPalabraSelec.Size = New System.Drawing.Size(482, 26)
        Me.TxtPalabraSelec.TabIndex = 2
        '
        'TxtTraduccion
        '
        Me.TxtTraduccion.Location = New System.Drawing.Point(356, 186)
        Me.TxtTraduccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTraduccion.Multiline = True
        Me.TxtTraduccion.Name = "TxtTraduccion"
        Me.TxtTraduccion.Size = New System.Drawing.Size(480, 173)
        Me.TxtTraduccion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Texto Seleccionado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Traduccion"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(356, 445)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(196, 35)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(356, 522)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(196, 35)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.Text = "Nuevo Idioma"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(640, 522)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(196, 35)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar Idioma"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Location = New System.Drawing.Point(640, 371)
        Me.BtnCambiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(196, 35)
        Me.BtnCambiar.TabIndex = 9
        Me.BtnCambiar.Text = "Cambiar Traduccion"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'FormIdiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 571)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTraduccion)
        Me.Controls.Add(Me.TxtPalabraSelec)
        Me.Controls.Add(Me.ComboIdiomas)
        Me.Controls.Add(Me.GridTextos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormIdiomas"
        Me.Text = "FormIdiomas"
        CType(Me.GridTextos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridTextos As DataGridView
    Friend WithEvents ComboIdiomas As ComboBox
    Friend WithEvents TxtPalabraSelec As TextBox
    Friend WithEvents TxtTraduccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCambiar As Button
End Class
