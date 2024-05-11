using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de filas de la matriz:");
        int filas;
        while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las filas:");
        }

        Console.WriteLine("Ingrese el número de columnas de la matriz:");
        int columnas;
        while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las columnas:");
        }

        int[,] matriz = new int[filas, columnas];
        int contador = 1;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = contador;
                contador++;
            }
        }

        // Calcular el elemento central de la matriz
        int indiceFilaCentral = filas / 2;
        int indiceColumnaCentral = columnas / 2;
        int elementoCentral = matriz[indiceFilaCentral, indiceColumnaCentral];

        Console.WriteLine($"El elemento central de la matriz es: {elementoCentral}");
        Console.WriteLine("Matriz:");

        // Imprimir la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}