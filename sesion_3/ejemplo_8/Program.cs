// Lista de números enteros, y genera un programa para asignar dinámicamente más numeros a la lista.

using System;

namespace ejemplo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de números enteros
            List<int> numeros = new List<int>();

            // Agregar números a la lista
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            // Mostrar los números de la lista
            Console.WriteLine("Lista de números:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Agregar más números a la lista
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            // Mostrar los números de la lista
            Console.WriteLine("Lista de números:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}