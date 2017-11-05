Imports BLL

Public Class FormEstadisticas
    Dim mAnioSelec As Integer
    Dim mDestinoSelec As Integer

    Private Sub FormEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mAnios As List(Of Integer) = VentaBLL.ObtenerAnios

        If Not IsNothing(mAnios) Then
            ComboAgno.DataSource = mAnios
        End If

        ComboAgno.SelectedIndex = 0
    End Sub


    Public Sub ActualizarDestinos(pAnio As Integer)
        ComboDestino.DataSource = Nothing
        Dim mLista As List(Of DestinoBLL) = VentaBLL.ObtenerDestinosPorAnio(pAnio)

        If Not IsNothing(mLista) Then
            ComboDestino.DataSource = mLista
            ComboDestino.SelectedIndex = 0
        End If
    End Sub


    Private Sub ComboAgno_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboAgno.SelectedValueChanged
        If Not IsNothing(ComboAgno.SelectedItem) Then
            ActualizarDestinos(ComboAgno.SelectedItem)
            mAnioSelec = ComboAgno.SelectedItem
        End If
    End Sub


    Private Sub ComboDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboDestino.SelectedValueChanged
        If Not IsNothing(ComboDestino.SelectedItem) Then
            mDestinoSelec = ComboDestino.SelectedItem
        End If
    End Sub


    Public Sub Calcular()

    End Sub

End Class