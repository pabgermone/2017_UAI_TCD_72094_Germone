<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Me.TabControlVentas = New System.Windows.Forms.TabControl()
        Me.TabVuelos = New System.Windows.Forms.TabPage()
        Me.BtnSiguienteTab1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.GridVuelos = New System.Windows.Forms.DataGridView()
        Me.TabPasajeros = New System.Windows.Forms.TabPage()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioFemenino = New System.Windows.Forms.RadioButton()
        Me.RadioMasculino = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPasaporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFechaNac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ComboClientes = New System.Windows.Forms.ComboBox()
        Me.GridPasajeros = New System.Windows.Forms.DataGridView()
        Me.BtnAnteriorTab2 = New System.Windows.Forms.Button()
        Me.BtnSiguienteTab2 = New System.Windows.Forms.Button()
        Me.TabAsientos = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAnteriorTab3 = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TabControlVentas.SuspendLayout()
        Me.TabVuelos.SuspendLayout()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPasajeros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridPasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAsientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlVentas
        '
        Me.TabControlVentas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlVentas.Controls.Add(Me.TabVuelos)
        Me.TabControlVentas.Controls.Add(Me.TabPasajeros)
        Me.TabControlVentas.Controls.Add(Me.TabAsientos)
        Me.TabControlVentas.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControlVentas.Location = New System.Drawing.Point(0, 0)
        Me.TabControlVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlVentas.Name = "TabControlVentas"
        Me.TabControlVentas.SelectedIndex = 0
        Me.TabControlVentas.Size = New System.Drawing.Size(477, 388)
        Me.TabControlVentas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlVentas.TabIndex = 0
        '
        'TabVuelos
        '
        Me.TabVuelos.BackColor = System.Drawing.Color.Transparent
        Me.TabVuelos.BackgroundImage = Global.InterfazUsuario.My.Resources.Resources._584767382
        Me.TabVuelos.Controls.Add(Me.BtnSiguienteTab1)
        Me.TabVuelos.Controls.Add(Me.Label1)
        Me.TabVuelos.Controls.Add(Me.TxtBusqueda)
        Me.TabVuelos.Controls.Add(Me.GridVuelos)
        Me.TabVuelos.Location = New System.Drawing.Point(4, 5)
        Me.TabVuelos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabVuelos.Name = "TabVuelos"
        Me.TabVuelos.Padding = New System.Windows.Forms.Padding(2)
        Me.TabVuelos.Size = New System.Drawing.Size(469, 379)
        Me.TabVuelos.TabIndex = 0
        Me.TabVuelos.Text = "TabPage1"
        '
        'BtnSiguienteTab1
        '
        Me.BtnSiguienteTab1.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnSiguienteTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguienteTab1.Location = New System.Drawing.Point(383, 352)
        Me.BtnSiguienteTab1.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSiguienteTab1.Name = "BtnSiguienteTab1"
        Me.BtnSiguienteTab1.Size = New System.Drawing.Size(84, 21)
        Me.BtnSiguienteTab1.TabIndex = 3
        Me.BtnSiguienteTab1.Text = "Siguiente"
        Me.BtnSiguienteTab1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(5, 17)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(233, 20)
        Me.TxtBusqueda.TabIndex = 1
        '
        'GridVuelos
        '
        Me.GridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVuelos.Location = New System.Drawing.Point(5, 38)
        Me.GridVuelos.Margin = New System.Windows.Forms.Padding(2)
        Me.GridVuelos.Name = "GridVuelos"
        Me.GridVuelos.RowTemplate.Height = 28
        Me.GridVuelos.Size = New System.Drawing.Size(461, 311)
        Me.GridVuelos.TabIndex = 0
        '
        'TabPasajeros
        '
        Me.TabPasajeros.BackgroundImage = Global.InterfazUsuario.My.Resources.Resources._584767382
        Me.TabPasajeros.Controls.Add(Me.BtnRegistrar)
        Me.TabPasajeros.Controls.Add(Me.BtnAgregar)
        Me.TabPasajeros.Controls.Add(Me.GroupBox1)
        Me.TabPasajeros.Controls.Add(Me.ComboClientes)
        Me.TabPasajeros.Controls.Add(Me.GridPasajeros)
        Me.TabPasajeros.Controls.Add(Me.BtnAnteriorTab2)
        Me.TabPasajeros.Controls.Add(Me.BtnSiguienteTab2)
        Me.TabPasajeros.Location = New System.Drawing.Point(4, 5)
        Me.TabPasajeros.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPasajeros.Name = "TabPasajeros"
        Me.TabPasajeros.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPasajeros.Size = New System.Drawing.Size(469, 379)
        Me.TabPasajeros.TabIndex = 1
        Me.TabPasajeros.Text = "TabPage2"
        Me.TabPasajeros.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(5, 281)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(147, 21)
        Me.BtnRegistrar.TabIndex = 11
        Me.BtnRegistrar.Text = "Registrar nuevo Pasajero"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(5, 315)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(147, 21)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar pasajero"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RadioFemenino)
        Me.GroupBox1.Controls.Add(Me.RadioMasculino)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtPasaporte)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtDNI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtFechaNac)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(201, 246)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sexo"
        '
        'RadioFemenino
        '
        Me.RadioFemenino.AutoSize = True
        Me.RadioFemenino.Location = New System.Drawing.Point(65, 104)
        Me.RadioFemenino.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioFemenino.Name = "RadioFemenino"
        Me.RadioFemenino.Size = New System.Drawing.Size(31, 17)
        Me.RadioFemenino.TabIndex = 11
        Me.RadioFemenino.TabStop = True
        Me.RadioFemenino.Text = "F"
        Me.RadioFemenino.UseVisualStyleBackColor = True
        '
        'RadioMasculino
        '
        Me.RadioMasculino.AutoSize = True
        Me.RadioMasculino.Location = New System.Drawing.Point(7, 104)
        Me.RadioMasculino.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioMasculino.Name = "RadioMasculino"
        Me.RadioMasculino.Size = New System.Drawing.Size(34, 17)
        Me.RadioMasculino.TabIndex = 10
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "M"
        Me.RadioMasculino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pasaporte"
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(8, 220)
        Me.TxtPasaporte.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(126, 20)
        Me.TxtPasaporte.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(8, 185)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(126, 20)
        Me.TxtDNI.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Location = New System.Drawing.Point(8, 148)
        Me.TxtFechaNac.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(126, 20)
        Me.TxtFechaNac.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(8, 62)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(126, 20)
        Me.TxtApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(8, 23)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(126, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'ComboClientes
        '
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Items.AddRange(New Object() {"- Seleccione un pasajero -"})
        Me.ComboClientes.Location = New System.Drawing.Point(5, 4)
        Me.ComboClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(203, 21)
        Me.ComboClientes.TabIndex = 1
        '
        'GridPasajeros
        '
        Me.GridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPasajeros.Location = New System.Drawing.Point(221, 4)
        Me.GridPasajeros.Margin = New System.Windows.Forms.Padding(2)
        Me.GridPasajeros.Name = "GridPasajeros"
        Me.GridPasajeros.RowTemplate.Height = 28
        Me.GridPasajeros.Size = New System.Drawing.Size(245, 333)
        Me.GridPasajeros.TabIndex = 6
        '
        'BtnAnteriorTab2
        '
        Me.BtnAnteriorTab2.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAnteriorTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnteriorTab2.Location = New System.Drawing.Point(4, 352)
        Me.BtnAnteriorTab2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAnteriorTab2.Name = "BtnAnteriorTab2"
        Me.BtnAnteriorTab2.Size = New System.Drawing.Size(84, 21)
        Me.BtnAnteriorTab2.TabIndex = 5
        Me.BtnAnteriorTab2.Text = "Anterior"
        Me.BtnAnteriorTab2.UseVisualStyleBackColor = False
        '
        'BtnSiguienteTab2
        '
        Me.BtnSiguienteTab2.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnSiguienteTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguienteTab2.Location = New System.Drawing.Point(383, 352)
        Me.BtnSiguienteTab2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSiguienteTab2.Name = "BtnSiguienteTab2"
        Me.BtnSiguienteTab2.Size = New System.Drawing.Size(84, 21)
        Me.BtnSiguienteTab2.TabIndex = 4
        Me.BtnSiguienteTab2.Text = "Siguiente"
        Me.BtnSiguienteTab2.UseVisualStyleBackColor = False
        '
        'TabAsientos
        '
        Me.TabAsientos.BackgroundImage = Global.InterfazUsuario.My.Resources.Resources._584767382
        Me.TabAsientos.Controls.Add(Me.Label8)
        Me.TabAsientos.Controls.Add(Me.BtnAnteriorTab3)
        Me.TabAsientos.Controls.Add(Me.BtnFinalizar)
        Me.TabAsientos.Location = New System.Drawing.Point(4, 5)
        Me.TabAsientos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabAsientos.Name = "TabAsientos"
        Me.TabAsientos.Padding = New System.Windows.Forms.Padding(2)
        Me.TabAsientos.Size = New System.Drawing.Size(469, 379)
        Me.TabAsientos.TabIndex = 2
        Me.TabAsientos.Text = "TabPage1"
        Me.TabAsientos.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(39, 160)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(408, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "En esta ventana se deberian elegir los asientos del vuelo que ocuparan los pasaje" &
    "ros"
        '
        'BtnAnteriorTab3
        '
        Me.BtnAnteriorTab3.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnAnteriorTab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnteriorTab3.Location = New System.Drawing.Point(4, 352)
        Me.BtnAnteriorTab3.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAnteriorTab3.Name = "BtnAnteriorTab3"
        Me.BtnAnteriorTab3.Size = New System.Drawing.Size(84, 21)
        Me.BtnAnteriorTab3.TabIndex = 5
        Me.BtnAnteriorTab3.Text = "Anterior"
        Me.BtnAnteriorTab3.UseVisualStyleBackColor = False
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizar.Location = New System.Drawing.Point(383, 352)
        Me.BtnFinalizar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(84, 21)
        Me.BtnFinalizar.TabIndex = 4
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 386)
        Me.Controls.Add(Me.TabControlVentas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        Me.TabControlVentas.ResumeLayout(False)
        Me.TabVuelos.ResumeLayout(False)
        Me.TabVuelos.PerformLayout()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPasajeros.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridPasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAsientos.ResumeLayout(False)
        Me.TabAsientos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlVentas As TabControl
    Friend WithEvents TabVuelos As TabPage
    Friend WithEvents TabPasajeros As TabPage
    Friend WithEvents BtnSiguienteTab1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents GridVuelos As DataGridView
    Friend WithEvents BtnAnteriorTab2 As Button
    Friend WithEvents BtnSiguienteTab2 As Button
    Friend WithEvents TabAsientos As TabPage
    Friend WithEvents BtnAnteriorTab3 As Button
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents GridPasajeros As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioMasculino As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPasaporte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFechaNac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents RadioFemenino As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnRegistrar As Button
End Class
