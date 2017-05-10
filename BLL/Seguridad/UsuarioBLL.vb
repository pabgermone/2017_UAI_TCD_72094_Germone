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
    ''' <param name="pUser">Nombre de usuario del que se quieren recuperar datos</param>
    Sub New(pUser As String)
        CargarPropiedades(pUser)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pUser">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pUser As UsuarioBE)
        CargarPropiedades(pUser)
    End Sub
#End Region

#Region "Carga de Datos"
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
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pUser">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pUser As UsuarioBE)
        If Not IsNothing(pUser) Then
            Me.ID = pUser.ID
            Me.UserName = pUser.UserName
            Me.Nombre = pUser.Nombre
            Me.Apellido = pUser.Apellido
            Me.Password = pUser.Password
            Me.Rol = pUser.Rol
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
#End Region


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

        If Not IsNothing(mListaBE) Then
            For Each mBE As UsuarioBE In mListaBE
                Dim mUsuario As New UsuarioBLL(mBE)

                mLista.Add(mUsuario)
            Next
        End If


        Return mLista
    End Function


    Public Overrides Function ToString() As String
        Return Me.UserName
    End Function
End Class