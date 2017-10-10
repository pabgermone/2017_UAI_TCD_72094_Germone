Imports BLL
Imports Framework

Public Class FormLogIn
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mBitacora As Bitacora = Bitacora.GetInstance


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


    Private Sub FormLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CreadorBD.GetInstance.Crear()

        txtUsername.Text = "Administrador"
        txtPass.Text = "Administrador"


        If Not ControladorDVV.VerificarBD() Then
            MsgBox("Error en los datos")
        End If

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim mUsuario As New UsuarioBLL(txtUsername.Text)
        Dim mEncriptador As Encriptador = Encriptador.GetInstance

        If mUsuario.ID <> 0 Then
            If mEncriptador.ValidarHash(txtPass.Text, mUsuario.Password) Then
                txtUsername.Clear()
                txtPass.Clear()
                Label3.Visible = False

                mBitacora.GuardarRegistro(mUsuario.UserName, System.DateTime.Now.Date, "Ingreso al sistema")

                Dim mForm As New FormPrincipal(mUsuario)
                mForm.ShowDialog()
            Else
                Label3.Visible = True
            End If
        Else
            Label3.Visible = True
        End If
    End Sub
End Class