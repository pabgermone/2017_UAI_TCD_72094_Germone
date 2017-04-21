Imports BLL

Public Class CargaPasajeros
    Private Shared mID As Integer

    Private Sub Guardar(mPasajero As PasajeroBLL)
        mPasajero.Nombre = TextBox1.Text
        mPasajero.Apellido = TextBox2.Text
        mPasajero.DNI = TextBox3.Text
        mPasajero.Pasaporte = TextBox4.Text
        mPasajero.FechaNac = TextBox5.Text
        mPasajero.Telefono = TextBox6.Text
        mPasajero.Sexo = TextBox7.Text
        mPasajero.EstadoCivil = TextBox8.Text

        mPasajero.Guardar()
    End Sub

    Private Sub Guardar(mPasajero As PasajeroBLL, pID As Integer)
        mPasajero.ID = mID
        mPasajero.Nombre = TextBox1.Text
        mPasajero.Apellido = TextBox2.Text
        mPasajero.DNI = TextBox3.Text
        mPasajero.Pasaporte = TextBox4.Text
        mPasajero.FechaNac = TextBox5.Text
        mPasajero.Telefono = TextBox6.Text
        mPasajero.Sexo = TextBox7.Text
        mPasajero.EstadoCivil = TextBox8.Text

        mPasajero.Guardar()
    End Sub


    Private Sub CargarDatos()
        mID = InputBox("ID Pasajero:")

        Dim mPasajero As New PasajeroBLL(mID)

        TextBox1.Text = mPasajero.Nombre
        TextBox2.Text = mPasajero.Apellido
        TextBox3.Text = mPasajero.DNI
        TextBox4.Text = mPasajero.Pasaporte
        TextBox5.Text = mPasajero.FechaNac
        TextBox6.Text = mPasajero.Telefono
        TextBox7.Text = mPasajero.Sexo
        TextBox8.Text = mPasajero.EstadoCivil
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mPasajero As New PasajeroBLL

        Guardar(mPasajero)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guardar(New PasajeroBLL, mID)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CargarDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mPasajero As New PasajeroBLL(InputBox("ID Pasajero"))
        mPasajero.Eliminar()
    End Sub
End Class