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
        Me.TabsVenta = New System.Windows.Forms.TabControl()
        Me.TabBusqueda = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CheckAvanzadas = New System.Windows.Forms.CheckBox()
        Me.GroupOpciones = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboClase = New System.Windows.Forms.ComboBox()
        Me.ComboEscalas = New System.Windows.Forms.ComboBox()
        Me.TxtPasajeros = New System.Windows.Forms.TextBox()
        Me.DatePickerVuelta = New System.Windows.Forms.DateTimePicker()
        Me.DatePickerIda = New System.Windows.Forms.DateTimePicker()
        Me.TabsDestinos = New System.Windows.Forms.TabControl()
        Me.TabDestino1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkAgregarTramo = New System.Windows.Forms.LinkLabel()
        Me.ComboOrigen = New System.Windows.Forms.ComboBox()
        Me.ComboDestino = New System.Windows.Forms.ComboBox()
        Me.RadioMulti = New System.Windows.Forms.RadioButton()
        Me.RadioIda = New System.Windows.Forms.RadioButton()
        Me.RadioIdaVuelta = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabsVenta.SuspendLayout()
        Me.TabBusqueda.SuspendLayout()
        Me.GroupOpciones.SuspendLayout()
        Me.TabsDestinos.SuspendLayout()
        Me.TabDestino1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabsVenta
        '
        Me.TabsVenta.Controls.Add(Me.TabBusqueda)
        Me.TabsVenta.Controls.Add(Me.TabPage2)
        Me.TabsVenta.Location = New System.Drawing.Point(0, 0)
        Me.TabsVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TabsVenta.Name = "TabsVenta"
        Me.TabsVenta.SelectedIndex = 0
        Me.TabsVenta.Size = New System.Drawing.Size(471, 592)
        Me.TabsVenta.TabIndex = 0
        '
        'TabBusqueda
        '
        Me.TabBusqueda.Controls.Add(Me.Label5)
        Me.TabBusqueda.Controls.Add(Me.Label4)
        Me.TabBusqueda.Controls.Add(Me.Label3)
        Me.TabBusqueda.Controls.Add(Me.BtnBuscar)
        Me.TabBusqueda.Controls.Add(Me.CheckAvanzadas)
        Me.TabBusqueda.Controls.Add(Me.GroupOpciones)
        Me.TabBusqueda.Controls.Add(Me.TxtPasajeros)
        Me.TabBusqueda.Controls.Add(Me.DatePickerVuelta)
        Me.TabBusqueda.Controls.Add(Me.DatePickerIda)
        Me.TabBusqueda.Controls.Add(Me.TabsDestinos)
        Me.TabBusqueda.Controls.Add(Me.RadioMulti)
        Me.TabBusqueda.Controls.Add(Me.RadioIda)
        Me.TabBusqueda.Controls.Add(Me.RadioIdaVuelta)
        Me.TabBusqueda.Location = New System.Drawing.Point(4, 25)
        Me.TabBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.TabBusqueda.Name = "TabBusqueda"
        Me.TabBusqueda.Padding = New System.Windows.Forms.Padding(4)
        Me.TabBusqueda.Size = New System.Drawing.Size(463, 563)
        Me.TabBusqueda.TabIndex = 0
        Me.TabBusqueda.Text = "Busqueda"
        Me.TabBusqueda.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Pasajeros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha Regreso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Fecha Partida"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(336, 526)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(119, 32)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CheckAvanzadas
        '
        Me.CheckAvanzadas.AutoSize = True
        Me.CheckAvanzadas.Location = New System.Drawing.Point(11, 403)
        Me.CheckAvanzadas.Name = "CheckAvanzadas"
        Me.CheckAvanzadas.Size = New System.Drawing.Size(163, 21)
        Me.CheckAvanzadas.TabIndex = 10
        Me.CheckAvanzadas.Text = "Opciones avanzadas"
        Me.CheckAvanzadas.UseVisualStyleBackColor = True
        '
        'GroupOpciones
        '
        Me.GroupOpciones.Controls.Add(Me.Label7)
        Me.GroupOpciones.Controls.Add(Me.Label6)
        Me.GroupOpciones.Controls.Add(Me.ComboClase)
        Me.GroupOpciones.Controls.Add(Me.ComboEscalas)
        Me.GroupOpciones.Location = New System.Drawing.Point(8, 430)
        Me.GroupOpciones.Name = "GroupOpciones"
        Me.GroupOpciones.Size = New System.Drawing.Size(440, 81)
        Me.GroupOpciones.TabIndex = 9
        Me.GroupOpciones.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Clase de Boleto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Escalas"
        '
        'ComboClase
        '
        Me.ComboClase.FormattingEnabled = True
        Me.ComboClase.Items.AddRange(New Object() {"Indistinto", "Turista", "Premium Economy", "Ejecutiva", "Primera Clase"})
        Me.ComboClase.Location = New System.Drawing.Point(218, 38)
        Me.ComboClase.Name = "ComboClase"
        Me.ComboClase.Size = New System.Drawing.Size(184, 24)
        Me.ComboClase.TabIndex = 1
        '
        'ComboEscalas
        '
        Me.ComboEscalas.FormattingEnabled = True
        Me.ComboEscalas.Items.AddRange(New Object() {"Indistinto", "Vuelo Directo", "Hasta 1 Escala", "Hasta 2 Escalas", "Hasta 3 Escalas", "Hasta 4 Escalas", "Hasta 5 Escalas", "Hasta 6 Escalas", "Hasta 7 Escalas", "Hasta 8 Escalas"})
        Me.ComboEscalas.Location = New System.Drawing.Point(3, 38)
        Me.ComboEscalas.Name = "ComboEscalas"
        Me.ComboEscalas.Size = New System.Drawing.Size(190, 24)
        Me.ComboEscalas.TabIndex = 0
        '
        'TxtPasajeros
        '
        Me.TxtPasajeros.Location = New System.Drawing.Point(11, 344)
        Me.TxtPasajeros.Name = "TxtPasajeros"
        Me.TxtPasajeros.Size = New System.Drawing.Size(100, 22)
        Me.TxtPasajeros.TabIndex = 8
        '
        'DatePickerVuelta
        '
        Me.DatePickerVuelta.Location = New System.Drawing.Point(255, 269)
        Me.DatePickerVuelta.Name = "DatePickerVuelta"
        Me.DatePickerVuelta.Size = New System.Drawing.Size(195, 22)
        Me.DatePickerVuelta.TabIndex = 7
        '
        'DatePickerIda
        '
        Me.DatePickerIda.Location = New System.Drawing.Point(11, 269)
        Me.DatePickerIda.Name = "DatePickerIda"
        Me.DatePickerIda.Size = New System.Drawing.Size(195, 22)
        Me.DatePickerIda.TabIndex = 6
        '
        'TabsDestinos
        '
        Me.TabsDestinos.Controls.Add(Me.TabDestino1)
        Me.TabsDestinos.Location = New System.Drawing.Point(7, 76)
        Me.TabsDestinos.Name = "TabsDestinos"
        Me.TabsDestinos.SelectedIndex = 0
        Me.TabsDestinos.Size = New System.Drawing.Size(453, 145)
        Me.TabsDestinos.TabIndex = 5
        '
        'TabDestino1
        '
        Me.TabDestino1.Controls.Add(Me.Label2)
        Me.TabDestino1.Controls.Add(Me.Label1)
        Me.TabDestino1.Controls.Add(Me.LinkAgregarTramo)
        Me.TabDestino1.Controls.Add(Me.ComboOrigen)
        Me.TabDestino1.Controls.Add(Me.ComboDestino)
        Me.TabDestino1.Location = New System.Drawing.Point(4, 25)
        Me.TabDestino1.Name = "TabDestino1"
        Me.TabDestino1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDestino1.Size = New System.Drawing.Size(445, 116)
        Me.TabDestino1.TabIndex = 0
        Me.TabDestino1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Origen"
        '
        'LinkAgregarTramo
        '
        Me.LinkAgregarTramo.AutoSize = True
        Me.LinkAgregarTramo.LinkColor = System.Drawing.Color.Green
        Me.LinkAgregarTramo.Location = New System.Drawing.Point(3, 96)
        Me.LinkAgregarTramo.Name = "LinkAgregarTramo"
        Me.LinkAgregarTramo.Size = New System.Drawing.Size(99, 17)
        Me.LinkAgregarTramo.TabIndex = 5
        Me.LinkAgregarTramo.TabStop = True
        Me.LinkAgregarTramo.Text = "Agregar tramo"
        Me.LinkAgregarTramo.VisitedLinkColor = System.Drawing.Color.Green
        '
        'ComboOrigen
        '
        Me.ComboOrigen.FormattingEnabled = True
        Me.ComboOrigen.Location = New System.Drawing.Point(6, 42)
        Me.ComboOrigen.Name = "ComboOrigen"
        Me.ComboOrigen.Size = New System.Drawing.Size(189, 24)
        Me.ComboOrigen.TabIndex = 3
        '
        'ComboDestino
        '
        Me.ComboDestino.FormattingEnabled = True
        Me.ComboDestino.Location = New System.Drawing.Point(244, 42)
        Me.ComboDestino.Name = "ComboDestino"
        Me.ComboDestino.Size = New System.Drawing.Size(195, 24)
        Me.ComboDestino.TabIndex = 4
        '
        'RadioMulti
        '
        Me.RadioMulti.AutoSize = True
        Me.RadioMulti.Location = New System.Drawing.Point(339, 29)
        Me.RadioMulti.Name = "RadioMulti"
        Me.RadioMulti.Size = New System.Drawing.Size(111, 21)
        Me.RadioMulti.TabIndex = 2
        Me.RadioMulti.Text = "Multi-Destino"
        Me.RadioMulti.UseVisualStyleBackColor = True
        '
        'RadioIda
        '
        Me.RadioIda.AutoSize = True
        Me.RadioIda.Location = New System.Drawing.Point(175, 29)
        Me.RadioIda.Name = "RadioIda"
        Me.RadioIda.Size = New System.Drawing.Size(80, 21)
        Me.RadioIda.TabIndex = 1
        Me.RadioIda.Text = "Solo Ida"
        Me.RadioIda.UseVisualStyleBackColor = True
        '
        'RadioIdaVuelta
        '
        Me.RadioIdaVuelta.AutoSize = True
        Me.RadioIdaVuelta.Checked = True
        Me.RadioIdaVuelta.Location = New System.Drawing.Point(11, 29)
        Me.RadioIdaVuelta.Name = "RadioIdaVuelta"
        Me.RadioIdaVuelta.Size = New System.Drawing.Size(103, 21)
        Me.RadioIdaVuelta.TabIndex = 0
        Me.RadioIdaVuelta.TabStop = True
        Me.RadioIdaVuelta.Text = "Ida y Vuelta"
        Me.RadioIdaVuelta.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(463, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 591)
        Me.Controls.Add(Me.TabsVenta)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        Me.TabsVenta.ResumeLayout(False)
        Me.TabBusqueda.ResumeLayout(False)
        Me.TabBusqueda.PerformLayout()
        Me.GroupOpciones.ResumeLayout(False)
        Me.GroupOpciones.PerformLayout()
        Me.TabsDestinos.ResumeLayout(False)
        Me.TabDestino1.ResumeLayout(False)
        Me.TabDestino1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabsVenta As TabControl
    Friend WithEvents TabBusqueda As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CheckAvanzadas As CheckBox
    Friend WithEvents GroupOpciones As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboClase As ComboBox
    Friend WithEvents ComboEscalas As ComboBox
    Friend WithEvents TxtPasajeros As TextBox
    Friend WithEvents DatePickerVuelta As DateTimePicker
    Friend WithEvents DatePickerIda As DateTimePicker
    Friend WithEvents TabsDestinos As TabControl
    Friend WithEvents TabDestino1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkAgregarTramo As LinkLabel
    Friend WithEvents ComboOrigen As ComboBox
    Friend WithEvents ComboDestino As ComboBox
    Friend WithEvents RadioMulti As RadioButton
    Friend WithEvents RadioIda As RadioButton
    Friend WithEvents RadioIdaVuelta As RadioButton
    Friend WithEvents Label7 As Label
End Class
