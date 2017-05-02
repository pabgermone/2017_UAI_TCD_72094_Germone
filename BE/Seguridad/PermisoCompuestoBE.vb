Public Class PermisoCompuestoBE
    Inherits PermisoAbstractoBE

    ''' <summary>
    ''' Lista de todos los permisos "hijos" que tiene este PermisoCompuesto
    ''' </summary>
    ''' <returns></returns>
    Public Property ListaPermisos As New List(Of PermisoAbstractoBE)
End Class
