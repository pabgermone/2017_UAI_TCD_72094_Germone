Imports System.Windows.Forms
Imports BE
Imports DAL

Public Class PermisoBLL
    Inherits PermisoAbstractoBLL

    Sub New()

    End Sub

    Sub New(pBE As PermisoBE)
        CargarPropiedades(pBE)
    End Sub

    Public Overrides Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
        pBE.Formulario = Me.Formulario
    End Sub

    Private Sub CargarPropiedades(pBE As PermisoBE)
        Me.ID = pBE.ID
        Me.Nombre = pBE.Nombre
        Me.Padre = pBE.Padre
        Me.Formulario = pBE.Formulario
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

    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Return Nothing
    End Function

    Public Overrides Sub MostrarEnMenuStrip(pMenu As MenuStrip, pUsuario As UsuarioBLL, pForm As Form)

    End Sub

    'Public Overrides Function Clone() As PermisoAbstractoBLL
    '    Dim pat As New PermisoBLL
    '    pat.Nombre = Me.Nombre
    '    Return pat
    'End Function
End Class
