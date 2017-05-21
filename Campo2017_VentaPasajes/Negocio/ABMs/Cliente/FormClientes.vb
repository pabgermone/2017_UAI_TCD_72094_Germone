Imports BLL

Public Class FormClientes
    Dim mClienteSelec As ClienteBLL

#Region "Eventos Form"
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub


    Private Sub ComboClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedValueChanged
        If Not IsNothing(ComboClientes.SelectedItem) Then
            If TypeOf (ComboClientes.SelectedItem) Is ClienteBLL Then
                mClienteSelec = ComboClientes.SelectedItem
                ActualizarLabels()
            End If
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim mForm As New ModificarCliente(mClienteSelec)
        mForm.ShowDialog()
        ActualizarLista()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mForm As New AltaCliente()
        mForm.ShowDialog()
        ActualizarLista()
    End Sub
#End Region


    ''' <summary>
    ''' Actualiza los datos mostrados en el ComboBox
    ''' </summary>
    Public Sub ActualizarLista()
        ComboClientes.DataSource = Nothing
        ComboClientes.DataSource = ClienteBLL.Listar

        ActualizarLabels()
    End Sub


    ''' <summary>
    ''' Mustra los datos del cliente seleccionado en los Labels
    ''' </summary>
    Public Sub ActualizarLabels()
        If Not IsNothing(mClienteSelec) Then
            LblNomAp.Text = "Nombre y Apellido: " & mClienteSelec.ToString
            LblDNI.Text = "DNI: " & mClienteSelec.DNI
            LblPasaporte.Text = "Pasaporte: " & mClienteSelec.Pasaporte
            LblFechaNac.Text = "Fecha de Nacimiento: " & mClienteSelec.FechaNac
            LblTel.Text = "Telefono: " & mClienteSelec.Telefono
            LblSexo.Text = "Sexo: " & mClienteSelec.Sexo
            LblEstado.Text = "Estado Civil: " & mClienteSelec.EstadoCivil
        Else
            LblNomAp.Text = "Nombre y Apellido: "
            LblDNI.Text = "DNI: "
            LblPasaporte.Text = "Pasaporte: "
            LblFechaNac.Text = "Fecha de Nacimiento: "
            LblTel.Text = "Telefono: "
            LblSexo.Text = "Sexo: "
            LblEstado.Text = "Estado Civil: "
        End If
    End Sub
End Class