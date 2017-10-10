Imports BE
Imports DAL
Imports Framework

Public Class RolBLL

#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property DV As Integer
    Public Property ListaPermisos As New List(Of PermisoAbstractoBLL)
    Public Property PermisoRaiz As PermisoAbstractoBLL '??
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    ''' <summary>
    ''' Crea una nueva instancia con los datos que tengan las propiedades del objeto BE pasado por parametro
    ''' </summary>
    ''' <param name="pRol">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pRol As RolBE)
        CargarPropiedades(pRol)
    End Sub

    ''' <summary>
    ''' Crea una nueva instancia con los datos recuperados de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub
#End Region

#Region "Carga de Datos"

    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pBE">Objeto BE con los datos deseados</param>
    Private Sub CargarPropiedades(pBE As RolBE)
        If Not IsNothing(pBE) Then
            If CalculadorDV.VerificarDV(pBE.Nombre, pBE.DV) Then
                Me.ID = pBE.ID
                Me.Nombre = pBE.Nombre
                Me.DV = pBE.DV

                If pBE.ListaPermisos.Count > 0 Then
                    For Each mPermisoBE As PermisoAbstractoBE In pBE.ListaPermisos
                        Dim mPermiso As PermisoAbstractoBLL

                        If TypeOf (mPermisoBE) Is PermisoCompuestoBE Then
                            mPermiso = New PermisoCompuestoBLL(mPermisoBE)
                        Else
                            mPermiso = New PermisoBLL(mPermisoBE)
                        End If

                        Me.ListaPermisos.Add(mPermiso)
                    Next
                End If
            Else
                MsgBox("Error DV - CargarPropiedades(BE) - RolBLL")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos recuperados de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Private Sub CargarPropiedades(pID As Integer)
        Dim pBE As RolBE = RolDAL.ObtenerRol(pID)

        If Not IsNothing(pBE) Then
            If CalculadorDV.VerificarDV(pBE.Nombre, pBE.DV) Then
                Me.ID = pBE.ID
                Me.Nombre = pBE.Nombre
                Me.DV = pBE.DV

                If pBE.ListaPermisos.Count > 0 Then
                    For Each mPermisoBE As PermisoAbstractoBE In pBE.ListaPermisos
                        Dim mPermiso As PermisoAbstractoBLL

                        If TypeOf (mPermisoBE) Is PermisoCompuestoBE Then
                            mPermiso = New PermisoCompuestoBLL(mPermisoBE)
                        Else
                            mPermiso = New PermisoBLL(mPermisoBE)
                        End If

                        Me.ListaPermisos.Add(mPermiso)
                    Next
                End If
            Else
                MsgBox("Error DV - CargarPropiedades(int) - RolBLL")
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
        mBE.DV = Me.DV

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

#End Region


    ''' <summary>
    ''' Guarda los datos de esta instancia BLL en la BD
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New RolBE

        Me.DV = CalculadorDV.CalcularDV(Me.Nombre)

        If Me.ID = 0 Then
            CargarBE(mBE)
            RolDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            RolDAL.GuardarModificacion(mBE)
        End If

        ControladorDVV.ModificarDigito("Rol", ControladorDVV.CalcularDVV("Rol"))
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

        ControladorDVV.ModificarDigito("Rol", ControladorDVV.CalcularDVV("Rol"))
    End Sub


    ''' <summary>
    ''' Elimina un permiso de la lista de permisos del rol
    ''' </summary>
    ''' <param name="pPermisoID">ID del permiso que quiere eliminarse</param>
    Public Sub EliminarRelacion(pPermisoID As Integer)
        For Each mPermiso As PermisoAbstractoBLL In Me.ListaPermisos
            If mPermiso.ID = pPermisoID Then
                Me.ListaPermisos.Remove(mPermiso)
            End If
        Next
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
                Dim mRol As New RolBLL(mBE)

                mLista.Add(mRol)
            Next
        End If

        Return mLista
    End Function


    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class
