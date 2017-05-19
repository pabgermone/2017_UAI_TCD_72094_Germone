Imports System.Windows.Forms
Imports BE
Imports DAL

Public Class PermisoBLL
    Inherits PermisoAbstractoBLL

#Region "Constructores"
    Sub New()

    End Sub

    ''' <summary>
    ''' Crea una instancia ya cargada con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pBE"></param>
    Sub New(pBE As PermisoBE)
        CargarPropiedades(pBE)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BE con los datos de la instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se desea cargar</param>
    Public Overrides Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
        pBE.Formulario = Me.Formulario
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pBE">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pBE As PermisoBE)
        Me.ID = pBE.ID
        Me.Nombre = pBE.Nombre
        Me.Padre = pBE.Padre
        Me.Formulario = pBE.Formulario
    End Sub
#End Region


    ''' <summary>
    ''' Elimina los datos de esta instancia de BD
    ''' </summary>
    Public Overrides Sub Eliminar()
        Throw New NotImplementedException()
    End Sub


    ''' <summary>
    ''' Persiste los datos de la instancia en BD
    ''' </summary>
    Public Overrides Sub Guardar()
        Dim mBE As New PermisoBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            PermisoDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PermisoDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Lista todos los permisos simples existentes en BD
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function ListarPermisos() As List(Of PermisoAbstractoBLL)
        Dim mListaPermisos As New List(Of PermisoAbstractoBLL)
        Dim mListBE As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos

        If Not IsNothing(mListBE) Then
            For Each mPermiso As PermisoAbstractoBE In mListBE
                If TypeOf (mPermiso) Is PermisoBE Then
                    Dim mPermisoBLL As New PermisoBLL(mPermiso)
                End If
            Next
        End If

        Return mListaPermisos
    End Function


#Region "Metodos Composite"
    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Return Nothing
    End Function

    Public Overrides Sub MostrarEnMenuStrip(pMenu As MenuStrip, pUsuario As UsuarioBLL, pForm As Form)

    End Sub
#End Region

End Class
