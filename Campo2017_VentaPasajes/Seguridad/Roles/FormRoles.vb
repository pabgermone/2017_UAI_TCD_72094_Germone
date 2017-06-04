Imports BLL

Public Class FormRoles
    Dim mRolSelec As RolBLL

#Region "Eventos Form"
    Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarRoles()
    End Sub


    Private Sub ListRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListRoles.SelectedValueChanged
        If Not IsNothing(ListRoles.SelectedItem) And TypeOf (ListRoles.SelectedItem) Is RolBLL Then
            mRolSelec = ListRoles.SelectedItem
            ActualizarPermisos()
        End If
    End Sub

#End Region


#Region "Botones"
    Private Sub BtnNvoRol_Click(sender As Object, e As EventArgs) Handles BtnNvoRol.Click
        Dim mRol As New RolBLL

        mRol.Nombre = InputBox("Ingrese el nombre del rol:")

        mRol.Guardar()

        ActualizarRoles()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Esta seguro que desea eliminar el rol seleccinado", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            mRolSelec.Eliminar()
        End If

        ActualizarRoles()
    End Sub


    Private Sub BtnRenombrar_Click(sender As Object, e As EventArgs) Handles BtnRenombrar.Click
        mRolSelec.Nombre = InputBox("Ingrese el nuevo nombre para el rol:")

        mRolSelec.Guardar()

        ActualizarRoles()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim mListaPermisos As New List(Of PermisoAbstractoBLL)

        For Each mNodo As TreeNode In TreePermisos.Nodes
            'Llena la lista con los permisos que hay seleccionados en el treeview
            CargarPermisosSelec(mNodo, mListaPermisos)
        Next

        mRolSelec.ListaPermisos = mListaPermisos

        mRolSelec.Guardar()

        ActualizarRoles()
    End Sub


    Private Sub BtnDeshacer_Click(sender As Object, e As EventArgs) Handles BtnDeshacer.Click
        ActualizarPermisos()
    End Sub
#End Region


    Public Sub ActualizarRoles()
        ListRoles.DataSource = Nothing
        ListRoles.DataSource = RolBLL.ListarRoles
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
    ''' Marca como seleccionado a un nodo y todos los nodos que dependan de este. Si alguno de esos nodos, tiene
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
    ''' Carga a una lista de permisos los permisos que haya seleccionados en los nodos de un nodo del treeview
    ''' </summary>
    ''' <param name="pNodo">Nodo que se quiere recorrer</param>
    ''' <param name="pLista">Lista que lleva los permisos seleccionados en el treeview</param>
    Public Sub CargarPermisosSelec(pNodo As TreeNode, pLista As List(Of PermisoAbstractoBLL))
        If TypeOf (pNodo.Tag) Is PermisoCompuestoBLL Then
            If pNodo.Checked = True Then
                pLista.Add(pNodo.Tag)
            Else
                For Each mNodo In pNodo.Nodes
                    CargarPermisosSelec(mNodo, pLista)
                Next
            End If
        ElseIf TypeOf (pNodo.Tag) Is PermisoBLL Then
            If pNodo.Checked = True Then
                pLista.Add(pNodo.Tag)
            End If
        End If
    End Sub
End Class