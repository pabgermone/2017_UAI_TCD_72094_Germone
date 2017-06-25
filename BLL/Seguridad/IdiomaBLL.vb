Imports BE
Imports DAL

Public Class IdiomaBLL


#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String

    Public Property Diccionario As Dictionary(Of String, String)
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    ''' <summary>
    ''' Crea una nueva instancia con los datos que tengan las propiedades del objeto BE pasado por parametro
    ''' </summary>
    ''' <param name="pIdioma">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pIdioma As IdiomaBE)
        CargarPropiedades(pIdioma)
    End Sub

    ''' <summary>
    ''' Crea una nueva instancia con los datos recuperados de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub
#End Region

#Region "Carga de Datos"

    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pBE">Objeto BE con los datos deseados</param>
    Private Sub CargarPropiedades(pBE As IdiomaBE)
        If Not IsNothing(pBE) Then
            Me.ID = pBE.ID
            Me.Nombre = pBE.Nombre
            Me.Diccionario = pBE.Diccionario
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos recuperados de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Private Sub CargarPropiedades(pID As Integer)
        Dim pBE As IdiomaBE = IdiomaDAL.ObtenerIdioma(pID)

        If Not IsNothing(pBE) Then
            Me.ID = pBE.ID
            Me.Nombre = pBE.Nombre
            Me.Diccionario = pBE.Diccionario
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE vacio con las propiedades que haya en el objeto BLL
    ''' </summary>
    ''' <param name="mBE">Objeto BE a cargar</param>
    Private Sub CargarBE(mBE As IdiomaBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
        mBE.Diccionario = Me.Diccionario
    End Sub

#End Region


    ''' <summary>
    ''' Guarda los datos de esta instancia BLL en la BD
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New IdiomaBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            IdiomaDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            IdiomaDAL.GuardarModificacion(mBE)
        End If
    End Sub


    <Obsolete("Falta implementar")>
    Public Sub QuitarPermiso(pPermiso As PermisoAbstractoBE)
        'Buscar forma de apuntar el permiso seleccionado al permiso dentro de la lista del Idioma
        Throw New NotImplementedException
    End Sub


    ''' <summary>
    ''' Elimina de la BD los datos de esta instancia
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New IdiomaBE

        CargarBE(mBE)

        IdiomaDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Lista todos los Idiomaes guardados en la BD
    ''' </summary>
    ''' <returns>List(Of IdiomaBLL) que contiene todos los Idiomaes existentes en la BD</returns>
    Public Shared Function ListarIdiomaes() As List(Of IdiomaBLL)
        Dim mLista As New List(Of IdiomaBLL)
        Dim mListaBE As List(Of IdiomaBE) = IdiomaDAL.ListarIdiomas

        If Not IsNothing(mListaBE) Then
            For Each mBE As IdiomaBE In mListaBE
                Dim mIdioma As New IdiomaBLL(mBE)

                mLista.Add(mIdioma)
            Next
        End If

        Return mLista
    End Function


    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class

