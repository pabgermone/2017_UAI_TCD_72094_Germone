Imports BLL

Public Class FormDestinos
    Dim mDestinoSelec As DestinoBLL


    Private Sub FormDestinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDestinos()
    End Sub


    Private Sub GridDestinos_SelectionChanged(sender As Object, e As EventArgs) Handles GridDestinos.SelectionChanged
        If GridDestinos.CurrentRow.Index > -1 And GridDestinos.SelectedRows.Count > 0 Then
            If Not IsNothing(GridDestinos.SelectedRows(0).DataBoundItem) Then
                If TypeOf (GridDestinos.SelectedRows(0).DataBoundItem) Is DestinoBLL Then
                    mDestinoSelec = GridDestinos.SelectedRows(0).DataBoundItem
                End If
            End If
        End If
    End Sub



    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mDestino As New DestinoBLL

        mDestino.Nombre = InputBox("Ingrese el nombre del destino:")

        mDestino.Guardar()

        ActualizarDestinos()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not IsNothing(mDestinoSelec) Then
            mDestinoSelec.Eliminar()

            ActualizarDestinos()
        End If
    End Sub



    Public Sub ActualizarDestinos()
        GridDestinos.DataSource = Nothing
        GridDestinos.DataSource = DestinoBLL.ListarDestinos
    End Sub
End Class