Imports BLL
Imports BE

Public Class FormPermisos
    Public Property PermisoCompuesto As PermisoCompuestoBLL

    'Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    Modelo.GetInstance().PermisoRaiz.MostrarEnTreeview(Me.treePatentes)
    'End Sub

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

    Private Sub FormPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoRaiz As New PermisoCompuestoBLL(0)
        mPermisoRaiz.MostrarEnTreeview(treePatentes)
    End Sub

    Private Sub AgregarPermisoCompuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPermisoCompuestoToolStripMenuItem.Click
        Dim vSNode As TreeNode = treePatentes.SelectedNode
        If TypeOf vSNode.Tag Is PermisoCompuestoBLL Then
            Dim vPadre As PermisoCompuestoBLL = vSNode.Tag
            Dim vNombre As String = InputBox("Ingrese el nombre del Grupo: ")
            If vNombre.Length > 0 Then
                Dim vNNode As New TreeNode
                vNNode.Text = vNombre
                PermisoCompuesto.Nombre = vNombre
                vNNode.Tag = PermisoCompuesto
                vSNode.Nodes.Add(vNNode)
                vPadre.ListaPermisos.Add(PermisoCompuesto)
                PermisoCompuesto.Padre = vPadre.ID
                PermisoCompuesto.Guardar()
                treePatentes.Nodes.Clear()
                FormPermisos_Load(Nothing, Nothing)
                treePatentes.ExpandAll()
            End If
        End If
    End Sub
End Class