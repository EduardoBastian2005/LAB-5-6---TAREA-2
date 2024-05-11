using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe hasta qué número quisiera imprimir: ");
        int n = int.Parse(Console.ReadLine());
        // Hacer que cuente hasta 100 y solo imprima pares
        for (int i = 2; i < n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
