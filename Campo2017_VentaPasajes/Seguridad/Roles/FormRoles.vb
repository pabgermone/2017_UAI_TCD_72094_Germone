Imports BLL

Public Class FormRoles
    Dim mRolSelec As RolBLL
    Dim mEstadoOriginal As TreeNodeCollection 'Contiene el estado de los nodos del treeview antes de que se cambie

#Region "Eventos Form"
    Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BtnGuardar.Enabled = False
        'BtnDeshacer.Enabled = False

        ActualizarRoles()
    End Sub


    Private Sub ListRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListRoles.SelectedValueChanged
        If Not IsNothing(ListRoles.SelectedItem) And TypeOf (ListRoles.SelectedItem) Is RolBLL Then
            mRolSelec = ListRoles.SelectedItem
            ActualizarPermisos()
        End If
    End Sub


    Private Sub TreePermisos_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreePermisos.AfterCheck

    End Sub
#End Region


#Region "Botones"
    Private Sub BtnNvoRol_Click(sender As Object, e As EventArgs) Handles BtnNvoRol.Click
        Dim mRol As New RolBLL

        mRol.Nombre = InputBox("Ingrese el nombre del rol:")

        mRol.Guardar()

        ActualizarRoles()
    End Sub
#End Region


    Public Sub ActualizarRoles()
        ListRoles.DataSource = Nothing
        ListRoles.DataSource = RolBLL.ListarRoles

        GuardarEstado()
    End Sub


    Public Sub ActualizarPermisos()
        If Not IsNothing(mRolSelec) Then
            TreePermisos.Nodes.Clear()

            Dim mPermisoRaiz As New PermisoCompuestoBLL(0)
            mPermisoRaiz.MostrarEnTreeview(Me.TreePermisos)

            'Compara el contenido de cada nodo con cada permiso que haya en la lista de permisos del rol
            'para marcarlos como seleccionados
            For Each mNodo As TreeNode In TreePermisos.Nodes
                For Each mPermiso As PermisoAbstractoBLL In mRolSelec.ListaPermisos
                    SeleccionarNodos(mNodo, mPermiso)
                Next
            Next

            TreePermisos.ExpandAll()
        End If
    End Sub


    ''' <summary>
    ''' Selecciona todos los nodos que tengan los permisos que hay en el rol
    ''' </summary>
    ''' <param name="pNodo">Nodo que contiene el permiso a comparar</param>
    ''' <param name="pPermiso">Permiso del rol que se compara con el contenido del nodo</param>
    Public Sub SeleccionarNodos(pNodo As TreeNode, pPermiso As PermisoAbstractoBLL)
        If TypeOf (pNodo.Tag) Is PermisoCompuestoBLL Then
            If CType(pNodo.Tag, PermisoAbstractoBLL).Nombre = pPermiso.Nombre Then
                SeleccionNodoRaiz(pNodo)
            Else
                For Each mNodo As TreeNode In pNodo.Nodes
                    SeleccionarNodos(mNodo, pPermiso)
                Next
            End If
        ElseIf TypeOf (pNodo.Tag) Is PermisoBLL Then
            If CType(pNodo.Tag, PermisoAbstractoBLL).Nombre = pPermiso.Nombre Then
                pNodo.Checked = True
            End If
        End If
    End Sub


    ''' <summary>
    ''' Marca como seleccionado aun nodo y todos los nodos que dependan de este. Si alguno de esos nodos, tiene
    ''' mas nodos, tambien los selecciona
    ''' </summary>
    ''' <param name="pNodo">Nodo con el PermisoCompuesto que se quiere seleccionar</param>
    Public Sub SeleccionNodoRaiz(pNodo As TreeNode)
        pNodo.Checked = True

        For Each mNodo As TreeNode In pNodo.Nodes
            SeleccionNodoRaiz(mNodo)
        Next
    End Sub


    ''' <summary>
    ''' Guarda el estado de los nodos del treeview en caso de que se quieran deshacer cambios
    ''' </summary>
    Public Sub GuardarEstado()
        mEstadoOriginal = TreePermisos.Nodes
    End Sub


    ''' <summary>
    ''' Vuelve a cargar en el treeview los nodos de la forma en que estaban antes de realizar los cambios
    ''' </summary>
    Public Sub RecuperarEstado()
        TreePermisos.Nodes.Clear()

        For Each mNodo As TreeNode In mEstadoOriginal
            TreePermisos.Nodes.Add(mNodo)
        Next
    End Sub









    'Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    '    Dim mRol As New RolBLL
    '    Dim mListaPermisos As New List(Of PermisoAbstractoBLL)

    '    mRol.Nombre = txtNombre.Text
    '    GetPermisosSeleccionados(treePatentes.Nodes, mListaPermisos)
    '    mRol.ListaPermisos = mListaPermisos
    '    mRol.Guardar()

    '    Me.Close()
    'End Sub


    'Public Sub GetPermisosSeleccionados(pNodos As TreeNodeCollection, pListaPermisos As List(Of PermisoAbstractoBLL))
    '    For Each mNode As TreeNode In pNodos
    '        If mNode.Checked Then
    '            pListaPermisos.Add(CType(mNode.Tag, PermisoAbstractoBLL))
    '        End If

    '        GetPermisosSeleccionados(mNode.Nodes, pListaPermisos)
    '    Next
    'End Sub


    'Private Sub treePatentes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterCheck
    '    e.Node.Tag.Seleccionada = e.Node.Checked
    'End Sub



    'Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    '    Me.Close()
    'End Sub


    'Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim mPermisoRaiz As New PermisoCompuestoBLL(0)
    '    mPermisoRaiz.MostrarEnTreeview(Me.treePatentes)
    'End Sub
End Class