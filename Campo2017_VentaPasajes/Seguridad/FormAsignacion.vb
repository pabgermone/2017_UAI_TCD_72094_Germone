Imports BLL
Imports BE

Public Class FormAsignacion
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usu As New UsuarioBLL With {.Nombre = textBox1.Text, .Rol = CType(comboBox1.SelectedItem, RolBE)}
        Modelo.GetInstance.Usuarios.Add(usu)
        Me.Close()
    End Sub

    Private Sub FormularioUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBox1.DataSource = Modelo.GetInstance().Roles
    End Sub
End Class