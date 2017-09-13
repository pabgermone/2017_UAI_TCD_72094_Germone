Imports DAL

''' <summary>
''' Clase Singleton
''' </summary>
Public Class ControladorBackup

    ''' <summary>
    ''' Genera un Backup de la BD
    ''' </summary>
    ''' <param name="pNombre">Nombre del archivo a crear</param>
    Public Shared Sub CrearBackup(pNombre As String)
        If (Not System.IO.Directory.Exists("C:\VentaPasajes")) Then
            System.IO.Directory.CreateDirectory("C:\VentaPasajes")
        End If

        Dim mCommand As String = "backup database [Diploma2017_VentaPasajes] to disk = 'C:\VentaPasajes\BackupVentaPasajes.bak' with noFormat, noInit, name = 'Backup_VentaPasajes', skip, noRewind, noUnload, stats = 10;"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Crear Backup")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Restaura la BD usando un archivo .bak
    ''' </summary>
    ''' <param name="pDireccion">Direccion en la que esta el archivo .bak necesario para la restauracion</param>
    Public Shared Sub RestaurarBD(pDireccion As String)
        Dim mDataSources As DataTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources

        Dim mConnection As String = "Data Source=" & mDataSources.Rows(0).Item(0) & "\" & mDataSources.Rows(0).Item(1) & ";Initial Catalog=master;Integrated Security=true"
        Dim mCommand As String = "restore database [Diploma2017_VentaPasajes] from disk = '" & pDireccion & "';"

        Try
            BD.ExecuteNonQuery(mCommand, mConnection)
        Catch ex As Exception
            MsgBox("Error - Restaurar BD")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
