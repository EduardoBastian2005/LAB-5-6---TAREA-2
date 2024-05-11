using System;


class Program
{
    static void Main(string[] args)
    {
        // Declarar matriz
        Console.WriteLine("Ingrese el número de filas y columnas de la matriz (separados por un espacio):");
        string input = Console.ReadLine();
        string[] dimensions = input.Split(' ');
        int filas = int.Parse(dimensions[0]);
        int columnas = int.Parse(dimensions[1]);

        int[,] matrix = new int[filas, columnas];

        // Resolver
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Ingrese el elemento de la matriz ({0}, {1}):", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Sirve el max para el valor máximo
        int max = FindMax(matrix);
        Console.WriteLine("El máximo elemento de la matriz es: " + max);
    }

    //  el máximo elemento de una matriz dada
    static int FindMax(int[,] matrix)
    {
        int max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Si el elemento actual es mayor que el máximo actual, actualiza el máximo
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }
}