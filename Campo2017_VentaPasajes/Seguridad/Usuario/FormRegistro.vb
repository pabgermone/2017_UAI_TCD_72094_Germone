Imports BLL
Imports Framework

Public Class FormRegistro
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim mUsuario As New UsuarioBLL
        Dim mEncriptador As Encriptador = Encriptador.GetInstance
        Dim mValido As Boolean = True

        If txtNombre.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]+$", txtNombre.Text) Then
            mUsuario.Nombre = txtNombre.Text
        Else
            MsgBox("Debe ingresar un Nombre valido")
            txtNombre.BackColor = Color.Red

            mValido = False
        End If

        If txtNombre.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z]+$", txtNombre.Text) Then
            mUsuario.Apellido = txtApellido.Text
        Else
            MsgBox("Debe ingresar un Apellido valido")
            txtNombre.BackColor = Color.Red

            mValido = False
        End If

        If txtUser.Text <> "" Then
            mUsuario.UserName = txtUser.Text
        Else
            MsgBox("Debe ingresar un nombre de usuario valido")
            txtNombre.BackColor = Color.Red

            mValido = False
        End If

        If txtPass.Text <> "" And txtVerif.Text <> "" Then
            If txtPass.Text = txtVerif.Text Then
                mUsuario.Password = mEncriptador.Encriptar(txtPass.Text)
            Else
                Label6.Visible = True
            End If
        Else
            MsgBox("Debe ingresar una contraseña")
            txtPass.BackColor = Color.Red

            mValido = False
        End If


        If mValido Then
            mUsuario.Guardar()

            MsgBox("Usuario registrado")
            Me.Close()
        End If
    End Sub


    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub

End Class