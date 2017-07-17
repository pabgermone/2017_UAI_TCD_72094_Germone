Imports BLL
Imports Framework

Public Class ModificarUsuario
    Implements IObservador

    Dim mUsuario As UsuarioBLL
    Dim mRol As RolBLL
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pUsuario) Then
            mUsuario = pUsuario

            mRol = New RolBLL(mUsuario.Rol)
        End If

        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub


    ''' <summary>
    ''' Carga en pControl.Tag el texto que tiene pControl al momento de instanciar el Form
    ''' </summary>
    ''' <param name="pControl"></param>
    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub

#End Region


    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUserName.Text = mUsuario.UserName
        TxtNombre.Text = mUsuario.Nombre
        TxtApellido.Text = mUsuario.Apellido

        If Not IsNothing(mRol) Then
            LblRol.Text = "Rol: " & mRol.Nombre
        Else
            LblRol.Text = "Rol: No asignado"
        End If

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim mValido As Boolean = True

        If TxtUserName.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]+$", TxtUserName.Text) Then
            mUsuario.UserName = TxtUserName.Text
        Else
            MsgBox("El nombre de usuario ingresado no es valido")
            TxtUserName.BackColor = Color.Red

            mValido = False
        End If

        If TxtNombre.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]+$", TxtNombre.Text) Then
            mUsuario.Nombre = TxtNombre.Text
        Else
            MsgBox("El nombre ingresado no es valido")
            TxtNombre.BackColor = Color.Red

            mValido = False
        End If

        If TxtNombre.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]+$", TxtNombre.Text) Then
            mUsuario.Apellido = TxtApellido.Text
        Else
            MsgBox("El apellido ingresado no es valido")
            TxtApellido.BackColor = Color.Red

            mValido = False
        End If


        If mValido Then
            mUsuario.Guardar()

            Me.Close()
        End If
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