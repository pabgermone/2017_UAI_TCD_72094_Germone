Imports BE
Imports DAL

''' <summary>
''' Clase Singleton
''' </summary>
Public Class Bitacora

#Region "Singleton"
    Private Shared mInstance As Bitacora


    Private Sub New()

    End Sub


    ''' <summary>
    ''' Devuelve la unica instancia de Bitacora que hay en el sistema
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As Bitacora
        If IsNothing(mInstance) Then
            mInstance = New Bitacora
        End If

        Return mInstance
    End Function
#End Region


    ''' <summary>
    ''' Guarda un registro en la bitacora
    ''' </summary>
    ''' <param name="pUsuario">Usuario que realizo la accion</param>
    ''' <param name="pFecha">Fecha en la que se registro</param>
    ''' <param name="pDescripcion">Descripcion de la accion registrada</param>
    Public Sub GuardarRegistro(pUsuario As String, pFecha As Date, pDescripcion As String)
        Dim mRegistro As New RegistroBE With {.Usuario = pUsuario,
                                              .Fecha = pFecha,
                                              .Descripcion = pDescripcion}

        mRegistro.DV = CalculadorDV.CalcularDV(mRegistro.Usuario & mRegistro.Fecha.ToString("yyyymmdd") & mRegistro.Descripcion)

        BitacoraDAL.GuardarRegistro(mRegistro)
    End Sub


    ''' <summary>
    ''' Lista todo lo que haya registrado en la bitacora
    ''' </summary>
    ''' <returns>Lista con los datos de las acciones registradas</returns>
    Public Shared Function ListarRegistros() As List(Of RegistroBE)
        Dim mLista As List(Of RegistroBE) = BitacoraDAL.ListarRegistros
        Dim mVerif As Boolean

        For Each mRegistro As RegistroBE In mLista
            If Not (CalculadorDV.VerificarDV(mRegistro.Usuario & mRegistro.Fecha.ToString("yyyymmdd") & mRegistro.Descripcion, mRegistro.DV)) Then
                mVerif = False
                Exit For
            Else
                mVerif = True
            End If
        Next

        If mVerif Then
            Return mLista
        Else
            MsgBox("Unos de los registros fue cambiado - Bitacora")
            Return Nothing
        End If
    End Function

End Class
