Imports BE
Imports System.Data.SqlClient

Public Class PasajeroDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pPasajero">Objeto BE a cargar</param>
    ''' <param name="pRow">Fila con datos a cargar al objeto BE</param>
    ''' <returns>Objeto BE cargado con datos recuperados de BD</returns>
    Private Shared Function CargarBE(pPasajero As PasajeroBE, pRow As DataRow) As PasajeroBE
        pPasajero.ID = pRow("Pasajero_id")
        pPasajero.Nombre = pRow("Pasajero_nombre")
        pPasajero.Apellido = pRow("pasajero_apellido")
        pPasajero.DNI = pRow("pasajero_dni")
        pPasajero.Pasaporte = pRow("pasajero_pasaporte")
        pPasajero.FechaNac = pRow("pasajero_fechaNac")
        pPasajero.Telefono = pRow("pasajero_telefono")
        pPasajero.Sexo = pRow("pasajero_sexo")
        pPasajero.EstadoCivil = pRow("pasajero_estadoCivil")

        Return pPasajero
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Pasajero
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns>Objeto BE con los datos recuperados de BD</returns>
    Public Shared Function ObtenerPasajero(pID As Integer) As PasajeroBE
        Dim mPasajero As New PasajeroBE
        Dim mCommand As String = "SELECT Pasajero_id, Pasajero_nombre, pasajero_apellido, pasajero_dni, pasajero_pasaporte, pasajero_fechaNac, pasajero_telefono, pasajero_sexo, pasajero_estadoCivil FROM Pasajero WHERE Pasajero_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mPasajero = CargarBE(mPasajero, mDataSet.Tables(0).Rows(0))
                Return mPasajero
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - PasajeroDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Pasajero
    ''' </summary>
    ''' <param name="pPasajero">Objeto BE con datos a persistir en BD</param>
    Public Shared Sub GuardarNuevo(pPasajero As PasajeroBE)
        Dim mCommand As String = "INSERT INTO Pasajero(Pasajero_id, Pasajero_nombre, pasajero_apellido, pasajero_dni, pasajero_pasaporte, pasajero_fechaNac, pasajero_telefono, pasajero_sexo, pasajero_estadoCivil) " &
                                 "VALUES (" & pPasajero.ID & ", '" &
                                              pPasajero.Nombre & "', '" &
                                              pPasajero.Apellido & "', " &
                                              pPasajero.DNI & ", " &
                                              pPasajero.Pasaporte & ", '" &
                                              pPasajero.FechaNac & "', " &
                                              pPasajero.Telefono & ", '" &
                                              pPasajero.Sexo & "', '" &
                                              pPasajero.EstadoCivil & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - PasajeroDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Pasajero
    ''' </summary>
    ''' <param name="pPasajero">Objeto BE con datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pPasajero As PasajeroBE)
        Dim mCommand As String = "UPDATE Pasajero SET " &
                                 "Pasajero_nombre = '" & pPasajero.Nombre &
                                 "', pasajero_apellido = '" & pPasajero.Apellido & "', " &
                                 "pasajero_dni = " & pPasajero.DNI & ", " &
                                 "pasajero_pasaporte = " & pPasajero.Pasaporte & ", " &
                                 "pasajero_fechaNac = '" & pPasajero.FechaNac & "', " &
                                 "pasajero_telefono = " & pPasajero.Telefono & ", " &
                                 "pasajero_sexo = '" & pPasajero.Sexo & "', " &
                                 "pasajero_estadoCivil = '" & pPasajero.EstadoCivil & "' " &
                                 "WHERE Pasajero_id = " & pPasajero.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - PasajeroDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Pasajero
    ''' </summary>
    ''' <param name="pPasajero">Objeto BE con datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pPasajero As PasajeroBE)
        Dim mCommand As String = "DELETE FROM Pasajero WHERE Pasajero_id = " & pPasajero.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - PasajeroDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos PasajeroBE con los datos de cada registro de la tabla Pasajero
    ''' </summary>
    ''' <returns>Lista de todos los pasajeros existentes en BD</returns>
    Public Shared Function ListarPasajeros() As List(Of PasajeroBE)
        Dim mLista As New List(Of PasajeroBE)
        Dim mCommand As String = "SELECT Pasajero_id, Pasajero_nombre, pasajero_apellido, pasajero_dni, pasajero_pasaporte, pasajero_fechaNac, pasajero_telefono, pasajero_sexo, pasajero_estadoCivil FROM Pasajero"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mPasajero As New PasajeroBE

                    mPasajero = CargarBE(mPasajero, mRow)

                    mLista.Add(mPasajero)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - PasajeroDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
