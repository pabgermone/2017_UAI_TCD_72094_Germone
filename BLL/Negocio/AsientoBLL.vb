Imports BE
Imports DAL

Public Class AsientoBLL
#Region "Propiedades"
    Public Property Numero As Integer
    Public Property NumeroVuelo As Integer
    Public Property Clase As String
    Public Property Ocupado As Boolean
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un AsientoBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pAsiento">Numero de asiento del que se quieren recuperar datos</param>
    ''' <param name="pVuelo">Numero de vuelo al que pertence el asientp</param>
    Sub New(pAsiento As Integer, pVuelo As Integer)
        CargarPropiedades(pAsiento, pVuelo)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pAsiento">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pAsiento As AsientoBE)
        CargarPropiedades(pAsiento)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pASiento">Numero del asiento del que se quieren obtener datos</param>
    ''' <param name="pVuelo">Numero de vuelo al que pertenece el asiento</param>
    Private Sub CargarPropiedades(pASiento As Integer, pVuelo As Integer)
        Dim mBE As AsientoBE = AsientoDAL.ObtenerAsiento(pASiento, pVuelo)

        If Not IsNothing(mBE) Then
            Me.Numero = mBE.Numero
            Me.NumeroVuelo = mBE.NumeroVuelo
            Me.Clase = mBE.Clase
            Me.Ocupado = mBE.Ocupado
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pAsiento">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pAsiento As AsientoBE)
        If Not IsNothing(pAsiento) Then
            Me.Numero = pAsiento.Numero
            Me.NumeroVuelo = pAsiento.NumeroVuelo
            Me.Clase = pAsiento.Clase
            Me.Ocupado = pAsiento.Ocupado
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(pBE As AsientoBE)
        pBE.Numero = Me.Numero
        pBE.NumeroVuelo = Me.NumeroVuelo
        pBE.Clase = Me.Clase
        pBE.Ocupado = Me.Ocupado
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New AsientoBE

        CargarBE(mBE)
        AsientoDAL.GuardarNuevo(mBE)
    End Sub


    ''' <summary>
    ''' Persisten en la base los cambios realizados a la entidad
    ''' </summary>
    Public Sub GuardarModificacion()
        Dim mBE As New AsientoBE

        CargarBE(mBE)
        AsientoDAL.GuardarModificacion(mBE)
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New AsientoBE

        CargarBE(mBE)

        AsientoDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada usuario guardado en la BD
    ''' </summary>
    ''' <returns>List(Of UsuarioBLL) con datos de cada usuario</returns>
    Public Shared Function Listar() As List(Of AsientoBLL)
        Dim mLista As New List(Of AsientoBLL)
        Dim mListaBE As List(Of AsientoBE) = AsientoDAL.ListarAsientos

        If Not IsNothing(mListaBE) Then
            For Each mBE As AsientoBE In mListaBE
                Dim mUsuario As New AsientoBLL(mBE)

                mLista.Add(mUsuario)
            Next
        End If


        Return mLista
    End Function
End Class
