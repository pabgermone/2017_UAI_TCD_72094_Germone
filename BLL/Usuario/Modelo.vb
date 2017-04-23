Imports BE
Imports DAL

Public Class Modelo

    Private Shared mInstancia As Modelo
    Public Shared Function GetInstance() As Modelo
        If mInstancia Is Nothing Then
            mInstancia = New Modelo
        End If

        Return mInstancia
    End Function


    Public Property Roles As New List(Of RolBLL)
    Public Property Usuarios As New List(Of UsuarioBLL)
    Public Property PermisoRaiz As PermisoAbstractoBLL

    Public Sub New()
        Dim mRaiz As New PermisoCompuestoBLL
        mRaiz.Nombre = "Permisos del Sistema"

        Me.PermisoRaiz = mRaiz
    End Sub
End Class
