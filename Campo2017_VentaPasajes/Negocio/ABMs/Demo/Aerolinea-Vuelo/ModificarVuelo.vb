Imports BLL
Imports Framework

Public Class ModificarVuelo
    Implements IObservador

    Dim mVuelo As VueloBLL
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(pVuelo As VueloBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mVuelo = pVuelo

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

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        mVuelo.Numero = TxtNroVuelo.Text
        mVuelo.Fecha = TxtFecha.Text
        mVuelo.Hora = TxtHora.Text
        mVuelo.Destino = CType(ComboDestinos.SelectedItem, DestinoBLL).ID

        mVuelo.GuardarModificacion()
    End Sub
End Class