﻿Imports BE
Imports DAL
Imports Framework

Public Class VentaBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Usuario As Integer
    Public Property Fecha As Date
    Public Property Paquete As Integer
    Public Property DV As Integer

    Public Property Clientes As New List(Of ClienteBLL)
    Public Property Vuelos As New List(Of VueloBLL)
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un VentaBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pVenta">Nombre de Venta del que se quieren recuperar datos</param>
    Sub New(pVenta As Integer)
        CargarPropiedades(pVenta)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pVenta As VentaBE)
        CargarPropiedades(pVenta)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pVenta">ID de la Venta del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pVenta As Integer)
        Dim mBE As VentaBE = VentaDAL.ObtenerVenta(pVenta)

        If Not IsNothing(mBE) Then
            If CalculadorDV.VerificarDV(mBE.Usuario & mBE.Fecha.ToString("yyyymmdd") & mBE.Paquete, mBE.DV) Then
                Me.ID = mBE.ID
                Me.Usuario = mBE.Usuario
                Me.Fecha = mBE.Fecha
                Me.Paquete = mBE.Paquete

                For Each mCliente As ClienteBE In mBE.Clientes
                    Dim mClienteBLL As New ClienteBLL(mCliente)

                    Me.Clientes.Add(mClienteBLL)
                Next

                For Each mVuelo As VueloBE In mBE.Vuelos
                    Dim mVueloBLL As New VueloBLL(mVuelo)

                    Me.Vuelos.Add(mVueloBLL)
                Next
            Else
                MsgBox("Error - DV - Venta - CargarPropiedades(Integer)")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pVenta As VentaBE)
        If Not IsNothing(pVenta) Then
            Me.ID = pVenta.ID
            Me.Usuario = pVenta.Usuario
            Me.Fecha = pVenta.Fecha
            Me.Paquete = pVenta.Paquete

            For Each mCliente As ClienteBE In pVenta.Clientes
                Dim mClienteBLL As New ClienteBLL(mCliente)

                Me.Clientes.Add(mClienteBLL)
            Next

            For Each mVuelo As VueloBE In pVenta.Vuelos
                Dim mVueloBLL As New VueloBLL(mVuelo)

                Me.Vuelos.Add(mVueloBLL)
            Next
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As VentaBE)
        mBE.ID = Me.ID
        mBE.Usuario = Me.Usuario
        mBE.Fecha = Me.Fecha
        mBE.Paquete = Me.Paquete
        mBE.DV = Me.DV

        For Each mCliente As ClienteBLL In Me.Clientes
            Dim mClienteBE As New ClienteBE

            mCliente.CargarBE(mClienteBE)

            mBE.Clientes.Add(mClienteBE)
        Next

        For Each mVuelo As VueloBLL In Me.Vuelos
            Dim mVueloBE As New VueloBE

            mVuelo.CargarBE(mVueloBE)

            mBE.Vuelos.Add(mVueloBE)
        Next
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New VentaBE

        Me.DV = CalculadorDV.CalcularDV(Me.Usuario & Me.Fecha.ToString("yyyymmdd") & Me.Paquete)

        If Me.ID = 0 Then
            CargarBE(mBE)
            VentaDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            VentaDAL.GuardarModificacion(mBE)

            ControladorDVV.ModificarDigito("Venta", ControladorDVV.CalcularDVV("Venta"))
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New VentaBE

        CargarBE(mBE)

        VentaDAL.Eliminar(mBE)

        ControladorDVV.ModificarDigito("Venta", ControladorDVV.CalcularDVV("Venta"))
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada Venta guardado en la BD
    ''' </summary>
    ''' <returns>List(Of VentaBLL) con datos de cada Venta</returns>
    Public Shared Function ListarVentas() As List(Of VentaBLL)
        Dim mLista As New List(Of VentaBLL)
        Dim mListaBE As List(Of VentaBE) = VentaDAL.ListarVentas

        If Not IsNothing(mListaBE) Then
            For Each mBE As VentaBE In mListaBE
                If CalculadorDV.VerificarDV(mBE.Usuario & mBE.Fecha.ToString("yyyymmdd") & mBE.Paquete, mBE.DV) Then
                    Dim mVenta As New VentaBLL(mBE)

                    mLista.Add(mVenta)
                Else
                    MsgBox("Error - DV - Venta - Listar")
                End If
            Next
        End If


        Return mLista
    End Function


    Public Shared Function ObtenerAnios() As List(Of Integer)
        Return VentaDAL.ObtenerAnios
    End Function


    Public Shared Function ObtenerDestinosPorAnio(pAnio As Integer) As List(Of DestinoBLL)
        Dim mListaBE As List(Of DestinoBE) = VentaDAL.ObtenerDestinosPorAnio(pAnio)
        Dim mListaDestinos As New List(Of DestinoBLL)

        If Not IsNothing(mListaBE) Then
            For Each mBE As DestinoBE In mListaBE
                Dim mBLL As New DestinoBLL(mBE)

                mListaDestinos.Add(mBLL)
            Next
        End If

        Return mListaDestinos
    End Function

End Class
