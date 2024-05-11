using System;
namespace RecursiPirámide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe el numero de numeros de la piramide n: ");
            int n = int.Parse(Console.ReadLine());
            ImprimirPiramide(n, 1); // Llamada inicial  para imprimir la pirámide
        }

        public static void ImprimirPiramide(int n, int m)//Imprime las filas de la pirámide
        {
            if (m > n)
            {
                return;
            }
            ImprimirEspacios(n - m);

            ImprimirNumeros(1, m);

            Console.WriteLine(); // para a la siguiente dile

            // Llamada recursiva para imprimir la siguiente fila de la pirámide
            ImprimirPiramide(n, m + 1);
        }

        public static void ImprimirEspacios(int contador)//Imprime una cantidad de espacios blanco
        {
            if (contador <= 0)
            {
                return;
            }

            Console.Write(" "); // Imprimir un espacio en blanco
            ImprimirEspacios(contador - 1); // Llamada recursiva para imprimir el siguiente espacio
        }

        public static void ImprimirNumeros(int inicio, int final)//Imprime números consecutivos
        {
            if (inicio > final)
            {
                return;
            }

            Console.Write(inicio + " "); // Imprimir el número actual seguido de un espacio
            ImprimirNumeros(inicio + 1, final); // Llamada recursiva para imprimir el siguiente número
        }
    }
}
