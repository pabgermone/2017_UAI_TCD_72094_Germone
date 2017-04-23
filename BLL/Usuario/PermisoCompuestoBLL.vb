Imports System.Windows.Forms
Imports BE
Imports BLL
Imports DAL

Public Class PermisoCompuestoBLL
    Inherits PermisoAbstractoBLL
    Public Property ListaPatentes As New List(Of PermisoAbstractoBLL)

    Private Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
    End Sub


    Public Overrides Sub Eliminar()
        Dim mBE As New PermisoCompuestoBE
        CargarBE(mBE)
        PermisoDAL.Eliminar(mBE)
    End Sub

    Public Overrides Sub Guardar()
        Dim mBE As New PermisoCompuestoBE

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

        For Each patente As PermisoAbstractoBLL In ListaPatentes
            patente.MostrarEnTreeview(node.Nodes)
        Next
    End Sub

    Public Overrides Function Clone() As PermisoAbstractoBLL
        Dim pat As New PermisoCompuestoBLL
        pat.Nombre = Me.Nombre

        For Each patente As PermisoAbstractoBLL In ListaPatentes
            pat.ListaPatentes.Add(patente.Clone())
        Next

        Return pat
    End Function
End Class
