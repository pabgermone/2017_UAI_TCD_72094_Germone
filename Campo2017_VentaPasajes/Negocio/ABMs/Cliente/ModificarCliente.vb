Imports BLL

Public Class ModificarCliente
    Dim mCliente As ClienteBLL

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
    End Sub


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
End Class