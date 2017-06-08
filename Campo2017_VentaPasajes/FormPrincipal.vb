Imports System.ComponentModel
Imports BLL

Public Class FormPrincipal
    Public Property UsuarioActivo As UsuarioBLL

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.UsuarioActivo = pUsuario
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoComp As New PermisoCompuestoBLL
        mPermisoComp.MostrarEnMenuStrip(MenuStrip1, Me.UsuarioActivo, Me)
    End Sub

    'Muestra un mensaje antes de cerrar la ventana para que el usuario confirme que quiere cerrar sesion
    Private Sub FormPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Esta seguro que desea salir. Al salir del programa se cerrará la sesión", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            e.Cancel = True
        End If
    End Sub
End Class