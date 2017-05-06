Imports BLL
Imports BE

Public Class FormPermisos
    'Public Property PermisoCompuesto As PermisoCompuestoBLL

    Private Sub AgregarPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPermisoToolStripMenuItem.Click
        Dim mSelectedNode As TreeNode = Me.treePatentes.SelectedNode

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

    Private Sub FormPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoRaiz As New PermisoCompuestoBLL(0)
        mPermisoRaiz.MostrarEnTreeview(treePatentes)
    End Sub

    Private Sub AgregarPermisoCompuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPermisoCompuestoToolStripMenuItem.Click
        Dim mSelectedNode As TreeNode = treePatentes.SelectedNode

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
                treePatentes.Nodes.Clear()

                FormPermisos_Load(Nothing, Nothing)
                treePatentes.ExpandAll()
            End If
        End If
    End Sub
End Class