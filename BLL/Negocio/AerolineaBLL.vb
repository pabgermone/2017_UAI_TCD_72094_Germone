Imports BE
Imports DAL

Public Class AerolineaBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Shared Property Vuelos As New List(Of VueloBLL)
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un AerolineaBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pAerolinea">Nombre de Aerolinea del que se quieren recuperar datos</param>
    Sub New(pAerolinea As String)
        CargarPropiedades(pAerolinea)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pAerolinea As AerolineaBE)
        CargarPropiedades(pAerolinea)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pAerolinea">ID de la Aerolinea del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pAerolinea As Integer)
        Dim mBE As AerolineaBE = AerolineaDAL.ObtenerAerolinea(pAerolinea)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre

            'CargarVuelos()
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pAerolinea As AerolineaBE)
        If Not IsNothing(pAerolinea) Then
            Me.ID = pAerolinea.ID
            Me.Nombre = pAerolinea.Nombre

            'CargarVuelos()
        End If
    End Sub


    '''' <summary>
    '''' Carga la lista de vuelos relacionadas a esta aerolinea
    '''' </summary>
    'Private Sub CargarVuelos()
    '    Dim mVuelos As List(Of VueloBLL) = VueloBLL.ListarPorAerolinea(Me.ID)

    '    If Not IsNothing(mVuelos) Then
    '        Me.Vuelos = mVuelos
    '    End If
    'End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As AerolineaBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New AerolineaBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            AerolineaDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            AerolineaDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New AerolineaBE

        CargarBE(mBE)

        AerolineaDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada Aerolinea guardado en la BD
    ''' </summary>
    ''' <returns>List(Of AerolineaBLL) con datos de cada Aerolinea</returns>
    Public Shared Function ListarAerolineas() As List(Of AerolineaBLL)
        Dim mLista As New List(Of AerolineaBLL)
        Dim mListaBE As List(Of AerolineaBE) = AerolineaDAL.ListarAerolineas

        If Not IsNothing(mListaBE) Then
            For Each mBE As AerolineaBE In mListaBE
                Dim mAerolinea As New AerolineaBLL(mBE)

                mLista.Add(mAerolinea)
            Next
        End If


        Return mLista
    End Function


    'Public Shared Function BuscarVuelos(pOrigen As DestinoBLL, pDestino As DestinoBLL, pCantPasajeros As Integer, Optional pEspeciales As Boolean, pFecha As Date, Optional pEscalas As Integer = -1, Optional pClase As String = "") As List(Of VueloBLL)

    'End Function

End Class
