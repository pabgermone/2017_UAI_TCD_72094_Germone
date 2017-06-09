Imports BLL

Public Class ModificarUsuario
    Dim mUsuario As UsuarioBLL
    Dim mRol As RolBLL

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pUsuario) Then
            mUsuario = pUsuario

            mRol = New RolBLL(mUsuario.Rol)
        End If
    End Sub

    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUserName.Text = mUsuario.UserName
        TxtNombre.Text = mUsuario.Nombre
        TxtApellido.Text = mUsuario.Apellido

        If Not IsNothing(mRol) Then
            LblRol.Text = "Rol: " & mRol.Nombre
        Else
            LblRol.Text = "Rol: No asignado"
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        mUsuario.UserName = TxtUserName.Text
        mUsuario.Nombre = TxtNombre.Text
        mUsuario.Apellido = TxtApellido.Text

        mUsuario.Guardar()

        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub LinkRol_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRol.LinkClicked
        Dim mForm As New FormCambioRolUsuario(mUsuario)
        mForm.ShowDialog()

        mRol = New RolBLL(mUsuario.Rol)

        If Not IsNothing(mRol) Then
            LblRol.Text = "Rol: " & mRol.Nombre
        Else
            LblRol.Text = "Rol: No asignado"
        End If
    End Sub
End Class