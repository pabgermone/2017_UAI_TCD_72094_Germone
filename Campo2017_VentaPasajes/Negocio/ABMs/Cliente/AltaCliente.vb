﻿Imports BLL
Imports Framework

Public Class AltaCliente
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mForm As Form


    Public Sub New(Optional pForm As Form = Nothing)

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
            TxtDNI.BackColor = Color.Red

            mValido = False
        End If

        If TxtPasaporte.Text <> "" And IsNumeric(TxtPasaporte.Text) Then
            mCliente.Pasaporte = TxtPasaporte.Text
        Else
            MsgBox("Debe ingresar un numero de pasaporte valido")
            TxtPasaporte.BackColor = Color.Red

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
            TxtTel.BackColor = Color.Red

            mValido = False
        End If

        If RadioMasculino.Checked Then
            mCliente.Sexo = "Masculino"
        Else
            mCliente.Sexo = "Femenino"
        End If


        If mValido Then
            mCliente.Guardar()

            If Not IsNothing(mForm) Then
                CType(mForm, FormVentas).ActualizarComboClientes()
            End If

            Me.Close()
        End If
    End Sub


    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub

End Class