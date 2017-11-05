Imports BLL

Public Class FormReservas

    Dim mCliente As ClienteBLL

    Public Sub New(pCliente As ClienteBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pCliente) Then
            mCliente = pCliente
        End If
    End Sub

    Private Sub FormReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mListaVuelos As List(Of VueloBLL) = mCliente.ObtenerReservas

        If Not IsNothing(mListaVuelos) Then
            GridVuelos.DataSource = mListaVuelos
        End If
    End Sub
End Class