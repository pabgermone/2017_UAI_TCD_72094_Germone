Imports BLL
Imports Framework

Public Class FormVentas
    Dim mUsuarioActivo As UsuarioBLL
    Dim mVueloSelec As VueloBLL
    Dim mClienteSelec As ClienteBLL


#Region "Principal"

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGridVuelos()
        RadioRegistrado.Checked = True

        For Each mForm As Form In Application.OpenForms
            If TypeOf mForm Is FormPrincipal Then
                mUsuarioActivo = CType(mForm, FormPrincipal).UsuarioActivo
                Exit For
            End If
        Next
    End Sub

#End Region


#Region "TabVuelos"

    ''' <summary>
    ''' Carga con datos a GridVuelos
    ''' </summary>
    Public Sub ActualizarGridVuelos()
        GridVuelos.DataSource = Nothing
        GridVuelos.DataSource = VueloBLL.ListarVuelos
    End Sub


    ''' <summary>
    ''' Cambia el vuelo que se haya seleccionado en GridVuelos
    ''' </summary>
    Private Sub GridVuelos_SelectionChanged(sender As Object, e As EventArgs) Handles GridVuelos.SelectionChanged
        If GridVuelos.SelectedRows.Count > 0 Then
            If Not IsNothing(GridVuelos.SelectedRows(0).DataBoundItem) Then
                If TypeOf GridVuelos.SelectedRows(0).DataBoundItem Is VueloBLL Then
                    mVueloSelec = GridVuelos.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub


    Private Sub BtnSiguienteTab1_Click(sender As Object, e As EventArgs) Handles BtnSiguienteTab1.Click

    End Sub

#End Region


#Region "TabPasajeros"

    ''' <summary>
    ''' Carga con datos ComboClientes
    ''' </summary>
    Public Sub ActualizarComboClientes()
        For Each mCliente As ClienteBLL In ClienteBLL.Listar
            ComboClientes.Items.Add(mCliente)
        Next
    End Sub


    ''' <summary>
    ''' Cambia el cliente que se haya seleccionado en ComboClientes
    ''' </summary>
    Private Sub ComboClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedValueChanged
        If Not IsNothing(ComboClientes.SelectedItem) Then
            If TypeOf ComboClientes.SelectedItem Is ClienteBLL Then
                mClienteSelec = ComboClientes.SelectedItem
            End If
        End If
    End Sub


    Private Sub RadioRegistrado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRegistrado.CheckedChanged

    End Sub

#End Region

End Class