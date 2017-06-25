Imports BE
Imports System.Data.SqlClient

Public Class IdiomaDAL

    ''' <summary>
    ''' Carga un objeto BE con datos tomados de una fila de la tabla BD
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE al que se quiere cargar con datos</param>
    ''' <param name="pRow">Fila de la BD que contiene los datos para el objeto</param>
    ''' <returns>Objeto BE cargado con datos recuperados de la base</returns>
    Private Shared Function CargarBE(pIdioma As IdiomaBE, pRow As DataRow) As IdiomaBE
        pIdioma.ID = pRow("Idioma_id")
        pIdioma.Nombre = pRow("Idioma_nombre")

        CargarDiccionario(pIdioma.Diccionario, DiccionarioDAL.ListarDiccionarios(pIdioma.ID))

        Return pIdioma
    End Function


    ''' <summary>
    ''' Ejecuta un query que obtiene los datos de una Idioma
    ''' </summary>
    ''' <param name="pIdioma">Nombre del Idioma que se quiere obtener</param>
    ''' <returns>Objeto BE con datos recuperados de BD</returns>
    Public Shared Function ObtenerIdioma(pIdioma As String) As IdiomaBE
        Dim mIdioma As New IdiomaBE
        Dim mCommand As String = "SELECT Idioma_id, Idioma_nombre FROM Idioma WHERE idioma_nombre LIKE '" & pIdioma & "';"

        Try
            Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                mIdioma = CargarBE(mIdioma, mDataSet.Tables(0).Rows(0))
                Return mIdioma
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - DataSet - IdiomaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Crea un nuevo registro en la tabla Idioma
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE con los datos a persistir</param>
    Public Shared Sub GuardarNuevo(pIdioma As IdiomaBE)
        Dim mCommand As String = "INSERT INTO Idioma(Idioma_nombre) " &
                                 "VALUES ('" & pIdioma.Nombre & "');"

        Try
            BD.ExecuteNonQuery(mCommand)

            For Each mItem In pIdioma.Diccionario
                Dim mDiccionario As New DiccionarioBE

                mDiccionario.IDIdioma = pIdioma.ID
                mDiccionario.IDPalabra = mItem.Key 'Deberia ser el orden que tiene la palabra en el diccionario
                mDiccionario.Traduccion = mItem.Value

                DiccionarioDAL.GuardarNuevo(mDiccionario)
            Next
        Catch ex As Exception
            MsgBox("Error - Nuevo - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Modifica un registro de la tabla Idioma
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE con los datos modificades</param>
    Public Shared Sub GuardarModificacion(pIdioma As IdiomaBE)
        Dim mCommand As String = "UPDATE Idioma SET " &
                                 "Idioma_nombre = '" & pIdioma.Nombre &
                                 " WHERE Idioma_id = " & pIdioma.ID

        Try
            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Modificacion - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Elimina un registro de la tabla Idioma
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE con los datos a eliminar de la BD</param>
    Public Shared Sub Eliminar(pIdioma As IdiomaBE)
        Dim mCommand As String = "DELETE FROM Idioma WHERE Idioma_id = " & pIdioma.ID

        Try
            DiccionarioDAL.Eliminar(pIdioma.ID)

            BD.ExecuteNonQuery(mCommand)
        Catch ex As Exception
            MsgBox("Error - Eliminacion - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Devuelve una lista de objetos IdiomaBE con los datos de cada registro de la tabla Idioma
    ''' </summary>
    ''' <returns>Lista con instancias BE con todos los datos obtenidos de la BD</returns>
    Public Shared Function ListarIdiomas() As List(Of IdiomaBE)
        Dim mLista As New List(Of IdiomaBE)
        Dim mCommand As String = "SELECT Idioma_id, idioma_nombre FROM Idioma"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    Dim mIdioma As New IdiomaBE

                    mIdioma = CargarBE(mIdioma, mRow)

                    mLista.Add(mIdioma)
                Next

                Return mLista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error - Listar - IdiomaDAL")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Shared Sub CargarDiccionario(pDiccionario As Dictionary(Of String, String), pLista As List(Of DiccionarioBE))
        Dim mCommand As String = "select Diccionario_palabra, IdiomaDiccionario_Traduccion from Diccionario inner join IdiomaDiccionario on Diccionario.id = IdiomaDiccionario.IdDiccionario"
        Dim mDataSet As DataSet

        Try
            mDataSet = BD.ExecuteDataSet(mCommand)

            If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                For Each mRow As DataRow In mDataSet.Tables(0).Rows
                    pDiccionario.Add(mRow("Diccionario_palabra"), mRow("IdiomaDiccionario_Traduccion"))
                Next
            End If

        Catch ex As Exception
            MsgBox("Error - Carga Diccionario - IdiomaDAL")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class