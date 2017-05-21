Imports BLL

Public Class AltaCliente
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mCliente As New ClienteBLL

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

        Me.Close()
    End Sub
End Class