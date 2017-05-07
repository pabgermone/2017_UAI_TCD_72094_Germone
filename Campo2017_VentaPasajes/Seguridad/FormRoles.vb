Imports BLL

Public Class FormRoles
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim mRol As New RolBLL
        Dim mListaPermisos As New List(Of PermisoAbstractoBLL)

        mRol.Nombre = txtNombre.Text
        GetPermisosSeleccionados(treePatentes.Nodes, mListaPermisos)
        mRol.ListaPermisos = mListaPermisos
        mRol.Guardar()

        Me.Close()
    End Sub


    Public Sub GetPermisosSeleccionados(pNodos As TreeNodeCollection, pListaPermisos As List(Of PermisoAbstractoBLL))
        For Each mNode As TreeNode In pNodos
            If mNode.Checked Then
                pListaPermisos.Add(CType(mNode.Tag, PermisoAbstractoBLL))
            End If

            GetPermisosSeleccionados(mNode.Nodes, pListaPermisos)
        Next
    End Sub


    Private Sub treePatentes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterCheck
        e.Node.Tag.Seleccionada = e.Node.Checked
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoRaiz As New PermisoCompuestoBLL(0)
        mPermisoRaiz.MostrarEnTreeview(Me.treePatentes)
    End Sub
End Class