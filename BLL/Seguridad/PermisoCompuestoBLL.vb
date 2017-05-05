Imports System.Windows.Forms
Imports BE
Imports DAL

Public Class PermisoCompuestoBLL
    Inherits PermisoAbstractoBLL

    ''' <summary>
    ''' Lista de todos los permisos "hijos" de este PermisoCompuesto
    ''' </summary>
    ''' <returns></returns>
    Public Property ListaPermisos As New List(Of PermisoAbstractoBLL)


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
        pBE.Formulario = Me.Formulario
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta entidad de la BD
    ''' </summary>
    Public Overrides Sub Eliminar()
        Dim mBE As New PermisoCompuestoBE
        CargarBE(mBE)
        PermisoDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Guarda los datos de esta instancia en la BD
    ''' </summary>
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


    ''' <summary>
    ''' Agrega a la lsita de permisos de esta instancia, un nuevo permiso hijo
    ''' </summary>
    ''' <param name="pPermiso">Objeto BLL que se quiere agregar a la lista</param>
    Public Sub AgregarPermisoHijo(pPermiso As PermisoAbstractoBLL)
        If pPermiso.Padre = 0 Then
            Me.ListaPermisos.Add(pPermiso)

            pPermiso.Padre = Me.ID
            pPermiso.Guardar()

            Me.Guardar()
        Else
            MsgBox("Este permiso ya es parte de otro permiso compuesto")
        End If
    End Sub


    ''' <summary>
    ''' ???
    ''' </summary>
    ''' <param name="padres"></param>
    Public Overrides Sub MostrarEnTreeview(ByRef padres As TreeNodeCollection)
        Dim node As TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me

        For Each patente As PermisoAbstractoBLL In ListaPermisos
            patente.MostrarEnTreeview(node.Nodes)
        Next
    End Sub


    ''' <summary>
    ''' ???
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function Clone() As PermisoAbstractoBLL
        Dim pat As New PermisoCompuestoBLL
        pat.Nombre = Me.Nombre

        For Each patente As PermisoAbstractoBLL In ListaPermisos
            pat.ListaPermisos.Add(patente.Clone())
        Next

        Return pat
    End Function
End Class
