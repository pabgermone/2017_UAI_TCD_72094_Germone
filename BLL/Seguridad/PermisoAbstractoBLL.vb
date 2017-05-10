Imports System.Windows.Forms
Imports BE
Imports DAL

''' <summary>
''' Representa los dos tipos de permisos presentes en el sistema
''' </summary>
Public MustInherit Class PermisoAbstractoBLL
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Padre As Integer
    Public Property Formulario As String
    Public Property Seleccionada As Boolean


    Public MustOverride Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
    Public MustOverride Sub MostrarEnMenuStrip(pMenu As MenuStrip, pUsuario As UsuarioBLL, pForm As Form)
    Public MustOverride Sub Guardar()
    Public MustOverride Sub Eliminar()
    Public MustOverride Sub CargarBE(pBE As PermisoAbstractoBE)
End Class
