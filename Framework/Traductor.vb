Imports BLL
Imports BE

Public Class Traductor
    Implements IObservado

#Region "Singleton"
    Private Shared mTraductor As Traductor

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As Traductor
        If mTraductor Is Nothing Then
            mTraductor = New Traductor
            mTraductor.IdiomaSeleccionado = mTraductor.GetIdiomas().Item(0)
        End If
        Return mTraductor
    End Function

    Public Function Traducir(pTraducible As String) As String
        If Me.IdiomaSeleccionado.Diccionario.ContainsKey(pTraducible) Then
            Return Me.IdiomaSeleccionado.Diccionario(pTraducible)
        Else
            Return pTraducible
        End If
    End Function
#End Region

    Private vIdiomaSeleccionado As IdiomaBLL
    Public Property IdiomaSeleccionado() As IdiomaBLL
        Get
            Return vIdiomaSeleccionado
        End Get
        Set(ByVal value As IdiomaBLL) 'Cuando se cambia el idioma seleccionado del traductor, se llama al metodo
            '                       Notificar() que llama al ActualizarObservador de cada Form registrado
            If vIdiomaSeleccionado Is Nothing OrElse vIdiomaSeleccionado.Nombre <> value.Nombre Then
                vIdiomaSeleccionado = value
                Notificar()
            End If
        End Set
    End Property

    Dim vListaRegistrados As New List(Of IObservador)
    Dim vIdiomaDinamico As New IdiomaBLL

    Public ReadOnly Property Registrados As List(Of IObservador) Implements IObservado.Registrados
        Get
            Return vListaRegistrados
        End Get
    End Property

    Public Sub Notificar() Implements IObservado.Notificar
        For Each vRegistrado As IObservador In vListaRegistrados
            vRegistrado.ActualizarObservador(vRegistrado)
        Next
    End Sub

    'Este metodo registra a un IObservador en la lista de observadores del Traductor. Si el observador que se pasa por
    'parametro ya estaba en la lista, primero lo saca de la lista y despues lo vuelve a agregar (?)
    Public Sub Registrar(pObservador As IObservador) Implements IObservado.Registrar
        If vListaRegistrados.Count > 0 Then
            For Each vRegistrado As IObservador In vListaRegistrados
                If vRegistrado.ToString = pObservador.ToString Then
                    vListaRegistrados.Remove(vRegistrado)
                    Exit For
                End If
            Next
        End If
        vListaRegistrados.Add(pObservador)
    End Sub

    Public Function GetIdiomas() As List(Of IdiomaBLL)
        Dim vLista As New List(Of IdiomaBLL)
        For Each vIdioma As IdiomaBLL In IdiomaBLL.ListarIdiomaes
            vLista.Add(vIdioma)
        Next
        Return vLista
    End Function

    Public Sub AltaIdioma(pNombre As String, pDiccionario As Dictionary(Of String, String))
        Dim vIdioma As New IdiomaBLL()

        vIdioma.Nombre = pNombre
        vIdioma.Diccionario = pDiccionario

        vIdioma.Guardar()
    End Sub

    Public Sub BajaIdioma(pIdioma As IdiomaBLL)
        pIdioma.Eliminar()
    End Sub

    Public Sub ModificacionIdioma(pIdioma As IdiomaBLL)
        pIdioma.Guardar()
    End Sub
End Class

