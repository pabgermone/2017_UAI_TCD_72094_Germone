Imports BE
Imports System.Data.SqlClient

Public Class PaqueteDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Paquete_id), 0) from Paquete") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pPaquete As PaqueteBE, pRow As DataRow) As PaqueteBE
        pPaquete.ID = pRow("Paquete_id")
        pPaquete.Descripcion = pRow("Paquete_Descripcion")

        Return pPaquete
    End Function


    'Ejecuta un query que obtiene los datos de una Paquete
    Public Shared Function ObtenerPaquete(pID As Integer) As PaqueteBE
        Dim mPaquete As New PaqueteBE
        Dim mCommand As String = "SELECT Paquete_id, Paquete_Descripcion FROM Paquete WHERE Paquete_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mPaquete = CargarBE(mPaquete, mDataSet.Tables(0).Rows(0))
                Return mPaquete
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - PaqueteDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Paquete
    Public Shared Sub GuardarNuevo(pPaquete As PaqueteBE)
        Dim mCommand As String = "INSERT INTO Paquete(Paquete_id, Paquete_Descripcion) VALUES (" & pPaquete.ID & ", '" & pPaquete.Descripcion & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - PaqueteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Paquete
    Public Shared Sub GuardarModificacion(pPaquete As PaqueteBE)
        Dim mCommand As String = "UPDATE Paquete SET " &
                                 "Paquete_Descripcion = '" & pPaquete.Descripcion &
                                 "WHERE Paquete_id = " & pPaquete.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - PaqueteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Paquete
    Public Shared Sub Eliminar(pPaquete As PaqueteBE)
        Dim mCommand As String = "DELETE FROM Paquete WHERE Paquete_id = " & pPaquete.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - PaqueteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos PaqueteBE con los datos de cada registro de la tabla Paquete
    Public Shared Function ListarPaquetes() As List(Of PaqueteBE)
        Dim mLista As New List(Of PaqueteBE)
        Dim mCommand As String = "SELECT Paquete_id, Paquete_Descripcion FROM Paquete"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mPaquete As New PaqueteBE

                    mPaquete = CargarBE(mPaquete, mRow)

                    mLista.Add(mPaquete)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - PaqueteDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
