using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("MATRIZ DE MATRICES");
        Console.Write("Inserte el numero de las filas que desea: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Inserte el numero de las columas que desea: ");
        int columnas = int.Parse(Console.ReadLine());

        int[][][] matrizDeMatrices = new int[filas][][];


        for (int i = 0; i < filas; i++)
        {
            matrizDeMatrices[i] = new int[columnas][];
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el número de elementos para la matriz en la posición [{i},{j}]: ");
                int numElementos = int.Parse(Console.ReadLine());

                matrizDeMatrices[i][j] = new int[numElementos];
                Console.WriteLine($"Ingrese los {numElementos} elementos para la matriz en la posición [{i},{j}]:");
                for (int k = 0; k < numElementos; k++)
                {
                    Console.Write($"Elemento {k + 1}: ");
                    matrizDeMatrices[i][j][k] = int.Parse(Console.ReadLine());
                }
            }
        }

        Console.WriteLine("\nMatriz de Matrices ingresada:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"[{i},{j}]: ");
                MostrarMatriz(matrizDeMatrices[i][j]);
                Console.WriteLine();
                Console.WriteLine();

                Console.ReadKey();
            }
            // Método para mostrar una matriz (array)
            static void MostrarMatriz(int[] matriz)
            {
                Console.Write("[");
                for (int i = 0; i < matriz.Length; i++)
                {
                    Console.Write(matriz[i]);
                    if (i < matriz.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");

            }
        }
    }
}