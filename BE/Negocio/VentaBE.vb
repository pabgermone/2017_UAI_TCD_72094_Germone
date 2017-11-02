Public Class VentaBE
    Public Property ID As Integer
    Public Property Usuario As Integer
    Public Property Fecha As Date
    Public Property Paquete As Integer
    Public Property DV As Integer

    Public Property Vuelos As New List(Of VueloBE)
    Public Property Clientes As New List(Of ClienteBE)
End Class
