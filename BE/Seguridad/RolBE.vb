﻿Public Class RolBE
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property DV As Integer
    Public Property ListaPermisos As New List(Of PermisoAbstractoBE)
End Class
