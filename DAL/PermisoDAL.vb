Imports BE
Imports System.Data.SqlClient

Public Class PermisoDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Permiso_id), 0) from Permiso") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pPermiso As PermisoBE, pRow As DataRow) As PermisoBE
        pPermiso.ID = pRow("Permiso_id")
        pPermiso.Nombre = pRow("Permiso_nombre")
        pPermiso.Padre = pRow("Permiso_padre")

        Return pPermiso
    End Function


    'Ejecuta un query que obtiene los datos de una Permiso
    Public Shared Function ObtenerPermiso(pID As Integer) As PermisoBE
        Dim mPermiso As New PermisoBE
        Dim mCommand As String = "SELECT Permiso_id, Permiso_nombre, permiso_padre FROM Permiso WHERE Permiso_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mPermiso = CargarBE(mPermiso, mDataSet.Tables(0).Rows(0))
                Return mPermiso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - PermisoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Permiso
    Public Shared Sub GuardarNuevo(pPermiso As PermisoBE)
        Dim mCommand As String = "INSERT INTO Permiso(Permiso_id, Permiso_nombre, permiso_padre) VALUES (" & pPermiso.ID & ", '" & pPermiso.Nombre & "', " & pPermiso.Padre & ");"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Permiso
    Public Shared Sub GuardarModificacion(pPermiso As PermisoBE)
        Dim mCommand As String = "UPDATE Permiso SET " &
                                 "Permiso_nombre = '" & pPermiso.Nombre &
                                 "', permiso_padre = " & pPermiso.Padre &
                                 " WHERE Permiso_id = " & pPermiso.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Permiso
    Public Shared Sub Eliminar(pPermiso As PermisoBE)
        Dim mCommand As String = "DELETE FROM Permiso WHERE Permiso_id = " & pPermiso.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos PermisoBE con los datos de cada registro de la tabla Permiso
    Public Shared Function ListarPermisos() As List(Of PermisoBE)
        Dim mLista As New List(Of PermisoBE)
        Dim mCommand As String = "SELECT Permiso_id, Permiso_nombre, permiso_padre FROM Permiso"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mPermiso As New PermisoBE

                    mPermiso = CargarBE(mPermiso, mRow)

                    mLista.Add(mPermiso)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - PermisoDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
