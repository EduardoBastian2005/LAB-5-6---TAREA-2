                sum += num;
            }

            return (double)sum / contador;
        }

        // Calcula la mediana de los elementos de la matriz
        static int CalcularMediana(int[,] matrix)
        {
            // Crear una lista para almacenar todos los elementos de la matriz
            List<int> elementos = new List<int>();

            foreach (int num in matrix)
            {
                elementos.Add(num);
            }

            // Ordenar la lista de elementos
            elementos.Sort();

            int n = elementos.Count;
            if (n % 2 == 1)
            {
                return elementos[n / 2];
            }
            else
            {
                return (elementos[n / 2 - 1] + elementos[n / 2]) / 2;
            }
        }

        //Calcula la desviación estándar de los elementos de la matriz
        static double CalcularDesviacionEstandar(int[,] matriz, double media)
        {
            int count = matriz.GetLength(0) * matriz.GetLength(1);
            double sumOfSquares = 0;

            foreach (int num in matriz)
            {
                sumOfSquares += Math.Pow(num - media, 2);
            }

            double variance = sumOfSquares / contador;
            return Math.Sqrt(variance);
        }
    }
}