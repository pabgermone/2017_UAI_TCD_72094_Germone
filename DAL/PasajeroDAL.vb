﻿Imports BE
Imports System.Data.SqlClient

Public Class PasajeroDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Pasajero_id), 0) from Pasajero") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
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


    'Ejecuta un query que obtiene los datos de una Pasajero
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


    'Crea un nuevo registro en la tabla Pasajero
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


    'Modifica un registro de la tabla Pasajero
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


    'Elimina un registro de la tabla Pasajero
    Public Shared Sub Eliminar(pPasajero As PasajeroBE)
        Dim mCommand As String = "DELETE FROM Pasajero WHERE Pasajero_id = " & pPasajero.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - PasajeroDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos PasajeroBE con los datos de cada registro de la tabla Pasajero
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
