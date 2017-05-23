Imports BLL

Public Class FormAerolineas
    Dim mAerolineaSelec As AerolineaBLL
    Dim mVueloSelec As VueloBLL

#Region "Eventos Form"
    Private Sub FormAerolineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarAerolineas()
        ActualizarVuelos()
    End Sub

    Private Sub GridAerolineas_SelectionChanged(sender As Object, e As EventArgs) Handles GridAerolineas.SelectionChanged
        If Not IsNothing(GridAerolineas.SelectedRows(0).DataBoundItem) Then
            If TypeOf (GridAerolineas.SelectedRows(0).DataBoundItem) Is AerolineaBLL Then
                mAerolineaSelec = GridAerolineas.SelectedRows(0).DataBoundItem
                ActualizarVuelos()
            End If
        End If
    End Sub

    Private Sub GridVuelos_SelectionChanged(sender As Object, e As EventArgs) Handles GridVuelos.SelectionChanged
        If Not IsNothing(GridVuelos.SelectedRows(0).DataBoundItem) Then
            If TypeOf (GridVuelos.SelectedRows(0).DataBoundItem) Is AerolineaBLL Then
                mVueloSelec = GridVuelos.SelectedRows(0).DataBoundItem
            End If
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Not IsNothing(mAerolineaSelec) Then
            Dim mNombre As String = InputBox("Ingrese el nombre deseado para la Aerolinea")

            If mNombre <> "" Then
                mAerolineaSelec.Nombre = mNombre
                mAerolineaSelec.Guardar()

                ActualizarAerolineas()
            End If
        Else
            MsgBox("Seleccione una aerolinea")
        End If
    End Sub
#End Region


    ''' <summary>
    ''' Actualiza los datos mostrados en GridAerolineas
    ''' </summary>
    Public Sub ActualizarAerolineas()
        GridAerolineas.DataSource = Nothing
        GridAerolineas.DataSource = AerolineaBLL.ListarAerolineas
    End Sub


    ''' <summary>
    ''' Actualiza los datos mostrados en GridVuelos
    ''' </summary>
    Public Sub ActualizarVuelos()
        If Not IsNothing(mAerolineaSelec) Then
            GridVuelos.DataSource = Nothing
            GridVuelos.DataSource = VueloBLL.ListarPorAerolinea(mAerolineaSelec.ID)
        End If
    End Sub


End Class