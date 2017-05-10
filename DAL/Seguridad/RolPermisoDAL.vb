Imports BE

''' <summary>
''' Clase encargada del manejo de la tabla intermedia entre Rol y Permiso
''' </summary>
Public Class RolPermisoDAL

    ''' <summary>
    ''' Crea una relacion entre una entidad Rol y una entidad Permiso
    ''' </summary>
    ''' <param name="pRolID">ID del rol que contiene al permiso</param>
    ''' <param name="pPermisoID">ID del permiso contenido por el rol</param>
    Public Shared Sub GuardarNuevo(pRolID As Integer, pPermisoID As Integer)
        Dim mCommand As String = "INSERT INTO RolPermiso(RolPermiso_rol, RolPermiso_permiso) VALUES " &
                                 "(" & pRolID & ", " & pPermisoID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Rol y el Permiso indicado
    ''' </summary>
    ''' <param name="pPermisoID">ID del permiso del que se quiere eliminar relaciones</param>
    Public Shared Sub EliminarPorPermiso(pPermisoID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_permiso = " & pPermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Permiso - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Permiso y el Rol indicado
    ''' </summary>
    ''' <param name="pRolID">ID del permiso del que se quieren eliminar relaciones</param>
    Public Shared Sub EliminarPorRol(pRolID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_rol = " & pRolID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Rol - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina una relacion entre un Rol y un Permiso
    ''' </summary>
    ''' <param name="pRolID">ID del rol del que se quiere eliminar relaciones</param>
    ''' <param name="pPermisoID">ID del permiso del que se quiere elimnar relaciones</param>
    Public Shared Sub Eliminar(pRolID As Integer, pPermisoID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_rol = " & pRolID & "AND RolPermiso_permiso = " & pPermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Permiso de Rol - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
