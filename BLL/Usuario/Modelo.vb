Imports BE
Imports DAL

Public Class Modelo

#Region "Propiedades"
    Public Property Roles As New List(Of RolBLL)
    Public Property Usuarios As New List(Of UsuarioBLL)

    ''' <summary>
    ''' Es el primer nodo del arbol y deberia contener todos los permisos que tiene el sistema
    ''' </summary>
    ''' <returns></returns>
    Public Property PermisoRaiz As PermisoAbstractoBLL
#End Region

#Region "Singleton"

    ''' <summary>
    ''' Devuelve la unica instancia de Modelo existente en el sistema
    ''' </summary>
    Private Shared mInstancia As Modelo
    Public Shared Function GetInstance() As Modelo
        If mInstancia Is Nothing Then
            mInstancia = New Modelo
        End If

        Return mInstancia
    End Function


    Public Sub New()
        Dim mRaiz As New PermisoCompuestoBLL
        mRaiz.Nombre = "Permisos del Sistema"

        Me.PermisoRaiz = mRaiz
    End Sub

#End Region


    ''' <summary>
    ''' Carga la lista de Roles con todos los roles que haya en la BD
    ''' </summary>
    Private Sub CargarRoles()
        'Metodos de BLL para listar los roles
    End Sub

End Class
