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
        Me.Tab1 = New System.Windows.Forms.TabPage()
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
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.lblSelecVuelo = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.GridVuelos = New System.Windows.Forms.DataGridView()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.RadioDoc = New System.Windows.Forms.RadioButton()
        Me.RadioApellido = New System.Windows.Forms.RadioButton()
        Me.BtnSiguiente2 = New System.Windows.Forms.Button()
        Me.BtnClienteNvo = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LstCtesSeleccionados = New System.Windows.Forms.ListBox()
        Me.BtnSelec = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBusquedaCte = New System.Windows.Forms.TextBox()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.Tab4 = New System.Windows.Forms.TabPage()
        Me.BtnVolver2 = New System.Windows.Forms.Button()
        Me.TxtVerificacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnVolver3 = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TabControlVentas.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.GroupOpciones.SuspendLayout()
        Me.TabsDestinos.SuspendLayout()
        Me.TabDestino1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab3.SuspendLayout()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlVentas
        '
        Me.TabControlVentas.Controls.Add(Me.Tab1)
        Me.TabControlVentas.Controls.Add(Me.Tab2)
        Me.TabControlVentas.Controls.Add(Me.Tab3)
        Me.TabControlVentas.Controls.Add(Me.Tab4)
        Me.TabControlVentas.Location = New System.Drawing.Point(0, 0)
        Me.TabControlVentas.Name = "TabControlVentas"
        Me.TabControlVentas.SelectedIndex = 0
        Me.TabControlVentas.Size = New System.Drawing.Size(353, 481)
        Me.TabControlVentas.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Label5)
        Me.Tab1.Controls.Add(Me.Label4)
        Me.Tab1.Controls.Add(Me.Label3)
        Me.Tab1.Controls.Add(Me.BtnBuscar)
        Me.Tab1.Controls.Add(Me.CheckAvanzadas)
        Me.Tab1.Controls.Add(Me.GroupOpciones)
        Me.Tab1.Controls.Add(Me.TxtPasajeros)
        Me.Tab1.Controls.Add(Me.DatePickerVuelta)
        Me.Tab1.Controls.Add(Me.DatePickerIda)
        Me.Tab1.Controls.Add(Me.TabsDestinos)
        Me.Tab1.Controls.Add(Me.RadioMulti)
        Me.Tab1.Controls.Add(Me.RadioIda)
        Me.Tab1.Controls.Add(Me.RadioIdaVuelta)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(345, 455)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Paso 1"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Pasajeros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha Regreso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Fecha Partida"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(252, 427)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(89, 26)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CheckAvanzadas
        '
        Me.CheckAvanzadas.AutoSize = True
        Me.CheckAvanzadas.Location = New System.Drawing.Point(8, 327)
        Me.CheckAvanzadas.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckAvanzadas.Name = "CheckAvanzadas"
        Me.CheckAvanzadas.Size = New System.Drawing.Size(126, 17)
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
        Me.GroupOpciones.Location = New System.Drawing.Point(6, 349)
        Me.GroupOpciones.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupOpciones.Name = "GroupOpciones"
        Me.GroupOpciones.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupOpciones.Size = New System.Drawing.Size(330, 66)
        Me.GroupOpciones.TabIndex = 9
        Me.GroupOpciones.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Clase de Boleto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Escalas"
        '
        'ComboClase
        '
        Me.ComboClase.FormattingEnabled = True
        Me.ComboClase.Items.AddRange(New Object() {"Indistinto", "Turista", "Premium Economy", "Ejecutiva", "Primera Clase"})
        Me.ComboClase.Location = New System.Drawing.Point(164, 31)
        Me.ComboClase.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboClase.Name = "ComboClase"
        Me.ComboClase.Size = New System.Drawing.Size(139, 21)
        Me.ComboClase.TabIndex = 1
        '
        'ComboEscalas
        '
        Me.ComboEscalas.FormattingEnabled = True
        Me.ComboEscalas.Items.AddRange(New Object() {"Indistinto", "Vuelo Directo", "Hasta 1 Escala", "Hasta 2 Escalas", "Hasta 3 Escalas", "Hasta 4 Escalas", "Hasta 5 Escalas", "Hasta 6 Escalas", "Hasta 7 Escalas", "Hasta 8 Escalas"})
        Me.ComboEscalas.Location = New System.Drawing.Point(2, 31)
        Me.ComboEscalas.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboEscalas.Name = "ComboEscalas"
        Me.ComboEscalas.Size = New System.Drawing.Size(144, 21)
        Me.ComboEscalas.TabIndex = 0
        '
        'TxtPasajeros
        '
        Me.TxtPasajeros.Location = New System.Drawing.Point(8, 280)
        Me.TxtPasajeros.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPasajeros.Name = "TxtPasajeros"
        Me.TxtPasajeros.Size = New System.Drawing.Size(76, 20)
        Me.TxtPasajeros.TabIndex = 8
        '
        'DatePickerVuelta
        '
        Me.DatePickerVuelta.Location = New System.Drawing.Point(191, 219)
        Me.DatePickerVuelta.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickerVuelta.Name = "DatePickerVuelta"
        Me.DatePickerVuelta.Size = New System.Drawing.Size(147, 20)
        Me.DatePickerVuelta.TabIndex = 7
        '
        'DatePickerIda
        '
        Me.DatePickerIda.Location = New System.Drawing.Point(8, 219)
        Me.DatePickerIda.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickerIda.Name = "DatePickerIda"
        Me.DatePickerIda.Size = New System.Drawing.Size(147, 20)
        Me.DatePickerIda.TabIndex = 6
        '
        'TabsDestinos
        '
        Me.TabsDestinos.Controls.Add(Me.TabDestino1)
        Me.TabsDestinos.Location = New System.Drawing.Point(5, 62)
        Me.TabsDestinos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabsDestinos.Name = "TabsDestinos"
        Me.TabsDestinos.SelectedIndex = 0
        Me.TabsDestinos.Size = New System.Drawing.Size(340, 118)
        Me.TabsDestinos.TabIndex = 5
        '
        'TabDestino1
        '
        Me.TabDestino1.Controls.Add(Me.Label2)
        Me.TabDestino1.Controls.Add(Me.Label1)
        Me.TabDestino1.Controls.Add(Me.LinkAgregarTramo)
        Me.TabDestino1.Controls.Add(Me.ComboOrigen)
        Me.TabDestino1.Controls.Add(Me.ComboDestino)
        Me.TabDestino1.Location = New System.Drawing.Point(4, 22)
        Me.TabDestino1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabDestino1.Name = "TabDestino1"
        Me.TabDestino1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabDestino1.Size = New System.Drawing.Size(332, 92)
        Me.TabDestino1.TabIndex = 0
        Me.TabDestino1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Origen"
        '
        'LinkAgregarTramo
        '
        Me.LinkAgregarTramo.AutoSize = True
        Me.LinkAgregarTramo.Enabled = False
        Me.LinkAgregarTramo.LinkColor = System.Drawing.Color.Green
        Me.LinkAgregarTramo.Location = New System.Drawing.Point(2, 78)
        Me.LinkAgregarTramo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkAgregarTramo.Name = "LinkAgregarTramo"
        Me.LinkAgregarTramo.Size = New System.Drawing.Size(73, 13)
        Me.LinkAgregarTramo.TabIndex = 5
        Me.LinkAgregarTramo.TabStop = True
        Me.LinkAgregarTramo.Text = "Agregar tramo"
        Me.LinkAgregarTramo.VisitedLinkColor = System.Drawing.Color.Green
        '
        'ComboOrigen
        '
        Me.ComboOrigen.FormattingEnabled = True
        Me.ComboOrigen.Location = New System.Drawing.Point(4, 34)
        Me.ComboOrigen.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboOrigen.Name = "ComboOrigen"
        Me.ComboOrigen.Size = New System.Drawing.Size(143, 21)
        Me.ComboOrigen.TabIndex = 3
        '
        'ComboDestino
        '
        Me.ComboDestino.FormattingEnabled = True
        Me.ComboDestino.Location = New System.Drawing.Point(183, 34)
        Me.ComboDestino.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboDestino.Name = "ComboDestino"
        Me.ComboDestino.Size = New System.Drawing.Size(147, 21)
        Me.ComboDestino.TabIndex = 4
        '
        'RadioMulti
        '
        Me.RadioMulti.AutoSize = True
        Me.RadioMulti.Enabled = False
        Me.RadioMulti.Location = New System.Drawing.Point(254, 24)
        Me.RadioMulti.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioMulti.Name = "RadioMulti"
        Me.RadioMulti.Size = New System.Drawing.Size(86, 17)
        Me.RadioMulti.TabIndex = 2
        Me.RadioMulti.Text = "Multi-Destino"
        Me.RadioMulti.UseVisualStyleBackColor = True
        '
        'RadioIda
        '
        Me.RadioIda.AutoSize = True
        Me.RadioIda.Location = New System.Drawing.Point(131, 24)
        Me.RadioIda.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioIda.Name = "RadioIda"
        Me.RadioIda.Size = New System.Drawing.Size(64, 17)
        Me.RadioIda.TabIndex = 1
        Me.RadioIda.Text = "Solo Ida"
        Me.RadioIda.UseVisualStyleBackColor = True
        '
        'RadioIdaVuelta
        '
        Me.RadioIdaVuelta.AutoSize = True
        Me.RadioIdaVuelta.Checked = True
        Me.RadioIdaVuelta.Location = New System.Drawing.Point(8, 24)
        Me.RadioIdaVuelta.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioIdaVuelta.Name = "RadioIdaVuelta"
        Me.RadioIdaVuelta.Size = New System.Drawing.Size(81, 17)
        Me.RadioIdaVuelta.TabIndex = 0
        Me.RadioIdaVuelta.TabStop = True
        Me.RadioIdaVuelta.Text = "Ida y Vuelta"
        Me.RadioIdaVuelta.UseVisualStyleBackColor = True
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.lblSelecVuelo)
        Me.Tab2.Controls.Add(Me.BtnVolver)
        Me.Tab2.Controls.Add(Me.BtnSiguiente)
        Me.Tab2.Controls.Add(Me.GridVuelos)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(345, 455)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Paso 2"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'lblSelecVuelo
        '
        Me.lblSelecVuelo.AutoSize = True
        Me.lblSelecVuelo.Location = New System.Drawing.Point(5, 12)
        Me.lblSelecVuelo.Name = "lblSelecVuelo"
        Me.lblSelecVuelo.Size = New System.Drawing.Size(104, 13)
        Me.lblSelecVuelo.TabIndex = 3
        Me.lblSelecVuelo.Text = "Seleccione un vuelo"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(8, 426)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 2
        Me.BtnVolver.Text = "<< Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(263, 426)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.BtnSiguiente.TabIndex = 1
        Me.BtnSiguiente.Text = "Siguiente >>"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'GridVuelos
        '
        Me.GridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVuelos.Location = New System.Drawing.Point(8, 28)
        Me.GridVuelos.Name = "GridVuelos"
        Me.GridVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridVuelos.Size = New System.Drawing.Size(330, 386)
        Me.GridVuelos.TabIndex = 1
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.BtnVolver2)
        Me.Tab3.Controls.Add(Me.RadioDoc)
        Me.Tab3.Controls.Add(Me.RadioApellido)
        Me.Tab3.Controls.Add(Me.BtnSiguiente2)
        Me.Tab3.Controls.Add(Me.BtnClienteNvo)
        Me.Tab3.Controls.Add(Me.BtnQuitar)
        Me.Tab3.Controls.Add(Me.Label10)
        Me.Tab3.Controls.Add(Me.LstCtesSeleccionados)
        Me.Tab3.Controls.Add(Me.BtnSelec)
        Me.Tab3.Controls.Add(Me.Label9)
        Me.Tab3.Controls.Add(Me.Label8)
        Me.Tab3.Controls.Add(Me.TxtBusquedaCte)
        Me.Tab3.Controls.Add(Me.GridClientes)
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab3.Size = New System.Drawing.Size(345, 455)
        Me.Tab3.TabIndex = 2
        Me.Tab3.Text = "Paso 3"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'RadioDoc
        '
        Me.RadioDoc.AutoSize = True
        Me.RadioDoc.Location = New System.Drawing.Point(249, 54)
        Me.RadioDoc.Name = "RadioDoc"
        Me.RadioDoc.Size = New System.Drawing.Size(97, 17)
        Me.RadioDoc.TabIndex = 12
        Me.RadioDoc.TabStop = True
        Me.RadioDoc.Text = "Por documento"
        Me.RadioDoc.UseVisualStyleBackColor = True
        '
        'RadioApellido
        '
        Me.RadioApellido.AutoSize = True
        Me.RadioApellido.Location = New System.Drawing.Point(162, 54)
        Me.RadioApellido.Name = "RadioApellido"
        Me.RadioApellido.Size = New System.Drawing.Size(80, 17)
        Me.RadioApellido.TabIndex = 11
        Me.RadioApellido.TabStop = True
        Me.RadioApellido.Text = "Por apellido"
        Me.RadioApellido.UseVisualStyleBackColor = True
        '
        'BtnSiguiente2
        '
        Me.BtnSiguiente2.Location = New System.Drawing.Point(264, 426)
        Me.BtnSiguiente2.Name = "BtnSiguiente2"
        Me.BtnSiguiente2.Size = New System.Drawing.Size(75, 23)
        Me.BtnSiguiente2.TabIndex = 10
        Me.BtnSiguiente2.Text = "Siguiente >>"
        Me.BtnSiguiente2.UseVisualStyleBackColor = True
        '
        'BtnClienteNvo
        '
        Me.BtnClienteNvo.Location = New System.Drawing.Point(93, 235)
        Me.BtnClienteNvo.Name = "BtnClienteNvo"
        Me.BtnClienteNvo.Size = New System.Drawing.Size(89, 23)
        Me.BtnClienteNvo.TabIndex = 9
        Me.BtnClienteNvo.Text = "Nuevo cliente"
        Me.BtnClienteNvo.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(188, 293)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(94, 23)
        Me.BtnQuitar.TabIndex = 8
        Me.BtnQuitar.Text = "Quitar pasajero"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 277)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Pasajeros seleccionados"
        '
        'LstCtesSeleccionados
        '
        Me.LstCtesSeleccionados.Enabled = False
        Me.LstCtesSeleccionados.FormattingEnabled = True
        Me.LstCtesSeleccionados.Location = New System.Drawing.Point(6, 293)
        Me.LstCtesSeleccionados.Margin = New System.Windows.Forms.Padding(2)
        Me.LstCtesSeleccionados.Name = "LstCtesSeleccionados"
        Me.LstCtesSeleccionados.Size = New System.Drawing.Size(177, 121)
        Me.LstCtesSeleccionados.TabIndex = 6
        '
        'BtnSelec
        '
        Me.BtnSelec.Location = New System.Drawing.Point(5, 235)
        Me.BtnSelec.Name = "BtnSelec"
        Me.BtnSelec.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelec.TabIndex = 5
        Me.BtnSelec.Text = "Seleccionar"
        Me.BtnSelec.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 37)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Buscar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Seleccionar pasajeros"
        '
        'TxtBusquedaCte
        '
        Me.TxtBusquedaCte.Location = New System.Drawing.Point(5, 53)
        Me.TxtBusquedaCte.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaCte.Name = "TxtBusquedaCte"
        Me.TxtBusquedaCte.Size = New System.Drawing.Size(152, 20)
        Me.TxtBusquedaCte.TabIndex = 2
        '
        'GridClientes
        '
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Location = New System.Drawing.Point(6, 76)
        Me.GridClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.RowTemplate.Height = 24
        Me.GridClientes.Size = New System.Drawing.Size(336, 154)
        Me.GridClientes.TabIndex = 1
        '
        'Tab4
        '
        Me.Tab4.Controls.Add(Me.BtnFinalizar)
        Me.Tab4.Controls.Add(Me.BtnVolver3)
        Me.Tab4.Controls.Add(Me.Label11)
        Me.Tab4.Controls.Add(Me.TxtVerificacion)
        Me.Tab4.Location = New System.Drawing.Point(4, 22)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab4.Size = New System.Drawing.Size(345, 455)
        Me.Tab4.TabIndex = 3
        Me.Tab4.Text = "Paso 4"
        Me.Tab4.UseVisualStyleBackColor = True
        '
        'BtnVolver2
        '
        Me.BtnVolver2.Location = New System.Drawing.Point(6, 426)
        Me.BtnVolver2.Name = "BtnVolver2"
        Me.BtnVolver2.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver2.TabIndex = 13
        Me.BtnVolver2.Text = "<< Volver"
        Me.BtnVolver2.UseVisualStyleBackColor = True
        '
        'TxtVerificacion
        '
        Me.TxtVerificacion.Enabled = False
        Me.TxtVerificacion.Location = New System.Drawing.Point(8, 28)
        Me.TxtVerificacion.Multiline = True
        Me.TxtVerificacion.Name = "TxtVerificacion"
        Me.TxtVerificacion.Size = New System.Drawing.Size(330, 383)
        Me.TxtVerificacion.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Verifique los datos"
        '
        'BtnVolver3
        '
        Me.BtnVolver3.Location = New System.Drawing.Point(6, 426)
        Me.BtnVolver3.Name = "BtnVolver3"
        Me.BtnVolver3.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver3.TabIndex = 14
        Me.BtnVolver3.Text = "<< Volver"
        Me.BtnVolver3.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(264, 426)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFinalizar.TabIndex = 15
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 480)
        Me.Controls.Add(Me.TabControlVentas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        Me.TabControlVentas.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.GroupOpciones.ResumeLayout(False)
        Me.GroupOpciones.PerformLayout()
        Me.TabsDestinos.ResumeLayout(False)
        Me.TabDestino1.ResumeLayout(False)
        Me.TabDestino1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        CType(Me.GridVuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab3.ResumeLayout(False)
        Me.Tab3.PerformLayout()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab4.ResumeLayout(False)
        Me.Tab4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlVentas As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents Tab2 As TabPage
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
    Friend WithEvents lblSelecVuelo As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents GridVuelos As DataGridView
    Friend WithEvents Tab3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents LstCtesSeleccionados As ListBox
    Friend WithEvents BtnSelec As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBusquedaCte As TextBox
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents BtnSiguiente2 As Button
    Friend WithEvents BtnClienteNvo As Button
    Friend WithEvents BtnQuitar As Button
    Friend WithEvents RadioDoc As RadioButton
    Friend WithEvents RadioApellido As RadioButton
    Friend WithEvents Tab4 As TabPage
    Friend WithEvents BtnVolver2 As Button
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents BtnVolver3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtVerificacion As TextBox
End Class
