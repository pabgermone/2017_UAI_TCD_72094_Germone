Imports DAL

Public Class ControladorDVV

    ''' <summary>
    ''' Se encarga de verificar la integridad de la BD
    ''' </summary>
    ''' <returns>Boolean indicando si los datos leidos son validos</returns>
    Public Shared Function VerificarBD() As Boolean
        Dim mValido As Boolean = True
        Dim mTabla As String
        Dim mStringDVs As String
        Dim mDataSetDVV As DataSet
        Dim mDataSetTabla As DataSet
        Dim mCommandDV As String
        Dim mCommandObtener As String = "select dvv_tabla, dvv_digito from DVV where dvv_fechaVerificacion not like '" & Date.Now.Date.ToString("yyyy-MM-dd") & "'"

        Try
            mDataSetDVV = BD.ExecuteDataSet(mCommandObtener)

            If Not IsNothing(mDataSetDVV) And mDataSetDVV.Tables.Count > 0 And mDataSetDVV.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSetDVV.Tables(0).Rows
                    mStringDVs = ""

                    mTabla = mRow("dvv_tabla")

                    mCommandDV = "select * from " & mTabla

                    mDataSetTabla = BD.ExecuteDataSet(mCommandDV)

                    If Not IsNothing(mDataSetTabla) And mDataSetTabla.Tables.Count > 0 Then
                        If mDataSetTabla.Tables(0).Rows.Count > 0 Then
                            For Each mRowTabla As DataRow In mDataSetTabla.Tables(0).Rows
                                mStringDVs &= mRowTabla(mTabla & "_dv")
                            Next

                            mValido = CalculadorDV.VerificarDV(mStringDVs, mRow("dvv_digito"))

                            ActualizarFecha(mTabla)

                            If Not mValido Then
                                Exit For
                            End If
                        End If
                    Else
                        MsgBox("Error - ControladorDVV - TablaDV")
                        mValido = False
                        Exit For
                    End If
                Next
            Else
                MsgBox("Error - ControladorDVV - TablaDVV")
                mValido = False
            End If

            Return mValido
        Catch ex As Exception
            MsgBox("Error - ControladorDVV - Verificar")
            MsgBox(ex.Message)

            Return False
        End Try
    End Function


    Private Shared Sub ActualizarFecha(pTabla As String)
        Dim mCommand As String = "update DVV set dvv_fechaVerificacion = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "' where dvv_tabla like '" & pTabla & "'"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - ControladorDVV - Cambio fecha")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Function CalcularDVV(pTabla As String)
        Dim mStringDVs As String = ""
        Dim mCommand As String = "select " & pTabla & "_dv from " & pTabla
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    mStringDVs &= mRow(pTabla & "_dv")
                Next
            End If

            Return CalculadorDV.CalcularDV(mStringDVs)
        Catch ex As Exception
            MsgBox("Error - ControladorDVV - CalcularDVV")
            MsgBox(ex.Message)

            Return Nothing
        End Try
    End Function


    Public Shared Sub GuardarNuevo(pTabla As String, pDigito As Integer)
        DVVDAL.GuardarDigito(pTabla, pDigito)
    End Sub


    Public Shared Sub ModificarDigito(pTabla As String, pDigito As Integer)
        DVVDAL.ModificarDigito(pTabla, pDigito)
    End Sub


    Public Shared Function ObtenerDigito(pTabla As String) As Integer
        Return DVVDAL.ObtenerDVV(pTabla)
    End Function

End Class
