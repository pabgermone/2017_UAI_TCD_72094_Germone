Imports BE
Imports DAL

Public Class Modelo

#Region "Propiedades"
    Public Property ListaRoles As New List(Of RolBLL)
    Public Property ListaUsuarios As New List(Of UsuarioBLL)

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
        'CargarListas()

        Dim mRaiz As New PermisoCompuestoBLL
        mRaiz.Nombre = "Permisos del Sistema"

        Me.PermisoRaiz = mRaiz
    End Sub

#End Region


    ''' <summary>
    ''' Carga la lista de Roles con todos los roles que haya en la BD
    ''' </summary>
    Private Sub CargarListas()
        Me.ListaRoles = RolBLL.ListarRoles
        Me.ListaUsuarios = UsuarioBLL.ListarUsuarios
    End Sub

End Class
