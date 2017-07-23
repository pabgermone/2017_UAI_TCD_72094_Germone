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
        TxtPrecio.Text = mVuelo.Precio

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
        Dim mValido As Boolean = True

        If TxtNroVuelo.Text <> "" Then
            mVuelo.Numero = TxtNroVuelo.Text
        Else
            MsgBox("Debe ingresar un numero de vuelo")
            TxtNroVuelo.BackColor = Color.Red

            mValido = False
        End If

        If TxtFecha.Text <> "" Then
            mVuelo.Fecha = TxtFecha.Text
        Else
            MsgBox("Debe ingresar una fecha para el vuelo")
            TxtFecha.BackColor = Color.Red

            mValido = False
        End If

        If TxtHora.Text <> "" Then
            mVuelo.Hora = TxtHora.Text
        Else
            MsgBox("Debe ingresar una hora para el vuelo")
            TxtHora.BackColor = Color.Red

            mValido = False
        End If

        If TypeOf ComboDestinos.SelectedItem Is DestinoBLL Then
            mVuelo.Destino = CType(ComboDestinos.SelectedItem, DestinoBLL).ID
        Else
            MsgBox("Debe seleccionar un destino")

            mValido = False
        End If

        If TxtPrecio.Text <> "" And IsNumeric(TxtPrecio.Text) Then
            mVuelo.Precio = TxtPrecio.Text
        Else
            MsgBox("Debe ingresar un precio para el vuelo")
            TxtPrecio.BackColor = Color.Red

            mValido = False
        End If


        If mValido Then
            If MsgBox("Esta seguro que esea guardar los cambios realizados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mVuelo.GuardarModificacion()

                MsgBox("Se guardaron los cambios")

                Me.Close()
            End If
        End If
    End Sub
End Class