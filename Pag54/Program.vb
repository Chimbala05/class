Imports System

Module Program
    Sub Main()
        Console.Title = "Sirett 20-EISM-6-021"

        'Declaracion de variables
        Dim Cuota As Double
        Dim Tardanza As Double
        Dim Mora As Double
        Dim Descuento As Double
        Dim DeudaTotal As Double
        Dim Repetir As Double

Entrada1:
        'Llenar variables de entrada
        Try
            Console.WriteLine()
            Console.Write("Introduzca la cuota a pagar: ")
            Cuota = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Entrada invalida, intentemos de nuevo")
            Console.WriteLine()
            GoTo Entrada1
        End Try

Entrada2:
        Try
            Console.WriteLine()
            Console.Write("¿Cuántos meses tiene de retraso?: ")
            Tardanza = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Entrada invalida, intentemos de nuevo")
            Console.WriteLine()
            GoTo Entrada2
        End Try

        'Si Tardanza >= 1 entonces
        If Tardanza >= 1 Then
            Mora = Cuota * 0.05
            Descuento = 0
        Else
            Mora = 0
            Descuento = Cuota * 0.1
        End If

        'Calcular DeuudaTotal
        DeudaTotal = (Cuota + Mora) - Descuento

        'Mostrar resultados
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine("Resumen")
        Console.WriteLine()
        Console.WriteLine("Cuota: " & Cuota)
        Console.WriteLine("Meses de retraso: " & Tardanza)
        Console.WriteLine("Mora: " & Mora)
        Console.WriteLine("Descuento: " & Descuento)
        Console.WriteLine("Deuda Total: " & DeudaTotal)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Pulse 1 si desea voler al inicio, o cualquier otra tecla para salir: ")
        Repetir = Console.ReadLine()

        'Si repetir = 1 entonces repetir el programa
        If Repetir = 1 Then
            Console.Clear()
            GoTo Entrada1
        End If

    End Sub
End Module
