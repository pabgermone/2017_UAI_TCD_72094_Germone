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
        If GridAerolineas.CurrentRow.Index > -1 And GridAerolineas.SelectedRows.Count > 0 Then
            If Not IsNothing(GridAerolineas.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridAerolineas.SelectedRows(0).DataBoundItem) Is AerolineaBLL Then
                    mAerolineaSelec = GridAerolineas.SelectedRows(0).DataBoundItem
                    ActualizarVuelos()
                End If
            End If
        End If
    End Sub

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

#Region "Botones"
    Private Sub BtnAltaAerolinea_Click(sender As Object, e As EventArgs) Handles BtnAltaAerolinea.Click
        Dim mAerolinea As New AerolineaBLL

        mAerolinea.Nombre = InputBox("Ingrese el nombre de la nueva aerolinea")
        mAerolinea.Guardar()

        ActualizarAerolineas()
        ActualizarVuelos()
    End Sub


    'Boton de edicion de la aerolinea
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Not IsNothing(mAerolineaSelec) Then
            Dim mNombre As String = InputBox("Ingrese el nombre deseado para la Aerolinea")

            If mNombre <> "" Then
                mAerolineaSelec.Nombre = mNombre
                mAerolineaSelec.Guardar()

                ActualizarAerolineas()
                ActualizarVuelos()
            End If
        Else
            MsgBox("Seleccione una aerolinea")
        End If
    End Sub


    Private Sub BtnAltaVuelo_Click(sender As Object, e As EventArgs) Handles BtnAltaVuelo.Click
        If Not IsNothing(mAerolineaSelec) Then
            Dim mForm As New AltaVuelo(mAerolineaSelec.ID)
            mForm.ShowDialog()

            ActualizarAerolineas()
            ActualizarVuelos()
        End If
    End Sub


    Private Sub BtnModifVuelo_Click(sender As Object, e As EventArgs) Handles BtnModifVuelo.Click
        If Not IsNothing(mVueloSelec) Then
            Dim mForm As New ModificarVuelo(mVueloSelec)
            mForm.ShowDialog()

            ActualizarAerolineas()
            ActualizarVuelos()
        End If
    End Sub


    Private Sub BtnEliminarVuelo_Click(sender As Object, e As EventArgs) Handles BtnEliminarVuelo.Click
        If Not IsNothing(mVueloSelec) Then
            mVueloSelec.Disponible = False

            mVueloSelec.GuardarModificacion()

            ActualizarAerolineas()
            ActualizarVuelos()
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
            Dim mListaVuelos As New List(Of VueloBLL)

            For Each mVuelo As VueloBLL In VueloBLL.ListarPorAerolinea(mAerolineaSelec.ID)
                If mVuelo.Disponible Then
                    mListaVuelos.Add(mVuelo)
                End If
            Next

            GridVuelos.DataSource = Nothing
            GridVuelos.DataSource = mListaVuelos
        End If
    End Sub



End Class