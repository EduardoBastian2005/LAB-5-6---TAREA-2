using System;

namespace MatrixSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de f1 de la primera matriz: ");
            int filas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de c1 de la primera matriz: ");
            int columnas1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de f2 de la segunda matriz: ");
            int filas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de c2 de la segunda matriz: ");
            int columnas2 = int.Parse(Console.ReadLine());

            // Resolver
            if (columnas1 != filas2)
            {
                Console.WriteLine("No se puede sumar las matrices porque tienen diferentes dimensiones!!!");
                return;
            }

            int[,] matriz1 = new int[filas1, columnas1];
            Console.WriteLine("Ingrese los elementos de la primera matriz:");
            for (int i = 0; i < filas1; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < columnas1; j++)
                {
                    matriz1[i, j] = int.Parse(input[j]);
                }
            }

            int[,] matriz2 = new int[filas2, columnas2];
            Console.WriteLine("Ingrese los elementos de la segunda matriz:");
            for (int i = 0; i < filas2; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < columnas2; j++)
                {
                    matriz2[i, j] = int.Parse(input[j]);
                }
            }

            int[,] sumMatrix = new int[filas1, columnas2];
            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas2; j++)
                {
                    sumMatrix[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("La suma de las matrices es:");
            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas2; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}