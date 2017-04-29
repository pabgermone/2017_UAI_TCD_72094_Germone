﻿Imports BE
Imports DAL

Public Class RolBLL

#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Permisos As New List(Of PermisoAbstractoBE)
    Public Property PermisoRaiz As PermisoAbstractoBLL '??
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    ''' <summary>
    ''' Carga un objeto BLL con los datos que haya guardados en el BD para esta entidad
    ''' </summary>
    ''' <param name="pRol">Nombre que tiene la entidad en la BD</param>
    Sub New(pRol As String)
        CargarPropiedades(pRol)
    End Sub
#End Region


    ''' <summary>
    ''' Carga las propiedades de una instacia con los datos que haya guardados en la BD
    ''' </summary>
    ''' <param name="pRol">Nombre de la entidad en la BD</param>
    Private Sub CargarPropiedades(pRol As String)
        Dim mBE As RolBE = RolDAL.ObtenerRol(pRol)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
            Me.Permisos = mBE.ListaPermisos
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE vacio con las propiedades que haya en el objeto BLL
    ''' </summary>
    ''' <param name="mBE">Objeto BE a cargar</param>
    Private Sub CargarBE(mBE As RolBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
        mBE.ListaPermisos = Me.Permisos
    End Sub


    ''' <summary>
    ''' Guarda los datos de esta instancia BLL en la BD
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New RolBE

        If Me.ID = 0 Then
            Me.ID = RolDAL.GetProximoID
            CargarBE(mBE)
            RolDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            RolDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina de la BD los datos de esta instancia
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New RolBE

        CargarBE(mBE)

        RolDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Lista todos los roles guardados en la BD
    ''' </summary>
    ''' <returns>List(Of RolBLL) que contiene todos los roles existentes en la BD</returns>
    Public Shared Function ListarRoles() As List(Of RolBLL)
        Dim mLista As New List(Of RolBLL)
        Dim mListaBE As List(Of RolBE) = RolDAL.ListarRoles

        For Each mBE As RolBE In mListaBE
            Dim mRol As New RolBLL(mBE.Nombre)

            mLista.Add(mRol)
        Next

        Return mLista
    End Function


    Public Overrides Function ToString() As String 'Necesario?
        Return Me.Nombre
    End Function
End Class
