Imports BLL
Imports BE

Public Class FormAsignacion
    Private Sub FormularioUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboRoles.DataSource = RolBLL.ListarRoles
        ComboUsuarios.DataSource = UsuarioBLL.ListarUsuarios
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim mUsuarioSeleccionado As UsuarioBLL = ComboUsuarios.SelectedItem
        Dim mRolSeleccionado As RolBLL = ComboRoles.SelectedItem

        mUsuarioSeleccionado.Rol = mRolSeleccionado.ID

        mUsuarioSeleccionado.Guardar()

        Me.Close()
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class