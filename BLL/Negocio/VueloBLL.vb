Imports BE
Imports DAL
Imports Framework

Public Class VueloBLL
#Region "Propiedades"
    Public Property Numero As Integer
    Public Property Disponible As Boolean
    Public Property CantEspacios As Integer
    Public Property Fecha As Date
    Public Property Hora As String
    Public Property Origen As Integer
    Public Property Destino As Integer
    Public Property Escalas As Integer
    Public Property Aerolinea As Integer
    Public Property Precio As Decimal
    Public Property DV As Integer

    Public Property Asientos As New List(Of AsientoBLL)
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un VueloBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pVuelo">Nombre de Vuelo del que se quieren recuperar datos</param>
    Sub New(pVuelo As Integer)
        CargarPropiedades(pVuelo)

        CargarAsientos()
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pVuelo As VueloBE)
        CargarPropiedades(pVuelo)

        CargarAsientos()
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pVuelo">ID de la Vuelo del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pVuelo As Integer)
        Dim mBE As VueloBE = VueloDAL.ObtenerVuelo(pVuelo)

        If Not IsNothing(mBE) Then
            If CalculadorDV.VerificarDV(mBE.Numero & mBE.Disponible & mBE.Fecha.ToString("yyyymmdd") & mBE.Hora & mBE.Destino & mBE.Aerolinea & mBE.Precio, mBE.DV) Then
                Me.Numero = mBE.Numero
                Me.Disponible = mBE.Disponible
                Me.CantEspacios = mBE.CantEspacios
                Me.Fecha = mBE.Fecha
                Me.Hora = mBE.Hora
                Me.Origen = mBE.Origen
                Me.Destino = mBE.Destino
                Me.Escalas = mBE.Escalas
                Me.Aerolinea = mBE.Aerolinea
                Me.Precio = mBE.Precio
            Else
                MsgBox("Error - DV - Vuelo - CargarPropiedades(Integer)")
            End If

        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pVuelo As VueloBE)
        If Not IsNothing(pVuelo) Then
            Me.Numero = pVuelo.Numero
            Me.Disponible = pVuelo.Disponible
            Me.CantEspacios = pVuelo.CantEspacios
            Me.Fecha = pVuelo.Fecha
            Me.Hora = pVuelo.Hora
            Me.Origen = pVuelo.Origen
            Me.Destino = pVuelo.Destino
            Me.Escalas = pVuelo.Escalas
            Me.Aerolinea = pVuelo.Aerolinea
            Me.Precio = pVuelo.Precio
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Public Sub CargarBE(mBE As VueloBE)
        mBE.Numero = Me.Numero
        mBE.Disponible = Me.Disponible
        mBE.CantEspacios = Me.CantEspacios
        mBE.Fecha = Me.Fecha
        mBE.Hora = Me.Hora
        mBE.Origen = Me.Origen
        mBE.Destino = Me.Destino
        mBE.Escalas = Me.Escalas
        mBE.Aerolinea = Me.Aerolinea
        mBE.Precio = Me.Precio
        mBE.DV = Me.DV
    End Sub


    Private Sub CargarAsientos()
        Me.Asientos = AsientoBLL.Listar(Me.Numero)
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub GuardarNuevo()
        Dim mBE As New VueloBE

        Me.DV = CalculadorDV.CalcularDV(Me.Numero & Me.Disponible & Me.Fecha.ToString("yyyymmdd") & Me.Hora & Me.Destino & Me.Aerolinea & Me.Precio)

        CargarBE(mBE)
        VueloDAL.GuardarNuevo(mBE)

        ControladorDVV.ModificarDigito("Vuelo", ControladorDVV.CalcularDVV("Vuelo"))
    End Sub


    ''' <summary>
    ''' Persiste los cambios hechos a una instancia
    ''' </summary>
    Public Sub GuardarModificacion()
        Dim mBE As New VueloBE

        Me.DV = CalculadorDV.CalcularDV(Me.Numero & Me.Disponible & Me.Fecha.ToString("yyyymmdd") & Me.Hora & Me.Destino & Me.Aerolinea & Me.Precio)

        CargarBE(mBE)
        VueloDAL.GuardarModificacion(mBE)

        ControladorDVV.ModificarDigito("Vuelo", ControladorDVV.CalcularDVV("Vuelo"))
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New VueloBE

        CargarBE(mBE)

        VueloDAL.Eliminar(mBE)

        ControladorDVV.ModificarDigito("Vuelo", ControladorDVV.CalcularDVV("Vuelo"))
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada Vuelo guardado en la BD
    ''' </summary>
    ''' <returns>List(Of VueloBLL) con datos de cada Vuelo</returns>
    Public Shared Function ListarVuelos() As List(Of VueloBLL)
        Dim mLista As New List(Of VueloBLL)
        Dim mListaBE As List(Of VueloBE) = VueloDAL.ListarVuelos

        If Not IsNothing(mListaBE) Then
            For Each mBE As VueloBE In mListaBE
                If CalculadorDV.VerificarDV(mBE.Numero & mBE.Disponible & mBE.Fecha.ToString("yyyymmdd") & mBE.Hora & mBE.Destino & mBE.Aerolinea & mBE.Precio, mBE.DV) Then
                    Dim mVuelo As New VueloBLL(mBE)

                    mLista.Add(mVuelo)
                Else
                    MsgBox("Error - DV - Vuelo - Listar")
                End If
            Next
        End If

        Return mLista
    End Function


    ''' <summary>
    ''' Lista todos los vuelos pertenecientes a una aerolinea especifica
    ''' </summary>
    ''' <param name="pAerolinea">ID de la aerolinea de la que se quieren recuperar vuelos</param>
    ''' <returns>Lista con datos de todas los vuelos que tenga la aerolinea</returns>
    Public Shared Function ListarPorAerolinea(pAerolinea As Integer) As List(Of VueloBLL)
        Dim mLista As New List(Of VueloBLL)
        Dim mListaBE As List(Of VueloBE) = VueloDAL.ListarVuelos(pAerolinea)

        If Not IsNothing(mListaBE) Then
            For Each mBE As VueloBE In mListaBE
                If CalculadorDV.VerificarDV(mBE.Numero & mBE.Disponible & mBE.Fecha.ToString("yyyymmdd") & mBE.Hora & mBE.Destino & mBE.Aerolinea & mBE.Precio, mBE.DV) Then
                    Dim mVuelo As New VueloBLL(mBE)

                    mLista.Add(mVuelo)
                Else
                    MsgBox("Error - DV - Vuelo - Listar")
                End If
            Next
        End If

        Return mLista
    End Function
End Class
