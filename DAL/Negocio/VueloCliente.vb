Public Class VueloCliente

    ''' <summary>
    ''' Crea una relacion entre una entidad Vuelo y una entidad Cliente
    ''' </summary>
    ''' <param name="pVueloID">ID del Vuelo que contiene al Cliente</param>
    ''' <param name="pClienteID">ID del Cliente contenido</param>
    Public Shared Sub GuardarNuevo(pVueloID As Integer, pClienteID As Integer)
        Dim mCommand As String = "INSERT INTO VueloCliente(VueloCliente_Vuelo, VueloCliente_Cliente) VALUES " &
                                 "(" & pVueloID & ", " & pClienteID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VueloClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Vuelo y el Cliente indicado
    ''' </summary>
    ''' <param name="pClienteID">ID del Vuelo del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorCliente(pClienteID As Integer)
        Dim mCommand As String = "DELETE FROM VueloCliente WHERE VueloCliente_Cliente = " & pClienteID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Cliente - VueloClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todas las relaciones que haya entre algun Cliente y el Vuelo indicado
    ''' </summary>
    ''' <param name="pVueloID">ID del Vuelo del que se quieren eliminar las relaciones</param>
    Public Shared Sub EliminarPorVuelo(pVueloID As Integer)
        Dim mCommand As String = "DELETE FROM VueloCliente WHERE VueloCliente_Vuelo = " & pVueloID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Vuelo - VueloClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina una relacion entre un Vuelo y un Cliente
    ''' </summary>
    ''' <param name="pVueloID">ID del Vuelo del que se quieren eliminar relaciones</param>
    ''' <param name="pClienteID">ID del Cliente del que se quiere eliminar relaciones</param>
    Public Shared Sub Eliminar(pVueloID As Integer, pClienteID As Integer)
        Dim mCommand As String = "DELETE FROM VueloCliente WHERE VueloCliente_Vuelo = " & pVueloID & "AND VueloCliente_Cliente = " & pClienteID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar Cliente de Vuelo - VueloClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
