﻿Imports BLL

Public Class FormRegistro
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim mUsuario As New UsuarioBLL

        mUsuario.Nombre = txtNombre.Text
        mUsuario.Apellido = txtApellido.Text
        mUsuario.UserName = txtUser.Text
        If txtPass.Text = txtVerif.Text Then
            mUsuario.Password = txtPass.Text
        Else
            Label6.Visible = True
        End If

        mUsuario.Guardar()

        MsgBox("Usuario registrado")
        Me.Close()
    End Sub
End Class