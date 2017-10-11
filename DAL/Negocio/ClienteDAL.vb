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
        pCliente.TipoDocumento = pRow("cliente_tipoDocumento")
        pCliente.NumeroDocumento = pRow("cliente_numeroDocumento")
        pCliente.Pasaporte = pRow("cliente_pasaporte")
        pCliente.FechaNac = pRow("cliente_fechaNac")
        pCliente.Pais = pRow("cliente_pais")
        pCliente.Direccion = pRow("cliente_direccion")
        pCliente.CodigoPostal = pRow("cliente_codPostal")
        pCliente.DV = pRow("cliente_dv")

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
                CargarTelefonos(mCliente)
                CargarMails(mCliente)
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
    ''' Carga el array Telefonos del cliente que se pase por parametros
    ''' </summary>
    ''' <param name="pBE">Cliente al que se quieren cargar numeros de telefono</param>
    Private Shared Sub CargarTelefonos(pBE As ClienteBE)
        Dim mCommand As String = "select telefono_numero from telefono where telefono_cliente = " & pBE.ID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    pBE.Telefonos(pBE.Telefonos.Count) = mRow("telefono_numero")
                Next
            End If
        Catch ex As Exception
            MsgBox("Error - CargarTelefonos - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Carga el array de Mails del cliente que se pase por parametros
    ''' </summary>
    ''' <param name="pBE">Cliente al que se quieren cargar direcciones de mail</param>
    Private Shared Sub CargarMails(pBE As ClienteBE)
        Dim mCommand As String = "select email_direccion from email where email_cliente = " & pBE.ID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    pBE.Emails(pBE.Emails.Count) = mRow("email_cliente")
                Next
            End If
        Catch ex As Exception
            MsgBox("Error - CargarMails - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Cliente
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pCliente As ClienteBE)
        Dim mCommand As String = "INSERT INTO Cliente(Cliente_nombre, cliente_apellido, cliente_tipoDocumento, cliente_numeroDocumento, cliente_pasaporte, cliente_fechaNac, cliente_pais, cliente_direccion, cliente_codPostal, cliente_dv) 
                                  VALUES ('" & pCliente.Nombre & "', '" & pCliente.Apellido & "', '" & pCliente.TipoDocumento & "', " & pCliente.NumeroDocumento & ", " & pCliente.Pasaporte & ", '" & pCliente.FechaNac.ToString("yyyy-MM-dd") & "', '" & pCliente.Pais & "', '" & pCliente.Direccion & "', " & pCliente.CodigoPostal & ", " & pCliente.DV & ")"

        Dim mCommandTelefonos As String
        Dim mCommandMails As String

        Try
            BD.ExecuteNonQuery(mCommand)

            For Each mTelefono As Integer In pCliente.Telefonos
                mCommandTelefonos = "insert into Telefono(telefono_numero, telefono_cliente) values(" & mTelefono & ", " & pCliente.ID & ")"

                BD.ExecuteNonQuery(mCommandTelefonos)
            Next

            For Each mMail As String In pCliente.Emails
                mCommandMails = "insert into Email(email_direccion, email_cliente) values('" & mMail & "', " & pCliente.ID & ")"

                BD.ExecuteNonQuery(mCommandMails)
            Next
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
                                 "', cliente_tipoDocumento = '" & pCliente.TipoDocumento &
                                 "'m cliente_numeroDocumento = " & pCliente.NumeroDocumento &
                                 ", cliente_pasaporte = " & pCliente.Pasaporte &
                                 ", cliente_fechaNac = '" & pCliente.FechaNac.ToString("yyyy-MM-dd") &
                                 "', cliente_pais = '" & pCliente.Pais &
                                 "', cliente_direccion = '" & pCliente.Direccion &
                                 "', cliente_codPostal = " & pCliente.CodigoPostal &
                                 ", cliente_dv = " & pCliente.DV &
                                 " WHERE Cliente_id = " & pCliente.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - ClienteDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica los registros de numeros de telefono relacionados con el cliente pasado por parametros
    ''' </summary>
    ''' <param name="pBE">Cliente del que se quieren modifcar numeros de telefono</param>
    Private Shared Sub ModificarTelefonos(pBE As ClienteBE)
        Dim mCommandEliminar As String = "delete from Telefono where telefono_cliente = " & pBE.ID
        Dim mCommandCarga As String

        Try
            BD.ExecuteNonQuery(mCommandEliminar)

            For Each mTelefono As Integer In pBE.Telefonos
                mCommandCarga = "insert into Telefono(telefono_numero, telefono_cliente) values(" & mTelefono & ", " & pBE.ID & ")"

                BD.ExecuteNonQuery(mCommandCarga)
            Next
        Catch ex As Exception
            MsgBox("Error - ModificarTelefonos - ClienteDAL")
        End Try
    End Sub


    ''' <summary>
    ''' Modifica los registros de direcciones de mail relacionados con el cliente pasado por parametros
    ''' </summary>
    ''' <param name="pBE">Cliente del que se quieren modifcar direcciones de mail</param>
    Private Shared Sub ModificarMails(pBE As ClienteBE)
        Dim mCommandEliminar As String = "delete from Email where email_cliente = " & pBE.ID
        Dim mCommandCarga As String

        Try
            BD.ExecuteNonQuery(mCommandEliminar)

            For Each mMail As String In pBE.Emails
                mCommandCarga = "insert into Email(email_direccion, email_cliente) values('" & mMail & "', " & pBE.ID & ")"

                BD.ExecuteNonQuery(mCommandCarga)
            Next
        Catch ex As Exception
            MsgBox("Error - ModificarMails - ClienteDAL")
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Cliente
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos a eliminar de BD</param>
    Public Shared Sub Eliminar(pCliente As ClienteBE)
        Dim mCommand As String = "DELETE FROM Cliente WHERE Cliente_id = " & pCliente.ID
        Dim mCommandTelefonos As String = "delete from Telefono where telefono_cliente = " & pCliente.ID
        Dim mCommandMails As String = "delete from Email where email_cliente = " & pCliente.ID

        Try
            BD.ExecuteNonQuery(mCommand)
            BD.ExecuteNonQuery(mCommandTelefonos)
            BD.ExecuteNonQuery(mCommandMails)
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
                    CargarTelefonos(mCliente)
                    CargarMails(mCliente)

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
