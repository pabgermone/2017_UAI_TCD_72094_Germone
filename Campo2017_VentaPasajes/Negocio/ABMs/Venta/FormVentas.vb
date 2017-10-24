Imports BLL
Imports Framework

Public Class FormVentas

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Tab Busqueda"
        ComboEscalas.SelectedIndex = 0
        ComboEscalas.Enabled = False

        ComboClase.SelectedIndex = 0
        ComboClase.Enabled = False

        Dim mDestinos As List(Of DestinoBLL) = DestinoBLL.ListarDestinos

        If Not IsNothing(mDestinos) Then
            ComboOrigen.DataSource = mDestinos
            ComboDestino.DataSource = mDestinos
        End If
#End Region
    End Sub


#Region "Tab Busqueda"
    Dim mOrigen As DestinoBLL
    Dim mDestino As DestinoBLL

    Dim mFechaPartida As Date
    Dim mFechaVuelta As Date

    Dim mCantPasajeros As Integer

    Dim mCantEscalas As Integer
    Dim mClase As String

#Region "Eventos"

    Private Sub RadioIdaVuelta_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIdaVuelta.CheckedChanged
        If RadioIdaVuelta.Checked Then
            DatePickerVuelta.Enabled = True
            LinkAgregarTramo.Visible = False
        End If
    End Sub


    Private Sub RadioIda_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIda.CheckedChanged
        If RadioIda.Checked Then
            DatePickerVuelta.Enabled = False
            LinkAgregarTramo.Visible = False
        End If
    End Sub


    Private Sub RadioMulti_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMulti.CheckedChanged
        If RadioMulti.Checked Then
            DatePickerVuelta.Enabled = False
            LinkAgregarTramo.Visible = True
        End If
    End Sub


    Private Sub CheckAvanzadas_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAvanzadas.CheckedChanged
        If Not CheckAvanzadas.Checked Then
            ComboEscalas.Enabled = False
            ComboClase.Enabled = False
        Else
            ComboEscalas.Enabled = True
            ComboClase.Enabled = True
        End If
    End Sub


    Private Sub ComboOrigen_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboOrigen.SelectedValueChanged
        If TypeOf ComboOrigen.SelectedItem Is DestinoBLL Then
            mOrigen = ComboOrigen.SelectedItem
        End If
    End Sub


    Private Sub ComboDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboDestino.SelectedValueChanged
        If TypeOf ComboDestino.SelectedItem Is DestinoBLL Then
            mDestino = ComboDestino.SelectedItem
        End If
    End Sub


    Private Sub ComboEscalas_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboEscalas.SelectedValueChanged
        mCantEscalas = ComboEscalas.SelectedIndex - 1
    End Sub


    Private Sub ComboClase_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClase.SelectedValueChanged
        If Not ComboClase.SelectedIndex = 0 Then
            mClase = ComboClase.SelectedItem.ToString
        End If
    End Sub

#End Region

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim mListaAerolineas As List(Of AerolineaBLL) = AerolineaBLL.ListarAerolineas
        Dim mListaVuelos As New List(Of VueloBLL)

        If Not IsNothing(mListaAerolineas) Then
            For Each mAerolinea As AerolineaBLL In mListaAerolineas
                'Metodo filtrar de AerolineaBLL
            Next
        End If
    End Sub









#End Region

#Region "Codigo viejo"
    '    'Variables generales
    '    Dim mUsuarioActivo As UsuarioBLL

    '    'Variables de TabVuelos
    '    Dim mVueloSelec As VueloBLL

    '    'Variables de TabPasajeros
    '    Dim mClienteSelec As ClienteBLL
    '    Dim mPasajeros As New List(Of ClienteBLL)


    '#Region "Principal"

    '    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        'TabVuelos
    '        ActualizarGridVuelos()

    '        'TabPasajeros
    '        TxtNombre.Enabled = False
    '        TxtApellido.Enabled = False
    '        RadioMasculino.Enabled = False
    '        RadioFemenino.Enabled = False
    '        TxtFechaNac.Enabled = False
    '        TxtDNI.Enabled = False
    '        TxtPasaporte.Enabled = False

    '        ActualizarComboClientes()

    '        'General
    '        For Each mForm As Form In Application.OpenForms
    '            If TypeOf mForm Is FormPrincipal Then
    '                mUsuarioActivo = CType(mForm, FormPrincipal).UsuarioActivo
    '                Exit For
    '            End If
    '        Next
    '    End Sub

    '#End Region


    '#Region "TabVuelos"

    '    ''' <summary>
    '    ''' Carga con datos a GridVuelos
    '    ''' </summary>
    '    Public Sub ActualizarGridVuelos()
    '        GridVuelos.DataSource = Nothing
    '        GridVuelos.DataSource = VueloBLL.ListarVuelos
    '    End Sub


    '    ''' <summary>
    '    ''' Cambia el vuelo que se haya seleccionado en GridVuelos
    '    ''' </summary>
    '    Private Sub GridVuelos_SelectionChanged(sender As Object, e As EventArgs) Handles GridVuelos.SelectionChanged
    '        If GridVuelos.SelectedRows.Count > 0 Then
    '            If Not IsNothing(GridVuelos.SelectedRows(0).DataBoundItem) Then
    '                If TypeOf GridVuelos.SelectedRows(0).DataBoundItem Is VueloBLL Then
    '                    mVueloSelec = GridVuelos.SelectedRows(0).DataBoundItem
    '                End If
    '            End If
    '        End If
    '    End Sub


    '    Private Sub BtnSiguienteTab1_Click(sender As Object, e As EventArgs) Handles BtnSiguienteTab1.Click
    '        If Not IsNothing(mVueloSelec) Then
    '            TabControlVentas.SelectedTab = TabPasajeros
    '        Else
    '            MsgBox("Debe seleccionar un vuelo")
    '        End If
    '    End Sub

    '#End Region


    '#Region "TabPasajeros"

    '    ''' <summary>
    '    ''' Carga con datos ComboClientes
    '    ''' </summary>
    '    Public Sub ActualizarComboClientes()
    '        ComboClientes.Items.Clear()

    '        ComboClientes.Items.Add("- Seleccione un pasajero -")

    '        For Each mCliente As ClienteBLL In ClienteBLL.Listar
    '            ComboClientes.Items.Add(mCliente)
    '        Next

    '        ComboClientes.SelectedIndex = 0
    '    End Sub


    '    ''' <summary>
    '    ''' Carga GridPasajeros con los datos de los pasajeros seleccionados para el vuelo
    '    ''' </summary>
    '    Public Sub ActualizarGridPasajeros()
    '        GridPasajeros.DataSource = Nothing
    '        GridPasajeros.DataSource = mPasajeros
    '    End Sub


    '    ''' <summary>
    '    ''' Cambia el cliente que se haya seleccionado en ComboClientes
    '    ''' </summary>
    '    Private Sub ComboClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedValueChanged
    '        If Not IsNothing(ComboClientes.SelectedItem) Then
    '            If TypeOf ComboClientes.SelectedItem Is ClienteBLL Then
    '                mClienteSelec = ComboClientes.SelectedItem
    '            End If
    '        End If

    '        If Not IsNothing(mClienteSelec) Then
    '            TxtNombre.Text = mClienteSelec.Nombre
    '            TxtApellido.Text = mClienteSelec.Apellido
    '            TxtDNI.Text = mClienteSelec.DNI
    '            TxtPasaporte.Text = mClienteSelec.Pasaporte
    '            TxtFechaNac.Text = mClienteSelec.FechaNac

    '            If mClienteSelec.Sexo = "Masculino" Then
    '                RadioMasculino.Checked = True
    '            Else
    '                RadioFemenino.Checked = True
    '            End If
    '        End If
    '    End Sub


    '    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
    '        If Not IsNothing(mClienteSelec) Then
    '            mPasajeros.Add(mClienteSelec)
    '        Else
    '            MsgBox("Debe seleccionar un pasajero")
    '        End If

    '        ActualizarGridPasajeros()
    '    End Sub


    '    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
    '        Dim mForm As New AltaCliente(Me)
    '        mForm.ShowDialog()
    '    End Sub


    '    Private Sub BtnAnteriorTab2_Click(sender As Object, e As EventArgs) Handles BtnAnteriorTab2.Click
    '        TabControlVentas.SelectedTab = TabVuelos
    '    End Sub


    '    Private Sub BtnSiguienteTab2_Click(sender As Object, e As EventArgs) Handles BtnSiguienteTab2.Click
    '        If mPasajeros.Count > 0 Then
    '            TabControlVentas.SelectedTab = TabAsientos
    '        Else
    '            MsgBox("Debe agregar al menos un pasajero")
    '        End If
    '    End Sub

    '#End Region


    '#Region "TabAsientos"

    '    Private Sub BtnAnteriorTab3_Click(sender As Object, e As EventArgs) Handles BtnAnteriorTab3.Click
    '        TabControlVentas.SelectedTab = TabPasajeros
    '    End Sub


    '    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
    '        For Each mCliente As ClienteBLL In mPasajeros
    '            Dim mVenta As New VentaBLL

    '            mVenta.Usuario = mUsuarioActivo.ID
    '            mVenta.Fecha = System.DateTime.Now
    '            mVenta.Cliente = mClienteSelec.ID
    '            mVenta.Vuelo = mVueloSelec.Numero

    '            mVenta.Guardar()
    '        Next

    '        MsgBox("La venta se ha realizado con exito")

    '        Me.Close()
    '    End Sub

    '#End Region
#End Region

End Class