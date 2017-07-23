Imports BLL
Imports Framework

Public Class ModificarCliente
    Implements IObservador

    Dim mCliente As ClienteBLL
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(pCliente As ClienteBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pCliente) Then
            Me.mCliente = pCliente

            TxtNomAp.Text = pCliente.ToString
            TxtDNI.Text = pCliente.DNI
            TxtPasaporte.Text = pCliente.Pasaporte
            DateTimeFechaNac.Value = mCliente.FechaNac
            TxtTel.Text = pCliente.Telefono

            If pCliente.Sexo = "Masculino" Then
                RadioMasculino.Checked = True
            Else
                RadioFemenino.Checked = False
            End If
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


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim mValido As Boolean = True

        If TxtNomAp.Text <> "" Then
            Try
                Dim NomAp As String() = Split(TxtNomAp.Text)

                mCliente.Nombre = NomAp(0)
                mCliente.Apellido = NomAp(1)
            Catch ex As Exception
                MsgBox("El nombre y apellido ingresados no son validos")
                TxtNomAp.BackColor = Color.Red

                mValido = False
            End Try
        Else
            MsgBox("Debe ingresar Nombre y Apellido")
            TxtNomAp.BackColor = Color.Red

            mValido = False
        End If

        If TxtDNI.Text <> "" And IsNumeric(TxtDNI.Text) And TxtDNI.TextLength = 8 Then
            mCliente.DNI = TxtDNI.Text
        Else
            MsgBox("Debe ingresar un numero de DNI valido (8 caracteres)")
            TxtNomAp.BackColor = Color.Red

            mValido = False
        End If

        If TxtPasaporte.Text <> "" And IsNumeric(TxtPasaporte.Text) Then
            mCliente.Pasaporte = TxtPasaporte.Text
        Else
            MsgBox("Debe ingresar un numero de pasaporte valido")
            TxtNomAp.BackColor = Color.Red

            mValido = False
        End If

        If DateTimeFechaNac.Value.Year <= Date.Now.Year Then
            mCliente.FechaNac = DateTimeFechaNac.Value
        Else
            MsgBox("La fecha de nacimiento seleccionada no es valida")

            mValido = False
        End If

        If TxtTel.Text <> "" And IsNumeric(TxtTel.Text) Then
            mCliente.Telefono = TxtTel.Text
        Else
            MsgBox("Debe ingresar un numero de telefono valido")
            TxtNomAp.BackColor = Color.Red

            mValido = False
        End If

        If RadioMasculino.Checked Then
            mCliente.Sexo = "Masculino"
        Else
            mCliente.Sexo = "Femenino"
        End If


        If mValido Then
            If MsgBox("Esta seguro que desea guardar los cambios hechos a este cliente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mCliente.Guardar()

                MsgBox("Se guardaron las modificaciones")

                Me.Close()
            End If
        End If
    End Sub


    Private Sub LinkEliminar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEliminar.LinkClicked
        If MsgBox("Esta seguro que desea eliminar todos los datos del cliente seleccionado?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            mCliente.Eliminar()
            Me.Close()
        End If
    End Sub


    Private Sub ModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub

End Class