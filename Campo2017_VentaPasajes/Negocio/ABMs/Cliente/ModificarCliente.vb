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
            TxtFechaNac.Text = pCliente.FechaNac
            TxtTel.Text = pCliente.Telefono
            TxtSexo.Text = pCliente.Sexo
            TxtEstado.Text = pCliente.EstadoCivil
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
        Dim NomAp As String() = Split(TxtNomAp.Text)

        mCliente.Nombre = NomAp(0)
        mCliente.Apellido = NomAp(1)
        mCliente.DNI = TxtDNI.Text
        mCliente.Pasaporte = TxtPasaporte.Text
        mCliente.FechaNac = TxtFechaNac.Text
        mCliente.Telefono = TxtTel.Text
        mCliente.Sexo = TxtSexo.Text
        mCliente.EstadoCivil = TxtEstado.Text

        mCliente.Guardar()

        MsgBox("Se guardaron las modificaciones")

        Me.Close()
    End Sub


    Private Sub LinkEliminar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEliminar.LinkClicked
        mCliente.Eliminar()
        Me.Close()
    End Sub


    Private Sub ModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub

End Class