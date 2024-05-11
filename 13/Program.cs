
using System;

class Program
{
    static void Main()
    {
        // Tamaño de la matriz
        int filas = 10;
        int columnas = 10;

        // Crear una instancia de Random para generar números aleatorios
        Random random = new Random();

        // Crear una matriz de tamaño 10x10 para almacenar números aleatorios
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números aleatorios
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(1, 20); // Genera un número aleatorio entre 1 y 100
            }
        }

        // Mostrar la matriz en la consola
        Console.WriteLine("Matriz de números aleatorios de tamaño 10x10:");
        MostrarMatriz(matriz, filas, columnas);
    }

    static void MostrarMatriz(int[,] matriz, int filas, int columnas)
    {
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