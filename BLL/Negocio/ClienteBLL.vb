Imports BE
Imports DAL

Public Class ClienteBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property DNI As Integer
    Public Property Pasaporte As Integer
    Public Property FechaNac As Date
    Public Property Telefono As Integer
    Public Property Sexo As String
    Public Property EstadoCivil As String
#End Region

#Region "Constructores"

    Sub New()

    End Sub


    ''' <summary>
    ''' Instancia un ClienteBLL con los datos que haya en BD
    ''' </summary>
    ''' <param name="pCliente">Numero de Cliente del que se quieren recuperar datos</param>
    Sub New(pCliente As Integer)
        CargarPropiedades(pCliente)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos que se quieren copiar</param>
    Sub New(pCliente As ClienteBE)
        CargarPropiedades(pCliente)
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de un objeto BLL con datos de la BD
    ''' </summary>
    ''' <param name="pCliente">Numero del Cliente del que se quieren obtener datos</param>
    Private Sub CargarPropiedades(pCliente As Integer)
        Dim mBE As ClienteBE = ClienteDAL.ObtenerCliente(pCliente)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
            Me.Apellido = mBE.Apellido
            Me.DNI = mBE.DNI
            Me.Pasaporte = mBE.Pasaporte
            Me.FechaNac = mBE.FechaNac
            Me.Telefono = mBE.Telefono
            Me.Sexo = mBE.Sexo
            Me.EstadoCivil = mBE.EstadoCivil
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pCliente As ClienteBE)
        If Not IsNothing(pCliente) Then
            Me.ID = pCliente.ID
            Me.Nombre = pCliente.Nombre
            Me.Apellido = pCliente.Apellido
            Me.DNI = pCliente.DNI
            Me.Pasaporte = pCliente.Pasaporte
            Me.FechaNac = pCliente.FechaNac
            Me.Telefono = pCliente.Telefono
            Me.Sexo = pCliente.Sexo
            Me.EstadoCivil = pCliente.EstadoCivil
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se quiere cargar con datos</param>
    Private Sub CargarBE(pBE As ClienteBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Apellido = Me.Apellido
        pBE.DNI = Me.DNI
        pBE.Pasaporte = Me.Pasaporte
        pBE.FechaNac = Me.FechaNac
        pBE.Telefono = Me.Telefono
        pBE.Sexo = Me.Sexo
        pBE.EstadoCivil = Me.EstadoCivil
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Dim mBE As New ClienteBE

        If mBE.ID = 0 Then
            CargarBE(mBE)
            ClienteDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            ClienteDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New ClienteBE

        CargarBE(mBE)

        ClienteDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Instancia y guarda en un lista objetos BLL con los datos de cada usuario guardado en la BD
    ''' </summary>
    ''' <returns>List(Of UsuarioBLL) con datos de cada usuario</returns>
    Public Shared Function Listar() As List(Of ClienteBLL)
        Dim mLista As New List(Of ClienteBLL)
        Dim mListaBE As List(Of ClienteBE) = ClienteDAL.ListarClientes

        If Not IsNothing(mListaBE) Then
            For Each mBE As ClienteBE In mListaBE
                Dim mUsuario As New ClienteBLL(mBE)

                mLista.Add(mUsuario)
            Next
        End If


        Return mLista
    End Function
End Class
