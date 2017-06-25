﻿Imports InterfazUsuario
Imports BLL
Imports Framework

Public Class FormIdiomas

    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vIdioma As IdiomaBLL

    Private Sub Idiomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        AgregarIdiomas()
        Me.ActualizarObservador(Me)
    End Sub

    Private Sub AgregarIdiomas()
        ComboIdiomas.Items.Clear()
        For Each Idioma As IdiomaBLL In vTraductor.GetIdiomas
            ComboIdiomas.Items.Add(Idioma)
        Next
        ComboIdiomas.Items.Add(vTraductor.Traducir("Crear idioma"))
    End Sub

    Private Sub Actualizar(pIdioma As IdiomaBLL)
        Dim vLista As New List(Of VistaDiccionario)
        For Each Item In pIdioma.Diccionario
            vLista.Add(New VistaDiccionario(Item.Key, Item.Value))
        Next
        GridDiccionario.DataSource = Nothing
        GridDiccionario.DataSource = vLista
        GridDiccionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ActualizarObservador(GridDiccionario)
    End Sub

    Private Sub GrillaDiccionario_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GridDiccionario.CellEnter
        Try
            TxtPalabraSelec.Text = GridDiccionario.SelectedRows(0).Cells(0).Value
            TxtTraduccion.Text = GridDiccionario.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements IObservador.ActualizarObservador
        For Each vControl As Control In pControl.Controls
            Try
                vControl.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vControl.Tag.ToString)
            Catch ex As Exception
            Finally
                If vControl.Controls.Count > 0 Then
                    ActualizarObservador(vControl)
                End If
                If TypeOf vControl Is DataGridView Then
                    For Each vColumna As DataGridViewColumn In DirectCast(vControl, DataGridView).Columns
                        Try
                            vColumna.HeaderText = vTraductor.IdiomaSeleccionado.Diccionario.Item(vColumna.Name)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            End Try
        Next
    End Sub

    Private Sub CambiarValorBtn_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        Try
            GridDiccionario.SelectedRows(0).Cells(1).Value = TxtTraduccion.Text
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
    '    For Each Idioma As Idioma In vIdiomaDinamico.ConsultaTodo
    '        If IdiomaCombo.SelectedItem.ToString = Idioma.Nombre Then
    '            vIdioma = Idioma
    '            Actualizar(vIdioma)
    '        End If
    '    Next
    'End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            If ComboIdiomas.SelectedItem.ToString = vTraductor.IdiomaSeleccionado.Diccionario.Item("Crear idioma") Then
                Dim vNombreIdioma As String = InputBox("Ingrese el nombre del idioma")
                If vNombreIdioma.Length > 0 Then
                    Dim mIdioma As New IdiomaBLL

                    mIdioma.Nombre = vNombreIdioma
                    mIdioma.Diccionario = CrearDiccionario()

                    mIdioma.Guardar()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function CrearDiccionario() As Dictionary(Of String, String)
        Dim vDiccionario As New Dictionary(Of String, String)
        For i = 0 To GridDiccionario.Rows.Count - 1
            vDiccionario.Add(GridDiccionario.Rows(i).Cells(0).Value, GridDiccionario.Rows(i).Cells(1).Value)
        Next
        Return vDiccionario
    End Function

    Private Sub IdiomaCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIdiomas.SelectedIndexChanged
        If ComboIdiomas.SelectedItem.ToString = vTraductor.IdiomaSeleccionado.Diccionario.Item("Crear idioma") Then
            Actualizar(vTraductor.IdiomaSeleccionado)
        Else
            Actualizar(ComboIdiomas.SelectedItem)
        End If
    End Sub

    Private Sub Idiomas_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnCambiar.PerformClick()
        End If
    End Sub
End Class