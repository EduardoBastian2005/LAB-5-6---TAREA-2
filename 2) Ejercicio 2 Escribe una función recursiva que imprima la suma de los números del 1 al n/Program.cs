using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe hasta qué número quisiera imprimir: ");
        int suma = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i = i + 1)
        {
            suma = suma + i;
        }
        Console.WriteLine("La suma de los números hasta " + n + " es: " + suma);
    }
}
