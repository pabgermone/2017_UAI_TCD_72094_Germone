Imports DAL
Imports BE

Public Class PasajeroBLL

#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property DNI As Integer
    Public Property Pasaporte As Integer
    Public Property FechaNac As String
    Public Property Telefono As Integer
    Public Property Sexo As String
    Public Property EstadoCivil As String
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub
#End Region


    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos existentes en BD para el registro indicado
    ''' </summary>
    ''' <param name="pId">ID del registro que contiene los datos deseados</param>
    Private Sub CargarPropiedades(pId As Integer)
        Dim mBE As PasajeroBE = PasajeroDAL.ObtenerPasajero(pId)

        Me.ID = mBE.ID
        Me.Nombre = mBE.Nombre
        Apellido = mBE.Apellido
        DNI = mBE.DNI
        Pasaporte = mBE.Pasaporte
        FechaNac = mBE.FechaNac
        Telefono = mBE.Telefono
        Sexo = mBE.Sexo
        EstadoCivil = mBE.EstadoCivil
    End Sub


    ''' <summary>
    ''' Carga un objeto PasajeroBE con los datos guardados en las propiedades de la entidad
    ''' </summary>
    ''' <param name="mBE">Instancia BE vacia en la que se quieren cargar los datos</param>
    Private Sub CargarBE(mBE As PasajeroBE)
        mBE.ID = Me.ID
        mBE.Nombre = Me.Nombre
        mBE.Apellido = Apellido
        mBE.DNI = DNI
        mBE.Pasaporte = Pasaporte
        mBE.FechaNac = FechaNac
        mBE.Telefono = Telefono
        mBE.Sexo = Sexo
        mBE.EstadoCivil = EstadoCivil
    End Sub


    ''' <summary>
    ''' Persiste los datos guardados en las propiedades de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New PasajeroBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            PasajeroDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PasajeroDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New PasajeroBE

        CargarBE(mBE)

        PasajeroDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Lista los datos de todos los pasajeros registrados en el sistema
    ''' </summary>
    ''' <returns>Coleccion de entidades BLL con datos recuperados de BD</returns>
    Public Shared Function ListarPasajeros() As List(Of PasajeroBLL)
        Dim mLista As New List(Of PasajeroBLL)
        Dim mListaBE As List(Of PasajeroBE) = PasajeroDAL.ListarPasajeros

        For Each mBE As PasajeroBE In mListaBE
            Dim mPasajero As New PasajeroBLL(mBE.ID)

            mLista.Add(mPasajero)
        Next

        Return mLista
    End Function
End Class
