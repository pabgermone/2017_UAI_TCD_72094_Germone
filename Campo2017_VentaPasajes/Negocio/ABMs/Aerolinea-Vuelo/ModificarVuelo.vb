Imports BLL

Public Class ModificarVuelo
    Dim mVuelo As VueloBLL

    Public Sub New(pVuelo As VueloBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mVuelo = pVuelo
    End Sub


    Private Sub ModificarVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboDestinos.DataSource = DestinoBLL.ListarDestinos

        TxtNroVuelo.Text = mVuelo.Numero
        TxtFecha.Text = mVuelo.Fecha
        TxtHora.Text = mVuelo.Hora

        Dim mDestino As New DestinoBLL(mVuelo.Destino)

        For Each mItem As DestinoBLL In ComboDestinos.Items
            If mItem.ID = mDestino.ID Then
                ComboDestinos.SelectedItem = mItem
            End If
        Next
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        mVuelo.Numero = TxtNroVuelo.Text
        mVuelo.Fecha = TxtFecha.Text
        mVuelo.Hora = TxtHora.Text
        mVuelo.Destino = CType(ComboDestinos.SelectedItem, DestinoBLL).ID

        mVuelo.GuardarModificacion()
    End Sub
End Class