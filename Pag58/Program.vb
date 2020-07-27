Imports System

Module Program
    Sub Main()

        'Declarar variables
        Dim Edad, Repetir As Double

Entrada:

        'Llenar variable de entrada (Edad)
        Try
            Console.Write("Digite la edad: ")
            Edad = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine("Debe introducir su edad en formato númerico")
            GoTo Entrada
        End Try

        'Si Edad es mayor o igual a 18 entonces es mayor de edad; de lo contrario, es menor
        If Edad >= 18 Then
            Console.WriteLine()
            Console.WriteLine("    Es mayor de edad")
        Else
            Console.WriteLine()
            Console.WriteLine("    Es menor de edad")
        End If

        'Llenar variable de entrada (Repetir)
        Console.WriteLine()
        Console.Write("Pulse 1 para voler al inicio, o cualquier otra tecla para salir: ")
        Repetir = Console.ReadLine()

        'Si Repetir = 1 entonces volver al inicio
        If Repetir = 1 Then
            Console.Clear()
            GoTo Entrada
        End If
    End Sub
End Module