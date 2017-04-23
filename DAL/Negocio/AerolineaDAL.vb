Imports BE
Imports System.Data.SqlClient

Public Class AerolineaDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(aerolinea_id), 0) from Aerolinea") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pAerolinea As AerolineaBE, pRow As DataRow) As AerolineaBE
        pAerolinea.ID = pRow("aerolinea_id")
        pAerolinea.Nombre = pRow("aerolinea_nombre")

        Return pAerolinea
    End Function


    'Ejecuta un query que obtiene los datos de una aerolinea
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


    'Crea un nuevo registro en la tabla Aerolinea
    Public Shared Sub GuardarNuevo(pAerolinea As AerolineaBE)
        Dim mCommand As String = "INSERT INTO Aerolinea(aerolinea_id, aerolinea_nombre) VALUES (" & pAerolinea.ID & ", '" & pAerolinea.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Aerolinea
    Public Shared Sub GuardarModificacion(pAerolinea As AerolineaBE)
        Dim mCommand As String = "UPDATE Aerolinea SET " &
                                 "aerolinea_nombre = '" & pAerolinea.Nombre &
                                 "WHERE aerolinea_id = " & pAerolinea.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Aerolinea
    Public Shared Sub Eliminar(pAerolinea As AerolineaBE)
        Dim mCommand As String = "DELETE FROM aerolinea WHERE aerolinea_id = " & pAerolinea.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - AerolineaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos AerolineaBE con los datos de cada registro de la tabla Aerolinea
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
End Class
