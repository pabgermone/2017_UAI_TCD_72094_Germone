Imports DAL

Public Class CalculadorDV

    Public Shared Sub CalcularDV(pString As String)
        Dim mDV As Integer

        pString = pString.ToUpper

        Dim mTotal As Integer

        For i As Integer = 0 To pString.Length - 1
            Dim mChar As Char = pString.Chars(pString.Length - i - 1)

            Dim mDigito As Integer = Asc(mChar) - 48

            Dim mValor As Integer

            If i Mod 2 = 0 Then
                mValor = (2 * mDigito) - CInt(mDigito / 5) * 9
            Else
                mValor = mDigito
            End If

            mTotal += mValor
        Next

        mTotal = Math.Abs(mTotal) + 10

        mDV = (10 - (mTotal Mod 10)) Mod 10
    End Sub

End Class
