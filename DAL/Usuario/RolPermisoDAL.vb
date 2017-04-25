Imports BE

Public Class RolPermisoDAL
    Public Shared Sub GuardarNuevo(pRolPermiso As RolPermisoBE)
        Dim mCommand As String = "INSERT INTO RolPermiso(RolPermiso_rol, RolPermiso_permiso) VALUES " &
                                 "(" & pRolPermiso.RolID & ", " & pRolPermiso.PermisoID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub EliminarPorPermiso(pRolPermiso As RolPermisoBE)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_permiso = " & pRolPermiso.PermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar categoria - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub EliminarPorRol(pRolPermiso As RolPermisoBE)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_movimiento_id = " & pRolPermiso.RolID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar movimiento - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub Eliminar(pRolPermiso As RolPermisoBE)
        Dim mCommand As String = "DELETE FROM RolPermiso WHERE RolPermiso_rol = " & pRolPermiso.RolID & "AND RolPermiso_permiso = " & pRolPermiso.PermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar categoria de movimiento - RolPermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
