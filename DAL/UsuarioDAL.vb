Imports BE
Imports System.Data.SqlClient

Public Class UsuarioDAL
    Private Shared mProximoID As Integer

    'Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Usuario_id), 0) from Usuario") + 1
    End Function


    'Carga un objeto BE con datos tomados de una fila de la tabla BD
    Private Shared Function CargarBE(pUsuario As UsuarioBE, pRow As DataRow) As UsuarioBE
        pUsuario.ID = pRow("Usuario_id")
        pUsuario.UserName = pRow("usuario_userName")
        pUsuario.Nombre = pRow("Usuario_nombre")
        pUsuario.Apellido = pRow("usuario_apellido")
        pUsuario.Password = pRow("usuario_password")
        pUsuario.Rol = pRow("usuario_rol")

        Return pUsuario
    End Function


    'Ejecuta un query que obtiene los datos de una Usuario
    Public Shared Function ObtenerUsuario(pID As Integer) As UsuarioBE
        Dim mUsuario As New UsuarioBE
        Dim mCommand As String = "SELECT Usuario_id, usuario_userName, usuario_nombre, usuario_apellido, usuario_password, usuario_rol FROM Usuario WHERE Usuario_id = " & pID

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mUsuario = CargarBE(mUsuario, mDataSet.Tables(0).Rows(0))
                Return mUsuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - UsuarioDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Crea un nuevo registro en la tabla Usuario
    Public Shared Sub GuardarNuevo(pUsuario As UsuarioBE)
        Dim mCommand As String = "INSERT INTO Usuario(Usuario_id, Usuario_userName, usuario_nombre, usuario_apellido, usuario_password, usuario_rol) " &
                                 "VALUES (" & pUsuario.ID & ", '" & pUsuario.UserName & "', '" & pUsuario.Nombre & "', '" & pUsuario.Apellido & "', " & pUsuario.Rol & ");"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - UsuarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modifica un registro de la tabla Usuario
    Public Shared Sub GuardarModificacion(pUsuario As UsuarioBE)
        Dim mCommand As String = "UPDATE Usuario SET " &
                                 "usuario_userName = '" & pUsuario.UserName &
                                 "', usuario_nombre = '" & pUsuario.Nombre &
                                 "', usuario_apellido = '" & pUsuario.Apellido &
                                 "', usuario_password = '" & pUsuario.Password &
                                 "', usuario_rol = " & pUsuario.Rol &
                                 " WHERE Usuario_id = " & pUsuario.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - UsuarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Elimina un registro de la tabla Usuario
    Public Shared Sub Eliminar(pUsuario As UsuarioBE)
        Dim mCommand As String = "DELETE FROM Usuario WHERE Usuario_id = " & pUsuario.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - UsuarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    'Devuelve una lista de objetos UsuarioBE con los datos de cada registro de la tabla Usuario
    Public Shared Function ListarUsuarios() As List(Of UsuarioBE)
        Dim mLista As New List(Of UsuarioBE)
        Dim mCommand As String = "SELECT SELECT Usuario_id, usuario_userName, usuario_nombre, usuario_apellido, usuario_password, usuario_rol FROM Usuario"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mUsuario As New UsuarioBE

                    mUsuario = CargarBE(mUsuario, mRow)

                    mLista.Add(mUsuario)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - UsuarioDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
