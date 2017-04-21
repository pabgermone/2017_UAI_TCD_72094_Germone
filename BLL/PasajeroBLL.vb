Imports DAL
Imports BE

Public Class PasajeroBLL
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property DNI As Integer
    Public Property Pasaporte As Integer
    Public Property FechaNac As String
    Public Property Telefono As Integer
    Public Property Sexo As String
    Public Property EstadoCivil As String


    Sub New()

    End Sub

    Sub New(pID As Integer)
        CargarPropiedades(pID)
    End Sub


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


    Public Sub Guardar()
        Dim mBE As New PasajeroBE

        If Me.ID = 0 Then
            Me.ID = PasajeroDAL.GetProximoID
            CargarBE(mBE)
            PasajeroDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PasajeroDAL.GuardarModificacion(mBE)
        End If
    End Sub


    Public Sub Eliminar()
        Dim mBE As New PasajeroBE

        CargarBE(mBE)

        PasajeroDAL.Eliminar(mBE)
    End Sub


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
