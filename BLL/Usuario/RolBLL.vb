Imports BE
Imports DAL

Public Class RolBLL
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Permisos As New List(Of PermisoAbstractoBE)
    Public Property PermisoRaiz As PermisoAbstractoBLL


    Sub New()

    End Sub

    Sub New(pRol As String)
        CargarPropiedades(pRol)
    End Sub



    Private Sub CargarPropiedades(pRol As String)
        Dim mBE As RolBE = RolDAL.ObtenerRol(pRol)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
        End If
    End Sub


    Private Sub CargarBE(mBE As RolBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
    End Sub


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


    Public Sub Eliminar()
        Dim mBE As New RolBE

        CargarBE(mBE)

        RolDAL.Eliminar(mBE)
    End Sub


    Public Shared Function ListarUsuarios() As List(Of RolBLL)
        Dim mLista As New List(Of RolBLL)
        Dim mListaBE As List(Of RolBE) = RolDAL.ListarRols

        For Each mBE As RolBE In mListaBE
            Dim mUsuario As New RolBLL(mBE.ID)

            mLista.Add(mUsuario)
        Next

        Return mLista
    End Function

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class
