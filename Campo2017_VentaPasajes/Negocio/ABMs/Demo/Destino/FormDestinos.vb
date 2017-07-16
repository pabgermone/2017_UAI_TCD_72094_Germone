Imports BLL
Imports Framework

Public Class FormDestinos
    Implements IObservador

    Dim mDestinoSelec As DestinoBLL
    Dim mTraductor As Traductor = Traductor.GetInstance


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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


    Private Sub FormDestinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDestinos()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
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

        If mDestino.Nombre <> "" Then
            mDestino.Guardar()

            ActualizarDestinos()
        Else
            MsgBox("Debe el nombre del nuevo destino")
        End If

    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not IsNothing(mDestinoSelec) Then
            mDestinoSelec.Eliminar()

            ActualizarDestinos()
        Else
            MsgBox("Debe seleccionar un destino")
        End If
    End Sub



    Public Sub ActualizarDestinos()
        GridDestinos.DataSource = Nothing
        GridDestinos.DataSource = DestinoBLL.ListarDestinos
    End Sub
End Class