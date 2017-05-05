Imports System.Windows.Forms
Imports BE
Imports BLL
Imports DAL

Public Class PermisoBLL
    Inherits PermisoAbstractoBLL
    Private Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
        pBE.Formulario = Me.Formulario
    End Sub


    Public Overrides Sub Eliminar()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Guardar()
        Dim mBE As New PermisoBE

        If Me.ID = 0 Then
            Me.ID = PermisoDAL.GetProximoID
            CargarBE(mBE)
            PermisoDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PermisoDAL.GuardarModificacion(mBE)
        End If
    End Sub

    Public Overrides Sub MostrarEnTreeview(ByRef padres As TreeNodeCollection)
        Dim node As TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me
    End Sub

    Public Overrides Function Clone() As PermisoAbstractoBLL
        Dim pat As New PermisoBLL
        pat.Nombre = Me.Nombre
        Return pat
    End Function
End Class
