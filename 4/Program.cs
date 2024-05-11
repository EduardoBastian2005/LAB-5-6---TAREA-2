using System;
namespace RecursiInvertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte hasta que numero n quisiera que se imprima la piramide: ");
            int n = int.Parse(Console.ReadLine());
            ImprimirPiramideInvertida(n, 1);
        }

        public static void ImprimirPiramideInvertida(int n, int m)//Imprime filas de la piramide
        {
            if (m > n)
            {
                return;
            }

            ImprimirPiramideInvertida(n, m + 1);

            ImprimirEspacios(n - m);

            ImprimirNumeros(1, m);

            Console.WriteLine(); // Salto de línea después de imprimir la fila
        }

        public static void ImprimirEspacios(int contador)//Imprime la cantidad de espacios en blanco
        {
            if (contador <= 0)
            {
                return;
            }

            Console.Write(" "); // Imprimir un espacio en blanco
            ImprimirEspacios(contador - 1);
        }

        public static void ImprimirNumeros(int inicio, int final)//Imprime los números consecutivos
        {
            if (inicio > final)
            {
                return;
            }

            Console.Write(inicio + " "); // el numero actual + un espacio
            ImprimirNumeros(inicio + 1, final); //para la impresion recursiba 
        }
    }
}