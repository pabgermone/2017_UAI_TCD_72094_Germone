Imports BLL

Public Class FormRoles


    Dim family As New RolBLL

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.family.PermisoRaiz = Modelo.GetInstance().PermisoRaiz.Clone()
        Me.family.PermisoRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim gp = New PermisoCompuestoBLL

        PatentesSeleccionas(treePatentes.Nodes, gp.ListaPermisos)

        family.Nombre = Me.txtNombre.Text
        Modelo.GetInstance.ListaRoles.Add(family)
        Me.Close()
    End Sub

    Public Sub PatentesSeleccionas(Node As TreeNodeCollection, ByRef list As IList(Of PermisoAbstractoBLL))

        For Each n As System.Windows.Forms.TreeNode In Node
            PatentesSeleccionas(n.Nodes, list)

            If n.Checked Then
                list.Add(CType(n.Tag, PermisoAbstractoBLL))
            End If
        Next
    End Sub


    Private Sub treePatentes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterCheck
        e.Node.Tag.Seleccionada = e.Node.Checked
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class