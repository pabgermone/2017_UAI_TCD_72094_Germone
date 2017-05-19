Imports BE
Imports System.Data.SqlClient

Public Class DestinoDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pDestino">Objeto BE a cargar</param>
    ''' <param name="pRow">Fila con los datos a cargar en el objeto BE</param>
    ''' <returns></returns>
    Private Shared Function CargarBE(pDestino As DestinoBE, pRow As DataRow) As DestinoBE
        pDestino.ID = pRow("Destino_id")
        pDestino.Nombre = pRow("Destino_nombre")

        Return pDestino
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Destino
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns></returns>
    Public Shared Function ObtenerDestino(pID As Integer) As DestinoBE
        Dim mDestino As New DestinoBE
        Dim mCommand As String = "SELECT Destino_id, Destino_nombre FROM Destino WHERE Destino_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mDestino = CargarBE(mDestino, mDataSet.Tables(0).Rows(0))
                Return mDestino
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - DestinoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Destino
    ''' </summary>
    ''' <param name="pDestino">Objeto BE con datos a persistir</param>
    Public Shared Sub GuardarNuevo(pDestino As DestinoBE)
        Dim mCommand As String = "INSERT INTO Destino(Destino_id, Destino_nombre) VALUES (" & pDestino.ID & ", '" & pDestino.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - DestinoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Destino
    ''' </summary>
    ''' <param name="pDestino">Objeto BE con datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pDestino As DestinoBE)
        Dim mCommand As String = "UPDATE Destino SET " &
                                 "Destino_nombre = '" & pDestino.Nombre &
                                 "WHERE Destino_id = " & pDestino.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - DestinoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Destino
    ''' </summary>
    ''' <param name="pDestino">Objeto BE con datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pDestino As DestinoBE)
        Dim mCommand As String = "DELETE FROM Destino WHERE Destino_id = " & pDestino.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - DestinoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos DestinoBE con los datos de cada registro de la tabla Destino
    ''' </summary>
    ''' <returns>Lista de todos los destinos existentes en BD</returns>
    Public Shared Function ListarDestinos() As List(Of DestinoBE)
        Dim mLista As New List(Of DestinoBE)
        Dim mCommand As String = "SELECT Destino_id, Destino_nombre FROM Destino"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mDestino As New DestinoBE

                    mDestino = CargarBE(mDestino, mRow)

                    mLista.Add(mDestino)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - DestinoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
