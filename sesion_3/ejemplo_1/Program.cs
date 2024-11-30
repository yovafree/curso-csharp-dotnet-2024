public class Program
{
    public static void Main()
    {
        // Estrucutra de control if

        int numero = 10;

        if (numero == 0)
        {
            Console.WriteLine("El número es igual a 0");
        }
        else if (numero > 0)
        {
            Console.WriteLine("El número es mayor a 0");
        }
        else
        {
            Console.WriteLine("El número es menor a 0");
        }

        // Estructura de control switch

        int dia = 7;

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Día no válido");
                break;
        }
    }
}