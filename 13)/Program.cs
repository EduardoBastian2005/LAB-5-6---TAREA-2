using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3] { { 10, 20, 35 }, { 14, 15, 6 }, { 7, 18, 9 } };
            double media = CalcularMedia(matriz);
            Console.WriteLine($"La media de los elementos de la matriz es: {media}");
        }

        static double CalcularMedia(int[,] matriz)
        {
            int suma = 0;
            int total = matriz.Length;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
            }

            return (double)suma / total;
        }
    }
}