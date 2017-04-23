Imports BE
Imports System.Data.SqlClient

Public Class VentaDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Venta_id), 0) from Venta") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pVenta As VentaBE, pRow As DataRow) As VentaBE
        pVenta.ID = pRow("Venta_id")
        pVenta.Fecha = pRow("venta_fecha")
        pVenta.Precio = pRow("venta_fecha")
        pVenta.Paquete = pRow("venta_paquete")

        Return pVenta
    End Function


    'Ejecuta un query que obtiene los datos de una Venta
    Public Shared Function ObtenerVenta(pID As Integer) As VentaBE
        Dim mVenta As New VentaBE
        Dim mCommand As String = "SELECT Venta_id, Venta_fecha, venta_precio, venta_paquete FROM Venta WHERE Venta_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mVenta = CargarBE(mVenta, mDataSet.Tables(0).Rows(0))
                Return mVenta
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - VentaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Venta
    Public Shared Sub GuardarNuevo(pVenta As VentaBE)
        Dim mCommand As String = "INSERT INTO Venta(Venta_id, Venta_fecha, venta_precio, venta_paquete) VALUES (" & pVenta.ID & ", " & pVenta.Fecha & ", " & pVenta.Precio & ", " & ", " & pVenta.Paquete & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Venta
    Public Shared Sub GuardarModificacion(pVenta As VentaBE)
        Dim mCommand As String = "UPDATE Venta SET " &
                                 "Venta_fecha = '" & pVenta.Fecha &
                                 ", venta_precio = " & pVenta.Precio &
                                 ", venta_paquete = " & pVenta.Paquete &
                                 "WHERE Venta_id = " & pVenta.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Venta
    Public Shared Sub Eliminar(pVenta As VentaBE)
        Dim mCommand As String = "DELETE FROM Venta WHERE Venta_id = " & pVenta.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos VentaBE con los datos de cada registro de la tabla Venta
    Public Shared Function ListarVentas() As List(Of VentaBE)
        Dim mLista As New List(Of VentaBE)
        Dim mCommand As String = "SELECT Venta_id, Venta_fecha, venta_precio, venta_paquete FROM Venta"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mVenta As New VentaBE

                    mVenta = CargarBE(mVenta, mRow)

                    mLista.Add(mVenta)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - VentaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
