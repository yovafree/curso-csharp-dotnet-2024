namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();

            estudiante1.mostrarInformacionEstudiante();

            Estudiante estudiante2 = new Estudiante(2,
                "Leonel",
                "Ramos",
                "Graduado",
                "N/A",
                new DateTime(1999, 02, 03),
                "110002133");

            estudiante2.mostrarInformacionEstudiante();

            Estudiante estudiante3 = new Estudiante(3,"Pedro","Ibañez");

            estudiante3.mostrarInformacionEstudiante();



        }
    }
}
