Imports System.Data.SqlClient
Imports BE

Public Class TablaIntermedia
    Public Shared Sub GuardarNuevo(pCatMov As CategoriasMovimientoDTO)
        Dim mCommand As String = "INSERT INTO MovCat(movcat_movimiento_id, movcat_cuenta_id, movcat_categoria_id) VALUES " &
                                 "(" & pCatMov.MovimientoID & ", " & pCatMov.CuentaID & ", " & pCatMov.CategoriaID & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - CatMovDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub EliminarPorCategoria(pCatMov As CategoriasMovimientoDTO)
        Dim mCommand As String = "DELETE FROM MovCat WHERE movcat_categoria_id = " & pCatMov.CategoriaID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar categoria - MovCatDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub EliminarPorMovimiento(pCatMov As CategoriasMovimientoDTO)
        Dim mCommand As String = "DELETE FROM MovCat WHERE movcat_movimiento_id = " & pCatMov.MovimientoID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar movimiento - MovCatDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Sub Eliminar(pCatMov As CategoriasMovimientoDTO)
        Dim mCommand As String = "DELETE FROM MovCat WHERE movcat_movimiento_id = " & pCatMov.MovimientoID & "AND movcat_categoria_id = " & pCatMov.CategoriaID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar categoria de movimiento - MovCatDAL")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
