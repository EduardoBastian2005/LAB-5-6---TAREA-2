using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escriba hasta qué número del 1 al n quisiera imprimir: ");
        int n = int.Parse(Console.ReadLine());
        int M = 1;

        for (int i = 1; i <= n; i++)
        {
            M = M * i;
        }

        Console.WriteLine("El factorial de " + n + " es: " + M);
    }
}
