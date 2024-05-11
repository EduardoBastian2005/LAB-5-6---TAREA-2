using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] X = { { 10, 20, 3 }, { 14, 5, 6 }, { 17, 8, 9 } };
            int[,] Y = { { 9, 8, 7 }, { 6, 5, 14 }, { 3, 2, 1 } };

            double[,] covXY = CalcularMatrizCovarianza(X, Y);

            Console.WriteLine("Matriz de Covarianza entre X y Y:");
            MostrarMatriz(covXY);
        }

        // calcula  la matriz de covarianza entre dos matrices X y Y
        static double[,] CalcularMatrizCovarianza(int[,] X, int[,] Y)
        {
            int m = X.GetLength(0);
            int n = X.GetLength(1);

            double[] meanX = CalcularMediaPorColumna(X);
            double[] meanY = CalcularMediaPorColumna(Y);

            // Inicializar la matriz de covarianza
            double[,] covXY = new double[n, n];

            // Resolver
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    double sum = 0;

                    for (int i = 0; i < m; i++)
                    {
                        sum += (X[i, j] - meanX[j]) * (Y[i, k] - meanY[k]);
                    }

                    covXY[j, k] = sum / m;
                }
            }

            return covXY;
        }

        // calcula la media por columna de una matriz
        static double[] CalcularMediaPorColumna(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[] mean = new double[cols];

            for (int j = 0; j < cols; j++)
            {
                double sum = 0;

                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }

                mean[j] = sum / rows;
            }

            return mean;
        }

        static void MostrarMatriz(double[,] matriz)//Imprime la matriz
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

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
}