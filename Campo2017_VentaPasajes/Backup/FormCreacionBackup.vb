Imports Framework

Public Class FormCreacionBackup

    Dim mDireccion As String


    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        BrowserBackup.ShowDialog()

        mDireccion = BrowserBackup.SelectedPath
        TxtDireccion.Text = mDireccion
    End Sub


    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        ControladorBackup.CrearBackup(TxtNombre.Text, mDireccion)
    End Sub

End Class