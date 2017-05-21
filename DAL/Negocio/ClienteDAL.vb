Imports BE

Public Class ClienteDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pCliente">Objeto BE a cargar con datos</param>
    ''' <param name="pRow">Fila de datos recuperada de BD</param>
    ''' <returns></returns>
    Private Shared Function CargarBE(pCliente As ClienteBE, pRow As DataRow) As ClienteBE
        pCliente.ID = pRow("Cliente_id")
        pCliente.Nombre = pRow("Cliente_nombre")
        pCliente.Apellido = pRow("cliente_apellido")
        pCliente.DNI = pRow("cliente_dni")
        pCliente.Pasaporte = pRow("cliente_pasaporte")
        pCliente.FechaNac = pRow("cliente_fechaNac")
        pCliente.Telefono = pRow("cliente_telefono")
        pCliente.Sexo = pRow("cliente_sexo")
        pCliente.EstadoCivil = pRow("cliente_estadoCivil")

        Return pCliente
    End Function


    ''' <summary>
    ''' Recupera los datos de una Cliente de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns></returns>
    Public Shared Function ObtenerCliente(pID As Integer) As ClienteBE
        Dim mCliente As New ClienteBE
        Dim mCommand As String = "SELECT * FROM Cliente WHERE Cliente_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mCliente = CargarBE(mCliente, mDataSet.Tables(0).Rows(0))
                Return mCliente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - ClienteDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Cliente
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pCliente As ClienteBE)
        Dim mCommand As String = "INSERT INTO Cliente(Cliente_nombre, cliente_apellido, cliente_dni, cliente_pasaporte, cliente_fechaNac, cliente_telefono, cliente_sexo, cliente_estadoCivil) 
                                  VALUES ('" & pCliente.Nombre & "', '" & pCliente.Apellido & "', " & pCliente.DNI & ", " & pCliente.Pasaporte & ", " & pCliente.FechaNac & ", " & pCliente.Telefono & ", '" & pCliente.Sexo & "', '" & pCliente.EstadoCivil & "'"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Cliente
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pCliente As ClienteBE)
        Dim mCommand As String = "UPDATE Cliente SET " &
                                 "Cliente_nombre = '" & pCliente.Nombre &
                                 "', cliente_apellido = '" & pCliente.Apellido &
                                 "', cliente_dni = " & pCliente.DNI &
                                 ", cliente_pasaporte = " & pCliente.Pasaporte &
                                 ", cliente_fechaNac = " & pCliente.FechaNac &
                                 ", cliente_telefono = " & pCliente.Telefono &
                                 ", cliente_sexo = '" & pCliente.Sexo &
                                 "', cliente_estadoCivil = '" & pCliente.EstadoCivil &
                                 "', WHERE Cliente_id = " & pCliente.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Cliente
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pCliente As ClienteBE)
        Dim mCommand As String = "DELETE FROM Cliente WHERE Cliente_id = " & pCliente.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos ClienteBE con los datos de cada registro de la tabla Cliente
    ''' </summary>
    ''' <returns>Lista de todas las Clientes existentes en BD</returns>
    Public Shared Function ListarClientes() As List(Of ClienteBE)
        Dim mLista As New List(Of ClienteBE)
        Dim mCommand As String = "SELECT * FROM Cliente"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mCliente As New ClienteBE

                    mCliente = CargarBE(mCliente, mRow)

                    mLista.Add(mCliente)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - ClienteDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
