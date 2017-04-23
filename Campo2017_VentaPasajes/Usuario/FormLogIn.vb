Imports BLL

Public Class FormLogIn

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim mUsuario As New UsuarioBLL(txtUsername.Text)

        If mUsuario.ID <> 0 Then
            'Hacer que la contraseña ingresada por el usuario pase por la encripatacion antes de comparar
            If mUsuario.Password = txtPass.Text Then
                'Pasar a pantalla principal.. mostrar pantalla con menu de opciones dinamico
                MsgBox("Ingreso")
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