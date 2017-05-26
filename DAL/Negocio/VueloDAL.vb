Imports BE

Public Class VueloDAL
    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE a cargar con datos</param>
    ''' <param name="pRow">Fila de datos recuperada de BD</param>
    ''' <returns>Objeto BE con datos cargados</returns>
    Private Shared Function CargarBE(pVuelo As VueloBE, pRow As DataRow) As VueloBE
        pVuelo.Numero = pRow("Vuelo_Numero")
        pVuelo.Disponible = pRow("vuelo_disponible")
        pVuelo.Fecha = pRow("vuelo_fecha")
        pVuelo.Hora = CType(pRow("vuelo_hora"), TimeSpan).ToString("hh\:mm")
        pVuelo.Destino = pRow("vuelo_destino")
        pVuelo.Aerolinea = pRow("vuelo_aerolinea")

        Return pVuelo
    End Function


    ''' <summary>
    ''' Recupera los datos de una Vuelo de BD
    ''' </summary>
    ''' <param name="pNumero">Numero del registro de BD con los datos deseados</param>
    ''' <returns></returns>
    Public Shared Function ObtenerVuelo(pNumero As Integer) As VueloBE
        Dim mVuelo As New VueloBE
        Dim mCommand As String = "SELECT Vuelo_Numero, vuelo_disponible, Vuelo_fecha, vuelo_hora, vuelo_destino, vuelo_aerolinea FROM Vuelo WHERE Vuelo_Numero = " & pNumero

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mVuelo = CargarBE(mVuelo, mDataSet.Tables(0).Rows(0))
                Return mVuelo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - VueloDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Vuelo
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pVuelo As VueloBE)
        Dim mCommand As String = "INSERT INTO Vuelo(Vuelo_Numero, vuelo_disponible, Vuelo_fecha, vuelo_hora, vuelo_destino, vuelo_aerolinea) 
                                  VALUES ('" & pVuelo.Numero & "', " & IIf(pVuelo.Disponible, 1, 0) & ", '" & pVuelo.Fecha.ToString("yyyy-MM-dd") & "', '" & pVuelo.Hora & "', " & pVuelo.Destino & ", " & pVuelo.Aerolinea & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - VueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Vuelo
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pVuelo As VueloBE)
        Dim mCommand As String = "UPDATE Vuelo SET " &
                                 "vuelo_disponible = " & IIf(pVuelo.Disponible, 1, 0) &
                                 ", vuelo_fecha = '" & pVuelo.Fecha.ToString("yyyy-MM-dd") &
                                 "', vuelo_hora = '" & pVuelo.Hora &
                                 "', vuelo_destino = " & pVuelo.Destino &
                                 ", vuelo_aerolinea = " & pVuelo.Aerolinea &
                                 " WHERE Vuelo_Numero like '" & pVuelo.Numero & "'"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - VueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Vuelo
    ''' </summary>
    ''' <param name="pVuelo">Objeto BE con los datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pVuelo As VueloBE)
        Dim mCommand As String = "update Vuelo set vuelo_disponible = 0 where vuelo_numero like '" & pVuelo.Numero & "'"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - VueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina todos los vuelos relacionados a una aerolinea
    ''' </summary>
    ''' <param name="pAerolineaID">ID de la aerolinea de la que se quieren eliminar vuelos</param>
    Public Shared Sub EliminarPorAerolinea(pAerolineaID As Integer)
        Dim mCommand As String = "update Vuelo set vuelo_disponible = 0 where vuelo_aerolinea = " & pAerolineaID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminar por Aerolinea - VueloDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos VueloBE con los datos de cada registro de la tabla Vuelo
    ''' </summary>
    ''' <param name="pAerolinea">(Optional) ID de la aerolinea de la que se quieren recuperar vuelos</param>
    ''' <returns>Lista de todas las Vuelos existentes en BD</returns>
    Public Shared Function ListarVuelos(Optional pAerolinea As Integer = 0) As List(Of VueloBE)
        Dim mLista As New List(Of VueloBE)
        Dim mCommand As String = ""

        If pAerolinea <> 0 Then
            mCommand = "SELECT Vuelo_Numero, vuelo_disponible, Vuelo_fecha, vuelo_hora, vuelo_destino, vuelo_aerolinea FROM Vuelo where vuelo_aerolinea = " & pAerolinea
        Else
            mCommand = "SELECT Vuelo_Numero, vuelo_disponible, Vuelo_fecha, vuelo_hora, vuelo_destino, vuelo_aerolinea FROM Vuelo"
        End If

        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mVuelo As New VueloBE

                    mVuelo = CargarBE(mVuelo, mRow)

                    mLista.Add(mVuelo)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - VueloDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
