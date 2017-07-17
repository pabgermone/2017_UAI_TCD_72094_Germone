Imports BLL
Imports Framework

Public Class FormClientes
    Implements IObservador

    Dim mClienteSelec As ClienteBLL
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


#Region "Eventos Form"
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
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
    <Obsolete("Falta hacer compatible con el MultiIdioma")>
    Public Sub ActualizarLabels()
        If Not IsNothing(mClienteSelec) Then
            LblNomAp.Text = "Nombre y Apellido: " & mClienteSelec.ToString
            LblDNI.Text = "DNI: " & mClienteSelec.DNI
            LblPasaporte.Text = "Pasaporte: " & mClienteSelec.Pasaporte
            LblFechaNac.Text = "Fecha de Nacimiento: " & mClienteSelec.FechaNac
            LblTel.Text = "Telefono: " & mClienteSelec.Telefono
            LblSexo.Text = "Sexo: " & mClienteSelec.Sexo
        Else
            LblNomAp.Text = "Nombre y Apellido: "
            LblDNI.Text = "DNI: "
            LblPasaporte.Text = "Pasaporte: "
            LblFechaNac.Text = "Fecha de Nacimiento: "
            LblTel.Text = "Telefono: "
            LblSexo.Text = "Sexo: "
        End If
    End Sub
End Class