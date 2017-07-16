Imports BLL
Imports Framework

Public Class FormUsuarios
    Implements IObservador

    Public mUsuarioSelec As UsuarioBLL
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
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarUsuarios()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub ComboUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboUsuarios.SelectedValueChanged
        If Not IsNothing(ComboUsuarios.SelectedItem) And TypeOf (ComboUsuarios.SelectedItem) Is UsuarioBLL Then
            mUsuarioSelec = ComboUsuarios.SelectedItem

            ActualizarLabels()
        End If
    End Sub


    Private Sub LinkRol_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRol.LinkClicked
        If Not IsNothing(mUsuarioSelec) Then
            Dim mForm As New FormVerPermisos(mUsuarioSelec)
            mForm.ShowDialog()
        End If
    End Sub
#End Region


#Region "Botones"
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim mForm As New FormRegistro
        mForm.ShowDialog()

        ActualizarUsuarios()
    End Sub


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If Not IsNothing(mUsuarioSelec) Then
            Dim mForm As New ModificarUsuario(mUsuarioSelec)
            mForm.ShowDialog()

            ActualizarLabels()
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not IsNothing(mUsuarioSelec) Then
            If MsgBox("Esta seguro que desea eliminar al usuario " & mUsuarioSelec.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mUsuarioSelec.Eliminar()

                ActualizarUsuarios()
            End If
        Else
            MsgBox("Debe seleccionar un usuario")
        End If


    End Sub
#End Region

    Public Sub ActualizarUsuarios()
        ComboUsuarios.DataSource = Nothing
        ComboUsuarios.DataSource = UsuarioBLL.ListarUsuarios
    End Sub

    Public Sub ActualizarLabels()
        If Not IsNothing(mUsuarioSelec) Then
            Dim mRol As New RolBLL(mUsuarioSelec.Rol)

            LblUserName.Text = "Nombre de Usuario: " & mUsuarioSelec.UserName
            LblRol.Text = "Rol del Usuario: " & mRol.Nombre
        End If
    End Sub


End Class