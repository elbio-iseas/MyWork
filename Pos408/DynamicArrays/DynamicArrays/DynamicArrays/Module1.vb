Module Module1

    Sub Main()
        Dim intElements As Integer = 3
        Dim Vector(3) As Integer
        Vector(0) = 18
        Vector(1) = 20
        Vector(2) = 8
        System.Console.Write("Enter number of elements greater than 3 for the array: ")
        intElements = System.Console.ReadLine()
        ReDim Preserve Vector(intElements)
        For intIndex As Integer = 3 To intElements - 1
            Vector(intIndex) = CInt(Int((99 * Rnd()) + 1))
        Next
        For intIndex As Integer = 0 To intElements - 1
            System.Console.WriteLine("Element value : " & Vector(intIndex))
        Next
        System.Console.ReadKey()
        System.Console.Write("Now Enter new number of elements > 0 and < actual number of elements for the array: ")
        Dim intFewerElements As Integer
        intFewerElements = System.Console.ReadLine()
        ReDim Preserve Vector(intFewerElements)
        For intIndex As Integer = 0 To intFewerElements - 1
            System.Console.WriteLine("Element value : " & Vector(intIndex))
        Next
        System.Console.ReadKey()
    End Sub

End Module
