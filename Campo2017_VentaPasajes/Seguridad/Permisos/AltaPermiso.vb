Imports System.Reflection
Imports Framework

Public Class AltaPermiso
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance

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


    Private Sub AltaPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNombre.Text <> "" And cmbFormularios.Text <> "" Then
            Me.Close()
        Else
            MsgBox("El nuevo permiso debe tener un nombre y estar asociado a un formulario")
        End If
    End Sub

End Class