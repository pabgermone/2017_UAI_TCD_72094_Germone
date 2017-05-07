Imports System.Windows.Forms
Imports System.Reflection
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

    Sub New(pBE As PermisoCompuestoBE)
        CargarPropiedades(pBE)
        CargarHijos()
    End Sub

    Sub New(pID As Integer)
        CargarPropiedades(pID)
        CargarHijos()
    End Sub

    Private Sub CargarPropiedades(pBE As PermisoCompuestoBE)
        If Not IsNothing(pBE) Then
            Me.ID = pBE.ID
            Me.Nombre = pBE.Nombre
            Me.Padre = pBE.Padre
            Me.Formulario = pBE.Formulario
        End If
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
    Public Overrides Sub CargarBE(pBE As PermisoAbstractoBE)
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
            'Me.ID = PermisoDAL.GetProximoID
            CargarBE(mBE)
            PermisoDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PermisoDAL.GuardarModificacion(mBE)
        End If
    End Sub


    Public Sub AgregarPermisosHijo(pPermisoPadre As PermisoCompuestoBLL, pTreenode As TreeNode)
        For Each mPermisoAbstracto As PermisoAbstractoBLL In pPermisoPadre.ListaPermisos
            Dim mNode As New TreeNode
            mNode.Text = mPermisoAbstracto.Nombre
            mNode.Tag = mPermisoAbstracto
            pTreenode.Nodes.Add(mNode)

            If TypeOf (mPermisoAbstracto) Is PermisoCompuestoBLL Then
                'mNode.Text = mPermisoAbstracto.Nombre

                Dim mPermisoCompuesto As PermisoCompuestoBLL
                mPermisoCompuesto = DirectCast(mPermisoAbstracto, PermisoCompuestoBLL)

                If mPermisoCompuesto.ListaPermisos.Count > 0 Then
                    AgregarPermisosHijo(mPermisoCompuesto, pTreenode.LastNode)
                End If
            End If
        Next
    End Sub


    'Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
    '    Try
    '        Dim mListaPermisos As List(Of PermisoAbstractoBLL) = ListarPermisos()

    '        'El primer item de la lista deberia ser el permiso compuesto generico que tiene como hijos
    '        'a todos los demas permisos que no tienen padre
    '        Dim mNode As TreeNode = pTreeView.Nodes.Add(mListaPermisos.Item(0).Nombre)
    '        mNode.Tag = mListaPermisos.Item(0)

    '        AgregarPermisosHijo(mNode.Tag, mNode)
    '    Catch ex As Exception

    '    End Try

    '    Return pTreeView
    'End Function


    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Try
            Dim mListaPermisos As List(Of PermisoAbstractoBLL) = ListarPermisos()

            'El primer item de la lista deberia ser el permiso compuesto generico que tiene como hijos
            'a todos los demas permisos que no tienen padre
            Dim mNode As TreeNode = pTreeView.Nodes.Add(mListaPermisos.Item(0).Nombre)
            mNode.Tag = mListaPermisos.Item(0)

            AgregarPermisosHijo(mNode.Tag, mNode)
        Catch ex As Exception

        End Try

        Return pTreeView
    End Function



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
                    Dim mPermisoBLL As New PermisoCompuestoBLL(mPermiso)
                    mListaPermisos.Add(mPermisoBLL)
                End If
            Next
        End If

        Return mListaPermisos
    End Function



    ''' <summary>
    ''' Carga la lista de permisos hijo de la instancia que llama a este metodo
    ''' </summary>
    Private Sub CargarHijos()
        Dim mListaCompuestos As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(True, Me.ID)
        Dim mListaSimples As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(False, Me.ID)

        If Not IsNothing(mListaCompuestos) Then
            For Each mPermisoAbs As PermisoAbstractoBE In mListaCompuestos
                Dim mPermisoBLL As New PermisoCompuestoBLL(mPermisoAbs)
                Me.ListaPermisos.Add(mPermisoBLL)
            Next
        End If

        If Not IsNothing(mListaSimples) Then
            For Each mPermisoAbs As PermisoAbstractoBE In mListaSimples
                Dim mPermisoBLL As New PermisoBLL(mPermisoAbs)
                Me.ListaPermisos.Add(mPermisoBLL)
            Next
        End If
    End Sub


    Public Overrides Sub MostrarEnMenuStrip(pMenuStrip As MenuStrip, pUsuario As UsuarioBLL, pFormulario As Form)
        Dim mRol As New RolBLL(pUsuario.Rol)

        For Each mPermisoAbs As PermisoAbstractoBLL In mRol.ListaPermisos
            Dim mMenuItem As New ToolStripMenuItem()

            mMenuItem.Name = mPermisoAbs.Nombre
            mMenuItem.Tag = mPermisoAbs

            pMenuStrip.Items.Add(mMenuItem)
            pMenuStrip.Items.Item(mMenuItem.Name).Text = mPermisoAbs.Nombre

            If TypeOf mPermisoAbs Is PermisoCompuestoBLL Then
                AgregarToolStrip(mPermisoAbs, mMenuItem, pFormulario)
            Else
                AddHandler mMenuItem.Click, AddressOf Menu_Click
            End If
        Next
    End Sub


    Public Sub AgregarToolStrip(pPermiso As PermisoAbstractoBLL, pMenuItem As ToolStripMenuItem, pFormulario As Form)
        Try
            Dim mPadre As PermisoCompuestoBLL = DirectCast(pPermiso, PermisoCompuestoBLL)

            If Not mPadre.ListaPermisos Is Nothing Then
                For Each mPermisoAbs As PermisoAbstractoBLL In mPadre.ListaPermisos
                    Dim mMenuItem As New ToolStripMenuItem

                    mMenuItem.Name = mPermisoAbs.Nombre
                    mMenuItem.Tag = mPermisoAbs

                    pMenuItem.DropDownItems.Add(mMenuItem)
                    pMenuItem.DropDownItems.Item(mMenuItem.Name).Text = mPermisoAbs.Nombre


                    If TypeOf mPermisoAbs Is PermisoCompuestoBLL Then
                        AgregarToolStrip(mPermisoAbs, mMenuItem, pFormulario)
                    Else
                        AddHandler mMenuItem.Click, AddressOf Menu_Click
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mMenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Click(mMenuItem)
    End Sub


    Private Sub Click(pMenuItem As ToolStripItem)
        Dim mFormName As String = DirectCast(pMenuItem.Tag, PermisoBLL).Formulario.ToString
        Dim mAssembly As Assembly = Assembly.GetEntryAssembly
        Dim mType As Type = mAssembly.GetType(mFormName)
        Dim mForm = Activator.CreateInstance(mType)
        mForm.ShowDialog()
    End Sub
End Class
