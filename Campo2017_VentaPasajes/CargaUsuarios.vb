Imports BLL

Public Class CargaUsuarios

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim mUsuario As New UsuarioBLL(txtUsername.Text)

        If mUsuario.ID <> 0 Then
            'Hacer que la contraseña ingresada por el usuario pase por la encripatacion antes de comparar
            If mUsuario.Password = txtPass.Text Then
                'Pasar a pantalla principal.. mostrar pantalla con menu de opciones dinamico
            Else
                Label3.Visible = True
            End If
        Else
            Label3.Visible = True
        End If
    End Sub

End Class