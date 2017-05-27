﻿Imports BE
Imports DAL

Public Class VueloBLL
#Region "Propiedades"
    Public Property Numero As Integer
    Public Property Disponible As Boolean
    Public Property Fecha As Date
    Public Property Hora As String
    Public Property Destino As Integer
    Public Property Aerolinea As Integer
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
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pVuelo As VueloBE)
        CargarPropiedades(pVuelo)
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
            Me.Numero = mBE.Numero
            Me.Disponible = mBE.Disponible
            Me.Fecha = mBE.Fecha
            Me.Hora = mBE.Hora
            Me.Destino = mBE.Destino
            Me.Aerolinea = mBE.Aerolinea
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
            Me.Fecha = pVuelo.Fecha
            Me.Hora = pVuelo.Hora
            Me.Destino = pVuelo.Destino
            Me.Aerolinea = pVuelo.Aerolinea
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As VueloBE)
        mBE.Numero = Me.Numero
        mBE.Disponible = Me.Disponible
        mBE.Fecha = Me.Fecha
        mBE.Fecha = Me.Fecha
        mBE.Hora = Me.Hora
        mBE.Destino = Me.Destino
        mBE.Aerolinea = Me.Aerolinea
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub GuardarNuevo()
        Dim mBE As New VueloBE
        CargarBE(mBE)
        VueloDAL.GuardarNuevo(mBE)
    End Sub


    ''' <summary>
    ''' Persiste los cambios hechos a una instancia
    ''' </summary>
    Public Sub GuardarModificacion()
        Dim mBE As New VueloBE
        CargarBE(mBE)
        VueloDAL.GuardarModificacion(mBE)
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New VueloBE

        CargarBE(mBE)

        VueloDAL.Eliminar(mBE)
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
                Dim mVuelo As New VueloBLL(mBE)

                mLista.Add(mVuelo)
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
                Dim mVuelo As New VueloBLL(mBE)

                mLista.Add(mVuelo)
            Next
        End If

        Return mLista
    End Function
End Class