using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Definir las dimensiones de la matriz
        Console.Write("Un NxN matriz de numeros complejos, " +
            "que numero quisiera que sera el numero de la matriz: ");
        int Numero = int.Parse(Console.ReadLine());

        // Crear la matriz de números complejos
        Complex[,] matriz = new Complex[Numero, Numero];

        // Llenar la matriz con números complejos
        for (int i = 0; i < Numero; i++)
        {
            for (int j = 0; j < Numero; j++)
            {
                double real = GenerarNumeroAleatorio();
                double imaginario = GenerarNumeroAleatorio();
                matriz[i, j] = new Complex(real, imaginario);
            }
        }

        Console.WriteLine("Matriz de números complejos:");
        for (int i = 0; i < Numero; i++)
        {
            for (int j = 0; j < Numero; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static double GenerarNumeroAleatorio()
    {
        Random rnd = new Random();
        return rnd.NextDouble() * 10 - 5; // Genera un número aleatorio en el rango
    }
}
