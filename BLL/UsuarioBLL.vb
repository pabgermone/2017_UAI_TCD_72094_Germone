Imports DAL
Imports BE

Public Class UsuarioBLL
    Public Property ID As Integer
    Public Property UserName As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Password As String
    Public Property Rol As Integer


    Sub New()

    End Sub

    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub



    Private Sub CargarPropiedades(pID As Integer)
        Dim mBE As UsuarioBE = UsuarioDAL.ObtenerUsuario(pID)

        Me.ID = mBE.ID
        Me.UserName = mBE.UserName
        Me.Nombre = mBE.Nombre
        Me.Apellido = mBE.Apellido
        Me.Password = mBE.Password
        Me.Rol = mBE.Rol
    End Sub


    Private Sub CargarBE(mBE As UsuarioBE)
        mBE.ID = Me.ID
        mBE.UserName = Me.UserName
        mBE.Nombre = Me.Nombre
        mBE.Apellido = Me.Apellido
        mBE.Password = Me.Password
        mBE.Rol = Me.Rol
    End Sub


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


    Public Sub Eliminar()
        Dim mBE As New UsuarioBE

        CargarBE(mBE)

        UsuarioDAL.Eliminar(mBE)
    End Sub


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
