Imports BLL
Imports Framework
Imports System.Text.RegularExpressions

Public Class FormClientes
    Implements IObservador

    Dim mClienteSelec As ClienteBLL
    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mListaClientes As List(Of ClienteBLL) = ClienteBLL.Listar



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub


    ''' <summary>
    ''' Carga en pControl.Tag el texto que tiene pControl al momento de instanciar el Form
    ''' </summary>
    ''' <param name="pControl"></param>
    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub

#End Region


#Region "Eventos Form"

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ActualizarLista()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)

        If Not IsNothing(mListaClientes) Then
            ActualizarClientes(mListaClientes)
        End If

        RadioApellido.Checked = True
    End Sub


    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If Not IsNothing(mListaClientes) Then
            Dim mListaFiltrados As New List(Of ClienteBLL)

            Dim mBusqueda As String = "^" & TxtBuscar.Text

            If TxtBuscar.Text <> "" Then
                For Each mCliente As ClienteBLL In mListaClientes
                    If RadioApellido.Checked Then
                        If Regex.IsMatch(mCliente.Apellido, mBusqueda) Then
                            mListaFiltrados.Add(mCliente)
                        End If
                    Else
                        If Regex.IsMatch(mCliente.NumeroDocumento.ToString, mBusqueda) Then
                            mListaFiltrados.Add(mCliente)
                        End If
                    End If
                Next

                ActualizarClientes(mListaFiltrados)
            Else
                ActualizarClientes(mListaClientes)
            End If
        End If
    End Sub


    Private Sub GridClientes_SelectionChanged(sender As Object, e As EventArgs) Handles GridClientes.SelectionChanged
        If GridClientes.CurrentRow.Index > -1 And GridClientes.SelectedRows.Count > 0 Then
            If Not IsNothing(GridClientes.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridClientes.SelectedRows(0).DataBoundItem) Is ClienteBLL Then
                    mClienteSelec = GridClientes.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub

#Region "Viejo"
    'Private Sub ComboClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedValueChanged
    '    If Not IsNothing(ComboClientes.SelectedItem) Then
    '        If TypeOf (ComboClientes.SelectedItem) Is ClienteBLL Then
    '            mClienteSelec = ComboClientes.SelectedItem
    '        Else
    '            mClienteSelec = Nothing
    '        End If

    '        ActualizarLabels()
    '    End If
    'End Sub
#End Region

#End Region


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Not IsNothing(mClienteSelec) Then
            Dim mForm As New AltaCliente(mClienteSelec)

            mForm.ShowDialog()

            mListaClientes = ClienteBLL.Listar

            TxtBuscar.Clear()
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mForm As New AltaCliente

        mForm.ShowDialog()

        mListaClientes = ClienteBLL.Listar

        TxtBuscar.Clear()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not IsNothing(mClienteSelec) Then
            mClienteSelec.Eliminar()
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub


    Private Sub BtnReservas_Click(sender As Object, e As EventArgs) Handles BtnReservas.Click
        If Not IsNothing(mClienteSelec) Then
            Dim mForm As New FormReservas(mClienteSelec)

            mForm.ShowDialog()
        End If
    End Sub



    ''' <summary>
    ''' Actualiza los datos mostrados en el DataGrid de Clientes
    ''' </summary>
    ''' <param name="pClientes"></param>
    Public Sub ActualizarClientes(pClientes As List(Of ClienteBLL))
        GridClientes.DataSource = Nothing
        GridClientes.DataSource = pClientes
    End Sub
















#Region "Botones"

#Region "Viejo"
    'Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
    '    If Not IsNothing(mClienteSelec) Then
    '        Dim mForm As New ModificarCliente(mClienteSelec)
    '        mForm.ShowDialog()
    '        ActualizarLista()
    '    Else
    '        MsgBox("Debe seleccionar un cliente")
    '    End If
    'End Sub

    'Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
    '    Dim mForm As New AltaCliente()
    '    mForm.ShowDialog()
    '    ActualizarLista()
    'End Sub
#End Region

#End Region

#Region "Viejo"
    '''' <summary>
    '''' Actualiza los datos mostrados en el ComboBox
    '''' </summary>
    'Public Sub ActualizarLista()
    '    ComboClientes.Items.Clear()
    '    ComboClientes.Items.Add("- Seleccione un cliente -")

    '    For Each mCliente As ClienteBLL In ClienteBLL.Listar
    '        ComboClientes.Items.Add(mCliente)
    '    Next

    '    ActualizarLabels()
    'End Sub


    '''' <summary>
    '''' Mustra los datos del cliente seleccionado en los Labels
    '''' </summary>
    '<Obsolete("Falta hacer compatible con el MultiIdioma")>
    'Public Sub ActualizarLabels()
    '    If Not IsNothing(mClienteSelec) Then
    '        LblNomAp.Text = "Nombre y Apellido: " & mClienteSelec.ToString
    '        'LblDNI.Text = "DNI: " & mClienteSelec.DNI
    '        LblPasaporte.Text = "Pasaporte: " & mClienteSelec.Pasaporte
    '        LblFechaNac.Text = "Fecha de Nacimiento: " & mClienteSelec.FechaNac
    '        'LblTel.Text = "Telefono: " & mClienteSelec.Telefono
    '        'LblSexo.Text = "Sexo: " & mClienteSelec.Sexo
    '    Else
    '        LblNomAp.Text = "Nombre y Apellido: "
    '        LblDNI.Text = "DNI: "
    '        LblPasaporte.Text = "Pasaporte: "
    '        LblFechaNac.Text = "Fecha de Nacimiento: "
    '        LblTel.Text = "Telefono: "
    '        LblSexo.Text = "Sexo: "
    '    End If
    'End Sub
#End Region

End Class