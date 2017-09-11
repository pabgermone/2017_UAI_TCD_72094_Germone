Imports DAL

''' <summary>
''' Clase Singleton
''' </summary>
Public Class ControladorBackup

    ''' <summary>
    ''' Genera un Backup de la BD
    ''' </summary>
    ''' <param name="pNombre">Nombre del archivo a crear</param>
    ''' <param name="pDireccion">Direccion en donde sera creado el archivo</param>
    Public Shared Sub CrearBackup(pNombre As String, pDireccion As String)
        Dim mCommand As String = "backup database [Diploma2017_VentaPasajes] to disk = '" & pDireccion & "\" & pNombre & ".bak' with noFormat, noInit, name = 'Backup_VentaPasajes', skip, noRewind, noUnload, stats = 10;"

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
        Dim mCommand As String = "restore database [Diploma2017_VentaPasajes] from disk = '" & pDireccion & "';"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Restaurar BD")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
