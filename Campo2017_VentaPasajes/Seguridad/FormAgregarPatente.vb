Imports System.Reflection
Imports BLL

Public Class FormAgregarPatente
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)
            End If

        Next
    End Sub

    ''' <summary>
    ''' Se encarga de guardar el nombre del nuevo permiso
    ''' </summary>
    ''' <returns>Nombre del permiso</returns>
    Public Function Nombre() As String
        Return Me.txtNombre.Text
    End Function

    ''' <summary>
    ''' Se encarga de guardar el nombre del formulario seleccionado para el nuevo permiso
    ''' </summary>
    ''' <returns>Nombre del formulario al que accede ese permiso</returns>
    Public Function Formulario() As String
        Return Me.cmbFormularios.Text
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class