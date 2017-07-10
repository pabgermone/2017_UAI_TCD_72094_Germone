Imports BLL
Imports Framework

''' <summary>
''' Clase Observador
''' </summary>
Public Class FormIdiomas
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mIdiomaSelec As IdiomaBLL = Nothing


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


    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    ''' <summary>
    ''' Cambia el todos los mensajes de los controles por los mensajes que haya en Traductor.GetInstance().IdiomaSeleccionado.Diccionario
    ''' </summary>
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

    Private Sub FormIdiomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridTextos.ColumnCount = 2
        GridTextos.Columns(0).Name = "Key"
        GridTextos.Columns(0).Visible = False
        GridTextos.Columns(1).Name = "Texto"

        mTraductor.RegistrarObservador(Me)

        ActualizarCombo()
        ComboIdiomas.SelectedIndex = 0

        ActualizarGrid()

        Actualizar(Me)
    End Sub


    Private Sub ComboIdiomas_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboIdiomas.SelectedValueChanged
        If Not IsNothing(ComboIdiomas.SelectedItem) Then
            If TypeOf ComboIdiomas.SelectedItem Is IdiomaBLL Then
                mIdiomaSelec = ComboIdiomas.SelectedItem
                ActualizarGrid()
            End If
        End If
    End Sub


    Private Sub GridTextos_SelectionChanged(sender As Object, e As EventArgs) Handles GridTextos.SelectionChanged
        If GridTextos.SelectedRows.Count > 0 Then
            If GridTextos.SelectedRows(0).Cells(0).Value <> "" Then
                TxtPalabraSelec.Text = GridTextos.SelectedRows(0).Cells(1).Value
                TxtTraduccion.Text = GridTextos.SelectedRows(0).Cells(1).Value
            End If
        End If
    End Sub

#End Region


#Region "Botones"

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        If GridTextos.SelectedRows.Count > 0 Then
            If GridTextos.SelectedRows(0).Cells(0).Value <> "" Then
                GridTextos.SelectedRows(0).Cells(1).Value = TxtTraduccion.Text
                TxtPalabraSelec.Text = GridTextos.SelectedRows(0).Cells(1).Value
            End If
        End If
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Not IsNothing(mIdiomaSelec) Then
            For i = 0 To (GridTextos.RowCount - 2)
                mIdiomaSelec.Diccionario.Item(GridTextos.Rows.Item(i).Cells(0).Value) = GridTextos.Rows.Item(i).Cells(1).Value
            Next

            mIdiomaSelec.GuardarTraducciones()
        End If
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim mIdioma As New IdiomaBLL

        mIdioma.Nombre = InputBox("Ingrese el nombre del nuevo idioma")

        mIdioma.Guardar()

        ActualizarCombo()
        ActualizarGrid()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not IsNothing(mIdiomaSelec) Then
            If MsgBox("Esta seguro que desea borrar este idioma del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mIdiomaSelec.Eliminar()
            End If

            ActualizarCombo()
            ActualizarGrid()
        End If
    End Sub

#End Region


    ''' <summary>
    ''' Carga en ComboIdiomas todos los idiomas que haya guardados en BD
    ''' </summary>
    Public Sub ActualizarCombo()
        ComboIdiomas.Items.Clear()

        For Each mIdioma As IdiomaBLL In IdiomaBLL.ListarIdiomas
            ComboIdiomas.Items.Add(mIdioma)
        Next
    End Sub


    ''' <summary>
    ''' Carga en GridTextos todas las traducciones que haya en mIdiomaSelec.Diccionario
    ''' </summary>
    Public Sub ActualizarGrid()
        GridTextos.Rows.Clear()

        If Not IsNothing(mIdiomaSelec) Then
            For Each mTexto As KeyValuePair(Of String, String) In mIdiomaSelec.Diccionario
                GridTextos.Rows.Add(mTexto.Key, mTexto.Value)
            Next
        End If
    End Sub

End Class