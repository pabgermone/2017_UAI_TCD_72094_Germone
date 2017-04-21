Imports BE
Imports System.Data.SqlClient

Public Class DestinoDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Destino_id), 0) from Destino") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pDestino As DestinoBE, pRow As DataRow) As DestinoBE
        pDestino.ID = pRow("Destino_id")
        pDestino.Nombre = pRow("Destino_nombre")

        Return pDestino
    End Function


    'Ejecuta un query que obtiene los datos de una Destino
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


    'Crea un nuevo registro en la tabla Destino
    Public Shared Sub GuardarNuevo(pDestino As DestinoBE)
        Dim mCommand As String = "INSERT INTO Destino(Destino_id, Destino_nombre) VALUES (" & pDestino.ID & ", '" & pDestino.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - DestinoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Destino
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


    'Elimina un registro de la tabla Destino
    Public Shared Sub Eliminar(pDestino As DestinoBE)
        Dim mCommand As String = "DELETE FROM Destino WHERE Destino_id = " & pDestino.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - DestinoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos DestinoBE con los datos de cada registro de la tabla Destino
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
