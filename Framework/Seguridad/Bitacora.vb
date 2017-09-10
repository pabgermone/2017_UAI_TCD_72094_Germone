Imports BE
Imports DAL

Public Class Bitacora
    Private Shared mInstance As Bitacora


    Private Sub New()

    End Sub


    Public Shared Function GetInstance() As Bitacora
        If IsNothing(mInstance) Then
            mInstance = New Bitacora
        End If

        Return mInstance
    End Function


    Public Sub GuardarRegistro(pUsuario As String, pFecha As Date, pDescripcion As String)
        Dim mRegistro As New RegistroBE With {.Usuario = pUsuario,
                                              .Fecha = pFecha,
                                              .Descripcion = pDescripcion}

        BitacoraDAL.GuardarRegistro(mRegistro)
    End Sub


    Public Shared Function ListarRegistros() As List(Of RegistroBE)
        Return BitacoraDAL.ListarRegistros
    End Function

End Class
