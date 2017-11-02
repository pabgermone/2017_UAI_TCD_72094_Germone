Imports BLL
Imports Framework
Imports System.Text

Public Class FormVentas
    Dim mVuelosEncontrados As New List(Of VueloBLL)
    Dim mVueloSelec As VueloBLL
    Dim mListaVuelosSelec As New List(Of VueloBLL)

    Dim mTipoViaje As String
    Dim mCantTramos As Integer = 1

    Dim mClienteSelec As ClienteBLL
    Dim mListaClientes As List(Of ClienteBLL)
    Dim mClientesFiltrados As New List(Of ClienteBLL)
    Dim mPasajeros As New List(Of ClienteBLL)
    Dim mTipoBusqueda As String


    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Tab 1"
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

#Region "Tab 3"

        mListaClientes = ClienteBLL.Listar

        If Not IsNothing(mListaClientes) Then
            ActualizarClientes(mListaClientes)
        End If

#End Region
    End Sub


#Region "Tab 1"

    Dim mOrigen As DestinoBLL
    Dim mDestino As DestinoBLL

    Dim mCantEscalas As Integer
    Dim mClase As String

#Region "Eventos"

    Private Sub RadioIdaVuelta_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIdaVuelta.CheckedChanged
        If RadioIdaVuelta.Checked Then
            DatePickerVuelta.Enabled = True
            LinkAgregarTramo.Visible = False
            mTipoViaje = "IdaVuelta"
        End If
    End Sub


    Private Sub RadioIda_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIda.CheckedChanged
        If RadioIda.Checked Then
            DatePickerVuelta.Enabled = False
            LinkAgregarTramo.Visible = False
            mTipoViaje = "Ida"
        End If
    End Sub


    'Private Sub RadioMulti_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMulti.CheckedChanged
    '    If RadioMulti.Checked Then
    '        DatePickerVuelta.Enabled = False
    '        LinkAgregarTramo.Visible = True
    '        mTipoViaje = "Multi"
    '    End If
    'End Sub


    'Private Sub LinkAgregarTramo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAgregarTramo.LinkClicked
    '    mCantTramos += 1
    '    Dim mTab As New TabPage

    '    mTab.Name = "Destino " & mCantTramos
    '    mTab.Text = "Tramo " & mCantTramos

    '    TabsDestinos.
    'End Sub


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
        mVuelosEncontrados = Buscar(DatePickerIda.Value, mOrigen, mDestino, TxtPasajeros.Text, IIf(CheckAvanzadas.Checked, True, Nothing), IIf(CheckAvanzadas.Checked, mCantEscalas, Nothing), IIf(CheckAvanzadas.Checked, mClase, Nothing))

        TabControlVentas.SelectedTab = Tab2

#Region "Tab 2"
        ActualizarVuelos()

        If mTipoViaje = "Ida" Then
            lblSelecVuelo.Text = "Seleccione un vuelo"
        Else
            lblSelecVuelo.Text = "Seleccione el vuelo de ida"
        End If
#End Region

    End Sub

#End Region


#Region "Tab 2"

#Region "Eventos"

    Private Sub GridVuelos_SelectionChanged(sender As Object, e As EventArgs) Handles GridVuelos.SelectionChanged
        If GridVuelos.CurrentRow.Index > -1 And GridVuelos.SelectedRows.Count > 0 Then
            If Not IsNothing(GridVuelos.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridVuelos.SelectedRows(0).DataBoundItem) Is VueloBLL Then
                    mVueloSelec = GridVuelos.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub

#End Region

#Region "Navegacion"

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Select Case mTipoViaje
            Case "Ida"
                TabControlVentas.SelectedTab = Tab1
            Case "IdaVuelta"
                If mListaVuelosSelec.Count = 2 Then '(Volviendo desde la seleccion del vieje de vuelta)
                    mListaVuelosSelec.RemoveAt(1)

                    mVuelosEncontrados = Buscar(DatePickerIda.Value, mOrigen, mDestino, TxtPasajeros.Text, IIf(CheckAvanzadas.Checked, True, Nothing), IIf(CheckAvanzadas.Checked, mCantEscalas, Nothing), IIf(CheckAvanzadas.Checked, mClase, Nothing))

                    ActualizarVuelos()

                    lblSelecVuelo.Text = "Seleccione el vieje de ida"
                Else '(Volviendo desde la seleccion del viaje de ida)
                    mListaVuelosSelec.Clear()

                    TabControlVentas.SelectedTab = Tab1
                End If
        End Select
    End Sub


    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Select Case mTipoViaje
            Case "Ida"
                TabControlVentas.SelectedTab = Tab3
            Case "IdaVuelta"
                If mListaVuelosSelec.Count = 0 Then '(Eligiendo vieje de ida)
                    mListaVuelosSelec.Add(mVueloSelec)

                    'Busqueda de los vuelos de vuelta
                    mVuelosEncontrados = Buscar(DatePickerIda.Value, mDestino, mOrigen, TxtPasajeros.Text, IIf(CheckAvanzadas.Checked, True, Nothing), IIf(CheckAvanzadas.Checked, mCantEscalas, Nothing), IIf(CheckAvanzadas.Checked, mClase, Nothing))

                    ActualizarVuelos()

                    lblSelecVuelo.Text = "Seleccione el vuelo de vuelta"
                Else '(Eligiendo viaje de vuelta)
                    mListaVuelosSelec.Add(mVueloSelec)

                    TabControlVentas.SelectedTab = Tab3
                End If
        End Select
    End Sub

#End Region

    Public Sub ActualizarVuelos()
        GridVuelos.DataSource = Nothing
        GridVuelos.DataSource = mVuelosEncontrados
    End Sub

#End Region


#Region "Tab 3"

#Region "Eventos"

    Private Sub GridClientes_SelectionChanged(sender As Object, e As EventArgs) Handles GridClientes.SelectionChanged
        If GridClientes.CurrentRow.Index > -1 And GridClientes.SelectedRows.Count > 0 Then
            If Not IsNothing(GridClientes.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridClientes.SelectedRows(0).DataBoundItem) Is VueloBLL Then
                    mClienteSelec = GridClientes.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub


    Private Sub RadioApellido_CheckedChanged(sender As Object, e As EventArgs) Handles RadioApellido.CheckedChanged
        If RadioApellido.Checked Then
            mTipoBusqueda = "Apellido"
        Else
            mTipoBusqueda = "Documento"
        End If
    End Sub


    Private Sub TxtBusquedaCte_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaCte.TextChanged
        If Not TxtBusquedaCte.Text = "" Then
            If Not IsNothing(mListaClientes) Then
                mClientesFiltrados.Clear()

                For Each mCliente As ClienteBLL In mListaClientes
                    If mTipoBusqueda = "Apellido" Then
                        If RegularExpressions.Regex.IsMatch(mCliente.Apellido, "^" & TxtBusquedaCte.Text) Then
                            mClientesFiltrados.Add(mCliente)
                        End If
                    Else
                        If RegularExpressions.Regex.IsMatch(mCliente.NumeroDocumento.ToString, "^" & TxtBusquedaCte.Text) Then
                            mClientesFiltrados.Add(mCliente)
                        End If
                    End If
                Next

                ActualizarClientes(mClientesFiltrados)
            End If
        Else
            ActualizarClientes(mListaClientes)
        End If

    End Sub

#End Region

#Region "Navegacion"

    Private Sub BtnVolver2_Click(sender As Object, e As EventArgs) Handles BtnVolver2.Click
        mPasajeros.Clear()
        TxtBusquedaCte.Text = ""

        ActualizarLstClientes()

        TabControlVentas.SelectedTab = Tab2
    End Sub


    Private Sub BtnSiguiente2_Click(sender As Object, e As EventArgs) Handles BtnSiguiente2.Click
        TabControlVentas.SelectedTab = Tab4

#Region "Tab 4"

        TxtVerificacion.Text = "Pasajeros:" & vbCrLf

        For Each mCliente As ClienteBLL In mPasajeros
            TxtVerificacion.Text &= mCliente.ToString & " " & mCliente.TipoDocumento & ": " & mCliente.NumeroDocumento & vbCrLf
        Next

        If mTipoViaje = "Ida" Then
            TxtVerificacion.Text &= "Aerolinea: " & New AerolineaBLL(mVueloSelec.Aerolinea).Nombre & vbCrLf &
                                    "Vuelo: " & mVueloSelec.Numero & " Origen: " & New DestinoBLL(mVueloSelec.Origen).Nombre & " Destino: " & New DestinoBLL(mVueloSelec.Destino).Nombre & vbCrLf
        Else
            TxtVerificacion.Text &= "Viaje de ida" & vbCrLf &
                                    "Aerolinea: " & New AerolineaBLL(mListaVuelosSelec(0).Aerolinea).Nombre & vbCrLf &
                                    "Vuelo: " & mListaVuelosSelec(0).Numero & " Origen: " & New DestinoBLL(mListaVuelosSelec(0).Origen).Nombre & " Destino: " & New DestinoBLL(mListaVuelosSelec(0).Destino).Nombre & vbCrLf & vbCrLf &
                                    "Viaje de vuelta" & vbCrLf &
                                    "Aerolinea: " & New AerolineaBLL(mListaVuelosSelec(1).Aerolinea).Nombre & vbCrLf &
                                    "Vuelo: " & mListaVuelosSelec(1).Numero & " Origen: " & New DestinoBLL(mListaVuelosSelec(1).Origen).Nombre & " Destino: " & New DestinoBLL(mListaVuelosSelec(1).Destino).Nombre
        End If

#End Region

    End Sub

#End Region

    Public Sub ActualizarClientes(pClientes As List(Of ClienteBLL))
        GridClientes.DataSource = Nothing
        GridClientes.DataSource = pClientes
    End Sub


    Public Sub ActualizarLstClientes()
        LstCtesSeleccionados.DataSource = Nothing
        LstCtesSeleccionados.DataSource = mPasajeros
    End Sub


    Private Sub BtnSelec_Click(sender As Object, e As EventArgs) Handles BtnSelec.Click
        If mPasajeros.Count <= TxtPasajeros.Text Then
            If Not IsNothing(mClienteSelec) Then
                mPasajeros.Add(mClienteSelec)
                ActualizarLstClientes()
            End If
        Else
            MsgBox("Ya se alcanzo la cantidad de pasajeros")
        End If
    End Sub


    Private Sub BtnClienteNvo_Click(sender As Object, e As EventArgs) Handles BtnClienteNvo.Click
        Dim mForm As New AltaCliente
        mForm.ShowDialog()

        mListaClientes = ClienteBLL.Listar

        ActualizarClientes(mListaClientes)
    End Sub


    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        If Not IsNothing(LstCtesSeleccionados.SelectedItem) Then
            If TypeOf (LstCtesSeleccionados.SelectedItem) Is ClienteBLL Then
                mPasajeros.Remove(LstCtesSeleccionados.SelectedItem)

                ActualizarLstClientes()
            End If
        End If
    End Sub

#End Region


#Region "Tab 4"

    Private Sub BtnVolver3_Click(sender As Object, e As EventArgs) Handles BtnVolver3.Click
        TxtVerificacion.Clear()

        TabControlVentas.SelectedTab = Tab3
    End Sub


    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim mVenta As New VentaBLL

        mVenta.Usuario = FormPrincipal.UsuarioActivo.ID
        mVenta.Fecha = Date.Now.Date

        If mTipoViaje = "Ida" Then
            mVenta.Vuelos.Add(mVueloSelec)
        Else
            mVenta.Vuelos.AddRange(mListaVuelosSelec)
        End If

        mVenta.Clientes.AddRange(mPasajeros)

        mVenta.Guardar()

        'Falta impresion
    End Sub

#End Region


    ''' <summary>
    ''' Se encarga de la busqueda de vuelos en cada aerolinea
    ''' </summary>
    ''' <param name="pFecha">Fecha del vuelo</param>
    ''' <param name="pOrigen">Lugar de origen del vuelo</param>
    ''' <param name="pDestino">Destino del vuelo</param>
    ''' <param name="pCantPasajeros">Cantidad de pasajeros que queiren viajar</param>
    ''' <param name="pAvanzadas">Opciones avanzadas</param>
    ''' <param name="pEscalas">Cantidad de escalas</param>
    ''' <param name="pClase">Preferencia para la clase de los asientos</param>
    ''' <returns>Lista con vuelos encontrados</returns>
    Public Function Buscar(pFecha As Date, pOrigen As DestinoBLL, pDestino As DestinoBLL, pCantPasajeros As Integer, pAvanzadas As Boolean, pEscalas As Integer, pClase As String)
        Dim mVuelos As New List(Of VueloBLL)
        Dim mListaAerolineas As List(Of AerolineaBLL) = AerolineaBLL.ListarAerolineas

        If Not IsNothing(mListaAerolineas) Then
            For Each mAerolinea As AerolineaBLL In mListaAerolineas
                mVuelos.AddRange(mAerolinea.BuscarVuelos(DatePickerIda.Value, mOrigen, mDestino, TxtPasajeros.Text, IIf(CheckAvanzadas.Checked, True, Nothing), IIf(CheckAvanzadas.Checked, mCantEscalas, Nothing), IIf(CheckAvanzadas.Checked, mClase, Nothing)))
            Next
        End If

        Return mVuelos
    End Function
























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