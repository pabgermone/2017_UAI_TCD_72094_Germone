Imports BE

''' <summary>
''' Clase encargada del manejo de la tabla intermedia entre Rol y PermisoCompuesto
''' </summary>
Public Class RolPermisoCompuestoDAL

    ''' <summary>
    ''' Crea una relacion entre una entidad Rol y una entidad Permiso
    ''' </summary>
    ''' <param name="pRolID"></param>
    ''' <param name="pPermisoID"></param>
    Public Shared Sub GuardarNuevo(pRolID As Integer, pPermisoID As Integer)
        Dim mCommand As String = "INSERT INTO RolPermisoCompuesto(RolPermisoCompuesto_rol, RolPermisoCompuesto_permiso) VALUES " &
                                 "(" & pRolID & ", " & pPermisoID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - RolPermisoCompuestoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Rol y el Permiso indicado
    ''' </summary>
    ''' <param name="pPermisoID"></param>
    Public Shared Sub EliminarPorPermiso(pPermisoID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermisoCompuesto WHERE RolPermisoCompuesto_permiso = " & pPermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Permiso - RolPermisoCompuestoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Permiso y el Rol indicado
    ''' </summary>
    ''' <param name="pRolID"></param>
    Public Shared Sub EliminarPorRol(pRolID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermisoCompuesto WHERE RolPermisoCompuesto_rol = " & pRolID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Rol - RolPermisoCompuestoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina una relacion entre un Rol y un Permiso
    ''' </summary>
    ''' <param name="pRolID"></param>
    ''' <param name="pPermisoID"></param>
    Public Shared Sub Eliminar(pRolID As Integer, pPermisoID As Integer)
        Dim mCommand As String = "DELETE FROM RolPermisoCompuesto WHERE RolPermisoCompuesto_rol = " & pRolID & "AND RolPermisoCompuesto_permiso = " & pPermisoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Permiso de Rol - RolPermisoCompuestoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

