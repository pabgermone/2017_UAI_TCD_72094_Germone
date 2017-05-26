Imports BLL

Public Class AltaVuelo
    Dim mAerolinea As Integer

    Public Sub New(pAerolinea As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mAerolinea = pAerolinea
    End Sub


    Private Sub AltaVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboDestinos.DataSource = DestinoBLL.ListarDestinos
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mVuelo As New VueloBLL

        mVuelo.Numero = TxtNroVuelo.Text
        mVuelo.Disponible = True
        mVuelo.Fecha = TxtFecha.Text
        mVuelo.Hora = TxtHora.Text
        mVuelo.Destino = CType(ComboDestinos.SelectedItem, DestinoBLL).ID
        mVuelo.Aerolinea = mAerolinea

        mVuelo.GuardarNuevo()

        MsgBox("El vuelo se guardo correctamente")

        Me.Close()
    End Sub
End Class