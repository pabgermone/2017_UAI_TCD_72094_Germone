Imports System.Data.SqlClient
Imports BE

Public Class BitacoraDAL

    Private Shared Sub CargarBE(pRegistro As RegistroBE, pRow As DataRow)
        pRegistro.Usuario = pRow("bitacora_usuario")
        pRegistro.Fecha = pRow("bitacora_fecha")
        pRegistro.Descripcion = pRow("bitacora_descripcion")
        pRegistro.DV = pRow("bitacora_dv")
    End Sub


    Public Shared Sub GuardarRegistro(pRegistro As RegistroBE)
        Dim mCommand As String = "insert into Bitacora(bitacora_usuario, bitacora_fecha, bitacora_descripcion, bitacora_dv) 
                                  values('" & pRegistro.Usuario & "', '" & pRegistro.Fecha.ToString("yyyy-MM-dd") & "', '" & pRegistro.Descripcion & "', " & pRegistro.DV & ");"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - BitacoraDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Function ListarRegistros() As List(Of RegistroBE)
        Dim mLista As New List(Of RegistroBE)
        Dim mCommand As String = "select bitacora_usuario, bitacora_fecha, bitacora_descripcion, bitacora_dv from Bitacora"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            For Each mRow As DataRow In mDataSet.Tables(0).Rows
                Dim mRegistro As New RegistroBE

                CargarBE(mRegistro, mRow)

                mLista.Add(mRegistro)
            Next

            Return mLista
        Catch ex As Exception
            MsgBox("Error - Listar - BitacoraDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
