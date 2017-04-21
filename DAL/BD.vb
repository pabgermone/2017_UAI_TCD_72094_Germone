Imports System.Data.SqlClient

Public Class BD
    'Private Shared mConnectionString As String = "Data Source=PABLO-PC\SQLEXPRESS;Initial Catalog=Campo2017_VentaPasajes;Integrated Security=True"
    Private Shared mConnectionString As String = "Data Source=.\SQL14_UAI;Initial Catalog=Campo2017_VentaPasajes;Integrated Security=True"

    Private Shared mConnection As SqlConnection

    'Ejecuta una Query en la BD y devuelve un objeto DataSet con los datos obtenidos
    Public Shared Function ExecuteDataSet(pCommand As String) As DataSet
        Try
            mConnection = New SqlConnection(mConnectionString)
            Dim mDataSet As New DataSet
            Dim mDataAdapter As New SqlDataAdapter(pCommand, mConnection)

            mConnection.Open()
            mDataAdapter.Fill(mDataSet)

            Return mDataSet
        Catch ex As Exception
            MsgBox("Error en DataSet - BD")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            mConnection.Close()
            mConnection.Dispose()
        End Try
    End Function


    'Ejecuta un cambio en la BD y devuelve el numero de filas afectadas
    Public Shared Function ExecuteNonQuery(pCommand As String) As Integer
        Try
            mConnection = New SqlConnection(mConnectionString)
            Dim mCommand As New SqlCommand(pCommand, mConnection)

            mConnection.Open()
            Return mCommand.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Error - NonQuery - BD")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            mConnection.Close()
            mConnection.Dispose()
        End Try
    End Function


    '??
    Public Shared Function ExecuteReader(pCommandStr As String) As SqlDataReader
        Dim mReader As SqlDataReader

        Try
            mConnection = New SqlConnection(mConnectionString)
            Dim mCommand As New SqlCommand(pCommandStr, mConnection)

            mConnection.Open()
            mReader = mCommand.ExecuteReader

            Return mReader
        Catch ex As Exception
            MsgBox("Error - Reader - BD")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            mReader.Close()
            mConnection.Close()
            mConnection.Dispose()
        End Try
    End Function


    'Ejecuta una query en la BD y devuelve solo el primer resultado
    Public Shared Function ExecuteScalar(pCommandStr As String) As Integer
        Try
            mConnection = New SqlConnection(mConnectionString)
            Dim mCommand As New SqlCommand(pCommandStr, mConnection)

            mConnection.Open()
            Return mCommand.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error - Scalar - BD")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            mConnection.Close()
            mConnection.Dispose()
        End Try
    End Function
End Class