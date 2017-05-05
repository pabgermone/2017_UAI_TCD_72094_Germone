Imports DAL
Imports BE

Public Class UsuarioBLL

#Region "Propiedades"
    Public Property ID As Integer = 0
    Public Property UserName As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Password As String
    Public Property Rol As Integer = 0
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    ''' <summary>
    ''' Instancia un UsuarioBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pUser"></param>
    Sub New(pUser As String)
        CargarPropiedades(pUser)
    End Sub
#End Region


    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pUser">Nombre de Usuario del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pUser As String)
        Dim mBE As UsuarioBE = UsuarioDAL.ObtenerUsuario(pUser)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.UserName = mBE.UserName
            Me.Nombre = mBE.Nombre
            Me.Apellido = mBE.Apellido
            Me.Password = mBE.Password
            Me.Rol = mBE.Rol
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As UsuarioBE)
        mBE.ID = Me.ID
        mBE.UserName = Me.UserName
        mBE.Nombre = Me.Nombre
        mBE.Apellido = Me.Apellido
        mBE.Password = Me.Password
        mBE.Rol = Me.Rol
    End Sub


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New UsuarioBE

        If Me.ID = 0 Then
            Me.ID = UsuarioDAL.GetProximoID
            CargarBE(mBE)
            UsuarioDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            UsuarioDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New UsuarioBE

        CargarBE(mBE)

        UsuarioDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada usuario guardado en la BD
    ''' </summary>
    ''' <returns>List(Of UsuarioBLL) con datos de cada usuario</returns>
    Public Shared Function ListarUsuarios() As List(Of UsuarioBLL)
        Dim mLista As New List(Of UsuarioBLL)
        Dim mListaBE As List(Of UsuarioBE) = UsuarioDAL.ListarUsuarios


        For Each mBE As UsuarioBE In mListaBE
            Dim mUsuario As New UsuarioBLL(mBE.ID)

            mLista.Add(mUsuario)
        Next

        Return mLista
    End Function
End Class