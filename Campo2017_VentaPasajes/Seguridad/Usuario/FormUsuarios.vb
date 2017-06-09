Imports BLL

Public Class FormUsuarios
    Public mUsuarioSelec As UsuarioBLL


#Region "Eventos Form"
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarUsuarios()
    End Sub


    Private Sub ComboUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboUsuarios.SelectedValueChanged
        If Not IsNothing(ComboUsuarios.SelectedItem) And TypeOf (ComboUsuarios.SelectedItem) Is UsuarioBLL Then
            mUsuarioSelec = ComboUsuarios.SelectedItem

            ActualizarLabels()
        End If
    End Sub


    Private Sub LinkRol_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRol.LinkClicked
        If Not IsNothing(mUsuarioSelec) Then
            Dim mForm As New FormVerPermisos(mUsuarioSelec)
            mForm.ShowDialog()
        End If
    End Sub
#End Region


#Region "Botones"
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim mForm As New FormRegistro
        mForm.ShowDialog()

        ActualizarUsuarios()
    End Sub


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If Not IsNothing(mUsuarioSelec) Then
            Dim mForm As New ModificarUsuario(mUsuarioSelec)
            mForm.ShowDialog()

            ActualizarLabels()
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Esta seguro que desea eliminar al usuario " & mUsuarioSelec.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            mUsuarioSelec.Eliminar()

            ActualizarUsuarios()
        End If
    End Sub
#End Region

    Public Sub ActualizarUsuarios()
        ComboUsuarios.DataSource = Nothing
        ComboUsuarios.DataSource = UsuarioBLL.ListarUsuarios
    End Sub

    Public Sub ActualizarLabels()
        If Not IsNothing(mUsuarioSelec) Then
            Dim mRol As New RolBLL(mUsuarioSelec.Rol)

            LblUserName.Text = "Nombre de Usuario: " & mUsuarioSelec.UserName
            LblRol.Text = "Rol del Usuario: " & mRol.Nombre
        End If
    End Sub


End Class