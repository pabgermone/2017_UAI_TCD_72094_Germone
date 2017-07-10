Imports System.ComponentModel
Imports BLL
Imports Framework

Public Class FormPrincipal
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Public Property UsuarioActivo As UsuarioBLL

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.UsuarioActivo = pUsuario

        For Each mControl As Control In Me.Controls
            Try
                mControl.Tag = mControl.Text
            Catch ex As Exception

            End Try
        Next
    End Sub


    Public Sub CargarTagsMenu(pItem As ToolStripMenuItem)
        Dim mTag As PermisoAbstractoBLL = pItem.Tag

        mTag.Texto = pItem.Text

        If pItem.HasDropDownItems Then
            For Each mItem As ToolStripMenuItem In pItem.DropDownItems
                CargarTagsMenu(mItem)
            Next
        End If
    End Sub


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoComp As New PermisoCompuestoBLL
        mPermisoComp.MostrarEnMenuStrip(MenuStrip1, Me.UsuarioActivo, Me)

        For Each mItem As ToolStripMenuItem In MenuStrip1.Items
            CargarTagsMenu(mItem)
        Next

        ComboIdiomas.DataSource = IdiomaBLL.ListarIdiomas
        mTraductor.RegistrarObservador(Me)
    End Sub

    'Muestra un mensaje antes de cerrar la ventana para que el usuario confirme que quiere cerrar sesion
    Private Sub FormPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Esta seguro que desea salir. Al salir del programa se cerrará la sesión", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            e.Cancel = True
        End If
    End Sub

#Region "Observer"

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                If Not TypeOf mControl Is MenuStrip Then
                    mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
                Else
                    For Each mItem As ToolStripMenuItem In CType(mControl, MenuStrip).Items
                        TraducirMenuItem(mItem)
                    Next
                End If
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub


    Public Sub TraducirMenuItem(pItem As ToolStripMenuItem)
        pItem.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(pItem.Tag.Texto)

        If pItem.HasDropDownItems Then
            For Each mItem As ToolStripMenuItem In pItem.DropDownItems
                TraducirMenuItem(mItem)
            Next
        End If
    End Sub

#End Region


    Private Sub ComboIdiomas_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboIdiomas.SelectedValueChanged
        If Not IsNothing(ComboIdiomas.SelectedItem) Then
            If TypeOf ComboIdiomas.SelectedItem Is IdiomaBLL Then
                mTraductor.IdiomaSeleccionado = ComboIdiomas.SelectedItem
            End If
        End If
    End Sub

End Class