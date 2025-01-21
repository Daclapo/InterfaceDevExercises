Imports System.IO

Module Module1
    Sub Main()
        ' Ruta del archivo de texto
        Dim filePath As String = "archivoTexto.txt"

        ' Escribir en el archivo
        EscribirArchivo(filePath)

        ' Leer desde el archivo
        LeerArchivo(filePath)

        ' No se necesita esperar una tecla
        ' El programa finalizará automáticamente al llegar al final de Main
    End Sub

    Sub EscribirArchivo(ByVal filePath As String)
        ' Usar StreamWriter para escribir en el archivo
        Dim writer As New System.IO.StreamWriter(filePath)
        writer.WriteLine("Hola, este es un archivo de texto creado en Visual Basic .NET.")
        writer.WriteLine("Cada línea se escribe usando StreamWriter.")
        writer.WriteLine("¡Este es el final del archivo!")
        writer.Close() ' Cerrar el archivo después de escribir
        writer = Nothing
        Console.WriteLine("Texto escrito en el archivo con éxito.")
    End Sub

    Sub LeerArchivo(ByVal filePath As String)
        ' Usar StreamReader para leer el archivo
        Dim reader As New System.IO.StreamReader(filePath)
        Console.WriteLine("Contenido del archivo:")
        While reader.Peek() >= 0
            Console.WriteLine(reader.ReadLine())
        End While
        reader.Close() ' Cerrar el archivo después de leer
    End Sub
End Module
