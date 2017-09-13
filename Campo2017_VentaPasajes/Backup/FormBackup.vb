Imports Framework

Public Class FormBackup

    Dim mDireccion As String


    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        If System.IO.Directory.Exists("C:\VentaPasajes") Then
            OpenBackup.InitialDirectory = "C:\VentaPasajes"
        End If

        OpenBackup.ShowDialog()

        mDireccion = OpenBackup.FileName
        TxtDireccion.Text = mDireccion
    End Sub


    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        ControladorBackup.CrearBackup(TxtNombre.Text)
    End Sub


    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ControladorBackup.RestaurarBD(mDireccion)
    End Sub

End Class