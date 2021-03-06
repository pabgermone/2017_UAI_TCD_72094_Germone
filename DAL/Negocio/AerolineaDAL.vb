﻿Imports BE

Public Class AerolineaDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE a cargar con datos</param>
    ''' <param name="pRow">Fila de datos recuperada de BD</param>
    ''' <returns></returns>
    Private Shared Function CargarBE(pAerolinea As AerolineaBE, pRow As DataRow) As AerolineaBE
        pAerolinea.ID = pRow("aerolinea_id")
        pAerolinea.Nombre = pRow("aerolinea_nombre")

        Return pAerolinea
    End Function


    ''' <summary>
    ''' Recupera los datos de una Aerolinea de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns></returns>
    Public Shared Function ObtenerAerolinea(pID As Integer) As AerolineaBE
        Dim mAerolinea As New AerolineaBE
        Dim mCommand As String = "SELECT aerolinea_id, aerolinea_nombre FROM Aerolinea WHERE aerolinea_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mAerolinea = CargarBE(mAerolinea, mDataSet.Tables(0).Rows(0))
                Return mAerolinea
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - AerolineaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Aerolinea
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pAerolinea As AerolineaBE)
        Dim mCommand As String = "INSERT INTO Aerolinea(aerolinea_nombre) VALUES ('" & pAerolinea.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Aerolinea
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE con los datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pAerolinea As AerolineaBE)
        Dim mCommand As String = "UPDATE Aerolinea SET " &
                                 "aerolinea_nombre = '" & pAerolinea.Nombre &
                                 "' WHERE aerolinea_id = " & pAerolinea.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Aerolinea
    ''' </summary>
    ''' <param name="pAerolinea">Objeto BE con los datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pAerolinea As AerolineaBE)
        Dim mCommand As String = "DELETE FROM aerolinea WHERE aerolinea_id = " & pAerolinea.ID

        Try
            VueloDAL.EliminarPorAerolinea(pAerolinea.ID)
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos AerolineaBE con los datos de cada registro de la tabla Aerolinea
    ''' </summary>
    ''' <returns>Lista de todas las Aerolineas existentes en BD</returns>
    Public Shared Function ListarAerolineas() As List(Of AerolineaBE)
        Dim mLista As New List(Of AerolineaBE)
        Dim mCommand As String = "SELECT aerolinea_id, aerolinea_nombre FROM Aerolinea"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mAerolinea As New AerolineaBE

                    mAerolinea = CargarBE(mAerolinea, mRow)

                    mLista.Add(mAerolinea)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - AerolineaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Devuelve una lista de vuelos pertenecientes a una aerolinea que cumplen con ciertos requisitos de busqueda
    ''' </summary>
    ''' <param name="pAerolinea">ID de la aeroliena de la que se quieren obtener vuelos</param>
    ''' <param name="pFecha">Fecha de los vuelos que se quieren obtener</param>
    ''' <param name="pOrigen">ID del lugar de origen de los vuelos a obtener</param>
    ''' <param name="pDestino">ID del lugar de destino de los velos a obtener</param>
    ''' <param name="pCantPAsajeros">Cantidad de pasajeros que deberian poder viajar en los vuelos a obtener</param>
    ''' <returns>List(Of VueloBE) con los vuelos resultantes de la busqueda</returns>
    Public Shared Function FiltrarVuelos(pAerolinea As Integer, pFecha As Date, pOrigen As Integer, pDestino As Integer, pCantPAsajeros As Integer)
        Dim mListaVuelos As New List(Of VueloBE)
        Dim mCommand As String = "select * from Vuelo where
                                  vuelo_fecha like '" & pFecha.ToString("yyyy-MM-dd") & "' and vuelo_origen = " & pOrigen & " and vuelo_destino = " & pDestino & " and vuelo_cantidadEspacios >= " & pCantPAsajeros & " and vuelo_aerolinea = " & pAerolinea

        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mVuelo As New VueloBE

                    VueloDAL.CargarBE(mVuelo, mRow)

                    mListaVuelos.Add(mVuelo)
                Next
            End If

            Return mListaVuelos
        Catch ex As Exception
            MsgBox("Error - FiltrarVuelos - AerolineaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
