Public Class DVVDAL

    ''' <summary>
    ''' Persiste un nuevo digito en la tabla DVV
    ''' </summary>
    ''' <param name="pTabla">Nombre de la tabla a la que corresponde en DVV</param>
    ''' <param name="pDigito">DVV a persistir</param>
    Public Shared Sub GuardarDigito(pTabla As String, pDigito As Integer)
        Dim mCommand As String = "insert into DVV(dvv_tabla, dvv_digito) values('" & pTabla & "', " & pDigito & ")"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - DVV")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un DVV existente en la tabla de DVVs
    ''' </summary>
    ''' <param name="pTabla">Tabla a la que corresponde el DVV a modificar</param>
    ''' <param name="pDigito">DVV a modificar</param>
    Public Shared Sub ModificarDigito(pTabla As String, pDigito As Integer)
        Dim mCommand As String = "update DVV set dvv_digito = " & pDigito & " where dvv_tabla like '" & pTabla & "'"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificar - DVV")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Obtiene el DVV correspondiente a una tabla de BD
    ''' </summary>
    ''' <param name="pTabla">Nombre de la tabla de la que se quiere obtener el DVV</param>
    ''' <returns>DVV recuperado de BD</returns>
    Public Shared Function ObtenerDVV(pTabla As String) As Integer
        Dim mDVV As Integer
        Dim mDataSet As DataSet
        Dim mCommand As String = "select dvv_digito from DVV where dvv_tabla like '" & pTabla & "'"

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) Then
                If mDataSet.Tables.Count > 0 Then
                    If mDataSet.Tables(0).Rows.Count > 0 Then
                        mDVV = mDataSet.Tables(0).Rows(0)("dvv_digito")
                    End If
                End If
            End If

            Return mDVV
        Catch ex As Exception
            MsgBox("Error - Obtener - DVV")
            MsgBox(ex.Message)

            Return Nothing
        End Try
    End Function

End Class
