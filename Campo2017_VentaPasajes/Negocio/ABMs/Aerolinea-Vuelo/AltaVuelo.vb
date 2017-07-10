Imports BLL
Imports Framework

Public Class AltaVuelo
    Implements IObservador

    Dim mAerolinea As Integer
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(pAerolinea As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mAerolinea = pAerolinea

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



    Private Sub AltaVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboDestinos.DataSource = DestinoBLL.ListarDestinos

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
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