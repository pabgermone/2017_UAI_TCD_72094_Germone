﻿Imports BE
Imports System.Data.SqlClient

Public Class VentaDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pVenta">Objeto BE a cargar</param>
    ''' <param name="pRow">Fila con datos a cargar al objeto BE</param>
    ''' <returns>Objeto BE cargado con datos recuperados de BD</returns>
    Private Shared Function CargarBE(pVenta As VentaBE, pRow As DataRow) As VentaBE
        pVenta.ID = pRow("Venta_id")
        pVenta.Usuario = pRow("venta_usuario")
        pVenta.Fecha = pRow("venta_fecha")
        pVenta.Paquete = pRow("venta_paquete")
        pVenta.Cliente = pRow("venta_cliente")
        pVenta.Vuelo = pRow("venta_vuelo")
        pVenta.DV = pRow("venta_dv")

        Return pVenta
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Venta
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns>Objeto BE con datos recuperados de BD</returns>
    Public Shared Function ObtenerVenta(pID As Integer) As VentaBE
        Dim mVenta As New VentaBE
        Dim mCommand As String = "SELECT Venta_id, venta_usuario, Venta_fecha, venta_paquete, venta_cliente, venta_vuelo, venta_dv FROM Venta WHERE Venta_id = " & pID

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


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Venta
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con datos a persistir</param>
    Public Shared Sub GuardarNuevo(pVenta As VentaBE)
        Dim mCommand As String = "INSERT INTO Venta(venta_usuario, Venta_fecha, venta_paquete, venta_cliente, venta_vuelo, venta_dv) VALUES (" & pVenta.Usuario & ", '" & pVenta.Fecha.ToString("yyyy-MM-dd") & "', " & pVenta.Paquete & ", " & pVenta.Cliente & ", '" & pVenta.Vuelo & "', " & pVenta.DV & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Venta
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pVenta As VentaBE)
        Dim mCommand As String = "UPDATE Venta SET " &
                                 "venta_usuario = " & pVenta.Usuario &
                                 ", Venta_fecha = '" & pVenta.Fecha.ToString("yyyy-MM-dd") &
                                 "', venta_paquete = " & pVenta.Paquete &
                                 ", venta_cliente = " & pVenta.Cliente &
                                 ", venta_vuelo = '" & pVenta.Vuelo &
                                 "', venta_dv = " & pVenta.DV &
                                 " WHERE Venta_id = " & pVenta.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Venta
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pVenta As VentaBE)
        Dim mCommand As String = "DELETE FROM Venta WHERE Venta_id = " & pVenta.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos VentaBE con los datos de cada registro de la tabla Venta
    ''' </summary>
    ''' <returns>Lista de todas las ventas registradas en BD</returns>
    Public Shared Function ListarVentas() As List(Of VentaBE)
        Dim mLista As New List(Of VentaBE)
        Dim mCommand As String = "SELECT Venta_id, venta_usuario, Venta_fecha, venta_paquete, venta_cliente, venta_vuelo, venta_dv FROM Venta"
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
