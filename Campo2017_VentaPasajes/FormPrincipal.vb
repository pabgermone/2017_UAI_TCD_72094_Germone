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
End Class