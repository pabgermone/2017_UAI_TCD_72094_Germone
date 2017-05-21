Imports BE
Imports DAL

Public Class PaqueteBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Descripcion As String
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un PaqueteBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pPaquete">ID de Paquete del que se quieren recuperar datos</param>
    Sub New(pPaquete As Integer)
        CargarPropiedades(pPaquete)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pPaquete">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pPaquete As PaqueteBE)
        CargarPropiedades(pPaquete)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pPaquete">ID de la Paquete del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pPaquete As Integer)
        Dim mBE As PaqueteBE = PaqueteDAL.ObtenerPaquete(pPaquete)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Descripcion = mBE.Descripcion
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pPaquete">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pPaquete As PaqueteBE)
        If Not IsNothing(pPaquete) Then
            Me.ID = pPaquete.ID
            Me.Descripcion = pPaquete.Descripcion
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="mBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(mBE As PaqueteBE)
        mBE.ID = Me.ID
        mBE.Descripcion = Me.Descripcion
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New PaqueteBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            PaqueteDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PaqueteDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New PaqueteBE

        CargarBE(mBE)

        PaqueteDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada Paquete guardado en la BD
    ''' </summary>
    ''' <returns>List(Of PaqueteBLL) con datos de cada Paquete</returns>
    Public Shared Function ListarPaquetes() As List(Of PaqueteBLL)
        Dim mLista As New List(Of PaqueteBLL)
        Dim mListaBE As List(Of PaqueteBE) = PaqueteDAL.ListarPaquetes

        If Not IsNothing(mListaBE) Then
            For Each mBE As PaqueteBE In mListaBE
                Dim mPaquete As New PaqueteBLL(mBE)

                mLista.Add(mPaquete)
            Next
        End If


        Return mLista
    End Function

End Class
