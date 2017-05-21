Public Class VentaVueloDAL

    ''' <summary>
    ''' Crea una relacion entre una entidad Venta y una entidad Vuelo
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta que contiene al Vuelo</param>
    ''' <param name="pVueloID">ID del Vuelo contenido</param>
    Public Shared Sub GuardarNuevo(pVentaID As Integer, pVueloID As Integer)
        Dim mCommand As String = "INSERT INTO VentaVuelo(VentaVuelo_Venta, VentaVuelo_Vuelo) VALUES " &
                                 "(" & pVentaID & ", " & pVueloID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VentaVueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Venta y el Vuelo indicado
    ''' </summary>
    ''' <param name="pVueloID">ID del Venta del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorVuelo(pVueloID As Integer)
        Dim mCommand As String = "DELETE FROM VentaVuelo WHERE VentaVuelo_Vuelo = " & pVueloID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Vuelo - VentaVueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Vuelo y el Venta indicado
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorVenta(pVentaID As Integer)
        Dim mCommand As String = "DELETE FROM VentaVuelo WHERE VentaVuelo_Venta = " & pVentaID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Venta - VentaVueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina una relacion entre un Venta y un Vuelo
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta del que se quieren eliminar relaciones</param>
    ''' <param name="pVueloID">ID del Vuelo del que se quiere eliminar relaciones</param>
    Public Shared Sub Eliminar(pVentaID As Integer, pVueloID As Integer)
        Dim mCommand As String = "DELETE FROM VentaVuelo WHERE VentaVuelo_Venta = " & pVentaID & "AND VentaVuelo_Vuelo = " & pVueloID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Vuelo de Venta - VentaVueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
