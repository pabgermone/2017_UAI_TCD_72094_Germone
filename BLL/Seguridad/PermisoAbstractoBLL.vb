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
    Public Property Texto As String


    Public MustOverride Sub MostrarEnTreeview(Optional pTreeView As TreeView = Nothing, Optional pNode As TreeNode = Nothing)
    Public MustOverride Sub MostrarEnMenuStrip(pMenu As MenuStrip, pUsuario As UsuarioBLL, pForm As Form)
    Public MustOverride Sub Guardar()
    Public MustOverride Sub Eliminar()
    Public MustOverride Sub CargarBE(pBE As PermisoAbstractoBE)
End Class
