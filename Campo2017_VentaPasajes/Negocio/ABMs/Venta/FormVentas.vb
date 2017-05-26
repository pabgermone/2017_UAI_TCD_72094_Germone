Imports BLL

Public Class FormVentas
    Dim mClienteSelec As ClienteBLL
    Dim mVentaSelec As VentaBLL

#Region "Eventos Form"
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarClientes()
        ActualizarVentas()
    End Sub


    Private Sub ComboClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedValueChanged
        mClienteSelec = ComboClientes.SelectedItem

        ActualizarVentas()
    End Sub


    Private Sub GridVentas_SelectionChanged(sender As Object, e As EventArgs) Handles GridVentas.SelectionChanged
        If GridVentas.CurrentRow.Index > -1 And GridVentas.SelectedRows.Count > 0 Then
            If Not IsNothing(GridVentas.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridVentas.SelectedRows(0).DataBoundItem) Is VentaBLL Then
                    mVentaSelec = GridVentas.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub BtnNueva_Click(sender As Object, e As EventArgs) Handles BtnNueva.Click

    End Sub
#End Region


    Public Sub ActualizarClientes()
        ComboClientes.DataSource = Nothing
        ComboClientes.DataSource = ClienteBLL.Listar
    End Sub


    Public Sub ActualizarVentas()
        If Not IsNothing(mClienteSelec) Then
            GridVentas.DataSource = Nothing
            GridVentas.DataSource = VentaBLL.ListarVentas
        End If
    End Sub


End Class