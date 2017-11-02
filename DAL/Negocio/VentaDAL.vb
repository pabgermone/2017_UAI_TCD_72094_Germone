Imports BE
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
        pVenta.DV = pRow("venta_dv")

        CargarVuelos(pVenta)
        CargarClientes(pVenta)

        Return pVenta
    End Function


    ''' <summary>
    ''' Carga los vuelos relacionados con una venta
    ''' </summary>
    ''' <param name="pVenta">Venta de la que se quieren encontrar vuelos</param>
    Private Shared Sub CargarVuelos(pVenta As VentaBE)
        Dim mCommand As String = "select Vuelo_Numero, vuelo_disponible, vuelo_cantidadEspacios, Vuelo_fecha, vuelo_hora, vuelo_origen, vuelo_destino, vuelo_escalas, vuelo_aerolinea, vuelo_precio, vuelo_dv " &
                                       "from Vuelo inner join VentaVuelo on vuelo_numero = ventaVuelo_vuelo " &
                                       "where ventaVuelo_venta = " & pVenta.ID
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mVuelo As New VueloBE

                    VueloDAL.CargarBE(mVuelo, mRow)

                    pVenta.Vuelos.Add(mVuelo)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error - Carga vuelos - VentaDAL")
        End Try
    End Sub


    ''' <summary>
    ''' Carga los clientes relacionados con una venta
    ''' </summary>
    ''' <param name="pVenta">Venta de la que se quieren encontrar los vuelos</param>
    Private Shared Sub CargarClientes(pVenta As VentaBE)
        Dim mCommand As String = "select cliente_id, cliente_nombre, cliente_apellido, cliente_tipoDocumento, cliente_numeroDocumento, cliente_pasaporte, cliente_fechaNac, cliente_pais, cliente_direccion, cliente_codPostal, cliente_dv " &
                                         "from Cliente inner join VentaCliente on cliente_id = ventaCliente_cliente " &
                                         "where ventaCliente_venta = " & pVenta.ID

        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mCliente As New ClienteBE

                    ClienteDAL.CargarBE(mCliente, mRow)

                    pVenta.Clientes.Add(mCliente)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error - Carga clientes - VentaDAL")
        End Try
    End Sub


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Venta
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns>Objeto BE con datos recuperados de BD</returns>
    Public Shared Function ObtenerVenta(pID As Integer) As VentaBE
        Dim mVenta As New VentaBE
        Dim mCommand As String = "SELECT Venta_id, venta_usuario, Venta_fecha, venta_paquete, venta_dv FROM Venta WHERE Venta_id = " & pID

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
        Dim mCommand As String = "INSERT INTO Venta(venta_usuario, Venta_fecha, venta_paquete, venta_dv) VALUES (" & pVenta.Usuario & ", '" & pVenta.Fecha.ToString("yyyy-MM-dd") & "', " & pVenta.Paquete & ", " & pVenta.DV & ")"
        Dim mCommandClientes As String
        Dim mCommandVuelos As String

        Try
            BD.ExecuteNonQuery(mCommand)

            For Each mCliente As ClienteBE In pVenta.Clientes
                mCommandClientes = "insert into VentaCliente(ventaCliente_venta, ventaCliente_cliente) values((select isnull(max(venta_id), 0) from Venta), " & mCliente.ID & ")"

                BD.ExecuteNonQuery(mCommandClientes)
            Next

            For Each mVuelo As VueloBE In pVenta.Vuelos
                mCommandVuelos = "insert into VentaVuelo(ventaVuelo_venta, ventaVuelo_vuelo) values((select isnull(max(venta_id), 0) from Venta), " & mVuelo.Numero & ")"

                BD.ExecuteNonQuery(mCommandVuelos)
            Next
        Catch ex As Exception
            MsgBox("Error - Nuevo - VentaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Venta
    ''' </summary>
    ''' <param name="pVenta">Objeto BE con datos modificados a persistir</param>
    ''' <remarks>Solo modifica datos en la tabla Venta, no en sus relaciones con tablas intermedias</remarks>
    Public Shared Sub GuardarModificacion(pVenta As VentaBE)
        Dim mCommand As String = "UPDATE Venta SET " &
                                 "venta_usuario = " & pVenta.Usuario &
                                 ", Venta_fecha = '" & pVenta.Fecha.ToString("yyyy-MM-dd") &
                                 "', venta_paquete = " & pVenta.Paquete &
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
    <Obsolete("Las ventas no tienen que ser eliminadas. Flata hacer borrado logico")>
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
        Dim mCommand As String = "SELECT Venta_id, venta_usuario, Venta_fecha, venta_paquete, venta_dv FROM Venta"
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
