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
        Me.TabControlVentas.ItemSize = New System.Drawing.Size(50, 10)
        Me.TabControlVentas.Location = New System.Drawing.Point(0, 0)
        Me.TabControlVentas.Name = "TabControlVentas"
        Me.TabControlVentas.SelectedIndex = 0
        Me.TabControlVentas.Size = New System.Drawing.Size(715, 597)
        Me.TabControlVentas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlVentas.TabIndex = 0
        '
        'TabVuelos
        '
        Me.TabVuelos.Controls.Add(Me.BtnSiguienteTab1)
        Me.TabVuelos.Controls.Add(Me.Label1)
        Me.TabVuelos.Controls.Add(Me.TxtBusqueda)
        Me.TabVuelos.Controls.Add(Me.GridVuelos)
        Me.TabVuelos.Location = New System.Drawing.Point(4, 14)
        Me.TabVuelos.Name = "TabVuelos"
        Me.TabVuelos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVuelos.Size = New System.Drawing.Size(707, 579)
        Me.TabVuelos.TabIndex = 0
        Me.TabVuelos.Text = "TabPage1"
        Me.TabVuelos.UseVisualStyleBackColor = True
        '
        'BtnSiguienteTab1
        '
        Me.BtnSiguienteTab1.Location = New System.Drawing.Point(574, 541)
        Me.BtnSiguienteTab1.Name = "BtnSiguienteTab1"
        Me.BtnSiguienteTab1.Size = New System.Drawing.Size(126, 33)
        Me.BtnSiguienteTab1.TabIndex = 3
        Me.BtnSiguienteTab1.Text = "Siguiente"
        Me.BtnSiguienteTab1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(8, 26)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(347, 26)
        Me.TxtBusqueda.TabIndex = 1
        '
        'GridVuelos
        '
        Me.GridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVuelos.Location = New System.Drawing.Point(8, 58)
        Me.GridVuelos.Name = "GridVuelos"
        Me.GridVuelos.RowTemplate.Height = 28
        Me.GridVuelos.Size = New System.Drawing.Size(692, 479)
        Me.GridVuelos.TabIndex = 0
        '
        'TabPasajeros
        '
        Me.TabPasajeros.Controls.Add(Me.BtnRegistrar)
        Me.TabPasajeros.Controls.Add(Me.BtnAgregar)
        Me.TabPasajeros.Controls.Add(Me.GroupBox1)
        Me.TabPasajeros.Controls.Add(Me.ComboClientes)
        Me.TabPasajeros.Controls.Add(Me.GridPasajeros)
        Me.TabPasajeros.Controls.Add(Me.BtnAnteriorTab2)
        Me.TabPasajeros.Controls.Add(Me.BtnSiguienteTab2)
        Me.TabPasajeros.Location = New System.Drawing.Point(4, 14)
        Me.TabPasajeros.Name = "TabPasajeros"
        Me.TabPasajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPasajeros.Size = New System.Drawing.Size(707, 579)
        Me.TabPasajeros.TabIndex = 1
        Me.TabPasajeros.Text = "TabPage2"
        Me.TabPasajeros.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(8, 433)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(220, 33)
        Me.BtnRegistrar.TabIndex = 11
        Me.BtnRegistrar.Text = "Registrar nuevo Pasajero"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(8, 485)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(220, 33)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar pasajero"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 378)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sexo"
        '
        'RadioFemenino
        '
        Me.RadioFemenino.AutoSize = True
        Me.RadioFemenino.Location = New System.Drawing.Point(98, 160)
        Me.RadioFemenino.Name = "RadioFemenino"
        Me.RadioFemenino.Size = New System.Drawing.Size(44, 24)
        Me.RadioFemenino.TabIndex = 11
        Me.RadioFemenino.TabStop = True
        Me.RadioFemenino.Text = "F"
        Me.RadioFemenino.UseVisualStyleBackColor = True
        '
        'RadioMasculino
        '
        Me.RadioMasculino.AutoSize = True
        Me.RadioMasculino.Location = New System.Drawing.Point(10, 160)
        Me.RadioMasculino.Name = "RadioMasculino"
        Me.RadioMasculino.Size = New System.Drawing.Size(47, 24)
        Me.RadioMasculino.TabIndex = 10
        Me.RadioMasculino.TabStop = True
        Me.RadioMasculino.Text = "M"
        Me.RadioMasculino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pasaporte"
        '
        'TxtPasaporte
        '
        Me.TxtPasaporte.Location = New System.Drawing.Point(12, 338)
        Me.TxtPasaporte.Name = "TxtPasaporte"
        Me.TxtPasaporte.Size = New System.Drawing.Size(187, 26)
        Me.TxtPasaporte.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(12, 284)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(187, 26)
        Me.TxtDNI.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Location = New System.Drawing.Point(12, 227)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(187, 26)
        Me.TxtFechaNac.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(12, 95)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(187, 26)
        Me.TxtApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(12, 36)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(187, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'ComboClientes
        '
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Items.AddRange(New Object() {"- Seleccione un pasajero -"})
        Me.ComboClientes.Location = New System.Drawing.Point(8, 6)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(302, 28)
        Me.ComboClientes.TabIndex = 1
        '
        'GridPasajeros
        '
        Me.GridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPasajeros.Location = New System.Drawing.Point(332, 6)
        Me.GridPasajeros.Name = "GridPasajeros"
        Me.GridPasajeros.RowTemplate.Height = 28
        Me.GridPasajeros.Size = New System.Drawing.Size(368, 513)
        Me.GridPasajeros.TabIndex = 6
        '
        'BtnAnteriorTab2
        '
        Me.BtnAnteriorTab2.Location = New System.Drawing.Point(6, 541)
        Me.BtnAnteriorTab2.Name = "BtnAnteriorTab2"
        Me.BtnAnteriorTab2.Size = New System.Drawing.Size(126, 33)
        Me.BtnAnteriorTab2.TabIndex = 5
        Me.BtnAnteriorTab2.Text = "Anterior"
        Me.BtnAnteriorTab2.UseVisualStyleBackColor = True
        '
        'BtnSiguienteTab2
        '
        Me.BtnSiguienteTab2.Location = New System.Drawing.Point(574, 541)
        Me.BtnSiguienteTab2.Name = "BtnSiguienteTab2"
        Me.BtnSiguienteTab2.Size = New System.Drawing.Size(126, 33)
        Me.BtnSiguienteTab2.TabIndex = 4
        Me.BtnSiguienteTab2.Text = "Siguiente"
        Me.BtnSiguienteTab2.UseVisualStyleBackColor = True
        '
        'TabAsientos
        '
        Me.TabAsientos.Controls.Add(Me.Label8)
        Me.TabAsientos.Controls.Add(Me.BtnAnteriorTab3)
        Me.TabAsientos.Controls.Add(Me.BtnFinalizar)
        Me.TabAsientos.Location = New System.Drawing.Point(4, 14)
        Me.TabAsientos.Name = "TabAsientos"
        Me.TabAsientos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAsientos.Size = New System.Drawing.Size(707, 579)
        Me.TabAsientos.TabIndex = 2
        Me.TabAsientos.Text = "TabPage1"
        Me.TabAsientos.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(607, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "En esta ventana se deberian elegir los asientos del vuelo que ocuparan los pasaje" &
    "ros"
        '
        'BtnAnteriorTab3
        '
        Me.BtnAnteriorTab3.Location = New System.Drawing.Point(6, 541)
        Me.BtnAnteriorTab3.Name = "BtnAnteriorTab3"
        Me.BtnAnteriorTab3.Size = New System.Drawing.Size(126, 33)
        Me.BtnAnteriorTab3.TabIndex = 5
        Me.BtnAnteriorTab3.Text = "Anterior"
        Me.BtnAnteriorTab3.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(574, 541)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(126, 33)
        Me.BtnFinalizar.TabIndex = 4
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 596)
        Me.Controls.Add(Me.TabControlVentas)
        Me.Name = "FormVentas"
        Me.Text = "Form1"
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
