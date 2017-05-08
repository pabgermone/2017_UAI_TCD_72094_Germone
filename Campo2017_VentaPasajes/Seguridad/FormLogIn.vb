Imports BLL

Public Class FormLogIn

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim mUsuario As New UsuarioBLL(txtUsername.Text)
        Dim mEncriptador As Encriptador = Encriptador.GetInstance

        If mUsuario.ID <> 0 Then
            If mEncriptador.ValidarHash(txtPass.Text, mUsuario.Password) Then
                Dim mForm As New FormPrincipal(mUsuario)
                mForm.ShowDialog()
            Else
                Label3.Visible = True
            End If
        Else
            Label3.Visible = True
        End If
    End Sub


    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim mForm As New FormRegistro
        mForm.ShowDialog()
    End Sub
End Class