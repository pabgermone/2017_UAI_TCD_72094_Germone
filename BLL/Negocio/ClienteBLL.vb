Imports BE
Imports DAL
Imports Framework

Public Class ClienteBLL
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property TipoDocumento As String
    Public Property NumeroDocumento As Integer
    Public Property Pasaporte As Integer
    Public Property FechaNac As Date
    Public Property Pais As String
    Public Property Direccion As String
    Public Property CodigoPostal As Integer
    Public Property Telefonos As Integer()
    Public Property Emails As String()
    Public Property DV As Integer
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
            If CalculadorDV.VerificarDV(mBE.Nombre & mBE.Apellido & mBE.TipoDocumento & mBE.NumeroDocumento & mBE.Pasaporte & mBE.FechaNac.ToString("yyyymmdd") & mBE.Pais & mBE.Direccion & mBE.CodigoPostal, mBE.DV) Then
                Me.ID = mBE.ID
                Me.Nombre = mBE.Nombre
                Me.Apellido = mBE.Apellido
                Me.TipoDocumento = mBE.TipoDocumento
                Me.NumeroDocumento = mBE.NumeroDocumento
                Me.Pasaporte = mBE.Pasaporte
                Me.FechaNac = mBE.FechaNac
                Me.Pais = mBE.Pais
                Me.Direccion = mBE.Direccion
                Me.CodigoPostal = mBE.CodigoPostal
                Me.DV = mBE.DV

                For Each mTelefono As Integer In mBE.Telefonos
                    Me.Telefonos(Me.Telefonos.Count) = mTelefono
                Next

                For Each mMail As String In mBE.Emails
                    Me.Emails(Me.Emails.Count) = mMail
                Next
            Else
                MsgBox("Error DV - ClienteBLL")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de la instancia con datos de un Objeto BE
    ''' </summary>
    ''' <param name="pCliente">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pCliente As ClienteBE)
        If Not IsNothing(pCliente) Then
            If CalculadorDV.VerificarDV(pCliente.Nombre & pCliente.Apellido & pCliente.TipoDocumento & pCliente.NumeroDocumento & pCliente.Pasaporte & pCliente.FechaNac.ToString("yyyymmdd") & pCliente.Pais & pCliente.Direccion & pCliente.CodigoPostal, pCliente.DV) Then
                Me.ID = pCliente.ID
                Me.Nombre = pCliente.Nombre
                Me.Apellido = pCliente.Apellido
                Me.TipoDocumento = pCliente.TipoDocumento
                Me.NumeroDocumento = pCliente.NumeroDocumento
                Me.Pasaporte = pCliente.Pasaporte
                Me.FechaNac = pCliente.FechaNac
                Me.Pais = pCliente.Pais
                Me.Direccion = pCliente.Direccion
                Me.CodigoPostal = pCliente.CodigoPostal
                Me.DV = pCliente.DV

                For Each mTelefono As Integer In pCliente.Telefonos
                    Me.Telefonos(Me.Telefonos.Count) = mTelefono
                Next

                For Each mMail As String In pCliente.Emails
                    Me.Emails(Me.Emails.Count) = mMail
                Next
            Else
                MsgBox("Error DV - ClienteBLL")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se quiere cargar con datos</param>
    Public Sub CargarBE(pBE As ClienteBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Apellido = Me.Apellido
        pBE.TipoDocumento = Me.TipoDocumento
        pBE.NumeroDocumento = Me.NumeroDocumento
        pBE.Pasaporte = Me.Pasaporte
        pBE.FechaNac = Me.FechaNac
        pBE.Pais = Me.Pais
        pBE.Direccion = Me.Direccion
        pBE.CodigoPostal = Me.CodigoPostal
        pBE.DV = Me.DV

        For Each mTelefono As Integer In Me.Telefonos
            pBE.Telefonos(pBE.Telefonos.Count) = mTelefono
        Next

        For Each mMail As String In Me.Emails
            pBE.Emails(pBE.Emails.Count) = mMail
        Next
    End Sub
#End Region


    ''' <summary>
    ''' Persiste en la base los datos de la instancia
    ''' </summary>
    Public Sub Guardar()
        Me.DV = CalculadorDV.CalcularDV(Me.Nombre & Me.Apellido & Me.TipoDocumento & Me.NumeroDocumento & Me.Pasaporte & Me.FechaNac & Me.Pais & Me.Direccion & Me.CodigoPostal)

        Dim mBE As New ClienteBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            ClienteDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            ClienteDAL.GuardarModificacion(mBE)
        End If

        ControladorDVV.ModificarDigito("Cliente", ControladorDVV.CalcularDVV("Cliente"))
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta instancia de la BD
    ''' </summary>
    Public Sub Eliminar()
        Dim mBE As New ClienteBE

        CargarBE(mBE)

        ClienteDAL.Eliminar(mBE)

        ControladorDVV.ModificarDigito("Cliente", ControladorDVV.CalcularDVV("Cliente"))
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


    Public Overrides Function ToString() As String
        Return Me.Nombre & " " & Me.Apellido
    End Function
End Class
