class Program
{
    static void Main()
    {
        // Crear un ciclo For que nos muestre una tabla de multiplicar de un número ingresado por el usuario

        // Pedir al usuario que ingrese un número
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(System.Console.ReadLine());

        // Crear un ciclo For que nos muestre la tabla de multiplicar del número ingresado
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }

        // Generar un listado de números entre el 0 y el 100000 de números primos utilizando el ciclo While

        // Crear un ciclo While que nos muestre los números primos entre el 0 y el 100000
        int contador = 0;
        int numeroPrimo = 0;
        while (numeroPrimo <= 100000)
        {
            if (numeroPrimo == 0 || numeroPrimo == 1)
            {
                numeroPrimo++;
                continue;
            }

            bool esPrimo = true;
            for (int i = 2; i <= numeroPrimo / 2; i++)
            {
                if (numeroPrimo % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine(numeroPrimo);
                contador++;
            }

            numeroPrimo++;
        }
    }
}