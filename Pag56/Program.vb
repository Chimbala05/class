Imports System

Module Program
    Sub Main()

        'Declarar variables
        Dim Nota, Repetir As Double

Entrada:

        'Llenar variable de entrada (Nota)
        Try
            Console.Write("Digite la nota: ")
            Nota = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine("Debe introducir su nota en formato n�merico")
            GoTo Entrada
        End Try

        'Si Nota es mayor o igual a 70 entonces aprueba, y reprueba si es menor
        If Nota >= 70 Then
            Console.WriteLine()
            Console.WriteLine("    APROBADO")
        Else
            Console.WriteLine()
            Console.WriteLine("    REPROBADO")
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