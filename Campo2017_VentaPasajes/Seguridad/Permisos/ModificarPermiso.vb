Imports BLL
Imports System.Reflection
Imports Framework

Public Class ModificarPermiso
    Implements IObservador

    Dim mPermiso As PermisoBLL
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(pPermiso As PermisoBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mPermiso = pPermiso
    End Sub


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


    Private Sub ModificarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)

                If t.FullName = mPermiso.Formulario Then
                    cmbFormularios.SelectedItem = t.FullName
                End If
            End If
        Next

        txtNombre.Text = mPermiso.Nombre

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mValido As Boolean = True

        If txtNombre.Text <> "" Then
            mPermiso.Nombre = txtNombre.Text
        Else
            MsgBox("El permiso debe tener un nombre")
        End If

        mPermiso.Formulario = cmbFormularios.SelectedItem

        If mValido Then
            If MsgBox("Esta seguro que desea guardar los cambios realizados al permiso?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mPermiso.Guardar()

                Me.Close()
            End If
        End If
    End Sub
End Class