﻿Imports System.IO

Module Module1

    Sub Main()

        Dim path As String = Directory.GetCurrentDirectory()
        Dim streamWriter As StreamWriter = New StreamWriter(path & "\" & "StreamWriterExample.txt")
        streamWriter.WriteLine("This is a test")
        streamWriter.WriteLine("This is a test")
        streamWriter.WriteLine("This is a test")
        streamWriter.Close()

    End Sub

End Module