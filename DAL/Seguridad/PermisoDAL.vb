Imports BE
Imports System.Data.SqlClient

''' <summary>
''' PermisoDAL puede manejar datos de permisos simples y compuestos
''' </summary>
Public Class PermisoDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pPermiso">Objeto BE a Cargar</param>
    ''' <param name="pRow">Fila con datos a cargar en pPermiso</param>
    ''' <returns>Objeto BE Con propiedades cargadas</returns>
    Friend Shared Function CargarBE(pPermiso As PermisoAbstractoBE, pRow As DataRow) As PermisoAbstractoBE

        If TypeOf (pPermiso) Is PermisoBE Then
            pPermiso.ID = pRow("Permiso_id")
            pPermiso.Nombre = pRow("Permiso_nombre")

            If TypeOf (pRow("permiso_padre")) Is DBNull Then
                pPermiso.Padre = 0
            Else
                pPermiso.Padre = pRow("permiso_padre")
            End If

            If TypeOf (pRow("permiso_padre")) Is DBNull Then
                pPermiso.Formulario = ""
            Else
                pPermiso.Formulario = pRow("permiso_formulario")
            End If

        ElseIf TypeOf (pPermiso) Is PermisoCompuestoBE Then
            pPermiso.ID = pRow("permisoCompuesto_id")
            pPermiso.Nombre = pRow("permisoCompuesto_nombre")

            If TypeOf (pRow("permisoCompuesto_padre")) Is DBNull Then
                pPermiso.Padre = 0
            Else
                pPermiso.Padre = pRow("permisoCompuesto_padre")
            End If

            If TypeOf (pRow("permisoCompuesto_padre")) Is DBNull Then
                pPermiso.Formulario = ""
            Else
                pPermiso.Formulario = pRow("permisoCompuesto_formulario")
            End If
        End If

        Return pPermiso
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de un Permiso simple o compuesto
    ''' </summary>
    ''' <param name="pID">ID del permiso que se quiere obtener</param>
    ''' <returns>Datos del permiso indicado recuperados de BD</returns>
    Public Shared Function ObtenerPermiso(pID As Integer, pCompuesto As Boolean) As PermisoAbstractoBE
        Dim mPermiso As PermisoAbstractoBE
        Dim mCommand As String

        If pCompuesto Then
            mPermiso = New PermisoCompuestoBE
            mCommand = "SELECT PermisoCompuesto_id, PermisoCompuesto_nombre, permisoCompuesto_padre, permisoCompuesto_formulario FROM PermisoCompuesto WHERE PermisoCompuesto_id = " & pID
        Else
            mPermiso = New PermisoBE
            mCommand = "SELECT Permiso_id, Permiso_nombre, permiso_padre, permiso_formulario FROM Permiso WHERE Permiso_id = " & pID
        End If

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


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Permiso
    ''' </summary>
    ''' <param name="pPermiso">Objeto BE con datos a persistir en BD</param>
    Public Shared Sub GuardarNuevo(pPermiso As PermisoAbstractoBE)
        Dim mCommand As String = ""

        If TypeOf (pPermiso) Is PermisoBE Then
            mCommand = "INSERT INTO Permiso(Permiso_nombre, permiso_padre, permiso_formulario)
                        VALUES ('" & pPermiso.Nombre & "', " & pPermiso.Padre & ", '" & pPermiso.Formulario & "');"
        ElseIf TypeOf (pPermiso) Is PermisoCompuestoBE Then
            mCommand = "INSERT INTO PermisoCompuesto(PermisoCompuesto_nombre, permisoCompuesto_padre, permisoCompuesto_formulario)
                        VALUES ('" & pPermiso.Nombre & "', " & pPermiso.Padre & ", '" & pPermiso.Formulario & "');"
        End If

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Permiso
    ''' </summary>
    ''' <param name="pPermiso">Objeto BE con datos modificados a persistir</param>
    Public Shared Sub GuardarModificacion(pPermiso As PermisoAbstractoBE)
        Dim mCommand As String = ""

        If TypeOf (pPermiso) Is PermisoBE Then
            mCommand = "UPDATE Permiso SET " &
                                 "Permiso_nombre = '" & pPermiso.Nombre &
                                 "', permiso_padre = " & pPermiso.Padre &
                                 ", permiso_formulario = '" & pPermiso.Formulario &
                                 "' WHERE Permiso_id = " & pPermiso.ID
        ElseIf TypeOf (pPermiso) Is PermisoCompuestoBE Then
            mCommand = "UPDATE PermisoCompuesto SET " &
                                 "PermisoCompuesto_nombre = '" & pPermiso.Nombre &
                                 "', permisoCompuesto_padre = " & pPermiso.Padre &
                                 ", permisoCompuesto_formulario = '" & pPermiso.Formulario &
                                 "' WHERE PermisoCompuesto_id = " & pPermiso.ID
        End If

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Permiso o PermisoCompuesto
    ''' </summary>
    ''' <param name="pPermiso">Objeto BE con datos a eliminar en BD</param>
    Public Shared Sub Eliminar(pPermiso As PermisoAbstractoBE)
        Dim mCommand As String = ""

        If TypeOf (pPermiso) Is PermisoBE Then
            RolPermisoDAL.EliminarPorPermiso(pPermiso.ID)
            mCommand = "DELETE FROM Permiso WHERE Permiso_id = " & pPermiso.ID
        ElseIf TypeOf (pPermiso) Is PermisoCompuestoBE Then
            RolPermisoCompuestoDAL.EliminarPorPermiso(pPermiso.ID)
            mCommand = "DELETE FROM PermisoCompuesto WHERE PermisoCompuesto_id = " & pPermiso.ID
        End If

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - PermisoDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de Permiso o PermisoCompuesto con los datos de cada registro de la tabla Permiso o PermisoCompuesto
    ''' </summary>
    ''' <param name="pCompuesto">False (Default): Indica que se quiere una lista de PermisoBE /
    '''                          True: Indica que se quiere una lista de PermisoCompuestoBE</param>
    ''' <param name="pPadreID">ID del PermisoCompuesto padre del que se quieren obtener los hijos</param>
    ''' <returns>List(Of PermisoAbstracto) con todos los permisos simples o compuestos existentes en BD</returns>
    Public Shared Function ListarPermisos(Optional pCompuesto As Boolean = False, Optional pPadreID As Integer = -1) As List(Of PermisoAbstractoBE)
        Dim mLista As New List(Of PermisoAbstractoBE)
        Dim mCommand As String = ""

        If pCompuesto Then
            If pPadreID <> -1 Then
                mCommand = "SELECT PermisoCompuesto_id, PermisoCompuesto_nombre, permisoCompuesto_padre, permisoCompuesto_formulario FROM PermisoCompuesto
                             WHERE permisoCompuesto_padre = " & pPadreID
            Else
                mCommand = "SELECT PermisoCompuesto_id, PermisoCompuesto_nombre, permisoCompuesto_padre, permisoCompuesto_formulario FROM PermisoCompuesto"
            End If
        Else
            If pPadreID <> -1 Then
                mCommand = "SELECT Permiso_id, Permiso_nombre, permiso_padre, permiso_formulario FROM Permiso
                             WHERE permiso_padre = " & pPadreID
            Else
                mCommand = "SELECT Permiso_id, Permiso_nombre, permiso_padre, permiso_formulario FROM Permiso"
            End If
        End If

        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mPermiso As PermisoAbstractoBE

                    If pCompuesto Then
                        mPermiso = New PermisoCompuestoBE
                    Else
                        mPermiso = New PermisoBE
                    End If

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
