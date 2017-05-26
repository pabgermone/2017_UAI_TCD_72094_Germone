Imports BLL

Public Class FormPermisos

    Private Sub FormPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mCompuesto As New PermisoCompuestoBLL(0)
        mCompuesto.MostrarEnTreeview(TreePermisos)
    End Sub


    'Controla los botones que pueden usarse dependiendo del tipo de permiso que se haya seleccionado
    Private Sub TreePermisos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreePermisos.AfterSelect
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoBLL Then
            BtnNvoPermiso.Enabled = False
            BtnNvoCompuesto.Enabled = False
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = True
        ElseIf TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            BtnNvoPermiso.Enabled = True
            BtnNvoCompuesto.Enabled = True
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = True
        Else
            BtnNvoPermiso.Enabled = False
            BtnNvoCompuesto.Enabled = False
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
        End If
    End Sub


    Private Sub BtnNvoPermiso_Click(sender As Object, e As EventArgs) Handles BtnNvoPermiso.Click
        Dim mSelectedNode As TreeNode = Me.TreePermisos.SelectedNode

        If TypeOf mSelectedNode.Tag Is PermisoCompuestoBLL Then

            Dim mPadre As PermisoCompuestoBLL = mSelectedNode.Tag

            Dim mForm As New FormAgregarPatente
            mForm.ShowDialog()

            Dim mNombrePermiso As String = mForm.Nombre
            Dim mNombreFormulario As String = mForm.Formulario

            If (mNombrePermiso.Length > 0) And (mNombreFormulario.Length > 0) Then

                Dim mPermiso As New PermisoBLL
                Dim mNodoNuevo As New TreeNode

                mNodoNuevo.Text = mNombrePermiso

                mPermiso.Nombre = mNombrePermiso
                mPermiso.Formulario = mNombreFormulario
                mPermiso.Padre = mPadre.ID

                mPermiso.Guardar()

                mNodoNuevo.Tag = mPermiso

                mSelectedNode.Nodes.Add(mNodoNuevo)
                mPadre.ListaPermisos.Add(mPermiso)
            End If
        End If
    End Sub


    Private Sub BtnNvoCompuesto_Click(sender As Object, e As EventArgs) Handles BtnNvoCompuesto.Click
        Dim mSelectedNode As TreeNode = TreePermisos.SelectedNode

        If TypeOf mSelectedNode.Tag Is PermisoCompuestoBLL Then
            Dim mPadre As PermisoCompuestoBLL = mSelectedNode.Tag
            Dim mNombrePermiso As String = InputBox("Ingrese el nombre del Permiso: ")

            If mNombrePermiso.Length > 0 Then
                Dim mPermisoCompuesto As New PermisoCompuestoBLL
                mPermisoCompuesto.Nombre = mNombrePermiso
                mPermisoCompuesto.Padre = mPadre.ID

                Dim mNodoNuevo As New TreeNode
                mNodoNuevo.Text = mNombrePermiso
                mNodoNuevo.Tag = mPermisoCompuesto

                mSelectedNode.Nodes.Add(mNodoNuevo)
                mPadre.ListaPermisos.Add(mPermisoCompuesto)

                mPermisoCompuesto.Guardar()
                TreePermisos.Nodes.Clear()

                FormPermisos_Load(Nothing, Nothing)
                TreePermisos.ExpandAll()
            End If
        End If
    End Sub


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoBLL Then
            Dim mFormulario As New ModificarPermiso(TreePermisos.SelectedNode.Tag)
            mFormulario.ShowDialog()
        ElseIf TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            Dim mPermiso As PermisoCompuestoBLL = TreePermisos.SelectedNode.Tag

            mPermiso.Nombre = InputBox("Ingrese el nuevo nombre para el permiso compuesto:")

            mPermiso.Guardar()

            TreePermisos.SelectedNode.Tag = mPermiso
            TreePermisos.Nodes.Clear()
            FormPermisos_Load(Nothing, Nothing)
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            If MsgBox("Esta seguro que quiere eliminar este permiso y todos sus componentes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CType(TreePermisos.SelectedNode.Tag, PermisoCompuestoBLL).Eliminar()
            End If
        Else
            If MsgBox("Esta seguro que desea eliminar este permiso?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CType(TreePermisos.SelectedNode.Tag, PermisoBLL).Eliminar()
            End If
        End If
    End Sub
End Class