Public Class roman_numbers
    Function ToRoman(ByVal number As Integer) As String
        Dim symbols As New List(Of String) From {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"}
        Dim numbers As New List(Of Integer) From {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1}

        Dim romanNumber = Nothing
        If number >= 5000 Then Return "Number must be in the range of 1 to 4999"
        While number > 0
            'Find the index
            Dim i = numbers.FindIndex(Function(x) x <= number)
            'Substract from the number
            number -= numbers(i)
            'Add the symbol to the romanNumber variable until the number is 0
            romanNumber += symbols(i)
        End While

        Return romanNumber
    End Function
End Class
