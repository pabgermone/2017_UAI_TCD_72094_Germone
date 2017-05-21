Public Class VentaClienteDAL

    ''' <summary>
    ''' Crea una relacion entre una entidad Venta y una entidad Cliente
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta que contiene al Cliente</param>
    ''' <param name="pClienteID">ID del Cliente contenido</param>
    Public Shared Sub GuardarNuevo(pVentaID As Integer, pClienteID As Integer)
        Dim mCommand As String = "INSERT INTO VentaCliente(VentaCliente_Venta, VentaCliente_Cliente) VALUES " &
                                 "(" & pVentaID & ", " & pClienteID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VentaClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Venta y el Cliente indicado
    ''' </summary>
    ''' <param name="pClienteID">ID del Venta del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorCliente(pClienteID As Integer)
        Dim mCommand As String = "DELETE FROM VentaCliente WHERE VentaCliente_Cliente = " & pClienteID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Cliente - VentaClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Cliente y el Venta indicado
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorVenta(pVentaID As Integer)
        Dim mCommand As String = "DELETE FROM VentaCliente WHERE VentaCliente_Venta = " & pVentaID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Venta - VentaClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina una relacion entre un Venta y un Cliente
    ''' </summary>
    ''' <param name="pVentaID">ID del Venta del que se quieren eliminar relaciones</param>
    ''' <param name="pClienteID">ID del Cliente del que se quiere eliminar relaciones</param>
    Public Shared Sub Eliminar(pVentaID As Integer, pClienteID As Integer)
        Dim mCommand As String = "DELETE FROM VentaCliente WHERE VentaCliente_Venta = " & pVentaID & "AND VentaCliente_Cliente = " & pClienteID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Cliente de Venta - VentaClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
