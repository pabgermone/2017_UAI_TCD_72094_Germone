Imports BE
Imports System.Data.SqlClient

Public Class RolDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Rol_id), 0) from Rol") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pRol As RolBE, pRow As DataRow) As RolBE
        pRol.ID = pRow("Rol_id")
        pRol.Nombre = pRow("Rol_nombre")

        Return pRol
    End Function


    'Ejecuta un query que obtiene los datos de una Rol
    Public Shared Function ObtenerRol(pID As Integer) As RolBE
        Dim mRol As New RolBE
        Dim mCommand As String = "SELECT Rol_id, Rol_nombre FROM Rol WHERE Rol_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mRol = CargarBE(mRol, mDataSet.Tables(0).Rows(0))
                Return mRol
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - RolDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Rol
    Public Shared Sub GuardarNuevo(pRol As RolBE)
        Dim mCommand As String = "INSERT INTO Rol(Rol_id, Rol_nombre) VALUES (" & pRol.ID & ", '" & pRol.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - RolDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Rol
    Public Shared Sub GuardarModificacion(pRol As RolBE)
        Dim mCommand As String = "UPDATE Rol SET " &
                                 "Rol_nombre = '" & pRol.Nombre &
                                 "WHERE Rol_id = " & pRol.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - RolDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Rol
    Public Shared Sub Eliminar(pRol As RolBE)
        Dim mCommand As String = "DELETE FROM Rol WHERE Rol_id = " & pRol.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - RolDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos RolBE con los datos de cada registro de la tabla Rol
    Public Shared Function ListarRols() As List(Of RolBE)
        Dim mLista As New List(Of RolBE)
        Dim mCommand As String = "SELECT Rol_id, Rol_nombre FROM Rol"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mRol As New RolBE

                    mRol = CargarBE(mRol, mRow)

                    mLista.Add(mRol)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - RolDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
