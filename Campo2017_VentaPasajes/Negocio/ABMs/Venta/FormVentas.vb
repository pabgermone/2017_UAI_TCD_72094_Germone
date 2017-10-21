Imports BLL
Imports Framework

Public Class FormVentas

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