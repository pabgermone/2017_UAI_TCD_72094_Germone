Imports BLL
Imports Framework

Public Class FormRoles
    Implements IObservador

    Dim mRolSelec As RolBLL
    Dim mTraductor As Traductor = Traductor.GetInstance


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub


    ''' <summary>
    ''' Carga en pControl.Tag el texto que tiene pControl al momento de instanciar el Form
    ''' </summary>
    ''' <param name="pControl"></param>
    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub

#End Region


#Region "Eventos Form"

    Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarRoles()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
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

        If mRol.Nombre <> "" Then
            mRol.Guardar()

            ActualizarRoles()
        Else
            MsgBox("El nuevo rol debe tener un nombre")
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Esta seguro que desea eliminar el rol seleccinado", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Not IsNothing(mRolSelec) Then
                mRolSelec.Eliminar()
            Else
                MsgBox("Debe seleccionar un rol")
            End If
        End If

        ActualizarRoles()
    End Sub


    Private Sub BtnRenombrar_Click(sender As Object, e As EventArgs) Handles BtnRenombrar.Click
        If Not IsNothing(mRolSelec) Then
            mRolSelec.Nombre = InputBox("Ingrese el nuevo nombre para el rol:")

            If mRolSelec.Nombre <> "" Then
                mRolSelec.Guardar()

                ActualizarRoles()
            Else
                MsgBox("Debe ingresar un nuevo nombre para el rol")
            End If
        Else
            MsgBox("Debe seleccionar un rol")
        End If
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If MsgBox("Esta seguro que desea guardar los cambios realizados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim mListaPermisos As New List(Of PermisoAbstractoBLL)

            For Each mNodo As TreeNode In TreePermisos.Nodes
                'Llena la lista con los permisos que hay seleccionados en el treeview
                CargarPermisosSelec(mNodo, mListaPermisos)
            Next

            mRolSelec.ListaPermisos = mListaPermisos

            mRolSelec.Guardar()

            ActualizarRoles()
        End If
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

    Private Sub TreePermisos_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreePermisos.AfterCheck

    End Sub
End Class