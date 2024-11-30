// Mostrar diferentes formas de inicializar un arreglo de enteros

using System;

namespace ejemplo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un arreglo de enteros
            int[] arreglo1 = new int[5];
            int[] arreglo2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arreglo3 = { 1, 2, 3, 4, 5 };

            // Mostrar los elementos de los arreglos
            Console.WriteLine("Elementos del arreglo1:");
            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine(arreglo1[i]);
            }

            Console.WriteLine("Elementos del arreglo2:");
            for (int i = 0; i < arreglo2.Length; i++)
            {
                Console.WriteLine(arreglo2[i]);
            }

            Console.WriteLine("Elementos del arreglo3:");
            for (int i = 0; i < arreglo3.Length; i++)
            {
                Console.WriteLine(arreglo3[i]);
            }
        }
    }
}
