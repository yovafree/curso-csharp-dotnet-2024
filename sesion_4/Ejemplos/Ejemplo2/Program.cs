namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.mostrarInformacionEstudiante();

            Console.WriteLine($"La edad del estudiante {estudiante.obtNombreCompleto()}, es {estudiante.obtEdad()}");
            
            Console.WriteLine($"La edad del estudiante {estudiante.obtNombreCompleto()}, es {estudiante.obtEdad(1998)}");

            Console.WriteLine($"La edad del estudiante {estudiante.obtNombreCompleto()}, es {estudiante.obtEdad("1989")}");

            var numALetras = Herramientas.Convertir(1500);

            Console.WriteLine($"{numALetras}");

            Console.WriteLine($"{Herramientas.Convertir(500)}");

            Console.WriteLine($"{Herramientas.Convertir(150)}");

            Console.WriteLine($"{Herramientas.Convertir(92)}");
        }
    }
}
