using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir las dimensiones de la matriz
        Console.Write("El numero de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("El numero de columnas: ");
        int columnas = int.Parse(Console.ReadLine());
        Console.Write("El rango de numeros que quisieras que haya: ");
        int rango=int.Parse(Console.ReadLine());

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con valores aleatorios
        Random rnd = new Random();
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(0, rango+1);
            }
        }

        Console.WriteLine("Matriz de números enteros:");
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
