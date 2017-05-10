Imports BE
Imports System.Data.SqlClient

Public Class RolDAL
    Private Shared mProximoID As Integer

    ''' <summary>
    ''' Ejecuta una query sobre la base para saber cual es el ultimo ID de la tabla y le suma uno
    ''' </summary>
    ''' <returns>Integer con el ID a asignar</returns>
    <Obsolete("El ID tiene que ser manejado desde la BD")>
    Public Shared Function GetProximoID() As Integer
        Return BD.ExecuteScalar("select isnull(max(Rol_id), 0) from Rol") + 1
    End Function


    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pRol">RolBE que se quiere cargar con datos</param>
    ''' <param name="pRow">DataRow que contiene los datos para pRol</param>
    ''' <returns>RolBE con propiedades cargadas</returns>
    Private Shared Function CargarBE(pRol As RolBE, pRow As DataRow) As RolBE
        pRol.ID = pRow("Rol_id")
        pRol.Nombre = pRow("Rol_nombre")
        pRol.ListaPermisos = ObtenerPermisos(pRol.ID)

        Return pRol
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de un Rol
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    ''' <returns>RolBE con los datos recuperados de BD par esa entidad</returns>
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


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Rol
    ''' </summary>
    ''' <param name="pRol">RolBE con datos a persistir</param>
    Public Shared Sub GuardarNuevo(pRol As RolBE)
        Dim mCommand As String = "INSERT INTO Rol(Rol_id, Rol_nombre) VALUES (" & pRol.ID & ", '" & pRol.Nombre & "')"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - RolDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Rol
    ''' </summary>
    ''' <param name="pRol">RolBE con datos modificados</param>
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


    ''' <summary>
    ''' Elimina un registro de la tabla Rol
    ''' </summary>
    ''' <param name="pRol">RolBE con datos a eliminar</param>
    Public Shared Sub Eliminar(pRol As RolBE)
        Dim mCommand As String = "DELETE FROM Rol WHERE Rol_id = " & pRol.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - RolDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos RolBE con los datos de cada registro de la tabla Rol
    ''' </summary>
    ''' <returns>List(Of RolBE) con objetos BE cargados con datos obtenidos de BD</returns>
    Public Shared Function ListarRoles() As List(Of RolBE)
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


    ''' <summary>
    ''' Recupera de BD todos los permisos relacionados con esta instancia de RolBE
    ''' </summary>
    ''' <returns>
    ''' List(Of PermisoAbstractoBE) con instancias de los permisos que se relacionan con el Rol indicado
    ''' </returns>
    Public Shared Function ObtenerPermisos(pID As Integer) As List(Of PermisoAbstractoBE)
        Dim mLista As New List(Of PermisoAbstractoBE)
        Dim mCommand As String = "select permiso_id, permiso_nombre, permiso_padre, permiso_formulario
                                  from Permiso
                                  inner join RolPermiso on rolPermiso_permiso = permiso_id
                                  where rolPermiso_rol = " & pID

        Dim mCommandComp As String = "select permisoCompuesto_id, permisoCompuesto_nombre, permisoCompuesto_padre, PermisoCompuesto_formulario
                                      from PermisoCompuesto
                                      inner join RolPermisoCompuesto on rolPermisoCompuesto_permiso = permisoCompuesto_id
                                      where rolPermisoCompuesto_rol = " & pID

        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mBE As New PermisoBE

                    mLista.Add(PermisoDAL.CargarBE(mBE, mRow))
                Next
            End If


            mDataSet = BD.ExecuteDataSet(mCommandComp)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mBE As New PermisoCompuestoBE

                    mLista.Add(PermisoDAL.CargarBE(mBE, mRow))
                Next
            End If

            Return mLista
        Catch ex As Exception
            MsgBox("Error - ObtenerPermisos - RolDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
End Class