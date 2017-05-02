Imports BLL

Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p1 As New PermisoBLL
        Dim p2 As New PermisoBLL
        Dim p3 As New PermisoBLL
        Dim p4 As New RolBLL


        p1.Nombre = "p1"
        p2.Nombre = "p1"
        p3.Nombre = "p3"
        p4.Nombre = "p1p2"

        Modelo.GetInstance.ListaRoles.Add(p4)
    End Sub

    Private Sub btnDefinirPatentes_Click(sender As Object, e As EventArgs) Handles btnDefinirPatentes.Click
        Dim mForm As New FormPermisos
        mForm.ShowDialog()
    End Sub

    Private Sub btnDefinirFamilias_Click(sender As Object, e As EventArgs) Handles btnDefinirFamilias.Click
        Dim mForm As New FormRoles
        mForm.ShowDialog()
    End Sub

    Private Sub btnDefinirUsuarios_Click(sender As Object, e As EventArgs) Handles btnDefinirUsuarios.Click
        Dim mForm As New FormAsignacion
        mForm.ShowDialog()
    End Sub
End Class