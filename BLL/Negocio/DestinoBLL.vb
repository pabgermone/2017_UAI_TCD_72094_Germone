Imports BE
Imports DAL

Public Class DestinoBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un DestinoBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pDestino">Nombre de Destino del que se quieren recuperar datos</param>
    Sub New(pDestino As String)
        CargarPropiedades(pDestino)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pDestino">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pDestino As DestinoBE)
        CargarPropiedades(pDestino)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pDestino">ID de la Destino del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pDestino As Integer)
        Dim mBE As DestinoBE = DestinoDAL.ObtenerDestino(pDestino)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pDestino">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pDestino As DestinoBE)
        If Not IsNothing(pDestino) Then
            Me.ID = pDestino.ID
            Me.Nombre = pDestino.Nombre
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As DestinoBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New DestinoBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            DestinoDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            DestinoDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New DestinoBE

        CargarBE(mBE)

        DestinoDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada Destino guardado en la BD
    ''' </summary>
    ''' <returns>List(Of DestinoBLL) con datos de cada Destino</returns>
    Public Shared Function ListarDestinos() As List(Of DestinoBLL)
        Dim mLista As New List(Of DestinoBLL)
        Dim mListaBE As List(Of DestinoBE) = DestinoDAL.ListarDestinos

        If Not IsNothing(mListaBE) Then
            For Each mBE As DestinoBE In mListaBE
                Dim mDestino As New DestinoBLL(mBE)

                mLista.Add(mDestino)
            Next
        End If

        Return mLista
    End Function


    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class
