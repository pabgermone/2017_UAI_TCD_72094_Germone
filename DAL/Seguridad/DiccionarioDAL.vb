Imports BE
Imports System.Data.SqlClient

Public Class DiccionarioDAL


    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pDiccionario">Objeto BE al que se quiere cargar con datos</param>
    ''' <param name="pRow">Fila de la BD que contiene los datos para el objeto</param>
    ''' <returns>Objeto BE cargado con datos recuperados de la base</returns>
    Private Shared Function CargarBE(pDiccionario As DiccionarioBE, pRow As DataRow) As DiccionarioBE
        pDiccionario.IDPalabra = pRow("IdiomaDiccionario_IdDiccionario")
        pDiccionario.IDIdioma = pRow("IdiomaDiccionario_IdIdioma")
        pDiccionario.Traduccion = pRow("IdiomaDiccionario_Traduccion")

        Return pDiccionario
    End Function

    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Diccionario
    ''' </summary>
    ''' <param name="pID">Nombre del Diccionario que se quiere obtener</param>
    ''' <returns>Objeto BE con datos recuperados de BD</returns>
    Public Shared Function ObtenerDiccionario(pID As Integer) As DiccionarioBE
        Dim mDiccionario As New DiccionarioBE
        Dim mCommand As String = "SELECT IdiomaDiccionario_IdDiccionario, IdiomaDiccionario_IdIdioma, IdiomaDiccionario_Traduccion FROM IdiomaDiccionario WHERE IdiomaDiccionario_IdIdioma = " & pID & ";"

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mDiccionario = CargarBE(mDiccionario, mDataSet.Tables(0).Rows(0))
                Return mDiccionario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - DiccionarioDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Diccionario
    ''' </summary>
    ''' <param name="pDiccionario">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pDiccionario As DiccionarioBE)
        Dim mCommand As String = "INSERT INTO Diccionario(IdiomaDiccionario_IdDiccionario, IdiomaDiccionario_IdIdioma, IdiomaDiccionario_Traduccion) " &
                                 "VALUES (" & pDiccionario.IDPalabra & ", " & pDiccionario.IDIdioma & ", '" & pDiccionario.Traduccion & "');"

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Nuevo - DiccionarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Diccionario
    ''' </summary>
    ''' <param name="pDiccionario">Objeto BE con los datos modificades</param>
    Public Shared Sub GuardarModificacion(pDiccionario As DiccionarioBE)
        Dim mCommand As String = "UPDATE Diccionario SET " &
                                 "IdiomaDiccionario_IdDiccionario = " & pDiccionario.IDPalabra &
                                 ", IdiomaDiccionario_IdIdioma = " & pDiccionario.IDIdioma &
                                 ", IdiomaDiccionario_Traduccion = '" & pDiccionario.Traduccion &
                                 "' WHERE IdiomaDiccionario_IdIdioma = " & pDiccionario.IDIdioma

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - DiccionarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Diccionario
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE con los datos a eliminar de la BD</param>
    Public Shared Sub Eliminar(pIdioma As Integer)
        Dim mCommand As String = "DELETE FROM IdiomaDiccionario WHERE IdiomaDiccionario_IdIdioma = " & pIdioma

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - DiccionarioDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos DiccionarioBE con los datos de cada registro de la tabla Diccionario
    ''' </summary>
    ''' <returns>Lista con instancias BE con todos los datos obtenidos de la BD</returns>
    Public Shared Function ListarDiccionarios(pIdioma As Integer) As List(Of DiccionarioBE)
        Dim mLista As New List(Of DiccionarioBE)
        Dim mCommand As String = "SELECT IdiomaDiccionario_IdDiccionario, IdiomaDiccionario_IdIdioma, IdiomaDiccionario_Traduccion  FROM IdiomaDiccionario where idiomaDiccionario_IdIdioma = " & pIdioma
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mDiccionario As New DiccionarioBE

                    mDiccionario = CargarBE(mDiccionario, mRow)

                    mLista.Add(mDiccionario)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - DiccionarioDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
