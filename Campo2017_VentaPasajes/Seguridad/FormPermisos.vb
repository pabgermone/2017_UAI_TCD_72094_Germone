Imports BLL

Public Class FormPermisos

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Modelo.GetInstance().PermisoRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub

    Private Sub AgregarPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPermisoToolStripMenuItem.Click
        Dim mNodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf mNodo.Tag Is PermisoCompuestoBLL Then

            Dim mPadre As PermisoCompuestoBLL = mNodo.Tag

            Dim mForm As New FormAgregarPatente
            mForm.ShowDialog()

            Dim mNombrePermiso As String = mForm.Nombre
            Dim mNombreFormulario As String = mForm.Formulario

            If (mNombrePermiso.Length > 0) And (mNombreFormulario.Length > 0) Then

                Dim mPermiso As New PermisoBLL
                Dim mNodoNuevo As New TreeNode

                mNodoNuevo.Text = mNombrePermiso

                mPermiso.Nombre = mForm.Nombre
                mPermiso.Formulario = mForm.Formulario

                mPermiso.Guardar()

                mNodoNuevo.Tag = mPermiso

                mNodo.Nodes.Add(mNodoNuevo)
                mPadre.ListaPermisos.Add(mPermiso)
            End If
        End If
    End Sub
End Class