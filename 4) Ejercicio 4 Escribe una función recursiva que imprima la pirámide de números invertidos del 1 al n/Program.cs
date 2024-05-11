using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte el número de la pirámide que quiera: ");
            int n = int.Parse(Console.ReadLine());
            ImprimirPiramideInvertida(n, 1);
        }

        public static void ImprimirPiramideInvertida(int n, int m) // Imprime filas de la pirámide
        {
            if (m > n)
            {
                return;
            }

            // Llamada recursiva para imprimir la siguiente fila de la pirámide invertida
            ImprimirPiramideInvertida(n, m + 1);

            // Imprimir espacios en blanco para alinear los números en la fila actual
            ImprimirEspacios(n - m);

            // Llamada recursiva para imprimir los números en la fila actual
            ImprimirNumeros(1, m);

            Console.WriteLine(); // Salto de línea después de imprimir la fila
        }

        public static void ImprimirEspacios(int contador) // Imprime la cantidad de espacios en blanco
        {
            if (contador <= 0)
            {
                return;
            }

            Console.Write(" "); // Imprimir un espacio en blanco
            ImprimirEspacios(contador - 1);
        }

        public static void ImprimirNumeros(int inicio, int final) // Imprime los números consecutivos
        {
            if (inicio > final)
            {
                return;
            }

            Console.Write(inicio + " "); // Imprimir el número actual seguido de un espacio
            ImprimirNumeros(inicio + 1, final); // Llamada recursiva para imprimir el siguiente número
        }
    }
