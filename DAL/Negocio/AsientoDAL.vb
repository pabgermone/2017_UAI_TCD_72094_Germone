Imports BE
Imports System.Data.SqlClient

Public Class AsientoDAL
    Private Shared mProximoID As Integer

    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pAsiento As AsientoBE, pRow As DataRow) As AsientoBE
        pAsiento.Numero = pRow("asiento_id")
        pAsiento.NumeroVuelo = pRow("asiento_vuelo_numero")
        pAsiento.Ocupado = pRow("asiento_ocupado")

        Return pAsiento
    End Function


    'Ejecuta un query que obtiene los datos de un Asiento
    Public Shared Function ObtenerAsiento(pAsiento As Integer, pVuelo As Integer) As AsientoBE
        Dim mAsiento As New AsientoBE
        Dim mCommand As String = "SELECT asiento_numero, asiento_vuelo_numero, asiento_ocupado FROM Asiento WHERE Asiento_numero = " & pAsiento & " and asiento_vuelo_numero = " & pVuelo

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mAsiento = CargarBE(mAsiento, mDataSet.Tables(0).Rows(0))
                Return mAsiento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - AsientoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Asiento
    Public Shared Sub GuardarNuevo(pAsiento As AsientoBE)
        Dim mCommand As String = "INSERT INTO Asiento(asiento_numero, asiento_vuelo_numero, asiento_ocupado) VALUES (" & pAsiento.Numero & ", " & pAsiento.NumeroVuelo & ", " & pAsiento.Ocupado & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - AsientoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Asiento
    Public Shared Sub GuardarModificacion(pAsiento As AsientoBE)
        Dim mCommand As String = "UPDATE Asiento SET " &
                                 "asiento_ocupado = '" & pAsiento.Ocupado &
                                 "WHERE Asiento_id = " & pAsiento.Numero &
                                 " and asiento_vuelo_numero = " & pAsiento.NumeroVuelo

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - AsientoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Asiento
    Public Shared Sub Eliminar(pAsiento As AsientoBE)
        Dim mCommand As String = "DELETE FROM Asiento WHERE Asiento_id = " & pAsiento.Numero & " and asiento_vuelo_numero = " & pAsiento.NumeroVuelo

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - AsientoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos AsientoBE con los datos de cada registro de la tabla Asiento
    Public Shared Function ListarAsientos() As List(Of AsientoBE)
        Dim mLista As New List(Of AsientoBE)
        Dim mCommand As String = "SELECT Asiento_numero, Asiento_vuelo_numero, asiento_ocupado FROM Asiento"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mAsiento As New AsientoBE

                    mAsiento = CargarBE(mAsiento, mRow)

                    mLista.Add(mAsiento)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - AsientoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
