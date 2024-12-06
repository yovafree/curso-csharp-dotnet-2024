namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.seccion = "A";

            Console.WriteLine(estudiante.seccion);
        }
    }
}
