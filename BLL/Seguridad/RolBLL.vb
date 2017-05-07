Imports BE
Imports DAL

Public Class RolBLL

#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property ListaPermisos As New List(Of PermisoAbstractoBLL)
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

            If mBE.ListaPermisos.Count > 0 Then
                For Each mPermisoBE As PermisoAbstractoBE In mBE.ListaPermisos
                    Dim mPermiso As PermisoAbstractoBLL

                    If TypeOf (mPermisoBE) Is PermisoCompuestoBE Then
                        mPermiso = New PermisoCompuestoBLL(mPermisoBE)
                    Else
                        mPermiso = New PermisoBLL(mPermisoBE)
                    End If

                    Me.ListaPermisos.Add(mPermiso)
                Next
            End If
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE vacio con las propiedades que haya en el objeto BLL
    ''' </summary>
    ''' <param name="mBE">Objeto BE a cargar</param>
    Private Sub CargarBE(mBE As RolBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre

        For Each mPermisoBLL As PermisoAbstractoBLL In Me.ListaPermisos
            Dim mPermiso As PermisoAbstractoBE

            If TypeOf (mPermisoBLL) Is PermisoCompuestoBLL Then
                mPermiso = New PermisoCompuestoBE
            Else
                mPermiso = New PermisoBE
            End If

            mPermisoBLL.CargarBE(mPermiso)
            mBE.ListaPermisos.Add(mPermiso)
        Next
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
            RolPermisoDAL.EliminarPorRol(Me.ID)
            RolPermisoCompuestoDAL.EliminarPorRol(Me.ID)

            CargarBE(mBE)
            RolDAL.GuardarModificacion(mBE)
        End If

        If mBE.ListaPermisos.Count > 0 Then
            For Each mPermiso As PermisoAbstractoBE In mBE.ListaPermisos
                If TypeOf (mPermiso) Is PermisoBE Then
                    RolPermisoDAL.GuardarNuevo(mBE.ID, mPermiso.ID)
                Else
                    RolPermisoCompuestoDAL.GuardarNuevo(mBE.ID, mPermiso.ID)
                End If
            Next
        End If
    End Sub


    <Obsolete("Falta implementar")>
    Public Sub QuitarPermiso(pPermiso As PermisoAbstractoBE)
        'Buscar forma de apuntar el permiso seleccionado al permiso dentro de la lista del rol
        Throw New NotImplementedException
    End Sub


    ''' <summary>
    ''' Elimina de la BD los datos de esta instancia
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New RolBE

        CargarBE(mBE)

        RolPermisoDAL.EliminarPorRol(mBE.ID)
        RolDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Lista todos los roles guardados en la BD
    ''' </summary>
    ''' <returns>List(Of RolBLL) que contiene todos los roles existentes en la BD</returns>
    Public Shared Function ListarRoles() As List(Of RolBLL)
        Dim mLista As New List(Of RolBLL)
        Dim mListaBE As List(Of RolBE) = RolDAL.ListarRoles

        If Not IsNothing(mListaBE) Then
            For Each mBE As RolBE In mListaBE
                Dim mRol As New RolBLL(mBE.Nombre)

                mLista.Add(mRol)
            Next
        End If

        Return mLista
    End Function


    Public Overrides Function ToString() As String 'Necesario?
        Return Me.Nombre
    End Function
End Class
