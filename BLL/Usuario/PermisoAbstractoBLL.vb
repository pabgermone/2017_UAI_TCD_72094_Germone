Imports System.Windows.Forms
Imports BE
Imports DAL

Public MustInherit Class PermisoAbstractoBLL
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Padre As Integer

    Public MustOverride Sub MostrarEnTreeview(ByRef padres As TreeNodeCollection)
    Public MustOverride Sub Guardar()
    Public MustOverride Sub Eliminar()
End Class
