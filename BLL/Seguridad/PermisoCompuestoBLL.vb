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


    Sub New()

    End Sub

    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub


    Private Sub CargarPropiedades(pID As Integer)
        Dim mBE As PermisoCompuestoBE = PermisoDAL.ObtenerPermiso(pID, True)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
            Me.Padre = mBE.Padre
            Me.Formulario = mBE.Formulario
        End If
    End Sub


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
    Public Sub AgregarPermisoHijo(pPermisoPadre As PermisoCompuestoBE, pTreenode As TreeNode)
        For Each mPermisoAbstracto As PermisoAbstractoBE In pPermisoPadre.ListaPermisos
            Dim mNode As New TreeNode
            mNode.Text = mPermisoAbstracto.Nombre
            mNode.Tag = mPermisoAbstracto
            pTreenode.Nodes.Add(mNode)

            If TypeOf (mPermisoAbstracto) Is PermisoCompuestoBE Then
                mNode.Text = mPermisoAbstracto.Nombre

                Dim mPermisoCompuesto As PermisoCompuestoBE
                mPermisoCompuesto = DirectCast(mPermisoAbstracto, PermisoCompuestoBE)

                If Not mPermisoCompuesto.ListaPermisos Is Nothing Then
                    AgregarPermisoHijo(mPermisoCompuesto, pTreenode.LastNode)
                End If
            End If
        Next
    End Sub


    ''' <summary>
    ''' ???
    ''' </summary>
    ''' <param name="padres"></param>
    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Try
            Dim mListaPermisos As New List(Of PermisoAbstractoBE)
            mListaPermisos = PermisoDAL.ListarPermisos(True)

            Dim mNode As TreeNode = pTreeView.Nodes.Add(mListaPermisos.Item(0).Nombre)
            mNode.Tag = mListaPermisos.Item(0)
            AgregarPermisoHijo(mNode.Tag, mNode)
        Catch ex As Exception

        End Try

        Return pTreeView
    End Function


    ''' <summary>
    ''' ???
    ''' </summary>
    ''' <returns></returns>
    'Public Overrides Function Clone() As PermisoAbstractoBLL
    '    Dim pat As New PermisoCompuestoBLL
    '    pat.Nombre = Me.Nombre

    '    For Each patente As PermisoAbstractoBLL In ListaPermisos
    '        pat.ListaPermisos.Add(patente.Clone())
    '    Next

    '    Return pat
    'End Function


    Public Shared Function ListarPermisos() As List(Of PermisoAbstractoBLL)
        Dim mListaPermisos As New List(Of PermisoAbstractoBLL)
        Dim mListBE As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(True)

        If Not IsNothing(mListBE) Then
            For Each mPermiso As PermisoAbstractoBE In mListBE
                If TypeOf (mPermiso) Is PermisoCompuestoBE Then
                    Dim mPermisoBLL As New PermisoCompuestoBLL(mPermiso.ID)
                    mListaPermisos.Add(mPermisoBLL)
                End If
            Next
        End If

        Return mListaPermisos
    End Function
End Class
