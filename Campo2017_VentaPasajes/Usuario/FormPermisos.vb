Imports BLL

Public Class FormPermisos

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Modelo.GetInstance().PermisoRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub

    Private Sub AgregarPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPermisoToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is PermisoCompuestoBLL Then

            Dim padre As PermisoCompuestoBLL = nodo.Tag

            Dim frm As New FormAgregarPatente
            frm.ShowDialog()

            Dim nombre As String = frm.Nombre
            Dim formulario As String = frm.Formulario

            If (nombre.Length > 0) And (formulario.Length > 0) Then

                Dim patente As New PermisoBLL
                Dim nodoNuevo As New TreeNode

                nodoNuevo.Text = nombre
                patente.Nombre = nombre
                'patente.Formulario = formulario
                nodoNuevo.Tag = patente

                nodo.Nodes.Add(nodoNuevo)
                padre.ListaPatentes.Add(patente)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class