Imports BLL
Imports Framework
Imports System.Text

Public Class AltaCliente
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mForm As Form
    Dim mClienteModif As ClienteBLL


    Public Sub New(Optional pCliente As ClienteBLL = Nothing, Optional pForm As Form = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next

        If Not IsNothing(pForm) Then
            mForm = pForm
        End If

        If Not IsNothing(pCliente) Then
            mClienteModif = pCliente
        End If
    End Sub


    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)

        If Not IsNothing(mClienteModif) Then
            TxtNombre.Text = mClienteModif.Nombre
            TxtApellido.Text = mClienteModif.Apellido
            TxtTipoDoc.Text = mClienteModif.TipoDocumento
            TxtNumDoc.Text = mClienteModif.NumeroDocumento
            TxtPasaporte.Text = mClienteModif.Pasaporte
            DateTimeFechaNac.Value = mClienteModif.FechaNac
            TxtPais.Text = mClienteModif.Pais
            TxtDireccion.Text = mClienteModif.Direccion
            TxtCodPostal.Text = mClienteModif.CodigoPostal

            For Each mTelefono As Integer In mClienteModif.Telefonos
                LstTelefonos.Items.Add(mTelefono)
            Next

            For Each mMail As String In mClienteModif.Emails
                LstMails.Items.Add(mMail)
            Next
        End If
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


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mCliente As New ClienteBLL
        Dim mValido As Boolean = True

        If Not IsNothing(mClienteModif) Then
            mCliente.ID = mClienteModif.ID
        End If

        If Not TxtNombre.Text = "" And RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z\s]*$") Then
            mCliente.Nombre = TxtNombre.Text
        Else
            TxtNombre.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtApellido.Text = "" And RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z\s]*$") Then
            mCliente.Apellido = TxtApellido.Text
        Else
            TxtApellido.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtTipoDoc.Text = "" And RegularExpressions.Regex.IsMatch(TxtTipoDoc.Text, "^[a-zA-Z\s]*^$") Then
            mCliente.TipoDocumento = TxtTipoDoc.Text
        Else
            TxtTipoDoc.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtNumDoc.Text = "" And IsNumeric(TxtNumDoc.Text) Then
            mCliente.NumeroDocumento = TxtNumDoc.Text
        Else
            TxtNumDoc.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtPasaporte.Text = "" And IsNumeric(TxtPasaporte.Text) Then
            mCliente.Pasaporte = TxtPasaporte.Text
        Else
            TxtPasaporte.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtPais.Text = "" And RegularExpressions.Regex.IsMatch(TxtPais.Text, "^[a-zA-Z\s]*^$") Then
            mCliente.Pais = TxtPais.Text
        Else
            TxtPais.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtDireccion.Text = "" And RegularExpressions.Regex.IsMatch(TxtDireccion.Text, "^[a-zA-Z\s]*^$") Then
            mCliente.Direccion = TxtDireccion.Text
        Else
            TxtDireccion.BackColor = Color.Red
            mValido = False
        End If

        If Not TxtCodPostal.Text = "" And IsNumeric(TxtCodPostal.Text) Then
            mCliente.CodigoPostal = TxtCodPostal.Text
        Else
            TxtCodPostal.BackColor = Color.Red
            mValido = False
        End If

        For Each mNumero In LstTelefonos.Items
            If IsNumeric(mNumero.ToString) Then
                mCliente.Telefonos(mCliente.Telefonos.Count) = mNumero
            End If
        Next

        For Each mMail In LstMails.Items
            If RegularExpressions.Regex.IsMatch(mMail, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
                mCliente.Emails(mCliente.Emails.Count) = mMail
            End If
        Next

        mCliente.FechaNac = DateTimeFechaNac.Value

        If mValido Then
            mCliente.Guardar()

            Me.Close()
        End If
    End Sub


    Private Sub BtnAgregarTel_Click(sender As Object, e As EventArgs) Handles BtnAgregarTel.Click
        Dim mNumero As String = InputBox("Ingrese el numero de telefono")

        If IsNumeric(mNumero) Then
            LstTelefonos.Items.Add(mNumero)
        Else
            MsgBox("Debe ingresar un numero telefonico valido")
        End If
    End Sub


    Private Sub BtnQuitarTel_Click(sender As Object, e As EventArgs) Handles BtnQuitarTel.Click
        LstTelefonos.Items.Remove(LstTelefonos.SelectedItem)
    End Sub


    Private Sub BtnAgregarMail_Click(sender As Object, e As EventArgs) Handles BtnAgregarMail.Click
        Dim mMail As String = InputBox("Ingrese la direccion de e-mail")

        If Not mMail = "" And RegularExpressions.Regex.IsMatch(mMail, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            LstMails.Items.Add(mMail)
        Else
            MsgBox("Debe ingresar una direccion de e-mail valida")
        End If
    End Sub


    Private Sub BtnQuitarMail_Click(sender As Object, e As EventArgs) Handles BtnQuitarMail.Click
        LstMails.Items.Remove(LstMails.SelectedItem)
    End Sub
End Class