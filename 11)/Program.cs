using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las dimensiones de la matriz:");//Declarar variables
        Console.Write("Número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese los elementos de la matriz:");
        int[,] matriz = LeerMatriz(filas, columnas);

        Console.Write("Ingrese el número escalar para multiplicar la matriz: ");
        int escalar = int.Parse(Console.ReadLine());

        int[,] resultado = MultiplicarMatrizPorEscalar(matriz, filas, columnas, escalar);

        Console.WriteLine($"La matriz resultante de multiplicar por {escalar} es:");
        MostrarMatriz(resultado, filas, columnas);

        Console.ReadKey();
    }

    static int[,] LeerMatriz(int filas, int columnas)//INGRESA LOS NÚMEROS POR CONSOLA
    {
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matriz;
    }

    static int[,] MultiplicarMatrizPorEscalar(int[,] matriz, int filas, int columnas, int escalar)//MULTPLICA LA MATRIZ CON EL NÚMERO ESCALAR
    {
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz[i, j] * escalar;
            }
        }

        return resultado;
    }

    static void MostrarMatriz(int[,] matriz, int filas, int columnas)//IMPRIME LA MATRIZ
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
