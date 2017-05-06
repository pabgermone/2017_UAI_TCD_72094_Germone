﻿Imports System.Windows.Forms
Imports BE
Imports DAL

Public MustInherit Class PermisoAbstractoBLL
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Padre As Integer
    Public Property Formulario As String
    Public Property Seleccionada As Boolean


    Public MustOverride Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
    Public MustOverride Sub Guardar()
    Public MustOverride Sub Eliminar()
    'Public MustOverride Function Clone() As PermisoAbstractoBLL
End Class